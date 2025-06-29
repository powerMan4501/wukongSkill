using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ERigSpaceType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigSpaceType : byte
{
	Global,
	Bone,
	Control,
	Space
}
