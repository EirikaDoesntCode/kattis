// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace betting
{
    public class Program
    {
        static void Main(string[] args)
        {
            float input = float.Parse(Console.ReadLine());
            Console.WriteLine((1 / (input/100)));
            Console.WriteLine((1 / ((100-input)/100)));
        }
    }
}