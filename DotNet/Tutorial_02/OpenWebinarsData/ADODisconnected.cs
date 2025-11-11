using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace OpenWebinarsData
{
    public class ADODisconnected
    {
        public void Connection()
        {
            OdbcConnection connection = new OdbcConnection(string.Empty);

            try
            {
                connection.Open();
                OdbcCommand com = connection.CreateCommand();
                com.CommandText = "SELECT Param1, Param2, Param3 FROM Table1";

                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(com);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                connection.Close();
            }
            catch (Exception e)
            {
            }
        }
    }
}