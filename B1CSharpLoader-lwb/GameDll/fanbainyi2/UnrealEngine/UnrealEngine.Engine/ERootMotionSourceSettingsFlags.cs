using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERootMotionSourceSettingsFlags", "Engine", UnrealModuleType.Engine)]
public enum ERootMotionSourceSettingsFlags
{
	UseSensitiveLiftoffCheck = 1,
	DisablePartialEndTick = 2,
	IgnoreZAccumulate = 4
}
