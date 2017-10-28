using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTools
{
    class InvoiceLookup
    {
        private DataTable _data;

        public InvoiceLookup(string query)
        {
            sqlLookup slp = new sqlLookup(query);
            _data = slp.getDataTable();
        }

        public string[] getInvoiceNumbers()
        {
            string[] invoices = new string[_data.Rows.Count];

            for(int i = 0; i < _data.Rows.Count; i++)
            {
                invoices[i] = _data.Rows[i][0].ToString();
            }
            return invoices;
        }
    }
}
