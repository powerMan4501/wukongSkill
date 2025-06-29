using System;

namespace UnrealEngine.Runtime;

internal static class YieldPoolExtensions
{
	internal static T PoolNew<T>(this T instruction, TimeSpan time) where T : WaitFor
	{
		instruction.Time = time;
		return instruction;
	}

	internal static T PoolNewTime<T>(this T instruction, TimeSpan time) where T : WaitForRealtime
	{
		instruction.Time = time;
		return instruction;
	}
}
