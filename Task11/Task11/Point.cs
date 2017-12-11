using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task11
{
    /// <summary>
    /// Instructions of the object
    /// </summary>
    class Point
    {
        public double PointX { get; set; }
        public double PointY { get; set; }
        public double PointZ { get; set; }

        /// <summary>
        /// Initialize the Point object with the data
        /// </summary>
        /// <param name="x">X-coordinate</param>
        /// <param name="y">Y-coordinate</param>
        /// <param name="z">Z-coordinate</param>
        public Point(double x, double y, double z)
        {
            PointX = x;
            PointY = y;
            PointZ = z;
        }
    }
}
