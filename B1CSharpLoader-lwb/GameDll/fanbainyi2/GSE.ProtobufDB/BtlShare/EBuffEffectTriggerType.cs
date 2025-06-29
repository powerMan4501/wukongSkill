using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.BuffEffectTriggerType")]
public enum EBuffEffectTriggerType : byte
{
	None,
	Generation,
	Time,
	Remove,
	CasterDead,
	Dead,
	LayerMax,
	BeAttacked,
	OnSkillBreak,
	IntoChargeEnd,
	OnCriticalHit,
	OnKillUnit,
	SkillCostOnceDmg,
	OnShieldBreak,
	OnSkillDamage,
	BeHurted,
	BeHurtedNoneElem,
	BeHurtedFreeze,
	BeHurtedBurn,
	BeHurtedPoison,
	BeHurtedThunder,
	BeHurtedYin,
	BeHurtedYang,
	EnumMax
}
