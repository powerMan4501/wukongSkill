using BtlB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUIPartyRoom : BUInteractActionTemplate
{
	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BGS_EventCollectionCS.Get(User).Evt_BGS_ShowPartyRoomUI.Invoke();
		return true;
	}
}
