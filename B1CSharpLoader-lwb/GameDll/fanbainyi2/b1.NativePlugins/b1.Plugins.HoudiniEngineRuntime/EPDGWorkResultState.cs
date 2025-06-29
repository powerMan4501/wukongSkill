using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EPDGWorkResultState", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EPDGWorkResultState
{
	None,
	ToLoad,
	Loading,
	Loaded,
	ToDelete,
	Deleting,
	Deleted,
	NotLoaded
}
