using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBRLimitTargetType")]
public enum EBRLimitTargetType : byte
{
	None,
	Player,
	Monster
}
