// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace bijele
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputAsArray = input.Split(' ');
            int[] piecesArray = Array.ConvertAll(inputAsArray, int.Parse);
            int[] requiredPieces = {1, 1, 2, 2, 2, 8};
            for(int index = 0; index < piecesArray.Length; ++index)
            {
                piecesArray[index] = requiredPieces[index] - piecesArray[index];
            }
            foreach(var item in piecesArray)
            {
                Console.Write($"{item} ");
            }
        //     for(int index = 0; index < (piecesArray.Length -1); ++index)
        //     {
        //          Console.Write($"{piecesArray[index]} ");                
        //     }
        //     Console.WriteLine(piecesArray[piecesArray.Length -1]);
        }
    }
}