using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_TurretRotateMoveMode : BUC_MoveModeBase
{
	private IBUC_TurretControlData TurretControlData { get; set; }

	private APlayerController PlayerController { get; set; }

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		TurretControlData = Parent.TurretControlData;
		PlayerController = Parent.PlayerCameraManager.GetOwningPlayerController();
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (!TurretControlData.bEnableTurretRotate)
		{
			return;
		}
		UBGUFunctionLibrary.BGUPlayerCtrlerGetViewPoint(PlayerController, out var out_Location, out var out_Rotation);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter);
		FRotator fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter);
		FVector fVector2 = out_Location + out_Rotation.Vector() * 10000.0;
		FRotator fRotator2 = MathLib.MakeRotFromX((fVector2 - fVector).GetSafeNormal());
		float num = MathLib.ClampAxis(fRotator.Yaw);
		float num2 = MathLib.ClampAxis(fRotator2.Yaw);
		float Target = MathLib.NormalizeAxis(num2 - num);
		float num3 = MathLib.Abs(Target);
		BUC_MovementData movementData = MoveSys.MovementData;
		if (movementData.CurrentState == ETurretRotateState.Idle && num3 >= TurretControlData.Turn2CameraTriggerYaw)
		{
			movementData.CurrentState = ETurretRotateState.TimeWaiting;
			movementData.TotalDelayTime = 0f;
		}
		if (movementData.CurrentState == ETurretRotateState.TimeWaiting)
		{
			movementData.TotalDelayTime += DeltaTime;
			if (movementData.TotalDelayTime >= TurretControlData.Turn2CameraDelay)
			{
				if (num3 >= TurretControlData.Turn2CameraTriggerYaw)
				{
					movementData.CurrentState = ETurretRotateState.Rotating;
				}
				else
				{
					movementData.CurrentState = ETurretRotateState.Idle;
				}
			}
		}
		if (movementData.CurrentState == ETurretRotateState.Rotating)
		{
			float num4 = num + MathLib.FInterpTo(0f, in Target, DeltaTime, TurretControlData.Turn2CameraYawSpeed);
			BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, new FRotator(fRotator.Pitch, num4, 0.0), bTeleportPhysics: false);
			if (MathLib.Abs(num4 - num2) <= 1E-08f)
			{
				movementData.CurrentState = ETurretRotateState.Idle;
			}
		}
	}

	protected override void OnEnd()
	{
		MoveSys.MovementData.CurrentState = ETurretRotateState.Idle;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.TurretRotate;
	}
}
