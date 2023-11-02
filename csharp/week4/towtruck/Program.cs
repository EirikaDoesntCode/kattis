// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace towtruck
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            int[] arrayInput1 = Array.ConvertAll(input1.Split(' '), int.Parse);
            double totalHold = (arrayInput1[0]-arrayInput1[1])*0.9;
            string input2 = Console.ReadLine();
            int[] arrayInput2 = Array.ConvertAll(input2.Split(' '), int.Parse);

            foreach(int item in arrayInput2)
            {
                totalHold-=item;
            }
            Console.WriteLine(totalHold);
        }
    }
}