using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UEnum]
[UMetaPath("/Script/PhysicsCore.EAngularConstraintMotion", "PhysicsCore", UnrealModuleType.Engine)]
public enum EAngularConstraintMotion
{
	ACM_Free,
	ACM_Limited,
	ACM_Locked
}
