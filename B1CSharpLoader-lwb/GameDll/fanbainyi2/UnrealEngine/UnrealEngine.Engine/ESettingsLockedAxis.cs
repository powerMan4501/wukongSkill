using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESettingsLockedAxis", "Engine", UnrealModuleType.Engine)]
public enum ESettingsLockedAxis
{
	None,
	X,
	Y,
	Z,
	Invalid
}
