using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Movement_BrakingFriction : BGU_PropMgrType_Movement
{
	public BGU_PropMgrType_Movement_BrakingFriction(UCharacterMovementComponent InMovementComp)
		: base(InMovementComp)
	{
		base.PropType = EPropType.Movement_BrakingFriction;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_FloatPropRequest bGU_FloatPropRequest)
		{
			base.MovementComp.BrakingFriction = bGU_FloatPropRequest.Value;
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetFloatProperty.Invoke(base.PropType, base.MovementComp.BrakingFriction, 0u, 0u, bSetDefaultProperty: true);
	}
}
