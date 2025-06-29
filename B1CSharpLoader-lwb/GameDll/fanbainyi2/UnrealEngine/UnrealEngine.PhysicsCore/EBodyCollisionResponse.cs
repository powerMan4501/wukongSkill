using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UEnum]
[UMetaPath("/Script/PhysicsCore.EBodyCollisionResponse", "PhysicsCore", UnrealModuleType.Engine)]
public enum EBodyCollisionResponse
{
	BodyCollision_Enabled,
	BodyCollision_Disabled
}
