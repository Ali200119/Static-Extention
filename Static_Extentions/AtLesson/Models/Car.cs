using System;
namespace AtLesson.Models
{
	public class Car
	{
		public static int Speed { get; set; } = 400;

		public static int Sum()
		{
			return 7;
		}

		public Car()
		{
			Console.WriteLine("Constructor");
		}

		static Car()
		{
			Console.WriteLine("Static constructor");
		}
	}
}