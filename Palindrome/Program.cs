using System;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String str, revString = ""; 
            Console.WriteLine("Enter string : ");
            str = Console.ReadLine();
            str = str.ToLower();
            for (int i = 0; i <= (str.Length - 1) / 2; i++)
            {
                if (str[i] != str[(str.Length - 1) - i])
                {
                    if ((str[i + 1] == str[(str.Length - 1) - i]) || (str[i] != str[(str.Length - 1) - i - 1]))
                    {
                       Console.WriteLine("The incorrect letter was : {0}", str[i]);
                        break;
                    }
                      else
                        Console.WriteLine("String cannot be made into a palindrome");
                }
                else
                {
                    Console.WriteLine("Is a palindrome");
                    break;
                }
                    
                


            }

        }
    }

}
 
