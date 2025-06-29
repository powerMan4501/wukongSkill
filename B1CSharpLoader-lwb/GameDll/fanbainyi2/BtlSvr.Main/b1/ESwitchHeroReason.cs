using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.SwitchHeroReason")]
public enum ESwitchHeroReason : byte
{
	Manual,
	Dead
}
