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
    /// Interaction logic for frmNew.xaml
    /// </summary>
    public partial class frmNew : Window
    {
        private List<Student> studentList;
        private string[] departmentNames;
        private bool isChanged = false;
        public frmNew(List<Student> studentList, string[] departmentName)
        {
            InitializeComponent();
            this.studentList = studentList;
            this.departmentNames = departmentName;
            LoadDepartments();
            btnFullTime.IsChecked = true;
            cmbDepartment.SelectedIndex = -1;
            if (isChanged)
            {
                btnAdd.IsEnabled = true;
                btnReset.IsEnabled = true;
            }
            else
            {
                btnAdd.IsEnabled = false;
                btnReset.IsEnabled = false;
            }

        }
        private void LoadDepartments()
        {
            cmbDepartment.Items.Add(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            btnFullTime.IsChecked = true;
            cmbDepartment.SelectedIndex = -1;
            LoadDepartments();
            txtStudentId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentId.Focus();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string studentId = txtStudentId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            if (studentId == "" || studentId.Trim().Equals("") || firstName == "" || firstName.Trim().Equals("") || lastName == "" || lastName.Trim().Equals(""))
            {
                MessageBox.Show("Please fill in all the fields", "New Student Warning Page", MessageBoxButton.OK, MessageBoxImage.Warning);
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
                    Student s = new Student(studentId, firstName, lastName, cmbDepartment.Text, enrollmentType);
                    studentList.Add(s);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid format of the input!!", "New Student Warning Page", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            isChanged = true;
            btnAdd.IsEnabled = true;
            btnReset.IsEnabled = true;
        }

        private void txtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            isChanged = true;
            btnAdd.IsEnabled = true;
            btnReset.IsEnabled = true;
        }

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            isChanged = true;
            btnAdd.IsEnabled = true;
            btnReset.IsEnabled = true;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            isChanged = true;
            btnAdd.IsEnabled = true;
            btnReset.IsEnabled = true;
        }
    }
}
