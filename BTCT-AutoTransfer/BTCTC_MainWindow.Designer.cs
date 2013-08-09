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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.tbSecurity = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOrderType = new System.Windows.Forms.ComboBox();
            this.cbExpiry = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCancelOrderId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.cbGlobalDataSelect = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Authorize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verifier";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Get Portfolio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(8, 60);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(476, 350);
            this.tbOutput.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(336, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Load Token";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Save Token";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(492, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Trade Hist.";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "API Key";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 416);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Auth status";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 46);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Submit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tbSecurity
            // 
            this.tbSecurity.Location = new System.Drawing.Point(75, 20);
            this.tbSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.tbSecurity.Name = "tbSecurity";
            this.tbSecurity.Size = new System.Drawing.Size(127, 20);
            this.tbSecurity.TabIndex = 19;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(75, 42);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(127, 20);
            this.tbAmount.TabIndex = 20;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(75, 65);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(127, 20);
            this.tbPrice.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Security";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Price";
            // 
            // cbOrderType
            // 
            this.cbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderType.FormattingEnabled = true;
            this.cbOrderType.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.cbOrderType.Location = new System.Drawing.Point(75, 88);
            this.cbOrderType.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrderType.Name = "cbOrderType";
            this.cbOrderType.Size = new System.Drawing.Size(127, 21);
            this.cbOrderType.TabIndex = 26;
            // 
            // cbExpiry
            // 
            this.cbExpiry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExpiry.FormattingEnabled = true;
            this.cbExpiry.Items.AddRange(new object[] {
            "0",
            "1",
            "7",
            "14",
            "30",
            "90"});
            this.cbExpiry.Location = new System.Drawing.Point(75, 110);
            this.cbExpiry.Margin = new System.Windows.Forms.Padding(2);
            this.cbExpiry.Name = "cbExpiry";
            this.cbExpiry.Size = new System.Drawing.Size(127, 21);
            this.cbExpiry.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Order Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Expiry (days)";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(9, 136);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitOrder.TabIndex = 31;
            this.btnSubmitOrder.Text = "Submit";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSecurity);
            this.groupBox1.Controls.Add(this.btnSubmitOrder);
            this.groupBox1.Controls.Add(this.tbAmount);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbExpiry);
            this.groupBox1.Controls.Add(this.cbOrderType);
            this.groupBox1.Location = new System.Drawing.Point(492, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(210, 166);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Submit Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCancelOrderId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(492, 336);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(210, 75);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cancel Order";
            // 
            // tbCancelOrderId
            // 
            this.tbCancelOrderId.Location = new System.Drawing.Point(75, 20);
            this.tbCancelOrderId.Margin = new System.Windows.Forms.Padding(2);
            this.tbCancelOrderId.Name = "tbCancelOrderId";
            this.tbCancelOrderId.Size = new System.Drawing.Size(127, 20);
            this.tbCancelOrderId.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Order ID";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(572, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "Div. Hist.";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // cbGlobalDataSelect
            // 
            this.cbGlobalDataSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGlobalDataSelect.FormattingEnabled = true;
            this.cbGlobalDataSelect.Items.AddRange(new object[] {
            "Tickers",
            "Trade history (48h)",
            "Dividends (48h)"});
            this.cbGlobalDataSelect.Location = new System.Drawing.Point(75, 16);
            this.cbGlobalDataSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cbGlobalDataSelect.Name = "cbGlobalDataSelect";
            this.cbGlobalDataSelect.Size = new System.Drawing.Size(127, 21);
            this.cbGlobalDataSelect.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.cbGlobalDataSelect);
            this.groupBox3.Location = new System.Drawing.Point(492, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 72);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Global data (NYI)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Data";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(8, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 36;
            this.button9.Text = "Submit";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
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
            this.groupBox4.Location = new System.Drawing.Point(712, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 228);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DMS Auto-Transfer";
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
            // BTCTC_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 439);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Name = "BTCTC_MainWindow";
            this.Text = "BTCT-AutoTransfer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbSecurity;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOrderType;
        private System.Windows.Forms.ComboBox cbExpiry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCancelOrderId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cbGlobalDataSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label10;
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
    }
}

