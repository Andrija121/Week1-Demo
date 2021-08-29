using System;

namespace Week1_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //za ocekivati je da se ispise "167KM/H"
            //testiraj!!!
            
            //napravio sam da ispise, ali idalje kada stavim breakpoint na 12 liniju i zatim mis na new Car
            //ispise mi sve informacije za vrednosti car-a sem malo speedKMH koje je isto promenjiva,
            //ja dodam vrednost propertiju, a nisam siguran da tako treba, vec mislim da samo sada radi posao 
            Car car = new Car("NS567BB", ConsoleColor.Black, 167);
            Console.WriteLine(car.GetInfo());

            Bycicle bycicle = new Bycicle(true, 100);
            Console.WriteLine(bycicle.GetInfo());


            Console.ReadLine();
            
        }
    }
}
