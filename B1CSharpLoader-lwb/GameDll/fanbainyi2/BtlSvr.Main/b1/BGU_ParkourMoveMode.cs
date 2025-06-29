using UnrealEngine.Runtime;

namespace b1;

public class BGU_ParkourMoveMode : BUC_MoveModeBase
{
	private float ForwardValue;

	private float RightValue;

	private uint MovementModeHandleID;

	public override void MoveForward(float Value)
	{
		ForwardValue = Value;
	}

	public override void MoveRight(float Value)
	{
		RightValue = Value;
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (OwnerCharacter == null)
		{
			return;
		}
		MakeNoise();
		BUS_GSEventCollection evtCollection = EvtCollection;
		if (MovementModeHandleID == 0)
		{
			evtCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 6, 0u, 0u, bSetDefaultProperty: false, "ParkourMoveMode");
			MovementModeHandleID = MoveSys.PropMgrData.GetLastHandleID();
		}
		else
		{
			evtCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 6, MovementModeHandleID, 0u, bSetDefaultProperty: false, "ParkourMoveMode");
		}
		IBUC_ParkourMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ParkourMoveData, b1.BUC_ParkourMoveData>(OwnerCharacter);
		if (unPersistentReadOnlyData != null)
		{
			base.CppCharacterMovementComp.MoveUpdatedComponent(unPersistentReadOnlyData.ParkourDeltaMove, BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter), out var OutHit);
			if (OutHit.BlockingHit && OutHit.Time < 1f)
			{
				FVector parkourDeltaMove = unPersistentReadOnlyData.ParkourDeltaMove;
				UBGUFunctionLibraryForCS.BGUMovementComponentHandleImpact(base.CppCharacterMovementComp, OutHit, DeltaTime, parkourDeltaMove);
				UBGUFunctionLibraryForCS.BGUMovementComponentSlideAlongSurface(base.CppCharacterMovementComp, parkourDeltaMove, 1f - OutHit.Time, BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in OutHit.Normal), OutHit, bHandleImpact: true, out var _);
			}
		}
	}

	protected override void OnEnd()
	{
		EvtCollection.Evt_ResetProperty.Invoke(MovementModeHandleID);
		MovementModeHandleID = 0u;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.ParkourMove;
	}
}
