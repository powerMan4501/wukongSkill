using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.MoveDirection")]
public enum EMoveDirection : byte
{
	None,
	Forward,
	Right,
	Backward,
	Left
}
