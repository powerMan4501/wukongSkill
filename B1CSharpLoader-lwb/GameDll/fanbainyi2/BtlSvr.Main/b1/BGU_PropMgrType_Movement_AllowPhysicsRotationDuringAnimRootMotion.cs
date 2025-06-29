using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Movement_AllowPhysicsRotationDuringAnimRootMotion : BGU_PropMgrType_Movement
{
	public BGU_PropMgrType_Movement_AllowPhysicsRotationDuringAnimRootMotion(UCharacterMovementComponent InMovementComp)
		: base(InMovementComp)
	{
		base.PropType = EPropType.Movement_AllowPhysicsRotationDuringAnimRootMotion;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_BoolPropRequest bGU_BoolPropRequest)
		{
			base.MovementComp.AllowPhysicsRotationDuringAnimRootMotion = bGU_BoolPropRequest.Value;
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetBoolProperty.Invoke(base.PropType, base.MovementComp.AllowPhysicsRotationDuringAnimRootMotion, 0u, 0u, bSetDefaultProperty: true);
	}
}
