using System;
using System.Threading;

namespace LR_2._Dates
{
    class Program
    {
        static void PrintTime(object state)
        {
            Console.Clear();
            DateTime now = DateTime.Now;
            Console.WriteLine("\nNow: " + DateTime.Now);
            Console.Write("\nNow: " + now.ToString("dd.MM.yyyy "));
            Console.WriteLine(now.ToString("hh:mm:ss"));
            Console.WriteLine("\nPress [Enter] to exit... ");
        }
        static void Main(string[] args)
        {
            TimerCallback timeCB = new TimerCallback(PrintTime);
            Timer time = new Timer(timeCB, null, 0, 1000);
            Console.ReadLine();
        }
    }
}