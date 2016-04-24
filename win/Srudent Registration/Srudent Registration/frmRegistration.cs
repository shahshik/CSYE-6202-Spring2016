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
        private List<Student> mockStudentList;
        Student s1 = new Student();
        private string[] departmentNames;
        public delegate void NewStudentList(List<Student> studentList);
        public event EventHandler DataChanged;

        public frmRegistration()
        {
            mockStudentList = new List<Student>();
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
            departmentNames = new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
            cmbDepartment.Items.AddRange(departmentNames);
        }
        private void LoadDataGridWithMockData()
        {
            string[] studentId = new string[10];
            for (int i = 0; i < 10; i++)
            {
                string randomId = RandomGenerator.RandomStudentId();
                int position = Array.IndexOf(studentId, randomId);
                while (position > -1)
                {
                    randomId = RandomGenerator.RandomStudentId();
                    position = Array.IndexOf(studentId, randomId);
                }
                studentId[i] = randomId;
            }
            for (int i = 0; i < 10; i++)
            {
                mockStudentList.Add(new Student(studentId[i], RandomGenerator.randomFirstName(), RandomGenerator.randomLastName(), RandomGenerator.randomDepartment(), RandomGenerator.enrollmentType()));
            }
            var bindingList = new BindingList<Student>(mockStudentList);
            var dataSource = new BindingSource(bindingList, null);
            dataGridViewStudents.DataSource = dataSource;
            SetColumnsInDataGrid();
        }

        public void SetColumnsInDataGrid()
        {
            dataGridViewStudents.Columns["StudentID"].DisplayIndex = 0;
            dataGridViewStudents.Columns["FirstName"].DisplayIndex = 1;
            dataGridViewStudents.Columns["LastName"].DisplayIndex = 2;
            dataGridViewStudents.Columns["Department"].DisplayIndex = 3;
            dataGridViewStudents.Columns["EnrollmentType"].DisplayIndex = 4;
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
            if (dataGridViewStudents.RowCount > 0)
            {
                Student selectedStudent = (Student)dataGridViewStudents.CurrentRow.DataBoundItem;
                frmEdit eStudent = new frmEdit(selectedStudent, mockStudentList, departmentNames);
                eStudent.ShowDialog();
                var bindingList = new BindingList<Student>(mockStudentList);
                var dataSource = new BindingSource(bindingList, null);
                dataGridViewStudents.DataSource = null;
                dataGridViewStudents.DataSource = dataSource;
                SetColumnsInDataGrid();
                btnFullTime.Select();
                cmbDepartment.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please select a student to edit from the list", "Student Update Warning");
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewStudent ns = new frmNewStudent(departmentNames);
            NewStudentList sList = new NewStudentList(ns.GetStudentList);
            sList(mockStudentList);
            ns.ShowDialog();

            var bindingList = new BindingList<Student>(mockStudentList);
            var dataSource = new BindingSource(bindingList, null);
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = dataSource;
            SetColumnsInDataGrid();
           
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
            if (dataGridViewStudents.RowCount > 0)
            {
                Student selectedStudent = (Student)dataGridViewStudents.CurrentRow.DataBoundItem;
                frmRemove rsp = new frmRemove(selectedStudent, mockStudentList);
                rsp.ShowDialog();
                var bindingList = new BindingList<Student>(mockStudentList);
                var dataSource = new BindingSource(bindingList, null);
                dataGridViewStudents.DataSource = null;
                dataGridViewStudents.DataSource = dataSource;
                SetColumnsInDataGrid();
                btnFullTime.Select();
                cmbDepartment.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please select a student to remove from the list", "Student Remove Warning");
            }
           
        }
    }
}
