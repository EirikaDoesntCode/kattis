// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace addingTrouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputStrArray = input.Split(' ');
            int[] inputIntArray = Array.ConvertAll(inputStrArray, int.Parse);

            if (inputIntArray[2] - inputIntArray[1] == inputIntArray[0])
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("wrong!");
            }
        }
    }
}