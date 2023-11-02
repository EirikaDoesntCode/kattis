// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace summing
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(" ");
            int[] inputArrayInt = Array.ConvertAll(inputArray, int.Parse);
            int value = inputArrayInt.Sum();
            Console.WriteLine(value);
        }
    }
}