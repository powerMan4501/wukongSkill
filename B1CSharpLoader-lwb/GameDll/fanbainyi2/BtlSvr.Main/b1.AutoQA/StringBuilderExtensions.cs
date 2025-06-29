using System;
using System.Text;

namespace b1.AutoQA;

public static class StringBuilderExtensions
{
	public static StringBuilder AppendLine(this StringBuilder sb, int indentLevel, string value)
	{
		if (value == null || value == "")
		{
			return sb;
		}
		string[] array = ((!value.Contains("\r\n")) ? new string[1] { value } : value.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));
		string[] array2 = array;
		foreach (string value2 in array2)
		{
			string value3 = new string('\t', indentLevel);
			sb.Append(value3);
			sb.AppendLine(value2);
		}
		return sb;
	}
}
