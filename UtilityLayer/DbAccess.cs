using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace UtilityLayer
{
    public class DbAccess
    {
        private ConnectDB db = new ConnectDB();
        public DataTable ExecuteSPDatatable(string spName)
        {
            SqlDataAdapter cmd = new SqlDataAdapter(spName, db.connection);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            db.Close();
            return dt;
        }

        public DataTable ExecuteSPDatatable(string spName, ArrayList parameters)
        {
            SqlDataAdapter cmd = new SqlDataAdapter(spName, db.connection);
            cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parameter in parameters)
            {
                cmd.SelectCommand.Parameters.Add(parameter.ParameterName,parameter.SqlDbType).Value=parameter.Value;
            }
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            db.Close();
            return dt;
        }


        public int ExecuteSPNonQuery(string spName, ArrayList parameters)
        {
            SqlCommand cmd = new SqlCommand(spName, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach(SqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            if (db.connection.State == ConnectionState.Closed)
                db.connection.Open();
            int i = cmd.ExecuteNonQuery();
            db.connection.Close();
            return i;
        }


    }
}
