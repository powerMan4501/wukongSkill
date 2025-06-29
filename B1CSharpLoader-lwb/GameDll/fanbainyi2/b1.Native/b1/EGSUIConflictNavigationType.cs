using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EGSUIConflictNavigationType", "UnrealExtent", UnrealModuleType.Game)]
public enum EGSUIConflictNavigationType : byte
{
	Gamepad_DPad,
	Gamepad_Left,
	Keyboard
}
