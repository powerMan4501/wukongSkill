using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.RotationBaseDirection")]
public enum ERotationBaseDirection : byte
{
	[DisplayName("世界坐标X轴")]
	WorldSpaceXAxis,
	[DisplayName("与目标连线朝向")]
	LineToTarget
}
