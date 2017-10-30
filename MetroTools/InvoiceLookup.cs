using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metro;

namespace MetroTools
{
    class InvoiceLookup
    {
        private DataTable _data;
        private string[] _invoiceNumbers;

        public InvoiceLookup(string query)
        {
            sqlLookup slp = new sqlLookup(query);
            _data = slp.getDataTable();

            _invoiceNumbers = new string[_data.Rows.Count];
        }

        public string[] getInvoiceNumbers()
        {
            for(int i = 0; i < _data.Rows.Count; i++)
            {
                _invoiceNumbers[i] = _data.Rows[i][0].ToString();
            }
            return _invoiceNumbers;
        }

        public void openInvoice(string invoiceNum)
        {
            Invoices.Open(invoiceNum);
        }

        public void openInvoices(string[] invoiceNumbers)
        {
            Invoices.Open(invoiceNumbers);
        }

    }
}
