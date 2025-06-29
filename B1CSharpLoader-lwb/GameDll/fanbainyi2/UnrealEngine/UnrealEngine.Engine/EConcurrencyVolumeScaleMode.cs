using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EConcurrencyVolumeScaleMode", "Engine", UnrealModuleType.Engine)]
public enum EConcurrencyVolumeScaleMode
{
	Default,
	Distance,
	Priority
}
