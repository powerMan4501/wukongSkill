using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Movement_MaxSwimSpeed : BGU_PropMgrType_Movement
{
	public BGU_PropMgrType_Movement_MaxSwimSpeed(UCharacterMovementComponent InMovementComp)
		: base(InMovementComp)
	{
		base.PropType = EPropType.Movement_MaxSwimSpeed;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_FloatPropRequest bGU_FloatPropRequest)
		{
			base.MovementComp.MaxSwimSpeed = bGU_FloatPropRequest.Value;
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetFloatProperty.Invoke(base.PropType, base.MovementComp.MaxSwimSpeed, 0u, 0u, bSetDefaultProperty: true);
	}
}
