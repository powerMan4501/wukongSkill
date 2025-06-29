using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAnimCurveType", "Engine", UnrealModuleType.Engine)]
public enum EAnimCurveType
{
	AttributeCurve,
	MaterialCurve,
	MorphTargetCurve,
	MaxAnimCurveType
}
