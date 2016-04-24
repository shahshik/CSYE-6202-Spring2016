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

namespace AirlineReservationSystem
{
    public partial class frmLogin : Form
    {
        SqlConnection sConn = new SqlConnection("Password=KIS@tpo363#;Persist Security Info=True;User ID=sa;Initial Catalog=AirlineReservationSystem;Data Source=NCSHAH\\SQLSERVER2016");
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                if (sConn.State == ConnectionState.Closed)
                {
                    sConn.Open();
                }
                SqlCommand cmd = new SqlCommand("select count(*) from usermaster where c_userid='"+ txtUserName.Text + "' and c_password='"+txtPassword.Text  +"'", sConn);
                int count = Convert.ToInt16(cmd.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Invalid Username Or Password !!", "Airline Reservation System", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Login Successfull !!", "Airline Reservation System", MessageBoxButtons.OKCancel);
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
    }
}
