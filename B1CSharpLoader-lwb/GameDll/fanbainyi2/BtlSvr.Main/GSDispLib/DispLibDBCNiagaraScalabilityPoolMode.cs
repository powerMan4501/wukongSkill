using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCNiagaraScalabilityPoolMode")]
public enum DispLibDBCNiagaraScalabilityPoolMode : byte
{
	[DisplayName("DataAsset")]
	[UMeta(MD.ToolTip, "由此DataAsset创建的此特效之间进行统一性能控制，如果一个DA内配置了多个System相同的特效事件，每个事件都是独立的池")]
	[UMeta(MDProp.DisplayPriority, 1)]
	GlobalSameDataAssets,
	[DisplayName("NiagaraSystem")]
	[UMeta(MD.ToolTip, "所有由DBC创建的此特效，且性能控制参数也选择了此项的特效之间进行统一性能控制")]
	[UMeta(MDProp.DisplayPriority, 2)]
	GlobalSameNiagaraSystem,
	[UMeta(MDProp.DisplayPriority, 3)]
	[UMeta(MD.ToolTip, "所有由DBC创建的此特效，且SourceOwner相同的，且性能控制参数也选择了此项的特效之间进行统一性能控制")]
	[DisplayName("PreSourceOwnerNiagaraSystem")]
	PreSourceOwnerSameNiagaraSystem
}
