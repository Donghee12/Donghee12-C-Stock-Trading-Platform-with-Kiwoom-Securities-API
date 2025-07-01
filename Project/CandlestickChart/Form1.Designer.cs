namespace CandlestickChart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.requestButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dailyButton = new System.Windows.Forms.Button();
            this.weeklyButton = new System.Windows.Forms.Button();
            this.monthlyButton = new System.Windows.Forms.Button();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.minuteButton = new System.Windows.Forms.Button();
            this.tickButton = new System.Windows.Forms.Button();
            this.n1Button = new System.Windows.Forms.Button();
            this.n3Button = new System.Windows.Forms.Button();
            this.n5Button = new System.Windows.Forms.Button();
            this.n10Button = new System.Windows.Forms.Button();
            this.n15Button = new System.Windows.Forms.Button();
            this.n30Button = new System.Windows.Forms.Button();
            this.n45Button = new System.Windows.Forms.Button();
            this.n60Button = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartYLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lowPriceLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.highPriceLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openPriceLabel = new System.Windows.Forms.Label();
            this.currentPriceLabel = new System.Windows.Forms.Label();
            this.netChangeLabel = new System.Windows.Forms.Label();
            this.fluctuationRateLabel = new System.Windows.Forms.Label();
            this.accumulatedVolumeLabel = new System.Windows.Forms.Label();
            this.turnoverRatioLabel = new System.Windows.Forms.Label();
            this.volumeChangeLabel = new System.Windows.Forms.Label();
            this.tradingValueLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelBuyable = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTotalEval = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTotalBuy = new System.Windows.Forms.Label();
            this.labelell = new System.Windows.Forms.Label();
            this.btnAccountSerach = new System.Windows.Forms.Button();
            this.cmbMyAccounts = new System.Windows.Forms.ComboBox();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewInterest = new CandlestickChart.DoubleBufferedListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listViewHoldings = new CandlestickChart.DoubleBufferedListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuyOrder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBuy = new System.Windows.Forms.TabPage();
            this.chkInterestBuy = new System.Windows.Forms.CheckBox();
            this.lblMaxBuyQuantity = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.cmbBuyStockCode = new System.Windows.Forms.ComboBox();
            this.cmbBuyOrderType = new System.Windows.Forms.ComboBox();
            this.numBuyPrice = new System.Windows.Forms.NumericUpDown();
            this.numBuyQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSell = new System.Windows.Forms.TabPage();
            this.chkInterestSell = new System.Windows.Forms.CheckBox();
            this.lblMaxSellQuantity = new System.Windows.Forms.Label();
            this.txtSellStockName = new System.Windows.Forms.TextBox();
            this.cmbSellStockCode = new System.Windows.Forms.ComboBox();
            this.cmbSellOrderType = new System.Windows.Forms.ComboBox();
            this.numSellPrice = new System.Windows.Forms.NumericUpDown();
            this.numSellQuantity = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSellOrder = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyQuantity)).BeginInit();
            this.tabSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellQuantity)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(148, 443);
            this.axKHOpenAPI1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(10, 10);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(88, 0);
            this.requestButton.Margin = new System.Windows.Forms.Padding(0);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(52, 27);
            this.requestButton.TabIndex = 3;
            this.requestButton.Text = "조회";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 546);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 19;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.requestButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dailyButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.weeklyButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.monthlyButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.itemCodeTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.minuteButton, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.tickButton, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.n1Button, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.n3Button, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.n5Button, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.n10Button, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.n15Button, 13, 0);
            this.tableLayoutPanel2.Controls.Add(this.n30Button, 14, 0);
            this.tableLayoutPanel2.Controls.Add(this.n45Button, 15, 0);
            this.tableLayoutPanel2.Controls.Add(this.n60Button, 16, 0);
            this.tableLayoutPanel2.Controls.Add(this.itemNameLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(827, 27);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dailyButton
            // 
            this.dailyButton.Location = new System.Drawing.Point(280, 0);
            this.dailyButton.Margin = new System.Windows.Forms.Padding(0);
            this.dailyButton.Name = "dailyButton";
            this.dailyButton.Size = new System.Drawing.Size(35, 27);
            this.dailyButton.TabIndex = 4;
            this.dailyButton.Text = "일";
            this.dailyButton.UseVisualStyleBackColor = true;
            // 
            // weeklyButton
            // 
            this.weeklyButton.Location = new System.Drawing.Point(315, 0);
            this.weeklyButton.Margin = new System.Windows.Forms.Padding(0);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(35, 27);
            this.weeklyButton.TabIndex = 5;
            this.weeklyButton.Text = "주";
            this.weeklyButton.UseVisualStyleBackColor = true;
            // 
            // monthlyButton
            // 
            this.monthlyButton.Location = new System.Drawing.Point(350, 0);
            this.monthlyButton.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(35, 27);
            this.monthlyButton.TabIndex = 6;
            this.monthlyButton.Text = "월";
            this.monthlyButton.UseVisualStyleBackColor = true;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(3, 2);
            this.itemCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(82, 21);
            this.itemCodeTextBox.TabIndex = 8;
            // 
            // minuteButton
            // 
            this.minuteButton.Location = new System.Drawing.Point(385, 0);
            this.minuteButton.Margin = new System.Windows.Forms.Padding(0);
            this.minuteButton.Name = "minuteButton";
            this.minuteButton.Size = new System.Drawing.Size(35, 27);
            this.minuteButton.TabIndex = 9;
            this.minuteButton.Text = "분";
            this.minuteButton.UseVisualStyleBackColor = true;
            // 
            // tickButton
            // 
            this.tickButton.Location = new System.Drawing.Point(420, 0);
            this.tickButton.Margin = new System.Windows.Forms.Padding(0);
            this.tickButton.Name = "tickButton";
            this.tickButton.Size = new System.Drawing.Size(35, 27);
            this.tickButton.TabIndex = 10;
            this.tickButton.Text = "틱";
            this.tickButton.UseVisualStyleBackColor = true;
            // 
            // n1Button
            // 
            this.n1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n1Button.Enabled = false;
            this.n1Button.Location = new System.Drawing.Point(456, 1);
            this.n1Button.Margin = new System.Windows.Forms.Padding(1);
            this.n1Button.Name = "n1Button";
            this.n1Button.Size = new System.Drawing.Size(33, 25);
            this.n1Button.TabIndex = 11;
            this.n1Button.Text = "1";
            this.n1Button.UseVisualStyleBackColor = true;
            // 
            // n3Button
            // 
            this.n3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n3Button.Enabled = false;
            this.n3Button.Location = new System.Drawing.Point(491, 1);
            this.n3Button.Margin = new System.Windows.Forms.Padding(1);
            this.n3Button.Name = "n3Button";
            this.n3Button.Size = new System.Drawing.Size(33, 25);
            this.n3Button.TabIndex = 12;
            this.n3Button.Text = "3";
            this.n3Button.UseVisualStyleBackColor = true;
            // 
            // n5Button
            // 
            this.n5Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n5Button.Enabled = false;
            this.n5Button.Location = new System.Drawing.Point(526, 1);
            this.n5Button.Margin = new System.Windows.Forms.Padding(1);
            this.n5Button.Name = "n5Button";
            this.n5Button.Size = new System.Drawing.Size(33, 25);
            this.n5Button.TabIndex = 13;
            this.n5Button.Text = "5";
            this.n5Button.UseVisualStyleBackColor = true;
            // 
            // n10Button
            // 
            this.n10Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n10Button.Enabled = false;
            this.n10Button.Location = new System.Drawing.Point(561, 1);
            this.n10Button.Margin = new System.Windows.Forms.Padding(1);
            this.n10Button.Name = "n10Button";
            this.n10Button.Size = new System.Drawing.Size(33, 25);
            this.n10Button.TabIndex = 14;
            this.n10Button.Text = "10";
            this.n10Button.UseVisualStyleBackColor = true;
            // 
            // n15Button
            // 
            this.n15Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n15Button.Enabled = false;
            this.n15Button.Location = new System.Drawing.Point(596, 1);
            this.n15Button.Margin = new System.Windows.Forms.Padding(1);
            this.n15Button.Name = "n15Button";
            this.n15Button.Size = new System.Drawing.Size(33, 25);
            this.n15Button.TabIndex = 15;
            this.n15Button.Text = "15";
            this.n15Button.UseVisualStyleBackColor = true;
            // 
            // n30Button
            // 
            this.n30Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n30Button.Enabled = false;
            this.n30Button.Location = new System.Drawing.Point(631, 1);
            this.n30Button.Margin = new System.Windows.Forms.Padding(1);
            this.n30Button.Name = "n30Button";
            this.n30Button.Size = new System.Drawing.Size(33, 25);
            this.n30Button.TabIndex = 16;
            this.n30Button.Text = "30";
            this.n30Button.UseVisualStyleBackColor = true;
            // 
            // n45Button
            // 
            this.n45Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n45Button.Enabled = false;
            this.n45Button.Location = new System.Drawing.Point(666, 1);
            this.n45Button.Margin = new System.Windows.Forms.Padding(1);
            this.n45Button.Name = "n45Button";
            this.n45Button.Size = new System.Drawing.Size(33, 25);
            this.n45Button.TabIndex = 17;
            this.n45Button.Text = "45";
            this.n45Button.UseVisualStyleBackColor = true;
            // 
            // n60Button
            // 
            this.n60Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n60Button.Enabled = false;
            this.n60Button.Location = new System.Drawing.Point(701, 1);
            this.n60Button.Margin = new System.Windows.Forms.Padding(1);
            this.n60Button.Name = "n60Button";
            this.n60Button.Size = new System.Drawing.Size(33, 25);
            this.n60Button.TabIndex = 18;
            this.n60Button.Text = "60";
            this.n60Button.UseVisualStyleBackColor = true;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemNameLabel.ForeColor = System.Drawing.Color.White;
            this.itemNameLabel.Location = new System.Drawing.Point(195, 2);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(82, 23);
            this.itemNameLabel.TabIndex = 19;
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(140, 0);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 27);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chartYLabel);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(3, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 482);
            this.panel1.TabIndex = 3;
            // 
            // chartYLabel
            // 
            this.chartYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartYLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.chartYLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartYLabel.Location = new System.Drawing.Point(743, 28);
            this.chartYLabel.Name = "chartYLabel";
            this.chartYLabel.Size = new System.Drawing.Size(71, 19);
            this.chartYLabel.TabIndex = 5;
            this.chartYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chartYLabel.Visible = false;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AlignWithChartArea = "volumeChartArea";
            chartArea1.AxisX.IsReversed = true;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.ScrollBar.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 92.36364F;
            chartArea1.InnerPlotPosition.Width = 90.32448F;
            chartArea1.InnerPlotPosition.X = 1.675532F;
            chartArea1.InnerPlotPosition.Y = 3.818182F;
            chartArea1.Name = "PriceChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 55F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartArea2.AxisX.IsReversed = true;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 80.86906F;
            chartArea2.InnerPlotPosition.Width = 90.32448F;
            chartArea2.InnerPlotPosition.X = 1.675532F;
            chartArea2.InnerPlotPosition.Y = 4.999996F;
            chartArea2.Name = "volumeChartArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 38F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 59F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart1.Location = new System.Drawing.Point(0, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "PriceChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Name = "priceSeries";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "volumeChartArea";
            series2.Name = "volumeSeries";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(827, 478);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 13;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel3.Controls.Add(this.lowPriceLabel, 12, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 11, 0);
            this.tableLayoutPanel3.Controls.Add(this.highPriceLabel, 10, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.openPriceLabel, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.currentPriceLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.netChangeLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.fluctuationRateLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.accumulatedVolumeLabel, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.turnoverRatioLabel, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.volumeChangeLabel, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.tradingValueLabel, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 7, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(827, 23);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lowPriceLabel
            // 
            this.lowPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lowPriceLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.lowPriceLabel.Location = new System.Drawing.Point(747, 0);
            this.lowPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lowPriceLabel.Name = "lowPriceLabel";
            this.lowPriceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lowPriceLabel.Size = new System.Drawing.Size(87, 23);
            this.lowPriceLabel.TabIndex = 12;
            this.lowPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FloralWhite;
            this.label12.Location = new System.Drawing.Point(716, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "저";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // highPriceLabel
            // 
            this.highPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.highPriceLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.highPriceLabel.Location = new System.Drawing.Point(646, 0);
            this.highPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.highPriceLabel.Name = "highPriceLabel";
            this.highPriceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.highPriceLabel.Size = new System.Drawing.Size(70, 23);
            this.highPriceLabel.TabIndex = 10;
            this.highPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FloralWhite;
            this.label10.Location = new System.Drawing.Point(615, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "고";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openPriceLabel
            // 
            this.openPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openPriceLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.openPriceLabel.Location = new System.Drawing.Point(545, 0);
            this.openPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.openPriceLabel.Name = "openPriceLabel";
            this.openPriceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.openPriceLabel.Size = new System.Drawing.Size(70, 23);
            this.openPriceLabel.TabIndex = 8;
            this.openPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentPriceLabel
            // 
            this.currentPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPriceLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.currentPriceLabel.Location = new System.Drawing.Point(0, 0);
            this.currentPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.currentPriceLabel.Name = "currentPriceLabel";
            this.currentPriceLabel.Size = new System.Drawing.Size(70, 23);
            this.currentPriceLabel.TabIndex = 0;
            this.currentPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // netChangeLabel
            // 
            this.netChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netChangeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.netChangeLabel.Location = new System.Drawing.Point(70, 0);
            this.netChangeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.netChangeLabel.Name = "netChangeLabel";
            this.netChangeLabel.Size = new System.Drawing.Size(70, 23);
            this.netChangeLabel.TabIndex = 1;
            this.netChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fluctuationRateLabel
            // 
            this.fluctuationRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fluctuationRateLabel.AutoSize = true;
            this.fluctuationRateLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fluctuationRateLabel.Location = new System.Drawing.Point(140, 0);
            this.fluctuationRateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fluctuationRateLabel.Name = "fluctuationRateLabel";
            this.fluctuationRateLabel.Size = new System.Drawing.Size(62, 23);
            this.fluctuationRateLabel.TabIndex = 2;
            this.fluctuationRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accumulatedVolumeLabel
            // 
            this.accumulatedVolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accumulatedVolumeLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.accumulatedVolumeLabel.Location = new System.Drawing.Point(202, 0);
            this.accumulatedVolumeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accumulatedVolumeLabel.Name = "accumulatedVolumeLabel";
            this.accumulatedVolumeLabel.Size = new System.Drawing.Size(94, 23);
            this.accumulatedVolumeLabel.TabIndex = 3;
            this.accumulatedVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // turnoverRatioLabel
            // 
            this.turnoverRatioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.turnoverRatioLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.turnoverRatioLabel.Location = new System.Drawing.Point(364, 0);
            this.turnoverRatioLabel.Margin = new System.Windows.Forms.Padding(0);
            this.turnoverRatioLabel.Name = "turnoverRatioLabel";
            this.turnoverRatioLabel.Size = new System.Drawing.Size(49, 23);
            this.turnoverRatioLabel.TabIndex = 5;
            this.turnoverRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // volumeChangeLabel
            // 
            this.volumeChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeChangeLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.volumeChangeLabel.Location = new System.Drawing.Point(296, 0);
            this.volumeChangeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.volumeChangeLabel.Name = "volumeChangeLabel";
            this.volumeChangeLabel.Size = new System.Drawing.Size(68, 23);
            this.volumeChangeLabel.TabIndex = 4;
            this.volumeChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tradingValueLabel
            // 
            this.tradingValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tradingValueLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tradingValueLabel.Location = new System.Drawing.Point(413, 0);
            this.tradingValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.tradingValueLabel.Name = "tradingValueLabel";
            this.tradingValueLabel.Size = new System.Drawing.Size(101, 23);
            this.tradingValueLabel.TabIndex = 6;
            this.tradingValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(514, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "시";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(619, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 591);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "차트";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelBuyable);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.labelTotalEval);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.labelTotalBuy);
            this.groupBox2.Controls.Add(this.labelell);
            this.groupBox2.Controls.Add(this.btnAccountSerach);
            this.groupBox2.Controls.Add(this.cmbMyAccounts);
            this.groupBox2.Controls.Add(this.labelProfit);
            this.groupBox2.Controls.Add(this.labelTotal);
            this.groupBox2.Controls.Add(this.labelName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(619, 622);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 288);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내 정보";
            // 
            // labelBuyable
            // 
            this.labelBuyable.AutoSize = true;
            this.labelBuyable.Location = new System.Drawing.Point(130, 140);
            this.labelBuyable.Name = "labelBuyable";
            this.labelBuyable.Size = new System.Drawing.Size(12, 12);
            this.labelBuyable.TabIndex = 24;
            this.labelBuyable.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 12);
            this.label15.TabIndex = 23;
            this.label15.Text = "주문가능금액 :";
            // 
            // labelTotalEval
            // 
            this.labelTotalEval.AutoSize = true;
            this.labelTotalEval.Location = new System.Drawing.Point(122, 235);
            this.labelTotalEval.Name = "labelTotalEval";
            this.labelTotalEval.Size = new System.Drawing.Size(12, 12);
            this.labelTotalEval.TabIndex = 22;
            this.labelTotalEval.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "총 매입금액 :";
            // 
            // labelTotalBuy
            // 
            this.labelTotalBuy.AutoSize = true;
            this.labelTotalBuy.Location = new System.Drawing.Point(122, 202);
            this.labelTotalBuy.Name = "labelTotalBuy";
            this.labelTotalBuy.Size = new System.Drawing.Size(12, 12);
            this.labelTotalBuy.TabIndex = 20;
            this.labelTotalBuy.Text = "-";
            // 
            // labelell
            // 
            this.labelell.AutoSize = true;
            this.labelell.Location = new System.Drawing.Point(31, 233);
            this.labelell.Name = "labelell";
            this.labelell.Size = new System.Drawing.Size(85, 12);
            this.labelell.TabIndex = 19;
            this.labelell.Text = "총 평가금액 :";
            // 
            // btnAccountSerach
            // 
            this.btnAccountSerach.Location = new System.Drawing.Point(237, 72);
            this.btnAccountSerach.Name = "btnAccountSerach";
            this.btnAccountSerach.Size = new System.Drawing.Size(67, 24);
            this.btnAccountSerach.TabIndex = 18;
            this.btnAccountSerach.Text = "조회";
            this.btnAccountSerach.UseVisualStyleBackColor = true;
            // 
            // cmbMyAccounts
            // 
            this.cmbMyAccounts.FormattingEnabled = true;
            this.cmbMyAccounts.Location = new System.Drawing.Point(110, 75);
            this.cmbMyAccounts.Name = "cmbMyAccounts";
            this.cmbMyAccounts.Size = new System.Drawing.Size(121, 20);
            this.cmbMyAccounts.TabIndex = 17;
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Location = new System.Drawing.Point(115, 172);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(12, 12);
            this.labelProfit.TabIndex = 16;
            this.labelProfit.Text = "-";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(99, 109);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(12, 12);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "-";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(101, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(12, 12);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "평가손익 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "예수금 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "계좌번호 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "이름 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl2);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(12, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 597);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "관심종목";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 17);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(581, 577);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 551);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "검색창";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listViewInterest);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(573, 551);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "관심종목";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewInterest
            // 
            this.listViewInterest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader21,
            this.columnHeader24});
            this.listViewInterest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInterest.FullRowSelect = true;
            this.listViewInterest.GridLines = true;
            this.listViewInterest.HideSelection = false;
            this.listViewInterest.Location = new System.Drawing.Point(3, 3);
            this.listViewInterest.Name = "listViewInterest";
            this.listViewInterest.Size = new System.Drawing.Size(567, 545);
            this.listViewInterest.TabIndex = 0;
            this.listViewInterest.UseCompatibleStateImageBehavior = false;
            this.listViewInterest.View = System.Windows.Forms.View.Details;
            this.listViewInterest.SelectedIndexChanged += new System.EventHandler(this.listViewInterest_SelectedIndexChanged);
            this.listViewInterest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewInterest_MouseClick);
            this.listViewInterest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewInterest_MouseDoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "종목명";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "종목코드";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "현재가";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "변동률";
            this.columnHeader21.Width = 80;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "삭제";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listViewHoldings);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(573, 551);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "보유주식";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listViewHoldings
            // 
            this.listViewHoldings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewHoldings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHoldings.FullRowSelect = true;
            this.listViewHoldings.GridLines = true;
            this.listViewHoldings.HideSelection = false;
            this.listViewHoldings.Location = new System.Drawing.Point(0, 0);
            this.listViewHoldings.Name = "listViewHoldings";
            this.listViewHoldings.Size = new System.Drawing.Size(573, 551);
            this.listViewHoldings.TabIndex = 0;
            this.listViewHoldings.UseCompatibleStateImageBehavior = false;
            this.listViewHoldings.View = System.Windows.Forms.View.Details;
            this.listViewHoldings.SelectedIndexChanged += new System.EventHandler(this.listViewHoldings_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "종목명";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "보유수량";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "평균매입가";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "현재가";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "평가금액";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "손실율";
            this.columnHeader6.Width = 154;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 75;
            // 
            // btnBuyOrder
            // 
            this.btnBuyOrder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBuyOrder.Location = new System.Drawing.Point(26, 190);
            this.btnBuyOrder.Name = "btnBuyOrder";
            this.btnBuyOrder.Size = new System.Drawing.Size(113, 37);
            this.btnBuyOrder.TabIndex = 5;
            this.btnBuyOrder.Text = "현금매수";
            this.btnBuyOrder.UseVisualStyleBackColor = true;
            this.btnBuyOrder.Click += new System.EventHandler(this.btnBuyOrder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(587, 290);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "거래창";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBuy);
            this.tabControl1.Controls.Add(this.tabSell);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 270);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBuy
            // 
            this.tabBuy.Controls.Add(this.chkInterestBuy);
            this.tabBuy.Controls.Add(this.lblMaxBuyQuantity);
            this.tabBuy.Controls.Add(this.txtStockName);
            this.tabBuy.Controls.Add(this.cmbBuyStockCode);
            this.tabBuy.Controls.Add(this.cmbBuyOrderType);
            this.tabBuy.Controls.Add(this.numBuyPrice);
            this.tabBuy.Controls.Add(this.numBuyQuantity);
            this.tabBuy.Controls.Add(this.label4);
            this.tabBuy.Controls.Add(this.label3);
            this.tabBuy.Controls.Add(this.btnBuyOrder);
            this.tabBuy.Controls.Add(this.label2);
            this.tabBuy.Controls.Add(this.label1);
            this.tabBuy.Location = new System.Drawing.Point(4, 22);
            this.tabBuy.Name = "tabBuy";
            this.tabBuy.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuy.Size = new System.Drawing.Size(573, 244);
            this.tabBuy.TabIndex = 0;
            this.tabBuy.Text = "매수";
            this.tabBuy.UseVisualStyleBackColor = true;
            // 
            // chkInterestBuy
            // 
            this.chkInterestBuy.AutoSize = true;
            this.chkInterestBuy.Location = new System.Drawing.Point(322, 23);
            this.chkInterestBuy.Name = "chkInterestBuy";
            this.chkInterestBuy.Size = new System.Drawing.Size(76, 16);
            this.chkInterestBuy.TabIndex = 13;
            this.chkInterestBuy.Text = "관심종목";
            this.chkInterestBuy.UseVisualStyleBackColor = true;
            // 
            // lblMaxBuyQuantity
            // 
            this.lblMaxBuyQuantity.AutoSize = true;
            this.lblMaxBuyQuantity.Location = new System.Drawing.Point(184, 78);
            this.lblMaxBuyQuantity.Name = "lblMaxBuyQuantity";
            this.lblMaxBuyQuantity.Size = new System.Drawing.Size(0, 12);
            this.lblMaxBuyQuantity.TabIndex = 12;
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(185, 20);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(131, 21);
            this.txtStockName.TabIndex = 11;
            // 
            // cmbBuyStockCode
            // 
            this.cmbBuyStockCode.FormattingEnabled = true;
            this.cmbBuyStockCode.Location = new System.Drawing.Point(58, 20);
            this.cmbBuyStockCode.Name = "cmbBuyStockCode";
            this.cmbBuyStockCode.Size = new System.Drawing.Size(121, 20);
            this.cmbBuyStockCode.TabIndex = 10;
            // 
            // cmbBuyOrderType
            // 
            this.cmbBuyOrderType.FormattingEnabled = true;
            this.cmbBuyOrderType.Location = new System.Drawing.Point(58, 46);
            this.cmbBuyOrderType.Name = "cmbBuyOrderType";
            this.cmbBuyOrderType.Size = new System.Drawing.Size(121, 20);
            this.cmbBuyOrderType.TabIndex = 9;
            this.cmbBuyOrderType.SelectedIndexChanged += new System.EventHandler(this.cmbBuyOrderType_SelectedIndexChanged_1);
            // 
            // numBuyPrice
            // 
            this.numBuyPrice.Location = new System.Drawing.Point(59, 135);
            this.numBuyPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numBuyPrice.Name = "numBuyPrice";
            this.numBuyPrice.Size = new System.Drawing.Size(120, 21);
            this.numBuyPrice.TabIndex = 8;
            this.numBuyPrice.ThousandsSeparator = true;
            // 
            // numBuyQuantity
            // 
            this.numBuyQuantity.Location = new System.Drawing.Point(58, 74);
            this.numBuyQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numBuyQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBuyQuantity.Name = "numBuyQuantity";
            this.numBuyQuantity.Size = new System.Drawing.Size(120, 21);
            this.numBuyQuantity.TabIndex = 7;
            this.numBuyQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "가격";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "수량";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "유형";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "종목";
            // 
            // tabSell
            // 
            this.tabSell.Controls.Add(this.chkInterestSell);
            this.tabSell.Controls.Add(this.lblMaxSellQuantity);
            this.tabSell.Controls.Add(this.txtSellStockName);
            this.tabSell.Controls.Add(this.cmbSellStockCode);
            this.tabSell.Controls.Add(this.cmbSellOrderType);
            this.tabSell.Controls.Add(this.numSellPrice);
            this.tabSell.Controls.Add(this.numSellQuantity);
            this.tabSell.Controls.Add(this.label13);
            this.tabSell.Controls.Add(this.label16);
            this.tabSell.Controls.Add(this.btnSellOrder);
            this.tabSell.Controls.Add(this.label17);
            this.tabSell.Controls.Add(this.label18);
            this.tabSell.Location = new System.Drawing.Point(4, 22);
            this.tabSell.Name = "tabSell";
            this.tabSell.Padding = new System.Windows.Forms.Padding(3);
            this.tabSell.Size = new System.Drawing.Size(573, 244);
            this.tabSell.TabIndex = 1;
            this.tabSell.Text = "매도";
            // 
            // chkInterestSell
            // 
            this.chkInterestSell.AutoSize = true;
            this.chkInterestSell.Location = new System.Drawing.Point(322, 23);
            this.chkInterestSell.Name = "chkInterestSell";
            this.chkInterestSell.Size = new System.Drawing.Size(76, 16);
            this.chkInterestSell.TabIndex = 23;
            this.chkInterestSell.Text = "관심종목";
            this.chkInterestSell.UseVisualStyleBackColor = true;
            // 
            // lblMaxSellQuantity
            // 
            this.lblMaxSellQuantity.AutoSize = true;
            this.lblMaxSellQuantity.Location = new System.Drawing.Point(184, 78);
            this.lblMaxSellQuantity.Name = "lblMaxSellQuantity";
            this.lblMaxSellQuantity.Size = new System.Drawing.Size(0, 12);
            this.lblMaxSellQuantity.TabIndex = 22;
            // 
            // txtSellStockName
            // 
            this.txtSellStockName.Location = new System.Drawing.Point(185, 20);
            this.txtSellStockName.Name = "txtSellStockName";
            this.txtSellStockName.Size = new System.Drawing.Size(131, 21);
            this.txtSellStockName.TabIndex = 21;
            // 
            // cmbSellStockCode
            // 
            this.cmbSellStockCode.FormattingEnabled = true;
            this.cmbSellStockCode.Location = new System.Drawing.Point(58, 20);
            this.cmbSellStockCode.Name = "cmbSellStockCode";
            this.cmbSellStockCode.Size = new System.Drawing.Size(121, 20);
            this.cmbSellStockCode.TabIndex = 20;
            this.cmbSellStockCode.SelectedIndexChanged += new System.EventHandler(this.cmbSellStockCode_SelectedIndexChanged);
            // 
            // cmbSellOrderType
            // 
            this.cmbSellOrderType.FormattingEnabled = true;
            this.cmbSellOrderType.Location = new System.Drawing.Point(58, 46);
            this.cmbSellOrderType.Name = "cmbSellOrderType";
            this.cmbSellOrderType.Size = new System.Drawing.Size(121, 20);
            this.cmbSellOrderType.TabIndex = 19;
            this.cmbSellOrderType.SelectedIndexChanged += new System.EventHandler(this.cmbSellOrderType_SelectedIndexChanged);
            // 
            // numSellPrice
            // 
            this.numSellPrice.Location = new System.Drawing.Point(59, 135);
            this.numSellPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numSellPrice.Name = "numSellPrice";
            this.numSellPrice.Size = new System.Drawing.Size(120, 21);
            this.numSellPrice.TabIndex = 18;
            this.numSellPrice.ThousandsSeparator = true;
            // 
            // numSellQuantity
            // 
            this.numSellQuantity.Location = new System.Drawing.Point(58, 74);
            this.numSellQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numSellQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSellQuantity.Name = "numSellQuantity";
            this.numSellQuantity.Size = new System.Drawing.Size(120, 21);
            this.numSellQuantity.TabIndex = 17;
            this.numSellQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "가격";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 12);
            this.label16.TabIndex = 14;
            this.label16.Text = "수량";
            // 
            // btnSellOrder
            // 
            this.btnSellOrder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSellOrder.Location = new System.Drawing.Point(26, 190);
            this.btnSellOrder.Name = "btnSellOrder";
            this.btnSellOrder.Size = new System.Drawing.Size(113, 37);
            this.btnSellOrder.TabIndex = 15;
            this.btnSellOrder.Text = "현금매도";
            this.btnSellOrder.UseVisualStyleBackColor = true;
            this.btnSellOrder.Click += new System.EventHandler(this.btnSellOrder_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 12);
            this.label17.TabIndex = 13;
            this.label17.Text = "유형";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "종목";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancelOrder);
            this.tabPage1.Controls.Add(this.btnModifyOrder);
            this.tabPage1.Controls.Add(this.listViewOrders);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 244);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "정정/취소";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(292, 205);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(80, 30);
            this.btnCancelOrder.TabIndex = 2;
            this.btnCancelOrder.Text = "취소";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.Location = new System.Drawing.Point(200, 205);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(80, 30);
            this.btnModifyOrder.TabIndex = 1;
            this.btnModifyOrder.Text = "정정";
            this.btnModifyOrder.UseVisualStyleBackColor = true;
            this.btnModifyOrder.Click += new System.EventHandler(this.btnModifyOrder_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(3, 3);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(567, 238);
            this.listViewOrders.TabIndex = 0;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "주문번호";
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "종목명";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "코드";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "구분";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "수량";
            this.columnHeader15.Width = 50;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "가격";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "체결";
            this.columnHeader17.Width = 50;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "미체결";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "상태";
            this.columnHeader19.Width = 50;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(931, 622);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(563, 288);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "뉴스 · 공시";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(27, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 220);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(24, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "종목뉴스";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 948);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메인페이지";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBuy.ResumeLayout(false);
            this.tabBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyQuantity)).EndInit();
            this.tabSell.ResumeLayout(false);
            this.tabSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellQuantity)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label chartYLabel;
        private System.Windows.Forms.Button dailyButton;
        private System.Windows.Forms.Button weeklyButton;
        private System.Windows.Forms.Button monthlyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label currentPriceLabel;
        private System.Windows.Forms.Label netChangeLabel;
        private System.Windows.Forms.Label fluctuationRateLabel;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.Label accumulatedVolumeLabel;
        private System.Windows.Forms.Label turnoverRatioLabel;
        private System.Windows.Forms.Label volumeChangeLabel;
        private System.Windows.Forms.Label tradingValueLabel;
        private System.Windows.Forms.Label lowPriceLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label highPriceLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label openPriceLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button minuteButton;
        private System.Windows.Forms.Button tickButton;
        private System.Windows.Forms.Button n1Button;
        private System.Windows.Forms.Button n3Button;
        private System.Windows.Forms.Button n5Button;
        private System.Windows.Forms.Button n10Button;
        private System.Windows.Forms.Button n15Button;
        private System.Windows.Forms.Button n30Button;
        private System.Windows.Forms.Button n45Button;
        private System.Windows.Forms.Button n60Button;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuyOrder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBuy;
        private System.Windows.Forms.ComboBox cmbBuyStockCode;
        private System.Windows.Forms.ComboBox cmbBuyOrderType;
        private System.Windows.Forms.NumericUpDown numBuyPrice;
        private System.Windows.Forms.NumericUpDown numBuyQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabSell;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMyAccounts;
        private System.Windows.Forms.Button btnAccountSerach;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTotalBuy;
        private System.Windows.Forms.Label labelell;
        private System.Windows.Forms.Label labelTotalEval;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelBuyable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSellStockName;
        private System.Windows.Forms.ComboBox cmbSellStockCode;
        private System.Windows.Forms.ComboBox cmbSellOrderType;
        private System.Windows.Forms.NumericUpDown numSellPrice;
        private System.Windows.Forms.NumericUpDown numSellQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSellOrder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblMaxBuyQuantity;
        private System.Windows.Forms.Label lblMaxSellQuantity;
        private System.Windows.Forms.TabPage tabPage4;
        //private System.Windows.Forms.ListView listViewHoldings;
        private CandlestickChart.DoubleBufferedListView listViewHoldings;
        private CandlestickChart.DoubleBufferedListView listViewInterest;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.CheckBox chkInterestBuy;
        private System.Windows.Forms.CheckBox chkInterestSell;
        //private System.Windows.Forms.ListView listViewInterest;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnModifyOrder;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader24;
    }
}

