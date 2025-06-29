using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EAITaskActivationEvent")]
public enum EAITaskActivationEvent : byte
{
	AtOnce,
	BeAttacked
}
