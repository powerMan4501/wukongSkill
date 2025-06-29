using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.MatchingPosType")]
public enum EMatchingPosType : byte
{
	None,
	InterpolationLiner,
	FlyTrajectoryUseBezier,
	Teleport,
	OnlyRotation,
	EnumMax
}
