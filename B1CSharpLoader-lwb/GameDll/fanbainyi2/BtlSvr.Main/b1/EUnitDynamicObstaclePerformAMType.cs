using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.UnitDynamicObstaclePerformAMType")]
public enum EUnitDynamicObstaclePerformAMType : byte
{
	[DisplayName("全正面")]
	OnlyFront,
	[DisplayName("正反面")]
	FrontAndBehind,
	[DisplayName("四方向")]
	FourDir
}
