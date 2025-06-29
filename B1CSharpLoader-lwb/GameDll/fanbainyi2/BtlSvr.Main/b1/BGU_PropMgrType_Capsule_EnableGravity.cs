using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Capsule_EnableGravity : BGU_PropMgrType_Capsule
{
	public BGU_PropMgrType_Capsule_EnableGravity(UCapsuleComponent InCapsuleComp)
		: base(InCapsuleComp)
	{
		base.PropType = EPropType.Capsule_EnableGravity;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_BoolPropRequest bGU_BoolPropRequest && base.CapsuleComp.IsGravityEnabled() != bGU_BoolPropRequest.Value)
		{
			base.CapsuleComp.SetEnableGravity(bGU_BoolPropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetBoolProperty.Invoke(base.PropType, base.CapsuleComp.IsGravityEnabled(), 0u, 0u, bSetDefaultProperty: true);
	}
}
