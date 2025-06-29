using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EPDGBakeSelectionOption", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EPDGBakeSelectionOption
{
	All,
	SelectedNetwork,
	SelectedNode
}
