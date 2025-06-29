using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGsEnAnimNS", "b1", UnrealModuleType.Game)]
public enum EGsEnAnimNS : byte
{
	None,
	AttackState,
	AttackRotation,
	SweepCheck,
	ComboWindow,
	EditorHelper,
	DevLineHit,
	AddState,
	AddBuff,
	SlowTime,
	CalcAMScale,
	CastDingShen,
	SetCurveValueToMesh,
	HeadLock,
	HandAndFootLock,
	ChangeMoveMode,
	ZatoiSPScore,
	AMSpeedRate,
	AMCurveMove,
	Aiming,
	Shooting,
	Casting,
	MoveAttackState,
	AISkillFeature,
	MontageJumpToSection,
	AbortWindow,
	SetCurveValueToHair,
	SyncAnimation,
	Max
}
