using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ECRSimConstraintType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ECRSimConstraintType
{
	Distance,
	DistanceFromA,
	DistanceFromB,
	Plane
}
