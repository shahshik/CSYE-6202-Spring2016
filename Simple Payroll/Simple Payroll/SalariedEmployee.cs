using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Payroll
{
    public class SalariedEmployee extends Employee
    {
    private double weeklySalary;
 7
 8      // four-argument constructor
 9      public SalariedEmployee(String first, String last, String ssn,
10         double salary)
11      {
12         super(first, last, ssn ); // pass to Employee constructor
13         setWeeklySalary(salary ); // validate and store salary
14      } // end four-argument SalariedEmployee constructor
15
16      // set salary
17      public void setWeeklySalary(double salary)
18      {
19         if ( salary >= 0.0 )
20            baseSalary = salary;
21         else
22            throw new IllegalArgumentException(
23               "Weekly salary must be >= 0.0" );
24      } // end method setWeeklySalary
25
26      // return salary
27      public double getWeeklySalary()
28      {
29         return weeklySalary;
30      } // end method getWeeklySalary
31
32      // calculate earnings; override abstract method earnings in Employee
33      @Override                                                           
34      public double earnings()
35      {
36           return getWeeklySalary();                                        
37      } // end method earnings                                            
38
39      // return String representation of SalariedEmployee object   
        }
}
