using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EBGUMoveCurveType")]
public enum EBGUMoveCurveType : byte
{
	None,
	SpeedCurve,
	DistanceCurve
}
