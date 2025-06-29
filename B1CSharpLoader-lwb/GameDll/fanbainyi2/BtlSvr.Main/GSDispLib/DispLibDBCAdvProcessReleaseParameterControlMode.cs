using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCAdvProcessReleaseParameterControlMode")]
public enum DispLibDBCAdvProcessReleaseParameterControlMode : byte
{
	[DisplayName("事件整体RealEnd时")]
	[UMeta(MDProp.DisplayPriority, 1)]
	OnEventRealEnd,
	[DisplayName("参数收尾时间结束时")]
	[UMeta(MDProp.DisplayPriority, 2)]
	[UMeta(MD.ToolTip, "此模式受事件整体RealEnd时机影响，如果事件整体RealEnd时参数的收尾时间没有跑完，也会强制释放参数控制权")]
	OnParamSelfEndStageOver
}
