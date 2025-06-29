using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UEnum]
[UMetaPath("/Script/PhysicsCore.EPhysicsType", "PhysicsCore", UnrealModuleType.Engine)]
public enum EPhysicsType
{
	PhysType_Default,
	PhysType_Kinematic,
	PhysType_Simulated
}
