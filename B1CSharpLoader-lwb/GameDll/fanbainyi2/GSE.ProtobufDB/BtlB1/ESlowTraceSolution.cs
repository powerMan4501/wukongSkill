using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SlowTraceSolution")]
public enum ESlowTraceSolution : byte
{
	None = 0,
	Distance = 1,
	Angle = 2,
	EnumMax = 10
}
