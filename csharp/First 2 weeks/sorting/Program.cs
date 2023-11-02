// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] split = input.Split(' ');
            int x = int.Parse(split[0]);
            int y = int.Parse(split[1]);
            if(x < y)
            {
                Console.WriteLine($"{x} {y}");
            }
            else
            {
                Console.WriteLine($"{y} {x}");
            }
        }
    }
}