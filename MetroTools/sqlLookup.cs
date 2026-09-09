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

        public sqlLookup()
        {
            string connection;

            try
            {
                connection = System.IO.File.ReadAllText(Properties.Settings.Default.DBCONNECTION_STRING);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show($"Unable to get connection string for database. {e.Message}");
                return;
            }

            dbConnection = new SqlConnection(connection);
        }

        public DataTable Query(string query)
        {
            if (dbConnection != null)
            {
                try
                {
                    dbConnection.Open();

                    cmd = new SqlCommand(query, dbConnection);

                    cmd.CommandType = CommandType.Text;
                    var _data = new DataTable();
                    _data.Load(cmd.ExecuteReader());
                    return _data;
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                    dbConnection.Close();
                }
                finally
                {
                    dbConnection.Close();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No database connection established.");
            }

            return new DataTable();
        }
    }
}
