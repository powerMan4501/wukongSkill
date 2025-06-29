using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.RotateDirection")]
public enum ERotateDirection : byte
{
	[DisplayName("默认，朝小角度方向")]
	Auto,
	[DisplayName("顺时针")]
	Clockwise,
	[DisplayName("逆时针")]
	Counterclockwise
}
