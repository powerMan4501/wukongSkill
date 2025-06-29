using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MagicFieldDirectionTypeDetail")]
public enum EMagicFieldDirectionTypeDetail : byte
{
	[DisplayName("正向")]
	Positive,
	[DisplayName("负向")]
	Negative
}
