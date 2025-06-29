using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitPerformFXEventType")]
public enum EHitPerformFXEventType : byte
{
	None,
	NormalHit,
	CritHit,
	SkillSurperArmorHit,
	ParryHit,
	BlockArmorHit,
	PerfectBlockArmorHit,
	SkillSurperArmorBreakHit,
	BlockArmorBreakHit,
	BlockArmorBreak2WeakHit,
	FrozenHit,
	FrozenBreakHit,
	ImmobilizedHit,
	ImmobilizedBreakHit,
	PartBreakHit,
	ShieldBlockHit,
	EnumMax
}
