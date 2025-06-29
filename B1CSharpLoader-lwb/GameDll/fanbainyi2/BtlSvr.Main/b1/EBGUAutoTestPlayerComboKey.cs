using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EBGUAutoTestPlayerComboKey")]
public enum EBGUAutoTestPlayerComboKey : byte
{
	None,
	LightAttackDown,
	LightAttackUp,
	HeavyAttackDown,
	HeavyAttackUp,
	Dodge
}
