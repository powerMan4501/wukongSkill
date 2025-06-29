using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum PropFlags : ulong
{
	None = 0uL,
	Export = 8uL,
	EditFixedSize = 0x40uL,
	Transient = 0x2000uL,
	Config = 0x4000uL,
	GlobalConfig = 0x44000uL,
	DuplicateTransient = 0x200000uL,
	SaveGame = 0x1000000uL,
	NoClear = 0x2000000uL,
	BlueprintAssignable = 0x10000000uL,
	Interp = 0x200000005uL,
	NonTransactional = 0x400000000uL,
	AssetRegistrySearchable = 0x10000000000uL,
	SimpleDisplay = 0x20000000000uL,
	AdvancedDisplay = 0x40000000000uL,
	BlueprintCallable = 0x100000000000uL,
	BlueprintAuthorityOnly = 0x200000000000uL,
	TextExportTransient = 0x400000000000uL,
	NonPIEDuplicateTransient = 0x800000000000uL,
	SkipSerialization = 0x80000000000000uL,
	Instanced = 0x2000000080008uL
}
