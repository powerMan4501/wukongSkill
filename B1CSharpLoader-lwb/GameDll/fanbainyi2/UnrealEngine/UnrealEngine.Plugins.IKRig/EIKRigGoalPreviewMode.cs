using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/IKRig.EIKRigGoalPreviewMode", "IKRig", UnrealModuleType.EnginePlugin)]
public enum EIKRigGoalPreviewMode : byte
{
	Additive,
	Absolute
}
