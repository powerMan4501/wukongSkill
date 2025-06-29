using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EGSHitDestructibleImpulseType")]
public enum EGSHitDestructibleImpulseType : byte
{
	[DisplayName("默认")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	Default,
	[DisplayName("力度级别冲量")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	StrengthLevel,
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("手动输入冲量")]
	[UProperty]
	Manual
}
