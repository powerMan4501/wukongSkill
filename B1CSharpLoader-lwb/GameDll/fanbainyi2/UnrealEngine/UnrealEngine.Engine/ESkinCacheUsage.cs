using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESkinCacheUsage", "Engine", UnrealModuleType.Engine)]
public enum ESkinCacheUsage
{
	Auto = 0,
	Disabled = 255,
	Enabled = 1
}
