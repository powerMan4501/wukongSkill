using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.DmgRangeType")]
public enum EDmgRangeType : byte
{
	Default = 0,
	Near = 1,
	Far = 2,
	EnumMax = byte.MaxValue
}
