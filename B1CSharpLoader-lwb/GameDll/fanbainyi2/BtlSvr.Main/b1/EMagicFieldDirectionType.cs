using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MagicFieldDirectionType")]
public enum EMagicFieldDirectionType : byte
{
	[DisplayName("无方向")]
	None,
	[Tooltip("锚点X轴方向")]
	[DisplayName("固定方向")]
	Directional,
	[DisplayName("放射方向")]
	[Tooltip("锚点为中心，正方向为向外，负方向为向内")]
	Radial,
	[Tooltip("锚点为中心，正方向为顺时针，负方向为逆时针")]
	[DisplayName("螺旋方向")]
	Spiral
}
