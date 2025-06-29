using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum EPackageFlags : uint
{
	None = 0u,
	NewlyCreated = 1u,
	ClientOptional = 2u,
	ServerSideOnly = 4u,
	CompiledIn = 0x10u,
	ForDiffing = 0x20u,
	EditorOnly = 0x40u,
	Developer = 0x80u,
	Need = 0x8000u,
	Compiling = 0x10000u,
	ContainsMap = 0x20000u,
	RequiresLocalizationGather = 0x40000u,
	DisallowLazyLoading = 0x80000u,
	PlayInEditor = 0x100000u,
	ContainsScript = 0x200000u,
	StoreCompressed = 0x2000000u,
	StoreFullyCompressed = 0x4000000u,
	ReloadingForCooker = 0x40000000u,
	FilterEditorOnly = 0x80000000u
}
