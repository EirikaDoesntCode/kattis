// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace RemovoString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = input.Substring(input.IndexOf('a'));
            Console.WriteLine(output);
        }
    }
}