using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.DamageReason")]
public enum EDamageReason : byte
{
	None,
	Buff,
	Skill,
	FallDmg,
	DeadZone
}
