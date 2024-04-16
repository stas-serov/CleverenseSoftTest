using System;
using System.Collections.Generic;
using System.Text;

namespace CleverenseSoftTest
{
	public static class StringCompressor
	{
		public static string Compress(string str)
		{
			if (str.Length < 2)
			{
				return str;
			}
			StringBuilder sb = new StringBuilder();
			int left = 0;
			int right = 1;
			while (right <= str.Length)
			{
				if (right < str.Length && str[left] == str[right])
				{
					right++;
				}
				else
				{
					int count = right - left;
					sb.Append(str[left]);
					if (count > 1)
					{
						InsertCharsCount(sb, count);
					}
					left = right++;
				}
			}
			return sb.ToString();
		}
		private static void InsertCharsCount(StringBuilder sb, int charsCount)
		{
			Stack<char> countChars = new Stack<char>();
			while (charsCount > 0)
			{
				countChars.Push((char)('0' + charsCount % 10));
				charsCount /= 10;
			}
			while (countChars.Count > 0)
			{
				sb.Append(countChars.Pop());
			}
		}
		public static string Decompress(string str)
		{
			if (str.Length < 2)
			{
				return str;
			}
			StringBuilder sb = new StringBuilder();
			int left = 0;
			int right = 0;
			string tmpStr;
			while (right < str.Length)
			{
				tmpStr = str.Substring(left, 1);
				left = ++right;
				while (right < str.Length && char.IsDigit(str[right]))
				{
					right++;
				}
				sb.Append(tmpStr);
				if (right - left > 0)
				{
					int count = Convert.ToInt32(str.Substring(left, right - left));
					count--;
					while (count > 0)
					{
						sb.Append(tmpStr);
						count--;
					}
				}
				left = right;
			}
			return sb.ToString();
		}
	}
}
