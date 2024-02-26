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
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           countLabel.Text=(int.Parse(countLabel.Text)+1).ToString();
            if (countLabel.Text=="100")
            {
                this.Hide();
                new AdminLogin().Show();
               
            }
        }

        
    }
}
