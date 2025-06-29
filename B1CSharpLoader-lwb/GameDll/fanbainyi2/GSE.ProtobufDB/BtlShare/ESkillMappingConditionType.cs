using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkillMappingConditionType")]
public enum ESkillMappingConditionType : byte
{
	Any,
	Buff,
	SurfaceType,
	InAttackWarning,
	Attr,
	Talent,
	CeilingHeight,
	TargetDistanceFar,
	SkillDirection,
	AttrInterval,
	EnumMax
}
