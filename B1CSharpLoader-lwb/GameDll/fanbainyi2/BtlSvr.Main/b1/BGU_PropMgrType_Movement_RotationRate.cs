using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Movement_RotationRate : BGU_PropMgrType_Movement
{
	public BGU_PropMgrType_Movement_RotationRate(UCharacterMovementComponent InMovementComp)
		: base(InMovementComp)
	{
		base.PropType = EPropType.Movement_RotationRate;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_RotatorPropRequest bGU_RotatorPropRequest)
		{
			base.MovementComp.RotationRate = bGU_RotatorPropRequest.Value;
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetRotatorProperty.Invoke(base.PropType, base.MovementComp.RotationRate, 0u, 0u, bSetDefaultProperty: true);
	}
}
