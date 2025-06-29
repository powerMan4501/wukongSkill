using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UEnum]
[UMetaPath("/Script/PhysicsCore.EConstraintPlasticityType", "PhysicsCore", UnrealModuleType.Engine)]
public enum EConstraintPlasticityType
{
	CCPT_Free,
	CCPT_Shrink,
	CCPT_Grow
}
