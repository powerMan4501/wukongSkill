using System.Collections.Generic;
using System.Text;

namespace System.Net.Mime;

internal static class MailBnfHelper
{
	internal static bool[] Atext;

	internal static bool[] Qtext;

	internal static bool[] Dtext;

	internal static bool[] Ftext;

	internal static bool[] Ttext;

	internal static bool[] Ctext;

	internal static readonly int Ascii7bitMaxValue;

	internal static readonly char Quote;

	internal static readonly char Space;

	internal static readonly char Tab;

	internal static readonly char CR;

	internal static readonly char LF;

	internal static readonly char StartComment;

	internal static readonly char EndComment;

	internal static readonly char Backslash;

	internal static readonly char At;

	internal static readonly char EndAngleBracket;

	internal static readonly char StartAngleBracket;

	internal static readonly char StartSquareBracket;

	internal static readonly char EndSquareBracket;

	internal static readonly char Comma;

	internal static readonly char Dot;

	internal static readonly IList<char> Whitespace;

	private static string[] s_months;

	static MailBnfHelper()
	{
		Atext = new bool[128];
		Qtext = new bool[128];
		Dtext = new bool[128];
		Ftext = new bool[128];
		Ttext = new bool[128];
		Ctext = new bool[128];
		Ascii7bitMaxValue = 127;
		Quote = '"';
		Space = ' ';
		Tab = '\t';
		CR = '\r';
		LF = '\n';
		StartComment = '(';
		EndComment = ')';
		Backslash = '\\';
		At = '@';
		EndAngleBracket = '>';
		StartAngleBracket = '<';
		StartSquareBracket = '[';
		EndSquareBracket = ']';
		Comma = ',';
		Dot = '.';
		s_months = new string[13]
		{
			null, "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep",
			"Oct", "Nov", "Dec"
		};
		Whitespace = new List<char>();
		Whitespace.Add(Tab);
		Whitespace.Add(Space);
		Whitespace.Add(CR);
		Whitespace.Add(LF);
		for (int i = 48; i <= 57; i++)
		{
			Atext[i] = true;
		}
		for (int j = 65; j <= 90; j++)
		{
			Atext[j] = true;
		}
		for (int k = 97; k <= 122; k++)
		{
			Atext[k] = true;
		}
		Atext[33] = true;
		Atext[35] = true;
		Atext[36] = true;
		Atext[37] = true;
		Atext[38] = true;
		Atext[39] = true;
		Atext[42] = true;
		Atext[43] = true;
		Atext[45] = true;
		Atext[47] = true;
		Atext[61] = true;
		Atext[63] = true;
		Atext[94] = true;
		Atext[95] = true;
		Atext[96] = true;
		Atext[123] = true;
		Atext[124] = true;
		Atext[125] = true;
		Atext[126] = true;
		for (int l = 1; l <= 9; l++)
		{
			Qtext[l] = true;
		}
		Qtext[11] = true;
		Qtext[12] = true;
		for (int m = 14; m <= 33; m++)
		{
			Qtext[m] = true;
		}
		for (int n = 35; n <= 91; n++)
		{
			Qtext[n] = true;
		}
		for (int num = 93; num <= 127; num++)
		{
			Qtext[num] = true;
		}
		for (int num2 = 1; num2 <= 8; num2++)
		{
			Dtext[num2] = true;
		}
		Dtext[11] = true;
		Dtext[12] = true;
		for (int num3 = 14; num3 <= 31; num3++)
		{
			Dtext[num3] = true;
		}
		for (int num4 = 33; num4 <= 90; num4++)
		{
			Dtext[num4] = true;
		}
		for (int num5 = 94; num5 <= 127; num5++)
		{
			Dtext[num5] = true;
		}
		for (int num6 = 33; num6 <= 57; num6++)
		{
			Ftext[num6] = true;
		}
		for (int num7 = 59; num7 <= 126; num7++)
		{
			Ftext[num7] = true;
		}
		for (int num8 = 33; num8 <= 126; num8++)
		{
			Ttext[num8] = true;
		}
		Ttext[40] = false;
		Ttext[41] = false;
		Ttext[60] = false;
		Ttext[62] = false;
		Ttext[64] = false;
		Ttext[44] = false;
		Ttext[59] = false;
		Ttext[58] = false;
		Ttext[92] = false;
		Ttext[34] = false;
		Ttext[47] = false;
		Ttext[91] = false;
		Ttext[93] = false;
		Ttext[63] = false;
		Ttext[61] = false;
		for (int num9 = 1; num9 <= 8; num9++)
		{
			Ctext[num9] = true;
		}
		Ctext[11] = true;
		Ctext[12] = true;
		for (int num10 = 14; num10 <= 31; num10++)
		{
			Ctext[num10] = true;
		}
		for (int num11 = 33; num11 <= 39; num11++)
		{
			Ctext[num11] = true;
		}
		for (int num12 = 42; num12 <= 91; num12++)
		{
			Ctext[num12] = true;
		}
		for (int num13 = 93; num13 <= 127; num13++)
		{
			Ctext[num13] = true;
		}
	}

