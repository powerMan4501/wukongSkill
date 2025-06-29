using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.SPAWN_METHOD")]
public enum SPAWN_METHOD : byte
{
	[DisplayName("立即生成")]
	SPAWN_ON_START,
	[DisplayName("根据指定波次状态生成")]
	SPAWN_ON_WAVE,
	[DisplayName("进入范围触发生成")]
	SPAWN_ON_TRIGGER_RANGE
}
