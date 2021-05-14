using System;
using System.Runtime.InteropServices;
using static DLL.DLL;

namespace lab4.task2
{ 
    static class Program
    {
        static double CheckInt()
        {
            double Value;
            while (!double.TryParse(Console.ReadLine(), out Value))
            {
                Console.Write("Некоректный ввод, повторите попытку: ");
            }
            return Value;
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Первое число: ");
                double FirstValue = CheckInt();
                Console.Write("Второе число: ");
                double SecondValue = CheckInt();

                Console.WriteLine($"{FirstValue} + {SecondValue} = {Add(FirstValue, SecondValue)}");
                Console.WriteLine($"{FirstValue} - {SecondValue} = {Subtract(FirstValue, SecondValue)}");
                Console.WriteLine($"{FirstValue} * {SecondValue} = {Multiply(FirstValue, SecondValue)}");
                Console.WriteLine($"{FirstValue} / {SecondValue} = {Divide(FirstValue, SecondValue)}");
            }
        }
    }
}