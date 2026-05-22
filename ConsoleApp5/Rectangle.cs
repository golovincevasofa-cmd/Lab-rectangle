using System;

namespace ConsoleApp3
{
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    _width = 1;
                else
                    _width = value;
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                    _height = 1;
                else
                    _height = value;
            }
        }

        public Rectangle(double width, double height, string color) : base(color, "Прямоугольник")
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}