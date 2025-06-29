using System;
using System.Globalization;

namespace UnrealEngine.Runtime;

public static class StringParseHelper
{
	public static float SafeFloatParse(string Str, bool IsNeedCatch = true)
	{
		if (!IsNeedCatch)
		{
			return float.Parse(Str, NumberStyles.Any, CultureInfo.InvariantCulture);
		}
		try
		{
			return float.Parse(Str, NumberStyles.Any, CultureInfo.InvariantCulture);
		}
		catch (Exception arg)
		{
			FMessage.Log(ELogVerbosity.Error, $"[StringParseHelper] SafeFloatParse {arg}");
		}
		return 0f;
	}

	public static double SafeDoubleParse(string Str, bool IsNeedCatch = true)
	{
		if (!IsNeedCatch)
		{
			return double.Parse(Str, NumberStyles.Any, CultureInfo.InvariantCulture);
		}
		try
		{
			return double.Parse(Str, NumberStyles.Any, CultureInfo.InvariantCulture);
		}
		catch (Exception arg)
		{
			FMessage.Log(ELogVerbosity.Error, $"[StringParseHelper] SafeDoubleParse {arg}");
		}
		return 0.0;
	}

	public static bool SafeTryFloatParse(string Str, out float Ret, bool IsNeedCatch = true)
	{
		if (!IsNeedCatch)
		{
			return float.TryParse(Str, NumberStyles.Any, CultureInfo.InvariantCulture, out Ret);
		}
		try
		{
			return float.TryParse(Str, NumberStyles.Any, CultureInfo.InvariantCulture, out Ret);
		}
		catch (Exception arg)
		{
			FMessage.Log(ELogVerbosity.Error, $"[StringParseHelper] SafeTryFloatParse {arg}");
			Ret = 0f;
			return false;
		}
	}

	public static bool SafeTryDoubleParse(string Str, out double Ret, bool IsNeedCatch = true)
	{
		if (!IsNeedCatch)
		{
			return double.TryParse(Str, NumberStyles.Any, CultureInfo.InvariantCulture, out Ret);
		}
		try
		{
			return double.TryParse(Str, NumberStyles.Any, CultureInfo.InvariantCulture, out Ret);
		}
		catch (Exception arg)
		{
			FMessage.Log(ELogVerbosity.Error, $"[StringParseHelper] SafeTryDoubleParse {arg}");
			Ret = 0.0;
			return false;
		}
	}

	public static string SafeToLower(string Str)
	{
		return Str?.ToLowerInvariant();
	}
}
