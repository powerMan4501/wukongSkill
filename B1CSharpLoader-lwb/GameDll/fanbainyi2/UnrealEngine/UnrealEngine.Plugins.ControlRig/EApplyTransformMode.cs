using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EApplyTransformMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EApplyTransformMode
{
	Override,
	Additive,
	Max
}
