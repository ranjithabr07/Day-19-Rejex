using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegexEmail
    {
        public static string Email = "^[a-zA-Z]+([@#%$&+.-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, Email);
        }
    }
}
