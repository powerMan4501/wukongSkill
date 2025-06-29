using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERigEvent", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigEvent
{
	None,
	RequestAutoKey,
	Max
}
