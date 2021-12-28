using System;
using System.Collections.Generic;
using System.IO;

namespace DoorLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> Employees = new Dictionary<string, bool>();
            Employees.Add("Anny Ivanova", false);
            Employees.Add("Janna Moskova", false);
            Employees.Add("John Smith", false);
            Employees.Add("James Hench", false);
            Console.WriteLine("Enter Your Name : ");
            var curr = Console.ReadLine();
           
            if (Employees.ContainsKey(curr)){
                Console.WriteLine("Enter Login File Location : ");
                string path =Console.ReadLine();

                if (Directory.Exists(path))
                {
                    if (Employees[curr] == false) 
                    { 
                        Employees[curr] = true;
                        Console.WriteLine("Successfully Entered");
                    }
                    else
                    {
                        Employees[curr] = false;
                        Console.WriteLine("Successfully Exited");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Path");
                }
            }
            else
            {
                Console.WriteLine("Employee Does Not Exist");
            }
                

                
            
        }
    }
}
