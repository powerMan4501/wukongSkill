using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSInput.EGSInputType", "GSInput", UnrealModuleType.GamePlugin)]
public enum EGSInputType : byte
{
	None,
	KeyboardMouse,
	Gamepad,
	Touch,
	Other
}
