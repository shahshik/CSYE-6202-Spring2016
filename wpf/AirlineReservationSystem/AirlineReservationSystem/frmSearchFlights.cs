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
    public partial class frmSearchFlights : Form
    {

        FlightDAO flightDAO = new FlightDAO();
        Flight flight = new Flight();
        public frmSearchFlights()
        {
            InitializeComponent();
        }

        private void frmSearchFlights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineReservationSystemDataSet1.InternationalAirports' table. You can move, or remove it, as needed.
            this.internationalAirportsTableAdapter.Fill(this.airlineReservationSystemDataSet1.InternationalAirports);
            // TODO: This line of code loads data into the 'airlineReservationSystemDataSet.DomesticAirports' table. You can move, or remove it, as needed.
            this.domesticAirportsTableAdapter.Fill(this.airlineReservationSystemDataSet.DomesticAirports);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            flightDAO.searchFlight(flight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmViewFlight fView = new frmViewFlight();
            fView.Show(this);
            fView.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
