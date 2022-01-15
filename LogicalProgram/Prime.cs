using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Prime
    {
        public static void Main(string[] args)
        {
            int n,i,S=0,num=0;
            Console.WriteLine("Enter a Number");
            n=int.Parse(Console.ReadLine());
            S = n / 2;
            for(i=2;i<=S;i++)
            {
                if(n%i ==0)
                {
                    Console.WriteLine("No is Not Prime");
                    num = 1;
                    break;
                }
            }
            if(num==0)
                Console.WriteLine("No. is Prime");
        }
    }
}
