using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    class EmployeeAttendance1
    {
        public static void GetAttendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
                Console.ReadKey();
        }
        public static void Attendance()
        {
            int IsFullTime = 1;
            int IsPartTimer = 2;
            int EmpRatePrHr = 30;
            //variables
            int EmpWages = 0;
            int EmpHr = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == IsFullTime)
                EmpHr = 8;
            else if (empcheck == IsPartTimer)
                EmpHr = 4;
            else
                EmpHr = 0;
            EmpWages = EmpHr * EmpRatePrHr;
            Console.WriteLine("EmpWages:" + EmpWages);
            Console.ReadKey();
        }
    }
}
