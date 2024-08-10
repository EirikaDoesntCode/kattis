using System;
using System.Linq;

namespace Capitals
{
    public class Program
    {
        static void Main(string[] args)
        {
           string authors = Console.ReadLine();
           string output = string.Concat(authors.Where(x => x >= 'A' && x <= 'Z'));
           Console.WriteLine(output);
        }
    }
}
