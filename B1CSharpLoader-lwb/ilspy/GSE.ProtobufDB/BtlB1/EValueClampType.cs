using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ValueClampType")]
public enum EValueClampType : byte
{
	None,
	Value,
	MaxRatio
}
