// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace R2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int value = int.Parse(nums[0]);
            int mean = int.Parse(nums[1]);

            Console.WriteLine(((2 * mean) - value));
        }
    }
    
}