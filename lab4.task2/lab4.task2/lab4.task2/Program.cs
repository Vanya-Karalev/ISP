using System.Runtime.InteropServices;
using System;

namespace lab4.task2
{ 
    class Program
    {
        /*[DllImport("DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Add(double FirstValue, double SecondValue);
        [DllImport("DLL.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double Subtract(double FirstValue, double SecondValue);
        [DllImport("DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Multiply(double FirstValue, double SecondValue);
        [DllImport("DLL.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern double Divide(double FirstValue, double SecondValue);*/
        public static void Main(string[] args)
        {
            Console.WriteLine("a(25) + b(34) is: " + DLL.DLL.Add(25, 34));
            Console.WriteLine("a(25) - b(34) is: " + DLL.DLL.Subtract(25, 34));
            Console.WriteLine("a(25) * b(34) is: " + DLL.DLL.Multiply(25, 34));
            Console.WriteLine("a(25) / b(34) is: " + DLL.DLL.Divide(25, 34));
            Console.ReadKey();
        }
    }
}