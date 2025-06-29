using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SwitchBattleFSMState")]
public enum ESwitchBattleFSMState : byte
{
	[DisplayName("攻击状态")]
	Attack,
	[DisplayName("游走状态")]
	Wander
}
