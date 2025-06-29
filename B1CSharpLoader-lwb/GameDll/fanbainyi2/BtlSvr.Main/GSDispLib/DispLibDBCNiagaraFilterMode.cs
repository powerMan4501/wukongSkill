using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCNiagaraFilterMode")]
public enum DispLibDBCNiagaraFilterMode : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[UMeta(MD.ToolTip, "")]
	[DisplayName("全部特效")]
	AllNiagara,
	[DisplayName("名字包含指定字符")]
	[UMeta(MDProp.DisplayPriority, 2)]
	[UMeta(MD.ToolTip, "只要包含任意一个名字即视为匹配")]
	ByName,
	[DisplayName("排除名字包含指定字符")]
	[UMeta(MD.ToolTip, "只要包含任意一个名字即视为不匹配")]
	[UMeta(MDProp.DisplayPriority, 3)]
	ByExcludeName,
	[UMeta(MD.ToolTip, "只要包含任意一个tag即视为匹配")]
	[DisplayName("指定Tag")]
	[UMeta(MDProp.DisplayPriority, 4)]
	ByTags,
	[DisplayName("排除Tag")]
	[UMeta(MD.ToolTip, "只要包含任意一个tag即视为不匹配")]
	[UMeta(MDProp.DisplayPriority, 5)]
	ByExcludeTags,
	[UMeta(MDProp.DisplayPriority, 6)]
	[UMeta(MD.ToolTip, "")]
	[DisplayName("指定模板")]
	BySystemAsset,
	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.DisplayPriority, 7)]
	[DisplayName("排除模板")]
	ByExcludeSystemAsset
}
