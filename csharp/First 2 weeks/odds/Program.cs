// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace odds
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if(num%2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }
        }
    }
}