using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCCustomEventType")]
public enum DispLibDBCCustomEventType : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[DisplayName("None")]
	[UMeta(MD.ToolTip, "功能性保留，从Index 1开始扩展")]
	None,
	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.DisplayPriority, 2)]
	[DisplayName("Free_One")]
	Free_One,
	[DisplayName("Free_One")]
	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.DisplayPriority, 3)]
	Free_Two
}
