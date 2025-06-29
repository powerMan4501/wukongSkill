using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EnhancedTriggerEvent")]
public enum EEnhancedTriggerEvent : byte
{
	None,
	Triggered,
	Started,
	Ongoing,
	Canceled,
	Completed
}
