//Задание №2
using System;
using System.Text.RegularExpressions;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            if (Regex.IsMatch(text, @"^[a-zA-ZА-ЯЁа-яё ]+$")) { }
            else 
            {
                Console.WriteLine("Invalid input...");
                return;
            }
            string[] words = text.Split(' ');
            Array.Reverse(words);
            Console.Write("\nOutput: ");
            foreach (string st in words) 
            {
                Console.Write(st + " ");
            }
        }
    }
}
