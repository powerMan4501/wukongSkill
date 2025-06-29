using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCScalarNoiseMode")]
public enum DispLibDBCScalarNoiseMode : byte
{
	[DisplayName("无")]
	[UMeta(MDProp.DisplayPriority, 1)]
	NoNoise,
	[DisplayName("Sin")]
	[UMeta(MDProp.DisplayPriority, 2)]
	Sin,
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("PerlinNoise")]
	PerlinNoise
}
