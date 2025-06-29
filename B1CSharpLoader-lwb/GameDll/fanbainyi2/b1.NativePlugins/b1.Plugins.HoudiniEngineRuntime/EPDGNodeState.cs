using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EPDGNodeState", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EPDGNodeState
{
	None,
	Dirtied,
	Dirtying,
	Cooking,
	Cook_Complete,
	Cook_Failed
}
