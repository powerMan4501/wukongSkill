using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETimeStretchCurveMapping", "Engine", UnrealModuleType.Engine)]
public enum ETimeStretchCurveMapping
{
	T_Original,
	T_TargetMin,
	T_TargetMax
}
