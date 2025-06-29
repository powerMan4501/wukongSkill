using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SequenceBlendInMatchPositionType")]
public enum ESequenceBlendInMatchPositionType : byte
{
	[DisplayName("不对位")]
	None,
	[DisplayName("A点对位（已废弃）")]
	OnePoint,
	[DisplayName("AB两点对位（已废弃）")]
	TwoPoint,
	[DisplayName("朝向A点")]
	Ori2PointA
}
