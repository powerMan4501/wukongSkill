using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESplinePointType", "Engine", UnrealModuleType.Engine)]
public enum ESplinePointType : byte
{
	Linear,
	Curve,
	Constant,
	CurveClamped,
	CurveCustomTangent
}
