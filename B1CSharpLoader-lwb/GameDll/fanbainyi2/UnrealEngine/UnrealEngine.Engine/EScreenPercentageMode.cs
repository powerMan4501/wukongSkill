using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EScreenPercentageMode", "Engine", UnrealModuleType.Engine)]
public enum EScreenPercentageMode
{
	Manual,
	BasedOnDisplayResolution,
	BasedOnDPIScale
}
