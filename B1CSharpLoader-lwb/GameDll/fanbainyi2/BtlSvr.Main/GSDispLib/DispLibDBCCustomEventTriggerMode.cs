using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCCustomEventTriggerMode")]
public enum DispLibDBCCustomEventTriggerMode : byte
{
	[DisplayName("标准")]
	[UMeta(MD.ToolTip, "经过延迟时间后触发")]
	[UMeta(MDProp.DisplayPriority, 1)]
	Standard,
	[DisplayName("立即")]
	[UMeta(MD.ToolTip, "无视延迟时间，等价于 标准模式且延迟时间为0")]
	[UMeta(MDProp.DisplayPriority, 2)]
	Immediate
}
