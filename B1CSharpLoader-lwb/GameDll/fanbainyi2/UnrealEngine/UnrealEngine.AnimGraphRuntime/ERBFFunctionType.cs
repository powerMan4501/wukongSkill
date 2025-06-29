using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.ERBFFunctionType", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ERBFFunctionType
{
	Gaussian,
	Exponential,
	Linear,
	Cubic,
	Quintic,
	DefaultFunction
}
