using System;

namespace FindAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("input your age please: ");
            age = Convert.ToInt32(Console.ReadLine());

            int result = age;
            Console.WriteLine("Are you sure ?? you look way older than {0} to me", result);
        }
    }
}
