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

            progress.Report(10);

            initialQuery = string.Format(initialQuery, custNumber, startDate.ToShortDateString(), endDate.ToShortDateString());
            comparatorQuery = string.Format(comparatorQuery, custNumber, startDate.ToShortDateString(), endDate.ToShortDateString());

            progress.Report(20);

            DataTable dti = Database.sqlLookup(initialQuery);

            progress.Report(30);

            DataTable dtc = Database.sqlLookup(comparatorQuery);

            progress.Report(40);

            ExcelM.Export(_fillInCompare(dti, dtc));

            progress.Report(100);
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
                invoiceNum = comparatorTable.Rows[i][(int)ReferenceColumn.InvoiceNumber].ToString();

                if(!parsedInvoices.ContainsKey(invoiceNum))
                {
                    _invoiceToTrack itr = new _invoiceToTrack();
                    itr.disty = comparatorTable.Rows[i][(int)ReferenceColumn.Disty].ToString();
                    itr.poNumber = comparatorTable.Rows[i][(int)ReferenceColumn.PONumber].ToString();
                    itr.invoiceNum = invoiceNum;
                    itr.quantity = Convert.ToInt32(comparatorTable.Rows[i][(int)ReferenceColumn.Quantity]);
                    itr.itemNumber = comparatorTable.Rows[i][(int)ReferenceColumn.ItemNumber].ToString();
                    itr.itemDescription = comparatorTable.Rows[i][(int)ReferenceColumn.ItemDescription].ToString();
                    itr.unitPrice = Convert.ToInt32(comparatorTable.Rows[i][(int)ReferenceColumn.UnitPrice]);
                    itr.extendedPrice = Convert.ToInt32(comparatorTable.Rows[i][(int)ReferenceColumn.ExtendedPrice]);
                    itr.serialNumbers = comparatorTable.Rows[i][(int)ReferenceColumn.SerialNumbers].ToString();
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

                    ndr[(int)ExcelColumn.Disty] = lookupInvoices[i].disty;
                    ndr[(int)ExcelColumn.PONumber] = lookupInvoices[i].poNumber;
                    ndr[(int)ExcelColumn.InvoiceNumber] = lookupInvoices[i].invoiceNum;
                    ndr[(int)ExcelColumn.Quantity] = lookupInvoices[i].quantity;
                    ndr[(int)ExcelColumn.ItemNumber] = lookupInvoices[i].itemNumber;
                    ndr[(int)ExcelColumn.ItemDescription] = lookupInvoices[i].itemDescription;
                    ndr[(int)ExcelColumn.UnitPrice] = lookupInvoices[i].unitPrice;
                    ndr[(int)ExcelColumn.ExtendedPrice] = lookupInvoices[i].extendedPrice;
                    ndr[(int)ExcelColumn.TrackingNumber] = trackingTable.Rows[0][2].ToString();
                    ndr[(int)ExcelColumn.TrackingInfo] = "N/A";
                    ndr[(int)ExcelColumn.SerialNumbers] = lookupInvoices[i].serialNumbers;

                    initialTable.Rows.Add(ndr);
                }
            }

            return initialTable;
        }

        private enum ReferenceColumn
        {
            Disty,
            PONumber,
            InvoiceNumber,
            Quantity,
            ItemNumber,
            ItemDescription,
            UnitPrice,
            ExtendedPrice,
            SerialNumbers
        }

        private enum ExcelColumn
        {
            Disty,
            PONumber,
            InvoiceNumber,
            Quantity,
            ItemNumber,
            ItemDescription,
            UnitPrice,
            ExtendedPrice,
            TrackingNumber,
            TrackingInfo,
            SerialNumbers
        }

        private struct _invoiceToTrack
        {
            public string disty;
            public string poNumber;
            public string invoiceNum;
            public int quantity;
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
