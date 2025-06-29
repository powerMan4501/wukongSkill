using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkillMappingResultRull")]
public enum ESkillMappingResultRull : byte
{
	PseudoRandom,
	Latest,
	First,
	EnumMax
}
