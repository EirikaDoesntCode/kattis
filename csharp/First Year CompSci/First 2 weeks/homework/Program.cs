// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Take a string in style of "1-3;5;7;9;10-15" and count how many unique numbers are included in it, with "10-15" meaning "10 11 12 13 14 15"

using System;

namespace Homeworkkattis
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] inputArray = input.Split(';');

            int value = 0;

            for(int i = 0; i < inputArray.Length; i++)
            {
                if(inputArray[i].Contains('-'))
                {
                    // int[] myInts = Array.ConvertAll(arr, int.Parse);
                    string[] funkyNumbersStr = inputArray[i].Split('-');
                    // for(int n = 0; n < funkyNumbersStr.Length; n++)
                    // {
                    //     Console.WriteLine(funkyNumbersStr[n]);
                    // }
                    // int[] funkyNumbersInt = int.Parse(funkyNumbersStr[1]);
                    int[] funkyNumbersInt = Array.ConvertAll(funkyNumbersStr, int.Parse);
                    value += (funkyNumbersInt[1]-funkyNumbersInt[0]+1);
                }
                else
                {
                    value++;
                }
            }

            Console.WriteLine(value);
        }
    }
}