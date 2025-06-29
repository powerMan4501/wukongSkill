using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EGSForceFightCondition")]
public enum EGSForceFightCondition : byte
{
	[DisplayName("进入区域")]
	[Tooltip("进入区域时触发")]
	EnterCollisionArea,
	[Tooltip("离开区域时触发")]
	[DisplayName("离开区域")]
	LeaveCollisionArea,
	[DisplayName("检测单位状态")]
	[UMeta(MD.Hidden)]
	[Tooltip("检测单位状态满足条件时触发")]
	ObserveUnitsConditions
}
