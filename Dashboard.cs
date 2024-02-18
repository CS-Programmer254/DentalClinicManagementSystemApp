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
        NewPatientForm newPatient;
        BookAppointment bookAppointment;
        public string NavigationButton { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities();
            NavigationButton = "Patients";

        }
        private async void patientsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox.Text = "Registered Patients";
                NavigationButton = "Patients";
                await PopulateGridView(NavigationButton);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void doctorsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox.Text = "Doctors List View";
                NavigationButton = "Doctors";
                await PopulateGridView(NavigationButton);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void appointmentsBtn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                groupBox.Text = "Appointment Bookings";
                NavigationButton = "Appointments";
                await PopulateGridView(NavigationButton);

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private async void insurancesBtn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                groupBox.Text = "List of Insurances";
                NavigationButton = "Insurances";
                await PopulateGridView(NavigationButton);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private async void billingBtn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                groupBox.Text = "Recent Billings";
                NavigationButton = "Billings";
                await PopulateGridView(NavigationButton);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void Dashboard_LoadAsync(object sender, EventArgs e)
        {
            await PopulateGridView(NavigationButton);
        }
        public void FetchPatients()
        {
            try
            {
                // var patients =await  _dentalClinicDbEntities.patient_Table.ToListAsync();
                var patients = _dentalClinicDbEntities.patient_Table.Select(p => new
                {
                    FileNo = p.patientID,
                    PatientName = p.patientName,
                    Gender = p.gender,
                    Email = p.email,
                    Telephone = p.patientTel,
                    RegistrationDate = p.registrationDate,
                    InsuranceID = p.insuranceID,
                    Residence = p.residence,
                }).ToList();
                DataGridView.DataSource = patients;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task FetchAppointmentsAsync()
        {
            try
            {
                var appointments = await _dentalClinicDbEntities.appointment_Table.ToListAsync();
                DataGridView.DataSource = appointments;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task FetchDoctorsAsync()
        {
            try
            {
                var doctors = await _dentalClinicDbEntities.dentist_Table.ToListAsync();
                DataGridView.DataSource = doctors;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task FetchInsurancesAsync()
        {
            try
            {
                var insurances = await _dentalClinicDbEntities.insurance_Table.ToListAsync();
                DataGridView.DataSource = insurances;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task PopulateGridView(string navigationButton)
        {
            try
            {
                if (string.Equals(navigationButton, "Patients", StringComparison.InvariantCultureIgnoreCase))
                {
                    FetchPatients();
                    return;

                }
                else if (string.Equals(navigationButton, "Doctors", StringComparison.CurrentCultureIgnoreCase))
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
            catch (Exception)
            {

                throw;
            }

        }

        private void newPatientLabel_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookAppointment != null)
                {
                    bookAppointment.Close();

                }
                newPatient = new NewPatientForm();
                newPatient.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void appointmentLabel_Click(object sender, EventArgs e)
        {
            try
            {
                if (newPatient != null)
                {
                    newPatient.Close();

                }
                bookAppointment = new BookAppointment();
                bookAppointment.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
