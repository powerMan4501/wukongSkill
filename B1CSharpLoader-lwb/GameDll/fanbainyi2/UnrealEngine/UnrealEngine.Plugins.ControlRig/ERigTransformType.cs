using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERigTransformType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigTransformType
{
	InitialLocal,
	CurrentLocal,
	InitialGlobal,
	CurrentGlobal,
	NumTransformTypes
}
