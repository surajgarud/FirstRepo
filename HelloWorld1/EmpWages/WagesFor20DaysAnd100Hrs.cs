using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    public class WagesFor20DaysAnd100Hrs
    {
        //constant
        public const int IsPresent = 1;
        public const int IsPartTimer = 2;
        public const int EmpRatePrHr = 30;
        public const int NoOfWorkingDays = 5;
        public const int NoOfWorkingHrs = 40;
        public static void Wagesfor20d()
        {
            //variables
            int TotalEmpWage = 0;
            int empHr = 0;
            int TotalEmpHr = 0;
            int TotalWorkingDays = 0;
            while (TotalEmpHr <= NoOfWorkingHrs && TotalWorkingDays < NoOfWorkingDays)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
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
                    TotalEmpHr = TotalEmpHr + empHr;
                Console.WriteLine("Days#: " + TotalWorkingDays + " EmpHr: " + empHr);
            }
            TotalEmpWage = TotalEmpHr * EmpRatePrHr;
            Console.WriteLine("TotalEmpWage :" + TotalEmpWage);
        }
    }
}
