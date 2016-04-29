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
using System.Data.SqlClient;

namespace AirlineReservationSystem
{
    public partial class frmRegisterAirport : Form
    {

        clsDatabase cDA = new clsDatabase();
        Airport airport = new Airport();
        AirportDAO airportDAO = new AirportDAO();
        public frmRegisterAirport()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {

            LoadDataGrid();


        }
        private void LoadDataGrid()
        {
            cDA.ConnectDatabase();
            SqlDataAdapter Cmd = new SqlDataAdapter("SELECT Airport_Code,Airport_Name  FROM DomesticAirports order by Airport_Code", cDA.Conn);
            //Console.WriteLine(date);
            DataSet DS = new DataSet();
            Cmd.Fill(DS);

            gvDomestic.DataSource = DS.Tables[0];

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //Domestic airport insert 

            if (btnSave.Text == "Save")
            {
                airport.Airport_Code = txtAirportCode.Text;
                airport.Airport_Name = txtAirportName.Text;
                if (txtAirportCode.Text == "" || txtAirportCode.Text.Trim().Equals("") || txtAirportName.Text == "" || txtAirportName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please fill in all the fields", "New Airport Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    int count = airportDAO.insertDomesticData(airport);
                    LoadDataGrid();
                    if (count >= 0)
                    {
                        MessageBox.Show("Domestic Airport Details Saved SuccessFully !!");
                    }
                }
            }
            else
            {

                int count = airportDAO.updateDomesticData(airport);
                LoadDataGrid();
                if (count >= 0)
                {
                    MessageBox.Show("Domestic Airport Details Updated SuccessFully !!");
                }

            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete ?", "Delete Warning Page", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                airportDAO.deleteDomesticAirport(airport);
                LoadDataGrid();
                MessageBox.Show("Domestic Airport Deleted Successfully", "Airport Remove Warning");
            }

        }


        private void gvDomestic_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            airport.Airport_Code = gvDomestic.CurrentRow.Cells[0].Value.ToString();
            airport.OldAirport_Code = gvDomestic.CurrentRow.Cells[0].Value.ToString();
            airport.Airport_Name = gvDomestic.CurrentRow.Cells[1].Value.ToString();
            txtAirportCode.Text = airport.Airport_Code;
            txtAirportName.Text = airport.Airport_Name;
            airportDAO.fillDomesticAirport(airport);
            btnSave.Text = "Update";


        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAirportCode.Text = "";
            txtAirportName.Text = "";
            btnSave.Text = "Save";
        }
    }














    
    
}
