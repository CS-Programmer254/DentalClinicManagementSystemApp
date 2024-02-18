using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DentalClinicManagementSystemApp
{
    public static class ValidatePhoneNumber
    {
        // Regular expression used to validate a phone number.
        public const string PhoneRegexNumber = @"^\+254\d{9}$";
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber != null) return Regex.IsMatch(phoneNumber,PhoneRegexNumber);
            else return false;
        }
        public static string TransformPhoneNumber(string trimmedTelephone,string tbTelephoneText)
        {
            string telephone;
            if (trimmedTelephone.Length == 10)
            {
                string pattern = @"^0(7|1)";
                if (Regex.IsMatch(trimmedTelephone, pattern))
                {
                    // Remove the leading "0"
                    trimmedTelephone = Regex.Replace(trimmedTelephone, pattern, match =>
                    {
                        if (match.Value == "01")
                        {
                            return "1";
                        }
                        else if (match.Value == "07")
                        {
                            return "7";
                        }
                        else
                        {
                            return match.Value;
                        }
                    });
                }
                telephone = "+254" + trimmedTelephone;
                return telephone;
            }
            else
            {
                telephone = (tbTelephoneText.StartsWith("+254")) ? tbTelephoneText : "+254" + tbTelephoneText;
                return telephone;
            }


        }
    }
}
