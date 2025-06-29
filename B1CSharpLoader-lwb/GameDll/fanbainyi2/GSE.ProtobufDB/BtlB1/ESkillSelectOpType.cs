using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkillSelectOpType")]
public enum ESkillSelectOpType : byte
{
	Free,
	Suction,
	SwitchTarget
}
