using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.EConstraintOffsetOption", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EConstraintOffsetOption
{
	None,
	Offset_RefPose
}
