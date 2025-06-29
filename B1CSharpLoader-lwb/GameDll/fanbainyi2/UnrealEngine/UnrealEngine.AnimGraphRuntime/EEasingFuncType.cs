using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.EEasingFuncType", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EEasingFuncType
{
	Linear,
	Sinusoidal,
	Cubic,
	QuadraticInOut,
	CubicInOut,
	HermiteCubic,
	QuarticInOut,
	QuinticInOut,
	CircularIn,
	CircularOut,
	CircularInOut,
	ExpIn,
	ExpOut,
	ExpInOut,
	CustomCurve
}
