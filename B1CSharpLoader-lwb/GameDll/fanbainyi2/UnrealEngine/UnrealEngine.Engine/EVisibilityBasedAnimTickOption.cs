using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EVisibilityBasedAnimTickOption", "Engine", UnrealModuleType.Engine)]
public enum EVisibilityBasedAnimTickOption : byte
{
	AlwaysTickPoseAndRefreshBones,
	AlwaysTickPose,
	OnlyTickMontagesWhenNotRendered,
	OnlyTickPoseWhenRendered
}
