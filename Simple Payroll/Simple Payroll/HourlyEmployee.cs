using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Payroll
{
    public class HourlyEmployee : Employee
    {
        private double wage;
        private double hours;

        public HourlyEmployee(String first, String last, String ssn, double hourlywage, double hr) : base(first, last, ssn)
        {
            wage = hourlywage;
            hours = hr;
        }

        public double Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value >= 0)
                    wage = value;
                else

                    throw new ArgumentOutOfRangeException(
                        "Wage", value, "Hourly Wage must be >= 0");

            }
        }

        public double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value > 0)
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException("Hours", value, "Hours must be greater than 0")
             }
        }

        public override double earnings()
        {
            if (hours <= 40) 
               return wage * hours;
           else                                                             
              return 40 * wage + (hours - 40) * wage * 1.5;
        }           
    

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}",
                "Hourly employee", base.ToString(),
                "Hourly Wage", wage, "Hours worked", hours);

        }
    }
    
    
}
