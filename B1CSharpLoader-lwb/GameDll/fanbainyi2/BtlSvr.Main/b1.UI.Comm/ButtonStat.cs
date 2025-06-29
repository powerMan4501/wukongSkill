using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ButtonStat")]
public enum ButtonStat : byte
{
	Normal,
	Lock,
	Disable,
	NotUse,
	Hide
}
