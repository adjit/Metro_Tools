using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Metro;


namespace MetroTools
{
    public partial class MetroToolsForm : Form
    {
        public MetroToolsForm()
        {
            InitializeComponent();
            openStandaloneInvoice.Enabled = false;
        }

        private void ccCustLookupButton_Click(object sender, EventArgs e)
        {
            string custNum = ccCustomerNumber.Text;
            ccLookup LastCC = new ccLookup(custNum);
            fillDataGrid(LastCC.getDataTable());
        }

        private void fillDataGrid(DataTable dt)
        {
            ccDataGridView.DataSource = dt;
        }

        private void MetroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MetroTabControl.SelectedIndex == 2)
            {
                this.Width = Properties.Settings.Default._ccFormWidth;
                MetroTabControl.Width = Properties.Settings.Default._ccTabWidth;
            }
            else setDefaultDims();
        }

        private void setDefaultDims()
        {
            this.Width = Properties.Settings.Default._defaultFormWidth;
            this.Height = Properties.Settings.Default._defaultFormHeight;
            MetroTabControl.Width = Properties.Settings.Default._defaultTabWidth;
            MetroTabControl.Height = Properties.Settings.Default._defaultTabHeight;
        }

        private void invoiceLookupButton_Click(object sender, EventArgs e)
        {
            invoiceList.Items.Clear();
            openInvoice.Enabled = false;

            string query;

            if(serialNumberInput.TextLength > 0 && trackingNumberInput.TextLength > 0)
            {
                MessageBox.Show("Please input either a Serial Number OR Tracking Number");
                return;
            }
            else if (serialNumberInput.TextLength > 0)
            {
                query = Properties.Resources.serialQuery;
                query = String.Format(query, serialNumberInput.Text.Trim());
            }
            else if (trackingNumberInput.TextLength > 0)
            {
                query = Properties.Resources.trxQuery;
                query = String.Format(query, trackingNumberInput.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please input a value into either field");
                return;
            }

            InvoiceLookup ilp = new InvoiceLookup(query);
            string[] invoices = ilp.getInvoiceNumbers();

            if (invoices.Length == 0) invoiceList.Items.Add("No Invoices Found");
            else
            {
                openInvoice.Enabled = true;

                for (int i = 0; i < invoices.Length; i++)
                {
                    invoiceList.Items.Add(invoices[i].Trim());
                }
            }

            invoiceList.SelectedIndex = 0;
        }

        private void invoiceNumberInput_TextChanged(object sender, EventArgs e)
        {
            if (invoiceNumberInput.TextLength == invoiceNumberInput.MaxLength) openStandaloneInvoice.Enabled = true;
            else openStandaloneInvoice.Enabled = false;
        }

        private void openStandaloneInvoice_Click(object sender, EventArgs e)
        {
            Invoices.Open(invoiceNumberInput.Text);
        }

        private void openInvoice_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection soc = invoiceList.SelectedItems;

            for (int i = 0; i < soc.Count; i++) Invoices.Open(soc[i].ToString());
        }
    }
}
