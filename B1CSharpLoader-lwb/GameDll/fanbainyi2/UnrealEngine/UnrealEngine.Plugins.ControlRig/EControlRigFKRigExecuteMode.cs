using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EControlRigFKRigExecuteMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EControlRigFKRigExecuteMode
{
	Replace,
	Additive,
	Max
}
