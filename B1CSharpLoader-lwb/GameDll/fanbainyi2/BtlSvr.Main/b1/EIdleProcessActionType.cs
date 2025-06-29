using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.IdleProcessActionType")]
public enum EIdleProcessActionType : byte
{
	None,
	[UMeta(MD.DisplayName, "传送")]
	Teleport,
	[UMeta(MD.DisplayName, "激活复活点")]
	ActiveRebirthPoint,
	[UMeta(MD.DisplayName, "使单位消失")]
	DisappearUnit,
	[UMeta(MD.DisplayName, "通知取刀器掉刀")]
	NotifyDropItemManagerDrop,
	[UMeta(MD.DisplayName, "AiConversation")]
	AiConversation,
	[UMeta(MD.DisplayName, "设置NPC参数（重置不触发）")]
	SetNPCParamOnlyInEnter,
	[UMeta(MD.DisplayName, "触发单位混战")]
	TriggerUnitBattle,
	[UMeta(MD.DisplayName, "刷新协战单位")]
	SpawnAssociationUnit,
	[UMeta(MD.DisplayName, "激活协战单位")]
	ActiveAssociationUnit,
	[UMeta(MD.DisplayName, "杀死协战单位")]
	KillAssociationUnit,
	[UMeta(MD.DisplayName, "NPC播放动画")]
	NpcPlayMontage,
	[UMeta(MD.DisplayName, "NPC移动")]
	NpcMoveTo,
	[UMeta(MD.DisplayName, "进入弱表演状态")]
	EnterWeakPerformState,
	[UMeta(MD.DisplayName, "退出弱表演状态")]
	ExitWeakPerformState,
	[UMeta(MD.DisplayName, "杀死跟随作战单位")]
	KillFollowPartner,
	[UMeta(MD.DisplayName, "清除所有血条（临时）")]
	ClearAllBloodBar,
	[UMeta(MD.DisplayName, "通知状态机")]
	NotifyStateMachine,
	[UMeta(MD.DisplayName, "传送到复活点")]
	TeleportRebirthPoint,
	[UMeta(MD.DisplayName, "播放击杀UI")]
	PlayDefeatUI,
	[UMeta(MD.DisplayName, "使复活点不可传送")]
	BlockRebirthPoint,
	[UMeta(MD.DisplayName, "游戏通关")]
	GameLevelPass,
	[UMeta(MD.DisplayName, "触发SplineFlyMoveBox")]
	TriggerSplineMove
}
