using System;

namespace UnrealEngine.Runtime;

public struct FDefaultBitArrayAllocator
{
	public unsafe fixed int InlineData[4];

	public IntPtr SecondaryData;
}
