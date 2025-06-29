using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EHairCardsClusterType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EHairCardsClusterType : byte
{
	Low,
	High
}
