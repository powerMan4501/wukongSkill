using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.UnitAICrowdQualityLevel")]
public enum EUnitAICrowdQualityLevel : byte
{
	Low = 0,
	Medium = 1,
	Good = 2,
	High = 3,
	EnumMax = byte.MaxValue
}
