using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Actor_CustomTimeDilation : BGU_PropMgrType_Actor
{
	public BGU_PropMgrType_Actor_CustomTimeDilation(AActor InActor)
		: base(InActor)
	{
		base.PropType = EPropType.Actor_CustomTimeDilation;
		base.CalcRule = EPropCalcRule.Mul;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_FloatPropRequest bGU_FloatPropRequest)
		{
			base.Actor.CustomTimeDilation = bGU_FloatPropRequest.Value;
			if (base.Actor is BGUCharacterCS bGUCharacterCS)
			{
				bGUCharacterCS.SetCustomTimeDilation_ForAllCSharpComps(base.Actor.CustomTimeDilation);
			}
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetFloatProperty.Invoke(base.PropType, base.Actor.CustomTimeDilation, 0u, 0u, bSetDefaultProperty: true);
	}
}
