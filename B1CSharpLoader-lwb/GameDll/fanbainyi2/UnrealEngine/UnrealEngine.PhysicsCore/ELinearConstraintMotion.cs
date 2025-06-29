using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UEnum]
[UMetaPath("/Script/PhysicsCore.ELinearConstraintMotion", "PhysicsCore", UnrealModuleType.Engine)]
public enum ELinearConstraintMotion
{
	LCM_Free,
	LCM_Limited,
	LCM_Locked
}
