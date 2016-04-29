using AirlineReservationSystem.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.DAO
{
    public class NewCustomerDAO : IDAO
    {
        clsDatabase cDA = new clsDatabase();
  
       
        public int insertData(Customer customer, User user)
        {
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("insert into NewCustomer (name, address, phoneNo) values(@name,@address,@phoneNo)", cDA.Conn);
            //SqlCommand Cmd = new SqlCommand("Update DomesticAirports set Airport_Code=@Airport_Code,Airport_Name=@Airport_Name where Airport_Code=@OldAirport_Code",cDA.Conn);
            //Cmd.Parameters.AddWithValue("customer.customerid", customerId);

            Cmd.Parameters.AddWithValue("@name", customer.name);
            Cmd.Parameters.AddWithValue("@address", customer.address);
            Cmd.Parameters.AddWithValue("@phoneNo", customer.phoneNo);
            Cmd.ExecuteNonQuery();
         

            SqlCommand Cmd1 = new SqlCommand("insert into Usermaster (c_username,c_password) values (@c_username,@c_password)", cDA.Conn);
        
            Cmd1.Parameters.AddWithValue("@c_username", user.username);
            Cmd1.Parameters.AddWithValue("@c_password", user.password);
           
            return Cmd1.ExecuteNonQuery();
           
        }

        int IDAO.insertData()
        {
            throw new NotImplementedException();
        }
    }
}

