using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCCompsFilterMode")]
public enum DispLibDBCCompsFilterMode : byte
{
	[DisplayName("全部组件")]
	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.DisplayPriority, 1)]
	AllComps,
	[DisplayName("指定Tag")]
	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.DisplayPriority, 2)]
	ByTags,
	[DisplayName("排除Tag")]
	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.DisplayPriority, 3)]
	ByExcludeTags
}
