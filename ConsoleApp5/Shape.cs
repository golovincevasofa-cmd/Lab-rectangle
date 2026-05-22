using System;

namespace ConsoleApp3
{
    public abstract class Shape
    {
        private string _color;
        protected string _shapeType;

        public string Color
        {
            get { return _color; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _color = "Белый";
                else
                    _color = value;
            }
        }

        public string ShapeType
        {
            get { return _shapeType; }
        }

        public Shape(string color, string shapeType)
        {
            Color = color;
            _shapeType = shapeType;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}