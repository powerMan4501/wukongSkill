using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.BuffAndSkillEffectCategory")]
public enum EBuffAndSkillEffectCategory : byte
{
	Neutral,
	Positive,
	Negative,
	EnumMax
}
