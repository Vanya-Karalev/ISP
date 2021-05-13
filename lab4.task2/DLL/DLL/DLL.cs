using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public static class DLL
    {
        public static double Add(double FirstValue, double SecondValue) 
        {
            return FirstValue + SecondValue;
        }
        public static double Subtract(double FirstValue, double SecondValue)
        {
            return FirstValue - SecondValue;
        }
        public static double Multiply(double FirstValue, double SecondValue)
        {
            return FirstValue * SecondValue;
        }
        public static double Divide(double FirstValue, double SecondValue)
        {
            if (SecondValue == 0)
                return 0;

            return FirstValue / SecondValue;
        }
    }
}
