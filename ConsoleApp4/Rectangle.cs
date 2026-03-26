using System;

namespace Lab1_Rectangle
{
    public class Rectangle
    {
        private double _length;
        private double _width;

        // Свойство для длины с проверкой
        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    _length = 1;
                }
                else
                {
                    _length = value;
                }
            }
        }

        // Свойство для ширины с проверкой
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    _width = 1;
                }
                else
                {
                    _width = value;
                }
            }
        }

        // Конструктор по умолчанию 
        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }

        // Конструктор с двумя параметрами
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Расчет площади
        public double CalculateArea()
        {
            return Length * Width;
        }

        // Расчет периметра
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        // Проверка, является ли прямоугольник квадратом
        public bool IsSquare()
        {
            return Math.Abs(Length - Width) < 0.000001;
        }

        // Вывод информации о прямоугольнике
        public void DisplayInfo()
        {
            Console.WriteLine($"Длина: {Length:F2}");
            Console.WriteLine($"Ширина: {Width:F2}");
            Console.WriteLine($"Площадь: {CalculateArea():F2}");
            Console.WriteLine($"Периметр: {CalculatePerimeter():F2}");
            Console.WriteLine($"Квадрат: {(IsSquare() ? "Да" : "Нет")}");
        }
    }
}
