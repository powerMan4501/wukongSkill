using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.BuffControlCondition")]
public enum EBuffControlCondition : byte
{
	[DisplayName("进入区域")]
	[Tooltip("进入区域时触发")]
	EnterCollisionArea,
	[DisplayName("待在区域")]
	[Tooltip("待在区域时会持续触发")]
	[UMeta(MD.Hidden)]
	StayCollisionArea,
	[Tooltip("离开区域时触发")]
	[DisplayName("离开区域")]
	LeaveCollisionArea
}
