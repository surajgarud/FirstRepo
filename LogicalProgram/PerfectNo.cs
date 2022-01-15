using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNo
    {
        static void Main(string[] args)
        {
            int number, sum = 0, s;
            Console.WriteLine("Enter A Value");
            number=int.Parse(Console.ReadLine());
            s = number;
            for(int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == s)
            {
                Console.WriteLine("Entered Number Is A PerfectNo");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Entered Number Is Not PerfectNo");
                Console.ReadKey();
            }
        }
    }
}
