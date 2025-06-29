using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EWalkableSlopeBehavior", "Engine", UnrealModuleType.Engine)]
public enum EWalkableSlopeBehavior : byte
{
	WalkableSlope_Default,
	WalkableSlope_Increase,
	WalkableSlope_Decrease,
	WalkableSlope_Unwalkable,
	WalkableSlope_Max
}
