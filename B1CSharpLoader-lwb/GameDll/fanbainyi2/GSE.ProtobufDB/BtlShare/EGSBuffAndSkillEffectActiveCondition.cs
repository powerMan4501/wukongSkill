using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EGSBuffAndSkillEffectActiveCondition")]
public enum EGSBuffAndSkillEffectActiveCondition : byte
{
	Always,
	ByProbability,
	HasTalent,
	HasBuff,
	ByAttr,
	NotHasTalent,
	HasAnyBuff,
	NotHasBuff,
	MasterHasTalent,
	CheckPhysMat,
	IsSprinting,
	CheckNotOnPhysMat,
	TargetHasBuff,
	TargetHasSimpleState,
	TargetByAttr,
	TargetHasAnyBuff,
	TargetHasAnySimpleState,
	HasAnyTalent,
	CheckResId,
	MasterNotHasBuff,
	MasterHasAnyBuff,
	TargetHasAbnormalState,
	HasSimpleState,
	TargetNotHasBuff,
	NotHasSimpleState,
	EnumMax
}
