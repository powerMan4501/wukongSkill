using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ERecomputeUVsPropertiesIslandMode", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ERecomputeUVsPropertiesIslandMode
{
	PolyGroups,
	ExistingUVs
}
