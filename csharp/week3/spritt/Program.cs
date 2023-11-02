// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Spritt
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tempString = input.Split(' ');
            int[] importantValues = Array.ConvertAll(tempString, int.Parse);
            int value = 0;
            for(int i = 0; i < importantValues[0]; ++i)
            {
                int temp = int.Parse(Console.ReadLine());
                value+= temp;
            }
            if(value<=importantValues[1])
            {
                Console.WriteLine("Jebb");
            }
            else
            {
                Console.WriteLine("Neibb");
            }

        }
    }
}