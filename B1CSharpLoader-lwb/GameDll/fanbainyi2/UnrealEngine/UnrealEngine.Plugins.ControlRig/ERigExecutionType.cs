using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERigExecutionType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigExecutionType
{
	Runtime,
	Editing,
	Max
}
