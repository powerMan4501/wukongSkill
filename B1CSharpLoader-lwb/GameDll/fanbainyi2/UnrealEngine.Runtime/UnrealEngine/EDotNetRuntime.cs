using System;

namespace UnrealEngine;

[Flags]
public enum EDotNetRuntime
{
	None = 0,
	CLR = 1,
	Mono = 2,
	CoreCLR = 4,
	IL2CPP = 8
}
