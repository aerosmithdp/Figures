using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures   
{
    class Square : Figure
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }

        public override double Area()
        {
            double area = _side * _side;
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = _side * 4;
            return perimeter;
        }

    }
}
