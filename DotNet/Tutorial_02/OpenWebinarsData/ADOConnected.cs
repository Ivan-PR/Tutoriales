using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWebinarsData
{
    public class ADOConnected
    {
        public List<Tuple<int, string, float>> Connect()
        {
            OdbcConnection connection = new OdbcConnection(string.Empty);
            List<Tuple<int, string, float>> table1 = new List<Tuple<int, string, float>>();

            try
            {
                connection.Open();
                OdbcCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Param1, Param2, Param3 FROM Table1 WHERE Param1 = @Param1Where";
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    table1.Add(new Tuple<int, string, float>(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetFloat(2)));
                }

                connection.Close();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                if (connection != null)
                {
                    connection.Dispose();
                }
            }

            return table1;
        }
    }
}