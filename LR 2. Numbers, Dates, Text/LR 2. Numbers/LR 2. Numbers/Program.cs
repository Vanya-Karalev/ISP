using System;

namespace Numbers
{
    class Program
    {
        static int GetAllDva(int x)
        {
            if (x > 1)
                return x / 2 + GetAllDva(x / 2);
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter integer a: ");
            string A = Console.ReadLine();
            if (!int.TryParse(A, out a))
            {
                Console.WriteLine("Invalid input!");
            }
            Console.Write("Enter integer b: ");
            string B = Console.ReadLine();
            if (!int.TryParse(B, out b)) 
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Console.WriteLine("Output: " + (GetAllDva(b) - GetAllDva(a-1)));
        }
    }
}
