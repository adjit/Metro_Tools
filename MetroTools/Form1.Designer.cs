﻿namespace MetroTools
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
            this.openInvoiceTab = new System.Windows.Forms.TabPage();
            this.lookupGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackingNumberInput = new System.Windows.Forms.TextBox();
            this.tnLabel = new System.Windows.Forms.Label();
            this.invoiceLookupButton = new System.Windows.Forms.Button();
            this.serialNumberInput = new System.Windows.Forms.TextBox();
            this.snLabel = new System.Windows.Forms.Label();
            this.invoiceListGroupBox = new System.Windows.Forms.GroupBox();
            this.invoiceList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openInvoice = new System.Windows.Forms.Button();
            this.getInvoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.openStandaloneInvoice = new System.Windows.Forms.Button();
            this.invoiceNumberInput = new System.Windows.Forms.TextBox();
            this.MetroTabControl.SuspendLayout();
            this.invoiceLookupTab.SuspendLayout();
            this.lookupGroupBox.SuspendLayout();
            this.invoiceListGroupBox.SuspendLayout();
            this.getInvoiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetroTabControl
            // 
            this.MetroTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroTabControl.Controls.Add(this.invoiceLookupTab);
            this.MetroTabControl.Controls.Add(this.openInvoiceTab);
            this.MetroTabControl.Location = new System.Drawing.Point(0, 0);
            this.MetroTabControl.MinimumSize = new System.Drawing.Size(300, 345);
            this.MetroTabControl.Name = "MetroTabControl";
            this.MetroTabControl.SelectedIndex = 0;
            this.MetroTabControl.Size = new System.Drawing.Size(300, 345);
            this.MetroTabControl.TabIndex = 0;
            // 
            // invoiceLookupTab
            // 
            this.invoiceLookupTab.Controls.Add(this.getInvoiceGroupBox);
            this.invoiceLookupTab.Controls.Add(this.invoiceListGroupBox);
            this.invoiceLookupTab.Controls.Add(this.lookupGroupBox);
            this.invoiceLookupTab.Location = new System.Drawing.Point(4, 22);
            this.invoiceLookupTab.Name = "invoiceLookupTab";
            this.invoiceLookupTab.Padding = new System.Windows.Forms.Padding(3);
            this.invoiceLookupTab.Size = new System.Drawing.Size(292, 319);
            this.invoiceLookupTab.TabIndex = 0;
            this.invoiceLookupTab.Text = "Invoice Lookup";
            this.invoiceLookupTab.UseVisualStyleBackColor = true;
            // 
            // openInvoiceTab
            // 
            this.openInvoiceTab.Location = new System.Drawing.Point(4, 22);
            this.openInvoiceTab.Name = "openInvoiceTab";
            this.openInvoiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.openInvoiceTab.Size = new System.Drawing.Size(292, 319);
            this.openInvoiceTab.TabIndex = 1;
            this.openInvoiceTab.Text = "Open Invoice Report";
            this.openInvoiceTab.UseVisualStyleBackColor = true;
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
            this.invoiceListGroupBox.Size = new System.Drawing.Size(280, 128);
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
            // 
            // getInvoiceGroupBox
            // 
            this.getInvoiceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getInvoiceGroupBox.Controls.Add(this.openStandaloneInvoice);
            this.getInvoiceGroupBox.Controls.Add(this.invoiceNumberInput);
            this.getInvoiceGroupBox.Location = new System.Drawing.Point(6, 262);
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
            // 
            // invoiceNumberInput
            // 
            this.invoiceNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceNumberInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.invoiceNumberInput.Location = new System.Drawing.Point(6, 19);
            this.invoiceNumberInput.Name = "invoiceNumberInput";
            this.invoiceNumberInput.Size = new System.Drawing.Size(165, 20);
            this.invoiceNumberInput.TabIndex = 3;
            // 
            // MetroToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 341);
            this.Controls.Add(this.MetroTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(315, 380);
            this.Name = "MetroToolsForm";
            this.Text = "Metro Tools";
            this.MetroTabControl.ResumeLayout(false);
            this.invoiceLookupTab.ResumeLayout(false);
            this.lookupGroupBox.ResumeLayout(false);
            this.lookupGroupBox.PerformLayout();
            this.invoiceListGroupBox.ResumeLayout(false);
            this.invoiceListGroupBox.PerformLayout();
            this.getInvoiceGroupBox.ResumeLayout(false);
            this.getInvoiceGroupBox.PerformLayout();
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
    }
}

