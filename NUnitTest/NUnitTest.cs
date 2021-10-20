using Laboratory_Work_Two_Core;
using NUnit.Framework;
using System;

namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sin()
        {
            var x = 0.5;
            var standard = Math.Sin(x);
            var custom = MathFunctions.Sin(x);

            Assert.AreEqual(standard, custom, 0.0001);
        }

        [Test]
        public void Cos()
        {
            var x = 0.5;
            var standard = Math.Cos(x);
            var custom = MathFunctions.Cos(x);

            Assert.AreEqual(standard, custom, 0.0001);
        }

        [Test]
        public void Csc()
        {
            var x = 0.5;
            var standard = 1 / Math.Sin(x);
            var custom = MathFunctions.Csc(x);

            Assert.AreEqual(standard, custom, 0.0001);
        }

        [Test]
        public void Log()
        {
            var x = 10;
            var newBase = 2;

            var standard = Math.Log(x, newBase);
            var custom = MathFunctions.Log(x, newBase);

            Assert.AreEqual(standard, custom, 0.001);
        }

        [Test]
        public void Exp()
        {
            var x = 16;

            var standard = Math.Exp(x);
            var custom = MathFunctions.Exp(x);

            Assert.AreEqual(standard, custom, 0.001);
        }

        [Test]
        public void Power()
        {
            var x = 10;
            var radix = 15;

            var standard = Math.Pow(x, radix);
            var custom = MathFunctions.Power(x, radix);

            Assert.AreEqual(standard, custom, 0.01);
        }

        [Test]
        public void NegativeAbs()
        {
            var x = -0.5;

            var standard = Math.Abs(x);
            var custom = MathFunctions.Abs(x);

            Assert.AreEqual(standard, custom);
        }

        [Test]
        public void PositiveAbs()
        {
            var x = 0.5;

            var standard = Math.Abs(x);
            var custom = MathFunctions.Abs(x);

            Assert.AreEqual(standard, custom);
        }

        [Test]
        public void Arctg()
        {
            var x = 5;

            var standard = Math.Atan(x);
            var custom = PowerSeries.GetArctg(x);

            Assert.AreEqual(standard, custom, 0.0001);
        }

        [Test]
        public void Function()
        {
            Assert.AreEqual(0.785398163397448, FunctionSystem.Calculate(5), 0.1);
        }
    }
}