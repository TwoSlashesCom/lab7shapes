using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_shapes
{
    internal class Cylinder : Point
    {
        protected Point PointOnCenter;
        protected Point PointOnCircle;
        protected double Height;

        public void SetCenter(Point center)
        {
            this.PointOnCenter = center;
        }

        public void SetPointOnCircle(Point pointOnCircle)
        {
            this.PointOnCircle = pointOnCircle;
        }

        public void SetHeight(double height)
        {
            this.Height = height;
        }

        public Point GetCenter()
        {
            return this.PointOnCenter;
        }

        public Point GetPointOnCircle()
        {
            return this.PointOnCircle;
        }

        public double GetHeight()
        {
            return this.Height;
        }

        public Cylinder(Point center, Point pointOnCircle, double height)
        {
            this.PointOnCenter = center;
            this.PointOnCircle = pointOnCircle;
            this.Height = height;
        }

        public double GetBaseArea()
        {
            double radius = DistanceBetween(PointOnCenter, PointOnCircle);
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetBaseCircumference()
        {
            double radius = DistanceBetween(PointOnCenter, PointOnCircle);
            return 2 * Math.PI * radius;
        }

        public double GetVolume()
        {
            return GetBaseArea() * Height;
        }

        public double GetLateralArea()
        {
            double radius = DistanceBetween(PointOnCenter, PointOnCircle);
            return 2 * Math.PI * radius * Height;
        }
    }

    
}
