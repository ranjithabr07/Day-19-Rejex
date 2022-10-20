using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegexPassWordRule3
    {
        public static string PassWord = "^[A-Z]+[a-zA-Z]{6,16}[0-9]+$";
        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, PassWord);
        }
    }
}
