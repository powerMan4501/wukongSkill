using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniCurveOutputType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniCurveOutputType
{
	UnrealSpline,
	HoudiniSpline
}
