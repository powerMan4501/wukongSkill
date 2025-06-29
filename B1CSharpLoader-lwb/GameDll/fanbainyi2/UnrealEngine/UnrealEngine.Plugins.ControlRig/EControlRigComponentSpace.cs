using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EControlRigComponentSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EControlRigComponentSpace
{
	WorldSpace,
	ActorSpace,
	ComponentSpace,
	RigSpace,
	LocalSpace,
	Max
}
