using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum ClassFlags : ulong
{
	DefaultConfig = 2uL,
	AdvancedDisplay = 0x40uL,
	PerObjectConfig = 0x400uL,
	Const = 0x10000uL,
	DefaultToInstanced = 0x200000uL,
	Hidden = 0x1000000uL,
	HideDropDown = 0x4000000uL,
	GlobalUserConfig = 0x8000000uL,
	ConfigDoNotCheckDefaults = 0x40000000uL
}
