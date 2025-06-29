using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCActorGroup")]
public enum DispLibDBCActorGroup : byte
{
	[UMeta(MDProp.DisplayPriority, 0)]
	[UMeta(MD.ToolTip, "默认")]
	[DisplayName("NoGroup")]
	None = 0,
	[UMeta(MDProp.DisplayPriority, 1)]
	[DisplayName("战斗单位")]
	[UMeta(MD.ToolTip, "")]
	BattleUnit = 1,
	[DisplayName("可交互物")]
	[UMeta(MDProp.DisplayPriority, 2)]
	[UMeta(MD.ToolTip, "采集物，土地庙，精魄等")]
	Interact = 2,
	[UMeta(MD.ToolTip, "子弹，法术场")]
	[DisplayName("投射物")]
	[UMeta(MDProp.DisplayPriority, 3)]
	Projectile = 3,
	[DisplayName("装备预览")]
	[UMeta(MDProp.DisplayPriority, 4)]
	[UMeta(MD.ToolTip, "装备预览")]
	EquipPreview = 4,
	[UMeta(MDProp.DisplayPriority, 5)]
	[UMeta(MD.ToolTip, "DLDWorld")]
	[DisplayName("DLDWorld")]
	DLDWorld = 5,
	[UMeta(MD.ToolTip, "EditorPreviewTool")]
	[DisplayName("编辑器预览功能性Actor")]
	[UMeta(MDProp.DisplayPriority, 5)]
	EditorPreviewTool = 5
}
