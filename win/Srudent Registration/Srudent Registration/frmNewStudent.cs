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
    public partial class frmNewStudent : Form
    {
        private List<Student> studentList;
        private string[] departmentNames;
        public frmNewStudent()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            LoadDepartments();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;


        }
        private void LoadDepartments()
        {
            departmentNames = new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
            cmbDepartment.Items.AddRange(departmentNames);
        }
        public void GetStudentList(List<Student> studentList)
        {
            this.studentList = studentList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string studentId = txtStudentId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            if (studentId == "" || studentId.Trim().Equals("") || firstName == "" || firstName.Trim().Equals("") || lastName == "" || lastName.Trim().Equals(""))
            {
                MessageBox.Show("Please fill in all the fields", "New Student Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string enrollmentType;
                if (btnFullTime.Checked)
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
                    MessageBox.Show("Invalid format of the input!!", "New Student Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtStudentId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbDepartment.SelectedIndex = -1;
            btnFullTime.Checked = false;
            btnPartTime.Checked = false;
            txtStudentId.Focus();


        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
