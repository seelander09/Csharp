using System;
using System.Collections.Generic; // added for lists

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // getArray();
            // printOdd();
            // itterateArray();
            // FindMax();
            // GetAverage();
            // ArrayOddNumbers();
            // greaterThanY();
            EliminateNegitiveNums();
            // JosiahsFUNfunction();
        }

        //#1
        //static void getArray()
        // {
        //     for (var i = 1; i< 256; i++)
        //     {
        //System.Console.WriteLine("We {0} are being cool: {0} {1} -->>>>> {0}", i, "This is second so its");
        //     }
        // }

        //#2
        static void printOdd()
        {

            for (var i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                    System.Console.WriteLine(i);
            }
        }


        //#3
        static void itterateArray()
        {

            int[] newArr = new int[7] { -43, 2, 66, 55, -5, 0, 9 };
            foreach (var items in newArr)
            {
                System.Console.WriteLine(items);

                // int sum += item
                // System.Console.WriteLine("This might be the SUM --> {0} <--", sum);
            }

        }
        //#4
        static void FindMax()
        {
            int[] newArr2 = { -43, 2, 66, 55, -5, 0, 9 };
            int max = newArr2[0];
            for (int i = 0; i < newArr2.Length; i++)
            {
                //declare max

                if (newArr2[i] > max)
                {

                    max = newArr2[i];
                }

            }
            System.Console.WriteLine("Max is: {0} ", max);
        }
        //#5
        static void GetAverage()
        {
            int[] newArr3 = new int[5] { 1, 3, 5, 7, 20 };
            int sum = 0;
            for (var i = 0; i < newArr3.Length; i++)
            {
                sum += newArr3[i];
            }
            int average = sum / newArr3.Length;
            System.Console.WriteLine("Wizard shit dawg------->>>>>>> {0}", average);

        }

        // static void JosiahsFUNfunction()
        // //given an array square the values
        // {
        //     static List<int> funSquaredList = new List
        //     funSquaredList.Add
        // }
        //#6
        static void ArrayOddNumbers()
        {
            int[] newArray6 = new int[255];
            for (var i = 0; i < newArray6.Length; i++)
            {
                if (i % 2 == 1)
                {
                    newArray6[i] = i;
                    System.Console.WriteLine("This is the array value ----> {0}", newArray6[i]);
                }
            }
        }
        // #7
        static void greaterThanY()
        {
            List<int> greaterThanY = new List<int>();
            greaterThanY.Add(1);
            greaterThanY.Add(2);
            greaterThanY.Add(3);
            greaterThanY.Add(5);
            greaterThanY.Add(7);

            foreach (var item in greaterThanY)
            {
                System.Console.WriteLine(item);
                if (item >= 3)
                {
                    System.Console.WriteLine(item);
                }
            }

        }
        //#8
        static void EliminateNegitiveNums()
        {
            List<int> newArr8 = new List<int>();
            newArr8.Add(1);
            newArr8.Add(5);
            newArr8.Add(10);
            newArr8.Add(-2);
            newArr8.Add(-7);
            newArr8.Add(-10);

            foreach (var items in newArr8)
            {
                System.Console.WriteLine(items);
                if (items < 0)
                {
                    newArr8.RemoveAt(3);
                    System.Console.WriteLine(newArr8[3]);
                }
            // }
            // foreach (var negs in newArr8)
            // {
            //     System.Console.WriteLine(negs);
            // }
        }





    }


}
