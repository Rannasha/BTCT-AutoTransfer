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
        private const string _consumerKey = "20bd6751441ff12b98117f4be1c09a9371de4cf7";
        private const string _consumerSecret = "0949565dac0d493501a84cbab79a0f9eb6c936a9";

        // LTC-Global
     //   private const string _consumerKey = "e16d295063cb4e22fb6247e2e8b094deef601183";
     //  private const string _consumerSecret = "0394390ae938a512de7bdd150c693819c9c58a58";

        private BTCTLink b;

        public BTCTC_MainWindow()
        {
            InitializeComponent();

            OnAuthStatusChanged(null, EventArgs.Empty);

            // Change 3rd argument to "false" for LTC-Global
            b = new BTCTLink(_consumerKey, _consumerSecret, true, DebugToTextBox);
            b.AuthStatusChanged += OnAuthStatusChanged;
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

        private void DebugToTextBox(string msg)
        {
   //         Log(msg + Environment.NewLine, true);
        }

        private void OnAuthStatusChanged(object sender, EventArgs e)
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
                    button1.Enabled = true;
                    button2.Enabled = false;
                    textBox3.ReadOnly = true;
                    textBox2.Text = "None";
                    break;
                case AuthStatusType.AS_REQRCV:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    textBox3.ReadOnly = false;
                    textBox2.Text = "Req-rcv";
                    break;
                case AuthStatusType.AS_OK:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    textBox3.ReadOnly = true;
                    textBox2.Text = "Authorized";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.GetRequestToken();
            MessageBox.Show("After authorizing BTCT-Client in the browser window that just opened, copy/paste the \"oauth_verifier\" into the \"Verifier\" textbox and click \"Authorize\"", "BTCT-Client: Authorization in progress", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b.GetAccessToken(textBox3.Text);
            Portfolio p = b.GetPortfolio();
            b.ApiKey = p.apiKey;
            textBox1.Text = b.ApiKey;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b.DeserializeConfig("btct-client.dat");
            textBox1.Text = b.ApiKey;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b.ApiKey = textBox1.Text;
            b.SerializeConfig("btct-client.dat");
        }

        #region DMS Auto-Transfer functions
        System.Timers.Timer updateTimer;
        int interval, maxQuantity;
        bool readOnly, singleUser, qtyLimit;
        string singleUserName;
        DateTime lastUpdate;

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

            if (cbCustomStartTime.Checked)
            {
                DateTime d = dtpCustomStartDate.Value;
                DateTime ti = dtpCustomStartTime.Value;

                DateTime d0 = new DateTime(d.Year, d.Month, d.Day, ti.Hour, ti.Minute, ti.Second);

                if (d0.CompareTo(DateTime.Now) > 0)
                {
                    Log("Can't select custom starting date/time in the future. Aborting.", false);
                    btnAutoTransferStop_Click(sender, e);
                    return;
                }
            }


        } 

        private void btnAutoTransferStop_Click(object sender, EventArgs e)
        {
            bool cs = cbCustomStartTime.Checked;

            updateTimer.Enabled = false;

            lbInterval.Enabled = true;
            tbInterval.Enabled = true;
            cbReadOnly.Enabled = true;
            cbSingleUser.Enabled = !readOnly;
            lbSingleUserName.Enabled = !readOnly && singleUser;
            tbSingleUserName.Enabled = !readOnly && singleUser;
            
            cbMaxQuantity.Enabled = !readOnly;
            tbMaxQuantity.Enabled = !readOnly && qtyLimit;
            lbMaxQuantity.Enabled = !readOnly && qtyLimit;

            cbCustomStartTime.Enabled = true;
            dtpCustomStartDate.Enabled = cs;
            dtpCustomStartTime.Enabled = cs;

            btnAutoTransferStart.Enabled = true;
            btnAutoTransferStop.Enabled = false;
        }

        private void doUpdate(object sender, ElapsedEventArgs e)
        {
            string input = "DMS.PURCHASE";
            string[] output = { "DMS.MINING", "DMS.SELLING" };
            
            Log("Update started at " + DateTime.Now.ToString() + Environment.NewLine, true);
            
            TradeHistory t;
            try
            {
                t = b.GetTradeHistory();
            }
            catch (BTCTException ex)
            {
                Log("Error obtaining trade history. Message: " + ex.Message + Environment.NewLine, true);
                return;
            }
            if (lastUpdate.CompareTo(t.orders[t.orders.Count - 1].dateTime) > 0)
            {
                Log("ERROR: Newest order in latest update older than in previous update. Aborting auto-transfer.", true);
                btnAutoTransferStop_Click(this, e);
                return;
            }
            foreach (Order o in t.orders)
            {
                if (o.dateTime.CompareTo(lastUpdate) > 0
                    && o.orderType == OrderType.OT_TIN
                    && o.security.name == input)
                {
                    int num = o.amount;
                    string username = o.transferUser;
                    Log("TX-IN: " + num.ToString() + " x " + o.security.name + " <- " + username + Environment.NewLine, true);
                    foreach (string s in output)
                    {
                        try
                        {
                            if (!readOnly)
                            {
                                if ( (!singleUser || singleUserName == username) && (!qtyLimit || num <= maxQuantity) )
                                {
                                    b.TransferAsset(s, num, username, 0);
                                }
                            }
                            if (readOnly || (singleUser && singleUserName != username) || (qtyLimit && num > maxQuantity))
                            {
                                Log("(not executed) ", true);
                            }
                            Log("TX-OUT: " + num.ToString() + " x " + s + " -> " + username + Environment.NewLine, true);
                        }
                        catch (BTCTException ex)
                        {
                            Log("ERROR: " + ex.Message + Environment.NewLine, true);
                        }
                    }
                }
            }

            lastUpdate = t.orders[t.orders.Count - 1].dateTime;
            Log("Update completed at " + DateTime.Now.ToString() + Environment.NewLine, true);
            Log("Most recent trade was at " + t.orders[t.orders.Count - 1].dateTime.ToString() + " (server time)" + Environment.NewLine, true);
        }
        #endregion
    }
}
