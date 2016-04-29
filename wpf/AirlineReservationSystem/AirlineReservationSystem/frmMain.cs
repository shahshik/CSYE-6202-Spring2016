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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmLogin.ActiveForm.Visible = false;
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin.ActiveForm.Close();
           
        }

        private void searchForFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchFlights fSearch = new frmSearchFlights();
            fSearch.Show(this);
            fSearch.StartPosition = FormStartPosition.CenterParent;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void airportMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterAirport fAirport = new frmRegisterAirport();
            fAirport.Show(this);
            fAirport.StartPosition = FormStartPosition.CenterParent;
        }

        private void flightMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFlightMaster f = new frmFlightMaster();
            f.Show(this);
            f.StartPosition = FormStartPosition.CenterParent;
        }

        private void rateMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRate fRate = new frmRate();
            fRate.Show(this);
            fRate.StartPosition = FormStartPosition.CenterParent;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.Show(this);
            fLogin.StartPosition = FormStartPosition.CenterParent;

        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelBooking frmCancel = new frmCancelBooking();
            frmCancel.Show(this);
            
        }
    }
}
