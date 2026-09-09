using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metro.Core;
using Metro.Core.Infrastructure;

namespace MetroTools
{
    class InvoiceLookup
    {
        private DataTable _data;
        private string[] _invoiceNumbers;
        private GeneralConfigOptions _opts;

        public InvoiceLookup(string query, GeneralConfigOptions opts)
        {
            _opts = opts;

            sqlLookup slp = new sqlLookup();
            _data = slp.Query(query);

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
            InvoiceWrapper.Open(invoiceNum, _opts);
        }

        public void openInvoices(string[] invoiceNumbers)
        {
            InvoiceWrapper.Open(invoiceNumbers, _opts);
        }

    }
}
