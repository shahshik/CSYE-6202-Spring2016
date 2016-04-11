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
    Student s1;
    String v;

    /// Interaction logic for frmRemove.xaml
    /// </summary>
    public partial class frmRemove : Window
    {
        public frmRemove(Student s)
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
                btnPartTime.Checked = true;
            }
            else
            {

                btnFullTime.Checked = true;
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove this student", "Are you sure you want to remove this student?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //Student.mockStudentList.Remove(s1);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
