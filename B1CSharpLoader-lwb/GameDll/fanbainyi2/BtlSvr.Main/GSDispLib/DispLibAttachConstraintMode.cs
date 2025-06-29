using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibAttachConstraintMode")]
public enum DispLibAttachConstraintMode : byte
{
	[UMeta(MDProp.DisplayPriority, 0)]
	[UMeta(MD.ToolTip, "不会脱离，直到结束表现阶段第一帧依据【结束表现阶段与挂点分离】决定是否脱离")]
	[DisplayName("稳固")]
	Fixed,
	[UMeta(MDProp.DisplayPriority, 1)]
	[UMeta(MD.ToolTip, "经过固定时间后脱离")]
	[DisplayName("固定时间后脱离")]
	FixedTime,
	[UMeta(MDProp.DisplayPriority, 2)]
	[UMeta(MD.ToolTip, "根节点超过速度阈值后脱离，参数 = 0表示使用默认速度阈值")]
	[DisplayName("Root速度阈值")]
	RootVelocityThreshold,
	[UMeta(MD.ToolTip, "如果是实际Attach到某个挂点的特效，挂点超过速度阈值后脱离，参数 = 0表示使用默认速度阈值")]
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("挂点速度阈值")]
	AttachedSocketVelocityThreshold,
	[DisplayName("挂点速度阈值和挂点扭转阈值")]
	[UMeta(MDProp.DisplayPriority, 4)]
	[UMeta(MD.ToolTip, "如果是实际Attach到某个挂点的特效，挂点超过速度阈值后脱离，或者挂点扭转程度超过阈值后脱离，参数 = 0表示使用默认阈值")]
	AttachedSocketVelocityAndTorsionThreshold,
	[UMeta(MDProp.DisplayPriority, 5)]
	[UMeta(MD.ToolTip, "如果是实际Attach到某个挂点的特效，挂点累计位移距离超过阈值后脱离，或者挂点扭转程度超过阈值后脱离，参数 = 0表示使用默认阈值")]
	[DisplayName("挂点累计位移和挂点扭转阈值")]
	AttachedSocketDistanceACCAndTorsionThreshold
}
