using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MetroTools
{
    class ccLookup
    {
        private DataTable _data;

        public ccLookup(string custNum)
        {
            sqlLookup slp = new sqlLookup(string.Format(Properties.Resources.ccQuery, custNum));
            _data = slp.getDataTable();

            if(_data.Rows.Count == 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ERROR");
                dt.Rows.Add(new object[] { "No Rows Found" });
                _data = dt;
            }
        }

        public DataTable getDataTable()
        {
            return _data;
        }
    }
}
