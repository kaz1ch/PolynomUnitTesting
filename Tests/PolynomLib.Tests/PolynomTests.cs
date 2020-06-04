using System;
using System.Collections.Generic;
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

        public void Value_returns_NaN_for_zero_length_polynom()
        {
            var p = new Polynom(new double[0]);
            var x = 0;
            var expected_y = double.NaN;

            var actual_y = p.Value(x);

            Assert.AreEqual(expected_y, actual_y);
        }
    }
}
