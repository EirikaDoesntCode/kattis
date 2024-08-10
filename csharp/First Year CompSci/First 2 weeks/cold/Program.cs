// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Cold
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string nums = Console.ReadLine();

            int[] array = nums.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int posCount = 0;
            for (int i = 0; i  < array.Length; i++){
                if (array[i] < 0) {
                    posCount++;
                } 
            }
            Console.WriteLine(posCount);
        }
    }
}
