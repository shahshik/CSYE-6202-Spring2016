using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for frmRegistration.xaml
    /// </summary>
    public partial class frmRegistration : Window
    {
        private List<Student> randomStudentList;
        private string[] departmentNames;
        
        public event EventHandler DataChanged;
        public frmRegistration()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            LoadDepartments();
            LoadDataGridWithMockData();
            LoadDefaults();
        }
        private void LoadDepartments()
        {
            cmbDepartment.Items.Add(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
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
            //var source = new B(bindingList, null);
            dataGridViewStudents.DataContext = bindingList;

        }

        private void LoadDefaults()
        {
            
            cmbDepartment.SelectedIndex = 0;
           
            btnFullTime.IsEnabled = false;
            txtStudentId.IsEnabled = false;
            cmbDepartment.IsEnabled = false;
            txtFirstName.IsEnabled = false;
            txtLastName.IsEnabled = false;
            btnPartTime.IsEnabled = false;
            btnFullTime.IsChecked = false;
            btnPartTime.IsChecked = false;
            
        }

        private void HandleDataGridViewStudentsSelectionChanged(object sender, EventArgs e)
        {
            /*foreach (DataGrid row in dataGridViewStudents.SelectedItems)
            {
                txtStudentId.Text = 
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
            }*/
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            frmNew f1 = new frmNew(randomStudentList, departmentNames);
            nsr.ShowDialog();
            ObservableCollection<Student> list = new ObservableCollection<Student>(randomStudentList);
            RandomDataGrid.ItemsSource = null;
            RandomDataGrid.ItemsSource = list;
            comboBoxDeptt.SelectedIndex = 0;
            radioFull.IsEnabled = false;
            txtStudentId.IsEnabled = false;
            comboBoxDeptt.IsEnabled = false;
            txtFirst.IsEnabled = false;
            txtLast.IsEnabled = false;
            radioPart.IsEnabled = false;
            radioFull.IsChecked = false;
            radioPart.IsChecked = false;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Student student = (Student)dataGridViewStudents.SelectedItem;
            //s1.StudentID = (dataGridViewStudents.SelectedItem).Row["Id"].ToString();
            //s1.FirstName = dataGridViewStudents.SelectedRows[0].Cells[1].Value.ToString();
            //s1.LastName = dataGridViewStudents.SelectedRows[0].Cells[2].Value.ToString();
            //s1.Department = dataGridViewStudents.SelectedRows[0].Cells[3].Value.ToString();
            //s1.EnrollmentType = dataGridViewStudents.SelectedRows[0].Cells[4].Value.ToString();
            frmEdit f2 = new frmEdit(student);
            f2.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
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
