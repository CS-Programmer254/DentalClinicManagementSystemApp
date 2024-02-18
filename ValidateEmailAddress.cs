using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DentalClinicManagementSystemApp
{
    public static class ValidateEmailAddress
    {
       public static bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }
    }
}
