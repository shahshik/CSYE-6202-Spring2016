using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Srudent_Registration
{
    public static class RandomGenerator
    {
        static Random random = new Random();

        public static string RandomStudentId()
        {
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            int part1 = random.Next(0, 100);
            int part2 = random.Next(0, 100);
            int part3 = random.Next(0, 100);
            string studentId = part1.ToString("d3") + "-" + part2.ToString("d2") + "-" + part3.ToString("d4");
            Match m = Regex.Match(studentId, pattern);
            while (m.Success)
            {
                m = m.NextMatch();
            }
            return studentId;
        }
        public static string randomFirstName()
        {
            string[] firstName = { "Ram", "Nam", "Anita", "Neeta", "Ankit", "Amu", "Vincent", "Chiku", "Dhiresh", "Saloni", "Avinash", "Kari", "Gira", "Ramesh", "Nayak" };
            int fn = random.Next(0, 15);
            return firstName[fn];
        }

        public static string randomLastName()
        {

            string[] lastName = { "Shah", "Joseph", "Patel", "Arora", "Singh", "Kothari", "Kumaran", "Kumar", "Nauki", "Mehta", "Parekh", "Shetty", "Gandhi", "Mahidharia", "Sharma" };
            int ln = random.Next(lastName.Length);
            return lastName[ln];
        }

        public static string randomDepartment()
        {
            string[] departmentName = { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
            int deptt = random.Next(departmentName.Length);
            return departmentName[deptt];
        }

        public static string enrollmentType()
        {
            string[] enrollmentType = { "Full Time", "Part Time" };
            int et = random.Next(enrollmentType.Length);
            return enrollmentType[et];
        }
    }
}

