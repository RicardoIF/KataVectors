using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            Console.WriteLine("Digite la x del primer vector: ");
            x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite la x del segundo vector: ");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite la y del primer vector: ");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite la y del segundo vector: ");
            y2 = int.Parse(Console.ReadLine());

            Vectors.Vector vector = new Vectors.Vector(x1, y1);
            Vectors.Vector vector1 = new Vectors.Vector(x2, y2);
            Console.WriteLine("=========================================================");
            Console.WriteLine("The first vector Magnitude: " + vector.Magnitude());
            Console.WriteLine("The second vector Magnitude: " + vector1.Magnitude());
            Console.WriteLine("The DotProduct: " + vector.DotProduct(vector, vector1));
            Console.WriteLine("AngleBetween: " + (vector.AngleBetween(vector, vector1)));
            Console.WriteLine("=========================================================");
            Console.WriteLine("Press any key! ");
            Console.ReadKey();
        }
    }
}
