using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERBFVectorDistanceType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERBFVectorDistanceType
{
	Euclidean,
	Manhattan,
	ArcLength
}
