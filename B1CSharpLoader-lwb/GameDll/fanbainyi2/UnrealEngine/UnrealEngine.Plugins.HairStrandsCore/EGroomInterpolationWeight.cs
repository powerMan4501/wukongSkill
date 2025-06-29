using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[UMetaPath("/Script/HairStrandsCore.EGroomInterpolationWeight", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomInterpolationWeight
{
	Parametric,
	Root,
	Index,
	Unknown
}
