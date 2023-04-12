using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_shapes
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {

        }

        public void Read()
        {
            Console.Write("Введите координату x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Точка с координатами ({0}, {1})", x, y);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }

        public double DistanceBetween(Point p1, Point p2)
        {
            double dx = p1.x - p2.x;
            double dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
