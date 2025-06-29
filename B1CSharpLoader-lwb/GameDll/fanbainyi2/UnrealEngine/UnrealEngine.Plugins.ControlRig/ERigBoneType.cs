using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ERigBoneType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigBoneType : byte
{
	Imported,
	User
}
