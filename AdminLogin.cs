using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DentalClinicManagementSystemApp.Services;

namespace DentalClinicManagementSystemApp
{
    public partial class AdminLogin : Form
    {
        private readonly DentalClinicDbEntities _dentalClinicDbEntities;
        private readonly ISendMail _sendMail;

        public AdminLogin(ISendMail sendMail)
        {
            InitializeComponent();
            _dentalClinicDbEntities = new DentalClinicDbEntities();
            _sendMail = sendMail;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                var hashedPassword = sBuilder.ToString();
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill all the fields");

                }
                var user = _dentalClinicDbEntities.admin_Table.FirstOrDefault(a => a.username == username && a.password == hashedPassword);

                if (user == null)
                {
                    MessageBox.Show("Please Enter Valid Credentials");
                    return;
                }
                else
                {
                    new Dashboard(_sendMail).Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Something went wrong");
            }

        }

        private void notRegisteredBtn_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }
    }
}
