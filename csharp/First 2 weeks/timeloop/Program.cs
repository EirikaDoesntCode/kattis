// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace timeloop
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1} Abracadabra");
            }
        }
    }
}