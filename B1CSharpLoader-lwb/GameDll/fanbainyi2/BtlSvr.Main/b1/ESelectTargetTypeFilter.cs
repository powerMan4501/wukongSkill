using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SelectTargetTypeFilter")]
public enum ESelectTargetTypeFilter : byte
{
	None = 0,
	Character = 1,
	Bullet = 2,
	MagicField = 4,
	DestructibleActor = 8
}
