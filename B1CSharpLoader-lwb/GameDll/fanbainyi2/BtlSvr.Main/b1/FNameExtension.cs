using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public static class FNameExtension
{
	public static Dictionary<string, FName> FNameMap = new Dictionary<string, FName>();

	public static FName ToFName(this string Str)
	{
		if (!FNameMap.TryGetValue(Str, out var value))
		{
			value = new FName(Str);
			FNameMap[Str] = value;
		}
		return value;
	}

	public static bool EqualTo(this FName Tag, FGameplayTag OtherTag)
	{
		return Tag == OtherTag.TagName;
	}

	public static bool NotEqualTo(this FName Tag, FGameplayTag OtherTag)
	{
		return Tag != OtherTag.TagName;
	}

	public static bool EqualTo(this FName Tag, FName OtherTag)
	{
		return Tag == OtherTag;
	}

	public static bool NotEqualTo(this FName Tag, FName OtherTag)
	{
		return Tag != OtherTag;
	}

	public static bool EqualTo(this FName Tag, string OtherStr)
	{
		return Tag == ToFName(OtherStr);
	}

	public static bool NotEqualTo(this FName Tag, string OtherStr)
	{
		return Tag != ToFName(OtherStr);
	}
}
