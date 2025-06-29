using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_CloudMoveMode : BUC_MoveModeBase
{
	private float ForwardValue;

	private float RightValue;

	private float LengthScale = 1f;

	private float HeightLimitThreshold;

	private float HorizontalFlightAngleRange_Up;

	private float HorizontalFlightAngleRange_Down;

	public float MinimumHeightRestriction;

	public float MinimumHeightRestrictionThreshold;

	private IBUC_UnitStateData UnitStateData;

	public override void MoveForward(float Value)
	{
		ForwardValue = Value;
		if (ForwardValue != 0f && !CheckCanRun() && CheckCanRotate())
		{
			ForwardValue *= 0.0001f;
		}
	}

	public override void MoveRight(float Value)
	{
		RightValue = Value;
		if (RightValue != 0f && !CheckCanRun() && CheckCanRotate())
		{
			RightValue *= 0.0001f;
		}
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (UnitStateData.HasState(EBGUUnitState.Walking))
		{
			EvtCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputWalkRelease, 0f);
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter);
		float num = MoveSys.CloudMoveData.CurrentPositionHeightLimit - fVector.Z;
		FVector fVector2 = MoveSys.MovementData.FinalCloudMoveDir;
		if (num > 0f)
		{
			FVector fVector3 = fVector;
			FVector end = fVector3 - new FVector(0.0, 0.0, MinimumHeightRestriction + MinimumHeightRestrictionThreshold);
			if (USystemLibrary.LineTraceSingleByProfile(OwnerCharacter, fVector3, end, B1GlobalFNames.FlyingPawn, bTraceComplex: true, null, EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.White, FLinearColor.Red, 0f))
			{
				if (OutHit.Distance < MinimumHeightRestriction && fVector2.Size() > 0f)
				{
					OwnerCharacter.CharacterMovement.BrakingDecelerationFlying = 100000f;
				}
				float num2 = -1.2f * (OutHit.Distance - MinimumHeightRestriction) / MinimumHeightRestrictionThreshold + 0.2f;
				if (OutHit.Distance > MinimumHeightRestriction)
				{
					num2 = FMath.Min(0f, num2);
				}
				fVector2.Z = FMath.Clamp(fVector2.Z, num2, 1f);
			}
			FVector safeNormal = new FVector(fVector2.X, fVector2.Y, 0.0).GetSafeNormal();
			end = fVector3 + safeNormal * MoveSys.ChrData.Velocity.Size();
			FVector fVector4 = new FVector(0.0, 0.0, OwnerCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight());
			if (USystemLibrary.LineTraceSingleByProfile(OwnerCharacter, fVector3 - fVector4, end - fVector4, B1GlobalFNames.FlyingPawn, bTraceComplex: true, null, EDrawDebugTrace.None, out OutHit, bIgnoreSelf: true, FLinearColor.White, FLinearColor.Red, 0f) && !USystemLibrary.LineTraceSingleByProfile(OwnerCharacter, fVector3 + fVector4, end + fVector4, B1GlobalFNames.FlyingPawn, bTraceComplex: true, null, EDrawDebugTrace.None, out OutHit, bIgnoreSelf: true, FLinearColor.White, FLinearColor.Red, 0f))
			{
				fVector2.Z += 0.2f;
			}
		}
		if ((double)fVector2.Size() < 0.2 || MoveSys.ChrData.Velocity.Size() < 100f)
		{
			MoveSys.MovementData.VelocityAccelerationDegree = FMath.FInterpTo(MoveSys.MovementData.VelocityAccelerationDegree, 0f, DeltaTime, FMath.Max(MoveSys.MovementData.VelocityAccelerationDegree, 10f));
		}
		else
		{
			double value = fVector2.Dot_VectorVector(MoveSys.ChrData.Velocity) / (double)fVector2.Size() / (double)MoveSys.ChrData.Velocity.Size();
			MoveSys.MovementData.VelocityAccelerationDegree = (float)FMath.RadiansToDegrees(FMath.Acos(value));
		}
		if (fVector2.Size() > 1f)
		{
			fVector2 = fVector2.GetSafeNormal();
		}
		if (MoveSys.CloudMoveData.bIsAutoCloudMoveEnabled)
		{
			fVector2 = (MoveSys.CloudMoveData.AutoMoveTargetLocation - fVector).GetSafeNormal();
		}
		EvtCollection.Evt_SetMovementInput.Invoke(fVector2, fVector2.Size() * LengthScale, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
		MoveSys.MovementData.FinalCloudMoveDir = FVector.ZeroVector;
		FRotator inRot = (MoveSys.MovementData.IsCloudFreeLookEnabled ? MoveSys.MovementData.CloudFreeLookMoveRotation : OwnerCharacter.GetControlRotation());
		float num3 = FRotator.NormalizeAxis(inRot.Pitch);
		if (num3 > HorizontalFlightAngleRange_Down && num3 < HorizontalFlightAngleRange_Up)
		{
			inRot.Pitch = 0f;
		}
		FVector forwardVector = inRot.GetForwardVector();
		FVector rightVector = inRot.GetRightVector();
		FVector fVector5 = forwardVector * ForwardValue + rightVector * RightValue;
		if (MoveSys.MovementData.IsCloudMoveLift)
		{
			fVector5.Z += 1f;
			fVector5 = fVector5.GetSafeNormal();
		}
		MoveSys.MovementData.IsCloudMoveVerticalLift = MoveSys.MovementData.IsCloudMoveLift && ForwardValue < 1E-08f && RightValue < 1E-08f;
		if ((!MoveSys.CloudMoveData.DisableHeightLimitIfNoInput || ForwardValue != 0f || RightValue != 0f || MoveSys.MovementData.IsCloudMoveLift) && num < HeightLimitThreshold)
		{
			float num4 = (num - HeightLimitThreshold) / HeightLimitThreshold;
			if (fVector5.Z < 0f)
			{
				num4 = ((fVector5.Z < num4) ? 0f : (num4 - fVector5.Z));
			}
			fVector5 += new FVector(0.0, 0.0, num4);
		}
		if (fVector5.Size() > 1f)
		{
			fVector5 = fVector5.GetSafeNormal();
		}
		BUC_MovementData movementData = MoveSys.MovementData;
		FVector finalCloudMoveDir = (MoveSys.MovementData.InputCloudMoveDir = fVector5);
		movementData.FinalCloudMoveDir = finalCloudMoveDir;
		MakeNoise();
		ForwardValue = 0f;
		RightValue = 0f;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.CloudMove;
	}

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		BGWDataAsset_CloudMoveConfig cloudMoveConfig = BGW_PreloadAssetMgr.Get(OwnerCharacter).CloudMoveConfig;
		HeightLimitThreshold = cloudMoveConfig.HeightLimitThreshold;
		HorizontalFlightAngleRange_Up = cloudMoveConfig.HorizontalFlightUpAngleRange;
		HorizontalFlightAngleRange_Down = cloudMoveConfig.HorizontalFlightDownAngleRange;
		MinimumHeightRestriction = cloudMoveConfig.MinimumHeightRestriction;
		MinimumHeightRestrictionThreshold = cloudMoveConfig.MinimumHeightRestrictionThreshold;
		UnitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(OwnerCharacter);
	}

	public void ResetVelocity()
	{
	}

	protected override void OnEnd()
	{
	}
}
