using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Payroll
{
    public class CommissionEmployee : Employee
    {
        private double grossSales;
        private double commissionRate;

        public CommissionEmployee(String first,String last,String ssn,double sales,double rate):base(first,last,ssn)
        {
            grossSales = sales;
            commissionRate = rate;
        }

        public double GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value >= 0)
                    grossSales = value;
                else
                
                    throw new ArgumentOutOfRangeException(
                        "GrossSales", value, "GrossSales must be >= 0");
                
            }
        }

        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value > 0 && value < 1)
                    commissionRate = value;
                else
                    throw new ArgumentOutOfRangeException("CommissionRate", value, "Commission must be >0 and < 1");
             }
        }

        public override double earnings()
        {
           
            return CommissionRate * GrossSales;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}",
                "commision employee", base.ToString(),
                "gross sales", GrossSales, "commission rate", CommissionRate);

        }
    }
}
