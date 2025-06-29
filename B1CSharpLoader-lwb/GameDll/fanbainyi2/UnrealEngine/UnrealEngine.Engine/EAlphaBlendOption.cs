using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAlphaBlendOption", "Engine", UnrealModuleType.Engine)]
public enum EAlphaBlendOption
{
	Linear,
	Cubic,
	HermiteCubic,
	Sinusoidal,
	QuadraticInOut,
	CubicInOut,
	QuarticInOut,
	QuinticInOut,
	CircularIn,
	CircularOut,
	CircularInOut,
	ExpIn,
	ExpOut,
	ExpInOut,
	Custom
}
