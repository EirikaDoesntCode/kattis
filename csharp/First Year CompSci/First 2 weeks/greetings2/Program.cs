// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

namespace GreetingsFellowHumans
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputHey = Console.ReadLine();

            int count = inputHey.Count(x => x == 'e');

            string outputHey = "";
            for(int range = 0; range < count; ++range)
            {
                outputHey += "ee";
            }

            Console.WriteLine($"h{outputHey}y");
        }
    }
}