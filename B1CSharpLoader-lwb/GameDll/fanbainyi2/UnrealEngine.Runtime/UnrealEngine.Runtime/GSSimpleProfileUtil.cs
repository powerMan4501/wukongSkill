using System.Collections.Generic;
using System.Diagnostics;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class GSSimpleProfileUtil
{
	private static Dictionary<string, int> ProfileIdDic = new Dictionary<string, int>();

	[Conditional("DEBUG")]
	public static void ProfileBegin(string Name)
	{
		if (!ProfileIdDic.TryGetValue(Name, out var value))
		{
			value = Native_TStatId.CreateStatID(Name);
		}
		Native_TStatId.BeginSampleWithStatID(value);
	}

	[Conditional("DEBUG")]
	public static void ProfileEnd()
	{
		Native_TStatId.EndSample();
	}
}
