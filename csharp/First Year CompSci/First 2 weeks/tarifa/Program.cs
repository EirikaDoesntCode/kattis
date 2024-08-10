// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Tarifa
{
    public class Program
    {
        static void Main(string[] args)
        {
            int inputMax = int.Parse(Console.ReadLine());
            int inputMonths = int.Parse(Console.ReadLine());
            int value = inputMax * (inputMonths+1);

            for(int i = 0; i < inputMonths; ++i)
            {
                value-=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(value);
        }
    }
}