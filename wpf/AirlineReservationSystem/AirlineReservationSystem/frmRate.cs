using AirlineReservationSystem.Classes;
using AirlineReservationSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class frmRate : Form
    {
        Rate rate = new Rate();
        RateDAO rateDAO = new RateDAO();
        clsDatabase cDA = new clsDatabase();
        private string[] seatTypes;

        public frmRate()
        {
            InitializeComponent();
            LoadSeatTypes();
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            cDA.ConnectDatabase();
            SqlDataAdapter Cmd = new SqlDataAdapter("SELECT flightId, seatType, rate  FROM Rate order by flightId", cDA.Conn);
            //Console.WriteLine(date);
            DataSet DS = new DataSet();
            Cmd.Fill(DS);

            dvRate.DataSource = DS.Tables[0];

        }

        private void LoadSeatTypes()
        {
            seatTypes = new[] { "Economy", "Economy Plus", "Business"};
            cmbSeatType.Items.AddRange(seatTypes);
        }
       

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (btnSave.Text == "Save")
            {
                rate.flightNo= txtFlightId.Text;
                rate.seatType = cmbSeatType.Text;
                rate.rate = txtRate.Text;
              
                if (txtFlightId.Text == "" || txtFlightId.Text.Trim().Equals("") || cmbSeatType.Text == "" || cmbSeatType.Text.Trim().Equals("") || txtRate.Text == "" || txtRate.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please fill in all the fields", "New Airport Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    int count = rateDAO.insertData(rate);
                    LoadDataGrid();
                    if (count >= 0)
                    {
                        MessageBox.Show("Rate Details Saved SuccessFully !!");
                    }
                }
            }
            else
            {

                int count = rateDAO.updateRateData(rate);
                LoadDataGrid();
                if (count >= 0)
                {
                    MessageBox.Show("Rate Details Updated SuccessFully !!");
                }

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFlightId.Text = "";
            txtRate.Text = "";
            cmbSeatType.SelectedIndex = 0;
            btnSave.Text = "Save";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete ?", "Delete Warning Page", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                rateDAO.deleteRate(rate);
                LoadDataGrid();
                MessageBox.Show("Rate Deleted Successfully", "Airport Remove Warning");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dvRate_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            rate.flightNo = dvRate.CurrentRow.Cells[0].Value.ToString();
            rate.OldFlightId = dvRate.CurrentRow.Cells[0].Value.ToString();
            rate.seatType = dvRate.CurrentRow.Cells[1].Value.ToString();
            rate.rate = dvRate.CurrentRow.Cells[2].Value.ToString();
            txtFlightId.Text = rate.flightNo;
            for (int i = 0; i < seatTypes.Count(); i++)
            {
                if (seatTypes[i].Equals(seatTypes))
                {
                    cmbSeatType.SelectedIndex = i;
                    break;
                }
                txtRate.Text = rate.rate;
                rateDAO.fillRate(rate);
                btnSave.Text = "Update";



            }
        }
    }
}
