using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniInputType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniInputType
{
	Invalid,
	Geometry,
	Curve,
	Asset,
	Landscape,
	World,
	Skeletal,
	GeometryCollection
}
