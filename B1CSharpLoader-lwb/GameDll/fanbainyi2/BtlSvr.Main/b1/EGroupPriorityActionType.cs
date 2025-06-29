using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GroupPriorityActionType")]
public enum EGroupPriorityActionType : byte
{
	[DisplayName("移动到特定位置")]
	[Tooltip("目前是通过EQS计算移动；如果存在MoveToPos，必须为指令列表第一个且只有一个，否则优先队列失效")]
	MoveToPos = 0,
	[DisplayName("释放技能")]
	CastSkill = 1,
	[DisplayName("添加Buff")]
	AddBuff = 2,
	[UMeta(MD.Hidden)]
	EnumMax = byte.MaxValue
}
