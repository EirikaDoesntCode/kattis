// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Trik
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] instructions = input.ToCharArray();
            string position = "1";
            foreach(char item in instructions)
            {
                // Console.WriteLine($"{item}");
                char temp = item;
                bool check = true;
                
                if(position == "1" && check == true)
                {

                    if(temp == 'A' && check == true)
                    {
                        position = "2";
                        check = false;
                    }
                    if(temp == 'C' && check == true)
                    {
                        position = "3";
                        check = false;
                    }
                }
                if(position == "2" && check == true)
                {

                    if(temp == 'A' && check == true)
                    {
                        position = "1";
                        check = false;
                    }
                    if(temp == 'B' && check == true)
                    {
                        position = "3";
                        check = false;
                    }
                }                
                if(position == "3" && check == true)
                {

                    if(temp == 'B' && check == true)
                    {
                        position = "2";
                        check = false;
                    }
                    if(temp == 'C' && check == true)
                    {
                        position = "1";
                        check = false;
                    }

                }
                // Console.WriteLine($"{position} testing");
                
            }
            Console.WriteLine(position);
        }
    }
}