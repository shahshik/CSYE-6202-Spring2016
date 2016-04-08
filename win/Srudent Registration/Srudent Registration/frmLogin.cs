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
    public partial class frmLogin : Form
    {
        String v_UserName = "demouser";
        String v_Password = "demopassword";
        int v_InvalidLogin = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
