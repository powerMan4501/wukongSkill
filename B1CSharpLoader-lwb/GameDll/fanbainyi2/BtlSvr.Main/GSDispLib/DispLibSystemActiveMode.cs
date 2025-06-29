using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibSystemActiveMode")]
public enum DispLibSystemActiveMode : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[DisplayName("正常")]
	[UMeta(MD.ToolTip, "正常接收请求且执行请求")]
	NormalActive,
	[UMeta(MDProp.DisplayPriority, 2)]
	[UMeta(MD.ToolTip, "用于时空停滞类的暂停。直接拒绝请求，不会加入待执行事件队列")]
	[DisplayName("拒绝请求")]
	RefuseNewRequest,
	[DisplayName("积压请求")]
	[UMeta(MD.ToolTip, "不常用。请求加入待执行事件队列但是不会执行，恢复为正常状态后再开始执行")]
	[UMeta(MDProp.DisplayPriority, 3)]
	Deactive
}
