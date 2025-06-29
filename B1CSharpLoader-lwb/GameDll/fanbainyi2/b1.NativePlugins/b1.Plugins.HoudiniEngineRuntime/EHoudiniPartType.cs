using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniPartType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniPartType
{
	Invalid,
	Mesh,
	Instancer,
	Curve,
	Volume
}
