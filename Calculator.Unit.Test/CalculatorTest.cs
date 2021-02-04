using NUnit.Framework;


namespace Calculator.Unit.Test
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
		public void PowerTest_PositiveInteger_Equal()
		{
			var calc = new calculator();
			var calculated = calc.Power(4, 2);
			Assert.AreEqual(16,calculated);
		}

	}
}