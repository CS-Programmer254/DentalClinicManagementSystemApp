using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagementSystemApp
{
    public partial class Dashboard : Form
    {
        private readonly DentalClinicDbEntities _dentalClinicDbEntities;
        public string NavigationButton { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities();
            NavigationButton = "Patients";

        }
        private async void patientsBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Registered Patients";
            NavigationButton ="Patients";
           await PopulateGridView(NavigationButton);
        }

        private async void doctorsBtn_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Doctors List View";
            NavigationButton="Doctors";
           await PopulateGridView(NavigationButton);
        }

        private async void appointmentsBtn_ClickAsync(object sender, EventArgs e)
        {
            groupBox.Text = "Appointment Bookings";
            NavigationButton = "Appointments";
            await PopulateGridView(NavigationButton);
        }

        private async void insurancesBtn_ClickAsync(object sender, EventArgs e)
        {
            groupBox.Text = "List of Insurances";
            NavigationButton = "Insurances";
            await PopulateGridView(NavigationButton);
        }

        private async void billingBtn_ClickAsync(object sender, EventArgs e)
        {
            groupBox.Text = "Recent Billings";
            NavigationButton = "Billings";
            await PopulateGridView(NavigationButton);
        }

        private async void Dashboard_LoadAsync(object sender, EventArgs e)
        {
            await PopulateGridView(NavigationButton);
        }
        public async Task FetchPatientsAsync()
        {
            var patients =await  _dentalClinicDbEntities.patient_Table.ToListAsync();
            DataGridView.DataSource = patients;
        }
        public async Task FetchAppointmentsAsync()
        {
            var appointments = await  _dentalClinicDbEntities.appointment_Table.ToListAsync();
            DataGridView.DataSource = appointments;
        }
        public async Task FetchDoctorsAsync()
        {
            var doctors = await _dentalClinicDbEntities.dentist_Table.ToListAsync();
            DataGridView.DataSource = doctors;
        }
        public async Task FetchInsurancesAsync()
        {
            var insurances = await _dentalClinicDbEntities.insurance_Table.ToListAsync();
            DataGridView.DataSource = insurances;
        }
        private async Task PopulateGridView(string navigationButton)
        {
            if (string.Equals(navigationButton,"Patients",StringComparison.InvariantCultureIgnoreCase))
            {
                await FetchPatientsAsync();
                return;

            }else if (string.Equals(navigationButton, "Doctors", StringComparison.CurrentCultureIgnoreCase))
            { 
               await FetchDoctorsAsync();
                return;
            }
            else if (string.Equals(navigationButton, "Appointments", StringComparison.CurrentCultureIgnoreCase))
            {
               await FetchAppointmentsAsync();
                return;
            }
            else if (string.Equals(navigationButton, "Insurances", StringComparison.CurrentCultureIgnoreCase))
            {
               await FetchInsurancesAsync();
                return;
            }
            else if (string.Equals(navigationButton, "Billings", StringComparison.CurrentCultureIgnoreCase))
            {
               
            }

        }

      
    }
}
