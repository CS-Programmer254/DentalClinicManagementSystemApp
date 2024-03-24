using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagementSystemApp
{
    public partial class Register : Form
    {
        private readonly DentalClinicDbEntities _dentalClinicDbEntities;
        public Register()
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            var Username = tbUserName.Text;
            var Password = tbPassword.Text;
            var Email = tbEmail.Text;
            var Telephone = "0769860886";
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password)
                 || string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Please fill all the fields!");
                return;
            }

            var userExists = _dentalClinicDbEntities.admin_Table.Any(
               a => a.username == Username && a.email == Email && a.password == Password);

            if (userExists)
            {
                MessageBox.Show("Username or Email Already Exists");

            }

           
            var username = tbUserName.Text;
            var password = HashedPassword.HashPassword(tbPassword.Text);
            var email = tbEmail.Text;
            var telephone = "0769860886";
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)
                 || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show($"Please fill all the fields!");
                return;
            }

            var UserExists = _dentalClinicDbEntities.admin_Table.Any(
               a => a.username == username && a.email == email && a.password == password);
        

            if (userExists)
            {
                MessageBox.Show("Username or Email Already Exists");

            }

            var newUser = new admin_Table()
            {
                username = username,
                email = email,
                password = password,
                adminTel = telephone
            };
            if (newUser != null)
                {
                    _dentalClinicDbEntities.admin_Table.Add(newUser);
                    _dentalClinicDbEntities.SaveChanges();
                    MessageBox.Show("User Registered Successfully");

                }
        }
           
    }
}
