using System;
using System.Collections.Generic;
using System.Reflection;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> lista;

            int x;
            do
            { 
                Shape.DisplayMenu();
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Generate sample data");
                    /*{
                        Console.Write("Number of random numbers to generate: ");
                        String line = Console.ReadLine();
                        double numbers = 0;
                        Random rnd = new Random();
      
                        if (! double.TryParse(line, out numbers))
                            numbers = 10;
      
                        for (int i = 1; i <= numbers; i++)
                            Console.WriteLine("{0}", rnd.Next(0,20));
                        Console.ReadLine();
                    }*/
                        break;
                    case 2:
                        Console.WriteLine("Default sort");
                        break;
                    case 3:
                        Console.WriteLine("Sort by Perimeter");
                        break;
                    case 4:
                        Console.WriteLine("Filter by Shape type");
                        break;
                    case 5:
                        Console.WriteLine("Display shapes");
                        break;
                        
                }
                
            } while (x != 0);
            
            
            Square pole = new Square(10);
            pole.Area();
            pole.Perimeter();
            Console.WriteLine("Pole kwadratu: " + pole.Pole);
            Console.WriteLine("Obwód trójkąta: " + pole.Obwod);
            
            Rectangle pole2 = new Rectangle(10, 20);
            pole2.Area();
            pole2.Perimeter();
            Console.WriteLine("Pole prostokąta: " + pole2.Pole);
            Console.WriteLine("Obwód trójkąta: " + pole2.Obwod);
            
            Circle pole3 = new Circle(10);
            pole3.Area();
            pole3.Perimeter();
            Console.WriteLine("Pole koła: " + pole3.Pole);
            Console.WriteLine("Obwód trójkąta: " + pole3.Obwod);
            
            Triangle pole4 = new Triangle(10, 20, 30);
            pole4.Area();
            pole4.Perimeter();
            Console.WriteLine("Pole trójkąta: " + pole4.Pole);
            Console.WriteLine("Obwód trójkąta: " + pole4.Obwod);
        }
    }
}