using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[UEnum]
[UMetaPath("/Script/ControlRigSpline.ESplineType", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public enum ESplineType
{
	BSpline,
	Hermite,
	Max
}
