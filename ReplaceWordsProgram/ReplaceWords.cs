using System;

namespace ReplaceWordsProgram
{
    // Task 2 This Program Replaces Words

    class ReplaceWords
    {
        static void Main(string[] args)
        {
            
            string[] banned;
            Console.WriteLine("Write Banned Words : ");
            banned = Console.ReadLine().ToLower().Split(' ');
            string[] input;
            Console.WriteLine("Input Text : ");
            input = Console.ReadLine().ToLower().Split(' ');
            for(int i =0; i<input.Length; i++)
            {
               for(int j=0; j<banned.Length; j++)
                {
                    if(input[i] == banned[j])
                    {
                        input[i] = new string('*', input[i].Length-1);
                    }
                }
            }
            foreach(var word in input)
            {
                Console.Write(word);
                Console.Write(" ");

            }


        }
    }
}
