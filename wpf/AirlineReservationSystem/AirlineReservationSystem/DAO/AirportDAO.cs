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
    public class AirportDAO
    {
        clsDatabase cDA = new clsDatabase();

        public int insertDomesticData(Airport clsAirport)
        {
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("insert into DomesticAirports (Airport_Code,Airport_Name) values(@Airport_Code,@Airport_Name)", cDA.Conn);
            //SqlCommand Cmd = new SqlCommand("Update DomesticAirports set Airport_Code=@Airport_Code,Airport_Name=@Airport_Name where Airport_Code=@OldAirport_Code",cDA.Conn);
            Cmd.Parameters.AddWithValue("@Airport_Code", clsAirport.Airport_Code);
            Cmd.Parameters.AddWithValue("@Airport_Name", clsAirport.Airport_Name);
            return Cmd.ExecuteNonQuery();
        }

        public int updateDomesticData(Airport clsAirport)
        {
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("Update DomesticAirports set Airport_Code=@Airport_Code,Airport_Name=@Airport_Name where Airport_Code=@OldAirport_Code",cDA.Conn);
            Cmd.Parameters.AddWithValue("@Airport_Code", clsAirport.Airport_Code);
            Cmd.Parameters.AddWithValue("@Airport_Name", clsAirport.Airport_Name);
            Cmd.Parameters.AddWithValue("@OldAirport_Code", clsAirport.@OldAirport_Code);
           
            return Cmd.ExecuteNonQuery();
        }
      

        public DataTable GetDomesticAirport()
        {
            cDA.ConnectDatabase();
            return cDA.GetDataTable("SELECT Airport_Code,Airport_Name  FROM DomesticAirports order by Airport_Code");

        }

     
        public void deleteDomesticAirport(Airport clsAirport)
        {
            DataTable Dt = new DataTable();
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("Delete from DomesticAirports where Airport_Code=@Airport_Code", cDA.Conn);
            Cmd.Parameters.AddWithValue("@Airport_Code", clsAirport.Airport_Code);
            Cmd.ExecuteNonQuery();
            
           
        }

      

        public DataTable fillDomesticAirport(Airport clsAirport)
        {
            DataTable Dt = new DataTable();
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("Select Airport_Code,Airport_Name from DomesticAirports where Airport_Code=@Airport_Code", cDA.Conn);
            Cmd.Parameters.AddWithValue("@Airport_Code", clsAirport.Airport_Code);
            SqlDataAdapter sDa = new SqlDataAdapter(Cmd);
            sDa.Fill(Dt);
            return Dt;
       }

      
    }
}
