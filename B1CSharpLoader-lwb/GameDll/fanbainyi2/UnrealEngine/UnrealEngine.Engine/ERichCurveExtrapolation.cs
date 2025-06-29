using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ERichCurveExtrapolation", "Engine", UnrealModuleType.Engine)]
public enum ERichCurveExtrapolation : byte
{
	RCCE_Cycle,
	RCCE_CycleWithOffset,
	RCCE_Oscillate,
	RCCE_Linear,
	RCCE_Constant,
	RCCE_None
}
