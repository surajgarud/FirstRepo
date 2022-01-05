using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    public class ComputeEmpWagesUsingClassMethod
    {
        //constant
        public const int IsPresent = 1;
        public const int IsPartTimer = 2;
        public const int EmpRatePrHr = 40;
        public const int NoOfWorkingDays = 20;
        public const int NoOfWorkingHrs = 160;
        public static int ComputeWages()
        {
            //variables
            int EmpHr = 0;
            int TotalEmpHrs = 0;
            int TotalEmpWages = 0;
            int TotalNoOfDays = 0;
            int TotalWorkingHrs = 0;
            while (TotalNoOfDays < NoOfWorkingDays && TotalWorkingHrs <= NoOfWorkingHrs)
            {
                TotalNoOfDays++;
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
                TotalEmpHrs = TotalEmpHrs + EmpHr;
                Console.WriteLine("Days :" + TotalNoOfDays + "EmpHr :" + EmpHr);
            }
            TotalEmpWages = TotalEmpHrs * EmpRatePrHr;
            Console.WriteLine("TotalEmpWage :" + TotalEmpWages);
            return TotalEmpWages;
        }
            // public static void Main(string[] args)
            //{
            //  ComputeWages();
            //}
    }
}
