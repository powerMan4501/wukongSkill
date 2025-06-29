using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.GroupAIAttackBias")]
public enum EGroupAIAttackBias : byte
{
	None,
	MeleeAttack,
	RangeAttack
}
