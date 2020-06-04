using System;

namespace PolynomLib
{
    public class Polynom
    {
        private readonly double[] _a;

        public double this[int n] => _a[n];

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
            var length = _a.Length - 1;
            if (length < 0)
                throw new InvalidOperationException("Попытка дифференцирования полинома с массивом коэффициентов нулевой длины");

            var a = new double[length];

            for (var i = 0; i < length; i++)
                a[i] = _a[i + 1] * (i + 1);

            return new Polynom(a);
        }
    }
}
