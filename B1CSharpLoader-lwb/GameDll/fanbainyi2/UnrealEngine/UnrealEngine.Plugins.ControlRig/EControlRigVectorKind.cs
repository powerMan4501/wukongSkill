using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EControlRigVectorKind", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EControlRigVectorKind
{
	Direction,
	Location
}
