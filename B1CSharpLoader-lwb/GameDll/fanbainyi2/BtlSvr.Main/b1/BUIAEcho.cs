using BtlB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUIAEcho : BUInteractActionTemplate
{
	public BUIAEcho()
	{
		ParamIntNum = 0;
		ParamStringNum = 0;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BUS_EventCollectionCS.Get(InteractiveActor).Evt_OnInteractTriggerEcho?.Invoke();
		return true;
	}
}
