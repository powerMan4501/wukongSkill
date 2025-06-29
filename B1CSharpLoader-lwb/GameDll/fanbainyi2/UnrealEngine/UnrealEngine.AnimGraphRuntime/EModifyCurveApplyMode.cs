using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.EModifyCurveApplyMode", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EModifyCurveApplyMode
{
	Add,
	Scale,
	Blend,
	WeightedMovingAverage,
	RemapCurve
}
