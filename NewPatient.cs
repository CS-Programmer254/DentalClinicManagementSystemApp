using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagementSystemApp
{
    public partial class NewPatientForm : Form
    {
        private readonly DentalClinicDbEntities _dentalClinicDbEntities;
        public int fileCount;
        public NewPatientForm()
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities();
           // LoadFileNoCombox();
        }

        private void SavePatientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var telephone= tbTelephone.Text;
                var fileNo=cbFileNo.Text;
                var patientName=tbPatientName.Text;
                var email=tbEmail.Text;
                telephone=ValidatePhoneNumber.TransformPhoneNumber(tbTelephone.Text.Trim(), telephone); 
                var insurance = cbInsurance.Text;
                var residence = tbResidence.Text;
                var gender = cbGender.Text;

                if (string.IsNullOrWhiteSpace(fileNo) || string.IsNullOrWhiteSpace(patientName)
                    || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telephone)
                    || string.IsNullOrWhiteSpace(insurance)
                    || string.IsNullOrWhiteSpace(residence)
                     || string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show($"Please fill all the fields!");
                    return;
                }

                if(!ValidatePhoneNumber.IsValidPhoneNumber(telephone))
                {
                    MessageBox.Show($"Invalid PhoneNumber {telephone}");
                    return;
                }
                
                if(!ValidateEmailAddress.IsValidEmail(email))
                {
                    MessageBox.Show($"{email.ToUpperInvariant()} is not a valid email address.Please enter a valid email");
                    return;
                }
                
                var insuranceID = _dentalClinicDbEntities.insurance_Table
                    .Where(i => string.Equals(i.insuranceName, insurance, StringComparison.OrdinalIgnoreCase))
                    .Select(i => i.insuranceID)
                    .FirstOrDefault();

                var newPatientData = new patient_Table()
                {
                    patientID = fileNo,
                    patientName = patientName,
                    gender =gender,
                    email = email,
                    patientTel =telephone,
                    registrationDate = DateTime.Now,
                    insuranceID =insuranceID,
                    residence=residence

                };

                _dentalClinicDbEntities.patient_Table.Add(newPatientData);
                _dentalClinicDbEntities.SaveChanges();
                MessageBox.Show("Data saved successfully.");
                MessageBox.Show($"Patient Registered successfully as :{patientName} with file number {fileNo}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void NewPatientForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadInsuranceCombox();
                LoadFileNoCombox();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task LoadInsuranceCombox()
        {
            try
            {
                var insurances = await _dentalClinicDbEntities.insurance_Table.ToListAsync();
                cbInsurance.DisplayMember = "insuranceName";
                cbInsurance.ValueMember = "insuranceID";
                cbInsurance.DataSource = insurances;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public void LoadFileNoCombox()
        {
            try
            {
                ComboxItem comboxItem = new ComboxItem();
                var fileNo = "ACDC " + Convert.ToString(GenerateFileNo());
                comboxItem.Text =fileNo;
                comboxItem.Value =fileNo;
                cbFileNo.Items.Add(comboxItem);
                cbFileNo.SelectedIndex = 0;
                // MessageBox.Show((cbFileNo.SelectedItem as ComboxItem).Value.ToString());

            }
            catch (Exception)
            {

                throw;
            }
        }
        private int GenerateFileNo()
        {
            try
            {
                fileCount = _dentalClinicDbEntities.insurance_Table.ToList().Count; 
                return (fileCount + 1);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
