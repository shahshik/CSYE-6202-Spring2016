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
    public partial class frmViewFlight : Form
    {
        BookingDAO bd = new BookingDAO();
        Booking booking = new Booking();
        clsDatabase cDA = new clsDatabase();
        Flight flight = new Flight();
        public frmViewFlight()
        {
            InitializeComponent();
            LoadDataGrid();


        }

     
        private DataTable LoadDataGrid()
        {
            DataTable Dt = new DataTable();
            cDA.ConnectDatabase();
            SqlCommand Cmd = new SqlCommand("SELECT f.flightNo,f.flightName,f.Source,f.Destination FROM Flight f where f.Source = @fromFlight and f.Destination = @toFlight ", cDA.Conn);
            Cmd.Parameters.AddWithValue("@fromFlight", flight.source);
            Cmd.Parameters.AddWithValue("@toFlight", flight.destination);
            SqlDataAdapter sDa = new SqlDataAdapter(Cmd);
            sDa.Fill(Dt);
            return Dt;
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Cancel the booking?", "Delete Warning Page", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bd.cancelFlight(booking);
                LoadDataGrid();
                MessageBox.Show("Booking Cancel Successfully", "Airport Remove Warning");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to do the booking?", "Booking Warning Page", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bd.bookFlight(booking);
                LoadDataGrid();
                MessageBox.Show("Booking  Successfully", "Booking Warning");
            }
        }
    }
}
