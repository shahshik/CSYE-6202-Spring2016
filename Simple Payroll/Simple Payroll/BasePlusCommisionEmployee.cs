using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Payroll
{
     public class BasePlusCommisionEmployee : CommissionEmployee
    {
        private double baseSalary;

        public BasePlusCommisionEmployee(string first, string last,string ssn,double sales,
            double rate, double salary): base(first, last, ssn, sales, rate)
        {
            baseSalary = salary;
        }

        public double BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("Base Salary", value, "Base Salary must be >= 0");
            }
        }
        public override double earnings()
        {
            return BaseSalary + base.earnings();
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:C}\n{6}: {7:F2}",
                "Base Plus Commision employee", base.ToString(),
                "gross sales", GrossSales, "commission rate", CommissionRate,"Base Salary", BaseSalary);
         

        }


    }
}
