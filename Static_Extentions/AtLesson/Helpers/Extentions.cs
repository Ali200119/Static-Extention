using System;
using System.Text.RegularExpressions;

namespace AtLesson.Helpers
{
	public static class Extentions
	{
		public static int GetNum(this int number)
		{
			return number;
		}

		public static bool CheckString(this string text, string pattern)
		{
			return Regex.IsMatch(text, pattern);
		}
	}
}