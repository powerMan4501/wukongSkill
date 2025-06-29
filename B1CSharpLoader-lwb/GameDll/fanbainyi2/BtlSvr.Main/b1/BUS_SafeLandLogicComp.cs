using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SafeLandLogicComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorExit);
	}

	private void OnActorEnter(AActor OtherActor)
	{
		if (OtherActor.IsNullOrDestroyed())
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (!(bUS_GSEventCollection == null) && bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UpdateSafeLandFlag.Invoke(P1: true);
			}
		}
	}

	private void OnActorExit(AActor OtherActor)
	{
		if (OtherActor.IsNullOrDestroyed())
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (!(bUS_GSEventCollection == null) && bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UpdateSafeLandFlag.Invoke(P1: false);
			}
		}
	}
}
