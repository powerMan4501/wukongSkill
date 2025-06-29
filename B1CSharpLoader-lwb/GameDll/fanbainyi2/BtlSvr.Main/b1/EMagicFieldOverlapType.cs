using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[DisplayName("法术场检测类型")]
[USharpPath("/Script/b1-Managed.MagicFieldOverlapType")]
public enum EMagicFieldOverlapType : byte
{
	[DisplayName("Normal")]
	Normal,
	[DisplayName("NegativeOverlap")]
	NegativeOverlap
}
