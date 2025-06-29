using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransitionConditionType_Group")]
public enum ETransitionConditionType_Group : byte
{
	None,
	[UMeta(MD.DisplayName, "进入触发盒")]
	EnterOverlap,
	[UMeta(MD.DisplayName, "交互结束")]
	InteractorEnd,
	[UMeta(MD.DisplayName, "在触发盒内交互")]
	InteractorInOverlap,
	[UMeta(MD.DisplayName, "游戏状态条件")]
	GameStateCondition,
	[UMeta(MD.DisplayName, "交互时间结束")]
	InteractorTimeOver,
	[DisplayName("指定怪物死亡")]
	UnitsDead,
	[DisplayName("所有波次结束")]
	WaveEnd,
	[DisplayName("Has Buff")]
	HasBuff,
	[DisplayName("怪物击杀顺序")]
	KillOrder,
	[DisplayName("Sequence已被播放")]
	SequencePlayed,
	[DisplayName("任务阶段")]
	TaskStage,
	[DisplayName("指定怪物存活")]
	UnitsAlive,
	[DisplayName("Circus内交互结束")]
	CircusInteractorEnd,
	[DisplayName("Circus内进入触发盒")]
	CircusEnterOverlap,
	[DisplayName("玩家不在触发盒内")]
	NotInOverlapBox,
	[DisplayName("玩家在触发盒内")]
	InOverlapBox,
	[DisplayName("UI战斗退出")]
	UIBattleFinish
}
