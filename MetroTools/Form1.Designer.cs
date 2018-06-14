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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lastCreditCardTab = new System.Windows.Forms.TabPage();
            this.ccLookupList = new System.Windows.Forms.GroupBox();
            this.ccDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ccCustLookupButton = new System.Windows.Forms.Button();
            this.ccCustomerNumber = new System.Windows.Forms.TextBox();
            this.custNumberLabel = new System.Windows.Forms.Label();
            this.custExportTab = new System.Windows.Forms.TabPage();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exportSavePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAutosaveExport = new System.Windows.Forms.CheckBox();
            this.btnExportSavePath = new System.Windows.Forms.Button();
            this.btnExportSaveSettings = new System.Windows.Forms.Button();
            this.MetroTabControl.SuspendLayout();
            this.invoiceLookupTab.SuspendLayout();
            this.getInvoiceGroupBox.SuspendLayout();
            this.invoiceListGroupBox.SuspendLayout();
            this.lookupGroupBox.SuspendLayout();
            this.openInvoiceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.lastCreditCardTab.SuspendLayout();
            this.ccLookupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.custExportTab.SuspendLayout();
            this.exportGroup.SuspendLayout();
            this.dateRangeLookupGroup.SuspendLayout();
            this.customerExportLookup.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.MetroTabControl.Location = new System.Drawing.Point(0, 0);
            this.MetroTabControl.MinimumSize = new System.Drawing.Size(300, 365);
            this.MetroTabControl.Multiline = true;
            this.MetroTabControl.Name = "MetroTabControl";
            this.MetroTabControl.SelectedIndex = 0;
            this.MetroTabControl.Size = new System.Drawing.Size(300, 415);
            this.MetroTabControl.TabIndex = 0;
            this.MetroTabControl.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl_SelectedIndexChanged);
            // 
            // invoiceLookupTab
            // 
            this.invoiceLookupTab.Controls.Add(this.getInvoiceGroupBox);
            this.invoiceLookupTab.Controls.Add(this.invoiceListGroupBox);
            this.invoiceLookupTab.Controls.Add(this.lookupGroupBox);
            this.invoiceLookupTab.Location = new System.Drawing.Point(4, 40);
            this.invoiceLookupTab.Name = "invoiceLookupTab";
            this.invoiceLookupTab.Padding = new System.Windows.Forms.Padding(3);
            this.invoiceLookupTab.Size = new System.Drawing.Size(292, 321);
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
            this.getInvoiceGroupBox.Location = new System.Drawing.Point(6, 259);
            this.getInvoiceGroupBox.Name = "getInvoiceGroupBox";
            this.getInvoiceGroupBox.Size = new System.Drawing.Size(280, 50);
            this.getInvoiceGroupBox.TabIndex = 12;
            this.getInvoiceGroupBox.TabStop = false;
            this.getInvoiceGroupBox.Text = "Get Specific Invoice";
            // 
            // openStandaloneInvoice
            // 
            this.openStandaloneInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openStandaloneInvoice.Enabled = false;
            this.openStandaloneInvoice.Location = new System.Drawing.Point(177, 17);
            this.openStandaloneInvoice.Name = "openStandaloneInvoice";
            this.openStandaloneInvoice.Size = new System.Drawing.Size(92, 23);
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
            this.invoiceNumberInput.Location = new System.Drawing.Point(6, 19);
            this.invoiceNumberInput.MaxLength = 7;
            this.invoiceNumberInput.Name = "invoiceNumberInput";
            this.invoiceNumberInput.Size = new System.Drawing.Size(165, 20);
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
            this.invoiceListGroupBox.Location = new System.Drawing.Point(6, 128);
            this.invoiceListGroupBox.Name = "invoiceListGroupBox";
            this.invoiceListGroupBox.Size = new System.Drawing.Size(280, 125);
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
            this.invoiceList.Location = new System.Drawing.Point(6, 19);
            this.invoiceList.Name = "invoiceList";
            this.invoiceList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.invoiceList.Size = new System.Drawing.Size(165, 95);
            this.invoiceList.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opens all selected\r\ninvoices";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openInvoice
            // 
            this.openInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openInvoice.AutoSize = true;
            this.openInvoice.Enabled = false;
            this.openInvoice.Location = new System.Drawing.Point(179, 19);
            this.openInvoice.Name = "openInvoice";
            this.openInvoice.Size = new System.Drawing.Size(92, 23);
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
            this.lookupGroupBox.Location = new System.Drawing.Point(6, 6);
            this.lookupGroupBox.Name = "lookupGroupBox";
            this.lookupGroupBox.Size = new System.Drawing.Size(280, 116);
            this.lookupGroupBox.TabIndex = 10;
            this.lookupGroupBox.TabStop = false;
            this.lookupGroupBox.Text = "Lookup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "OR";
            // 
            // trackingNumberInput
            // 
            this.trackingNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackingNumberInput.Location = new System.Drawing.Point(104, 55);
            this.trackingNumberInput.Name = "trackingNumberInput";
            this.trackingNumberInput.Size = new System.Drawing.Size(170, 20);
            this.trackingNumberInput.TabIndex = 4;
            // 
            // tnLabel
            // 
            this.tnLabel.AutoSize = true;
            this.tnLabel.Location = new System.Drawing.Point(6, 58);
            this.tnLabel.Name = "tnLabel";
            this.tnLabel.Size = new System.Drawing.Size(92, 13);
            this.tnLabel.TabIndex = 3;
            this.tnLabel.Text = "Tracking Number:";
            // 
            // invoiceLookupButton
            // 
            this.invoiceLookupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceLookupButton.Location = new System.Drawing.Point(199, 81);
            this.invoiceLookupButton.Name = "invoiceLookupButton";
            this.invoiceLookupButton.Size = new System.Drawing.Size(75, 23);
            this.invoiceLookupButton.TabIndex = 2;
            this.invoiceLookupButton.Text = "Ok";
            this.invoiceLookupButton.UseVisualStyleBackColor = true;
            this.invoiceLookupButton.Click += new System.EventHandler(this.invoiceLookupButton_Click);
            // 
            // serialNumberInput
            // 
            this.serialNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialNumberInput.Location = new System.Drawing.Point(88, 23);
            this.serialNumberInput.Name = "serialNumberInput";
            this.serialNumberInput.Size = new System.Drawing.Size(186, 20);
            this.serialNumberInput.TabIndex = 1;
            // 
            // snLabel
            // 
            this.snLabel.AutoSize = true;
            this.snLabel.Location = new System.Drawing.Point(6, 26);
            this.snLabel.Name = "snLabel";
            this.snLabel.Size = new System.Drawing.Size(76, 13);
            this.snLabel.TabIndex = 0;
            this.snLabel.Text = "Serial Number:";
            // 
            // openInvoiceTab
            // 
            this.openInvoiceTab.Controls.Add(this.pictureBox1);
            this.openInvoiceTab.Location = new System.Drawing.Point(4, 40);
            this.openInvoiceTab.Name = "openInvoiceTab";
            this.openInvoiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.openInvoiceTab.Size = new System.Drawing.Size(292, 421);
            this.openInvoiceTab.TabIndex = 1;
            this.openInvoiceTab.Text = "Open Invoice Report";
            this.openInvoiceTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MetroTools.Properties.Resources.UnderConstruction_PS;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lastCreditCardTab
            // 
            this.lastCreditCardTab.Controls.Add(this.ccLookupList);
            this.lastCreditCardTab.Controls.Add(this.groupBox1);
            this.lastCreditCardTab.Location = new System.Drawing.Point(4, 40);
            this.lastCreditCardTab.Name = "lastCreditCardTab";
            this.lastCreditCardTab.Size = new System.Drawing.Size(292, 421);
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
            this.ccLookupList.Location = new System.Drawing.Point(9, 103);
            this.ccLookupList.Name = "ccLookupList";
            this.ccLookupList.Size = new System.Drawing.Size(274, 206);
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
            this.ccDataGridView.Location = new System.Drawing.Point(8, 19);
            this.ccDataGridView.Name = "ccDataGridView";
            this.ccDataGridView.Size = new System.Drawing.Size(260, 181);
            this.ccDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ccCustLookupButton);
            this.groupBox1.Controls.Add(this.ccCustomerNumber);
            this.groupBox1.Controls.Add(this.custNumberLabel);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Lookup";
            // 
            // ccCustLookupButton
            // 
            this.ccCustLookupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ccCustLookupButton.Location = new System.Drawing.Point(194, 50);
            this.ccCustLookupButton.Name = "ccCustLookupButton";
            this.ccCustLookupButton.Size = new System.Drawing.Size(75, 23);
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
            this.ccCustomerNumber.Location = new System.Drawing.Point(103, 24);
            this.ccCustomerNumber.MaxLength = 10;
            this.ccCustomerNumber.Name = "ccCustomerNumber";
            this.ccCustomerNumber.Size = new System.Drawing.Size(166, 20);
            this.ccCustomerNumber.TabIndex = 1;
            this.ccCustomerNumber.TextChanged += new System.EventHandler(this.ccCustomerNumber_TextChanged);
            // 
            // custNumberLabel
            // 
            this.custNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custNumberLabel.AutoSize = true;
            this.custNumberLabel.Location = new System.Drawing.Point(6, 27);
            this.custNumberLabel.Name = "custNumberLabel";
            this.custNumberLabel.Size = new System.Drawing.Size(94, 13);
            this.custNumberLabel.TabIndex = 0;
            this.custNumberLabel.Text = "Customer Number:";
            // 
            // custExportTab
            // 
            this.custExportTab.Controls.Add(this.groupBox2);
            this.custExportTab.Controls.Add(this.exportGroup);
            this.custExportTab.Controls.Add(this.dateRangeLookupGroup);
            this.custExportTab.Controls.Add(this.customerExportLookup);
            this.custExportTab.Location = new System.Drawing.Point(4, 40);
            this.custExportTab.Name = "custExportTab";
            this.custExportTab.Padding = new System.Windows.Forms.Padding(3);
            this.custExportTab.Size = new System.Drawing.Size(292, 371);
            this.custExportTab.TabIndex = 3;
            this.custExportTab.Text = "Customer History Export";
            this.custExportTab.UseVisualStyleBackColor = true;
            // 
            // exportGroup
            // 
            this.exportGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportGroup.Controls.Add(this.progressLabel);
            this.exportGroup.Controls.Add(this.progressBar);
            this.exportGroup.Controls.Add(this.custExportBtn);
            this.exportGroup.Location = new System.Drawing.Point(8, 161);
            this.exportGroup.Name = "exportGroup";
            this.exportGroup.Size = new System.Drawing.Size(278, 72);
            this.exportGroup.TabIndex = 3;
            this.exportGroup.TabStop = false;
            this.exportGroup.Text = "Export";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(6, 45);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(48, 13);
            this.progressLabel.TabIndex = 4;
            this.progressLabel.Text = "Progress";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(6, 19);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(185, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // custExportBtn
            // 
            this.custExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.custExportBtn.Location = new System.Drawing.Point(197, 19);
            this.custExportBtn.Name = "custExportBtn";
            this.custExportBtn.Size = new System.Drawing.Size(75, 23);
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
            this.dateRangeLookupGroup.Location = new System.Drawing.Point(8, 70);
            this.dateRangeLookupGroup.Name = "dateRangeLookupGroup";
            this.dateRangeLookupGroup.Size = new System.Drawing.Size(278, 85);
            this.dateRangeLookupGroup.TabIndex = 2;
            this.dateRangeLookupGroup.TabStop = false;
            this.dateRangeLookupGroup.Text = "Date Range";
            // 
            // exportEndDate
            // 
            this.exportEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportEndDate.Location = new System.Drawing.Point(69, 46);
            this.exportEndDate.Name = "exportEndDate";
            this.exportEndDate.Size = new System.Drawing.Size(203, 20);
            this.exportEndDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "End Date:";
            // 
            // exportStartDate
            // 
            this.exportStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportStartDate.Location = new System.Drawing.Point(69, 20);
            this.exportStartDate.Name = "exportStartDate";
            this.exportStartDate.Size = new System.Drawing.Size(203, 20);
            this.exportStartDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Date:";
            // 
            // customerExportLookup
            // 
            this.customerExportLookup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerExportLookup.Controls.Add(this.custExportNum);
            this.customerExportLookup.Controls.Add(this.label1);
            this.customerExportLookup.Location = new System.Drawing.Point(8, 6);
            this.customerExportLookup.Name = "customerExportLookup";
            this.customerExportLookup.Size = new System.Drawing.Size(278, 58);
            this.customerExportLookup.TabIndex = 1;
            this.customerExportLookup.TabStop = false;
            this.customerExportLookup.Text = "Customer Lookup";
            // 
            // custExportNum
            // 
            this.custExportNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custExportNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.custExportNum.Location = new System.Drawing.Point(103, 24);
            this.custExportNum.MaxLength = 10;
            this.custExportNum.Name = "custExportNum";
            this.custExportNum.Size = new System.Drawing.Size(169, 20);
            this.custExportNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Number:";
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
            this.groupBox2.Location = new System.Drawing.Point(8, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 119);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // exportSavePath
            // 
            this.exportSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportSavePath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.exportSavePath.Location = new System.Drawing.Point(98, 36);
            this.exportSavePath.MaxLength = 10;
            this.exportSavePath.Name = "exportSavePath";
            this.exportSavePath.Size = new System.Drawing.Size(176, 20);
            this.exportSavePath.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "SaveAs Location:";
            // 
            // chkAutosaveExport
            // 
            this.chkAutosaveExport.AutoSize = true;
            this.chkAutosaveExport.Location = new System.Drawing.Point(11, 19);
            this.chkAutosaveExport.Name = "chkAutosaveExport";
            this.chkAutosaveExport.Size = new System.Drawing.Size(104, 17);
            this.chkAutosaveExport.TabIndex = 4;
            this.chkAutosaveExport.Text = "Autosave Export";
            this.chkAutosaveExport.UseVisualStyleBackColor = true;
            // 
            // btnExportSavePath
            // 
            this.btnExportSavePath.Location = new System.Drawing.Point(196, 63);
            this.btnExportSavePath.Name = "btnExportSavePath";
            this.btnExportSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnExportSavePath.TabIndex = 5;
            this.btnExportSavePath.Text = "Browse";
            this.btnExportSavePath.UseVisualStyleBackColor = true;
            this.btnExportSavePath.Click += new System.EventHandler(this.btnExportSavePath_Click);
            // 
            // btnExportSaveSettings
            // 
            this.btnExportSaveSettings.Location = new System.Drawing.Point(116, 63);
            this.btnExportSaveSettings.Name = "btnExportSaveSettings";
            this.btnExportSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnExportSaveSettings.TabIndex = 6;
            this.btnExportSaveSettings.Text = "Save";
            this.btnExportSaveSettings.UseVisualStyleBackColor = true;
            this.btnExportSaveSettings.Click += new System.EventHandler(this.btnExportSaveSettings_Click);
            // 
            // MetroToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 411);
            this.Controls.Add(this.MetroTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(315, 400);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.lastCreditCardTab.ResumeLayout(false);
            this.ccLookupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ccDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.custExportTab.ResumeLayout(false);
            this.exportGroup.ResumeLayout(false);
            this.exportGroup.PerformLayout();
            this.dateRangeLookupGroup.ResumeLayout(false);
            this.dateRangeLookupGroup.PerformLayout();
            this.customerExportLookup.ResumeLayout(false);
            this.customerExportLookup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MetroTabControl;
        private System.Windows.Forms.TabPage invoiceLookupTab;
        private System.Windows.Forms.TabPage openInvoiceTab;
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
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}

