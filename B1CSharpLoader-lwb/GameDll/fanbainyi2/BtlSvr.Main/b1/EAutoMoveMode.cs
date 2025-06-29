using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AutoMoveMode")]
public enum EAutoMoveMode : byte
{
	AttackMove,
	ForcedMove,
	SimpleMove
}
