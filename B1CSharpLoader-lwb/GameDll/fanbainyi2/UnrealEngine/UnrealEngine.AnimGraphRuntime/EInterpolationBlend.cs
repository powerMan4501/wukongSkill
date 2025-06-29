using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.EInterpolationBlend", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EInterpolationBlend
{
	Linear,
	Cubic,
	Sinusoidal,
	EaseInOutExponent2,
	EaseInOutExponent3,
	EaseInOutExponent4,
	EaseInOutExponent5
}
