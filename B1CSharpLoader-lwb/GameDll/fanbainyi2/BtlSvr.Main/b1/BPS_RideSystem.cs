using b1.EventDelDefine;

namespace b1;

public class BPS_RideSystem : PlayerControllerSystemBase
{
	public override void OnAttach()
	{
		base.OnAttach();
		if (GetPlayerEventCollection() != null)
		{
			GetPlayerEventCollection().Evt_TriggerAllowRide += new Del_Void_Bool(OnTriggerAllowRide);
		}
	}

	private void OnTriggerAllowRide(bool bAllow)
	{
		if (bAllow)
		{
			BGW_EventCollection.Get(Owner).Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.Ride, bEnable: true);
			return;
		}
		BGW_EventCollection.Get(Owner).Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.Ride, bEnable: false);
		BPS_EventCollectionCS.Get(base.PlayerController).Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CantRide, default(PlayerTransParam));
	}
}
