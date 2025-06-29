using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UEnum]
[UMetaPath("/Script/GSInput.EGSInputDeviceType", "GSInput", UnrealModuleType.GamePlugin)]
public enum EGSInputDeviceType
{
	Microsoft,
	Sony,
	Nintendo,
	Other
}
