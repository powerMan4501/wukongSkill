using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EGroomStrandsSize", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomStrandsSize : byte
{
	None = 0,
	Size2 = 2,
	Size4 = 4,
	Size8 = 8,
	Size16 = 0x10,
	Size32 = 0x20
}
