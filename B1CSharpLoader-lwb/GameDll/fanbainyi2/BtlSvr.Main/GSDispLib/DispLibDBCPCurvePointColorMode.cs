using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCPCurvePointColorMode")]
public enum DispLibDBCPCurvePointColorMode : byte
{
	[DisplayName("手动设置")]
	[UMeta(MDProp.DisplayPriority, 1)]
	DirectSet,
	[UMeta(MDProp.DisplayPriority, 2)]
	[DisplayName("捕获当前值")]
	CacheCurValue,
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("参数初始值")]
	ParamInitialValue,
	[UMeta(MDProp.DisplayPriority, 4)]
	[DisplayName("Alpha单次随机[ 0, 1] * 值")]
	OnSpawn_ValueMultiplyRandom_0_1,
	[UMeta(MDProp.DisplayPriority, 5)]
	[DisplayName("Alpha单次随机[-1, 1] * 值")]
	OnSpawn_ValueMultiplyRandom_N1_1,
	[UMeta(MDProp.DisplayPriority, 6)]
	[DisplayName("Alpha持续随机[ 0, 1] * 值")]
	ValueMultiplyRandom_0_1,
	[UMeta(MDProp.DisplayPriority, 7)]
	[DisplayName("Alpha持续随机[-1, 1] * 值")]
	ValueMultiplyRandom_N1_1
}
