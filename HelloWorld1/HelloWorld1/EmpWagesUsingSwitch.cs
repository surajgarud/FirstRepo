using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    public class EmpWagesUsingSwitch
    {
        //constant
        public const int IsPresent = 1;
        public const int IsPartTimer = 2;
        public const int EmpRatePrHr = 20;
        public static void UsingSwitch()
        {
            //variables
            int empWages = 0;
            int empHr = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case IsPresent:
                    empHr = 8;
                    break;
                case IsPartTimer:
                    empHr = 4;
                        break;
                default:
                    empHr = 0;
                    break;
            }
            empWages = empHr * EmpRatePrHr;
            Console.WriteLine("EmpWages:" + empWages);
        }
    }
}
