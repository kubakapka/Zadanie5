using System;

namespace Shape
{
    public class Shape
    {
        //public string Type; 
        private double _bokA;
        public double Pole;
        public double Obwod;

        public double BokA
        {
            get => _bokA;
            set => _bokA = value;
        }
        
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("[1] Generate sample data");
            Console.WriteLine("[2] Default sort");
            Console.WriteLine("[3] Sort by Perimeter");
            Console.WriteLine("[4] Filter by Shape type");
            Console.WriteLine("[5] Display shapes");
            Console.WriteLine("[0] Exit");
        }
        
        
    }
}