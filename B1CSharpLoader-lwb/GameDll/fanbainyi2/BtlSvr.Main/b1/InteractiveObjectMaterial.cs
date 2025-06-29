using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.InteractiveObjectMaterial")]
public enum InteractiveObjectMaterial : byte
{
	[DisplayName("默认")]
	Default,
	[DisplayName("木头")]
	Wood,
	[DisplayName("石头")]
	Stone,
	[DisplayName("金属")]
	Steel
}
