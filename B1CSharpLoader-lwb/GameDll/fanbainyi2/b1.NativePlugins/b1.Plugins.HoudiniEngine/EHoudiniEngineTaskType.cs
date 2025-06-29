using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngine;

[UEnum]
[UMetaPath("/Script/HoudiniEngine.EHoudiniEngineTaskType", "HoudiniEngine", UnrealModuleType.GamePlugin)]
public enum EHoudiniEngineTaskType
{
	None,
	AssetInstantiation,
	AssetCooking,
	AssetDeletion,
	AssetProcess
}
