using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MagicFieldDirectionUsage")]
public enum EMagicFieldDirectionUsage : byte
{
	[DisplayName("无")]
	None,
	[DisplayName("大风阻力移动")]
	WindyMove
}
