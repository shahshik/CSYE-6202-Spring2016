using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Payroll
{
    public abstract class Employee
    {
        private String firstName;
        private String lastName;
        private String ssn;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name must have a value");
                if (value.Any(c => char.IsDigit(c)))
                    throw new ArgumentException("Name cannot contain numbers");

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name must have a value");
                if (value.Any(c => char.IsDigit(c)))
                    throw new ArgumentException("Name cannot contain numbers");

                lastName = value;
            }
        }

        public string Ssn
        {
            get { return ssn; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Number must have a value");
                if (value.Any(c => char.IsLetter(c)))
                    throw new ArgumentException("Number cannot contain letters");

                ssn = value;
            }
        }




        public Employee(String firstName,String lastName, String ssn)
        {
            this.firstName =  firstName;
            this.lastName = lastName;
            this.ssn = ssn;  
        }

        public abstract double earnings();

        public override string ToString()
        {
            return string.Format("{0} {1}\nsocial security number: {2}",
                firstName, lastName, ssn);
        }



    }
}
