using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace UtilityLayer
{
    public class ConnectDB
    {
        internal SqlConnection connection { get; }

        public ConnectDB()
        {
            connection = new SqlConnection(ConnectionString.ConnectionStr);
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
