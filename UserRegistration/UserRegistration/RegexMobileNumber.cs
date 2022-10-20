using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegexMobileNumber
    {
        public static string MobileNumber = "^[1-9][0-9][ ][6-9][0-9]{9}$";
        public bool validateString(string Number)
        {
            return Regex.IsMatch(Number, MobileNumber);
        }
    }
}
