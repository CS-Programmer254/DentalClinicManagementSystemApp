using DentalClinicManagementSystemApp.Settings;
using MailKit.Security;
using MimeKit;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicManagementSystemApp.Services
{
    public class SendMail : ISendMail
    {
        //private readonly MailSettings _mailSettings;
        public SendMail()
        {
            
        }
        public bool SendEmail(string toEmail, bool isNotifyEmail,string time,string service,string day)
        {
            try
            {
            
 
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse("stanleigh3oduor@gmail.com");
                email.From.Add(new MailboxAddress("Dental", "stanleigh3oduor@gmail.com"));
                email.To.Add(MailboxAddress.Parse(toEmail));
                email.Subject = "Advance Care Dental Clinic Appointment Booking";
                var builder = new BodyBuilder();
                var message = (!isNotifyEmail) ? $"You are booked for an appointment " +
                    $"for {service} " +
                    $"at{time} " +
                    $"on{day}" +
                    $" at Advance Care Dental Clinic" : $"In Advance Care we value our patients,your concern is our concern!!\n\rThank you for visiting Advance Dental Clinic.";
                builder.HtmlBody = message;
                email.Body = builder.ToMessageBody();
                var smtp = new MailKit.Net.Smtp.SmtpClient();
                smtp.Connect("smtp.gmail.com",587, SecureSocketOptions.StartTls);
                smtp.Authenticate("stanleigh3oduor@gmail.com","ofnh mkca elzz nhcp ");
                smtp.Send(email);
                smtp.Disconnect(true);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
          public bool SendEmailToDoctor (string toEmail,string messageInfo)
        {
            try
            {
            
 
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse("stanleigh3oduor@gmail.com");
                email.From.Add(new MailboxAddress("Advance Care Dental Clinic", "stanleigh3oduor@gmail.com"));
                email.To.Add(MailboxAddress.Parse(toEmail));
                email.Subject = "Doctor Registration Details";
                var builder = new BodyBuilder();
                var message = messageInfo;
                builder.HtmlBody = message;
                email.Body = builder.ToMessageBody();
                var smtp = new MailKit.Net.Smtp.SmtpClient();
                smtp.Connect("smtp.gmail.com",587, SecureSocketOptions.StartTls);
                smtp.Authenticate("stanleigh3oduor@gmail.com","ofnh mkca elzz nhcp ");
                smtp.Send(email);
                smtp.Disconnect(true);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
