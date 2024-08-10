// https://open.kattis.com/problems/isithalloween
using System;

namespace IIH
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input == "OCT 31" || input == "DEC 25")
            {
                Console.WriteLine("yup");
            }
            else
            {
                Console.WriteLine("nope");
            }
        }
    }
}