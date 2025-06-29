using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EControlRigSetKey", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EControlRigSetKey
{
	DoNotCare,
	Always,
	Never
}
