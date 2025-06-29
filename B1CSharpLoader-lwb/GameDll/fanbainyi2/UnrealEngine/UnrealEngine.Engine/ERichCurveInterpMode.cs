using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ERichCurveInterpMode", "Engine", UnrealModuleType.Engine)]
public enum ERichCurveInterpMode : byte
{
	RCIM_Linear,
	RCIM_Constant,
	RCIM_Cubic,
	RCIM_None
}
