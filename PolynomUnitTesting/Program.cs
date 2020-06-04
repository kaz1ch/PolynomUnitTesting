using PolynomLib;
using System;

namespace PolynomUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 7, 5, 3 };
            var p = new Polynom(a);

            var y0 = p.Value(0);
            var y1 = p.Value(1);
            var y5 = p.Value(5);

            Console.WriteLine("Fin.");
            Console.ReadLine();
        }
    }
}
