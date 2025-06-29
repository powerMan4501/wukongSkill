using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniLandscapeOutputBakeType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniLandscapeOutputBakeType
{
	Detachment,
	BakeToImage,
	BakeToWorld,
	InValid
}
