using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkillType")]
public enum ESkillType : byte
{
	NormalSkill = 0,
	HurtSkill = 1,
	ChargeSkillBegin = 8,
	ChargeSkillEnd = 9,
	RollSkill = 10,
	NoMontageSkill = 14,
	UseItemSkill = 15,
	VigorSkill = 16,
	CloudSkill = 17,
	EnumMax = byte.MaxValue
}
