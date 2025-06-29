using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.MontageBindReason")]
public enum EMontageBindReason : byte
{
	Default,
	NormalSkill,
	MagicallyChange,
	ChargeSkill,
	ManualSplineMove,
	FollowPartnerIdleDodge,
	FollowPartnerIdleWaiting,
	Patrol,
	SummonBehavior,
	Born,
	LifeSavingHairPrepare,
	LifeSavingHair,
	EngageSkill,
	InteractCricket,
	Interact
}
