using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ParkourMoveAnimState")]
public enum EParkourMoveAnimState : byte
{
	None,
	ParkourStart,
	ParkourStartFinished,
	ParkourFall,
	ParkourLand
}
