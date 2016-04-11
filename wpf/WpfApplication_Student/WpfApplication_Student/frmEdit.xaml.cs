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
    /// Interaction logic for frmEdit.xaml
    /// </summary>
    public partial class frmEdit : Window
    {
        Student s1;
        String v;
        public frmEdit(Student s)
        {
            InitializeComponent();
            s1 = s;
            txtStudentId.Text = s1.StudentID;
            txtFirstName.Text = s1.FirstName;
            txtLastName.Text = s1.LastName;
            cmbDepartment.Text = s1.Department;
            v = s1.EnrollmentType;
            if (v.Equals("Part Time"))
            {
                btnPartTime.IsChecked = true;
            }
            else
            {

                btnFullTime.IsChecked = true;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string value1 = "";
            bool chk = btnFullTime.GetValue(true);
            if (chk)
                value1 = btnFullTime.Text;
            else
                value1 = btnPartTime.Text;
            if (string.IsNullOrWhiteSpace(txtStudentId.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(cmbDepartment.Text) || string.IsNullOrWhiteSpace(value))
            {
                var confirmResult = MessageBox.Show("Please fill in all the fields", "Please fill in all the fields", MessageBoxButtons.OK);
                if (confirmResult == DialogResult.OK)
                {
                    this.Show();
                }

            }
            var confirmResult1 = MessageBox.Show("Are you sure you want to update this student", "Are you sure you want to update this student?", MessageBoxButtons.YesNo);
            if (confirmResult1 == DialogResult.Yes)
            {
                Student s2 = new Student(txtStudentId.Text, txtFirstName.Text, txtLastName.Text, cmbDepartment.Text, value);
                //Student.mockStudentList.Add(s2);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
