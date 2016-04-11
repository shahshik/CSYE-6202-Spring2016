using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for frmRemove.xaml
    /// </summary>
    public partial class frmRemove : Window
    {
        private Student student;
        private List<Student> studentList;
        private string[] departmentNames;
        public frmRemove(Student s, List<Student> sList)
        {   
             this.student = s;
            this.studentList = sList;
            InitializeComponent();
            LoadDepartments();
            txtStudentId.Text = student.StudentID;
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            cmbDepartment.Text = student.Department;
            if (btnFullTime.Content.Equals(student.EnrollmentType))
            {
                btnFullTime.IsChecked = true;
            }
            else
            {
                btnPartTime.IsChecked = true;
            }
            LoadDefaults();
        }
        private void LoadDepartments()
        {
            cmbDepartment.Items.Add(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }
        private void LoadDefaults()
        {
            btnFullTime.IsEnabled = false;
            txtStudentId.IsEnabled = false;
            cmbDepartment.IsEnabled = false;
            txtFirstName.IsEnabled = false;
            txtLastName.IsEnabled = false;
            btnPartTime.IsEnabled = false;
            btnFullTime.IsChecked = false;
            btnPartTime.IsChecked = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult warning = MessageBox.Show("Are you sure you want to remove this student?", "Remove Student Warning Page", MessageBoxButton.YesNo);
            if (warning == MessageBoxResult.Yes)
            {
                studentList.Remove(student);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
