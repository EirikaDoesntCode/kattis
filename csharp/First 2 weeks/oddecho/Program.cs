// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;


namespace oddEcho
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string[] stringArray = new string[lines];
            for(int i = 0; i < lines; ++i)
            {

                string temp = Console.ReadLine();
                if(i % 2 == 0)
                {
                    stringArray[i] = temp;
                }
                else{
                    stringArray[i] = "";
                }
            }
            foreach(var item in stringArray)
            {
                if(item != "")
                {
                    Console.WriteLine(item.ToString());
                }
                
            }
        }
    }
}