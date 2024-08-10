// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Nsum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            
            string[] numsToSum = new string[length];
            string input = Console.ReadLine();
            numsToSum = (input.Split(' '));
            int sum = 0;
            foreach(string item in numsToSum)
            {
                sum+=int.Parse(item);
            }
            Console.WriteLine(sum);

        }
    }
}