using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegexLastName
    {
        public static string LastName = "^[A-Z][a-z]{2,}$";
        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, LastName);
        }
    }
}
