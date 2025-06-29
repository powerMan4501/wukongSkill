using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EGSInputChangeType")]
public enum EGSInputChangeType : byte
{
	All,
	Gamepad,
	KeyboardMouse
}
