namespace System.Net;

internal struct ShellExpression
{
	private enum ShExpTokens
	{
		Asterisk = -1,
		Question = -2,
		AugmentedDot = -3,
		AugmentedAsterisk = -4,
		AugmentedQuestion = -5,
		Start = -6,
		End = -7
	}

	private ShExpTokens[] pattern;

	private int[] match;

	internal ShellExpression(string pattern)
	{
		this.pattern = null;
		match = null;
		Parse(pattern);
	}

	internal bool IsMatch(string target)
	{
		int num = 0;
		int num2 = 0;
		bool flag = false;
		bool result = false;
		while (true)
		{
			if (!flag)
			{
				if (num2 > target.Length)
				{
					break;
				}
				switch (pattern[num])
				{
				case ShExpTokens.Asterisk:
					num2 = (match[num++] = target.Length);
					continue;
				case ShExpTokens.Question:
					if (num2 == target.Length)
					{
						flag = true;
					}
					else
					{
						num2 = (match[num++] = num2 + 1);
					}
					continue;
				case ShExpTokens.AugmentedDot:
					if (num2 == target.Length)
					{
						match[num++] = num2;
					}
					else if (target[num2] == '.')
					{
						num2 = (match[num++] = num2 + 1);
					}
					else
					{
						flag = true;
					}
					continue;
				case ShExpTokens.AugmentedAsterisk:
					if (num2 == target.Length || target[num2] == '.')
					{
						flag = true;
					}
					else
					{
						num2 = (match[num++] = num2 + 1);
					}
					continue;
				case ShExpTokens.AugmentedQuestion:
					if (num2 == target.Length || target[num2] == '.')
					{
						match[num++] = num2;
					}
					else
					{
						num2 = (match[num++] = num2 + 1);
					}
					continue;
				case ShExpTokens.Start:
					if (num2 == 0)
					{
						match[num++] = 0;
						continue;
					}
					break;
				case ShExpTokens.End:
					if (num2 == target.Length)
					{
						result = true;
						break;
					}
					flag = true;
					continue;
				default:
					if (num2 < target.Length && pattern[num] == (ShExpTokens)char.ToLowerInvariant(target[num2]))
					{
						num2 = (match[num++] = num2 + 1);
					}
					else
					{
						flag = true;
					}
					continue;
				}
				break;
			}
			switch (pattern[--num])
			{
			default:
				continue;
			case ShExpTokens.AugmentedQuestion:
			case ShExpTokens.Asterisk:
				if (match[num] != match[num - 1])
				{
					num2 = --match[num++];
					flag = false;
				}
				continue;
			case ShExpTokens.End:
			case ShExpTokens.Start:
				break;
			}
			break;
		}
		return result;
	}

	private void Parse(string patString)
	{
		pattern = new ShExpTokens[patString.Length + 2];
		match = null;
		int num = 0;
		pattern[num++] = ShExpTokens.Start;
		for (int i = 0; i < patString.Length; i++)
		{
			switch (patString[i])
			{
			case '?':
				pattern[num++] = ShExpTokens.Question;
				break;
			case '*':
				pattern[num++] = ShExpTokens.Asterisk;
				break;
			case '^':
				if (i < patString.Length - 1)
				{
					i++;
					switch (patString[i])
					{
					case '.':
						pattern[num++] = ShExpTokens.AugmentedDot;
						break;
					case '?':
						pattern[num++] = ShExpTokens.AugmentedQuestion;
						break;
					case '*':
						pattern[num++] = ShExpTokens.AugmentedAsterisk;
						break;
					default:
						pattern = null;
						if (Logging.On)
						{
							Logging.PrintWarning(Logging.Web, SR.GetString("net_log_shell_expression_pattern_format_warning", patString));
						}
						throw new FormatException(SR.GetString("net_format_shexp", patString));
					}
					break;
				}
				pattern = null;
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.Web, SR.GetString("net_log_shell_expression_pattern_format_warning", patString));
				}
				throw new FormatException(SR.GetString("net_format_shexp", patString));
			default:
				pattern[num++] = (ShExpTokens)char.ToLowerInvariant(patString[i]);
				break;
			}
		}
		pattern[num++] = ShExpTokens.End;
		match = new int[num];
	}
}
