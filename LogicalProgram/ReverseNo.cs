using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNo
    {
        public static void Main(string[] args)
        {
              int n, reverse = 0, rem;
              Console.WriteLine("Enter A Number");
              n=int.Parse(Console.ReadLine());
              while(n!=0)
            {
               rem=n%10;
               reverse=reverse*10+rem;
               n/=10;
            }
              Console.WriteLine("Reverse Number:" + reverse);
        }
    }
}
