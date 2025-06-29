using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EBGUBulletDestroyReason")]
public enum EBGUBulletDestroyReason : byte
{
	None,
	HitItemDestroy,
	HitCharacterDestroy,
	TimeOutDestroy,
	SpeedLowDestroy,
	FlyBackDestroy,
	FarthestDistOutDestroy,
	EffectDestroy,
	AttachedParentNotValid,
	LevelSequenceDestroy
}
