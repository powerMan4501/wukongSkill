using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EBoneGetterSetterMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EBoneGetterSetterMode
{
	LocalSpace,
	GlobalSpace,
	Max
}
