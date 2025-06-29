using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SPAWN_BASE_LOCATION")]
public enum SPAWN_BASE_LOCATION : byte
{
	[DisplayName("以当前蓝图基准点")]
	BASE_ON_DEFAULT,
	[DisplayName("以指定波次最后怪物为基准点")]
	BASE_ON_SPECIFIC_WAVE_DEAD,
	[DisplayName("以玩家为基准点")]
	BASE_ON_PLAYER
}
