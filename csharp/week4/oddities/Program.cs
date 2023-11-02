// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace Oddities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] arrayInputs = new int[lines];
            
            for(int i = 0; i < lines; ++i)
            {
                arrayInputs[i] = int.Parse(Console.ReadLine());
            }
            foreach(int item in arrayInputs)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine($"{item} is even");
                }
                else
                {
                    Console.WriteLine($"{item} is odd");
                }
            }
        }
    }
}