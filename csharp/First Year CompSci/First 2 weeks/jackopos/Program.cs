// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace Jackopos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');

            int value = 1;

            for(int i = 0; i < inputArray.Length; ++i)
            {
                value *= int.Parse(inputArray[i]);
            }
            Console.WriteLine(value);
        }
    }
}