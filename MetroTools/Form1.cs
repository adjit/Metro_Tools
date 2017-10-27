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


namespace MetroTools
{
    public partial class MetroToolsForm : Form
    {
        public MetroToolsForm()
        {
            InitializeComponent();
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
        }
    }
}
