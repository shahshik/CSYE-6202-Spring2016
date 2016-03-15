using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Payroll
{
    public abstract class Employee
    {
        private String firstName { get; set; }
        private String lastName { get; set; }
        private String ssn { get ; set; }
        

        public Employee(String firstName,String lastName, String ssn)
        {
            this.firstName =  firstName;
            this.lastName = lastName;
            this.ssn = ssn;  
        }

        public abstract double earnings();


        
    }
}
