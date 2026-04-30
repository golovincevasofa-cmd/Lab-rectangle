using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1.Круг\n");

            ShapeCollection<Circle> circles = new ShapeCollection<Circle>();

            circles.AddShape(new Circle(3, "Красный"));
            circles.AddShape(new Circle(5, "Жёлтый"));
            circles.AddShape(new Circle(2, "Красный"));

            Console.WriteLine($"Общая площадь кругов: {circles.GetTotalArea():F2}");
            Console.WriteLine($"Количество красных кругов: {circles.GetShapesByColor("Красный").Count}");

            Console.WriteLine("\n2.Прямоугольник\n");

            ShapeCollection<Rectangle> rectangles = new ShapeCollection<Rectangle>();

            rectangles.AddShape(new Rectangle(5, 4, "Синий"));
            rectangles.AddShape(new Rectangle(6, 2, "Оранжевый"));
            rectangles.AddShape(new Rectangle(3, 3, "Синий"));

            Console.WriteLine($"Общая площадь прямоугольников: {rectangles.GetTotalArea():F2}");
            Console.WriteLine($"Количество синих прямоугольников: {rectangles.GetShapesByColor("Синий").Count}");

            Console.WriteLine("\n3.треугольник\n");

            ShapeCollection<Triangle> triangles = new ShapeCollection<Triangle>();

            triangles.AddShape(new Triangle(3, 4, 5, "Зелёный"));
            triangles.AddShape(new Triangle(5, 5, 5, "Фиолетовый"));

            Console.WriteLine($"Общая площадь треугольников: {triangles.GetTotalArea():F2}");
            Console.WriteLine($"Количество зелёных треугольников: {triangles.GetShapesByColor("Зелёный").Count}");

            Console.WriteLine("\n4. Все фигуры\n");

            ShapeCollection<Shape> allShapes = new ShapeCollection<Shape>();

            allShapes.AddShape(new Circle(4, "Красный"));
            allShapes.AddShape(new Rectangle(7, 3, "Синий"));
            allShapes.AddShape(new Triangle(6, 8, 10, "Зелёный"));
            allShapes.AddShape(new Circle(2, "Красный"));

            Console.WriteLine($"Общая площадь всех фигур: {allShapes.GetTotalArea():F2}");
            Console.WriteLine($"Количество красных фигур: {allShapes.GetShapesByColor("Красный").Count}");

            Console.WriteLine("\n5. Статический счётчик\n");
            Console.WriteLine($"Всего создано фигур: {ShapeCollection<Shape>.TotalShapesCreated}");

            Console.ReadKey();

        }
    }
}