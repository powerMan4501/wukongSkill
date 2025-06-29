using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum EClassFlags : uint
{
	None = 0u,
	Abstract = 1u,
	DefaultConfig = 2u,
	Config = 4u,
	Transient = 8u,
	Parsed = 0x10u,
	MatchedSerializers = 0x20u,
	AdvancedDisplay = 0x40u,
	Native = 0x80u,
	NoExport = 0x100u,
	NotPlaceable = 0x200u,
	PerObjectConfig = 0x400u,
	ReplicationDataIsSetUp = 0x800u,
	EditInlineNew = 0x1000u,
	CollapseCategories = 0x2000u,
	Interface = 0x4000u,
	CustomConstructor = 0x8000u,
	Const = 0x10000u,
	LayoutChanging = 0x20000u,
	CompiledFromBlueprint = 0x40000u,
	MinimalAPI = 0x80000u,
	RequiredAPI = 0x100000u,
	DefaultToInstanced = 0x200000u,
	TokenStreamAssembled = 0x400000u,
	HasInstancedReference = 0x800000u,
	Hidden = 0x1000000u,
	Deprecated = 0x2000000u,
	HideDropDown = 0x4000000u,
	GlobalUserConfig = 0x8000000u,
	Intrinsic = 0x10000000u,
	Constructed = 0x20000000u,
	ConfigDoNotCheckDefaults = 0x40000000u,
	NewerVersionExists = 0x80000000u,
	Inherit = 0x4AA1060Eu,
	RecompilerClear = 0x5AE1078Fu,
	ShouldNeverBeLoaded = 0x10400080u,
	ScriptInherit = 0x4AA1360Eu,
	SaveInCompiledInClasses = 0x5FB976EFu,
	AllFlags = uint.MaxValue
}
