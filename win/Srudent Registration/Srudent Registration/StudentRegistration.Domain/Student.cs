using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srudent_Registration.StudentRegistration.Domain
{
    public class Student
    { 
        public string StudentID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string EnrollmentType { get; set; }
        public static List<Student> mockStudentList;
        public Student(string studentId, string firstName, string lastName, string department,string enrollmentType)
        {
            StudentID = studentId;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            EnrollmentType = enrollmentType;
        }

        public Student()
        {
        }

        public override string ToString()
        {
            return string.Format("StudentID: {0}, FirstName: {1}, LastName: {2}, Department: {3}, EnrollmentType: {4}", StudentID, FirstName, LastName, Department, EnrollmentType);
        }
    }
}
