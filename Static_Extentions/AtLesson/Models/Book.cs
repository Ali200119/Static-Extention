using System;
namespace AtLesson.Models
{
	public class Book
	{
		public string Name { get; set; }
		public static int Count { get; set; } = 0;

		public Book()
		{
			Count++;
		}
	}
}