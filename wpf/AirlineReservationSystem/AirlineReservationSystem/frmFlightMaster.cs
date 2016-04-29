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
    public partial class frmFlightMaster : Form
    {
        clsDatabase cDA = new clsDatabase();
        SeatingCapacity sc = new SeatingCapacity();
        Flight flight = new Flight();
        FlightDAO flightDAO = new FlightDAO();

        public frmFlightMaster()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            cDA.ConnectDatabase();
            SqlDataAdapter Cmd = new SqlDataAdapter("SELECT f.flightNo,f.flightName,f.source,f.destination FROM Flight f order by flightno ", cDA.Conn);
            //Console.WriteLine(date);
            DataSet DS = new DataSet();
            Cmd.Fill(DS);

            dvFlight.DataSource = DS.Tables[0];

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                flight.flightNo = txtFlightNo.Text;
                flight.flightName = txtFlightName.Text;
                flight.seatingCapacity = txtSeatCapacity.Text;
                sc.economyclass_no = txtEcoSeat.Text;
                sc.economyplus_no = txtEcoPlusSeat.Text;
                sc.business = txtBusinessSeat.Text;
                flight.carrierInformation = txtCarrierInformation.Text;
                flight.flightCrewInformation = txtFlightCrewInformation.Text;
                flight.carrier = txtCarrier.Text;
                flight.source = txtSource.Text;
                flight.destination = txtDestination.Text;
                if (txtFlightNo.Text == "" || txtFlightNo.Text.Trim().Equals("") || txtFlightName.Text == "" || txtFlightName.Text.Trim().Equals("") || txtSource.Text == "" || txtSource.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please fill in all the fields", "New Airport Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { 
                int count = flightDAO.insertData(sc,flight);
                LoadDataGrid();
                if (count >= 0)
                {
                    MessageBox.Show("Flight Details Saved SuccessFully !!");
                }
               }
            }
               else
              {
                int count = flightDAO.updateFlightData(flight);
                LoadDataGrid();
                if (count >= 0)
                {
                    MessageBox.Show("Flight Details Updated SuccessFully !!");
                }
            }
        
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFlightNo.Text = "";
            txtFlightName.Text = "";
            txtSeatCapacity.Text = "";
            txtEcoSeat.Text = "";
            txtEcoPlusSeat.Text = "";
            txtBusinessSeat.Text = "";
            txtCarrierInformation.Text = "";
            txtFlightCrewInformation.Text = "";
            txtCarrier.Text = "";
            btnSave.Text = "Save";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete ?", "Delete Warning Page", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                flightDAO.deleteSeat(flight);
                LoadDataGrid();
                MessageBox.Show("Seat Deleted Successfully", "Airport Remove Warning");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvFlight_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            flight.flightNo = dvFlight.CurrentRow.Cells[0].Value.ToString();
            flight.oldflightNo = dvFlight.CurrentRow.Cells[0].Value.ToString();
            flight.flightName = dvFlight.CurrentRow.Cells[1].Value.ToString();
           // sc.economyclass_no = dvFlight.CurrentRow.Cells[1].Value.ToString();
            //sc.economyplus_no = dvFlight.CurrentRow.Cells[2].Value.ToString();
            //sc.business = dvFlight.CurrentRow.Cells[3].Value.ToString();
            flight.source = dvFlight.CurrentRow.Cells[2].Value.ToString();
            flight.destination = dvFlight.CurrentRow.Cells[3].Value.ToString();
            txtFlightNo.Text = flight.flightNo;
            txtFlightName.Text = flight.flightName;
            txtSource.Text = flight.source;
            txtDestination.Text = flight.destination;
           
            flightDAO.fillFlight(flight);
                btnSave.Text = "Update";
            }

      
    }
}
