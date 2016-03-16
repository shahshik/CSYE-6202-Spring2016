using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Payroll
{
    public class SalariedEmployee : Employee
    {
        private double weeklySalary;

        public SalariedEmployee(String first, String last, String ssn, double salary) : base(first, last, ssn)
        {

            weeklySalary = salary;


        }

        public double WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if (value >= 0)
                    weeklySalary = value;
                else
                    throw new ArgumentOutOfRangeException("WeeklySalary", value, "Weekly Salary must be greater  than 0");
            }
        }

        public override double earnings()
        {
            return weeklySalary;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1:C}\n{2}",
               "Salaried Employee", base.ToString(), "Weekly Salary", WeeklySalary);
             
        

        }

    }
}
