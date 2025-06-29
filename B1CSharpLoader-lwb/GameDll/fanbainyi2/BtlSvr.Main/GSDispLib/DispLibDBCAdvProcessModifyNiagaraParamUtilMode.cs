using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCAdvProcessModifyNiagaraParamUtilMode")]
public enum DispLibDBCAdvProcessModifyNiagaraParamUtilMode : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[DisplayName("手动单值")]
	Standard,
	[DisplayName("单次随机")]
	[UMeta(MDProp.DisplayPriority, 2)]
	RandomOnSpawn,
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("持续随机")]
	Random,
	[DisplayName("时间采样曲线")]
	[UMeta(MDProp.DisplayPriority, 4)]
	TimedUCurve,
	[DisplayName("属性单值")]
	[UMeta(MDProp.DisplayPriority, 5)]
	SpecAtt,
	[DisplayName("属性采样材质曲线")]
	[UMeta(MDProp.DisplayPriority, 6)]
	SpecAttUCurve
}
