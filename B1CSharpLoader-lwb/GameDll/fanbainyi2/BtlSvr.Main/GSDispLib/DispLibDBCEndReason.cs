using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCEndReason")]
public enum DispLibDBCEndReason : byte
{
	[DisplayName("正常结束")]
	[UMeta(MDProp.DisplayPriority, 1)]
	[UMeta(MD.ToolTip, "")]
	StandardEnd,
	[UMeta(MD.ToolTip, "")]
	[DisplayName("打断")]
	[UMeta(MDProp.DisplayPriority, 2)]
	Break,
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("主要Comp死亡")]
	[UMeta(MD.ToolTip, "")]
	MainCompDeath,
	[UMeta(MD.ToolTip, "")]
	[DisplayName("次要Comp死亡")]
	[UMeta(MDProp.DisplayPriority, 4)]
	MinorCompDeath,
	[UMeta(MDProp.DisplayPriority, 5)]
	[UMeta(MD.ToolTip, "")]
	[DisplayName("强制停止")]
	ForceStop
}
