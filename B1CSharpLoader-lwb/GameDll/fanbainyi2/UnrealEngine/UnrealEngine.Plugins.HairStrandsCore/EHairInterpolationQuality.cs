using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[UMetaPath("/Script/HairStrandsCore.EHairInterpolationQuality", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EHairInterpolationQuality
{
	Low,
	Medium,
	High,
	Unknown
}
