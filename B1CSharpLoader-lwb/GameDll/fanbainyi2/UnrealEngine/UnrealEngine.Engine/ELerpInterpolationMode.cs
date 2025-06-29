using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ELerpInterpolationMode", "Engine", UnrealModuleType.Engine)]
public enum ELerpInterpolationMode : byte
{
	QuatInterp,
	EulerInterp,
	DualQuatInterp
}
