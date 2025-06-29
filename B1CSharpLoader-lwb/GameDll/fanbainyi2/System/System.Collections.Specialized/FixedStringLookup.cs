using System.Globalization;

namespace System.Collections.Specialized;

internal static class FixedStringLookup
{
	internal static bool Contains(string[][] lookupTable, string value, bool ignoreCase)
	{
		int length = value.Length;
		if (length <= 0 || length - 1 >= lookupTable.Length)
		{
			return false;
		}
		string[] array = lookupTable[length - 1];
		if (array == null)
		{
			return false;
		}
		return Contains(array, value, ignoreCase);
	}

	private static bool Contains(string[] array, string value, bool ignoreCase)
	{
		int min = 0;
		int max = array.Length;
		int num = 0;
		while (num < value.Length)
		{
			char c = ((!ignoreCase) ? value[num] : char.ToLower(value[num], CultureInfo.InvariantCulture));
			if (max - min <= 1)
			{
				if (c != array[min][num])
				{
					return false;
				}
				num++;
			}
			else
			{
				if (!FindCharacter(array, c, num, ref min, ref max))
				{
					return false;
				}
				num++;
			}
		}
		return true;
	}

	private static bool FindCharacter(string[] array, char value, int pos, ref int min, ref int max)
	{
		int num = min;
		while (min < max)
		{
			num = (min + max) / 2;
			char c = array[num][pos];
			if (value == c)
			{
				int num2 = num;
				while (num2 > min && array[num2 - 1][pos] == value)
				{
					num2--;
				}
				min = num2;
				int i;
				for (i = num + 1; i < max && array[i][pos] == value; i++)
				{
				}
				max = i;
				return true;
			}
			if (value < c)
			{
				max = num;
			}
			else
			{
				min = num + 1;
			}
		}
		return false;
	}
}
