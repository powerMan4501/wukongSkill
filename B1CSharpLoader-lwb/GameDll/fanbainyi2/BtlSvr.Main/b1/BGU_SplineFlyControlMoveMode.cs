using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_SplineFlyControlMoveMode : BUC_MoveModeBase
{
	private float ForwardValue;

	private float RightValue;

	private bool bFirstUpdate = true;

	private FVector TargetLocalMoveOffsetVec;

	private FVector CurLocalMoveOffset;

	private FVector LastLocation;

	private uint MovementModeHandleID;

	public override void MoveForward(float Value)
	{
		if (GSGameplayCVar.CVar_ReverseSplineFlyVerticalInput.GetValueInGameThread() != 0)
		{
			Value *= -1f;
		}
		ForwardValue = Value;
	}

	public override void MoveRight(float Value)
	{
		RightValue = Value;
	}

	protected override void OnUpdate(float DeltaTime)
	{
		BUS_GSEventCollection evtCollection = EvtCollection;
		if (MovementModeHandleID == 0)
		{
			evtCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "SplineFlyControlMoveMode");
			MovementModeHandleID = MoveSys.PropMgrData.GetLastHandleID();
		}
		else
		{
			evtCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, MovementModeHandleID, 0u, bSetDefaultProperty: false, "SplineFlyControlMoveMode");
		}
		if (!CheckIsWaiting())
		{
			MakeNoise();
			UpdateLocalMoveOffset(DeltaTime);
			MoveAlongSpline(DeltaTime);
			ForwardValue = 0f;
			RightValue = 0f;
			bFirstUpdate = false;
		}
	}

	private bool CheckIsWaiting()
	{
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(OwnerCharacter);
		if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.SplineFlyWaiting))
		{
			bFirstUpdate = true;
			return true;
		}
		return false;
	}

	private void UpdateLocalMoveOffset(float DeltaTime)
	{
		IBUC_SplineFlyMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SplineFlyMoveData, b1.BUC_SplineFlyMoveData>(OwnerCharacter);
		if (unPersistentReadOnlyData != null)
		{
			float forwardValue = ForwardValue;
			float rightValue = RightValue;
			float num = unPersistentReadOnlyData.MaxMoveDistance * 0.5f;
			if (TargetLocalMoveOffsetVec.Z >= num && ForwardValue > 0f)
			{
				ForwardValue = FMath.GetMappedRangeValueClamped(new FVector2D(num, unPersistentReadOnlyData.MaxMoveDistance), new FVector2D(forwardValue, 0.0), TargetLocalMoveOffsetVec.Z);
			}
			if (TargetLocalMoveOffsetVec.Z <= 0f - num && ForwardValue < 0f)
			{
				ForwardValue = FMath.GetMappedRangeValueClamped(new FVector2D(num, unPersistentReadOnlyData.MaxMoveDistance), new FVector2D(forwardValue, 0.0), 0f - TargetLocalMoveOffsetVec.Z);
			}
			if (TargetLocalMoveOffsetVec.Y >= num && RightValue > 0f)
			{
				RightValue = FMath.GetMappedRangeValueClamped(new FVector2D(num, unPersistentReadOnlyData.MaxMoveDistance), new FVector2D(rightValue, 0.0), TargetLocalMoveOffsetVec.Y);
			}
			if (TargetLocalMoveOffsetVec.Y <= 0f - num && RightValue < 0f)
			{
				RightValue = FMath.GetMappedRangeValueClamped(new FVector2D(num, unPersistentReadOnlyData.MaxMoveDistance), new FVector2D(rightValue, 0.0), 0f - TargetLocalMoveOffsetVec.Y);
			}
			TargetLocalMoveOffsetVec.Z += ForwardValue * unPersistentReadOnlyData.VerticalMoveSpeed * DeltaTime;
			TargetLocalMoveOffsetVec.Y += RightValue * unPersistentReadOnlyData.HorizontalMoveSpeed * DeltaTime;
			TargetLocalMoveOffsetVec.X = 0f;
			if (TargetLocalMoveOffsetVec.Size() > unPersistentReadOnlyData.MaxMoveDistance)
			{
				TargetLocalMoveOffsetVec = TargetLocalMoveOffsetVec.GetSafeNormal() * unPersistentReadOnlyData.MaxMoveDistance;
			}
			CurLocalMoveOffset = FMath.VInterpTo(CurLocalMoveOffset, TargetLocalMoveOffsetVec, DeltaTime, 3f);
		}
	}

	private void MoveAlongSpline(float DeltaTime)
	{
		ACharacter ownerCharacter = OwnerCharacter;
		USplineComponent flyControlSpline = MoveSys.MovementData.FlyControlSpline;
		if (!flyControlSpline.IsNullOrDestroyed())
		{
			FVector locationAtDistanceAlongSpline = flyControlSpline.GetLocationAtDistanceAlongSpline(MoveSys.MovementData.SplineFlyDistance, ESplineCoordinateSpace.World);
			FVector directionAtDistanceAlongSpline = flyControlSpline.GetDirectionAtDistanceAlongSpline(MoveSys.MovementData.SplineFlyDistance, ESplineCoordinateSpace.World);
			FTransform t = new FTransform(BGUFuncLibActorTransformCS.BGUGetActorRotation(ownerCharacter), locationAtDistanceAlongSpline);
			FVector fVector = MathLib.TransformDirection(t, CurLocalMoveOffset.GetSafeNormal()) * CurLocalMoveOffset.Size();
			FVector fVector2 = FMath.VInterpTo(BGUFuncLibActorTransformCS.BGUGetActorLocation(ownerCharacter), locationAtDistanceAlongSpline + fVector, DeltaTime, MoveSys.MovementData.TransitionInterpSpeed);
			BGUFuncLibActorTransformCS.BGUSetActorLocation(ownerCharacter, fVector2, !bFirstUpdate, bFirstUpdate, out var HitResult, NeedReturnHitResult: true);
			if (HitResult.BlockingHit)
			{
				fVector = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in HitResult.Location) - locationAtDistanceAlongSpline;
				CurLocalMoveOffset = MathLib.InverseTransformDirection(t, fVector.GetSafeNormal()) * fVector.Size();
				TargetLocalMoveOffsetVec = CurLocalMoveOffset;
			}
			FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(ownerCharacter);
			if (fVector.Size() > 0.1f)
			{
				newRotation = FMath.RInterpTo(BGUFuncLibActorTransformCS.BGUGetActorRotation(ownerCharacter), fVector.Rotation(), DeltaTime, MoveSys.MovementData.RotationInterpSpeed);
			}
			newRotation.Roll = 0f;
			newRotation.Pitch = 0f;
			BGUFuncLibActorTransformCS.BGUSetActorRotation(ownerCharacter, newRotation, bTeleportPhysics: true);
			EvtCollection?.Evt_SetMovementInput.Invoke(directionAtDistanceAlongSpline, 1f, FromSvr: false);
			if (ForwardValue != 0f)
			{
				EvtCollection.Evt_SetMovementInput.Invoke(FVector.UpVector, ForwardValue, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(ownerCharacter));
			}
			if (RightValue != 0f)
			{
				EvtCollection.Evt_SetMovementInput.Invoke(FVector.CrossProduct(FVector.UpVector, directionAtDistanceAlongSpline).GetSafeNormal(), RightValue, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(ownerCharacter));
			}
			LastLocation = fVector2;
		}
	}

	protected override void OnEnd()
	{
		bFirstUpdate = true;
		TargetLocalMoveOffsetVec = FVector.ZeroVector;
		CurLocalMoveOffset = FVector.ZeroVector;
		LastLocation = FVector.ZeroVector;
		EvtCollection.Evt_ResetProperty.Invoke(MovementModeHandleID);
		MovementModeHandleID = 0u;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.SplineFlyControl;
	}
}
