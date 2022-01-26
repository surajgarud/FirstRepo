using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class SampleEmailTest
    {
        public static string regex = "^[a-z]+([@#$.%^-][0-9]{1,})?[0-9]?[@][a-z0-9]{1,}[.][a-z]{3}([.][a-z]{2,})?$";
        public bool RegexPro(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
