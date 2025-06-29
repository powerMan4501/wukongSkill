using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ERecomputeUVsToolOrientationMode", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ERecomputeUVsToolOrientationMode
{
	None,
	MinBounds
}
