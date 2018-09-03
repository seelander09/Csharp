using System;

namespace addToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str; 
            // int l= 0;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            
            if (str.Length >= 1)
           {
            var first = str.Substring(0,1);
            Console.WriteLine(first + str + first);
           }
            }
        }
}
