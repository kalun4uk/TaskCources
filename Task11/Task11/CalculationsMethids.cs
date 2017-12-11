using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task11
{
    partial class Vector
    {
        /// <summary>
        /// Get vector length
        /// </summary>
        /// <param name="obj">Vector, which length we are searching</param>
        /// <returns>Double value of vector length</returns>
        public static double VectorLenght(Vector obj)
        {
            return Math.Sqrt((obj.VectorX * obj.VectorX) + (obj.VectorY * obj.VectorY) + (obj.VectorZ * obj.VectorZ));
        }

        /// <summary>
        /// Addition of the vectors
        /// </summary>
        /// <param name="first">First vector to add</param>
        /// <param name="second">Second vector to add</param>
        /// <returns>New vector of added vectors</returns>
        public static Vector operator +(Vector first, Vector second)
        {
            var result = new Vector
            {
                VectorX = first.VectorX + second.VectorX,
                VectorY = first.VectorY + second.VectorY,
                VectorZ = first.VectorZ + second.VectorZ
            };
            return result;
        }

        /// <summary>
        /// Substraction of the vectors
        /// </summary>
        /// <param name="first">First vector to substract</param>
        /// <param name="second">Second vector to substract</param>
        /// <returns>New vector of substracted vectors</returns>
        public static Vector operator -(Vector first, Vector second)
        {
            var result = new Vector
            {
                VectorX = second.VectorX - second.VectorX,
                VectorY = second.VectorY - second.VectorY,
                VectorZ = second.VectorZ - second.VectorZ
            };
            return result;
        }

        /// <summary>
        /// Multiplication of the vectors
        /// </summary>
        /// <param name="first">First vector to multiplicate</param>
        /// <param name="second">Second vector to multiplicate</param>
        /// <returns>New vector of multiplicated vectors</returns>
        public static Vector operator *(Vector first, Vector second)
        {
            var result = new Vector
            {
                VectorX = second.VectorX*second.VectorX,
                VectorY = second.VectorY*second.VectorY,
                VectorZ = second.VectorZ*second.VectorZ
            };
            return result;
        }

        /// <summary>
        /// Verification of the vectors
        /// </summary>
        /// <param name="first">First vector of verification</param>
        /// <param name="second">Second vector of verification</param>
        /// <returns>Bool value of verification</returns>
        public static bool operator >(Vector first, Vector second)
        {
            return VectorLenght(first) > VectorLenght(second);
        }

        /// <summary>
        /// Verification of the vectors
        /// </summary>
        /// <param name="first">First vector of verification</param>
        /// <param name="second">Second vector of verification</param>
        /// <returns>Bool value of verification</returns>
        public static bool operator <(Vector first, Vector second)
        {
            return VectorLenght(first) < VectorLenght(second);
        }

        /// <summary>
        /// Scalar product
        /// </summary>
        /// <param name="first">First vector</param>
        /// <param name="second">Second vector</param>
        /// <returns>Scalar product of the vectors</returns>
        public static double ScalarProduct(Vector first, Vector second)
        {
            var obj = new Vector();
            obj = first * second;
            return obj.VectorX + obj.VectorY + obj.VectorZ;
        }

        /// <summary>
        /// Searching of the angle between the vectors
        /// </summary>
        /// <param name="first">First vector</param>
        /// <param name="second">Second vector</param>
        /// <returns>Radian value of the angle</returns>
        public static double AngleBetweenVectors(Vector first, Vector second)
        {
            return ScalarProduct(first, second) / (VectorLenght(first) * VectorLenght((second)));
        }

        /// <summary>
        /// Vector product of the vectors
        /// </summary>
        /// <param name="first">First vector</param>
        /// <param name="second">Second vector</param>
        /// <returns>Vector product value - new vector</returns>
        public static Vector VectorProduct(Vector first, Vector second)
        {
            var obj = new Vector
            {
                VectorX = first.VectorY*second.VectorZ + first.VectorZ*second.VectorY,
                VectorY = first.VectorZ*second.VectorX + first.VectorX*second.VectorZ,
                VectorZ = first.VectorX*second.VectorY + first.VectorY*second.VectorX
            };
            return obj;
        }

        /// <summary>
        /// Mixed product of the vectors
        /// </summary>
        /// <param name="first">First vector</param>
        /// <param name="second">Second vector</param>
        /// <returns>Mixed product value - double value</returns>
        public static double MixedProduct(Vector first, Vector second, Vector third)
        {
            return ScalarProduct(first, VectorProduct(second, third));
        }
    }
}
