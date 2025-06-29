using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.MoveSpeedLevel")]
public enum EMoveSpeedLevel : byte
{
	Walk,
	Run,
	Sprint
}
