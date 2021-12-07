using System;
using System.Numerics;
using System.Windows;

namespace Vector
{
    public class VectorClass
    {
        public int x;
        public int y;

        public VectorClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Magnitude()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public double DotProduct(VectorClass vector)
        {
            return (vector.x * x) + (vector.y * y);
        }

        public double AngleBetween(VectorClass vector)
        {
            return Math.Acos(DotProduct(vector) / (vector.Magnitude() * Magnitude()));
        }
    }
}
