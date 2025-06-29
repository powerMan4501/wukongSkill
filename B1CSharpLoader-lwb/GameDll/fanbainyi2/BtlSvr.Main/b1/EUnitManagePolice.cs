using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.UnitManagePolice")]
public enum EUnitManagePolice : byte
{
	[DisplayName("与前状态保持一致")]
	SameAsPrevious,
	Status,
	StatusWithoutHP,
	Spawn,
	Destroy
}
