using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EWindowMode", "Engine", UnrealModuleType.Engine)]
public enum EWindowMode : byte
{
	Fullscreen,
	WindowedFullscreen,
	Windowed
}
