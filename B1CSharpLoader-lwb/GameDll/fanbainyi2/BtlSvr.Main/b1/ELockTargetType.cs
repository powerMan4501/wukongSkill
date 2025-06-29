using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.LockTargetType")]
public enum ELockTargetType : byte
{
	Actor,
	SceneComp,
	SkeletonSocket,
	Point
}
