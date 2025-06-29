using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.FindSceneItemWay")]
public enum EFindSceneItemWay : byte
{
	[DisplayName("最近优先")]
	FindNearest,
	[DisplayName("最远优先")]
	FindFurthest,
	[DisplayName("角度最小优先")]
	FindMinTotalAngle,
	[DisplayName("综合因素（基于权重）")]
	Composite,
	[DisplayName("综合因素（主角飞虫降落）")]
	CompositeV2,
	[DisplayName("距离当前目标最近优先")]
	FindNearestToTarget,
	[DisplayName("距离当前目标最远优先")]
	FindFurthestToTarget,
	[DisplayName("角度外最近")]
	ClosestOutsideTheAngle,
	[DisplayName("角度外最远")]
	FarthestOutsideTheAngle
}
