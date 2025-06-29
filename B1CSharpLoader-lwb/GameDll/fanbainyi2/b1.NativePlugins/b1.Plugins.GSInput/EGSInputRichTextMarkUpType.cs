using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSInput.EGSInputRichTextMarkUpType", "GSInput", UnrealModuleType.GamePlugin)]
public enum EGSInputRichTextMarkUpType : byte
{
	None,
	InputAction,
	Keyboard,
	Gamepad,
	InputActionAlwaysShow
}
