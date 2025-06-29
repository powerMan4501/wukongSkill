using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EGSHitDestructibleDirection")]
public enum EGSHitDestructibleDirection : byte
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("破碎物朝向")]
	[BlueprintReadWrite]
	DestructibleDirection,
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("攻击者速度方向")]
	AttackerSpeedDirection,
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("攻击者与破碎物连线方向")]
	[UProperty]
	AttackerRelativeDirection
}
