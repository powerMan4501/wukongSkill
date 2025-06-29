using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum ESharedMemoryAccess
{
	Read = 2,
	Write = 4
}
