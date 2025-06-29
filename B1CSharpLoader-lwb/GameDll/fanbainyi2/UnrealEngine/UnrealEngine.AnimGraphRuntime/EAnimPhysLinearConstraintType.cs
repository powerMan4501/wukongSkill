using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.AnimPhysLinearConstraintType", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EAnimPhysLinearConstraintType
{
	Free,
	Limited
}
