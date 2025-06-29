using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransitionConditionType_Guide")]
public enum ETransitionConditionType_Guide : byte
{
	None,
	[DisplayName("进入触发盒")]
	EnterOverlap,
	[DisplayName("处于异常状态")]
	InAbnormalState,
	[DisplayName("交互土地庙")]
	InteractRebirthPoint,
	[DisplayName("玩家死亡")]
	PlayerDead,
	[DisplayName("玩家复活")]
	PlayerRebirth,
	[DisplayName("指定Unit死亡")]
	UnitDead,
	[DisplayName("获取指定物品")]
	GainItem,
	[DisplayName("主角属性")]
	PlayerAttr,
	[DisplayName("怪物激活")]
	UnitActive,
	[DisplayName("靠近指定怪物")]
	CloseToMonster,
	[DisplayName("任务阶段")]
	TaskStage,
	[DisplayName("地图")]
	CurrentMap,
	[DisplayName("玩家不在触发盒内")]
	NotInOverlapBox,
	[DisplayName("玩家在触发盒内")]
	InOverlapBox,
	[DisplayName("不在Seq中")]
	NotPlayingSeq,
	[DisplayName("学习某天赋")]
	LearnTalent,
	[DisplayName("打开特定界面")]
	OpenUIPage,
	[DisplayName("掉落UI确认后")]
	DropUIConfirm,
	[DisplayName("完成教学组")]
	FinishGuideGroup,
	[DisplayName("观察Sequence")]
	ObserveSequence,
	[DisplayName("拥有足够数量物品")]
	OwningItem,
	[DisplayName("老玩家（地图功能）")]
	OldPlayerForUnlockMap,
	[DisplayName("新玩家（地图功能）")]
	NewPlayerForUnlockMap
}
