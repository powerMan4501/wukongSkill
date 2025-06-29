using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SpecialMovementMode")]
public enum ESpecialMovementMode : byte
{
	GroundMove,
	AirMove,
	GlideMove,
	ParkourMove,
	WallMove,
	FlyMove,
	SplineMove
}
