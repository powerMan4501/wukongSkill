using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum ERenameFlags : uint
{
	None = 0u,
	ForceNoResetLoaders = 1u,
	Test = 2u,
	DoNotDirty = 4u,
	DontCreateRedirectors = 0x10u,
	NonTransactional = 0x20u,
	ForceGlobalUnique = 0x40u,
	SkipGeneratedClasses = 0x80u
}
