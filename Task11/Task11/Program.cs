using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new Vector(new Point(1, 2, 3), new Point(4, 2, 6));
            var second = new Vector(new Point(6, 2, 3), new Point(1, 8, 3));
            var third = new Vector(new Point(1, 2, 3), new Point(1, 8, 3));

            Console.WriteLine($"Scalar {Vector.ScalarProduct(first, second)}");
            Console.WriteLine($"Multiple ({(first * second).VectorX}; {(first * second).VectorY}; {(first * second).VectorZ})");
            Console.WriteLine($"Angle between {Vector.AngleBetweenVectors(first, second)}");
            Console.WriteLine($"Comparison first > second = {first > second}");
            Console.WriteLine($"Comparison first < second = {first < second}");
            Console.WriteLine($"Vector product ({Vector.VectorProduct(first, second).VectorX}; {Vector.VectorProduct(first, second).VectorY}; {Vector.VectorProduct(first, second).VectorZ})");
            Console.WriteLine($"Mixed product {Vector.MixedProduct(first, second, third)}");
            Console.ReadKey();
        }
    }
}
