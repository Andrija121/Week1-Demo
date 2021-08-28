using System;

namespace Week1_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bycicle bycicle = new Bycicle(true, 100);
            Console.WriteLine(bycicle.GetInfo());
            Console.ReadLine();
            
        }
    }
}
