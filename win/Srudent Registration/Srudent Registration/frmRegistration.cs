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
    public partial class frmRegistration : Form, IStudentRegistrationForm
    {
        //public static List<Student> mockStudentList;
        Student s1 = new Student();
        public event EventHandler DataChanged;
        public frmRegistration()
        {
            InitializeComponent();
            Init();
            txtStudentId.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            cmbDepartment.Enabled = false;
            btnFullTime.Enabled = false;
            btnPartTime.Enabled = false;
            
        }

        private void Init()
        {
            LoadDepartments();
            LoadDataGridWithMockData();
            LoadDefaults();
        }
        private void LoadDepartments()
        {
            cmbDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }
        private void LoadDataGridWithMockData()
        {
            var mockStudentList1 = new List<Student>()
            {
                new Student("111-11-1212","Bart","Simpson","Information Systems","Full Time"),
                new Student("123-12-1234","Maggie","Simpson","International Affairs","Part Time"),
            };

            var bindingList = new BindingList<Student>(mockStudentList1);
            var source = new BindingSource(bindingList, null);
            dataGridViewStudents.DataSource = source;

        }

        private void LoadDefaults()
        {
            btnFullTime.Select();
            cmbDepartment.SelectedIndex = 0;
        }

        private void HandleDataGridViewStudentsSelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                txtStudentId.Text = row.Cells[0].Value.ToString();
                txtFirstName.Text = row.Cells[1].Value.ToString();
                txtLastName.Text = row.Cells[2].Value.ToString();

                cmbDepartment.SelectedIndex = cmbDepartment.Items.IndexOf(row.Cells[3].Value.ToString());

                
                var enrollmentType = row.Cells[4].Value.ToString();
                if (btnFullTime.Text == enrollmentType)
                {
                    btnFullTime.Checked = true;
                }
                else if (btnPartTime.Text == enrollmentType)
                {
                    btnPartTime.Checked = true;
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            s1.StudentID = dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString();
            s1.FirstName = dataGridViewStudents.SelectedRows[0].Cells[1].Value.ToString();
            s1.LastName = dataGridViewStudents.SelectedRows[0].Cells[2].Value.ToString();
            s1.Department = dataGridViewStudents.SelectedRows[0].Cells[3].Value.ToString();
            s1.EnrollmentType = dataGridViewStudents.SelectedRows[0].Cells[4].Value.ToString();
            frmEdit f2 = new frmEdit(s1);
            f2.Show();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewStudent f1 = new frmNewStudent();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnFullTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPartTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //s1.StudentID = dataGridViewStudents.CurrentRow.Cells["Student ID"].Value.ToString();
            //s1.FirstName = dataGridViewStudents.CurrentRow.Cells["First Name"].Value.ToString();
            //s1.LastName = dataGridViewStudents.CurrentRow.Cells["Last Name"].Value.ToString();
            //s1.Department = dataGridViewStudents.CurrentRow.Cells["Department"].Value.ToString();
            //s1.EnrollmentType = dataGridViewStudents.CurrentRow.Cells["Enrollment Type"].Value.ToString();

            s1.StudentID = dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString();
            s1.FirstName = dataGridViewStudents.SelectedRows[0].Cells[1].Value.ToString();
            s1.LastName = dataGridViewStudents.SelectedRows[0].Cells[2].Value.ToString();
            s1.Department = dataGridViewStudents.SelectedRows[0].Cells[3].Value.ToString();
            s1.EnrollmentType = dataGridViewStudents.SelectedRows[0].Cells[4].Value.ToString();

            frmRemove f = new frmRemove(s1);
            f.ShowDialog(this);
        }
    }
}
