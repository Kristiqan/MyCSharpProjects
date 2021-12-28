using System;

namespace ReverseStringProgram
{
    // Task 1 This is a program that reverses a String.

     class ReverseString
    {
        static void Main(string[] args)
        {
            String str, RevString = "";
            Console.WriteLine("Enter string : ");
            str = Console.ReadLine();
            str = str.ToLower();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                RevString = RevString + str[i];
            }
            Console.WriteLine("Reverse String is: {0}", RevString);
        }
    }
}
