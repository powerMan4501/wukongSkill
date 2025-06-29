using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EHairCardsGenerationType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EHairCardsGenerationType : byte
{
	CardsCount,
	UseGuides
}
