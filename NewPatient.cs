using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
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
        private bool isEditMode;
        public string fileToUpdate;
        public NewPatientForm()
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities();
            isEditMode = false; 
        }

        public NewPatientForm(patient_Table patientToEdit)
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities();
            this.Text = "Edit Patient Details";
            this.ClearPatientBtn.Visible= false;
            SavePatientBtn.Text = "Edit";
            fileToUpdate = patientToEdit.patientID.ToString();
            PopulateEditFields(patientToEdit);
            isEditMode = true;
        }

        private void PopulateEditFields(patient_Table patient)
        {
            tbPatientName.Text = patient.patientName;
            tbEmail.Text=patient.email;
            tbTelephone.Text = patient.patientTel;
            tbResidence.Text = patient.residence;
            cbGender.Text = patient.gender;
            var insuranceName= _dentalClinicDbEntities.insurance_Table
                   .Where(i => i.insuranceID==patient.insuranceID)
                   .Select(i => i.insuranceName)
                   .FirstOrDefault();
            cbInsurance.Text = insuranceName;

        }

        private void SavePatientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var fileNo=cbFileNo.Text;
                var patientName=tbPatientName.Text;
                var email=tbEmail.Text;
                var telephone = ValidatePhoneNumber.TransformPhoneNumber(tbTelephone.Text.Trim());
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

                //var insuranceID = _dentalClinicDbEntities.insurance_Table
                //    .Where(i => string.Equals(i.insuranceName, insurance, StringComparison.OrdinalIgnoreCase))
                //    .Select(i => i.insuranceID)
                //    .FirstOrDefault();

                var insuranceID = _dentalClinicDbEntities.insurance_Table
                    .Where(i =>i.insuranceName==insurance)
                    .Select(i => i.insuranceID)
                    .FirstOrDefault();

                var newPatientData = new patient_Table
                {
                    patientID = fileNo,
                    patientName = patientName,
                    gender = gender,
                    email = email,
                    patientTel = telephone,
                    registrationDate = DateTime.Now,
                    insuranceID = insuranceID,
                    residence = residence
                };

                if (newPatientData !=null)
                {
                    _dentalClinicDbEntities.patient_Table.AddOrUpdate(newPatientData);
                    _dentalClinicDbEntities.SaveChanges();
                   
                    if (isEditMode)
                    {
                        MessageBox.Show($"Patient Updated successfully as :{patientName} with file number {fileNo}");
                        this.Close();
                        new Dashboard().Show();
                    }
                    else
                    {
                        MessageBox.Show($"Patient Registered successfully as :{patientName} with file number {fileNo}");
                        this.Close();
                        new Dashboard().Show();
                    }
                }
             
               

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
               
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
                var fileNo = (!isEditMode) ? "ACDC " + Convert.ToString(GenerateFileNo()) :fileToUpdate;
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
               //var fileCount = _dentalClinicDbEntities.patient_Table.ToList().Count; 
               // fileCount = Convert.ToInt32(fileCount)+1;
               // return fileCount;
               
               var fileCount = Convert.ToInt32(_dentalClinicDbEntities.patient_Table.ToList().Count)+1;
                return fileCount;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ClearPatientBtn_Click(object sender, EventArgs e)
        {
            cbFileNo.Text = "";
            tbPatientName.Text ="";
            tbEmail.Text = "";
            tbTelephone.Text ="";
            tbResidence.Text ="";
            cbGender.Text ="";
            cbInsurance.Text = "";

        }
    }
}
