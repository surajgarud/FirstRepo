using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograme
{
    internal class SwapNo
    {
        public static void SwapTwoNo()
        {
            int FirstNum = 5;
            int SecondNum = 10;
            Console.WriteLine("Before swap FirstNumber = " + FirstNum + " SecondNumber = " + SecondNum);
            FirstNum = FirstNum * SecondNum;
            SecondNum = FirstNum / SecondNum;
            FirstNum = FirstNum / SecondNum;
            Console.Write("After swap FirstNumber = " + FirstNum + " SecondNumber = " + SecondNum);
        }
    }
}
