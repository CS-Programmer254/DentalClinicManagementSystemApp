using DentalClinicManagementSystemApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagementSystemApp
{
    public partial class NewDentist : Form
    {
        private readonly DentalClinicDbEntities _dentalClinicDbEntities;
        private readonly ISendMail _sendMail;
        public NewDentist(ISendMail sendMail)
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities(); 
            _sendMail = sendMail;
        }

        private void SaveDoctorBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var fileNo = cbDentistNo.Text;
                var dentistName = tbDentistName.Text;
                var email = tbEmail.Text;
                //var telephone = ValidatePhoneNumber.TransformPhoneNumber(tbTelephone.Text.Trim());
                var telephone =tbTelephone.Text.Trim();
                
                if (string.IsNullOrWhiteSpace(fileNo) || string.IsNullOrWhiteSpace(dentistName)
                    || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telephone))
                {
                    MessageBox.Show($"Please fill all the fields!");
                    return;
                }

                if (!ValidatePhoneNumber.IsValidPhoneNumber(telephone))
                {
                    MessageBox.Show($"Invalid PhoneNumber {telephone}");
                    return;
                }

                if (!ValidateEmailAddress.IsValidEmail(email))
                {
                    MessageBox.Show($"{email.ToUpperInvariant()} is not a valid email address.Please enter a valid email");
                    return;
                }
                var password = "xxxxxxxx";

                var newDentistData = new dentist_Table
                {
                    dentistID = fileNo,
                    dentistName =dentistName,
                    dentistEmail= email,
                    dentistTel = telephone,
                    password=password,
                    registrationDate = DateTime.Now
                };

                if(newDentistData != null)
                {

                    _dentalClinicDbEntities.dentist_Table.Add(newDentistData);
                    _dentalClinicDbEntities.SaveChanges();
                    MessageBox.Show("Dentist Registered Successfully");
                    _sendMail.SendEmailToDoctor(email,$"Dear {dentistName} You have been successfully registered as a doctor in Advance Care\n" +
                        $".Your login password is {password}" +
                        ".Access the system to reset it");

                }
            }
            catch (Exception)
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            new Dashboard(_sendMail).Show();

        }

        private void ClearDoctorBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
