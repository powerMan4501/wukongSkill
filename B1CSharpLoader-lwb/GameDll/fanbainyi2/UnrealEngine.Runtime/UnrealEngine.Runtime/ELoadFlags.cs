using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum ELoadFlags : uint
{
	None = 0u,
	SeekFree = 1u,
	NoWarn = 2u,
	EditorOnly = 4u,
	ResolvingDeferredExports = 8u,
	Verify = 0x10u,
	AllowDll = 0x20u,
	NoVerify = 0x80u,
	IsVerifying = 0x100u,
	DisableDependencyPreloading = 0x1000u,
	Quiet = 0x2000u,
	FindIfFail = 0x4000u,
	MemoryReader = 0x8000u,
	NoRedirects = 0x10000u,
	ForDiff = 0x20000u,
	NoSeekFreeLinkerDetatch = 0x40000u,
	PackageForPIE = 0x80000u,
	DeferDependencyLoads = 0x100000u,
	ForFileDiff = 0x200000u
}
