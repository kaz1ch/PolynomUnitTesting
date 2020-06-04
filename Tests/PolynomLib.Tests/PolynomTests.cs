using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolynomLib.Tests
{
    [TestClass]
    public class PolynomTests
    {
        [TestMethod]

        public void Value_Returns_correct_result()
        {
            //A-A-A
            //Arrange - Act - Assert

            #region Arrage

            double[] a = { 7, 5, 3 };
            var x = 5d;
            var expected_y = 107d;

            var polynom = new Polynom(a);

            #endregion

            #region Act

            var actual_y = polynom.Value(x);

            #endregion

            Assert.IsFalse(double.IsNaN(actual_y));
            Assert.AreEqual(expected_y, actual_y);

        }

        [TestMethod]
        public void Value_returns_NaN_for_zero_length_polynom()
        {
            var p = new Polynom(new double[0]);
            var x = 0;
            var expected_y = double.NaN;

            var actual_y = p.Value(x);

            Assert.AreEqual(expected_y, actual_y);
        }

        [TestMethod]

        public void Differential_returns_Correct_Polynom()
        {
            var p = new Polynom(7, 5, 3);
            const double expected_a0 = 5;
            const double expected_a1 = 3 * 2;

            var diff_p = p.GetDifferential();

            Assert.IsNotNull(diff_p);
            Assert.AreEqual(expected_a0, diff_p[0]);
            Assert.AreEqual(expected_a1, diff_p[1]);
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]

        public void Differential_throw_InvalidOperationException_for_Polynom_with_zero_length()
        {
            var p = new Polynom();

            var q = p.GetDifferential();
        }

        [TestMethod]

        public void Differential_throw_InvalidOperationException_for_Polynom_with_zero_length2()
        {
            var p = new Polynom();
            const string expected_message = "Попытка дифференцирования полинома с массивом коэффициентов нулевой длины";

            var exception = Assert.ThrowsException<InvalidOperationException>(() => p.GetDifferential());
            Assert.AreEqual(expected_message, exception.Message);
        }
    }
}
