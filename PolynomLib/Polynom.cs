using System;

namespace PolynomLib
{
    public class Polynom
    {
        private readonly double[] _a;

        public Polynom(params double[] a)
        {
            _a = a;
        }

        public double Value(double x)
        {
            var len = _a.Length;
            if (len == 0) return double.NaN;
            var y = _a[_a.Length - 1];
            for (var n = len - 2; n >= 0; n--)
                y = y * x + _a[n];
            return y;
        }

        public double Value2(double x)
        {
            var y = 0d;
            for (var n = 0; n < _a.Length; n++)
                y += _a[n] * Math.Pow(x, n);

            return y;
        }

        public Polynom GetDifferential()
        {
            return null;
        }
    }
}
