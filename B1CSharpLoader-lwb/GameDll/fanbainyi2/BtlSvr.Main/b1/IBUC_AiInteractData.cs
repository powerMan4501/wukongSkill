using b1.ECS;
using BtlB1;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_AiInteractData
{
	EntitySharedRef BestInteractEntityRef { get; }

	Entity CurrentInteractingEntityRef { get; }

	FTransform MatchingPosTargetTransform { get; }

	FUStInteractionMappingDesc InteractActionDesc { get; }
}
