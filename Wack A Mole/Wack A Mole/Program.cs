
using System;

namespace Whac_A_Mole
{
    internal class Program
{
    static void Main(string[] args)
    {
        string table =                                      
 @" |===|=========|===|=======|=|===|=======|" + '\n' + 
 @" | 7 |       | | 8 |       | | 9 |       |" + '\n' + 
 @" |===|       | |===|       | |===|       |" + '\n' +
 @"     |       |     |       |     |       |" + '\n' +
 @"     |       |     |       |     |       |" + '\n' +
 @"     =====================================" + '\n' +
 @" |===|=========|===|=======|=|===|=======|" + '\n' +     
 @" | 4 |       | | 5 |       | | 6 |       |" + '\n' +     
 @" |===|       | |===|       | |===|       |" + '\n' +    
 @"     |       |     |       |     |       |" + '\n' +     
 @"     |       |     |       |     |       |" + '\n' +
 @"     =====================================" + '\n' +
 @" |===|=========|===|=======|=|===|=======|" + '\n' +
 @" | 1 |       | | 2 |       | | 3 |       |" + '\n' +
 @" |===|       | |===|       | |===|       |" + '\n' +
 @"     |       |     |       |     |       |" + '\n' +
 @"     |       |     |       |     |       |" + '\n' +
 @"     =====================================";


        string avatar =                   
            @" //-\\ " + '\n' +
            @"|^  ^| " + '\n' +       
            @"|O  O| " + '\n' +
            @"\  O / ";

        string Empty =
            @"       " + '\n' +
            @"       " + '\n' +      
            @"       " + '\n' +
            @"       ";


        TimeSpan playTime = TimeSpan.FromSeconds(30);   


            while (true)  
        {
            Console.Clear(); //Чисти конзолата
            Console.WriteLine("Whac-A-Mole by Kris"); 
            Console.WriteLine(); 
            Console.WriteLine(
                $"You have {(int)playTime.TotalSeconds} seconds to whack as many Moles as you " +    
                "can before the timer runs out. Use the number keys 1-9 to whack. Are you ready? ");  
                Console.WriteLine(); 
            Console.WriteLine("Play [enter], or quit [escape]?");
        GetInput:
            switch (Console.ReadKey(true).Key) 
                {                              
                case ConsoleKey.Enter:         
                    Play();                    
                    break;
                case ConsoleKey.Escape: 
                    Console.Clear();
                    Console.WriteLine("Whac-A-Mole was closed...");
                    Environment.Exit(0); 
                    break;
                default: goto GetInput; 
            }
        }

        void Play() 
            {
            Console.Clear();
            Console.WriteLine("Whac-A-Mole by Kris");
            Console.WriteLine();
            Console.WriteLine(table); 
            DateTime start = DateTime.Now; 
            int score = 0; 
            Random random = new(); 
            int moleLocation = random.Next(1, 10); 
                Console.CursorVisible = false;   
            while (DateTime.Now - start < playTime) 
            {
                var (left, top) = Map(moleLocation);
                Console.SetCursorPosition(left, top);
                Render(avatar); 
                int selection;
            GetInput:
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1: case ConsoleKey.NumPad1: selection = 1; break;
                    case ConsoleKey.D2: case ConsoleKey.NumPad2: selection = 2; break;
                    case ConsoleKey.D3: case ConsoleKey.NumPad3: selection = 3; break;
                    case ConsoleKey.D4: case ConsoleKey.NumPad4: selection = 4; break;
                    case ConsoleKey.D5: case ConsoleKey.NumPad5: selection = 5; break;  
                    case ConsoleKey.D6: case ConsoleKey.NumPad6: selection = 6; break;
                    case ConsoleKey.D7: case ConsoleKey.NumPad7: selection = 7; break;
                    case ConsoleKey.D8: case ConsoleKey.NumPad8: selection = 8; break;
                    case ConsoleKey.D9: case ConsoleKey.NumPad9: selection = 9; break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Whac-A-Mole was closed...");
                        Environment.Exit(0);
                        return;
                    default: goto GetInput;
                }
                if (moleLocation == selection) 
                {
                    score++; 
                    Console.SetCursorPosition(left, top);
                    Render(Empty); 
                    moleLocation = random.Next(1, 10); 
                }
            }
            Console.CursorVisible = true; 
            Console.Clear();
            Console.WriteLine("Whac-A-Mole By Kris");
            Console.WriteLine();
            Console.WriteLine(table);
            Console.WriteLine();
            Console.WriteLine("Your Score is: " + score);
            Console.WriteLine("Hopefully those Moles will learn their lesson and stop invading the land.");
            Console.WriteLine();
            Console.WriteLine("Press [Enter] To Continue...");
            Console.ReadLine();
        }

        (int Left, int Top) Map(int hole) =>
            hole switch
            {
                1 => (06, 15),
                2 => (20, 15),
                3 => (34, 15),
                4 => (06, 9),                                    
                5 => (20, 9),                       
                7 => (06, 03),
                8 => (20, 03),
                9 => (34, 03),
                _ => throw new NotImplementedException(), 
            };

        void Render(string @string)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            foreach (char d in @string)
            {
                if (d is '\n')
                {
                    Console.SetCursorPosition(x, ++y);
                }
                else
                {
                    Console.Write(d);
                }
            }
        }

    }
}
}
