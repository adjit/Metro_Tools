using Metro;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetroTools
{
    internal static class epsonExport
    {
        private static Dictionary<string, string> groupNames = new Dictionary<string, string>();

        public static void ExportEpsonPosReport(DateTime date)
        {
            int month = date.Month;
            int year = date.Year;

            qRow thisRow;

            Properties.Settings s = Properties.Settings.Default;

            for (int i = 0; i < s._groupMembers.Count; i++)
            {
                string[] arr = s._groupMembers[i].Split(';');
                if (arr.Length == 2) groupNames.Add(arr[0], arr[1]);
            }

            //string query = File.ReadAllText(@"EpsonQuery.sql");
            string query = Properties.Resources.epsonQuery;
            query = string.Format(query, month, year);

            List<string> checkRows = new List<string>();

            var slp = new sqlLookup();
            var dt = slp.Query(query);

            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow row = dt.Rows[i];
                string[] serials = row[(int)qCols.SerialNo].ToString().Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int qty = Convert.ToInt32(row[(int)qCols.QTY]);

                if (serials.Length > 0 && serials.Length != qty)
                {
                    checkRows.Add((i + 1).ToString());
                }
            }

            ExcelM.Export(dt);

            if (checkRows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("The following rows have a quantity that does not match the number of serial numbers provided:");
                sb.AppendLine();
                sb.AppendLine(string.Join(", ", checkRows));
                sb.AppendLine();
                sb.AppendLine("Please review these rows in the exported Excel file.");
                System.Windows.Forms.MessageBox.Show(sb.ToString(), "Quantity/Serial Number Mismatch", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }

        private enum qCols
        {
            Cogs,
            CustNo,
            ResellerNo,
            ResellerName,
            EndUserName,
            InvDt,
            InvNo,
            CCode,
            ItemNo,
            SerialNo,
            QTY,
            SalesRepID,
            BtAddress,
            BtCity,
            BtState,
            BtZip,
            StAddress,
            StCity,
            StState,
            StZip
        }

        private class qRow
        {
            public string cogs { get; }
            public string customerNumber { get; }
            public string enVisionNumber { get; }
            public string customerName { get; }
            public string endUserName { get; }
            public DateTime invoiceDate { get; }
            public string invoiceNumber { get; }
            public string cCode { get; }
            public string itemNumber { get; }
            public string[] serialNumbers { get; }
            public int quantity { get; }
            public string salesRepID { get; }
            public Address billTo { get; set; } = new Address();
            public Address shipTo { get; set; } = new Address();
            public double unitCost { get; }
            public double unitRebate { get; }
            public double fulfillmentPcnt { get; }

            public qRow(object Cogs, object CustNum, object EnvNum, object CustName, object EndName, object Date, object InvNum,
                            object CCode, object ItemNum, object delimittedSerials, object QTY, object SalesRepID, object CustAddress,
                            object CustCity, object CustState, object CustZip, object StAddress, object StCity, object StState, object StZip
                        )
            {
                cogs = Cogs.ToString().Trim();
                customerNumber = CustNum.ToString().Trim();
                enVisionNumber = EnvNum.ToString().Trim();
                customerName = CustName.ToString().Trim();
                endUserName = EndName.ToString().Trim();
                invoiceDate = Convert.ToDateTime(Date);
                invoiceNumber = InvNum.ToString().Trim();
                cCode = CCode.ToString().Trim();
                itemNumber = ItemNum.ToString().Trim();
                serialNumbers = delimittedSerials.ToString().Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                quantity = Convert.ToInt32(QTY);
                salesRepID = SalesRepID.ToString().Trim();
                billTo.address = CustAddress.ToString().Trim();
                billTo.city = CustCity.ToString().Trim();
                billTo.state = CustState.ToString().Trim();
                billTo.zip = CustZip.ToString().Trim();
                shipTo.address = StAddress.ToString().Trim();
                shipTo.city = StCity.ToString().Trim();
                shipTo.state = StState.ToString().Trim();
                shipTo.zip = StZip.ToString().Trim();

                //getFulfillment();
                //This method will be added later to do my comparisons
            }

            public class Address
            {
                public string address { get; set; }
                public string city { get; set; }
                public string state { get; set; }
                public string zip { get; set; }
            }
        }
    }
}
