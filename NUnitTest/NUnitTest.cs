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
            for (double i = -10; i < 10; i += 0.01)
            {
                Assert.AreEqual(Math.Sin(i), MathFunctions.Sin(i), 0.0001);
            }
        }

        [Test]
        public void Cos()
        {
            for (double i = -10; i < 4; i += 0.01)
            {
                Assert.AreEqual(Math.Cos(i), MathFunctions.Cos(i), 0.0001);
            }
        }

        [Test]
        public void Csc()
        {
            for (double i = -10; i < 10; i += 0.01)
            {
                Assert.AreEqual(1 / Math.Sin(i), MathFunctions.Csc(i), 0.0001);
            }
        }

        // от нуля
        [Test]
        public void Log()
        {
            for (int newBase = -10; newBase < 10; newBase++)
            {
                if (newBase == 1) continue;

                for (double i = -10; i < 10; i += 0.01)
                {
                    Assert.AreEqual(Math.Log(i, newBase), MathFunctions.Log(i, newBase), 0.1);
                }
            }
        }

        [Test]
        public void Exp()
        {
            for (double i = -10; i < 10; i += 0.01)
            {
                Assert.AreEqual(Math.Exp(i), MathFunctions.Exp(i), 0.001);
            }
        }

        [Test]
        public void Power()
        {
            for (int radix = -5; radix < 5; radix += 1)
            {
                for (double i = -10; i < 10; i += 0.01)
                {
                    Assert.AreEqual(Math.Pow(i, radix), MathFunctions.Power(i, radix), 0.001);
                }
            }
        }

        [Test]
        public void Abs()
        {
            for (double i = -10; i < 10; i += 0.01)
            {
                Assert.AreEqual(Math.Abs(i), MathFunctions.Abs(i));
                Assert.IsTrue(MathFunctions.Abs(i) >= 0);
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
            for (double x = -10; x < 10; x += 0.01)
            {
                Assert.AreEqual(FunctionSystem.CalculateByDefaultMethods(x), FunctionSystem.Calculate(x), 0.8);
            }
        }
    }
}