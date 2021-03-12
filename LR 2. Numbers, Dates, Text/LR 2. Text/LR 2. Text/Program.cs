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
            if (Regex.IsMatch(text, @"^[a-zA-ZА-ЯЁа-яё ]+$")) { } //Строка для поиска совпадения.
            else 
            {
                Console.WriteLine("Invalid input...");
                return;
            }
            string[] words = text.Split(' '); //Разбивает строку на подстроки на основе предоставленного разделителя строк.
            Array.Reverse(words); //Изменяет последовательность элементов во всем одномерном массиве .
            Console.Write("\nOutput: ");
            foreach (string st in words) //Цикл foreach позволяет проходить по каждому элементу коллекции
            {
                Console.Write(st + " ");
            }
        }
    }
}