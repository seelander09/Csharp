using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercise36 {
  static void Main(string[] args)
        {
            Console.Write("Input a first number: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
        }
}