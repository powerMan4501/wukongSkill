using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ETimelineDirection", "Engine", UnrealModuleType.Engine)]
public enum ETimelineDirection : byte
{
	Forward,
	Backward
}
