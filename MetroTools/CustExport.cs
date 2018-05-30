using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metro;

namespace MetroTools
{
    class CustExport
    {
        public static void ExportCustomer(string custNumber, DateTime startDate, DateTime endDate)
        {
            string initialQuery = Properties.Resources.custExportQuery;
            string comparatorQuery = Properties.Resources.custReferenceExportQuery;

            initialQuery = string.Format(initialQuery, custNumber, startDate.ToShortDateString(), endDate.ToShortDateString());
            comparatorQuery = string.Format(comparatorQuery, custNumber, startDate.ToShortDateString(), endDate.ToShortDateString());

            DataTable dti = Database.sqlLookup(initialQuery);
            DataTable dtc = Database.sqlLookup(comparatorQuery);
                        
            ExcelM.Export(_fillInCompare(dti, dtc));
        }

        public static void ExportCustomer(string custNumber, DateTime startDate, DateTime endDate, IProgress<int> progress)
        {
            string initialQuery = Properties.Resources.custExportQuery;
            string comparatorQuery = Properties.Resources.custReferenceExportQuery;

            initialQuery = string.Format(initialQuery, custNumber, startDate.ToShortDateString(), endDate.ToShortDateString());
            comparatorQuery = string.Format(comparatorQuery, custNumber, startDate.ToShortDateString(), endDate.ToShortDateString());

            DataTable dti = Database.sqlLookup(initialQuery);
            DataTable dtc = Database.sqlLookup(comparatorQuery);

            ExcelM.Export(_fillInCompare(dti, dtc), progress);
        }

        private static DataTable _fillInCompare(DataTable initialTable, DataTable comparatorTable)
        {
            DataTable trackingTable = new DataTable();

            Dictionary<string, int> parsedInvoices = new Dictionary<string, int>();
            List<_invoiceToTrack> lookupInvoices = new List<_invoiceToTrack>();
            string invoiceNum;

            for(int i = 0; i < initialTable.Rows.Count; i++)
            {
                invoiceNum = initialTable.Rows[i][0].ToString();

                if(!parsedInvoices.ContainsKey(invoiceNum))
                {
                    parsedInvoices.Add(invoiceNum, 1);
                }
            }

            for(int i = 0; i < comparatorTable.Rows.Count; i++)
            {
                invoiceNum = comparatorTable.Rows[i][0].ToString();

                if(!parsedInvoices.ContainsKey(invoiceNum))
                {
                    _invoiceToTrack itr = new _invoiceToTrack();
                    itr.invoiceNum = invoiceNum;
                    itr.itemNumber = comparatorTable.Rows[i][1].ToString();
                    itr.itemDescription = comparatorTable.Rows[i][2].ToString();
                    itr.unitPrice = Convert.ToInt32(comparatorTable.Rows[i][3]);
                    itr.extendedPrice = Convert.ToInt32(comparatorTable.Rows[i][4]);
                    itr.serialNumbers = comparatorTable.Rows[i][5].ToString();
                    lookupInvoices.Add(itr);
                }
            }

            for(int i = 0; i < lookupInvoices.Count; i++)
            {
                string itrxQuery = String.Format(Properties.Resources.invoiceTrxQuery, lookupInvoices[i].invoiceNum);

                trackingTable = Database.sqlLookup(itrxQuery);

                if(trackingTable.Rows.Count > 0)
                {
                    DataRow ndr = initialTable.NewRow();
                    
                    ndr[0] = lookupInvoices[i].invoiceNum;
                    ndr[1] = lookupInvoices[i].itemNumber;
                    ndr[2] = lookupInvoices[i].itemDescription;
                    ndr[3] = lookupInvoices[i].unitPrice;
                    ndr[4] = lookupInvoices[i].extendedPrice;
                    ndr[5] = trackingTable.Rows[0][2].ToString();
                    ndr[6] = "N/A";
                    ndr[7] = lookupInvoices[i].serialNumbers;

                    initialTable.Rows.Add(ndr);
                }
            }

            return initialTable;
        }

        private struct _invoiceToTrack
        {
            public string invoiceNum;
            public string itemNumber;
            public string itemDescription;
            public int unitPrice;
            public int extendedPrice;
            public string serialNumbers;
        }

/*  Deprecated. Do not want to create a CustExport object. It is unnecessary.
 *      public CustExport(string custNumber, DateTime startDate, DateTime endDate)
        {
            string query = Properties.Resources.custExportQuery;
            query = string.Format(query, custNumber, startDate.ToShortDateString(), endDate.ToShortDateString());
            DataTable dt = Database.sqlLookup(query);
            ExcelM.Export(dt);
        }
*/
    }
}
