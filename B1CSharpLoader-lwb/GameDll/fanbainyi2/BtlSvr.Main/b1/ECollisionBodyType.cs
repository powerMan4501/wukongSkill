using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.CollisionBodyType")]
public enum ECollisionBodyType : byte
{
	CollisionBody_CapsuleComp = 1,
	CollisionBody_SkeletalMeshComp
}
