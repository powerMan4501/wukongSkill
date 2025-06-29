using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.LockTargetWayType")]
public enum ELockTargetWayType : byte
{
	Auto,
	Manual,
	Skill,
	Combo,
	AimOffset,
	MoveTo
}
