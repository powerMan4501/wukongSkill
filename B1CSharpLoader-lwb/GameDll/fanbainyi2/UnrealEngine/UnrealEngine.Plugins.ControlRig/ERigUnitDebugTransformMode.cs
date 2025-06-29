using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERigUnitDebugTransformMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigUnitDebugTransformMode
{
	Point,
	Axes,
	Box,
	Max
}
