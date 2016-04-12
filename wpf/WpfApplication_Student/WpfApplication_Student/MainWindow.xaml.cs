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

        int logattempt = 1;
        public MainWindow()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            passwordBox.MaxLength = 15;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            frmRegistration f = new frmRegistration();
            if (txtUsername.Text == "demouser" && passwordBox.Password == "demo")
            {

                logattempt = 0;
                //MessageBox.Show("Welcome to the student registration portal!!", "Login Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                //this.Hide();
                f.Show();
            }
            else if (logattempt == 3)
            {

                MessageBox.Show("Sorry!! Maximum attempts reached. Try again next time");
                this.Close();
            }
            else
            {

                txtUsername.Text = "";
                passwordBox.Password = "";
                MessageBox.Show("Invalid Username or Password!! Please enter again, you have reached attempt " + logattempt + " of 3");
                logattempt += 1;
            }



        }
    }
}
