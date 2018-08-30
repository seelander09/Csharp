using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine(x + y * z);
            Console.WriteLine((35 + 5) % 7 );
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            
            //Swap two numbers
            //You can declare the 3 numbers right away.

            int number1, number2, temp;

            //this tells us to input a number in the console
            //then we set number1 to what is input on the line before then have the console read what is put in.
            Console.WriteLine("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());


            //Set the temp variable to number1.
            //set number1 equal to number2.
            //set number2 equal to temp.

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("\nAfter Swapping : ");
            Console.Write("\nFirst Number : "+number1);
            Console.Write("\nSecond Number : "+number2);
            Console.Read();

        }

    }
}
