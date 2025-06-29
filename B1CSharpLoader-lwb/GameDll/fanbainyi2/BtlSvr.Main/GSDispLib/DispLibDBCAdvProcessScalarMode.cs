using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCAdvProcessScalarMode")]
public enum DispLibDBCAdvProcessScalarMode : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[DisplayName("单值")]
	Standard,
	[UMeta(MDProp.DisplayPriority, 2)]
	[DisplayName("单次随机")]
	RandomOnSpawn,
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("持续随机")]
	Random,
	[UMeta(MDProp.DisplayPriority, 4)]
	[DisplayName("曲线")]
	UCurve
}
