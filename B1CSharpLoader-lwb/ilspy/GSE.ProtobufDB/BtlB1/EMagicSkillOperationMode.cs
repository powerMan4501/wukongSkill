using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.MagicSkillOperationMode")]
public enum EMagicSkillOperationMode : byte
{
	NormalCast,
	LockCast,
	RepeatToExit
}
