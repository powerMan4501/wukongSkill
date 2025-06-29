using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERigUnitDebugPointMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigUnitDebugPointMode
{
	Point,
	Vector,
	Max
}
