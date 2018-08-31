using System;

namespace NumberBlanks
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;

            Console.WriteLine("Input a number please: ");
            number1 = Convert.ToInt32(Console.ReadLine());

        
            // Part A: "num num num num" using Write
            Console.Write( number1 );
            Console.Write(" ");

            Console.Write( number1 );
            Console.Write(" ");

            Console.Write( number1 );
            Console.Write(" ");

            Console.Write( number1 );
            Console.WriteLine();

            // Part B: "numnumnumnum" using write
            Console.Write( number1 );
            Console.Write( number1 );
            Console.Write( number1 );
            Console.Write( number1 );
            Console.WriteLine();

            //Part C: "num num num num " using {0}
            Console.WriteLine("{0} {0} {0} {0}", number1);

            //Part D: "numnumnumnum" using {0}
            Console.WriteLine("{0}{0}{0}{0}", number1);

        }
    }
}
