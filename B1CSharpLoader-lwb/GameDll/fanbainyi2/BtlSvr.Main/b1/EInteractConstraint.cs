using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.InteractConstraint")]
public enum EInteractConstraint : byte
{
	None,
	TransForming,
	BossRush,
	NotFocusEnough,
	Busy,
	OtherIsUsing,
	EnemyAround,
	CD,
	Dead,
	NpcHide,
	ConfigMiss,
	ItemRequireCondition,
	Restriction,
	SplineMoving,
	Interacting,
	CricketIdle,
	Other
}
