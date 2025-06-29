using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngine;

[UEnum]
[UMetaPath("/Script/HoudiniEngine.EHoudiniEngineTaskState", "HoudiniEngine", UnrealModuleType.GamePlugin)]
public enum EHoudiniEngineTaskState
{
	None,
	Working,
	Success,
	FinishedWithError,
	FinishedWithFatalError,
	Aborted
}
