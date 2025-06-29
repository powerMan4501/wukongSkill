using BtlB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUIOnlineTeleport : BUInteractActionTemplate
{
	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BGW_EventCollection.Get(User).Evt_InteractOpenUI(InteractiveActor, "UIPartyRoomMember", 0);
		BGS_EventCollectionCS.Get(User).Evt_BGS_OnlineTeleport.Invoke();
		return true;
	}
}
