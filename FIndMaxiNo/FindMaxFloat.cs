using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMaxiNo
{
    internal class FindMaxFloat
    {
        public static double MaximumFloatNo(double FirstValue, double SecondValue, double ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) >0 && FirstValue.CompareTo(ThirdValue) >0)
            {
                return FirstValue;
            }
            if(SecondValue.CompareTo(ThirdValue) >0 && SecondValue.CompareTo(ThirdValue) >0)
            {
                return SecondValue;
            }
            if(ThirdValue.CompareTo(FirstValue) >0 && ThirdValue.CompareTo(SecondValue) >0)
            {
                return ThirdValue;
            }
            throw new Exception("All Values Are Same");
        }
    }
}
