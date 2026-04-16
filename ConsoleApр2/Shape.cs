using System;

namespace Lab2_Shape
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
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Фигура: {_shapeType}");
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Площадь: {CalculateArea():F2}");
            Console.WriteLine($"Периметр: {CalculatePerimeter():F2}");
        }
    }
}