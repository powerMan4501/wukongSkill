using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.ERefPoseType", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ERefPoseType
{
	EIT_LocalSpace,
	EIT_Additive
}
