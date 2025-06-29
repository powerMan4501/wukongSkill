using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.SPAWN_CONDITION")]
public enum SPAWN_CONDITION : byte
{
	[DisplayName("默认无条件")]
	SPAWN_ON_DEFALUT,
	[DisplayName("所有怪物死亡")]
	SPAWN_ON_ALL_DEAD,
	[DisplayName("x%怪物死亡")]
	SPAWN_ON_DEAD_PERCENTAGE,
	[DisplayName("随机条件")]
	SPAWN_ON_RANDOM
}
