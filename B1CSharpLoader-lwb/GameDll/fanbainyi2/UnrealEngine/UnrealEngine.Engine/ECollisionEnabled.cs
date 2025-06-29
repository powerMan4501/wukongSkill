using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ECollisionEnabled", "Engine", UnrealModuleType.Engine)]
public enum ECollisionEnabled : byte
{
	NoCollision,
	QueryOnly,
	PhysicsOnly,
	QueryAndPhysics
}
