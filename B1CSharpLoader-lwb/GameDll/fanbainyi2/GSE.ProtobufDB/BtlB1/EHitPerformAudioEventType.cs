using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitPerformAudioEventType")]
public enum EHitPerformAudioEventType : byte
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
