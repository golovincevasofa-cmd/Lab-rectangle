using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class ShapeCollection<T> where T : Shape
    {
        private static int _totalShapesCreated = 0;
        private List<T> _shapes = new List<T>();

        public static int TotalShapesCreated
        {
            get { return _totalShapesCreated; }
        }

        public void AddShape(T shape)
        {
            _shapes.Add(shape);
            _totalShapesCreated++;
        }

        public double GetTotalArea()
        {
            double total = 0;
            foreach (T shape in _shapes)
            {
                total += shape.CalculateArea();
            }
            return total;
        }

        public List<T> GetShapesByColor(string color)
        {
            List<T> result = new List<T>();
            foreach (T shape in _shapes)
            {
                if (shape.Color == color)
                {
                    result.Add(shape);
                }
            }
            return result;
        }
    }
}
