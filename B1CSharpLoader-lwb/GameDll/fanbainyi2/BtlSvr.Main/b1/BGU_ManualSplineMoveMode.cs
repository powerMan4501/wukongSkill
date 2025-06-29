using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_ManualSplineMoveMode : BUC_MoveModeBase
{
	private FVector ForwardDir;

	private FVector RightDir;

	private float ForwardValue;

	private float RightValue;

	private float LengthScale = 1f;

	public override void MoveForward(float Value)
	{
		if (Value == 0f)
		{
			return;
		}
		if (!CheckCanRun())
		{
			if (!CheckCanRotate())
			{
				return;
			}
			Value *= 0.0001f;
		}
		AController ownerController = MoveSys.CharacterComps.OwnerController;
		if (ownerController != null && Value != 0f)
		{
			FRotator inRot = new FRotator(0.0, BGUFunctionLibraryCS.GetMoveYawDirection(ownerController, MoveSys.PlayerCameraManager).Yaw, 0.0);
			FVector forwardDir = MathLib.GetForwardVector(inRot) * LengthScale;
			ForwardDir = forwardDir;
			ForwardValue = Value;
		}
	}

	public override void MoveRight(float Value)
	{
		if (Value == 0f)
		{
			return;
		}
		if (!CheckCanRun())
		{
			if (!CheckCanRotate())
			{
				return;
			}
			Value *= 0.0001f;
		}
		AController ownerController = MoveSys.CharacterComps.OwnerController;
		if (ownerController != null && Value != 0f)
		{
			FRotator inRot = new FRotator(0.0, BGUFunctionLibraryCS.GetMoveYawDirection(ownerController, MoveSys.PlayerCameraManager).Yaw, 0.0);
			FVector rightDir = MathLib.GetRightVector(inRot) * LengthScale;
			RightDir = rightDir;
			RightValue = Value;
		}
	}

	protected override void OnUpdate(float DeltaTime)
	{
		BUS_GSEventCollection evtCollection = EvtCollection;
		FVector fVector = ForwardDir * ForwardValue + RightDir * RightValue;
		if (!fVector.IsZero())
		{
			USplineComponent splineComp = MoveSys.ManualSplineMoveData.SplineComp;
			if (splineComp == null)
			{
				return;
			}
			float curSplineInputKey = MoveSys.ManualSplineMoveData.CurSplineInputKey;
			FVector safeNormal = splineComp.GetDirectionAtSplineInputKey(curSplineInputKey, ESplineCoordinateSpace.World).GetSafeNormal();
			FVector obj = ((FVector.DotProduct(safeNormal, fVector.GetSafeNormal()) >= 0f) ? safeNormal : (-safeNormal));
			FVector safeNormal2 = splineComp.GetRightVectorAtSplineInputKey(curSplineInputKey, ESplineCoordinateSpace.World).GetSafeNormal();
			FVector fVector2 = (BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter) - splineComp.GetLocationAtSplineInputKey(curSplineInputKey, ESplineCoordinateSpace.World)).ProjectOnTo(safeNormal2);
			float mappedRangeValueClamped = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, OwnerCharacter.CapsuleComponent.GetScaledCapsuleRadius() * 2f), new FVector2D(0.0, 0.6000000238418579), fVector2.Size());
			FVector fVector3 = ((FVector.DotProduct(safeNormal2, fVector2.GetSafeNormal()) >= 0f) ? (-safeNormal2) : safeNormal2);
			FVector fVector4 = obj + fVector3 * mappedRangeValueClamped;
			evtCollection.Evt_SetMovementInput.Invoke(fVector4.GetSafeNormal(), 1f, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
			ForwardDir = (RightDir = FVector.ZeroVector);
			ForwardValue = (RightValue = 0f);
			MakeNoise();
		}
		if (MoveSys.ManualSplineMoveData.CurrentManualSplineMoveType == EManualSplineMoveType.MoveWithSpecialAnimation)
		{
			FRotator rotationTarget = MoveSys.SplineMoveData.GetRotationTarget(MoveSys.ChrData, MoveSys.AnimHumanoidHelperData, DeltaTime);
			BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, rotationTarget, bTeleportPhysics: false);
		}
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.ManualSplineMove;
	}
}
