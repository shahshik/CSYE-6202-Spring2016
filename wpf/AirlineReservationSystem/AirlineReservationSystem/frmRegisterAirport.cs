using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using AirlineReservationSystem.Classes;
using AirlineReservationSystem.DAO;

namespace AirlineReservationSystem
{
    public partial class frmRegisterAirport : Form
    {
        Airport airport = new Airport();
        AirportDAO airportDAO = new AirportDAO();
        public frmRegisterAirport()
        {
            InitializeComponent();
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Domestic airport insert 

            if (btnSave.Text == "Save")
            {
                airport.Airport_Code = txtAirportCode.Text;
                airport.Airport_Name = txtAirportName.Text;
               int count= airportDAO.insertDomesticData(airport);
                if (count>=0)
                {
                    MessageBox.Show("Domestic Airport Details Saved SuccessFully !!");
                }
            }
            else
            {

            }
        }

       
        private void btnIntClose_Click(object sender, EventArgs e)
        {

        }

        private void btnIntSave_Click(object sender, EventArgs e)
        {
            //International Airport Insert
            if (btnIntSave.Text == "Save")
            {
                airport.Airport_Code = txtIntAirportCode.Text;
                airport.Airport_Name = txtIntAirportName.Text;
                int count = airportDAO.insertInternationalData(airport);
                if (count >= 0)
                {
                    MessageBox.Show("Internationl Airport Details Saved SuccessFully !!");
                }
            }
            else
            {

            }

        }
    }
}
