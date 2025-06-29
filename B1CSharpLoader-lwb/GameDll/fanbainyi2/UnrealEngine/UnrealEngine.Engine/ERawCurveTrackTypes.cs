using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ERawCurveTrackTypes", "Engine", UnrealModuleType.Engine)]
public enum ERawCurveTrackTypes : byte
{
	RCT_Float,
	RCT_Vector,
	RCT_Transform
}
