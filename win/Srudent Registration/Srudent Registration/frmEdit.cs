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
    public partial class frmEdit : Form
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
                btnPartTime.Checked = true;
            }
            else
            {

                btnFullTime.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "";
            bool isChecked = btnFullTime.Checked;
            if (isChecked)
                value = btnFullTime.Text;
            else
                value = btnPartTime.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
