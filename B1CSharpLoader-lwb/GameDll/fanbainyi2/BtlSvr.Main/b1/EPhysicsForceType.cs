using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.PhysicsForceType")]
public enum EPhysicsForceType : byte
{
	DirectionalForce,
	ExplosiveForce
}
