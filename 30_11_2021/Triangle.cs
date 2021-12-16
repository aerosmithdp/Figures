using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures   
{
    class Triangle : Figure
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public override double Perimeter()
        {
            double perimeter = _side1 + _side2 + _side3;
            return perimeter;
        }

        public override double Area()
        {
            double area = Math.Sqrt(GetSemiPerimeter() * (GetSemiPerimeter() - _side1) * (GetSemiPerimeter() - _side2) * (GetSemiPerimeter() - _side3));
            return area;
        }

        double GetSemiPerimeter()
        {
            double semiperimeter = Perimeter() / 2;
            return semiperimeter;
        }

    }
}
