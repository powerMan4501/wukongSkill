using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSInput.EGSInputIconShowType", "GSInput", UnrealModuleType.GamePlugin)]
public enum EGSInputIconShowType : byte
{
	KeyboardMouse,
	Gamepad,
	Both
}
