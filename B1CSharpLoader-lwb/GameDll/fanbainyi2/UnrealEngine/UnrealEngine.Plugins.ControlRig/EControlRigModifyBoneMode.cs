using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EControlRigModifyBoneMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EControlRigModifyBoneMode
{
	OverrideLocal,
	OverrideGlobal,
	AdditiveLocal,
	AdditiveGlobal,
	Max
}
