using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.AnimationKeyFormat", "Engine", UnrealModuleType.Engine)]
public enum EAnimationKeyFormat
{
	AKF_ConstantKeyLerp,
	AKF_VariableKeyLerp,
	AKF_PerTrackCompression
}
