using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Capsule_CollisionResponseToChannels : BGU_PropMgrType_Capsule
{
	public BGU_PropMgrType_Capsule_CollisionResponseToChannels(UCapsuleComponent InCapsuleComp)
		: base(InCapsuleComp)
	{
		base.PropType = EPropType.Capsule_CollisionResponseToChannels;
		base.CalcRule = EPropCalcRule.Merge;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_CollisionResponsePropRequest bGU_CollisionResponsePropRequest)
		{
			UBGUFunctionLibCollisionChannel.BGUSetCollisionResponseToChannels(base.CapsuleComp, bGU_CollisionResponsePropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		UBGUFunctionLibCollisionChannel.BGUGetCollisionResponseToChannels(base.CapsuleComp, out var OutResponseToChannels);
		EvtCollection.Evt_SetCollisionResponseProperty.Invoke(base.PropType, OutResponseToChannels, 0u, 0u, bSetDefaultProperty: true);
	}
}
