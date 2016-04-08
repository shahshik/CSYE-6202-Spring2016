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
    public partial class frmNewStudent : Form
    {
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
            cmbDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            string value = "";
            bool isChecked = btnFullTime.Checked;
            if (isChecked)
                value = btnFullTime.Text;
            else
                value = btnPartTime.Text;
            if(string.IsNullOrWhiteSpace(txtStudentId.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(cmbDepartment.Text) || string.IsNullOrWhiteSpace(value))
            {
                var confirmResult = MessageBox.Show("Please fill in all the fields","Please fill in all the fields",MessageBoxButtons.OK);
                  if (confirmResult == DialogResult.OK)
                   {
                    //frmNewStudent n1 = new frmNewStudent();
                    //n1.Show();
                    return;
                   }
                
            }
            Student s1 = new Student(txtStudentId.Text, txtFirstName.Text, txtLastName.Text, cmbDepartment.Text
                , value);
            var mockStudentList = new List<Student>();
            mockStudentList.Add(s1);

            this.Close();
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
