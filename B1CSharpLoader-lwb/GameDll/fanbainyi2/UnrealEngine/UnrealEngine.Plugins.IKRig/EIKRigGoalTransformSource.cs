using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/IKRig.EIKRigGoalTransformSource", "IKRig", UnrealModuleType.EnginePlugin)]
public enum EIKRigGoalTransformSource : byte
{
	Manual,
	Bone,
	ActorComponent
}
