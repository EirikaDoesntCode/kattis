using System;

namespace checking
{
    public class Program
    {
        static void Main(string[] args)
        {
            string telephone = Console.ReadLine();
            int telephoneNum = int.Parse(telephone);
            if (telephoneNum >= 5550000 && telephoneNum <= 5559999)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}