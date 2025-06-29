using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.BattleCoopReason")]
public enum EBattleCoopReason : byte
{
	[Tooltip("死亡时会给其他成员发送“B1.FSM.Event.AI.Battle.PartnerDead”")]
	UnitDead
}