	internal static bool SkipCFWS(string data, ref int offset)
	{
		int num = 0;
		while (offset < data.Length)
		{
			if (data[offset] > '\u007f')
			{
				throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", data[offset]));
			}
			if (data[offset] == '\\' && num > 0)
			{
				offset += 2;
			}
			else if (data[offset] == '(')
			{
				num++;
			}
			else if (data[offset] == ')')
			{
				num--;
			}
			else if (data[offset] != ' ' && data[offset] != '\t' && num == 0)
			{
				return true;
			}
			if (num < 0)
			{
				throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", data[offset]));
			}
			offset++;
		}
		return false;
	}

	internal static void ValidateHeaderName(string data)
	{
		int i;
		for (i = 0; i < data.Length; i++)
		{
			if (data[i] > Ftext.Length || !Ftext[(uint)data[i]])
			{
				throw new FormatException(SR.GetString("InvalidHeaderName"));
			}
		}
		if (i == 0)
		{
			throw new FormatException(SR.GetString("InvalidHeaderName"));
		}
	}

	internal static string ReadQuotedString(string data, ref int offset, StringBuilder builder)
	{
		return ReadQuotedString(data, ref offset, builder, doesntRequireQuotes: false, permitUnicodeInDisplayName: false);
	}

	internal static string ReadQuotedString(string data, ref int offset, StringBuilder builder, bool doesntRequireQuotes, bool permitUnicodeInDisplayName)
	{
		if (!doesntRequireQuotes)
		{
			offset++;
		}
		int num = offset;
		StringBuilder stringBuilder = ((builder != null) ? builder : new StringBuilder());
		while (offset < data.Length)
		{
			if (data[offset] == '\\')
			{
				stringBuilder.Append(data, num, offset - num);
				num = ++offset;
			}
			else
			{
				if (data[offset] == '"')
				{
					stringBuilder.Append(data, num, offset - num);
					offset++;
					if (builder == null)
					{
						return stringBuilder.ToString();
					}
					return null;
				}
				if (data[offset] == '=' && data.Length > offset + 3 && data[offset + 1] == '\r' && data[offset + 2] == '\n' && (data[offset + 3] == ' ' || data[offset + 3] == '\t'))
				{
					offset += 3;
				}
				else if (permitUnicodeInDisplayName)
				{
					if (data[offset] <= Ascii7bitMaxValue && !Qtext[(uint)data[offset]])
					{
						throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", data[offset]));
					}
				}
				else if (data[offset] > Ascii7bitMaxValue || !Qtext[(uint)data[offset]])
				{
					throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", data[offset]));
				}
			}
			offset++;
		}
		if (doesntRequireQuotes)
		{
			stringBuilder.Append(data, num, offset - num);
			if (builder == null)
			{
				return stringBuilder.ToString();
			}
			return null;
		}
		throw new FormatException(SR.GetString("MailHeaderFieldMalformedHeader"));
	}

