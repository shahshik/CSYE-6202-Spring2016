using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simple_Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            String t, fname,lname, s;
            double gr, cr;
            Console.WriteLine("Enter type of Employee:");
            t = Console.ReadLine();
            Console.WriteLine("Enter First Name:");
            fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            lname = Console.ReadLine();
            Console.WriteLine("Enter Social Security Number");
            s = Console.ReadLine();
            
            if(t.Equals("Salaried Employee"))
            {
                Console.WriteLine("Enter Weekly Salary");
                double se = Convert.ToDouble(Console.ReadLine());
                SalariedEmployee salariedEmployee = new SalariedEmployee(fname, lname, s, se);
                Console.WriteLine("{0}\nearned: {1:C}\n",
                    salariedEmployee, salariedEmployee.earnings());

            }else if(t.Equals("Hourly Employee"))
            {
                Console.WriteLine("Enter Wage");
                double w = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Hours");
                double h = Convert.ToDouble(Console.ReadLine());
                HourlyEmployee hourlyEmployee = new HourlyEmployee(fname, lname, s, w,h);
                Console.WriteLine("{0}\nearned: {1:C}\n",
                    hourlyEmployee, hourlyEmployee.earnings());
            }
            else if (t.Equals("Commission Employee"))
            {
                
                Console.WriteLine("Enter Gross Sales");
                gr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Commission Rate");
                cr = Convert.ToDouble(Console.ReadLine());
                CommissionEmployee commissionEmployee = new CommissionEmployee(fname, lname, s, gr,cr);
                Console.WriteLine("{0}\nearned: {1:C}\n",
                    commissionEmployee, commissionEmployee.earnings());
            }
            else if (t.Equals("BasePlusCommission Employee"))
            {   
                Console.WriteLine("Enter Gross Sales");
                gr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Commission Rate");
                cr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Base Salary");
                double bs = Convert.ToDouble(Console.ReadLine());
                BasePlusCommisionEmployee bcommissionEmployee = new BasePlusCommisionEmployee(fname, lname, s, gr, cr,bs);
                Console.WriteLine("{0}\nearned: {1:C}\n",
                    bcommissionEmployee, bcommissionEmployee.earnings());
            }
            else
            {
                Console.WriteLine("Enter Valid Employee Type");


            }
        }
    }
}
