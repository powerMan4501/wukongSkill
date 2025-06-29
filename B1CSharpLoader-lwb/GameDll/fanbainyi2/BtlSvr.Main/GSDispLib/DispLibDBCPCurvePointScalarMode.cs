using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCPCurvePointScalarMode")]
public enum DispLibDBCPCurvePointScalarMode : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[DisplayName("手动设置")]
	DirectSet,
	[DisplayName("捕获当前值")]
	[UMeta(MDProp.DisplayPriority, 2)]
	CacheCurValue,
	[DisplayName("参数初始值")]
	[UMeta(MDProp.DisplayPriority, 3)]
	ParamInitialValue,
	[UMeta(MDProp.DisplayPriority, 4)]
	[DisplayName("单次随机[ 0, 1] * 值")]
	OnSpawn_ValueMultiplyRandom_0_1,
	[UMeta(MDProp.DisplayPriority, 5)]
	[DisplayName("单次随机[-1, 1] * 值")]
	OnSpawn_ValueMultiplyRandom_N1_1,
	[DisplayName("持续随机[ 0, 1] * 值")]
	[UMeta(MDProp.DisplayPriority, 6)]
	ValueMultiplyRandom_0_1,
	[DisplayName("持续随机[-1, 1] * 值")]
	[UMeta(MDProp.DisplayPriority, 7)]
	ValueMultiplyRandom_N1_1
}
