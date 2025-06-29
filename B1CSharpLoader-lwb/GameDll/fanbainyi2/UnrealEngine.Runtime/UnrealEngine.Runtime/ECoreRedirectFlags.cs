using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum ECoreRedirectFlags
{
	None = 0,
	Object = 1,
	Class = 2,
	Struct = 4,
	Enum = 8,
	Function = 0x10,
	Property = 0x20,
	Package = 0x40,
	InstanceOnly = 0x10000,
	Removed = 0x20000,
	MatchSubstring = 0x20001
}
