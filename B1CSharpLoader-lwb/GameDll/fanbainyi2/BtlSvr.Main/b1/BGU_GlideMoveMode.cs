using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_GlideMoveMode : BUC_MoveModeBase
{
	private float ForwardValue;

	private float RightValue;

	public override void MoveForward(float Value)
	{
		ForwardValue = Value;
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
			FVector inputDirection = MathLib.GetForwardVector(inRot);
			AddGlideMoveInput(OwnerCharacter, inputDirection, Value);
		}
	}

	public override void MoveRight(float Value)
	{
		RightValue = Value;
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
			FVector inputDirection = MathLib.GetRightVector(inRot);
			AddGlideMoveInput(OwnerCharacter, inputDirection, Value);
		}
	}

	private void AddGlideMoveInput(ACharacter Chr, FVector InputDirection, float Value)
	{
		FVector fVector = FVector.CrossProduct(FVector.UpVector, MoveSys.SurfaceCheckData.SurfaceNormal_Normalized);
		int num;
		FVector fVector2;
		if (!fVector.IsZero())
		{
			num = (MoveSys.GlideMoveData.GlideDirection.IsZero() ? 1 : 0);
			if (num == 0)
			{
				fVector2 = InputDirection.ProjectOnTo(MoveSys.GlideMoveData.GlideDirectionXYPlane);
				goto IL_0061;
			}
		}
		else
		{
			num = 1;
		}
		fVector2 = FVector.ZeroVector;
		goto IL_0061;
		IL_0061:
		FVector fVector3 = fVector2;
		FVector fVector4 = ((num != 0) ? FVector.ZeroVector : InputDirection.ProjectOnTo(fVector));
		FVector direction = ((num != 0) ? FVector.ZeroVector : (InputDirection.ProjectOnTo(MoveSys.GlideMoveData.GlideDirection).GetSafeNormal() * fVector3.Size()));
		float num2 = 1f;
		FRotator rotation = Chr.GetVelocity().Rotation();
		rotation.Roll = 0f;
		rotation.Pitch = 0f;
		FRotator fRotator = MathLib.InverseTransformRotation(new FTransform(MoveSys.GlideMoveData.GlideDirectionXYPlane.Rotation()), rotation);
		FVector a = fVector4 * Value;
		a.Normalize();
		float num3 = FVector.DotProduct(a, fVector);
		if (num3 > 0f)
		{
			if (fRotator.Yaw > 0f)
			{
				num2 = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, MoveSys.GlideMoveData.GlideDirectionMaxHoriAngle), new FVector2D(1.0, 0.0), fRotator.Yaw);
			}
		}
		else if (num3 < 0f && fRotator.Yaw < 0f)
		{
			num2 = FMath.GetMappedRangeValueClamped(new FVector2D(0f - MoveSys.GlideMoveData.GlideDirectionMaxHoriAngle, 0.0), new FVector2D(0.0, 1.0), fRotator.Yaw);
		}
		EvtCollection.Evt_SetMovementInput.Invoke(direction, Value * MoveSys.GlideMoveData.GlideSpeedInputScale, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Chr));
		EvtCollection.Evt_SetMovementInput.Invoke(fVector4, Value * MoveSys.GlideMoveData.MoveControlReactionSpeed * num2, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Chr));
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (!(OwnerCharacter == null) && !MoveSys.UnitStateData.HasState(EBGUUnitState.Dead))
		{
			EvtCollection.Evt_SetMovementInput.Invoke(MoveSys.GlideMoveData.GlideDirection, MoveSys.GlideMoveData.GlideDirectionInputScale, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
			MakeNoise();
			FVector velocity = OwnerCharacter.GetVelocity();
			if (!(velocity.Size() <= 10f))
			{
				FRotator target = velocity.Rotation();
				target.Roll = 0f;
				target.Pitch = 0f;
				FRotator newRotation = FMath.RInterpTo(BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter), target, DeltaTime, 10f);
				BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, newRotation, bTeleportPhysics: false);
			}
		}
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.GlideMove;
	}
}
