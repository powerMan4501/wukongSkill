using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCMaterialsFilterMode")]
public enum DispLibDBCMaterialsFilterMode : byte
{
	[DisplayName("全部材质")]
	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.DisplayPriority, 1)]
	AllMats,
	[UMeta(MD.ToolTip, "")]
	[DisplayName("指定SlotName")]
	[UMeta(MDProp.DisplayPriority, 2)]
	BySlotNames,
	[DisplayName("排除SlotName")]
	[UMeta(MDProp.DisplayPriority, 3)]
	[UMeta(MD.ToolTip, "")]
	ByExcludeSlotNames,
	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.DisplayPriority, 4)]
	[DisplayName("指定Index")]
	ByIndexes,
	[UMeta(MDProp.DisplayPriority, 5)]
	[UMeta(MD.ToolTip, "")]
	[DisplayName("排除Index")]
	ByExcludeIndexes,
	[DisplayName("指定Shader")]
	[UMeta(MDProp.DisplayPriority, 6)]
	[UMeta(MD.ToolTip, "")]
	ByUMaterial,
	[UMeta(MDProp.DisplayPriority, 7)]
	[DisplayName("排除Shader")]
	[UMeta(MD.ToolTip, "")]
	ByExcludeUMaterial
}
