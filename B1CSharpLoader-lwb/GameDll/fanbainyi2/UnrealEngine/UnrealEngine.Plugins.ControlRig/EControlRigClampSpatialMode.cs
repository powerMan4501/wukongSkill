using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EControlRigClampSpatialMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EControlRigClampSpatialMode
{
	Plane,
	Cylinder,
	Sphere
}
