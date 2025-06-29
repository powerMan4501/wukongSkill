using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EBGUUnitState")]
public enum EBGUUnitState : byte
{
	None,
	Attacking,
	AttackMoving,
	AttackRotation,
	Beatback,
	InComboWindow,
	Dead,
	SideWalking,
	Sprinting,
	Walking,
	AtkComboKeyCache,
	DodgeComboKeyCache,
	MagicKeyCache,
	InDodgeWindow,
	InMagicWindow,
	HRCounterattacking,
	ShooterMode,
	BMMoveAttack,
	AttackAlignUpperBodyToSlope,
	AttackAlignWholeBodyToSlope,
	JumpMoving,
	FloatingHit,
	GlideMoving,
	InMoveWindow,
	BlockBeatBack,
	PerfectBlockBeatBack,
	BlockBounced,
	FreezeAccProtect,
	ImpactActionPlaying,
	BlindStiff,
	Teleporting,
	InAbortWindow,
	InAnimationSyncDeathWindow,
	JumpWindow,
	PhasePerformance,
	LifeSavingHair_FakeDead,
	LifeSavingHair_Rebirth,
	VigorKeyCache,
	InVigorWindow,
	ItemSkillKeyCache,
	InItemSkillWindow,
	LifeSavingHairBlocking,
	InInteractWindow,
	InCloudWindow,
	InChapterClearWorkFlow,
	EnumMax
}
