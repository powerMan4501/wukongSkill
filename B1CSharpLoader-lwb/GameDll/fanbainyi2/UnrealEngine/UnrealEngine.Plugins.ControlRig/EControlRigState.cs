using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EControlRigState", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EControlRigState
{
	Init,
	Update,
	Invalid
}
