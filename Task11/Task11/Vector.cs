using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task11
{
    partial class Vector
    {
        public double VectorX { get; set; }
        public double VectorY { get; set; }
        public double VectorZ { get; set; }

        public Vector(){}

        /// <summary>
        /// Initialize the Vector object with the data using entered points
        /// </summary>
        /// <param name="start">start-coordinate(x,y,z) of the vector</param>
        /// <param name="end">end-coordinate(x,y,z) of the vector</param>
        public Vector(Point start, Point end)
        {
            VectorX = end.PointX - start.PointX;
            VectorY = end.PointY - start.PointY;
            VectorZ = end.PointZ - start.PointZ;
        }
    }
}
