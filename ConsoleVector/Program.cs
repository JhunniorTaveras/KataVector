using System;
using Vector;

namespace ConsoleVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la coordenada x del primer vector: ");
            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca la coordenada y del primer vector: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Introduzca la coordenada x del segundo vector: ");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca la coordenada y del segundo vector: ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            VectorClass vectorOne = new(X1,Y1);
            VectorClass vectorTwo = new(X1, Y1);

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            Console.WriteLine($"La magnitud del primer vector es: {vectorOne.Magnitude()}");
            Console.WriteLine($"La magnitud del segundo vector es: {vectorTwo.Magnitude()}");

            Console.WriteLine();
            Console.WriteLine($"El producto punto es: {vectorOne.DotProduct(vectorTwo)}");
            Console.WriteLine($"El angulo es: {vectorOne.AngleBetween(vectorTwo)}");

        }
    }
}
