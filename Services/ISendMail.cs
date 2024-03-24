using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicManagementSystemApp.Services
{
    public interface ISendMail
    {
        bool SendEmail(string toEmail, bool isNotifyEmail, string time, string service, string day);
        bool SendEmailToDoctor(string toEmail, string messageInfo);
    }
}
