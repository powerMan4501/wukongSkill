using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniAssetStateResult", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniAssetStateResult
{
	None,
	Working,
	Success,
	FinishedWithError,
	FinishedWithFatalError,
	Aborted
}
