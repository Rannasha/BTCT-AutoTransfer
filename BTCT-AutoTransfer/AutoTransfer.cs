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
        private List<NameLink> _names;

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
        public BTCTLink OutLink { get; set; }

        public string Input { get; set; }
        public string Output { get; set; }

        public int MinInput { get; set; }
        public bool FeeInput { get; set; }

        public int Multiplier { get; set; }
        public bool MultInput { get; set; }
    }

    class AutoTransfer
    {
        static private NameDB _nameDB;

        private System.Timers.Timer _timer;
        private int _interval;
        private bool _active;
        private BTCTLink _inLink;
        private DateTime _lastUpdate;

        private List<TransferRule> _transferRules;
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
                    StartTimer();
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
        }
        public AutoTransfer(BTCTLink inLink, int interval, string nameFile) : this(inLink, interval)
        {
            _nameDB.LoadFromFile(nameFile);
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

        public void Initialize()
        {
        }

        public void StartTimer()
        {
        }

        public void StopTimer()
        {
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

        private void DoUpdate()
        {
            Log("Update started at " + DateTime.Now.ToString() + Environment.NewLine);

            TradeHistory t;
            try
            {
                t = _inLink.GetTradeHistory();
            }
            catch (BTCTException ex)
            {
                Log("Error obtaining trade history. Message: " + ex.Message + Environment.NewLine);
                return;
            }
            if (_lastUpdate.CompareTo(t.orders[t.orders.Count - 1].dateTime) > 0)
            {
                Log("ERROR: Newest order in latest update older than in previous update. Aborting auto-transfer.");
                StopTimer(); 
                return;
            }
            foreach (Order o in t.orders)
            {
                if (o.dateTime.CompareTo(_lastUpdate) > 0
                    && o.orderType == OrderType.OT_TIN)
                {
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

                        // Insufficient quantity transfered - return to sender.
                        if (num < tr.MinInput)
                        {
                            try
                            {
                                DoTransfer(tr.Input, num, username, _inLink);
                            }
                            catch (BTCTException ex)
                            {
                                Log("ERROR: " + ex.Message + Environment.NewLine);
                            }
                            continue;
                        }


                    }
                }
            }

            _lastUpdate = t.orders[t.orders.Count - 1].dateTime;
            Log("Update completed at " + DateTime.Now.ToString() + Environment.NewLine);
            Log("Most recent trade was at " + t.orders[t.orders.Count - 1].dateTime.ToString() + " (server time)" + Environment.NewLine);
        }


    }
}
