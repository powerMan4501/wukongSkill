using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCModNiagaraParamsPauseMode")]
public enum DispLibDBCModNiagaraParamsPauseMode : byte
{
	[DisplayName("冻结")]
	[UMeta(MD.ToolTip, "曲线、随机值等每帧变化的参数在冻结期间每帧不会计算新的参数值但依然会每帧将参数值设置到特效")]
	[UMeta(MDProp.DisplayPriority, 0)]
	Pause,
	[DisplayName("无影响")]
	[UMeta(MD.ToolTip, "触发暂停对此事件无任何影响，注意，无影响意味着此事件依然在计算持续时间，这可能导致此事件比DBC本身或目标特效提前结束")]
	[UMeta(MDProp.DisplayPriority, 1)]
	None,
	[DisplayName("进入结束表现阶段")]
	[UMeta(MD.ToolTip, "进入结束表现阶段")]
	[UMeta(MDProp.DisplayPriority, 2)]
	GotoEndDispStage,
	[DisplayName("强制结束")]
	[UMeta(MD.ToolTip, "结束且强制跳过结束表现阶段")]
	[UMeta(MDProp.DisplayPriority, 3)]
	RealEndAndNoEndDispStage
}
