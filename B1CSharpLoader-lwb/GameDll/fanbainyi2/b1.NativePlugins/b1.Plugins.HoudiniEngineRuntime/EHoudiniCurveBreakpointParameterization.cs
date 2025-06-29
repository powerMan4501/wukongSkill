using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniCurveBreakpointParameterization", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniCurveBreakpointParameterization
{
	Invalid = -1,
	Uniform,
	Chord,
	Centripetal
}
