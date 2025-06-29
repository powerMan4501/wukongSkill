using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ERecomputeUVsPropertiesUnwrapType", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ERecomputeUVsPropertiesUnwrapType
{
	ExpMap,
	Conformal,
	IslandMerging
}
