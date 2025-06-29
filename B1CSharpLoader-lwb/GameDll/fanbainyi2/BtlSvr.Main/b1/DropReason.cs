using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.DropReason")]
public enum DropReason : byte
{
	None,
	UnitDead,
	Collection,
	Destruction,
	Challenge,
	DropItemMgr
}
