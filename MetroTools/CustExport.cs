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
        public CustExport(string custNumber, DateTime startDate, DateTime endDate)
        {
            string query = Properties.Resources.custExportQuery;
            query = string.Format(query, custNumber, startDate.ToShortDateString(), endDate.ToShortDateString());
            DataTable dt = Database.sqlLookup(query);
            ExcelM.Export(dt);
        }
    }
}
