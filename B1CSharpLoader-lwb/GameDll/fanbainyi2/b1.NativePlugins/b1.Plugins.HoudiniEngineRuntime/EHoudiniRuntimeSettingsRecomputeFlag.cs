using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniRuntimeSettingsRecomputeFlag", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniRuntimeSettingsRecomputeFlag
{
	HRSRF_Always,
	HRSRF_OnlyIfMissing,
	HRSRF_Never
}
