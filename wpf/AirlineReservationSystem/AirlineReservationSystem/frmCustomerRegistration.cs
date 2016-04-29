using AirlineReservationSystem.Classes;
using AirlineReservationSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace AirlineReservationSystem
{
    public partial class frmCustomerRegistration : Form
    {
        Customer customer = new Customer();
        User user = new User();
        NewCustomerDAO customerDAO = new NewCustomerDAO();

        public frmCustomerRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Customer customer = new Customer();
            string name = textBox1.Text;
            string address = textBox2.Text;
            string phoneno = textBox3.Text;
            string username = textBox4.Text;
            string password = textBox5.Text;

            if (name == "" || name.Trim().Equals("") || address == "" || address.Trim().Equals("") || phoneno == "" || phoneno.Trim().Equals("") || username.Trim().Equals("") || username == "" || password.Trim().Equals("") || password == "")
            {
                MessageBox.Show("Please fill in all the fields", "New Customer Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
                if (Regex.IsMatch(phoneno, @"^\d{3}-\d{3}-\d{4}$") && Regex.IsMatch(name, @"^[A-Za-z]+$") && Regex.IsMatch(username, @"^[A-Za-z]+$"))
                {
                   customer.name = name;
                   customer.address = address;
                   customer.phoneNo = phoneno;
                   user.username = username;
                   user.password = password;

                   int count = customerDAO.insertData(customer,user);
                   if (count >= 0)
                   {
                    MessageBox.Show("Customer Details Saved SuccessFully !!");
                    frmLogin f1 = new frmLogin();
                    f1.Show();
                   }
                }
                else
                {
                    MessageBox.Show("Invalid format of the input!!", "New Customer Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               }
            
           
        }
    }

