using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransitionConditionType_Battle")]
public enum ETransitionConditionType_Battle : byte
{
	None,
	[DisplayName("指定怪物死亡")]
	UnitsDead,
	[DisplayName("所有波次结束")]
	WaveEnd,
	[DisplayName("Has Buff")]
	HasBuff,
	[DisplayName("怪物击杀顺序")]
	KillOrder,
	[DisplayName("怪物触发阶段变身")]
	UnitsTransStage,
	[DisplayName("指定怪物存活")]
	UnitsAlive,
	[DisplayName("指定群体单位死亡")]
	GroupUnitDead,
	[DisplayName("倒计时")]
	Countdown,
	[UMeta(MD.DisplayName, "玩家不在触发盒内")]
	NotInOverlapBox,
	[UMeta(MD.DisplayName, "玩家在触发盒内")]
	InOverlapBox,
	[UMeta(MD.DisplayName, "UI战斗退出")]
	UIBattleFinish,
	[UMeta(MD.DisplayName, "玩家存活")]
	PlayerAlive,
	[UMeta(MD.DisplayName, "玩家死亡")]
	PlayerDead
}
