namespace System.IO;

internal static class PatternMatcher
{
	private const int MATCHES_ARRAY_SIZE = 16;

	private const char ANSI_DOS_STAR = '>';

	private const char ANSI_DOS_QM = '<';

	private const char DOS_DOT = '"';

	public static bool StrictMatchPattern(string expression, string name)
	{
		char c = '\0';
		char c2 = '\0';
		int[] array = new int[16];
		int[] array2 = new int[16];
		bool flag = false;
		if (name == null || name.Length == 0 || expression == null || expression.Length == 0)
		{
			return false;
		}
		if (expression.Equals("*") || expression.Equals("*.*"))
		{
			return true;
		}
		if (expression[0] == '*' && expression.IndexOf('*', 1) == -1)
		{
			int num = expression.Length - 1;
			if (name.Length >= num && string.Compare(expression, 1, name, name.Length - num, num, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
		}
		array[0] = 0;
		int num2 = 1;
		int num3 = 0;
		int num4 = expression.Length * 2;
		int num8;
		while (!flag)
		{
			if (num3 < name.Length)
			{
				c = name[num3];
				int num5 = 1;
				num3++;
			}
			else
			{
				flag = true;
				if (array[num2 - 1] == num4)
				{
					break;
				}
			}
			int i = 0;
			int num6 = 0;
			int j = 0;
			while (i < num2)
			{
				int num7 = (array[i++] + 1) / 2;
				int num5 = 0;
				while (num7 != expression.Length)
				{
					num7 += num5;
					num8 = num7 * 2;
					if (num7 == expression.Length)
					{
						array2[num6++] = num4;
						break;
					}
					c2 = expression[num7];
					num5 = 1;
					if (num6 >= 14)
					{
						int num9 = array2.Length * 2;
						int[] array3 = new int[num9];
						Array.Copy(array2, array3, array2.Length);
						array2 = array3;
						array3 = new int[num9];
						Array.Copy(array, array3, array.Length);
						array = array3;
					}
					switch (c2)
					{
					case '*':
						array2[num6++] = num8;
						array2[num6++] = num8 + 1;
						continue;
					case '>':
					{
						bool flag2 = false;
						if (!flag && c == '.')
						{
							int length = name.Length;
							for (int k = num3; k < length; k++)
							{
								char c3 = name[k];
								num5 = 1;
								if (c3 == '.')
								{
									flag2 = true;
									break;
								}
							}
						}
						if (flag || c != '.' || flag2)
						{
							array2[num6++] = num8;
							array2[num6++] = num8 + 1;
						}
						else
						{
							array2[num6++] = num8 + 1;
						}
						continue;
					}
					}
					num8 += num5 * 2;
					if (c2 == '<')
					{
						if (!flag && c != '.')
						{
							array2[num6++] = num8;
							break;
						}
						continue;
					}
					if (c2 == '"')
					{
						if (flag)
						{
							continue;
						}
						if (c == '.')
						{
							array2[num6++] = num8;
							break;
						}
					}
					if (!flag)
					{
						if (c2 == '?')
						{
							array2[num6++] = num8;
						}
						else if (c2 == c)
						{
							array2[num6++] = num8;
						}
					}
					break;
				}
				if (i >= num2 || j >= num6)
				{
					continue;
				}
				for (; j < num6; j++)
				{
					for (int num10 = array.Length; i < num10 && array[i] < array2[j]; i++)
					{
					}
				}
			}
			if (num6 == 0)
			{
				return false;
			}
			int[] array4 = array;
			array = array2;
			array2 = array4;
			num2 = num6;
		}
		num8 = array[num2 - 1];
		return num8 == num4;
	}
}
