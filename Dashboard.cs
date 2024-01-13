using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinicManagementSystemApp
{
    public partial class Dashboard : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DEKTOP-KHILI9C-\\SQLEXPRESS;Initial Catalog=DentalClinicDb;Integrated Security=True");
        private string display = "";
        string query;
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
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DataGridView.DataSource = dataTable;
            connection.Close();

        }

      
    }
}
