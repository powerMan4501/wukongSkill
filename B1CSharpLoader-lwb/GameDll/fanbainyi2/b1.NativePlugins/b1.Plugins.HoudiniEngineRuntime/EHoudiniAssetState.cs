using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniAssetState", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniAssetState
{
	NeedInstantiation,
	NewHDA,
	PreInstantiation,
	Instantiating,
	PreCook,
	Cooking,
	PostCook,
	PreProcess,
	Processing,
	None,
	NeedRebuild,
	NeedDelete,
	Deleting,
	ProcessTemplate
}
