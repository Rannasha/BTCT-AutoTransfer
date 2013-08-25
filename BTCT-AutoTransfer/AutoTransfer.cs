using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace BTCTC
{
    class NameLink
    {
        public string LTCName { get; set; }
        public string BTCName { get; set; }

        public NameLink(string b, string l)
        {
            LTCName = l;
            BTCName = b;
        }

    }

    class NameDB
    {
        private List<NameLink> _names = new List<NameLink>();

        public NameLink this[int pos]
        {
            get
            {
                return _names[pos];
            }
            set
            {
                _names[pos] = value;
            }
        }
        
        public void Add(NameLink n)
        {
            _names.Add(n);
        }
        public void Add(string b, string l)
        {
            NameLink n = new NameLink(b, l);
            this.Add(n);
        }

        public void LoadFromFile(string fileName)
        {
            string [] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string s in lines)
            {
                string [] fields = s.Split(null);
                Add(fields[0], fields[1]);
            }
        }

        public string QueryName(string srcName, bool BTCtoLTC)
        {
            for (int i = 0; i < _names.Count; i++)
            {
                string n = BTCtoLTC ? _names[i].BTCName : _names[i].LTCName;
                if (n == srcName)
                {
                    return BTCtoLTC ? _names[i].LTCName : _names[i].BTCName;
                }
            }
            return "";
        }
    }

    class TransferRule
    {
        // BTCTLink for outgoing transfers
        public BTCTLink OutLink { get; set; }

        // Assets to receive and send. One output asset per
        // instance of TransferRule. For 1 -> n transfers (n > 1),
        // create multiple instances of TransferRule.
        public string Input { get; set; }
        public string Output { get; set; }

        // Minimum number of units before an conversion is processed.
        // Any incoming transfers below the minimum is returned to sender.
        public int MinInput { get; set; }

        // Transfer-fee (in number of units) to be deducted. FeeInput specifies
        // whether the fee is deducted from the input or output.
        public int Fee { get; set; }
        public bool FeeInput { get; set; }

        public int Multiplier { get; set; }
        public bool MultInput { get; set; }

        public TransferRule(BTCTLink outLink, string input, string output, int minInput, int fee, bool feeInput, int multiplier, bool multInput)
        {
            OutLink = outLink;
            Input = input;
            Output = output;
            MinInput = minInput;
            Fee = fee;
            FeeInput = feeInput;
            Multiplier = multiplier;
            MultInput = multInput;
        }
        public TransferRule()
        {
        }

        // Examples:
        // 100 shares of A can be exchanged for 1 share of B. A fixed fee of 1
        // share of A applies.
        // Input = A;
        // Output = B;
        // MinInput = 101;
        // Fee = 1;
        // FeeInput = true;
        // Multiplier = 100;
        // MultInput = false;
        //
        // 1 share of A can be exchanged for 100 shares of B. A fixed fee of 1
        // share of B applies.
        // Input = A;
        // Output = B;
        // MinInput = 1;
        // Fee = 1;
        // FeeInput = false;
        // Multiplier = 100;
        // MultInput = true;

        public int CalcTransferUnits(int inUnits)
        {
            if (inUnits < MinInput)
            {
                return 0;
            }

            int n = inUnits;

            if (FeeInput)
            {
                n -= Fee;
            }
            if (MultInput)
            {
                n *= Multiplier;
            }
            else
            {
                n /= Multiplier;
            }
            if (!FeeInput)
            {
                n -= Fee;
            }

            return n;
        }

        public int CalcReturnUnits(int inUnits)
        {
            if (inUnits < MinInput)
            {
                return inUnits;
            }
            if (MultInput)
            {
                return 0;
            }

            int n = inUnits % Multiplier;

            if (FeeInput)
            {
                n -= Fee;
            }

            return n;
        }
    }

    class AutoTransfer
    {
        static private NameDB _nameDB;

        private System.Timers.Timer _timer;
        private int _interval;
        private bool _active;
        private BTCTLink _inLink;
        private DateTime _lastUpdate;
        private System.ComponentModel.ISynchronizeInvoke _syncObj;
        private string _sitePrefix;

        private List<TransferRule> _transferRules = new List<TransferRule>();
        public bool Active
        {
            get
            {
                return _active;
            }
        }
        public bool ReadOnly { get; set; }
        public bool SingleUser { get; set; }
        public string SingleUserName { get; set; }
        public bool QtyLimit { get; set; }
        public int MaxQuantity { get; set; }
        public int Interval
        {
            get
            {
                return _interval;
            }
            set
            {
                if (Active)
                {
                    StopTimer();
                    _interval = value;
                    StartTimer(false, DateTime.Now, _syncObj);
                }
                else
                {
                    _interval = value;
                }
            }
        }

        public BTCTLink InLink
        {
            get
            {
                return _inLink;
            }
        }

        public DebugHandler Logger { get; set; }

        public AutoTransfer(BTCTLink inLink, int interval)
        {
            _inLink = inLink;
            _interval = interval;

            _timer = new System.Timers.Timer();
            _timer.Interval = interval;

            _active = false;

            _nameDB = new NameDB();

            if (_inLink.isBTCT)
            {
                _sitePrefix = "(B) ";
            }
            else
            {
                _sitePrefix = "(L) ";
            }
        }
        public AutoTransfer(BTCTLink inLink, int interval, string nameFile) : this(inLink, interval)
        {
            _nameDB.LoadFromFile(nameFile);
        }

        static public void ReadNameDB(string filename)
        {
            _nameDB = new NameDB();
            _nameDB.LoadFromFile(filename);
        }

        public void Log(string msg)
        {
            if (Logger != null)
            {
                Logger(msg);
            }
        }

        public void AddRule(TransferRule t)
        {
            _transferRules.Add(t);
        }

        public void StartTimer(bool customStart, DateTime start, System.ComponentModel.ISynchronizeInvoke s)
        {
            if (_active)
            {
                Log("Attempt to start timer that is already running." + Environment.NewLine);
                return;
            }
            if (_inLink.AuthStatus != AuthStatusType.AS_OK)
            {
                Log("Not yet authorized." + Environment.NewLine);
                return;
            }
            
            if (_interval < 120000)
            {
                Log("Interval too short, needs to be at least 2 minutes" + Environment.NewLine);
                return;
            }

            _timer.Interval = _interval;
            _timer.SynchronizingObject = s;
            _syncObj = s;
            _timer.Elapsed += new ElapsedEventHandler(DoUpdate);
            _timer.Enabled = true;
            _active = true;

            if (customStart)
            {
                _lastUpdate = start;
                Log(_sitePrefix + "Starting auto-transfer at " + DateTime.Now.ToString() + Environment.NewLine +
                    "Starting from custom date/time: " + start.ToString() + Environment.NewLine +
                    "Running update function to clear back-log" + Environment.NewLine);

                DoUpdate(this, null);
            }
            else
            {
                TradeHistory t;

                try
                {
                    t = _inLink.GetTradeHistory();
                    _lastUpdate = t.orders[t.orders.Count - 1].dateTime;
                    Log(_sitePrefix + "Starting auto-transfer at " + DateTime.Now.ToString() + Environment.NewLine
                        + _sitePrefix + "Most recent entry in trade history at " + _lastUpdate.ToString() + " (server time)" + Environment.NewLine);
                }
                catch (BTCTException ex)
                {
                    Log(_sitePrefix + "Error obtaining initial trade history - Timer aborted. Message: " + ex.Message + Environment.NewLine);
                    StopTimer();
                    return;
                }
            }
        }

        public void StopTimer()
        {
            if (_active)
            {
                Log(_sitePrefix + "Auto-transfer stopped at " + DateTime.Now.ToString() + Environment.NewLine);
                _timer.Enabled = false;
                _active = false;
            }
        }

        private bool isTestMode(string username, int num)
        {
            if (!ReadOnly)
            {
                if ((!SingleUser || SingleUserName == username) && (!QtyLimit || num <= MaxQuantity))
                {
                    return false;
                }
            }
            return true;
        }

        private void DoTransfer(string security, int amount, string username, BTCTLink link)
        {
            if (!isTestMode(username, amount))
            {
                link.TransferAsset(security, amount, username, 0);
            }
            else
            {
                Log("(not executed) ");
            }
            Log("TX-OUT: " + amount.ToString() + " x " + security + " -> " + username + Environment.NewLine);
        }

        private void DoUpdate(object sender, ElapsedEventArgs e)
        {
            Log(_sitePrefix + "Update started at " + DateTime.Now.ToString() + Environment.NewLine);

            TradeHistory t;
            try
            {
                t = _inLink.GetTradeHistory();
            }
            catch (BTCTException ex)
            {
                Log(_sitePrefix + "Error obtaining trade history. Message: " + ex.Message + Environment.NewLine);
                return;
            }
            if (_lastUpdate.CompareTo(t.orders[t.orders.Count - 1].dateTime) > 0)
            {
                Log(_sitePrefix + "ERROR: Newest order in latest update older than in previous update. Aborting auto-transfer.");
                StopTimer(); 
                return;
            }
            foreach (Order o in t.orders)
            {
                if ((o.dateTime.CompareTo(_lastUpdate) <= 0)
                    || o.orderType != OrderType.OT_TIN)
                {
                    continue;
                }
                
                int num = o.amount;
                string username = o.transferUser;

                Log("TX-IN: " + num.ToString() + " x " + o.security.name + " <- " + username + Environment.NewLine);

                foreach (TransferRule tr in _transferRules)
                {
                    // Transfered security doesn't match input
                    if (o.security.name != tr.Input)
                    {
                        continue;
                    }
                    
                    int numTransfer = tr.CalcTransferUnits(num);
                    int numReturn = tr.CalcReturnUnits(num);

                    string targetUsername = username;

                    // If in and out aren't on the same exchange, query the name-DB
                    if (_inLink.isBTCT != tr.OutLink.isBTCT)
                    {
                        targetUsername = _nameDB.QueryName(username, _inLink.isBTCT);
                        
                        // No matching user was found - return all shares
                        if (targetUsername == "")
                        {
                            Log("User \"" + username + "\" has no matching username in name-db." + Environment.NewLine);
                            numTransfer = 0;
                            numReturn = num;
                        }
                    }

                    if (numReturn > 0)
                    {
                        try
                        {
                            DoTransfer(tr.Input, numReturn, username, _inLink);
                        }
                        catch (BTCTException ex)
                        {
                            Log("ERROR: " + ex.Message + Environment.NewLine);
                        }
                    }
                    if (numTransfer > 0)
                    {
                        try
                        {
                            DoTransfer(tr.Output, numTransfer, targetUsername, tr.OutLink);
                        }
                        catch (BTCTException ex)
                        {
                            Log("ERROR: " + ex.Message + Environment.NewLine);
                        }
                    }

                }
            }

            _lastUpdate = t.orders[t.orders.Count - 1].dateTime;
            Log(_sitePrefix + "Update completed at " + DateTime.Now.ToString() + Environment.NewLine);
            Log(_sitePrefix + "Most recent trade was at " + t.orders[t.orders.Count - 1].dateTime.ToString() + " (server time)" + Environment.NewLine);
        }
    }
}
