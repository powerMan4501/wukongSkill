using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EAimMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EAimMode
{
	AimAtTarget,
	OrientToTarget
}
