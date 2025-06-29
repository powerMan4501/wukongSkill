using System;

namespace UnrealEngine.Runtime;

public static class YieldInstructionExtensions
{
	public static T KeepAlive<T>(this T instruction) where T : YieldInstruction
	{
		if (!instruction.IsPooled)
		{
			throw new InvalidOperationException("Cannot call KeepAlive on a non pooled instruction");
		}
		instruction.keepAlive = true;
		return instruction;
	}
}
