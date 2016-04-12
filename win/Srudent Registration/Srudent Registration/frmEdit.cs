using Srudent_Registration.StudentRegistration.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Srudent_Registration
{
    public partial class frmEdit : Form
    {
        private Student s1;
        private List<Student> studentList;
        String v;
        public frmEdit(Student s, List<Student> s2, string[] depttNames)
        {
            
            this.s1 = s;
            this.studentList = s2;
            InitializeComponent();
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
            string studentId = txtStudentId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
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
            if (Regex.IsMatch(studentId, @"^\d{3}-\d{2}-\d{4}$") && Regex.IsMatch(firstName, @"^[A-Za-z]+$") && Regex.IsMatch(firstName, @"^[A-Za-z]+$"))
            {
                DialogResult warning = MessageBox.Show("Are you sure you want to update this student?", "Edit Student Warning Page", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (warning == DialogResult.Yes)
                {
                    s1.StudentID = studentId;
                    s1.FirstName = firstName;
                    s1.LastName = lastName;
                    s1.Department = cmbDepartment.Text;
                    s1.EnrollmentType = value;
                    this.Close();
                }
                else if (warning == DialogResult.No)
                {
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Invalid format of the input!!", "New Student Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
