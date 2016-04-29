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
    public class BookingDAO
    {
        clsDatabase cDA = new clsDatabase();
        public int bookFlight(Booking b)
        {
          
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("insert into Booking (flightno,flightName,status) values(@flightno,@flightName,@oldstatus)", cDA.Conn);
            //SqlCommand Cmd = new SqlCommand("Update DomesticAirports set Airport_Code=@Airport_Code,Airport_Name=@Airport_Name where Airport_Code=@OldAirport_Code",cDA.Conn);
            Cmd.Parameters.AddWithValue("@flightno", b.flightNo);
            Cmd.Parameters.AddWithValue("@flightName", b.flightName);
            Cmd.Parameters.AddWithValue("@oldstatus", b.OldStatus);


            return Cmd.ExecuteNonQuery();
        }

        public int cancelFlight(Booking b)
        {
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("Update Booking set status = @Status where status = @OldStatus)" ,cDA.Conn);
            Cmd.Parameters.AddWithValue("@Status", b.Status);
            Cmd.Parameters.AddWithValue("@OldStatus", b.OldStatus);

            return Cmd.ExecuteNonQuery();
                
        }
    }
}
