using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniOutputType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniOutputType
{
	Invalid,
	Mesh,
	Instancer,
	Landscape,
	Curve,
	Skeletal,
	GeometryCollection
}
