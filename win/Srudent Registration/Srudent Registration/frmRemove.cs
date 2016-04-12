using Srudent_Registration.StudentRegistration.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Srudent_Registration
{
    public partial class frmRemove : Form
    {
        private Student student;
        private List<Student> studentList;
        private string v;
        public frmRemove(Student s, List<Student> sl)
        {
            this.student = s;
            this.studentList = sl;
            InitializeComponent();
            student = s;
            txtStudentId.Text = student.StudentID;
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            cmbDepartment.Text = student.Department;
            v = student.EnrollmentType;
            if(v.Equals("Part Time"))
            {
                btnPartTime.Checked = true;
            }
            else
            {

                btnFullTime.Checked = true;
            }

            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove this student", "Are you sure you want to remove this student?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                studentList.Remove(student);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
