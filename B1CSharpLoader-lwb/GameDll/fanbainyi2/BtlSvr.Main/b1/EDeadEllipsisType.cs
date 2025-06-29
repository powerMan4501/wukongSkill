using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.DeadEllipsisType")]
public enum EDeadEllipsisType : byte
{
	[DisplayName("无缺省")]
	None,
	[DisplayName("只忽略异常状态")]
	NoAbnormalState,
	[DisplayName("只省略攻击朝向")]
	NoHitAction,
	[DisplayName("只省略攻击者区域")]
	NoAttackerArea,
	[DisplayName("省略攻击者区域和攻击朝向")]
	BothNoAttackerAreaNHitAction,
	[DisplayName("省略受击挡位")]
	NoGears,
	[DisplayName("省略受击库")]
	NoDepot
}
