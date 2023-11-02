using System;

namespace knights
{
    public class Program
    {
        static void Main(string[] args)
        {
            int boardSize = int.Parse(Console.ReadLine());
            if (boardSize % 2 == 0)
                {
                    Console.WriteLine("second");
                }
            else
                {
                    Console.WriteLine("first");
                }
        }
    }
}