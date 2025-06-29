using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Actor_AttackerAbnormalDispID_Override : BGU_PropMgrType_Actor
{
	public BGU_PropMgrType_Actor_AttackerAbnormalDispID_Override(AActor InActor)
		: base(InActor)
	{
		base.PropType = EPropType.Actor_AttackerAbnormalDispID_Override;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_IntPropRequest { Value: var value } && base.Actor is BGUCharacterCS bGUCharacterCS)
		{
			bGUCharacterCS.AbnormalDispID_AsAttacker_Override = value;
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetIntProperty.Invoke(base.PropType, -1, 0u, 0u, bSetDefaultProperty: true);
	}
}
