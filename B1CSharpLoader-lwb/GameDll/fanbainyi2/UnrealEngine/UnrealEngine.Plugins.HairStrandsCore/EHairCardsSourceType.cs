using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EHairCardsSourceType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EHairCardsSourceType : byte
{
	Procedural,
	Imported
}
