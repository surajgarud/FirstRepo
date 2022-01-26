using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    class RegexPracticePro
    {      
        public static string regex = "^[A-Z]{1}[a-z]{2,}[ ]+[A-z]{1}?[a-z]{2,}$";
        public bool RegexPro(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
