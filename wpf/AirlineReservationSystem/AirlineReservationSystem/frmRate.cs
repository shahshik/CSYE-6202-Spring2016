using AirlineReservationSystem.Classes;
using AirlineReservationSystem.DAO;
using System;
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
    public partial class frmRate : Form
    {
        Rate rate = new Rate();
        RateDAO rateDAO = new RateDAO();
        private string[] seatTypes;

        public frmRate()
        {
            InitializeComponent();
            LoadSeatTypes();
        }

        private void LoadSeatTypes()
        {
            seatTypes = new[] { "Economy", "Economy Plus", "Business"};
            cmbSeatType.Items.AddRange(seatTypes);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                rate.flightNo = txtFlightId.Text;
                rate.seatType = cmbSeatType.Text;
                rate.rate = txtRate.Text;
                int count = rateDAO.insertData(rate);
                if (count >= 0)
                {
                    MessageBox.Show("Rate Details Saved SuccessFully !!");
                }
            }
            else
            {

            }
        }
    }
}
