using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    class Password
    {
        //[1-9][0-9]{2}[ ]?[0-9]{3}$";
        public static string regex = "^[A-Z][a-z]{7,}[@#$]{1}[0-9]{2,}$";
        public bool RegexPro(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
