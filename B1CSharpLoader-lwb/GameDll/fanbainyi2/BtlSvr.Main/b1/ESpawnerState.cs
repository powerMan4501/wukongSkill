using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SpawnerState")]
public enum ESpawnerState : byte
{
	[DisplayName("未启用（不刷怪）")]
	Disabled,
	[DisplayName("等待开始条件（可刷怪）")]
	Enabled,
	[DisplayName("已刷怪")]
	Spawned
}