	internal static string ReadParameterAttribute(string data, ref int offset, StringBuilder builder)
	{
		if (!SkipCFWS(data, ref offset))
		{
			return null;
		}
		return ReadToken(data, ref offset, null);
	}

	internal static string ReadToken(string data, ref int offset, StringBuilder builder)
	{
		int num = offset;
		while (offset < data.Length)
		{
			if (data[offset] > Ascii7bitMaxValue)
			{
				throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", data[offset]));
			}
			if (!Ttext[(uint)data[offset]])
			{
				break;
			}
			offset++;
		}
		if (num == offset)
		{
			throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", data[offset]));
		}
		return data.Substring(num, offset - num);
	}

	internal static string GetDateTimeString(DateTime value, StringBuilder builder)
	{
		StringBuilder stringBuilder = ((builder != null) ? builder : new StringBuilder());
		stringBuilder.Append(value.Day);
		stringBuilder.Append(' ');
		stringBuilder.Append(s_months[value.Month]);
		stringBuilder.Append(' ');
		stringBuilder.Append(value.Year);
		stringBuilder.Append(' ');
		if (value.Hour <= 9)
		{
			stringBuilder.Append('0');
		}
		stringBuilder.Append(value.Hour);
		stringBuilder.Append(':');
		if (value.Minute <= 9)
		{
			stringBuilder.Append('0');
		}
		stringBuilder.Append(value.Minute);
		stringBuilder.Append(':');
		if (value.Second <= 9)
		{
			stringBuilder.Append('0');
		}
		stringBuilder.Append(value.Second);
		string text = TimeZone.CurrentTimeZone.GetUtcOffset(value).ToString();
		if (text[0] != '-')
		{
			stringBuilder.Append(" +");
		}
		else
		{
			stringBuilder.Append(" ");
		}
		string[] array = text.Split(':');
		stringBuilder.Append(array[0]);
		stringBuilder.Append(array[1]);
		if (builder == null)
		{
			return stringBuilder.ToString();
		}
		return null;
	}

	internal static void GetTokenOrQuotedString(string data, StringBuilder builder, bool allowUnicode)
	{
		int i = 0;
		int num = 0;
		for (; i < data.Length; i++)
		{
			if (CheckForUnicode(data[i], allowUnicode) || (Ttext[(uint)data[i]] && data[i] != ' '))
			{
				continue;
			}
			builder.Append('"');
			for (; i < data.Length; i++)
			{
				if (!CheckForUnicode(data[i], allowUnicode))
				{
					if (IsFWSAt(data, i))
					{
						i++;
						i++;
					}
					else if (!Qtext[(uint)data[i]])
					{
						builder.Append(data, num, i - num);
						builder.Append('\\');
						num = i;
					}
				}
			}
			builder.Append(data, num, i - num);
			builder.Append('"');
			return;
		}
		if (data.Length == 0)
		{
			builder.Append("\"\"");
		}
		builder.Append(data);
	}

	private static bool CheckForUnicode(char ch, bool allowUnicode)
	{
		if (ch < Ascii7bitMaxValue)
		{
			return false;
		}
		if (!allowUnicode)
		{
			throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", ch));
		}
		return true;
	}

	internal static bool HasCROrLF(string data)
	{
		for (int i = 0; i < data.Length; i++)
		{
			if (data[i] == '\r' || data[i] == '\n')
			{
				return true;
			}
		}
		return false;
	}

	internal static bool IsFWSAt(string data, int index)
	{
		if (data[index] == CR && index + 2 < data.Length && data[index + 1] == LF)
		{
			if (data[index + 2] != Space)
			{
				return data[index + 2] == Tab;
			}
			return true;
		}
		return false;
	}
}
