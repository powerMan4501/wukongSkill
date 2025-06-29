using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ERigControlAxis", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigControlAxis : byte
{
	X,
	Y,
	Z
}
