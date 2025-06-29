using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ObserveConditionType")]
public enum EObserveConditionType : byte
{
	[UMeta(MD.Hidden)]
	None = 0,
	[DisplayName("进入区域")]
	[Tooltip("针对包围盒使用")]
	PlayerEnterArea = 1,
	[DisplayName("离开区域")]
	[Tooltip("针对包围盒使用")]
	PlayerLeaveArea = 2,
	[Tooltip("针对包围盒使用")]
	[DisplayName("穿过区域")]
	PlayerPenetrateArea = 3,
	[Tooltip("针对交互物使用")]
	[DisplayName("物件开始交互")]
	PlayerInteractBegin = 4,
	[DisplayName("物件交互被打断")]
	[Tooltip("针对交互物使用")]
	PlayerInteractBreak = 5,
	[DisplayName("物件结束交互")]
	[Tooltip("针对交互物使用")]
	PlayerInteractEnd = 6,
	[DisplayName("物件交互时间结束")]
	[Tooltip("针对交互物使用")]
	PlayerInteractTimeEnd = 7,
	[Tooltip("针对包围盒使用")]
	[DisplayName("范围内无单位")]
	UnitAllDeadInnerRange = 8,
	[DisplayName("生成的单位全死亡")]
	[Tooltip("针对刷怪点使用")]
	SpawnUnitAllDead = 9,
	[DisplayName("倒计时结束")]
	[Tooltip("针对计时器使用")]
	TimeOver = 10,
	[DisplayName("计时器过期")]
	[Tooltip("针对计时器使用")]
	TimeOut = 11,
	[DisplayName("唤醒")]
	[Tooltip("")]
	WakeUp = 12,
	[DisplayName("单位死亡")]
	[Tooltip("")]
	UnitDead = 13,
	[DisplayName("被触发")]
	[Tooltip("针对触发器使用")]
	Trigger = 14,
	[Tooltip("针对Gate状态机使用")]
	[DisplayName("Gate打开")]
	GateOpen = 15,
	[DisplayName("Gate关闭")]
	[Tooltip("针对Gate状态机使用")]
	GateClose = 16,
	[Tooltip("试炼/挑战使用")]
	[DisplayName("试炼失败(联机用)")]
	ChallengeFailed = 17,
	[DisplayName("试炼奖励领取完毕")]
	[Tooltip("试炼/挑战使用")]
	ChallengeAwarded = 18,
	[DisplayName("试炼挑战成功")]
	[Tooltip("试炼/挑战使用")]
	ChallengeSuccess = 19,
	[DisplayName("试炼挑战开启(联机用)")]
	ChallengeBegin = 20,
	[UMeta(MD.Hidden)]
	UseTagFlag = 100,
	[DisplayName("单位不存在")]
	UnitDestroy = 101,
	[DisplayName("单位被激活")]
	UnitActive = 102,
	[DisplayName("单位未被激活")]
	UnitInActive = 103,
	[DisplayName("单位属性值")]
	UnitAttr = 104,
	[DisplayName("SimpleState")]
	SimpleState = 105,
	[DisplayName("UnitState")]
	UnitState = 106,
	[DisplayName("Has Buff")]
	HasBuff = 107,
	[DisplayName("已满足道具数量(联机用)")]
	ItemFullOnline = 108,
	[UMeta(MD.Hidden)]
	EnumMax = 109
}
