using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metro;

namespace MetroTools
{
    class arExport
    {
        private static string _custNumber;

        public static void arStatementExport(string custNumber, IProgress<double>progress)
        {
            _custNumber = custNumber;

            string query = Properties.Resources.arQuery;

            query = string.Format(query, _custNumber);

            progress.Report(5);

            var slp = new sqlLookup();
            DataTable dti = slp.Query(query);

            progress.Report(5);

            ExcelM.Export(dti, true, progress);

            progress.Report(100);
        }
    }
}
