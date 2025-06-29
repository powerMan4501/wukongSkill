using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.PhysAnimType")]
public enum EPhysAnimType : byte
{
	None,
	Normal,
	BeAttack,
	PhysicBlend,
	BeCatchThrow,
	PhysicsSimulationMove,
	DeathPhysicBlend,
	DATA_MAX,
	Death,
	ThrowUpDeath
}
