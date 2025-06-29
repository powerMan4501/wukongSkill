using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ETransformSpaceMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ETransformSpaceMode
{
	LocalSpace,
	GlobalSpace,
	BaseSpace,
	BaseJoint,
	Max
}
