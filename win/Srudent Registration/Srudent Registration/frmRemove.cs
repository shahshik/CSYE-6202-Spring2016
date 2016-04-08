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
        Student s1;
        String v;
        public frmRemove(Student s)
        {

            InitializeComponent();
            s1 = s;
            txtStudentId.Text = s1.StudentID;
            txtFirstName.Text = s1.FirstName;
            txtLastName.Text = s1.LastName;
            cmbDepartment.Text = s1.Department;
            v = s1.EnrollmentType;
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
                //Student.mockStudentList.Remove(s1);
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
