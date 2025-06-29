using UnrealEngine.Runtime;

namespace b1;

public class BGU_FlyControlMoveMode : BUC_MoveModeBase
{
	private float ForwardValue;

	private float RightValue;

	private float LengthScale = 1f;

	private FRotator VelocityRotation;

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
		if (Value != 0f)
		{
			FVector direction = OwnerCharacter.GetActorForwardVector() * LengthScale;
			EvtCollection.Evt_SetMovementInput.Invoke(direction, Value, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
			MakeNoise();
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
		if (Value != 0f)
		{
			FVector direction = OwnerCharacter.GetActorRightVector() * LengthScale;
			EvtCollection.Evt_SetMovementInput.Invoke(direction, Value, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
			MakeNoise();
		}
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (OwnerCharacter.GetLastMovementInputVector().Size() > 0f)
		{
			VelocityRotation = FMath.RInterpTo(VelocityRotation, OwnerCharacter.GetControlRotation(), DeltaTime, 3f);
			BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, VelocityRotation, bTeleportPhysics: true);
		}
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.FlyControl;
	}

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		VelocityRotation = OwnerCharacter.GetControlRotation();
	}

	public void ResetVelocity()
	{
		VelocityRotation = OwnerCharacter.GetControlRotation();
	}

	protected override void OnEnd()
	{
	}
}
