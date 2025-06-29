using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EBGUComboKey")]
public enum EBGUComboKey : byte
{
	None,
	LightAttackDown,
	HeavyAttackDown,
	LightAttackUp,
	HeavyAttackUp,
	RollDown,
	RollUp
}
