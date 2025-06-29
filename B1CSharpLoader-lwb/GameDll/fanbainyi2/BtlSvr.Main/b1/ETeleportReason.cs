using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TeleportReason")]
public enum ETeleportReason : byte
{
	None,
	Rebirth,
	RebirthPointManual
}
