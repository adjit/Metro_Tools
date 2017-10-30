using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MetroTools
{

    class sqlLookup
    {
        private SqlConnection dbConnection;
        private SqlCommand cmd;
        private DataTable _data;
        public String Query { get; }

        public sqlLookup(string query)
        {
            dbConnection = new SqlConnection("Data Source=METRO-GP1;user id=sa;password=frx12gpa;persist security info=True;Integrated Security=False;Initial Catalog=METRO;persistsecurityinfo=True;");
            Query = query;

            dbConnection.Open();

            cmd = new SqlCommand(Query, dbConnection);
            cmd.CommandType = CommandType.Text;
            _data = new DataTable();
            _data.Load(cmd.ExecuteReader());

            dbConnection.Close();
        }

        public DataTable getDataTable()
        {
            return _data;
        }
    }
}
