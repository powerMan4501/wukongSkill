using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EVectorCurveChannel", "Engine", UnrealModuleType.Engine)]
public enum EVectorCurveChannel : byte
{
	X,
	Y,
	Z,
	Invalid
}
