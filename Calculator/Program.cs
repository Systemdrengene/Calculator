using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
	public class calculator
	{
		static void Main(string[] args)
		{
			calculator cal = new calculator();

			double a = 10;
			double b = 5;

			double result;

			result = cal.Add(a, b);
			Console.WriteLine("Add result: " + result);

			result = cal.Subtract(a, b);
			Console.WriteLine("Subtract result: " + result);

			result = cal.Multiply(a, b);
			Console.WriteLine("Multiply result: " + result);

			result = cal.Power(a, b);
			Console.WriteLine("Power result: " + result);

		}


		public double Add(double a, double b)
		{
			return a + b;
		}

		public double Subtract(double a, double b)
		{
			return a - b;
		}

		public double Multiply(double a, double b)
		{
			return a * b;
		}

		public double Power(double x, double exp)
		{
			return Math.Pow(x, exp);
		}

		double AccSum;
		public double Accumulator { get { return AccSum; } private set { AccSum += value; } }

		public double Add(double addend)
        {
			return Accumulator = Accumulator + addend;
        }
		public double Subtract(double subtractor)
		{
			return Accumulator = Accumulator - subtractor;
		}
		public double Multiply(double multiplier)
		{
			return Accumulator = Accumulator * multiplier;
		}
		public double Divide(double divisor)
		{
			if (divisor == 0)
			{
				Console.WriteLine("Divisor cant be 0\n");
				return -1;
			}
			return Accumulator = Accumulator / divisor;
		}
		public double Power(double exponent)
		{
			return Accumulator = Math.Pow(Accumulator,exponent);
		}

	}

}
