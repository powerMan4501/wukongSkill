using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[UMetaPath("/Script/HairStrandsCore.EGroomCacheType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomCacheType
{
	None,
	Strands,
	Guides
}
