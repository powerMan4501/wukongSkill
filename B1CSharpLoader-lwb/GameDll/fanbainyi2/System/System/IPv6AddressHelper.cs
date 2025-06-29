using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Text;

namespace System;

internal static class IPv6AddressHelper
{
	private const int NumberOfLabels = 8;

	private const string LegacyFormat = "{0:X4}:{1:X4}:{2:X4}:{3:X4}:{4:X4}:{5:X4}:{6:X4}:{7:X4}";

	private const string CanonicalNumberFormat = "{0:x}";

	private const string EmbeddedIPv4Format = ":{0:d}.{1:d}.{2:d}.{3:d}";

	private const string Separator = ":";

	internal unsafe static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId)
	{
		ushort* ptr = stackalloc ushort[9];
		*(long*)ptr = 0L;
		((long*)ptr)[1] = 0L;
		isLoopback = Parse(str, ptr, start, ref scopeId);
		return "[" + CreateCanonicalName(ptr) + "]";
	}

	internal unsafe static string CreateCanonicalName(ushort* numbers)
	{
		if (UriParser.ShouldUseLegacyV2Quirks)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0:X4}:{1:X4}:{2:X4}:{3:X4}:{4:X4}:{5:X4}:{6:X4}:{7:X4}", *numbers, numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7]);
		}
		KeyValuePair<int, int> keyValuePair = FindCompressionRange(numbers);
		bool flag = ShouldHaveIpv4Embedded(numbers);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 8; i++)
		{
			if (flag && i == 6)
			{
				stringBuilder.Append(string.Format(CultureInfo.InvariantCulture, ":{0:d}.{1:d}.{2:d}.{3:d}", numbers[i] >> 8, numbers[i] & 0xFF, numbers[i + 1] >> 8, numbers[i + 1] & 0xFF));
				break;
			}
			if (keyValuePair.Key == i)
			{
				stringBuilder.Append(":");
			}
			if (keyValuePair.Key <= i && keyValuePair.Value == 7)
			{
				stringBuilder.Append(":");
				break;
			}
			if (keyValuePair.Key > i || i > keyValuePair.Value)
			{
				if (i != 0)
				{
					stringBuilder.Append(":");
				}
				stringBuilder.Append(string.Format(CultureInfo.InvariantCulture, "{0:x}", new object[1] { numbers[i] }));
			}
		}
		return stringBuilder.ToString();
	}

	private unsafe static KeyValuePair<int, int> FindCompressionRange(ushort* numbers)
	{
		int num = 0;
		int num2 = -1;
		int num3 = 0;
		for (int i = 0; i < 8; i++)
		{
			if (numbers[i] == 0)
			{
				num3++;
				if (num3 > num)
				{
					num = num3;
					num2 = i - num3 + 1;
				}
			}
			else
			{
				num3 = 0;
			}
		}
		if (num >= 2)
		{
			return new KeyValuePair<int, int>(num2, num2 + num - 1);
		}
		return new KeyValuePair<int, int>(-1, -1);
	}

	private unsafe static bool ShouldHaveIpv4Embedded(ushort* numbers)
	{
		if (*numbers == 0 && numbers[1] == 0 && numbers[2] == 0 && numbers[3] == 0 && numbers[6] != 0)
		{
			if (numbers[4] == 0 && (numbers[5] == 0 || numbers[5] == ushort.MaxValue))
			{
				return true;
			}
			if (numbers[4] == ushort.MaxValue && numbers[5] == 0)
			{
				return true;
			}
		}
		if (numbers[4] == 0 && numbers[5] == 24318)
		{
			return true;
		}
		return false;
	}

	private unsafe static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress)
	{
		int num = 0;
		int num2 = 0;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = true;
		int start2 = 1;
		if (name[start] == ':' && (start + 1 >= end || name[start + 1] != ':') && ServicePointManager.UseStrictIPv6AddressParsing)
		{
			return false;
		}
		int i;
		for (i = start; i < end; i++)
		{
			bool num3;
			if (!flag3)
			{
				num3 = Uri.IsHexDigit(name[i]);
			}
			else
			{
				if (name[i] < '0')
				{
					goto IL_0080;
				}
				num3 = name[i] <= '9';
			}
			if (num3)
			{
				num2++;
				flag4 = false;
				continue;
			}
			goto IL_0080;
			IL_0080:
			if (num2 > 4)
			{
				return false;
			}
			if (num2 != 0)
			{
				num++;
				start2 = i - num2;
			}
			char c = name[i];
			if ((uint)c <= 46u)
			{
				if (c == '%')
				{
					while (true)
					{
						if (++i == end)
						{
							return false;
						}
						if (name[i] == ']')
						{
							break;
						}
						if (name[i] != '/')
						{
							continue;
						}
						goto IL_0123;
					}
					goto IL_00f5;
				}
				if (c != '.')
				{
					goto IL_0163;
				}
				if (flag2)
				{
					return false;
				}
				i = end;
				if (!IPv4AddressHelper.IsValid(name, start2, ref i, allowIPv6: true, notImplicitFile: false, unknownScheme: false))
				{
					return false;
				}
				num++;
				flag2 = true;
				i--;
			}
			else
			{
				if (c == '/')
				{
					goto IL_0123;
				}
				if (c != ':')
				{
					if (c == ']')
					{
						goto IL_00f5;
					}
					goto IL_0163;
				}
				if (i > 0 && name[i - 1] == ':')
				{
					if (flag)
					{
						return false;
					}
					flag = true;
					flag4 = false;
				}
				else
				{
					flag4 = true;
				}
			}
			goto IL_0165;
			IL_0163:
			return false;
			IL_0123:
			if (validateStrictAddress)
			{
				return false;
			}
			if (num == 0 || flag3)
			{
				return false;
			}
			flag3 = true;
			flag4 = true;
			goto IL_0165;
			IL_0165:
			num2 = 0;
			continue;
			IL_00f5:
			start = i;
			i = end;
		}
		if (flag3 && (num2 < 1 || num2 > 2))
		{
			return false;
		}
		int num4 = 8 + (flag3 ? 1 : 0);
		if (!flag4 && num2 <= 4 && (flag ? (num < num4) : (num == num4)))
		{
			if (i == end + 1)
			{
				end = start + 1;
				return true;
			}
			return false;
		}
		return false;
	}

	internal unsafe static bool IsValid(char* name, int start, ref int end)
	{
		return InternalIsValid(name, start, ref end, validateStrictAddress: false);
	}

	internal unsafe static bool IsValidStrict(char* name, int start, ref int end)
	{
		return InternalIsValid(name, start, ref end, validateStrictAddress: true);
	}

	internal unsafe static bool Parse(string address, ushort* numbers, int start, ref string scopeId)
	{
		int num = 0;
		int num2 = 0;
		int num3 = -1;
		bool flag = true;
		int num4 = 0;
		if (address[start] == '[')
		{
			start++;
		}
		int i = start;
		while (i < address.Length && address[i] != ']')
		{
			switch (address[i])
			{
			case '%':
				if (flag)
				{
					numbers[num2++] = (ushort)num;
					flag = false;
				}
				start = i;
				for (i++; address[i] != ']' && address[i] != '/'; i++)
				{
				}
				scopeId = address.Substring(start, i - start);
				for (; address[i] != ']'; i++)
				{
				}
				break;
			case ':':
			{
				numbers[num2++] = (ushort)num;
				num = 0;
				i++;
				if (address[i] == ':')
				{
					num3 = num2;
					i++;
				}
				else if (num3 < 0 && num2 < 6)
				{
					break;
				}
				for (int j = i; address[j] != ']' && address[j] != ':' && address[j] != '%' && address[j] != '/' && j < i + 4; j++)
				{
					if (address[j] == '.')
					{
						for (; address[j] != ']' && address[j] != '/' && address[j] != '%'; j++)
						{
						}
						num = IPv4AddressHelper.ParseHostNumber(address, i, j);
						numbers[num2++] = (ushort)(num >> 16);
						numbers[num2++] = (ushort)num;
						i = j;
						num = 0;
						flag = false;
						break;
					}
				}
				break;
			}
			case '/':
				if (flag)
				{
					numbers[num2++] = (ushort)num;
					flag = false;
				}
				for (i++; address[i] != ']'; i++)
				{
					num4 = num4 * 10 + (address[i] - 48);
				}
				break;
			default:
				num = num * 16 + Uri.FromHex(address[i++]);
				break;
			}
		}
		if (flag)
		{
			numbers[num2++] = (ushort)num;
		}
		if (num3 > 0)
		{
			int num5 = 7;
			int num6 = num2 - 1;
			for (int num7 = num2 - num3; num7 > 0; num7--)
			{
				numbers[num5--] = numbers[num6];
				numbers[num6--] = 0;
			}
		}
		if (*numbers == 0 && numbers[1] == 0 && numbers[2] == 0 && numbers[3] == 0 && numbers[4] == 0)
		{
			if (numbers[5] != 0 || numbers[6] != 0 || numbers[7] != 1)
			{
				if (numbers[6] == 32512 && numbers[7] == 1)
				{
					if (numbers[5] != 0)
					{
						return numbers[5] == ushort.MaxValue;
					}
					return true;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[Conditional("DEBUG")]
	private static void ValidateIndex(int index)
	{
		int num = (ServicePointManager.UseStrictIPv6AddressParsing ? 8 : 9);
	}
}
