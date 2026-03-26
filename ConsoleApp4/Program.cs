using System;

namespace Lab1_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Создание прямоугольников:\n");

            // Вызов конструктора без параметров
            Rectangle rect1 = new Rectangle();
            Console.WriteLine("Прямоугольник 1 (конструктор по умолчанию):");
            rect1.DisplayInfo();
            Console.WriteLine();

            // Вызов конструктора с двумя параметрами
            Rectangle rect2 = new Rectangle(5, 3);
            Console.WriteLine("Прямоугольник 2 (5x3):");
            rect2.DisplayInfo();
            Console.WriteLine();

            // Вызов конструктора с двумя параметрами
            Rectangle rect3 = new Rectangle(4, 4);
            Console.WriteLine("Прямоугольник 3 (4x4):");
            rect3.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("2. Демонстрация методов:\n");

            // Вызов методов
            Console.WriteLine($"Площадь прямоугольника 2: {rect2.CalculateArea()}");
            Console.WriteLine($"Периметр прямоугольника 2: {rect2.CalculatePerimeter()}");
            Console.WriteLine($"Прямоугольник 3 (4x4) является квадратом: {rect3.IsSquare()}");
            Console.WriteLine($"Прямоугольник 2 (5x3) является квадратом: {rect2.IsSquare()}");

            Console.WriteLine("\nНажмите любую клавишу для завершения");
            Console.ReadKey();
        }
    }
}