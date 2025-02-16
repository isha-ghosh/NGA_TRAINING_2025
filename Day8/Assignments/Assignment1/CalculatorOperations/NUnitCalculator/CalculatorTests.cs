
using NUnit.Framework;
using System;
using CalculatorOperations;

namespace NUnitCalculator
{
    
    [TestFixture]
    public class CalculatorTests
    {
        Calculator c =new Calculator();

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            double result = c.Add(5, 3);
            double expected = 8;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            double result = c.Subtract(10, 4);
            double expected = 6;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            double result =c.Multiply(2, 5);
            double expected = 10;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            double result =c.Divide(10, 2);
            double expected = 5;
            Assert.That(result, Is.EqualTo(expected));

        }

        

        [Test]
        public void Add_AddingZero_ReturnsSameNumber()
        {
            double result = c.Add(5, 0);
            double expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Subtract_SubtractingZero_ReturnsSameNumber()
        {
            double result =c.Subtract(5, 0);
            double expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
