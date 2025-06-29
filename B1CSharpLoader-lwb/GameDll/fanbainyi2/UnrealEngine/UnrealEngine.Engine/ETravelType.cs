using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETravelType", "Engine", UnrealModuleType.Engine)]
public enum ETravelType
{
	TRAVEL_Absolute,
	TRAVEL_Partial,
	TRAVEL_Relative
}
