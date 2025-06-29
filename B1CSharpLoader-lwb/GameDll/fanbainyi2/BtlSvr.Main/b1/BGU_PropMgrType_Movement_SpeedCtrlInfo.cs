using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_PropMgrType_Movement_SpeedCtrlInfo : BGU_PropMgrType_Movement
{
	public BGU_PropMgrType_Movement_SpeedCtrlInfo(UCharacterMovementComponent InMovementComp)
		: base(InMovementComp)
	{
		base.PropType = EPropType.Movement_SpeedCtrlInfo;
		base.CalcRule = EPropCalcRule.Sum;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_VectorPropRequest { Value: var value })
		{
			EvtCollection.Evt_UpdateSpeedCtrlInfoBySpdInfo.Invoke(value.X, value.Y, value.Z);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetVectorProperty.Invoke(base.PropType, in FVector.ZeroVector, 0u, 0u, bSetDefaultProperty: true);
	}
}
