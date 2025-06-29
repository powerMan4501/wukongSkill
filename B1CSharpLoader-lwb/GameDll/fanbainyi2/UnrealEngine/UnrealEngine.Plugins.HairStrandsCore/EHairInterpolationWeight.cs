using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[UMetaPath("/Script/HairStrandsCore.EHairInterpolationWeight", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EHairInterpolationWeight
{
	Parametric,
	Root,
	Index,
	Unknown
}
