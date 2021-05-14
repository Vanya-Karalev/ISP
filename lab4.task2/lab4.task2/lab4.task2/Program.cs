using System;
using System.Runtime.InteropServices;
using static DLL.DLL;

namespace lab4.task2
{ 
    static class Program
    {
        static int CheckInt()
        {
            int Value;
            while (!int.TryParse(Console.ReadLine(), out Value))
            {
                Console.Write("Некоректный ввод, повторите попытку: ");
            }
            return Value;
        }
        unsafe public static void Main(string[] args)
        {

            // ввод чисел
            int[] nums = new int[20];
            Random rands = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rands.Next() % 100;
            }
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i]);
            // сортировка
            Console.WriteLine("Хотите ли вы отсортировать массив ? \n1-да \nлюбое другое число-нет");
            int FirstValue = CheckInt();
            if (FirstValue == 1)
            {
                fixed (int* p = nums)
                {
                    Sort(p, nums.Length);
                }
                Console.WriteLine("Вывод отсортированного массива");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"{nums[i]} ");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Вы вышли из программы");
                Environment.Exit(0);
            }
        }
    }
}