using System.Resources;
using Microsoft.Reflection;

namespace System.Diagnostics.Tracing.Internal;

internal static class Environment
{
	public static readonly string NewLine = System.Environment.NewLine;

	private static ResourceManager rm = new ResourceManager("Microsoft.Diagnostics.Tracing.Messages", typeof(Environment).Assembly());

	public static int TickCount => System.Environment.TickCount;

	public static string GetResourceString(string key, params object[] args)
	{
		string text = rm.GetString(key);
		if (text != null)
		{
			return string.Format(text, args);
		}
		string text2 = string.Empty;
		foreach (object obj in args)
		{
			if (text2 != string.Empty)
			{
				text2 += ", ";
			}
			text2 += obj.ToString();
		}
		return key + " (" + text2 + ")";
	}

	public static string GetRuntimeResourceString(string key, params object[] args)
	{
		return GetResourceString(key, args);
	}
}
