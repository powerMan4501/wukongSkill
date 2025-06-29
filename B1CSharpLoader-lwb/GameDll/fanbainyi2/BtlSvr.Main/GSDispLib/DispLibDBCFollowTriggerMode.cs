using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCFollowTriggerMode")]
public enum DispLibDBCFollowTriggerMode : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[UMeta(MD.ToolTip, "")]
	[DisplayName("不使用接续触发")]
	None,
	[DisplayName("结束阶段开始时")]
	[UMeta(MDProp.DisplayPriority, 2)]
	[UMeta(MD.ToolTip, "")]
	OnEndStageBegin,
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("结束阶段完成后")]
	[UMeta(MD.ToolTip, " ")]
	AfterEndStage,
	[UMeta(MDProp.DisplayPriority, 4)]
	[UMeta(MD.ToolTip, "")]
	[DisplayName("中断时")]
	OnBreakBegin,
	[DisplayName("中断表现完成时")]
	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.DisplayPriority, 5)]
	AfterBreak
}
