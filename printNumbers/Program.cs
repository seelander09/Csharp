using System;

namespace printNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers 1 to 99. Print one per line");

            for (int n = 1; n < 99; n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
        }
    }
}
