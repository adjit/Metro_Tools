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
        }

        public DataTable getDataTable()
        {
            return _data;
        }
    }
}
