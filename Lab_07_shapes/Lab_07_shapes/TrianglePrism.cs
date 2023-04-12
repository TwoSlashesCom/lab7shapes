using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_shapes
{
    internal class TrianglePrism : Cylinder
    {
        protected Point PointOnBase;

        public Point GetPointOnBase()
        {
            return PointOnBase;
        }

        public void SetPointOnBase(Point pointOnBase)
        {
            this.PointOnBase = pointOnBase;
        }
        public TrianglePrism (Point center, Point pointOnCircle, double height, Point pointOnBase) : base (center, pointOnCircle, height)
        {
            this.PointOnBase = pointOnBase;
        }

    }
}
