using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Initialize()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var result = _mathOperations.Add(1, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            var result = _mathOperations.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            var result = _mathOperations.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            var result = _mathOperations.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Power_TwoNumbers_ReturnsResult()
        {
            var result = _mathOperations.Power(2, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Divide_DivisionByZero_ThrowsException()
        {
            _mathOperations.Divide(10, 0);
        }
    }
}