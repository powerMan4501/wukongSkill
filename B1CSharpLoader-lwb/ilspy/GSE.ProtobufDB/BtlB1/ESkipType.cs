using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkipType")]
public enum ESkipType : byte
{
	None,
	FastForward,
	SetPosition
}
