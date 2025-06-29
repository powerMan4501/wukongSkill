using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERigUnitVisualDebugPointMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigUnitVisualDebugPointMode
{
	Point,
	Vector,
	Max
}
