using DentalClinicManagementSystemApp.Services;
using DentalClinicManagementSystemApp.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagementSystemApp
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            var services = new ServiceCollection();
            //MailSettings _mailSettings = new MailSettings();

            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                //Application.Run(serviceProvider.GetRequiredService<BookAppointment>());
                Application.Run(serviceProvider.GetRequiredService<Splashscreen>());

            }
          
            //ISendMail _sendMail = new SendMail(_mailSettings); 
            //Application.Run(new Splashscreen(_sendMail));
        }
        private static void ConfigureServices(IServiceCollection services)
        {
          
            //services.AddTransient<MailSettings>();
            services.AddSingleton<ISendMail,SendMail>();
            services.AddTransient<BookAppointment>();
            services.AddTransient<Splashscreen>();
            
        }
    }
}
