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
    public partial class frmFlightMaster : Form
    {

        SeatingCapacity sc = new SeatingCapacity();
        Flight flight = new Flight();
        FlightDAO flightDAO = new FlightDAO();

        public frmFlightMaster()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                flight.flightNo = txtFlightNo.Text;
                flight.flightName = txtFlightName.Text;
                flight.seatingCapacity = Int32.Parse(txtSeatCapacity.Text);
                sc.economyclass_no = txtEcoSeat.Text;
                sc.economyplus_no = txtEcoPlusSeat.Text;
                sc.business = txtBusinessSeat.Text;
                flight.carrierInformation = txtCarrierInformation.Text;
                flight.flightCrewInformation = txtFlightCrewInformation.Text;
                flight.carrier = txtCarrier.Text;
                int count = flightDAO.insertData(sc,flight);
                if (count >= 0)
                {
                    MessageBox.Show("Flight Details Saved SuccessFully !!");
                }
            }
            else
            {
            }
        
        }
    }
}
