using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinicManagementSystemApp
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
        }
        private void patientsBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Registered Patients";
           

        }

        private void doctorsBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Doctors List View";
           
        }

        private void appointmentsBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Appointment Bookings";
            

        }

        private void insurancesBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "List of Insurances";
           
        }

        private void billingBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Recent Billings";
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }
        private void PopulateGridView()
        {
            

        }

      
    }
}
