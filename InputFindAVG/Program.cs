using System;

namespace InputFindAVG
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            Console.WriteLine("Input the first number to average: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number to average: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the third number to average: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the fourth number to average: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            int result = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("Output: {0} + {1} + {2} + {3} / 4 = {4}", num1, num2, num3, num4, result);

        }
    }
}
