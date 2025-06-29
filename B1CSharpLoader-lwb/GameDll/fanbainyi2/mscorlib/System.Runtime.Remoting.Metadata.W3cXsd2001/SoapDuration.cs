using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[ComVisible(true)]
public sealed class SoapDuration
{
	public static string XsdType => "duration";

	private static void CarryOver(int inDays, out int years, out int months, out int days)
	{
		years = inDays / 360;
		int num = years * 360;
		months = Math.Max(0, inDays - num) / 30;
		int num2 = months * 30;
		days = Math.Max(0, inDays - (num + num2));
		days = inDays % 30;
	}

	[SecuritySafeCritical]
	public static string ToString(TimeSpan timeSpan)
	{
		StringBuilder stringBuilder = new StringBuilder(10);
		stringBuilder.Length = 0;
		if (TimeSpan.Compare(timeSpan, TimeSpan.Zero) < 1)
		{
			stringBuilder.Append('-');
		}
		int years = 0;
		int months = 0;
		int days = 0;
		CarryOver(Math.Abs(timeSpan.Days), out years, out months, out days);
		stringBuilder.Append('P');
		stringBuilder.Append(years);
		stringBuilder.Append('Y');
		stringBuilder.Append(months);
		stringBuilder.Append('M');
		stringBuilder.Append(days);
		stringBuilder.Append("DT");
		stringBuilder.Append(Math.Abs(timeSpan.Hours));
		stringBuilder.Append('H');
		stringBuilder.Append(Math.Abs(timeSpan.Minutes));
		stringBuilder.Append('M');
		stringBuilder.Append(Math.Abs(timeSpan.Seconds));
		long num = Math.Abs(timeSpan.Ticks % 864000000000L);
		int num2 = (int)(num % 10000000);
		if (num2 != 0)
		{
			string value = ParseNumbers.IntToString(num2, 10, 7, '0', 0);
			stringBuilder.Append('.');
			stringBuilder.Append(value);
		}
		stringBuilder.Append('S');
		return stringBuilder.ToString();
	}

	public static TimeSpan Parse(string value)
	{
		int num = 1;
		try
		{
			if (value == null)
			{
				return TimeSpan.Zero;
			}
			if (value[0] == '-')
			{
				num = -1;
			}
			char[] array = value.ToCharArray();
			int[] array2 = new int[7];
			string s = "0";
			string s2 = "0";
			string s3 = "0";
			string s4 = "0";
			string s5 = "0";
			string text = "0";
			string text2 = "0";
			bool flag = false;
			bool flag2 = false;
			int num2 = 0;
			for (int i = 0; i < array.Length; i++)
			{
				switch (array[i])
				{
				case 'P':
					num2 = i + 1;
					break;
				case 'Y':
					s = new string(array, num2, i - num2);
					num2 = i + 1;
					break;
				case 'M':
					if (flag)
					{
						s5 = new string(array, num2, i - num2);
					}
					else
					{
						s2 = new string(array, num2, i - num2);
					}
					num2 = i + 1;
					break;
				case 'D':
					s3 = new string(array, num2, i - num2);
					num2 = i + 1;
					break;
				case 'T':
					flag = true;
					num2 = i + 1;
					break;
				case 'H':
					s4 = new string(array, num2, i - num2);
					num2 = i + 1;
					break;
				case '.':
					flag2 = true;
					text = new string(array, num2, i - num2);
					num2 = i + 1;
					break;
				case 'S':
					if (!flag2)
					{
						text = new string(array, num2, i - num2);
					}
					else
					{
						text2 = new string(array, num2, i - num2);
					}
					break;
				}
			}
			long ticks = num * ((long.Parse(s, CultureInfo.InvariantCulture) * 360 + long.Parse(s2, CultureInfo.InvariantCulture) * 30 + long.Parse(s3, CultureInfo.InvariantCulture)) * 864000000000L + long.Parse(s4, CultureInfo.InvariantCulture) * 36000000000L + long.Parse(s5, CultureInfo.InvariantCulture) * 600000000 + Convert.ToInt64(double.Parse(text + "." + text2, CultureInfo.InvariantCulture) * 10000000.0));
			return new TimeSpan(ticks);
		}
		catch (Exception)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid"), "xsd:duration", value));
		}
	}
}
