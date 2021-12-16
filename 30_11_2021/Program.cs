//using Figures;
using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Circle(10));
            figures.Add(new Square(10));
            figures.Add(new Triangle(3, 4, 5));

            Console.WriteLine(figures[0].Perimeter());
            Console.WriteLine(figures[1].Perimeter());
            Console.WriteLine(figures[2].Perimeter());
            Console.WriteLine(figures[0].Area());
            Console.WriteLine(figures[1].Area());
            Console.WriteLine(figures[2].Area());
            

        }
    }

}
 