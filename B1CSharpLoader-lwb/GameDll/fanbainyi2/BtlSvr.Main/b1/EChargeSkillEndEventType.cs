using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ChargeSkillEndEventType")]
public enum EChargeSkillEndEventType : byte
{
	ChargeEnd,
	TimeOut,
	StaminaOver,
	PELevelGrowUp
}
