using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Movement_MovementMode : BGU_PropMgrType_Movement
{
	public BGU_PropMgrType_Movement_MovementMode(UCharacterMovementComponent InMovementComp)
		: base(InMovementComp)
	{
		base.PropType = EPropType.Movement_MovementMode;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_EnumPropRequest bGU_EnumPropRequest && (uint)base.MovementComp.MovementMode != (byte)bGU_EnumPropRequest.Value)
		{
			base.MovementComp.SetMovementMode((EMovementMode)bGU_EnumPropRequest.Value, 0);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetEnumProperty.Invoke(base.PropType, (base.MovementComp.DefaultLandMovementMode == EMovementMode.MOVE_Flying) ? 5 : 3, 0u, 0u, bSetDefaultProperty: true, "Default");
	}
}
