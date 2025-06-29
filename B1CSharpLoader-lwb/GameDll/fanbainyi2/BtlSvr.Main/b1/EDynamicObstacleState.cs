using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.DynamicObstacleState")]
public enum EDynamicObstacleState : byte
{
	[DisplayName("开启（可以通过）")]
	Opened,
	[DisplayName("关闭（不可通过）")]
	Closed
}
