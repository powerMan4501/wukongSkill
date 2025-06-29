using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERBFQuatDistanceType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERBFQuatDistanceType
{
	Euclidean,
	ArcLength,
	SwingAngle,
	TwistAngle
}
