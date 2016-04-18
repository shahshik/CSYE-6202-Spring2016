using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication_Student
{
    /// <summary>
    /// Interaction logic for frmEdit.xaml
    /// </summary>
    public partial class frmEdit : Window
    {

        private Student student;
        private List<Student> studentList;
        private string[] departmentNames;
        public frmEdit(Student s, List<Student> students, string[] depttNames)
        {
            InitializeComponent();
            this.student = s;
            this.studentList = students;
            this.departmentNames = depttNames;

            txtStudentId.Text = student.StudentID;
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            cmbDepartment.Text = student.Department;
            btnFullTime.IsEnabled = true;
            txtStudentId.IsEnabled = true;
            cmbDepartment.IsEnabled = true;
            txtFirstName.IsEnabled = true;
            txtLastName.IsEnabled = true;
            btnPartTime.IsEnabled = true;
            btnFullTime.IsChecked = true;
            btnPartTime.IsChecked = true;
            LoadDepartments();
            string dept = student.Department;
            cmbDepartment.SelectedIndex = 0;
            if (btnFullTime.Content.Equals(student.EnrollmentType))
            {
                btnFullTime.IsChecked = true;
            }
            else
            {
                btnPartTime.IsChecked = true;
            }
            for (int i = 0; i < departmentNames.Count(); i++)
            {
                if (departmentNames[i].Equals(dept))
                {
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }
        }
        private void LoadDepartments()
        {
            foreach (string str in departmentNames)
            {
                cmbDepartment.Items.Add(str);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string studentId = txtStudentId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            if (studentId == "" || studentId.Trim().Equals("") || firstName == "" || firstName.Trim().Equals("") || lastName == "" || lastName.Trim().Equals(""))
            {
                MessageBox.Show("Please fill in all the fields", "Edit Student Warning Page", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string enrollmentType;
                if ((bool)btnFullTime.IsChecked)
                {
                    enrollmentType = "Full Time";
                }
                else enrollmentType = "Part Time";
                if (Regex.IsMatch(studentId, @"^\d{3}-\d{2}-\d{4}$") && Regex.IsMatch(firstName, @"^[A-Za-z]+$") && Regex.IsMatch(firstName, @"^[A-Za-z]+$"))
                {
                    MessageBoxResult warning = MessageBox.Show("Are you sure you want to update this student?", "Edit Student Warning Page", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (warning == MessageBoxResult.Yes)
                    {
                        
                        
                        student.StudentID = studentId;
                        student.FirstName = firstName;
                        student.LastName = lastName;
                        student.Department = cmbDepartment.Text;
                        student.EnrollmentType = enrollmentType;
                        this.Close();
                    }
                    else if (warning == MessageBoxResult.No)
                    {
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid format!!", "New Student Warning Page", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
