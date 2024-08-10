// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace graaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaass
{
    public class Program
    {
        static void Main(string[] args)
        {
            double cost = double.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            double gary = 0;

            for(int i = 0; i < lines; i++)
            {
                string nums = Console.ReadLine();
                string[] areaArray = nums.Split(' ');
                double[] areaArrayDoub = Array.ConvertAll(areaArray, double.Parse);

                gary+= (areaArrayDoub[0]*areaArrayDoub[1]);
            }
            Console.WriteLine(gary*cost);
        }
    }
}
