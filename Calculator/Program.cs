﻿using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
	public class calculator
	{
		public calculator()
		{
			Accumulator = 0;
		}

		static void Main(string[] args)
		{
			calculator cal = new calculator();

			double a = 10;
			double b = 5;

			double result;
			double resultDivide;

			result = cal.Add(a, b);
			Console.WriteLine("Add result: " + result);

			result = cal.Subtract(a, b);
			Console.WriteLine("Subtract result: " + result);

			result = cal.Multiply(a, b);
			Console.WriteLine("Multiply result: " + result);

			result = cal.Power(a, b);
			Console.WriteLine("Power result: " + result);

			resultDivide = cal.Divide(a, b);
			Console.WriteLine("Divide result: " + resultDivide);

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
            double result;
            result = Math.Pow(x, exp);

			if (Double.IsNaN(result))
                throw new ArithmeticException();

            return result;

        }
		
		public double Accumulator { get; private set; }

		public double Clear()
        {
			return Accumulator = 0;
        }

		public double Divide(double dividend, double divisor)
		{

			double result = dividend / divisor;

			if (Double.IsInfinity(result))
			{
				throw new DivideByZeroException();
			}
			else
			{
				return result;
			}

		}

		public double Add(double addend)
        {
			return Accumulator += addend;
        }
		public double Subtract(double subtractor)
		{
			return Accumulator -= subtractor;
		}
		public double Multiply(double multiplier)
		{
			return Accumulator *= multiplier;
		}
		public double Divide(double divisor)
		{
			if (divisor == 0)
			{
				Console.WriteLine("Divisor cant be 0\n");
				throw new DivideByZeroException();
			}
			return Accumulator /= divisor;
		}
		public double Power(double exponent)
		{
			Accumulator = Math.Pow(Accumulator, exponent);
			if (Double.IsNaN(Accumulator))
				throw new ArithmeticException();

			return Accumulator;
		}

	}

}
