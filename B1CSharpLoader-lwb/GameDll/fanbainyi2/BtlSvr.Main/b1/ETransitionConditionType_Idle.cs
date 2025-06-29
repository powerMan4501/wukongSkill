using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransitionConditionType_Idle")]
public enum ETransitionConditionType_Idle : byte
{
	None,
	[UMeta(MD.DisplayName, "进入触发盒")]
	EnterOverlap,
	[UMeta(MD.DisplayName, "交互结束（交互物）")]
	InteractorEnd,
	[UMeta(MD.DisplayName, "在触发盒内交互")]
	InteractorInOverlap,
	[UMeta(MD.DisplayName, "游戏状态条件")]
	GameStateCondition,
	[UMeta(MD.DisplayName, "所有操作执行完成")]
	ActionsAllFinish,
	[UMeta(MD.DisplayName, "交互时间结束")]
	InteractorTimeOver,
	[UMeta(MD.DisplayName, "隐性区域内计时")]
	CheckTimeInOverlap,
	[UMeta(MD.DisplayName, "隐性区域外计时")]
	CheckTimeOutOverlap,
	[UMeta(MD.DisplayName, "任务阶段")]
	TaskStage,
	[UMeta(MD.DisplayName, "消耗物品")]
	ConsumedItem,
	[UMeta(MD.DisplayName, "拥有足够数量物品")]
	OwningItem,
	[UMeta(MD.DisplayName, "交互记录")]
	InteractionRecord,
	[UMeta(MD.DisplayName, "交互结束（Npc）")]
	InteractionEnd,
	[UMeta(MD.DisplayName, "单位被激活")]
	UnitActive,
	[UMeta(MD.DisplayName, "NPC表演结束")]
	NpcActionFinished,
	[UMeta(MD.DisplayName, "NPC到达")]
	NPCReach,
	[UMeta(MD.DisplayName, "对话链结束")]
	AiConversationChainEnd,
	[UMeta(MD.DisplayName, "未持有足够数量物品")]
	UnownedEnoughItem,
	[UMeta(MD.DisplayName, "单位未被激活")]
	UnitInActive,
	[UMeta(MD.DisplayName, "玩家不在触发盒内")]
	NotInOverlapBox,
	[UMeta(MD.DisplayName, "玩家在触发盒内")]
	InOverlapBox,
	[UMeta(MD.DisplayName, "玩家处于筋斗云状态")]
	PlayerCloudMove,
	[UMeta(MD.DisplayName, "玩家是小狐狸变身状态")]
	PlayerTransAsFox
}
