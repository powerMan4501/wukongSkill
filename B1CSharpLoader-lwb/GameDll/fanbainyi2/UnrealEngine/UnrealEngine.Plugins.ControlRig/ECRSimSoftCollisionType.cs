using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ECRSimSoftCollisionType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ECRSimSoftCollisionType
{
	Plane,
	Sphere,
	Cone
}
