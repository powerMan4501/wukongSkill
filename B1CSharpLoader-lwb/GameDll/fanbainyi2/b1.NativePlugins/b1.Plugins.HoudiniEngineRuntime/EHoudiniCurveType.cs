using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniCurveType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniCurveType
{
	Invalid = -1,
	Polygon,
	Nurbs,
	Bezier,
	Points
}
