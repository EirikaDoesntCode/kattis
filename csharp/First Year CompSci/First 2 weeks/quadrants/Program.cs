// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Quadrants in the form 
//  2 1
//  3 4

using System;

namespace SickQuadsBro
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine(num1);
            int num2 = int.Parse(Console.ReadLine());
            // Console.WriteLine(num2);
            if(num1>0 && num2>0)
            {
                Console.WriteLine("1");
            }
            if(num1>0 && num2<0)
            {
                Console.WriteLine("4");
            }
            if(num1<0 && num2>0)
            {
                Console.WriteLine("2");
            }
            if(num1<0 && num2<0)
            {
                Console.WriteLine("3");
            }            
        }
    }
}