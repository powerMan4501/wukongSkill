using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransitionConditionType_State")]
public enum ETransitionConditionType_State : byte
{
	None,
	[UMeta(MD.DisplayName, "进入触发盒")]
	EnterOverlap,
	[UMeta(MD.DisplayName, "交互结束")]
	InteractorEnd,
	[UMeta(MD.DisplayName, "交互时间结束")]
	InteractorTimeOver,
	[DisplayName("指定怪物死亡")]
	UnitsDead,
	[DisplayName("所有波次结束")]
	WaveEnd,
	[DisplayName("Has Buff")]
	HasBuff,
	[DisplayName("Sequence已被播放")]
	SequencePlayed,
	[DisplayName("任务阶段")]
	TaskStage,
	[DisplayName("GamePlay计数")]
	GamePlayCount,
	[UMeta(MD.DisplayName, "Circus成员交互结束")]
	CircusInteractorEnd,
	[UMeta(MD.DisplayName, "Circus成员触发盒Overlap")]
	CircusEnterOverlap,
	[UMeta(MD.DisplayName, "玩家不在触发盒内")]
	NotInOverlapBox,
	[UMeta(MD.DisplayName, "玩家在触发盒内")]
	InOverlapBox
}
