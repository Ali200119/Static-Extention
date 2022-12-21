using System;
namespace AtHome.Helpers
{
	public static class Extentions
	{
		public static int Factorial(this int number)
		{
			int factorial = 1;

			for (int i = 1; i <= number; i++)
			{
				factorial *= i;
			}

			return factorial;
		}

		public static int Power(this int number, int power)
		{
			int result = 1;

			for (int i = 0; i < power; i++)
			{
				result *= number;
			}

			return result;
		}
	}
}

