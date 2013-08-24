namespace BTCTC
{
    partial class BTCTC_MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBConnect = new System.Windows.Forms.Button();
            this.tbBVerifier = new System.Windows.Forms.TextBox();
            this.tbBAuth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbBLoadToken = new System.Windows.Forms.Button();
            this.tbBSaveToken = new System.Windows.Forms.Button();
            this.tbBApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBAuthStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpCustomStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbCustomStartTime = new System.Windows.Forms.CheckBox();
            this.dtpCustomStartTime = new System.Windows.Forms.DateTimePicker();
            this.cbMaxQuantity = new System.Windows.Forms.CheckBox();
            this.lbMaxQuantity = new System.Windows.Forms.Label();
            this.tbMaxQuantity = new System.Windows.Forms.TextBox();
            this.cbSingleUser = new System.Windows.Forms.CheckBox();
            this.lbSingleUserName = new System.Windows.Forms.Label();
            this.tbSingleUserName = new System.Windows.Forms.TextBox();
            this.btnAutoTransferStop = new System.Windows.Forms.Button();
            this.cbReadOnly = new System.Windows.Forms.CheckBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.lbInterval = new System.Windows.Forms.Label();
            this.btnAutoTransferStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLApiKey = new System.Windows.Forms.TextBox();
            this.btnLConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLVerifier = new System.Windows.Forms.TextBox();
            this.tbLAuthStatus = new System.Windows.Forms.TextBox();
            this.btnLAuth = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLLoadToken = new System.Windows.Forms.Button();
            this.btnLSaveToken = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBConnect
            // 
            this.tbBConnect.Location = new System.Drawing.Point(184, 14);
            this.tbBConnect.Name = "tbBConnect";
            this.tbBConnect.Size = new System.Drawing.Size(75, 23);
            this.tbBConnect.TabIndex = 4;
            this.tbBConnect.Text = "Connect";
            this.tbBConnect.UseVisualStyleBackColor = true;
            this.tbBConnect.Click += new System.EventHandler(this.btnBConnect_Click);
            // 
            // tbBVerifier
            // 
            this.tbBVerifier.Location = new System.Drawing.Point(52, 40);
            this.tbBVerifier.Name = "tbBVerifier";
            this.tbBVerifier.Size = new System.Drawing.Size(124, 20);
            this.tbBVerifier.TabIndex = 5;
            // 
            // tbBAuth
            // 
            this.tbBAuth.Location = new System.Drawing.Point(184, 40);
            this.tbBAuth.Name = "tbBAuth";
            this.tbBAuth.Size = new System.Drawing.Size(75, 23);
            this.tbBAuth.TabIndex = 6;
            this.tbBAuth.Text = "Authorize";
            this.tbBAuth.UseVisualStyleBackColor = true;
            this.tbBAuth.Click += new System.EventHandler(this.btnBAuth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verifier";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(8, 104);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(476, 306);
            this.tbOutput.TabIndex = 9;
            // 
            // tbBLoadToken
            // 
            this.tbBLoadToken.Location = new System.Drawing.Point(264, 14);
            this.tbBLoadToken.Name = "tbBLoadToken";
            this.tbBLoadToken.Size = new System.Drawing.Size(75, 23);
            this.tbBLoadToken.TabIndex = 10;
            this.tbBLoadToken.Text = "Load Token";
            this.tbBLoadToken.UseVisualStyleBackColor = true;
            this.tbBLoadToken.Click += new System.EventHandler(this.btnBLoadToken_Click);
            // 
            // tbBSaveToken
            // 
            this.tbBSaveToken.Location = new System.Drawing.Point(264, 40);
            this.tbBSaveToken.Name = "tbBSaveToken";
            this.tbBSaveToken.Size = new System.Drawing.Size(75, 23);
            this.tbBSaveToken.TabIndex = 11;
            this.tbBSaveToken.Text = "Save Token";
            this.tbBSaveToken.UseVisualStyleBackColor = true;
            this.tbBSaveToken.Click += new System.EventHandler(this.btnBSaveToken_Click);
            // 
            // tbBApiKey
            // 
            this.tbBApiKey.Location = new System.Drawing.Point(52, 16);
            this.tbBApiKey.Name = "tbBApiKey";
            this.tbBApiKey.Size = new System.Drawing.Size(124, 20);
            this.tbBApiKey.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "API Key";
            // 
            // tbBAuthStatus
            // 
            this.tbBAuthStatus.Location = new System.Drawing.Point(260, 68);
            this.tbBAuthStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tbBAuthStatus.Name = "tbBAuthStatus";
            this.tbBAuthStatus.ReadOnly = true;
            this.tbBAuthStatus.Size = new System.Drawing.Size(76, 20);
            this.tbBAuthStatus.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Auth status";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpCustomStartDate);
            this.groupBox4.Controls.Add(this.cbCustomStartTime);
            this.groupBox4.Controls.Add(this.dtpCustomStartTime);
            this.groupBox4.Controls.Add(this.cbMaxQuantity);
            this.groupBox4.Controls.Add(this.lbMaxQuantity);
            this.groupBox4.Controls.Add(this.tbMaxQuantity);
            this.groupBox4.Controls.Add(this.cbSingleUser);
            this.groupBox4.Controls.Add(this.lbSingleUserName);
            this.groupBox4.Controls.Add(this.tbSingleUserName);
            this.groupBox4.Controls.Add(this.btnAutoTransferStop);
            this.groupBox4.Controls.Add(this.cbReadOnly);
            this.groupBox4.Controls.Add(this.tbInterval);
            this.groupBox4.Controls.Add(this.lbInterval);
            this.groupBox4.Controls.Add(this.btnAutoTransferStart);
            this.groupBox4.Location = new System.Drawing.Point(496, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 228);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Auto-Transfer";
            // 
            // dtpCustomStartDate
            // 
            this.dtpCustomStartDate.Enabled = false;
            this.dtpCustomStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustomStartDate.Location = new System.Drawing.Point(24, 172);
            this.dtpCustomStartDate.Name = "dtpCustomStartDate";
            this.dtpCustomStartDate.Size = new System.Drawing.Size(96, 20);
            this.dtpCustomStartDate.TabIndex = 47;
            // 
            // cbCustomStartTime
            // 
            this.cbCustomStartTime.AutoSize = true;
            this.cbCustomStartTime.Location = new System.Drawing.Point(8, 152);
            this.cbCustomStartTime.Name = "cbCustomStartTime";
            this.cbCustomStartTime.Size = new System.Drawing.Size(124, 17);
            this.cbCustomStartTime.TabIndex = 46;
            this.cbCustomStartTime.Text = "Start from earlier time";
            this.cbCustomStartTime.UseVisualStyleBackColor = true;
            this.cbCustomStartTime.CheckedChanged += new System.EventHandler(this.cbCustomStartTime_CheckedChanged);
            // 
            // dtpCustomStartTime
            // 
            this.dtpCustomStartTime.Enabled = false;
            this.dtpCustomStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCustomStartTime.Location = new System.Drawing.Point(124, 172);
            this.dtpCustomStartTime.Name = "dtpCustomStartTime";
            this.dtpCustomStartTime.ShowUpDown = true;
            this.dtpCustomStartTime.Size = new System.Drawing.Size(80, 20);
            this.dtpCustomStartTime.TabIndex = 45;
            // 
            // cbMaxQuantity
            // 
            this.cbMaxQuantity.AutoSize = true;
            this.cbMaxQuantity.Enabled = false;
            this.cbMaxQuantity.Location = new System.Drawing.Point(8, 108);
            this.cbMaxQuantity.Name = "cbMaxQuantity";
            this.cbMaxQuantity.Size = new System.Drawing.Size(159, 17);
            this.cbMaxQuantity.TabIndex = 44;
            this.cbMaxQuantity.Text = "Only transfer small quantities";
            this.cbMaxQuantity.UseVisualStyleBackColor = true;
            this.cbMaxQuantity.CheckedChanged += new System.EventHandler(this.cbMaxQuantity_CheckedChanged);
            // 
            // lbMaxQuantity
            // 
            this.lbMaxQuantity.AutoSize = true;
            this.lbMaxQuantity.Enabled = false;
            this.lbMaxQuantity.Location = new System.Drawing.Point(4, 132);
            this.lbMaxQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaxQuantity.Name = "lbMaxQuantity";
            this.lbMaxQuantity.Size = new System.Drawing.Size(70, 13);
            this.lbMaxQuantity.TabIndex = 43;
            this.lbMaxQuantity.Text = "Max. quantity";
            // 
            // tbMaxQuantity
            // 
            this.tbMaxQuantity.Enabled = false;
            this.tbMaxQuantity.Location = new System.Drawing.Point(76, 128);
            this.tbMaxQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaxQuantity.Name = "tbMaxQuantity";
            this.tbMaxQuantity.Size = new System.Drawing.Size(127, 20);
            this.tbMaxQuantity.TabIndex = 42;
            // 
            // cbSingleUser
            // 
            this.cbSingleUser.AutoSize = true;
            this.cbSingleUser.Enabled = false;
            this.cbSingleUser.Location = new System.Drawing.Point(8, 64);
            this.cbSingleUser.Name = "cbSingleUser";
            this.cbSingleUser.Size = new System.Drawing.Size(161, 17);
            this.cbSingleUser.TabIndex = 41;
            this.cbSingleUser.Text = "Transfer only to specific user";
            this.cbSingleUser.UseVisualStyleBackColor = true;
            this.cbSingleUser.CheckedChanged += new System.EventHandler(this.cbSingleUser_CheckedChanged);
            // 
            // lbSingleUserName
            // 
            this.lbSingleUserName.AutoSize = true;
            this.lbSingleUserName.Enabled = false;
            this.lbSingleUserName.Location = new System.Drawing.Point(16, 88);
            this.lbSingleUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSingleUserName.Name = "lbSingleUserName";
            this.lbSingleUserName.Size = new System.Drawing.Size(55, 13);
            this.lbSingleUserName.TabIndex = 40;
            this.lbSingleUserName.Text = "Username";
            // 
            // tbSingleUserName
            // 
            this.tbSingleUserName.Enabled = false;
            this.tbSingleUserName.Location = new System.Drawing.Point(76, 84);
            this.tbSingleUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSingleUserName.Name = "tbSingleUserName";
            this.tbSingleUserName.Size = new System.Drawing.Size(127, 20);
            this.tbSingleUserName.TabIndex = 39;
            // 
            // btnAutoTransferStop
            // 
            this.btnAutoTransferStop.Enabled = false;
            this.btnAutoTransferStop.Location = new System.Drawing.Point(88, 196);
            this.btnAutoTransferStop.Name = "btnAutoTransferStop";
            this.btnAutoTransferStop.Size = new System.Drawing.Size(75, 23);
            this.btnAutoTransferStop.TabIndex = 38;
            this.btnAutoTransferStop.Text = "Stop";
            this.btnAutoTransferStop.UseVisualStyleBackColor = true;
            this.btnAutoTransferStop.Click += new System.EventHandler(this.btnAutoTransferStop_Click);
            // 
            // cbReadOnly
            // 
            this.cbReadOnly.AutoSize = true;
            this.cbReadOnly.Checked = true;
            this.cbReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReadOnly.Location = new System.Drawing.Point(8, 40);
            this.cbReadOnly.Name = "cbReadOnly";
            this.cbReadOnly.Size = new System.Drawing.Size(184, 17);
            this.cbReadOnly.TabIndex = 37;
            this.cbReadOnly.Text = "Don\'t perform transfers (read-only)";
            this.cbReadOnly.UseVisualStyleBackColor = true;
            this.cbReadOnly.CheckedChanged += new System.EventHandler(this.cbReadOnly_CheckedChanged);
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(76, 16);
            this.tbInterval.Margin = new System.Windows.Forms.Padding(2);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(127, 20);
            this.tbInterval.TabIndex = 32;
            // 
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(4, 20);
            this.lbInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(67, 13);
            this.lbInterval.TabIndex = 32;
            this.lbInterval.Text = "Interval (min)";
            // 
            // btnAutoTransferStart
            // 
            this.btnAutoTransferStart.Location = new System.Drawing.Point(8, 196);
            this.btnAutoTransferStart.Name = "btnAutoTransferStart";
            this.btnAutoTransferStart.Size = new System.Drawing.Size(75, 23);
            this.btnAutoTransferStart.TabIndex = 36;
            this.btnAutoTransferStart.Text = "Start";
            this.btnAutoTransferStart.UseVisualStyleBackColor = true;
            this.btnAutoTransferStart.Click += new System.EventHandler(this.btnAutoTransferStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBApiKey);
            this.groupBox1.Controls.Add(this.tbBConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBVerifier);
            this.groupBox1.Controls.Add(this.tbBAuthStatus);
            this.groupBox1.Controls.Add(this.tbBAuth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbBLoadToken);
            this.groupBox1.Controls.Add(this.tbBSaveToken);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 96);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BTC-TC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLApiKey);
            this.groupBox2.Controls.Add(this.btnLConnect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbLVerifier);
            this.groupBox2.Controls.Add(this.tbLAuthStatus);
            this.groupBox2.Controls.Add(this.btnLAuth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnLLoadToken);
            this.groupBox2.Controls.Add(this.btnLSaveToken);
            this.groupBox2.Location = new System.Drawing.Point(360, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 96);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LTC-Global";
            // 
            // tbLApiKey
            // 
            this.tbLApiKey.Location = new System.Drawing.Point(52, 16);
            this.tbLApiKey.Name = "tbLApiKey";
            this.tbLApiKey.Size = new System.Drawing.Size(124, 20);
            this.tbLApiKey.TabIndex = 14;
            // 
            // btnLConnect
            // 
            this.btnLConnect.Location = new System.Drawing.Point(184, 14);
            this.btnLConnect.Name = "btnLConnect";
            this.btnLConnect.Size = new System.Drawing.Size(75, 23);
            this.btnLConnect.TabIndex = 4;
            this.btnLConnect.Text = "Connect";
            this.btnLConnect.UseVisualStyleBackColor = true;
            this.btnLConnect.Click += new System.EventHandler(this.btnLConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Auth status";
            // 
            // tbLVerifier
            // 
            this.tbLVerifier.Location = new System.Drawing.Point(52, 40);
            this.tbLVerifier.Name = "tbLVerifier";
            this.tbLVerifier.Size = new System.Drawing.Size(124, 20);
            this.tbLVerifier.TabIndex = 5;
            // 
            // tbLAuthStatus
            // 
            this.tbLAuthStatus.Location = new System.Drawing.Point(260, 68);
            this.tbLAuthStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tbLAuthStatus.Name = "tbLAuthStatus";
            this.tbLAuthStatus.ReadOnly = true;
            this.tbLAuthStatus.Size = new System.Drawing.Size(76, 20);
            this.tbLAuthStatus.TabIndex = 16;
            // 
            // btnLAuth
            // 
            this.btnLAuth.Location = new System.Drawing.Point(184, 40);
            this.btnLAuth.Name = "btnLAuth";
            this.btnLAuth.Size = new System.Drawing.Size(75, 23);
            this.btnLAuth.TabIndex = 6;
            this.btnLAuth.Text = "Authorize";
            this.btnLAuth.UseVisualStyleBackColor = true;
            this.btnLAuth.Click += new System.EventHandler(this.btnLAuth_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "API Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Verifier";
            // 
            // btnLLoadToken
            // 
            this.btnLLoadToken.Location = new System.Drawing.Point(264, 14);
            this.btnLLoadToken.Name = "btnLLoadToken";
            this.btnLLoadToken.Size = new System.Drawing.Size(75, 23);
            this.btnLLoadToken.TabIndex = 10;
            this.btnLLoadToken.Text = "Load Token";
            this.btnLLoadToken.UseVisualStyleBackColor = true;
            this.btnLLoadToken.Click += new System.EventHandler(this.btnLLoadToken_Click);
            // 
            // btnLSaveToken
            // 
            this.btnLSaveToken.Location = new System.Drawing.Point(264, 40);
            this.btnLSaveToken.Name = "btnLSaveToken";
            this.btnLSaveToken.Size = new System.Drawing.Size(75, 23);
            this.btnLSaveToken.TabIndex = 11;
            this.btnLSaveToken.Text = "Save Token";
            this.btnLSaveToken.UseVisualStyleBackColor = true;
            this.btnLSaveToken.Click += new System.EventHandler(this.btnLSaveToken_Click);
            // 
            // BTCTC_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tbOutput);
            this.Name = "BTCTC_MainWindow";
            this.Text = "BTCT-AutoTransfer";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbBConnect;
        private System.Windows.Forms.TextBox tbBVerifier;
        private System.Windows.Forms.Button tbBAuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button tbBLoadToken;
        private System.Windows.Forms.Button tbBSaveToken;
        private System.Windows.Forms.TextBox tbBApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBAuthStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbReadOnly;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label lbInterval;
        private System.Windows.Forms.Button btnAutoTransferStart;
        private System.Windows.Forms.CheckBox cbSingleUser;
        private System.Windows.Forms.Label lbSingleUserName;
        private System.Windows.Forms.TextBox tbSingleUserName;
        private System.Windows.Forms.Button btnAutoTransferStop;
        private System.Windows.Forms.CheckBox cbMaxQuantity;
        private System.Windows.Forms.Label lbMaxQuantity;
        private System.Windows.Forms.TextBox tbMaxQuantity;
        private System.Windows.Forms.CheckBox cbCustomStartTime;
        private System.Windows.Forms.DateTimePicker dtpCustomStartTime;
        private System.Windows.Forms.DateTimePicker dtpCustomStartDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLApiKey;
        private System.Windows.Forms.Button btnLConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLVerifier;
        private System.Windows.Forms.TextBox tbLAuthStatus;
        private System.Windows.Forms.Button btnLAuth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLLoadToken;
        private System.Windows.Forms.Button btnLSaveToken;
    }
}

