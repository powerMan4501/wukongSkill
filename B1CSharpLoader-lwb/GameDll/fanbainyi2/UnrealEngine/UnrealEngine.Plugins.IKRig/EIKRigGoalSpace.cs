using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/IKRig.EIKRigGoalSpace", "IKRig", UnrealModuleType.EnginePlugin)]
public enum EIKRigGoalSpace : byte
{
	Component,
	Additive,
	World
}
