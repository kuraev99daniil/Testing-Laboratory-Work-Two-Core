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
            for (double i = -4; i < 4; i += 0.5)
            {
                Assert.AreEqual(Math.Sin(i), MathFunctions.Sin(i), 0.0001);
            }
        }

        [Test]
        public void Cos()
        {
            for (double i = -4; i < 4; i += 0.5)
            {
                Assert.AreEqual(Math.Cos(i), MathFunctions.Cos(i), 0.0001);
            }
        }

        [Test]
        public void Csc()
        {
            for (double i = -4; i < 4; i += 0.5)
            {
                Assert.AreEqual(1 / Math.Sin(i), MathFunctions.Csc(i), 0.0001);
            }
        }

        [Test]
        public void Log()
        {
            var newBase = 2;
            for (double i = 10; i < 16; i += 0.5)
            {
                Assert.AreEqual(Math.Log(i, newBase), MathFunctions.Log(i, newBase), 0.001);
            }
        }

        [Test]
        public void Exp()
        {
            for (double i = 10; i < 16; i += 0.5)
            {
                Assert.AreEqual(Math.Exp(i), MathFunctions.Exp(i), 0.001);
            }
        }

        [Test]
        public void Power()
        {
            var radix = 2;
            for (double i = 10; i < 16; i += 0.5)
            {
                Assert.AreEqual(Math.Pow(i, radix), MathFunctions.Power(i, radix), 0.001);
            }
        }

        [Test]
        public void NegativeAbs()
        {
            for (double i = -4; i < -1; i += 0.5)
            {
                Assert.AreEqual(Math.Abs(i), MathFunctions.Abs(i), 0.001);
            }
        }

        [Test]
        public void PositiveAbs()
        {
            for (double i = 0; i < 4; i += 0.5)
            {
                Assert.AreEqual(Math.Abs(i), MathFunctions.Abs(i), 0.001);
            }
        }

        [Test]
        public void Arctg()
        {
            for (double i = -1; i < 1; i += 0.001)
            {
                Assert.AreEqual(Math.Atan(i), PowerSeries.GetArctg(i), 0.01);
            }
        }

        [Test]
        public void Function()
        {
            Assert.AreEqual(0.785398163397448, FunctionSystem.Calculate(5), 0.1);
        }
    }
}