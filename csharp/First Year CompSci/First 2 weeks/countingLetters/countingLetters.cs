using System;
using System.Linq;

namespace CountingLs
{
    public class Program
    {
        static void Main(string[] args)
        {
            string uInput = Console.ReadLine();
            int uncertainty = uInput.Count(x => x == 'u'); //number of u's in uInput  
            Console.WriteLine(uncertainty);
        }
    }
}