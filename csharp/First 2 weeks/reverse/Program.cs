// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace reverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string output = new(inputArray);
            Console.WriteLine(output);
        }
    }
}