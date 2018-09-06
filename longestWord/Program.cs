using System;

namespace longestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Write a C# program to display the following pattern using the alphabet";
            // makes a new array called words. the array is split into 12 strings. each word above is a string in the words array
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
        }
    }
}
