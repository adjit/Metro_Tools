namespace MetroTools
{
    partial class MetroToolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroToolsForm));
            this.MetroTabControl = new System.Windows.Forms.TabControl();
            this.invoiceLookupTab = new System.Windows.Forms.TabPage();
            this.getInvoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.openStandaloneInvoice = new System.Windows.Forms.Button();
            this.invoiceNumberInput = new System.Windows.Forms.TextBox();
            this.invoiceListGroupBox = new System.Windows.Forms.GroupBox();
            this.invoiceList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openInvoice = new System.Windows.Forms.Button();
            this.lookupGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackingNumberInput = new System.Windows.Forms.TextBox();
            this.tnLabel = new System.Windows.Forms.Label();
            this.invoiceLookupButton = new System.Windows.Forms.Button();
            this.serialNumberInput = new System.Windows.Forms.TextBox();
            this.snLabel = new System.Windows.Forms.Label();
            this.openInvoiceTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectMonthLabel = new System.Windows.Forms.Label();
            this.monthPicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.runQueryButton = new System.Windows.Forms.Button();
            this.lastCreditCardTab = new System.Windows.Forms.TabPage();
            this.ccLookupList = new System.Windows.Forms.GroupBox();
            this.ccDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ccCustLookupButton = new System.Windows.Forms.Button();
            this.ccCustomerNumber = new System.Windows.Forms.TextBox();
            this.custNumberLabel = new System.Windows.Forms.Label();
            this.custExportTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportSaveSettings = new System.Windows.Forms.Button();
            this.btnExportSavePath = new System.Windows.Forms.Button();
            this.chkAutosaveExport = new System.Windows.Forms.CheckBox();
            this.exportSavePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.exportGroup = new System.Windows.Forms.GroupBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.custExportBtn = new System.Windows.Forms.Button();
            this.dateRangeLookupGroup = new System.Windows.Forms.GroupBox();
            this.exportEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.exportStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.customerExportLookup = new System.Windows.Forms.GroupBox();
            this.custExportNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arStatementsTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.arProgressLabel = new System.Windows.Forms.Label();
            this.arProgressBar = new System.Windows.Forms.ProgressBar();
            this.arExportBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.arCustNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resaleTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.resaleDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.resaleLookupBtn = new System.Windows.Forms.Button();
            this.resaleCustNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MetroTabControl.SuspendLayout();
            this.invoiceLookupTab.SuspendLayout();
            this.getInvoiceGroupBox.SuspendLayout();
            this.invoiceListGroupBox.SuspendLayout();
            this.lookupGroupBox.SuspendLayout();
            this.openInvoiceTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.lastCreditCardTab.SuspendLayout();
            this.ccLookupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.custExportTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.exportGroup.SuspendLayout();
            this.dateRangeLookupGroup.SuspendLayout();
            this.customerExportLookup.SuspendLayout();
            this.arStatementsTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.resaleTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resaleDataGridView)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetroTabControl
            // 
            this.MetroTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroTabControl.Controls.Add(this.invoiceLookupTab);
            this.MetroTabControl.Controls.Add(this.openInvoiceTab);
            this.MetroTabControl.Controls.Add(this.lastCreditCardTab);
            this.MetroTabControl.Controls.Add(this.custExportTab);
            this.MetroTabControl.Controls.Add(this.arStatementsTab);
            this.MetroTabControl.Controls.Add(this.resaleTab);
            this.MetroTabControl.Location = new System.Drawing.Point(0, 0);
            this.MetroTabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MetroTabControl.MinimumSize = new System.Drawing.Size(550, 674);
            this.MetroTabControl.Multiline = true;
            this.MetroTabControl.Name = "MetroTabControl";
            this.MetroTabControl.SelectedIndex = 0;
            this.MetroTabControl.Size = new System.Drawing.Size(550, 766);
            this.MetroTabControl.TabIndex = 0;
            this.MetroTabControl.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl_SelectedIndexChanged);
            // 
            // invoiceLookupTab
            // 
            this.invoiceLookupTab.Controls.Add(this.getInvoiceGroupBox);
            this.invoiceLookupTab.Controls.Add(this.invoiceListGroupBox);
            this.invoiceLookupTab.Controls.Add(this.lookupGroupBox);
            this.invoiceLookupTab.Location = new System.Drawing.Point(4, 62);
            this.invoiceLookupTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invoiceLookupTab.Name = "invoiceLookupTab";
            this.invoiceLookupTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invoiceLookupTab.Size = new System.Drawing.Size(542, 700);
            this.invoiceLookupTab.TabIndex = 0;
            this.invoiceLookupTab.Text = "Invoice Lookup";
            this.invoiceLookupTab.UseVisualStyleBackColor = true;
            // 
            // getInvoiceGroupBox
            // 
            this.getInvoiceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getInvoiceGroupBox.Controls.Add(this.openStandaloneInvoice);
            this.getInvoiceGroupBox.Controls.Add(this.invoiceNumberInput);
            this.getInvoiceGroupBox.Location = new System.Drawing.Point(11, 537);
            this.getInvoiceGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.getInvoiceGroupBox.Name = "getInvoiceGroupBox";
            this.getInvoiceGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.getInvoiceGroupBox.Size = new System.Drawing.Size(513, 92);
            this.getInvoiceGroupBox.TabIndex = 12;
            this.getInvoiceGroupBox.TabStop = false;
            this.getInvoiceGroupBox.Text = "Get Specific Invoice";
            // 
            // openStandaloneInvoice
            // 
            this.openStandaloneInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openStandaloneInvoice.Enabled = false;
            this.openStandaloneInvoice.Location = new System.Drawing.Point(324, 31);
            this.openStandaloneInvoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.openStandaloneInvoice.Name = "openStandaloneInvoice";
            this.openStandaloneInvoice.Size = new System.Drawing.Size(169, 42);
            this.openStandaloneInvoice.TabIndex = 1;
            this.openStandaloneInvoice.Text = "Open Invoice";
            this.openStandaloneInvoice.UseVisualStyleBackColor = true;
            this.openStandaloneInvoice.Click += new System.EventHandler(this.openStandaloneInvoice_Click);
            // 
            // invoiceNumberInput
            // 
            this.invoiceNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceNumberInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.invoiceNumberInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.invoiceNumberInput.Location = new System.Drawing.Point(11, 35);
            this.invoiceNumberInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invoiceNumberInput.MaxLength = 7;
            this.invoiceNumberInput.Name = "invoiceNumberInput";
            this.invoiceNumberInput.Size = new System.Drawing.Size(299, 29);
            this.invoiceNumberInput.TabIndex = 3;
            this.invoiceNumberInput.TextChanged += new System.EventHandler(this.invoiceNumberInput_TextChanged);
            // 
            // invoiceListGroupBox
            // 
            this.invoiceListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceListGroupBox.Controls.Add(this.invoiceList);
            this.invoiceListGroupBox.Controls.Add(this.label2);
            this.invoiceListGroupBox.Controls.Add(this.openInvoice);
            this.invoiceListGroupBox.Location = new System.Drawing.Point(11, 236);
            this.invoiceListGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invoiceListGroupBox.Name = "invoiceListGroupBox";
            this.invoiceListGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invoiceListGroupBox.Size = new System.Drawing.Size(513, 290);
            this.invoiceListGroupBox.TabIndex = 11;
            this.invoiceListGroupBox.TabStop = false;
            this.invoiceListGroupBox.Text = "Invoice LIst";
            // 
            // invoiceList
            // 
            this.invoiceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceList.FormattingEnabled = true;
            this.invoiceList.ItemHeight = 24;
            this.invoiceList.Location = new System.Drawing.Point(11, 35);
            this.invoiceList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invoiceList.Name = "invoiceList";
            this.invoiceList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.invoiceList.Size = new System.Drawing.Size(299, 196);
            this.invoiceList.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opens all selected\r\ninvoices";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openInvoice
            // 
            this.openInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openInvoice.AutoSize = true;
            this.openInvoice.Enabled = false;
            this.openInvoice.Location = new System.Drawing.Point(200, 35);
            this.openInvoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.openInvoice.Name = "openInvoice";
            this.openInvoice.Size = new System.Drawing.Size(297, 65);
            this.openInvoice.TabIndex = 4;
            this.openInvoice.Text = "Open Invoice(s)";
            this.openInvoice.UseVisualStyleBackColor = true;
            this.openInvoice.Click += new System.EventHandler(this.openInvoice_Click);
            // 
            // lookupGroupBox
            // 
            this.lookupGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookupGroupBox.Controls.Add(this.label3);
            this.lookupGroupBox.Controls.Add(this.trackingNumberInput);
            this.lookupGroupBox.Controls.Add(this.tnLabel);
            this.lookupGroupBox.Controls.Add(this.invoiceLookupButton);
            this.lookupGroupBox.Controls.Add(this.serialNumberInput);
            this.lookupGroupBox.Controls.Add(this.snLabel);
            this.lookupGroupBox.Location = new System.Drawing.Point(11, 11);
            this.lookupGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lookupGroupBox.Name = "lookupGroupBox";
            this.lookupGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lookupGroupBox.Size = new System.Drawing.Size(513, 214);
            this.lookupGroupBox.TabIndex = 10;
            this.lookupGroupBox.TabStop = false;
            this.lookupGroupBox.Text = "Lookup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "OR";
            // 
            // trackingNumberInput
            // 
            this.trackingNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackingNumberInput.Location = new System.Drawing.Point(191, 102);
            this.trackingNumberInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trackingNumberInput.Name = "trackingNumberInput";
            this.trackingNumberInput.Size = new System.Drawing.Size(308, 29);
            this.trackingNumberInput.TabIndex = 4;
            // 
            // tnLabel
            // 
            this.tnLabel.AutoSize = true;
            this.tnLabel.Location = new System.Drawing.Point(11, 107);
            this.tnLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tnLabel.Name = "tnLabel";
            this.tnLabel.Size = new System.Drawing.Size(168, 25);
            this.tnLabel.TabIndex = 3;
            this.tnLabel.Text = "Tracking Number:";
            // 
            // invoiceLookupButton
            // 
            this.invoiceLookupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceLookupButton.Location = new System.Drawing.Point(365, 150);
            this.invoiceLookupButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invoiceLookupButton.Name = "invoiceLookupButton";
            this.invoiceLookupButton.Size = new System.Drawing.Size(138, 42);
            this.invoiceLookupButton.TabIndex = 2;
            this.invoiceLookupButton.Text = "Ok";
            this.invoiceLookupButton.UseVisualStyleBackColor = true;
            this.invoiceLookupButton.Click += new System.EventHandler(this.invoiceLookupButton_Click);
            // 
            // serialNumberInput
            // 
            this.serialNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialNumberInput.Location = new System.Drawing.Point(161, 42);
            this.serialNumberInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serialNumberInput.Name = "serialNumberInput";
            this.serialNumberInput.Size = new System.Drawing.Size(338, 29);
            this.serialNumberInput.TabIndex = 1;
            // 
            // snLabel
            // 
            this.snLabel.AutoSize = true;
            this.snLabel.Location = new System.Drawing.Point(11, 48);
            this.snLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.snLabel.Name = "snLabel";
            this.snLabel.Size = new System.Drawing.Size(142, 25);
            this.snLabel.TabIndex = 0;
            this.snLabel.Text = "Serial Number:";
            // 
            // openInvoiceTab
            // 
            this.openInvoiceTab.Controls.Add(this.tableLayoutPanel1);
            this.openInvoiceTab.Location = new System.Drawing.Point(4, 91);
            this.openInvoiceTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.openInvoiceTab.Name = "openInvoiceTab";
            this.openInvoiceTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.openInvoiceTab.Size = new System.Drawing.Size(542, 671);
            this.openInvoiceTab.TabIndex = 1;
            this.openInvoiceTab.Text = "Epson POS Report";
            this.openInvoiceTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.25874F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.74126F));
            this.tableLayoutPanel1.Controls.Add(this.selectMonthLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.monthPicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.runQueryButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 208);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectMonthLabel
            // 
            this.selectMonthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectMonthLabel.AutoSize = true;
            this.selectMonthLabel.Location = new System.Drawing.Point(7, 143);
            this.selectMonthLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.selectMonthLabel.MinimumSize = new System.Drawing.Size(183, 18);
            this.selectMonthLabel.Name = "selectMonthLabel";
            this.selectMonthLabel.Size = new System.Drawing.Size(204, 25);
            this.selectMonthLabel.TabIndex = 1;
            // 
            // monthPicker
            // 
            this.monthPicker.CustomFormat = "MMMM-  yyyy";
            this.monthPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthPicker.Location = new System.Drawing.Point(225, 9);
            this.monthPicker.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(298, 29);
            this.monthPicker.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Select First of Month";
            // 
            // runQueryButton
            // 
            this.runQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runQueryButton.Location = new System.Drawing.Point(224, 110);
            this.runQueryButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.runQueryButton.Name = "runQueryButton";
            this.runQueryButton.Size = new System.Drawing.Size(300, 92);
            this.runQueryButton.TabIndex = 4;
            this.runQueryButton.Text = "Run Query";
            this.runQueryButton.UseVisualStyleBackColor = true;
            this.runQueryButton.Click += new System.EventHandler(this.runQueryButton_Click);
            // 
            // lastCreditCardTab
            // 
            this.lastCreditCardTab.Controls.Add(this.ccLookupList);
            this.lastCreditCardTab.Controls.Add(this.groupBox1);
            this.lastCreditCardTab.Location = new System.Drawing.Point(4, 62);
            this.lastCreditCardTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lastCreditCardTab.Name = "lastCreditCardTab";
            this.lastCreditCardTab.Size = new System.Drawing.Size(542, 700);
            this.lastCreditCardTab.TabIndex = 2;
            this.lastCreditCardTab.Text = "Last Credit Card";
            this.lastCreditCardTab.UseVisualStyleBackColor = true;
            // 
            // ccLookupList
            // 
            this.ccLookupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccLookupList.Controls.Add(this.ccDataGridView);
            this.ccLookupList.Location = new System.Drawing.Point(16, 190);
            this.ccLookupList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ccLookupList.Name = "ccLookupList";
            this.ccLookupList.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ccLookupList.Size = new System.Drawing.Size(502, 506);
            this.ccLookupList.TabIndex = 1;
            this.ccLookupList.TabStop = false;
            this.ccLookupList.Text = "Last Credit Card List";
            // 
            // ccDataGridView
            // 
            this.ccDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ccDataGridView.Location = new System.Drawing.Point(15, 35);
            this.ccDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ccDataGridView.Name = "ccDataGridView";
            this.ccDataGridView.RowHeadersWidth = 72;
            this.ccDataGridView.Size = new System.Drawing.Size(477, 460);
            this.ccDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ccCustLookupButton);
            this.groupBox1.Controls.Add(this.ccCustomerNumber);
            this.groupBox1.Controls.Add(this.custNumberLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(504, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Lookup";
            // 
            // ccCustLookupButton
            // 
            this.ccCustLookupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ccCustLookupButton.Location = new System.Drawing.Point(356, 92);
            this.ccCustLookupButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ccCustLookupButton.Name = "ccCustLookupButton";
            this.ccCustLookupButton.Size = new System.Drawing.Size(138, 42);
            this.ccCustLookupButton.TabIndex = 2;
            this.ccCustLookupButton.Text = "Ok";
            this.ccCustLookupButton.UseVisualStyleBackColor = true;
            this.ccCustLookupButton.Click += new System.EventHandler(this.ccCustLookupButton_Click);
            // 
            // ccCustomerNumber
            // 
            this.ccCustomerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccCustomerNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ccCustomerNumber.Location = new System.Drawing.Point(189, 44);
            this.ccCustomerNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ccCustomerNumber.MaxLength = 10;
            this.ccCustomerNumber.Name = "ccCustomerNumber";
            this.ccCustomerNumber.Size = new System.Drawing.Size(301, 29);
            this.ccCustomerNumber.TabIndex = 1;
            this.ccCustomerNumber.TextChanged += new System.EventHandler(this.ccCustomerNumber_TextChanged);
            // 
            // custNumberLabel
            // 
            this.custNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custNumberLabel.AutoSize = true;
            this.custNumberLabel.Location = new System.Drawing.Point(11, 50);
            this.custNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.custNumberLabel.Name = "custNumberLabel";
            this.custNumberLabel.Size = new System.Drawing.Size(177, 25);
            this.custNumberLabel.TabIndex = 0;
            this.custNumberLabel.Text = "Customer Number:";
            // 
            // custExportTab
            // 
            this.custExportTab.Controls.Add(this.groupBox2);
            this.custExportTab.Controls.Add(this.exportGroup);
            this.custExportTab.Controls.Add(this.dateRangeLookupGroup);
            this.custExportTab.Controls.Add(this.customerExportLookup);
            this.custExportTab.Location = new System.Drawing.Point(4, 62);
            this.custExportTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.custExportTab.Name = "custExportTab";
            this.custExportTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.custExportTab.Size = new System.Drawing.Size(542, 700);
            this.custExportTab.TabIndex = 3;
            this.custExportTab.Text = "Customer History Export";
            this.custExportTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnExportSaveSettings);
            this.groupBox2.Controls.Add(this.btnExportSavePath);
            this.groupBox2.Controls.Add(this.chkAutosaveExport);
            this.groupBox2.Controls.Add(this.exportSavePath);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(15, 443);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(510, 220);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // btnExportSaveSettings
            // 
            this.btnExportSaveSettings.Location = new System.Drawing.Point(213, 116);
            this.btnExportSaveSettings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExportSaveSettings.Name = "btnExportSaveSettings";
            this.btnExportSaveSettings.Size = new System.Drawing.Size(138, 42);
            this.btnExportSaveSettings.TabIndex = 6;
            this.btnExportSaveSettings.Text = "Save";
            this.btnExportSaveSettings.UseVisualStyleBackColor = true;
            this.btnExportSaveSettings.Click += new System.EventHandler(this.btnExportSaveSettings_Click);
            // 
            // btnExportSavePath
            // 
            this.btnExportSavePath.Location = new System.Drawing.Point(359, 116);
            this.btnExportSavePath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExportSavePath.Name = "btnExportSavePath";
            this.btnExportSavePath.Size = new System.Drawing.Size(138, 42);
            this.btnExportSavePath.TabIndex = 5;
            this.btnExportSavePath.Text = "Browse";
            this.btnExportSavePath.UseVisualStyleBackColor = true;
            this.btnExportSavePath.Click += new System.EventHandler(this.btnExportSavePath_Click);
            // 
            // chkAutosaveExport
            // 
            this.chkAutosaveExport.AutoSize = true;
            this.chkAutosaveExport.Location = new System.Drawing.Point(20, 35);
            this.chkAutosaveExport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkAutosaveExport.Name = "chkAutosaveExport";
            this.chkAutosaveExport.Size = new System.Drawing.Size(182, 29);
            this.chkAutosaveExport.TabIndex = 4;
            this.chkAutosaveExport.Text = "Autosave Export";
            this.chkAutosaveExport.UseVisualStyleBackColor = true;
            // 
            // exportSavePath
            // 
            this.exportSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportSavePath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.exportSavePath.Location = new System.Drawing.Point(180, 66);
            this.exportSavePath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exportSavePath.MaxLength = 500;
            this.exportSavePath.Name = "exportSavePath";
            this.exportSavePath.Size = new System.Drawing.Size(319, 29);
            this.exportSavePath.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "SaveAs Location:";
            // 
            // exportGroup
            // 
            this.exportGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportGroup.Controls.Add(this.progressLabel);
            this.exportGroup.Controls.Add(this.progressBar);
            this.exportGroup.Controls.Add(this.custExportBtn);
            this.exportGroup.Location = new System.Drawing.Point(15, 297);
            this.exportGroup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exportGroup.Name = "exportGroup";
            this.exportGroup.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exportGroup.Size = new System.Drawing.Size(510, 133);
            this.exportGroup.TabIndex = 3;
            this.exportGroup.TabStop = false;
            this.exportGroup.Text = "Export";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(11, 83);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(90, 25);
            this.progressLabel.TabIndex = 4;
            this.progressLabel.Text = "Progress";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(11, 35);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(339, 42);
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // custExportBtn
            // 
            this.custExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.custExportBtn.Location = new System.Drawing.Point(361, 35);
            this.custExportBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.custExportBtn.Name = "custExportBtn";
            this.custExportBtn.Size = new System.Drawing.Size(138, 42);
            this.custExportBtn.TabIndex = 2;
            this.custExportBtn.Text = "Export";
            this.custExportBtn.UseVisualStyleBackColor = true;
            this.custExportBtn.Click += new System.EventHandler(this.custExportBtn_Click);
            // 
            // dateRangeLookupGroup
            // 
            this.dateRangeLookupGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateRangeLookupGroup.Controls.Add(this.exportEndDate);
            this.dateRangeLookupGroup.Controls.Add(this.label5);
            this.dateRangeLookupGroup.Controls.Add(this.exportStartDate);
            this.dateRangeLookupGroup.Controls.Add(this.label4);
            this.dateRangeLookupGroup.Location = new System.Drawing.Point(15, 129);
            this.dateRangeLookupGroup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateRangeLookupGroup.Name = "dateRangeLookupGroup";
            this.dateRangeLookupGroup.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateRangeLookupGroup.Size = new System.Drawing.Size(510, 157);
            this.dateRangeLookupGroup.TabIndex = 2;
            this.dateRangeLookupGroup.TabStop = false;
            this.dateRangeLookupGroup.Text = "Date Range";
            // 
            // exportEndDate
            // 
            this.exportEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportEndDate.Location = new System.Drawing.Point(126, 85);
            this.exportEndDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exportEndDate.Name = "exportEndDate";
            this.exportEndDate.Size = new System.Drawing.Size(369, 29);
            this.exportEndDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "End Date:";
            // 
            // exportStartDate
            // 
            this.exportStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportStartDate.Location = new System.Drawing.Point(126, 37);
            this.exportStartDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exportStartDate.Name = "exportStartDate";
            this.exportStartDate.Size = new System.Drawing.Size(369, 29);
            this.exportStartDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Date:";
            // 
            // customerExportLookup
            // 
            this.customerExportLookup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerExportLookup.Controls.Add(this.custExportNum);
            this.customerExportLookup.Controls.Add(this.label1);
            this.customerExportLookup.Location = new System.Drawing.Point(15, 11);
            this.customerExportLookup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customerExportLookup.Name = "customerExportLookup";
            this.customerExportLookup.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customerExportLookup.Size = new System.Drawing.Size(510, 107);
            this.customerExportLookup.TabIndex = 1;
            this.customerExportLookup.TabStop = false;
            this.customerExportLookup.Text = "Customer Lookup";
            // 
            // custExportNum
            // 
            this.custExportNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custExportNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.custExportNum.Location = new System.Drawing.Point(189, 44);
            this.custExportNum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.custExportNum.MaxLength = 10;
            this.custExportNum.Name = "custExportNum";
            this.custExportNum.Size = new System.Drawing.Size(306, 29);
            this.custExportNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Number:";
            // 
            // arStatementsTab
            // 
            this.arStatementsTab.Controls.Add(this.groupBox4);
            this.arStatementsTab.Controls.Add(this.groupBox3);
            this.arStatementsTab.Location = new System.Drawing.Point(4, 62);
            this.arStatementsTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.arStatementsTab.Name = "arStatementsTab";
            this.arStatementsTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.arStatementsTab.Size = new System.Drawing.Size(542, 700);
            this.arStatementsTab.TabIndex = 4;
            this.arStatementsTab.Text = "A/R Statements";
            this.arStatementsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.arProgressLabel);
            this.groupBox4.Controls.Add(this.arProgressBar);
            this.groupBox4.Controls.Add(this.arExportBtn);
            this.groupBox4.Location = new System.Drawing.Point(15, 129);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(510, 133);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Export";
            // 
            // arProgressLabel
            // 
            this.arProgressLabel.AutoSize = true;
            this.arProgressLabel.Location = new System.Drawing.Point(11, 83);
            this.arProgressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.arProgressLabel.Name = "arProgressLabel";
            this.arProgressLabel.Size = new System.Drawing.Size(90, 25);
            this.arProgressLabel.TabIndex = 4;
            this.arProgressLabel.Text = "Progress";
            // 
            // arProgressBar
            // 
            this.arProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arProgressBar.Location = new System.Drawing.Point(11, 35);
            this.arProgressBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.arProgressBar.Name = "arProgressBar";
            this.arProgressBar.Size = new System.Drawing.Size(339, 42);
            this.arProgressBar.TabIndex = 3;
            this.arProgressBar.Visible = false;
            // 
            // arExportBtn
            // 
            this.arExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.arExportBtn.Location = new System.Drawing.Point(361, 35);
            this.arExportBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.arExportBtn.Name = "arExportBtn";
            this.arExportBtn.Size = new System.Drawing.Size(138, 42);
            this.arExportBtn.TabIndex = 2;
            this.arExportBtn.Text = "Export";
            this.arExportBtn.UseVisualStyleBackColor = true;
            this.arExportBtn.Click += new System.EventHandler(this.arExportBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.arCustNumber);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(15, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(510, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Lookup";
            // 
            // arCustNumber
            // 
            this.arCustNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arCustNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.arCustNumber.Location = new System.Drawing.Point(189, 44);
            this.arCustNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.arCustNumber.MaxLength = 10;
            this.arCustNumber.Name = "arCustNumber";
            this.arCustNumber.Size = new System.Drawing.Size(306, 29);
            this.arCustNumber.TabIndex = 1;
            this.arCustNumber.TextChanged += new System.EventHandler(this.arCustNumber_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Customer Number:";
            // 
            // resaleTab
            // 
            this.resaleTab.Controls.Add(this.groupBox5);
            this.resaleTab.Controls.Add(this.groupBox6);
            this.resaleTab.Location = new System.Drawing.Point(4, 62);
            this.resaleTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resaleTab.Name = "resaleTab";
            this.resaleTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resaleTab.Size = new System.Drawing.Size(542, 700);
            this.resaleTab.TabIndex = 5;
            this.resaleTab.Text = "Resale Lookup";
            this.resaleTab.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.resaleDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(16, 201);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Size = new System.Drawing.Size(502, 439);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resale Certificate List";
            // 
            // resaleDataGridView
            // 
            this.resaleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resaleDataGridView.Location = new System.Drawing.Point(11, 35);
            this.resaleDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resaleDataGridView.Name = "resaleDataGridView";
            this.resaleDataGridView.RowHeadersWidth = 72;
            this.resaleDataGridView.Size = new System.Drawing.Size(477, 393);
            this.resaleDataGridView.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.resaleLookupBtn);
            this.groupBox6.Controls.Add(this.resaleCustNum);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(15, 11);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox6.Size = new System.Drawing.Size(504, 155);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Customer Lookup";
            // 
            // resaleLookupBtn
            // 
            this.resaleLookupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resaleLookupBtn.Location = new System.Drawing.Point(356, 92);
            this.resaleLookupBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resaleLookupBtn.Name = "resaleLookupBtn";
            this.resaleLookupBtn.Size = new System.Drawing.Size(138, 42);
            this.resaleLookupBtn.TabIndex = 2;
            this.resaleLookupBtn.Text = "Ok";
            this.resaleLookupBtn.UseVisualStyleBackColor = true;
            this.resaleLookupBtn.Click += new System.EventHandler(this.resaleLookupBtn_Click);
            // 
            // resaleCustNum
            // 
            this.resaleCustNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resaleCustNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.resaleCustNum.Location = new System.Drawing.Point(189, 44);
            this.resaleCustNum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resaleCustNum.MaxLength = 10;
            this.resaleCustNum.Name = "resaleCustNum";
            this.resaleCustNum.Size = new System.Drawing.Size(301, 29);
            this.resaleCustNum.TabIndex = 1;
            this.resaleCustNum.TextChanged += new System.EventHandler(this.resaleCustNum_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Number:";
            // 
            // MetroToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 759);
            this.Controls.Add(this.MetroTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(558, 684);
            this.Name = "MetroToolsForm";
            this.Text = "Metro Tools";
            this.MetroTabControl.ResumeLayout(false);
            this.invoiceLookupTab.ResumeLayout(false);
            this.getInvoiceGroupBox.ResumeLayout(false);
            this.getInvoiceGroupBox.PerformLayout();
            this.invoiceListGroupBox.ResumeLayout(false);
            this.invoiceListGroupBox.PerformLayout();
            this.lookupGroupBox.ResumeLayout(false);
            this.lookupGroupBox.PerformLayout();
            this.openInvoiceTab.ResumeLayout(false);
            this.openInvoiceTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.lastCreditCardTab.ResumeLayout(false);
            this.ccLookupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ccDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.custExportTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.exportGroup.ResumeLayout(false);
            this.exportGroup.PerformLayout();
            this.dateRangeLookupGroup.ResumeLayout(false);
            this.dateRangeLookupGroup.PerformLayout();
            this.customerExportLookup.ResumeLayout(false);
            this.customerExportLookup.PerformLayout();
            this.arStatementsTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.resaleTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resaleDataGridView)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MetroTabControl;
        private System.Windows.Forms.TabPage invoiceLookupTab;
        private System.Windows.Forms.GroupBox getInvoiceGroupBox;
        private System.Windows.Forms.Button openStandaloneInvoice;
        private System.Windows.Forms.TextBox invoiceNumberInput;
        private System.Windows.Forms.GroupBox invoiceListGroupBox;
        private System.Windows.Forms.ListBox invoiceList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openInvoice;
        private System.Windows.Forms.GroupBox lookupGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox trackingNumberInput;
        private System.Windows.Forms.Label tnLabel;
        private System.Windows.Forms.Button invoiceLookupButton;
        private System.Windows.Forms.TextBox serialNumberInput;
        private System.Windows.Forms.Label snLabel;
        private System.Windows.Forms.TabPage lastCreditCardTab;
        private System.Windows.Forms.GroupBox ccLookupList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ccCustLookupButton;
        private System.Windows.Forms.Label custNumberLabel;
        private System.Windows.Forms.TextBox ccCustomerNumber;
        private System.Windows.Forms.DataGridView ccDataGridView;
        private System.Windows.Forms.TabPage custExportTab;
        private System.Windows.Forms.Button custExportBtn;
        private System.Windows.Forms.GroupBox dateRangeLookupGroup;
        private System.Windows.Forms.DateTimePicker exportEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker exportStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox customerExportLookup;
        private System.Windows.Forms.TextBox custExportNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox exportGroup;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportSavePath;
        private System.Windows.Forms.CheckBox chkAutosaveExport;
        private System.Windows.Forms.TextBox exportSavePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExportSaveSettings;
        private System.Windows.Forms.TabPage arStatementsTab;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label arProgressLabel;
        private System.Windows.Forms.ProgressBar arProgressBar;
        private System.Windows.Forms.Button arExportBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox arCustNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage resaleTab;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView resaleDataGridView;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button resaleLookupBtn;
        private System.Windows.Forms.TextBox resaleCustNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage openInvoiceTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label selectMonthLabel;
        private System.Windows.Forms.DateTimePicker monthPicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button runQueryButton;
    }
}

