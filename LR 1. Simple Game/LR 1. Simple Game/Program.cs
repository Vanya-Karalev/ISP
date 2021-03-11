using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, count = 0;
            Console.WriteLine("Выберите цвет: ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("1-DarkGreen ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("2-Cyan ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("3-DarkYellow ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("4-DarkGray ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("5-Red ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("6-DarkMagenta ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("7-Blue ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            string A = Console.ReadLine();
            if (!int.TryParse(A, out a)) 
            {
                Console.WriteLine("Введите целое число!");
                return;
            }
            switch (a)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную цифру...");
                    break;
            }
            if (a > 7 || a < 1)
                return;
            Console.Clear();
            Console.WriteLine("               ************************    ");
            Console.WriteLine("               *       ВИСЕЛИЦА!      *    ");
            Console.WriteLine("               ************************    ");
            string[] Renders =
            {
	            #region Frames
	// 0
    @""+'\n'+
	@"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",
	// 1
    @""+'\n'+
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",
	// 2
    @""+'\n'+
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",
	// 3
    @""+'\n'+
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",
	// 4
    @""+'\n'+
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",
	// 5
    @""+'\n'+
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"       \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",
	// 6
    @""+'\n'+
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",
    // 7
    @""+'\n'+
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",
	#endregion
            };
			Console.WriteLine(Renders[0]);
            Random Random = new Random();
            const string words = "D:/C++ C C#/С#/LR 1. Simple Game/words.txt";
            string[] readAllFile = File.ReadAllLines(words);
            string s = readAllFile[Random.Next(readAllFile.Length)];
            Console.Write("\n   Слово: ");
            string[] underlines = new string[s.Length];
            string[] AS = new string[count];
            string[] AS2;
            for (int i = 0; i < s.Length; i++)
                underlines[i] = " _ ";
            for(int i = 0; i< s.Length; i++)
                Console.Write(underlines[i]);           
            char[] arr = s.ToCharArray(0, s.Length);
            int n = 7, t = 7, check = 0;
            for (int k = 0; k < n; k++)
            {
                Console.Write("\n\n   Введите букву: ");
                string UserInput = Console.ReadLine();
                if (UserInput.Length > 1) {
                    Console.WriteLine("   Можно вводить только одну букву...");
                    return;
                }
                if (Regex.IsMatch(UserInput, @"^[а-яё]+$")) { }
                else
                {
                    Console.WriteLine("   Можно вводить только русские буквы...");
                    return;
                }
                Console.Write("\n   Слово: ");              
                char[] c = UserInput.ToCharArray();
                int u = 0;
                for (int i = 0; i < s.Length; i++)
                    if (c[0] == arr[i])
                    {
                        check++;
                        underlines[i] = UserInput;
                        u = 1;
                    }
                Console.Clear();
                Console.WriteLine("               ************************    ");
                Console.WriteLine("               *       ВИСЕЛИЦА!      *    ");
                Console.WriteLine("               ************************    ");   
                if (u == 1)
                    n++;
                else
                    t--;
                if (t >=1 && t<=7)
                    Console.WriteLine(Renders[Math.Abs(t - 7)]);
                else
                    Console.WriteLine(Renders[7]);
                Console.Write("\n   Слово: ");
                for (int i = 0; i < s.Length; i++)
                    Console.Write(underlines[i]);


                Console.Write("\n\n   Вы ввели:");
                if (UserInput != "")
                {
                    count++;
                    AS2 = new string[count];
                    for (int i = 0; i < AS2.Length - 1; i++)
                        AS2[i] = AS[i];
                    AS2[count - 1] = UserInput;
                    AS = AS2;
                }
                for (int i = 0; i < AS.Length; i++)
                    Console.Write(" " + AS[i]);

                /*char[] ar = AS.ToCharArray(0, s.Length);
                for (int i = 0; i < 7 + s.Length; i++)
                    if (AS[i++] == AS[i])
                    {
                        Console.WriteLine("\n\n   Вы уже вводили эту букву...");
                    }*/




                if (check == s.Length)
                {
                    Console.WriteLine("\n\n   Вы выиграли!");
                    break;
                }
                if (t==0)
                    Console.WriteLine("\n\n   Вы проиграли...");    
            }            
            Console.WriteLine("\n   Правильный ответ: " + s);
            Console.ReadKey();
        }
    }
}