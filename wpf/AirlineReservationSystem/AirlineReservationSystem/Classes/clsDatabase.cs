using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using AirlineReservationSystem.Properties;

namespace AirlineReservationSystem.Classes
{
    public class clsDatabase
    {

        public SqlConnection Conn = new SqlConnection(AirlineReservationSystem.Properties.Settings.Default.AirlineReservationSystemConnectionString);
        SqlCommand Cmd = new SqlCommand();
        public void ConnectDatabase()
        {

            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }
        }
        public DataSet  GetDataSet(String strQuery)
        {   DataSet ds = new DataSet();
      
           Cmd = new SqlCommand(strQuery, Conn);
            Cmd.ExecuteNonQuery();
            SqlDataAdapter sDA = new SqlDataAdapter(Cmd);
            sDA.Fill(ds);
            return ds;
        }
        public DataTable GetDataTable(String strQuery)
        {
            DataTable dt = new DataTable();
            Cmd = new SqlCommand(strQuery, Conn);
            Cmd.ExecuteNonQuery();
            SqlDataAdapter sDA = new SqlDataAdapter(Cmd);
            sDA.Fill(dt);
            return dt;
        }
        public int GetDataCount(String strQuery)
        {
            Cmd = new SqlCommand(strQuery, Conn);
            return Cmd.ExecuteNonQuery();

        }
    }

}
