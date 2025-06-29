using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCNiagaraForceVisibleStateMode")]
public enum DispLibDBCNiagaraForceVisibleStateMode : byte
{
	[UMeta(MDProp.DisplayPriority, 0)]
	[DisplayName("立即设置Comp的可见性")]
	[UMeta(MD.ToolTip, "如果此事件响应了请求，立即设置Comp上的Visible开关，这会导致特效立即隐藏或显示")]
	ImmdSetCompVisibleState,
	[UMeta(MD.ToolTip, "即使此事件响应了请求，也对此特效无任何影响，不常用，一般用于debug")]
	[DisplayName("无影响")]
	[UMeta(MDProp.DisplayPriority, 1)]
	None,
	[UMeta(MDProp.DisplayPriority, 2)]
	[UMeta(MD.ToolTip, "特效需要有渐变消隐就选此项，如果此事件响应了请求，不会设置Comp上的Visible开关（不会立即设置，也不会延迟设置，就是真的不设置），而是设置特效int参数 User.GS_EfxForceVisibleState，特效内部自己处理可见性，例如逐渐降低所有发射器的透明度")]
	[DisplayName("设置特效参数")]
	SetNiagaraParam
}
