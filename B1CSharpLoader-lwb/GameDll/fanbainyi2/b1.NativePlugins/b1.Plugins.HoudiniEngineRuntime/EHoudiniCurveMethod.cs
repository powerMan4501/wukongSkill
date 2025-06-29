using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniCurveMethod", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniCurveMethod
{
	Invalid = -1,
	CVs,
	Breakpoints,
	Freehand
}
