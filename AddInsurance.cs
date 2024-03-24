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
    public partial class AddInsurance : Form
    {
        private readonly DentalClinicDbEntities _dentalClinicDbEntities;
        public AddInsurance()
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                var insuranceName = tbInsuranceName.Text;
                if (string.IsNullOrWhiteSpace(insuranceName))
                {
                    MessageBox.Show($"Please fill all the fields!");
                    return;
                }
                
                var insurance = new insurance_Table
                {
                    insuranceName = insuranceName
                };


               
                    _dentalClinicDbEntities.insurance_Table.Add(insurance);
                    _dentalClinicDbEntities.SaveChanges();
                    MessageBox.Show($"Insurance Saved Successfully");

                



            }
            catch (Exception)
            {

                
            }


        }
    }
}
