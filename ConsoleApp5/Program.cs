using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCollection<Circle> circles = new ShapeCollection<Circle>();
            circles.AddShape(new Circle(3, "Красный"));
            circles.AddShape(new Circle(5, "Жёлтый"));
            circles.AddShape(new Circle(2, "Красный"));

            Console.WriteLine("ShapeCollection<Circle>");
            Console.WriteLine($"Общая площадь кругов: {circles.GetTotalArea():F2}");
            Console.WriteLine($"Количество красных кругов: {circles.GetShapesByColor("Красный").Count}");
            Console.WriteLine();

            ShapeCollection<Rectangle> rectangles = new ShapeCollection<Rectangle>();
            rectangles.AddShape(new Rectangle(5, 4, "Синий"));
            rectangles.AddShape(new Rectangle(6, 2, "Оранжевый"));
            rectangles.AddShape(new Rectangle(3, 3, "Синий"));

            Console.WriteLine("ShapeCollection<Rectangle>");
            Console.WriteLine($"Общая площадь прямоугольников: {rectangles.GetTotalArea():F2}");
            Console.WriteLine($"Количество синих прямоугольников: {rectangles.GetShapesByColor("Синий").Count}");
            Console.WriteLine();

            ShapeCollection<Triangle> triangles = new ShapeCollection<Triangle>();
            triangles.AddShape(new Triangle(3, 4, 5, "Зелёный"));
            triangles.AddShape(new Triangle(5, 5, 5, "Фиолетовый"));

            Console.WriteLine("ShapeCollection<Triangle> ");
            Console.WriteLine($"Общая площадь треугольников: {triangles.GetTotalArea():F2}");
            Console.WriteLine($"Количество зелёных треугольников: {triangles.GetShapesByColor("Зелёный").Count}");
            Console.WriteLine();

            ShapeCollection<Shape> allShapes = new ShapeCollection<Shape>();
            allShapes.AddShape(new Circle(4, "Красный"));
            allShapes.AddShape(new Rectangle(7, 3, "Синий"));
            allShapes.AddShape(new Triangle(6, 8, 10, "Зелёный"));
            allShapes.AddShape(new Circle(2, "Красный"));

            Console.WriteLine("ShapeCollection<Shape> ");
            Console.WriteLine($"Общая площадь всех фигур: {allShapes.GetTotalArea():F2}");
            Console.WriteLine($"Количество красных фигур: {allShapes.GetShapesByColor("Красный").Count}");
            Console.WriteLine();

            Console.WriteLine(" Статический счётчик");
            Console.WriteLine($"Всего создано фигур: {ShapeCollection<Shape>.TotalShapesCreated}");

            Console.ReadKey();
        }
    }
}