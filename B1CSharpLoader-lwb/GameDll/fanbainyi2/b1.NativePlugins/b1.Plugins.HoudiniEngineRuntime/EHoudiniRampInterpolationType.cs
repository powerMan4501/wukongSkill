using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniRampInterpolationType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniRampInterpolationType
{
	InValid = -1,
	CONSTANT,
	LINEAR,
	CATMULL_ROM,
	MONOTONE_CUBIC,
	BEZIER,
	BSPLINE,
	HERMITE
}
