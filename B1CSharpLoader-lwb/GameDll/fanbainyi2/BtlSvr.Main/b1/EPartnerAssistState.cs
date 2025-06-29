using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.PartnerAssistState")]
public enum EPartnerAssistState : byte
{
	None,
	PassiveWithOutAtk,
	Passive,
	Active
}
