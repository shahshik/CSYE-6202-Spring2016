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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication_Student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {

        String v_UserName = "demouser";
        String v_Password = "demopassword";
        int v_InvalidLogin = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text.ToString() != v_UserName && txtPassword.Text.ToString() != v_Password)
            {
                MessageBox.Show("Invalid UserName Or Password !");
                v_InvalidLogin++;
            }
            if (v_InvalidLogin == 3)
            {
                this.Close();


            }
            frmRegistration formreg = new frmRegistration();
            formreg.ShowDialog();
        }
    }
}
