using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Web;
using OAuth;

namespace BTCTC
{
    public partial class BTCTC_MainWindow : Form
    {
        // BTCT
        private const string BconsumerKey = "20bd6751441ff12b98117f4be1c09a9371de4cf7";
        private const string BconsumerSecret = "0949565dac0d493501a84cbab79a0f9eb6c936a9";

        // LTC-Global
        private const string LconsumerKey = "e16d295063cb4e22fb6247e2e8b094deef601183";
        private const string LconsumerSecret = "0394390ae938a512de7bdd150c693819c9c58a58";

        private BTCTLink b, l;

        public BTCTC_MainWindow()
        {
            InitializeComponent();

            OnBAuthStatusChanged(null, EventArgs.Empty);
            OnLAuthStatusChanged(null, EventArgs.Empty);

            b = new BTCTLink(BconsumerKey, BconsumerSecret, true, DebugToTextBox);
            b.AuthStatusChanged += OnBAuthStatusChanged;
            
            l = new BTCTLink(LconsumerKey, LconsumerSecret, false, DebugToTextBox);
            l.AuthStatusChanged += OnLAuthStatusChanged;
        }

        private void Log(string s, bool toFile)
        {
            if (toFile)
            {
                using (StreamWriter sw = new StreamWriter("log.txt", true))
                {
                    sw.Write(s);
                }
            }

            tbOutput.AppendText(s);
        }

        private void ATLog(string msg)
        {
            Log(msg, true);
        }

        private void DebugToTextBox(string msg)
        {
         //   Log(msg, true);
        }

        private void OnBAuthStatusChanged(object sender, EventArgs e)
        {
            AuthStatusChangedEventArgs ea;

            if (e.Equals(EventArgs.Empty))
            {
                ea = new AuthStatusChangedEventArgs(AuthStatusType.AS_NONE);
            }
            else
            {
                ea = (AuthStatusChangedEventArgs)e;
            }

            switch (ea.AuthStatus)
            {
                case AuthStatusType.AS_NONE:
                    tbBConnect.Enabled = true;
                    tbBAuth.Enabled = false;
                    tbBVerifier.ReadOnly = true;
                    tbBAuthStatus.Text = "None";
                    break;
                case AuthStatusType.AS_REQRCV:
                    tbBConnect.Enabled = true;
                    tbBAuth.Enabled = true;
                    tbBVerifier.ReadOnly = false;
                    tbBAuthStatus.Text = "Req-rcv";
                    break;
                case AuthStatusType.AS_OK:
                    tbBConnect.Enabled = false;
                    tbBAuth.Enabled = false;
                    tbBVerifier.ReadOnly = true;
                    tbBAuthStatus.Text = "Authorized";
                    break;
            }
        }

        private void OnLAuthStatusChanged(object sender, EventArgs e)
        {
            AuthStatusChangedEventArgs ea;

            if (e.Equals(EventArgs.Empty))
            {
                ea = new AuthStatusChangedEventArgs(AuthStatusType.AS_NONE);
            }
            else
            {
                ea = (AuthStatusChangedEventArgs)e;
            }

            switch (ea.AuthStatus)
            {
                case AuthStatusType.AS_NONE:
                    btnLConnect.Enabled = true;
                    btnLAuth.Enabled = false;
                    tbLVerifier.ReadOnly = true;
                    tbLAuthStatus.Text = "None";
                    break;
                case AuthStatusType.AS_REQRCV:
                    btnLConnect.Enabled = true;
                    btnLAuth.Enabled = true;
                    tbLVerifier.ReadOnly = false;
                    tbLAuthStatus.Text = "Req-rcv";
                    break;
                case AuthStatusType.AS_OK:
                    btnLConnect.Enabled = false;
                    btnLAuth.Enabled = false;
                    tbLVerifier.ReadOnly = true;
                    tbLAuthStatus.Text = "Authorized";
                    break;
            }
        }

        #region BTCT Connection/auth button-handlers
        private void btnBConnect_Click(object sender, EventArgs e)
        {
            b.GetRequestToken();
            MessageBox.Show("After authorizing BTCT-Client in the browser window that just opened, copy/paste the \"oauth_verifier\" into the \"Verifier\" textbox and click \"Authorize\"", "BTCT-Client: Authorization in progress", MessageBoxButtons.OK);
        }

        private void btnBAuth_Click(object sender, EventArgs e)
        {
            b.GetAccessToken(tbBVerifier.Text);
            Portfolio p = b.GetPortfolio();
            b.ApiKey = p.apiKey;
            tbBApiKey.Text = b.ApiKey;
        }

        private void btnBLoadToken_Click(object sender, EventArgs e)
        {
            b.DeserializeConfig("btct-client_B.dat");
            tbBApiKey.Text = b.ApiKey;
        }

        private void btnBSaveToken_Click(object sender, EventArgs e)
        {
            b.ApiKey = tbBApiKey.Text;
            b.SerializeConfig("btct-client_B.dat");
        }
        #endregion

        #region LTC-G connection/auth button-handlers
        private void btnLConnect_Click(object sender, EventArgs e)
        {
            l.GetRequestToken();
            MessageBox.Show("After authorizing BTCT-Client in the browser window that just opened, copy/paste the \"oauth_verifier\" into the \"Verifier\" textbox and click \"Authorize\"", "BTCT-Client: Authorization in progress", MessageBoxButtons.OK);
        }

