using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCAdvProcessFLinearColorMode")]
public enum DispLibDBCAdvProcessFLinearColorMode : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[DisplayName("单值")]
	Standard,
	[UMeta(MDProp.DisplayPriority, 2)]
	[DisplayName("Alpha单次随机")]
	RandomAlphaOnSpawn,
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("Alpha持续随机")]
	RandomAlpha,
	[DisplayName("曲线")]
	[UMeta(MDProp.DisplayPriority, 4)]
	UCurve
}
