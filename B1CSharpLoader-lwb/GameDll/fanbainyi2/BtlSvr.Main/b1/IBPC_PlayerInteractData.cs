using b1.ECS;
using BtlB1;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBPC_PlayerInteractData
{
	EntitySharedRef BestInteractEntityRef { get; }

	Entity CurrentInteractingEntityRef { get; }

	bool TmpIsSpDrop { get; }

	FUStInteractionMappingDesc InteractActionDesc { get; }

	bool IsInInteraction();

	bool IsToolInteraction();
}
