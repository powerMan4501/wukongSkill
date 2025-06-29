using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkipMode")]
public enum ESkipMode : byte
{
	None,
	Press,
	LongPress
}
