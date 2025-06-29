using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SummonBehaviorState")]
public enum ESummonBehaviorState : byte
{
	Default,
	Idle,
	Follow,
	EnumMax
}
