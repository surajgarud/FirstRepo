using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class ValidMobileNo
    {
        public static string regex = "^[1-9]{2,3}[ ][1-9][0-9]{9}$";
        public bool RegexPro(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
