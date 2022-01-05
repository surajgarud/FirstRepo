using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    internal class WagesFor10Days
    {
        //constant
        public const int IsPresent = 1;
        public const int IsPartTimer = 2;
        public const int EmpRatePrHr = 20;
        public const int TotalNoOfDays = 10;
        public static void CalculateWagesFor10Days()
        {
            //variables
            int EmpWage = 0;
            int EmpHr = 0;
            int TotalWages = 0;
            for (int days = 0; days < TotalNoOfDays; days++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IsPresent:
                        EmpHr = 8;
                        break;
                    case IsPartTimer:
                        EmpHr = 4;
                        break;
                    default:
                        EmpHr = 0;
                        break;
                }
                EmpWage = EmpHr * EmpRatePrHr;
                TotalWages = TotalWages + EmpWage;
                 Console.WriteLine("EmpWage:" + EmpWage);
            }
            Console.WriteLine("TotalWages:" + TotalWages);
        }
    }
}