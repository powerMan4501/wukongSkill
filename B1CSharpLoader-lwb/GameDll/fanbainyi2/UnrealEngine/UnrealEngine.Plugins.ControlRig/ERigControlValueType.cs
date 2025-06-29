using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ERigControlValueType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigControlValueType : byte
{
	Initial,
	Current,
	Minimum,
	Maximum
}
