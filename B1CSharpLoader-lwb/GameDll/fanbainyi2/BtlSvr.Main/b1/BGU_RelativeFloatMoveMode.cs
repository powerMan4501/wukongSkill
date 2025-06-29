using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_RelativeFloatMoveMode : BUC_MoveModeBase
{
	private uint MovementModeHandleID;

	protected override void OnUpdate(float DeltaTime)
	{
		b1.IBUC_RelativeFloatMoveData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_RelativeFloatMoveData, b1.BUC_RelativeFloatMoveData>(OwnerCharacter);
		if (readOnlyData != null && !(readOnlyData.FloatRelativeSpotActor == null))
		{
			BUS_GSEventCollection evtCollection = EvtCollection;
			if (MovementModeHandleID == 0)
			{
				evtCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "RelativeFloatMoveMode");
				MovementModeHandleID = MoveSys.PropMgrData.GetLastHandleID();
			}
			else
			{
				evtCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, MovementModeHandleID, 0u, bSetDefaultProperty: false, "RelativeFloatMoveMode");
			}
			AActor floatRelativeSpotActor = readOnlyData.FloatRelativeSpotActor;
			FTransform newTransform = new FTransform(floatRelativeSpotActor.GetActorRotation(), floatRelativeSpotActor.GetActorLocation() + new FVector(0.0, 0.0, readOnlyData.RelativeFloatHeight));
			OwnerCharacter?.SetActorTransform(newTransform, bSweep: true, out var _, bTeleport: false);
		}
	}

	protected override void OnEnd()
	{
		EvtCollection.Evt_ResetProperty.Invoke(MovementModeHandleID);
		MovementModeHandleID = 0u;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.RelativeFloatMove;
	}
}
