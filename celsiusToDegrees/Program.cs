﻿using System;

namespace celsiusToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);

        }
    }
}
