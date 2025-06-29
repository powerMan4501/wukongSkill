using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.BattleStartConditionType")]
public enum EBattleStartConditionType : byte
{
	[DisplayName("直接开始")]
	Auto,
	[DisplayName("怪物激活后开始")]
	UnitActive,
	[DisplayName("刷怪器的怪被激活后开始")]
	SpawnerActive,
	[DisplayName("玩家进入触发盒开始")]
	EnterOverlap
}
