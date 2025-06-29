using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniProxyRefineResult", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniProxyRefineResult
{
	Invalid,
	Failed,
	Success,
	Skipped
}
