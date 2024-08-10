// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace ChanukahChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string[] number = new string[lines];
            double[] candles = new double[lines];

            for(int i = 0; i < lines; ++i)
            {
                string temp = Console.ReadLine();
                string[] tempArray = temp.Split(' ');
                number[i] = tempArray[0];
                double tempnum = double.Parse(tempArray[1]);
                
                candles[i] = (tempnum / 2) * (tempnum+3);
            }
            for(int u = 0; u < lines; ++u)
            {
                Console.WriteLine($"{number[u]} {candles[u]}");
            }
        }
    }
}
