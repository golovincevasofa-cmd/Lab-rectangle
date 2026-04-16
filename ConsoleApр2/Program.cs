using System;
using System.Collections.Generic;

namespace Lab2_Shape
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle(3, "Красный"));           
            shapes.Add(new Rectangle(5, 4, "Синий"));       
            shapes.Add(new Triangle(3, 4, 5, "Зелёный"));   
            shapes.Add(new Circle(5, "Жёлтый"));           
            shapes.Add(new Rectangle(6, 2, "Оранжевый"));   
            shapes.Add(new Triangle(5, 5, 5, "Фиолетовый"));

            Console.WriteLine("Информация о фигурах \n");

            double totalArea = 0;

            foreach (Shape shape in shapes)
            {
                shape.DisplayInfo();
                Console.WriteLine("  ");
                totalArea += shape.CalculateArea();  
            }

            Console.WriteLine($"\nОбщая площадь всех фигур: {totalArea:F2}");

           
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.ShapeType}: площадь = {shape.CalculateArea():F2}, периметр = {shape.CalculatePerimeter():F2}");
            }

            Console.ReadKey();
        }
    }
}