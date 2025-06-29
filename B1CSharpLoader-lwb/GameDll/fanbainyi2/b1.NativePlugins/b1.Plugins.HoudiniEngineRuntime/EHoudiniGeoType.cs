using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniGeoType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniGeoType
{
	Invalid,
	Default,
	Intermediate,
	Input,
	Curve
}
