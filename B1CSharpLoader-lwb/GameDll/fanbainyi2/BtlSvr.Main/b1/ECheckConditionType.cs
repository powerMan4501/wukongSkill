using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.CheckConditionType")]
public enum ECheckConditionType : byte
{
	[DisplayName("无")]
	[UMeta(MD.Hidden)]
	None = 0,
	[DisplayName("AI目标")]
	AITarget = 1,
	[DisplayName("血量低于")]
	HpLow = 2,
	[DisplayName("在范围内")]
	InRange = 3,
	[DisplayName("拥有Buff")]
	HasBuff = 4,
	[DisplayName("处于异常状态")]
	InAbnormalState = 5,
	[DisplayName("部位破坏")]
	BreakPart = 101,
	[DisplayName("受击")]
	Beatback = 102,
	[DisplayName("释放技能")]
	CastSkill = 103
}
