using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureEncodeSpeedOverride", "Engine", UnrealModuleType.Engine)]
public enum ETextureEncodeSpeedOverride
{
	Disabled = 255,
	Final = 0,
	FinalIfAvailable = 1,
	Fast = 2
}
