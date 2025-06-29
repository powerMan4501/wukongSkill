using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EGSHitDestructibleStrengthLevel")]
public enum EGSHitDestructibleStrengthLevel : byte
{
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("无法打碎")]
	[EditAnywhere]
	None,
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("轻力")]
	Light,
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("中力")]
	[UProperty]
	Medium,
	[EditAnywhere]
	[DisplayName("重力")]
	[UProperty]
	[BlueprintReadWrite]
	Heavy,
	[UProperty]
	[EditAnywhere]
	[DisplayName("怪力")]
	[BlueprintReadWrite]
	Special
}
