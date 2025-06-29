using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TransformBySplineRotateType")]
public enum ETransformBySplineRotateType : byte
{
	[DisplayName("朝向Spline运动方向切线且正面朝向Target")]
	RotateToSplineTangentByTargetSide,
	[DisplayName("朝向Spline运动方向切线且正面朝向当前朝向")]
	RotateToSplineTangentByCurSide,
	[DisplayName("朝向Spline运动方向切线")]
	RotateToSplineTangent,
	[DisplayName("朝向Target")]
	RotateToTarget,
	EnumMax
}
