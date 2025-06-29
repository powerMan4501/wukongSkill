using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SuitQuality")]
public enum SuitQuality : byte
{
	Init,
	Grey,
	Green,
	Blue,
	Purple,
	Orange,
	Red,
	EnumMax
}
