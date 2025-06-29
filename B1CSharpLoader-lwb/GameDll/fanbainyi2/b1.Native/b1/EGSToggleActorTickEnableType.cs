using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EGSToggleActorTickEnableType", "UnrealExtent", UnrealModuleType.Game)]
public enum EGSToggleActorTickEnableType : byte
{
	ActorTick,
	MoveComp,
	SKMeshComp,
	AkComp,
	AIComp,
	INCLUDE_CHILD_ACTOR
}
