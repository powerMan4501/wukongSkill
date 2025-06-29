using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCPauseMode")]
public enum DispLibDBCPauseMode : byte
{
	[UMeta(MDProp.DisplayPriority, 0)]
	[DisplayName("冻结")]
	[UMeta(MD.ToolTip, "冻结特效当前的渲染状态")]
	Pause,
	[UMeta(MDProp.DisplayPriority, 1)]
	[UMeta(MD.ToolTip, "触发暂停对此特效无任何影响，注意，无影响意味着此事件依然在计算持续时间，这可能导致此事件比DBC本身提前结束")]
	[DisplayName("无影响")]
	None,
	[UMeta(MD.ToolTip, "进入结束表现阶段")]
	[UMeta(MDProp.DisplayPriority, 2)]
	[DisplayName("进入结束表现阶段")]
	GotoEndDispStage,
	[DisplayName("强制结束")]
	[UMeta(MDProp.DisplayPriority, 3)]
	[UMeta(MD.ToolTip, "结束且强制跳过结束表现阶段")]
	RealEndAndNoEndDispStage,
	[DisplayName("冻结并隐藏")]
	[UMeta(MD.ToolTip, "冻结特效当前的渲染状态且隐藏渲染，暂停结束后恢复显示，适用于有飞行过程的表现如喷火吐毒")]
	[UMeta(MDProp.DisplayPriority, 4)]
	PauseAndHide,
	[DisplayName("强制结束强制销毁")]
	[UMeta(MD.ToolTip, "结束且强制跳过结束表现阶段且强制销毁NiagaraComp，理论上视觉效果和【强制结束】效果一致，但是销毁从池创建的特效会有引擎警告")]
	[UMeta(MDProp.DisplayPriority, 5)]
	ForceDestory
}
