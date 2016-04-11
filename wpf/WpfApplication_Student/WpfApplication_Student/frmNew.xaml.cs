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
    /// <summary>
    /// Interaction logic for frmNew.xaml
    /// </summary>
    public partial class frmNew : Window
    {
        private List<Student> studentList;
        private string[] departmentNames;
        private bool isChanged = false;
        public frmNew(List<Student> studentList, string[] departmentName)
        {
            InitializeComponent();
            this.studentList = studentList;
            this.departmentNames = departmentName;
            LoadDepartments();
            btnFullTime.IsChecked = true;
            cmbDepartment.SelectedIndex = -1;
            if (isChanged)
            {
                btnAdd.IsEnabled = true;
                btnReset.IsEnabled = true;
            }
            else
            {
                btnAdd.IsEnabled = false;
                btnReset.IsEnabled = false;
            }

        }
        private void LoadDepartments()
        {
            cmbDepartment.Items.Add(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
