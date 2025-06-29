using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.CameraType")]
public enum ECameraType : byte
{
	None = 0,
	BothSide = 1,
	MiddlePoint = 2,
	BigSize = 3,
	EnumMax = 10
}
