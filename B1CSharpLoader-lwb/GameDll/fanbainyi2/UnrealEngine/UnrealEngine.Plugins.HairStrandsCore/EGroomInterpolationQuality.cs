using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[UMetaPath("/Script/HairStrandsCore.EGroomInterpolationQuality", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomInterpolationQuality
{
	Low,
	Medium,
	High,
	Unknown
}
