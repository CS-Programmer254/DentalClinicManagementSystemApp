using DentalClinicManagementSystemApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagementSystemApp
{
    public partial class BookAppointment : Form
    {
        private readonly DentalClinicDbEntities _dentalClinicDbEntities;
        public string appointmentID;
        private readonly ISendMail _sendMail;
        public BookAppointment(ISendMail sendMail)
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities();
            _sendMail = sendMail;
        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            PopulateAppointmentDataGrid();
            PopulateDentistComboBox();
            PopulateDentalProcedureComboBox();
            appointmentID=PopulateAppointment();
        }
        public string PopulateAppointment()
        {
            var appointmentID = "AP" + GenerateAppointmentID();
            return appointmentID;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                var patientName = tbPatientName.Text;
                var dentalProcedure=cbDentalProcedure.Text;
                var dentistName= cbDentist.Text;
                //var telephone = ValidatePhoneNumber.TransformPhoneNumber(tbTelephone.Text.Trim());
                var telephone = tbTelephone.Text.Trim();
                var appointmentDate=cbAppointmentDate.Text;
                var appointmentTime=cbAppointmentTime.Text;
                var bookingMadeOn = DateTime.Now;

                if (string.IsNullOrWhiteSpace(patientName) || string.IsNullOrWhiteSpace(dentalProcedure)
                    || string.IsNullOrWhiteSpace(dentistName) || string.IsNullOrWhiteSpace(telephone)
                    || string.IsNullOrWhiteSpace(appointmentDate)
                    || string.IsNullOrWhiteSpace(appointmentTime)
                    )
                {
                    MessageBox.Show($"Please fill all the fields!");
                    return;
                }
                if (!ValidatePhoneNumber.IsValidPhoneNumber(telephone))
                {
                    MessageBox.Show($"Invalid PhoneNumber {telephone}");
                    return;
                }
                if ((Convert.ToDateTime(appointmentDate).Date) < bookingMadeOn.Date)
                {
                    MessageBox.Show($"Invalid Appointment Date\nSelect Another Date");
                }
                //if (Convert.ToDateTime((appointmentDate+appointmentTime))< bookingMadeOn)
                //{
                //    MessageBox.Show($"Invalid Appointment Time");
                //}

                var dentistID = _dentalClinicDbEntities.dentist_Table
                    .Where(d => d.dentistName == dentistName)
                    .Select(d => d.dentistID)
                    .FirstOrDefault();

                var appointmentStatus = "Pending";

                var appointmentIDExists = _dentalClinicDbEntities.appointment_Table.Any(
                   a => a.appointmentID == appointmentID);

                if (appointmentIDExists)
                {
                    MessageBox.Show($"An appointment with ID {appointmentID} Already Exists");

                }

                var newAppointment = new appointment_Table()
                {   
                    appointmentID=appointmentID,
                    dentalProcedure=dentalProcedure,
                    patientName=patientName,
                    appointmentDate=Convert.ToDateTime(appointmentDate).Date,    
                    appointmentTime=appointmentTime,
                    bookingMadeOn=bookingMadeOn,
                    appointmentStatus=appointmentStatus,
                    dentistID=dentistID,
                    patientTel=telephone
                };

                if(newAppointment!=null)
                {
                    _dentalClinicDbEntities.appointment_Table.Add(newAppointment);
                    _dentalClinicDbEntities.SaveChanges();
                    appointmentID = PopulateAppointment();
                    MessageBox.Show($"Appointment Booked Successfully!");
                    
                    var sent = _sendMail.SendEmail("eng.stanleyoduor@gmail.com", false,appointmentTime,dentalProcedure,appointmentDate);
                  
                    if (sent)
                    {
                        MessageBox.Show("Email with appointment details has been sent!");
                    }
                    

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while booking{ex.Message}");

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {

        }

        private void PopulateAppointmentDataGrid()
        {
            var appointments= _dentalClinicDbEntities.appointment_Table.Select(a=> new
            {
                AppointmentID=a.appointmentID,
                DentalProcedure=a.dentalProcedure,
                PatientName=a.patientName,
                AppointmentDate=a.appointmentDate,
                AppointmentTime=a.appointmentTime,
                BookingMadeOn=a.bookingMadeOn,
                AppointmentStatus=a.appointmentStatus,
                DentistID = a.dentistID,
                PatientTelephone =a.patientTel                
            }).ToList();
            dataGridViewAppointments.DataSource = appointments;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new Dashboard(_sendMail).Show();
        }
        private void PopulateDentistComboBox()
        {
            try
            {
                var dentists = _dentalClinicDbEntities.dentist_Table.OrderBy(d=>d.dentistName).ToList();
                cbDentist.DisplayMember = "dentistName";
                cbDentist.ValueMember = "dentistID";
                cbDentist.DataSource = dentists;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PopulateDentalProcedureComboBox()
        {
            try
            {
                var procedures = _dentalClinicDbEntities.dentalProcedure_Table.OrderBy(p=>p.procedureType).ToList();
                cbDentalProcedure.DisplayMember = "procedureType";
                cbDentalProcedure.ValueMember = "procedureID";
                cbDentalProcedure.DataSource = procedures;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public int GenerateAppointmentID()
        {
            try
            { 
            //var fileCount = _dentalClinicDbEntities.patient_Table.ToList().Count; 
            // fileCount = Convert.ToInt32(fileCount)+1;
            // return fileCount;


                var appointmentNo = Convert.ToInt32(_dentalClinicDbEntities.appointment_Table.ToList().Count);
     
                appointmentNo = appointmentNo+1;   
               
                return appointmentNo;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
