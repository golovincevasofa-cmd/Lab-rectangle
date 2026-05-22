using System;

namespace ConsoleApp3
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    _radius = 1;
                else
                    _radius = value;
            }
        }

        public Circle(double radius, string color) : base(color, "Круг")
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}