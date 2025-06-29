using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Actor_ActorHiddenInGame : BGU_PropMgrType_Actor
{
	public BGU_PropMgrType_Actor_ActorHiddenInGame(AActor InActor)
		: base(InActor)
	{
		base.PropType = EPropType.Actor_ActorHiddenInGame;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_BoolPropRequest bGU_BoolPropRequest)
		{
			base.Actor.SetActorHiddenInGame(bGU_BoolPropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetBoolProperty.Invoke(base.PropType, Value: false, 0u, 0u, bSetDefaultProperty: true);
	}
}
