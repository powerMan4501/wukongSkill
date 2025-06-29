using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AttackerArea")]
public enum EAttackerArea : byte
{
	Forward,
	LeftSide,
	RightSide,
	Backward
}
