using System;

namespace parkedCars
{
    public class Program
    {
        static void Main(string[] args)
        {
            int carsArnar = int.Parse(Console.ReadLine());
            int carsHannes = int.Parse(Console.ReadLine());    

            int carsParked = carsArnar + carsHannes;
            Console.WriteLine(carsParked);

        }
    }
}
