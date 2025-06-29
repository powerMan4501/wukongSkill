using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EACInterruptType")]
public enum EACInterruptType : byte
{
	None,
	Interrupt,
	Complete
}
