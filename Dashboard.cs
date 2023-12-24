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
            display = "patientsBtn";

        }

        private void doctorsBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Doctors List View";
            display = "doctorsBtn";
        }

        private void appointmentsBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Appointment Bookings";
            display = "appointmentsBtn";

        }

        private void insurancesBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "List of Insurances";
            display = "insurancesBtn";
        }

        private void billingBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Recent Billings";
            display = "billingsBtn";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }
        private void PopulateGridView()
        {
            connection.Open();
            if (display.Equals("patientsBtn")) {

                query = "SELECT*FROM patient_Table";

            }else if (display.Equals("doctorsBtn"))
            {
               // query = "SELECT*FROM patient_Table";

            }else if (display.Equals("appointmentsBtn"))
            {
               // query = "";

            }else if (display.Equals("insurancesBtn"))
            {
               // query = "";

            }
            else if (display.Equals("billingsBtn"))
            {
                //query = "";

            }
            else{
                query = "SELECT*FROM patient_Table";
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DataGridView.DataSource = dataTable;
            connection.Close();

        }

      
    }
}
