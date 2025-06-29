using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ObserveOnlineConditionType")]
public enum EObserveOnlineConditionType : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("区域内玩家数量")]
	[Tooltip("针对包围盒使用")]
	PlayerCountInRange,
	[DisplayName("玩家靠近Boss踪迹")]
	PlayerEnterBossTraceArea,
	[DisplayName("击杀怪物数量")]
	KillMonsterNumber,
	[DisplayName("累计获得道具数量")]
	GainItemCumulative,
	[DisplayName("抽奖次数达标")]
	AwardCount,
	[UMeta(MD.Hidden)]
	EnumMax
}
