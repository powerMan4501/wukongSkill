using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.FallHeightType_V2")]
public enum EFallHeightType_V2 : byte
{
	[DisplayName("坠落_LittleFall")]
	FallHeight_Little,
	[DisplayName("坠落_低")]
	FallHeight_Low,
	[DisplayName("坠落_中")]
	FallHeight_Mid,
	[DisplayName("坠落_高")]
	FallHeight_High,
	[DisplayName("坠落_死亡")]
	FallHeight_Dead
}
