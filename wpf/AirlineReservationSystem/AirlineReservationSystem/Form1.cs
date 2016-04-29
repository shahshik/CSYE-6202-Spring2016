using System;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AirlineReservationSystem.Classes;

namespace AirlineReservationSystem
{
    public partial class frmLogin : Form
    {
        //SqlConnection sConn = new SqlConnection("Password=KIS@tpo363#;Persist Security Info=True;User ID=sa;Initial Catalog=AirlineReservationSystem;Data Source=NCSHAH\\SQLSERVER2016");
        clsDatabase cDb = new clsDatabase();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
           /* if (txtUserName.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
            {
                //MessageBox.Show("Login Successfull !!", "Airline Reservation System", MessageBoxButtons.OKCancel);
                //this.Close();
                frmMain fmain = new frmMain();
                fmain.Show();

            }
            else {
                MessageBox.Show("Login UnSuccessfull !!", "Airline Reservation System", MessageBoxButtons.OKCancel);
            }*/

                if (txtUserName.Text != "" && txtPassword.Text != "")
                {
                    cDb.ConnectDatabase();

                    int count = cDb.GetDataCount("select count(*) from usermaster where c_username='" + txtUserName.Text + "' and c_password='" + txtPassword.Text + "'");
                    if (count == 0)
                    {
                        MessageBox.Show("Invalid Username Or Password !!", "Airline Reservation System", MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        //MessageBox.Show("Login Successfull !!", "Airline Reservation System", MessageBoxButtons.OKCancel);
                        //this.Close();
                        frmMain fmain = new frmMain();
                        fmain.Show();

                    }

                }
                else
                {
                    MessageBox.Show("You Have Not Entered Username Or Password !!", "Airline Reservation System", MessageBoxButtons.OKCancel);
                }

            
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmCustomerRegistration fCustomer = new frmCustomerRegistration();
            fCustomer.Show();
        }

       
    }
}
