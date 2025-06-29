using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.StanceType_Combo")]
public enum EStanceType_Combo : byte
{
	[UProperty]
	[DisplayName("沉重")]
	Heavy,
	[DisplayName("撑棍")]
	[UProperty]
	PROP,
	[UProperty]
	[DisplayName("捅棍")]
	POKE
}
