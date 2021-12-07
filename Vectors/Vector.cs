using System;

namespace Vectors
{
    public class Vector
    {
        private int x, y;
        public Vector(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public double Magnitude()
        {
            return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
        public double DotProduct(Vector vector, Vector vector1)
        {
            return (vector.x * vector1.x) + (vector.y * vector1.y);
        }
        public double AngleBetween(Vector vector, Vector vector1)
        {
            return (Math.Acos((DotProduct(vector, vector1)/(vector.Magnitude() * vector1.Magnitude()))))*(180/Math.PI);
        }
    }
}
