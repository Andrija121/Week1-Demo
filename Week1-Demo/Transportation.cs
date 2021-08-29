using System;
using System.Collections.Generic;
using System.Text;

namespace Week1_Demo
{
    class Transportation
    {
        private int speedKMH;
        protected int SpeedKMH { get; set; }

        public Transportation(int speedKMH)
        {
            this.SpeedKMH = speedKMH;
        }

        //public double CalculateHoursTillDestination(int km)
        //{

        //}
        public virtual string GetInfo()
        {
            return SpeedKMH + "KMH";
        }

    }
    class Car : Transportation
    {
        private string licensePlate;
        private ConsoleColor color;

        public Car(string licensePlate,ConsoleColor color,int speed) : base(speed)
        {
            this.licensePlate = licensePlate;
            this.color = color;
        }
    }
    class Bycicle : Transportation
    {
        private bool hasLuggageCarrier;

        public Bycicle(bool hasLuggage,int speed) :  base(speed)
        {
            this.hasLuggageCarrier = hasLuggage;
        }
        public override string GetInfo()
        {
            string info = "Bycicle";
            info += "- Luggage carrier";
            if (hasLuggageCarrier)
                info += " yes";
            else
                info += "no";

            info += "-speed:" + base.SpeedKMH;
            return info;
            
        }
    }
    class Boat : Transportation
    {
        private string company;
        private int weight;

        public Boat(string company,int weight,int speed) : base(speed)
        {
            this.company = company;
            this.weight = weight;
        }
    }
}
