using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.KillUnitMapCond")]
public enum EKillUnitMapCond : byte
{
	[DisplayName("暴击")]
	Crit,
	[DisplayName("无条件映射")]
	NoCodition,
	[DisplayName("无双伤害")]
	Unparalleled,
	[DisplayName("完美蓄力")]
	PerfectChargeDamage
}
