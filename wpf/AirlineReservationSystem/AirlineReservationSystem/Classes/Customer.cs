using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Classes
{
    public class Customer : User
    {
        //private String flightNo;{ get; set; }
        public String customerid;
        public String name;
        public String address;
        public String phoneNo;

    }  
}
