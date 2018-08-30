using System;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to print the output of multiplication
            // of three numbers which will be entered by the user

            int number1, number2, number3;

            Console.Write("\nInput first number to multiply : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("\nInput second number to multiply : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("\nInput third number to multiply : ");
            number3 = int.Parse(Console.ReadLine());

            int result = number1 * number2 * number3;
            Console.WriteLine("Output: {0} * {1} * {2} = {3}", number1, number2, number3, result);

        }
    }
}
