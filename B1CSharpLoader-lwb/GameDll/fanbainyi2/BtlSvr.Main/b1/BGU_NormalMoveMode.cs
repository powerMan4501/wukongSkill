using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_NormalMoveMode : BUC_MoveModeWithInputFilterBase
{
	public static bool GMFlyMode;

	private float LengthScale = 1f;

	private uint MovementModeHandleID;

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
			if (GMFlyMode)
			{
				rightDir.Z = Value;
			}
			RightDir = rightDir;
			RightValue = Value;
		}
	}

	protected override void OnUpdate(float DeltaTime)
	{
		base.OnUpdate(DeltaTime);
		BUS_GSEventCollection evtCollection = EvtCollection;
		MoveSys.MovementData.NormalMoveSpeed = OwnerCharacter.GetVelocity().Size();
		if (!base.ResultMoveInput.IsNearlyZero())
		{
			evtCollection.Evt_SetMovementInput.Invoke(base.ResultMoveInput.GetSafeNormal(), 1f, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
			ForwardDir = (RightDir = FVector.ZeroVector);
			ForwardValue = (RightValue = 0f);
			MakeNoise();
		}
		if (GMFlyMode)
		{
			if (MovementModeHandleID == 0)
			{
				evtCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "GMFlyMode");
				MovementModeHandleID = MoveSys.PropMgrData.GetLastHandleID();
			}
			else
			{
				evtCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, MovementModeHandleID, 0u, bSetDefaultProperty: false, "GMFlyMode");
			}
		}
		if (!MoveSys.MovementData.bInputMoving)
		{
			StopMove();
		}
	}

	protected override void OnEnd()
	{
		base.OnEnd();
		EvtCollection.Evt_ResetProperty.Invoke(MovementModeHandleID);
		MovementModeHandleID = 0u;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.Normal;
	}
}