        private void btnLAuth_Click(object sender, EventArgs e)
        {
            l.GetAccessToken(tbLVerifier.Text);
            Portfolio p = l.GetPortfolio();
            l.ApiKey = p.apiKey;
            tbLApiKey.Text = l.ApiKey;
        }

        private void btnLLoadToken_Click(object sender, EventArgs e)
        {
            l.DeserializeConfig("btct-client_L.dat");
            tbLApiKey.Text = l.ApiKey;
        }

        private void btnLSaveToken_Click(object sender, EventArgs e)
        {
            l.ApiKey = tbLApiKey.Text;
            l.SerializeConfig("btct-client_L.dat");
        }
        #endregion

        #region DMS Auto-Transfer functions
        int interval, maxQuantity;
        bool readOnly, singleUser, qtyLimit;
        string singleUserName;

        AutoTransfer aB, aL;

        private void cbReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            bool ro = cbReadOnly.Checked;
            bool su = cbSingleUser.Checked;
            bool mq = cbMaxQuantity.Checked;

            cbSingleUser.Enabled = !ro;
            tbSingleUserName.Enabled = !ro && su;
            lbSingleUserName.Enabled = !ro && su;

            cbMaxQuantity.Enabled = !ro;
            tbMaxQuantity.Enabled = !ro && mq;
            lbMaxQuantity.Enabled = !ro && mq;
        }

        private void cbSingleUser_CheckedChanged(object sender, EventArgs e)
        {
            bool su = cbSingleUser.Checked;

            tbSingleUserName.Enabled = su;
            lbSingleUserName.Enabled = su;
        }

        private void cbMaxQuantity_CheckedChanged(object sender, EventArgs e)
        {
            bool mq = cbMaxQuantity.Checked;

            tbMaxQuantity.Enabled = mq;
            lbMaxQuantity.Enabled = mq;
        }

        private void cbCustomStartTime_CheckedChanged(object sender, EventArgs e)
        {
            bool cs = cbCustomStartTime.Checked;

            dtpCustomStartDate.Enabled = cs;
            dtpCustomStartTime.Enabled = cs;
        }

        private void btnAutoTransferStart_Click(object sender, EventArgs e)
        {
            if (b.AuthStatus != AuthStatusType.AS_OK)
            {
                Log("Not yet authorized." + Environment.NewLine, false);
                return;
            }
            try
            {
                interval = Convert.ToInt32(tbInterval.Text);
            }
            catch (Exception ex)
            {
                Log("Invalid number-format in interval-input" + Environment.NewLine, false);
                return;
            }
            if (interval < 120000)
            {
                Log("Interval too short, needs to be at least 2 minutes" + Environment.NewLine, false);
                return;
            }

            readOnly = cbReadOnly.Checked;
            singleUser = cbSingleUser.Checked;
            if (singleUser)
                singleUserName = tbSingleUserName.Text;
            qtyLimit = cbMaxQuantity.Checked;
            if (qtyLimit)
            {
                try
                {
                    maxQuantity = Convert.ToInt32(tbMaxQuantity.Text);
                }
                catch (Exception ex)
                {
                    Log("Invalid number-format for max. quantity" + Environment.NewLine, false);
                    return;
                }
            }

            DateTime d = dtpCustomStartDate.Value;
            DateTime ti = dtpCustomStartTime.Value;

            DateTime d0 = new DateTime(d.Year, d.Month, d.Day, ti.Hour, ti.Minute, ti.Second);

            if (cbCustomStartTime.Checked && d0.CompareTo(DateTime.Now) > 0)
            {
                Log("Can't select custom starting date/time in the future. Aborting.", false);
                return;
            }

            aB = new AutoTransfer(b, interval);
            aB.ReadOnly = readOnly;
            aB.SingleUser = singleUser;
            aB.SingleUserName = singleUserName;
            aB.QtyLimit = qtyLimit;
            aB.MaxQuantity = maxQuantity;
            aB.Logger = ATLog;

            aL = new AutoTransfer(l, interval);
            aL.ReadOnly = readOnly;
            aL.SingleUser = singleUser;
            aL.SingleUserName = singleUserName;
            aL.QtyLimit = qtyLimit;
            aL.MaxQuantity = maxQuantity;
            aL.Logger = ATLog;

            // DMS.PURCHASE -> DMS.MINING + DMS.SELLING
            /* TransferRule t1 = new TransferRule(b, "DMS.PURCHASE", "DMS.MINING", 1, 0, true, 1, true);
            TransferRule t2 = new TransferRule(b, "DMS.PURCHASE", "DMS.SELLING", 1, 0, true, 1, true);
            aB.AddRule(t1);
            aB.AddRule(t2);
            */

            // ASICMINER-PT on LTC-Global
            TransferRule t1 = new TransferRule(l, "ASICMINER-PT", "TEST-ASICMINER", 1, 1, false, 100, true);
            aB.AddRule(t1);
            TransferRule t2 = new TransferRule(b, "TEST-ASICMINER", "ASICMINER-PT", 101, 1, true, 100, false);
            aL.AddRule(t2);

            aB.StartTimer(cbCustomStartTime.Checked, d0, this);
        } 

        private void btnAutoTransferStop_Click(object sender, EventArgs e)
        {
            aB.StopTimer();
            aL.StopTimer();
        }
        #endregion
    }
}
