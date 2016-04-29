using AirlineReservationSystem.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.DAO
{
    public class RateDAO 
    {
        clsDatabase cDA = new clsDatabase();

        public int insertData(Rate rate)
        {
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("insert into Rate (flightId,seatType,rate) values(@flightId,@seatType,@rate)", cDA.Conn);
            //SqlCommand Cmd = new SqlCommand("Update DomesticAirports set Airport_Code=@Airport_Code,Airport_Name=@Airport_Name where Airport_Code=@OldAirport_Code",cDA.Conn);
            Cmd.Parameters.AddWithValue("@flightId", rate.flightNo);
            Cmd.Parameters.AddWithValue("@seatType", rate.seatType);
            Cmd.Parameters.AddWithValue("@rate", rate.rate);
            return Cmd.ExecuteNonQuery();
        }

        public int updateRateData(Rate rate)
        {
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("Update Rate set flightId,seatType=@seatType,rate=@rate where flightId=@oldFlightId", cDA.Conn);
            Cmd.Parameters.AddWithValue("@flightId", rate.flightNo);
            Cmd.Parameters.AddWithValue("@seatType", rate.seatType);
            Cmd.Parameters.AddWithValue("@oldFlightId", rate.OldFlightId);
            Cmd.Parameters.AddWithValue("@rate",rate.rate);

            return Cmd.ExecuteNonQuery();
        }

        public DataTable GetRate()
        {
            cDA.ConnectDatabase();
            return cDA.GetDataTable("SELECT flightId,seatType,rate  FROM Rate order by flightId");

        }

        public void deleteRate(Rate rate)
        {
            DataTable Dt = new DataTable();
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("Delete from Rate where flightId=@flightId", cDA.Conn);
            Cmd.Parameters.AddWithValue("@flightId", rate.flightNo);
            Cmd.ExecuteNonQuery();


        }

        public DataTable fillRate(Rate rate)
        {
            DataTable Dt = new DataTable();
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("SELECT flightId, seatType, rate  FROM Rate where flightId=@flightId", cDA.Conn);
            Cmd.Parameters.AddWithValue("@flightId", rate.flightNo);
            SqlDataAdapter sDa = new SqlDataAdapter(Cmd);
            sDa.Fill(Dt);
            return Dt;
        }
    }
}
