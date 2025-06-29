using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSInput.EGSInputActionIconSupportedPlatform", "GSInput", UnrealModuleType.GamePlugin)]
public enum EGSInputActionIconSupportedPlatform : byte
{
	None,
	Windows,
	XSX,
	PS5
}
