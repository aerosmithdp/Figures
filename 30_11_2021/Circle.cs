using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures 
{
    class Circle : Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            double area = Math.PI * Math.Pow(_radius, 2);
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = 2 * Math.PI * _radius;
            return perimeter;
        }
    }
}
