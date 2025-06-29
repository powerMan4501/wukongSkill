using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EAICheckDistanceType")]
public enum EAICheckDistanceType : byte
{
	[Tooltip("计算距离：拿自身location2D - 目标location2D")]
	[DisplayName("位置距离（水平）")]
	LocationDistanceXY,
	[DisplayName("位置距离（立体）")]
	[Tooltip("计算距离：拿自身location3D - 目标location3D")]
	LocationDistance,
	[Tooltip("计算距离：拿自身locationZ - 目标locationZ")]
	[DisplayName("Z轴距离")]
	ZDistance,
	[Tooltip("计算距离：自身位置和目标位置在导航网格上的距离")]
	[DisplayName("导航网格路径长度距离")]
	NavigationDistance
}
