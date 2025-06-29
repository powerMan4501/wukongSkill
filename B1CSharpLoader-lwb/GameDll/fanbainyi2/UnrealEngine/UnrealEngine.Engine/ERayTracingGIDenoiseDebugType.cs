using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERayTracingGIDenoiseDebugType", "Engine", UnrealModuleType.Engine)]
public enum ERayTracingGIDenoiseDebugType
{
	Disabled,
	Variance,
	FirstMoment,
	SecondMoment,
	HistoryLength,
	MotionVector,
	HitDistance,
	RawOutput
}
