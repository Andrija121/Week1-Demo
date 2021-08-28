using System;

namespace Week1_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //za ocekivati je da se ispise "167KM/H"
            //testiraj!!!
            Car car = new Car("NS567BB", ConsoleColor.Black, 167);
            Console.WriteLine(car.GetInfo());

            Bycicle bycicle = new Bycicle(true, 100);
            Console.WriteLine(bycicle.GetInfo());


            Console.ReadLine();
            
        }
    }
}
