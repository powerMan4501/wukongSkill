using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MovePhysicsRotationType")]
public enum EMovePhysicsRotationType : byte
{
	None,
	FollowVelocityXYPlane,
	FollowVelocity
}
