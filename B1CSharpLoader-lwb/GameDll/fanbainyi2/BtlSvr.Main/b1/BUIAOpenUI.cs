using BtlB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUIAOpenUI : BUInteractActionTemplate
{
	public BUIAOpenUI()
	{
		ParamIntNum = 0;
		ParamStringNum = 0;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BGW_EventCollection.Get(User).Evt_InteractOpenUI(InteractiveActor, Action.ParamsString[0], (Action.ParamsInt.Count > 0) ? Action.ParamsInt[0] : 0);
		return true;
	}
}
