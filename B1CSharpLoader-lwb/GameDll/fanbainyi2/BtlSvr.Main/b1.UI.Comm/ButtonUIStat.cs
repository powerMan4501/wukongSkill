using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ButtonUIStat")]
public enum ButtonUIStat : byte
{
	None,
	Normal,
	Hovered,
	Focused,
	LockNormal,
	LockHovered,
	LockFocused,
	Actived,
	Disable,
	NotUse,
	LockActived,
	Hide
}
