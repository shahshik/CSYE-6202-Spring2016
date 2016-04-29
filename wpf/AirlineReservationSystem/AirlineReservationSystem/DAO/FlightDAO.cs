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
    public class FlightDAO 
    {
        clsDatabase cDA = new clsDatabase();

     

        public int insertData(SeatingCapacity sc,Flight f)
        {
      
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("insert into Flight (flightno,flightName,seatingCapacity,carrierInformation,flightCrewInformation,carrier,source,destination) values(@flightno,@flightName,@seatingCapacity,@carrierInformation,@flightCrewInformation,@carrier,@source,@destination)", cDA.Conn);
            //SqlCommand Cmd = new SqlCommand("Update DomesticAirports set Airport_Code=@Airport_Code,Airport_Name=@Airport_Name where Airport_Code=@OldAirport_Code",cDA.Conn);
            Cmd.Parameters.AddWithValue("@flightno", f.flightNo );
            Cmd.Parameters.AddWithValue("@flightName", f.flightName);
            Cmd.Parameters.AddWithValue("@seatingCapacity", f.seatingCapacity);
            Cmd.Parameters.AddWithValue("@carrierInformation", f.carrierInformation);
            Cmd.Parameters.AddWithValue("@flightCrewInformation", f.flightCrewInformation);
            Cmd.Parameters.AddWithValue("@carrier", f.carrier);
            Cmd.Parameters.AddWithValue("@source", f.source);
            Cmd.Parameters.AddWithValue("@destination", f.destination);
            Cmd.ExecuteNonQuery();
            SqlCommand Cmd1 = new SqlCommand("insert into SeatingCapacity (economyclass_no,economyplus_no,business) values(@economyclass_no,@economyplus_no,@business)", cDA.Conn);

            Cmd1.Parameters.AddWithValue("@economyclass_no", sc.economyclass_no);
            Cmd1.Parameters.AddWithValue("@economyplus_no", sc.economyplus_no);
            Cmd1.Parameters.AddWithValue("@business", sc.business);
            return Cmd1.ExecuteNonQuery();
        }

        public int updateFlightData(Flight flight)
        {
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("Update Flight set flightno=@flightno,flightname=@flightname,source=@source,destination=@destination where flightNo=@oldFlightNo", cDA.Conn);
            Cmd.Parameters.AddWithValue("@flightno", flight.flightNo);
            Cmd.Parameters.AddWithValue("@oldFlightno", flight.oldflightNo);
            Cmd.Parameters.AddWithValue("@flightname", flight.flightName);
            Cmd.Parameters.AddWithValue("@source", flight.source);
            Cmd.Parameters.AddWithValue("@destination", flight.destination);

            return Cmd.ExecuteNonQuery();
        }

        public DataTable GetFlight()
        {
            cDA.ConnectDatabase();
            return cDA.GetDataTable("SELECT f.flightNo,f.flightName, f.source,f.destination FROM Flight f order by f.flightno ");

        }

        public void deleteSeat(Flight f)
        {
            DataTable Dt = new DataTable();
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("Delete from Flight where flightno=@flightno", cDA.Conn);
            Cmd.Parameters.AddWithValue("@flightno", f.flightNo);
            Cmd.ExecuteNonQuery();


        }

        public DataTable fillFlight(Flight flight)
        {
            DataTable Dt = new DataTable();
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("SELECT f.flightNo,f.flightName,f.source,f.destination FROM Flight f where f.flightno = @flightno ", cDA.Conn);
            Cmd.Parameters.AddWithValue("@flightNo", flight.flightNo);
            SqlDataAdapter sDa = new SqlDataAdapter(Cmd);
            sDa.Fill(Dt);
            return Dt;
        }

        public DataTable searchFlight(Flight flight)
        {
            DataTable Dt = new DataTable();
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("SELECT f.flightNo,f.flightName,f.Source,f.Destination FROM Flight f where f.Source = @fromFlight and f.Destination = @toFlight ", cDA.Conn);
            Cmd.Parameters.AddWithValue("@fromFlight", flight.source);
            Cmd.Parameters.AddWithValue("@toFlight", flight.destination);
            SqlDataAdapter sDa = new SqlDataAdapter(Cmd);
            sDa.Fill(Dt);
            return Dt;
        }

    
    }
}

