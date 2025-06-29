using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.AwardStateConditionType")]
public enum EAwardStateConditionType : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("处于战斗状态")]
	IsInBattle,
	[DisplayName("距离某点小于某值")]
	InDistanceToCenter,
	[DisplayName("踪迹传送点距离内")]
	TraceTeleportDistance,
	[DisplayName("玩家死亡")]
	PlayerDead,
	[UMeta(MD.Hidden)]
	EnumMax
}
