using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.CamRefType")]
public enum ECamRefType : byte
{
	None = 0,
	BothSide = 1,
	MiddlePoint = 2,
	BigSize = 3,
	EnumMax = 10
}
