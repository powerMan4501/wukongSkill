using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.ERBFDistanceMethod", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ERBFDistanceMethod
{
	Euclidean,
	Quaternion,
	SwingAngle,
	TwistAngle,
	DefaultMethod
}
