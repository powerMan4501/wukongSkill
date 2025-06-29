using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.ERBFNormalizeMethod", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ERBFNormalizeMethod
{
	OnlyNormalizeAboveOne,
	AlwaysNormalize,
	NormalizeWithinMedian,
	NoNormalization
}
