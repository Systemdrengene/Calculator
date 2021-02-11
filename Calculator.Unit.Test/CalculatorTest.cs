using System;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
	[TestFixture]
	public class CalculatorTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void AdditionTest_PositiveInteger_Equal()
		{
			var calc = new calculator();
			var result = calc.Add(3, 5);
			Assert.AreEqual(8,result);
		}

		[Test]
		public void AdditionTest_NegativeInteger_NotEqual()
		{
			var calc = new calculator();
			var calculated = calc.Add(-4, -4);
			Assert.AreNotEqual(8,calculated);
		}

		[Test]
		public void AdditionTest_PositiveAndNegativInteger_Equal()
        {
			var calc = new calculator();
			var calculated = calc.Add(-4, 8);
			Assert.AreEqual(4, calculated);
        }


		[Test]
		public void SubtractionTest_PositiveInteger_Equal()
		{
			var calc = new calculator();
			var result = calc.Subtract(5, 1);
			Assert.AreEqual(4,result);
		}

		[Test]
		public void SubtractionTest_NegativeInteger_Equal()
		{
			var calc = new calculator();
			var result = calc.Subtract(-5, -2);
			Assert.AreEqual(-3, result);
		}

		[Test]
		public void SubtractionTest_PositiveAndNegativInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Subtract(-4, 8);
			Assert.AreEqual(-12, calculated);
		}

		[TestCase(1,4,4)]
		[TestCase(2, 1, 2)]
		[TestCase(6, 3, 18)]
		public void MultiplyTest_PositiveInteger_Equal(double first, double second, double expectedresult)
		{
			var calc = new calculator();
			var calculated = calc.Multiply(first, second);
			Assert.AreEqual(expectedresult,calculated);
		}

		
		[Test]
		public void MultiplyTest_NegativeInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Multiply(-6, 3);
			Assert.AreEqual(-18, calculated);
		}

		
		[Test]
		public void MultiplyTest_ZeroInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Multiply(6.4, 0);
			Assert.AreEqual(0, calculated);
		}


		[Test]
		public void Power_PositiveInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Power(4, 2);
			Assert.AreEqual(16,calculated);
		}

		[Test]
		public void Power_NegativeInteger_Equal()
		{	
			var uut = new calculator();
            
			var ans = uut.Power(4, -2);

			Assert.That(0.0625, Is.EqualTo(ans));
		}
		[Test]
		public void Power_ZeroInteger_Equal()
		{
			var uut = new calculator();

			var ans = uut.Power(4, 0);

			Assert.That(1, Is.EqualTo(ans));
		}

		[Test]
		public void Divide_NonZero_Equal()
		{
			var uut = new calculator();
			var ans = uut.Divide(6, 2);
			Assert.AreEqual(3,ans);
		}

		[Test]
		public void Divide_Zero_EqualThrow()
		{
			var uut = new calculator();
			Assert.Catch<DivideByZeroException>(()=>uut.Divide(6,0));

		}

        [Test]
        public void Power_NegativeExponent_Equal()
        {
            var uut = new calculator();

            var ans = uut.Power(2, -2);

            Assert.That(0.25, Is.EqualTo(ans));
        }

        [Test]
        public void Power_NegativeExponentAndInteger_Equal()
        {
            var uut = new calculator();

            var ans = uut.Power(-2, -2);

            Assert.That(0.25, Is.EqualTo(ans));
        }

        [Test]
        public void Power_DecimalIntegerNegativeExponent_Equal()
        {
            var uut = new calculator();

            var ans = uut.Power(0.5, -2);

            Assert.That(4, Is.EqualTo(ans));
        }

        [Test]
        public void Power_DecimalIntegerAndExponentDecimal_Equal()
        {
            var uut = new calculator();

            var ans = uut.Power(0.5, 0.5);

            Assert.That(Math.Sqrt(0.5), Is.EqualTo(ans));
        }

        [Test]
        public void Power_NegIntegerAndExponentDecimal_Equal()
        {
            var uut = new calculator();

            Assert.Catch<ArithmeticException>(() => uut.Power(-0.5, 0.5) );
        }

		[Test]
		public void Power_PosIntegerAndExponentDecimal_Equal()
		{
			var uut = new calculator();
			var ans = uut.Power(1, 2);

			Assert.That(1, Is.EqualTo(ans));
		}



		//Accumulator

		[Test]
		public void AdditionAccumulatorInit_PositiveInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Add(4);
			Assert.AreEqual(4, calculated);
		}

		[Test]
		public void AdditionAccumulatorInit_NegativeInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Add(-4);
			Assert.AreEqual(-4, calculated);
		}

		public void AdditionAccumulator_PositiveInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Add(4);
			calculated = calc.Add(8);
			Assert.AreEqual(12, calculated);
		}

		[Test]
		public void AdditionAccumulator_NegativeInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Add(-4);
			calculated = calc.Add(-8);
			Assert.AreEqual(-12, calculated);
		}

		[Test]
		public void AdditionAccumulator_NegativeAndPositiveInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Add(-4);
			calculated = calc.Add(8);
			Assert.AreEqual(4, calculated);
		}
		[Test]
		public void SubtractionAccumulator_NegativeAndPositiveInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Add(-4);
			calculated = calc.Subtract(8);
			Assert.AreEqual(-12, calculated);
		}

		[Test]
		public void DivisionAccumulator_NegativeAndPositiveInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Add(-4);
			calculated = calc.Divide(4);
			Assert.AreEqual(-1, calculated);
		}

		[Test]
		public void DivisionAccumulator_ZeroInteger_EqualThrow()
		{
			var calc = new calculator();
			calc.Add(6);
			Assert.Catch<DivideByZeroException>(() => calc.Divide(0));
		}

		[Test]
		public void PowerAccumulator_NegativeAndPositiveInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Add(-4);
			calculated = calc.Power(8);
			Assert.AreEqual(65536, calculated);
		}

		[Test]
		public void PowerAccumulator_NegativeAndPositiveDouble_EqualThrow()
		{
			var calc = new calculator();
			calc.Add(-0.5);
			Assert.Catch<ArithmeticException>(() => calc.Power(0.5));
		}

		[Test]
		public void ClearAccumulator_Equal()
		{
			var calc = new calculator();
			calc.Add(420);
			calc.Clear();
			Assert.AreEqual(0, calc.Accumulator);
		}

	}
}