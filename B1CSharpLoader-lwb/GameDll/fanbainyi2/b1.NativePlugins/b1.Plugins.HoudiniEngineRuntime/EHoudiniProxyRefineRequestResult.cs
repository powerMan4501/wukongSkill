using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniProxyRefineRequestResult", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniProxyRefineRequestResult
{
	Invalid,
	None,
	PendingCooks,
	Refined
}
