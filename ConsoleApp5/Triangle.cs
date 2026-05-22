using System;

namespace ConsoleApp3
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get { return _sideA; }
            set
            {
                if (value <= 0)
                    _sideA = 1;
                else
                    _sideA = value;
            }
        }

        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (value <= 0)
                    _sideB = 1;
                else
                    _sideB = value;
            }
        }

        public double SideC
        {
            get { return _sideC; }
            set
            {
                if (value <= 0)
                    _sideC = 1;
                else
                    _sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC, string color) : base(color, "Треугольник")
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}