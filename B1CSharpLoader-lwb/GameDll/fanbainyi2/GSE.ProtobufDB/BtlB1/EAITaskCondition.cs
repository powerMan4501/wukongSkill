using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EAITaskCondition")]
public enum EAITaskCondition : byte
{
	None,
	SelfHpLessThan,
	TargetHpLessThan,
	SelfHasBuff,
	TargetHasBuff
}
