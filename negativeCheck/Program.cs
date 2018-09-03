using System;

namespace negativeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter a number of your choice: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is Positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));

        }
    }
}
