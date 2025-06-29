using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.NormalStiffSectorsType")]
public enum ENormalStiffSectorsType : byte
{
	[DisplayName("全正面")]
	AllForward,
	[DisplayName("正反面")]
	ForwardAndBackward,
	[DisplayName("四方向")]
	FourDir
}
