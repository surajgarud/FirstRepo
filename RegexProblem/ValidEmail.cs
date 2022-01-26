using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class ValidEmail
    {
        //[A-Za-z0-9]+[.#_][A-Za-z0-9]+[@][A-Za-z]+[.][a-z]{2,3}([.][a-z]{2})?$";
            public static string regex = "^[a-z]+([.][a-z]{2,})?[@][a-z]+[.][a-z]{2,3}([.][a-z]{2})?$";
            public bool RegexPro(string sample)
            {
                return Regex.IsMatch(sample, regex);
            }
    }
}
