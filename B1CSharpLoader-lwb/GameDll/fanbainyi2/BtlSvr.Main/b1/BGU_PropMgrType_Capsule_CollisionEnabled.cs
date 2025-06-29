using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Capsule_CollisionEnabled : BGU_PropMgrType_Capsule
{
	public BGU_PropMgrType_Capsule_CollisionEnabled(UCapsuleComponent InCapsuleComp)
		: base(InCapsuleComp)
	{
		base.PropType = EPropType.Capsule_CollisionEnabled;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_EnumPropRequest bGU_EnumPropRequest && (int)base.CapsuleComp.GetCollisionEnabled() != bGU_EnumPropRequest.Value)
		{
			base.CapsuleComp.SetCollisionEnabled((ECollisionEnabled)bGU_EnumPropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetEnumProperty.Invoke(base.PropType, (int)base.CapsuleComp.GetCollisionEnabled(), 0u, 0u, bSetDefaultProperty: true);
	}
}
