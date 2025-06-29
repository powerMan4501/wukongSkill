using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDepthOfFieldFunctionValue", "Engine", UnrealModuleType.Engine)]
public enum EDepthOfFieldFunctionValue
{
	TDOF_NearAndFarMask,
	TDOF_NearMask,
	TDOF_FarMask,
	TDOF_CircleOfConfusionRadius
}
