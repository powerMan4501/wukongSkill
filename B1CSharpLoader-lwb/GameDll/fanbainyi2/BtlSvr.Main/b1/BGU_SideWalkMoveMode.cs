using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_SideWalkMoveMode : BUC_MoveModeWithInputFilterBase
{
	private uint OrientRotationToMovementHandleID;

	private BUS_GSEventCollection BE;

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		BE = EvtCollection;
		OrientRotationToMovementHandleID = 0u;
	}

	public override void MoveForward(float Value)
	{
		if (CheckCanRun())
		{
			AController controller = OwnerCharacter.GetController();
			if (controller != null && Value != 0f)
			{
				FRotator inRot = new FRotator(0.0, BGUFunctionLibraryCS.GetMoveYawDirection(controller, MoveSys.PlayerCameraManager).Yaw, 0.0);
				FVector forwardDir = MathLib.GetForwardVector(inRot);
				ForwardDir = forwardDir;
				ForwardValue = Value;
			}
		}
	}

	public override void MoveRight(float Value)
	{
		if (CheckCanRun())
		{
			AController controller = OwnerCharacter.GetController();
			if (controller != null && Value != 0f)
			{
				FRotator inRot = new FRotator(0.0, BGUFunctionLibraryCS.GetMoveYawDirection(controller, MoveSys.PlayerCameraManager).Yaw, 0.0);
				FVector rightDir = MathLib.GetRightVector(inRot);
				RightDir = rightDir;
				RightValue = Value;
			}
		}
	}

	protected override void OnUpdate(float DeltaTime)
	{
		base.OnUpdate(DeltaTime);
		if (!base.ResultMoveInput.IsNearlyZero())
		{
			BE.Evt_SetMovementInput.Invoke(base.ResultMoveInput.GetSafeNormal(), 1f, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
			ForwardDir = (RightDir = FVector.ZeroVector);
			ForwardValue = (RightValue = 0f);
			MakeNoise();
		}
		APlayerController aPlayerController = OwnerCharacter.GetController() as APlayerController;
		if (aPlayerController == null || !aPlayerController.IsLocalController())
		{
			return;
		}
		if (OrientRotationToMovementHandleID == 0)
		{
			BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, Value: false);
			OrientRotationToMovementHandleID = MoveSys.PropMgrData.GetLastHandleID();
		}
		else
		{
			BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, Value: false, OrientRotationToMovementHandleID);
		}
		UnitLockTargetInfo targetInfo = GetTargetInfoData().GetTargetInfo();
		ABGUCharacter aBGUCharacter = targetInfo.LockTargetActor as ABGUCharacter;
		if ((aBGUCharacter == null || BGUFunctionLibraryCS.BGUIsUnitDead(aBGUCharacter)) && !BGUFunctionLibraryCS.BGUHasUnitState(OwnerCharacter, EBGUUnitState.ShooterMode) && !MoveSys.CameraData.IsInG4Mode())
		{
			StopMove();
			return;
		}
		FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(OwnerCharacter);
		FVector location = fTransform.GetLocation();
		FRotator Current = fTransform.GetRotation().Rotator();
		GetRotateInfo(out var TargetPos, out var _);
		if (BGUFunctionLibraryCS.BGUHasUnitState(OwnerCharacter, EBGUUnitState.ShooterMode))
		{
			UBGUFunctionLibrary.BGUPlayerCtrlerGetViewPoint(aPlayerController, out var out_Location, out var out_Rotation);
			FVector fVector = out_Rotation.Vector();
			out_Location += fVector * (location - out_Location);
			TargetPos = out_Location + fVector * 10000.0;
		}
		else if (aBGUCharacter == null && MoveSys.CameraData.IsInG4Mode())
		{
			UBGUFunctionLibrary.BGUPlayerCtrlerGetViewPoint(aPlayerController, out var _, out var out_Rotation2);
			TargetPos = location + out_Rotation2.Vector() * 1000.0;
		}
		else if (aBGUCharacter != null && !BGUFunctionLibraryCS.BGUIsUnitDead(aBGUCharacter))
		{
			TargetPos = ((!string.IsNullOrEmpty(targetInfo.LockTargetSkeletonSocketName)) ? aBGUCharacter.Mesh.GetSocketLocation(new FName(targetInfo.LockTargetSkeletonSocketName)) : (string.IsNullOrEmpty(targetInfo.LockTargetSceneCompName) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter) : aBGUCharacter.Mesh.GetSocketLocation(new FName(targetInfo.LockTargetSceneCompName))));
		}
		FVector x = TargetPos - location;
		x.Normalize();
		FRotator TargetRot = MathLib.MakeRotFromX(x);
		bool bForceSetRot = true;
		if (!BGUFunctionLibraryCS.BGUHasUnitState(OwnerCharacter, EBGUUnitState.ShooterMode))
		{
			UpdateTargetRotationForMotionMatching(ref TargetRot, ref bForceSetRot);
		}
		FRotator newRotation = MathLib.RInterpTo(in Current, in TargetRot, DeltaTime, 4f);
		newRotation.Pitch = 0f;
		newRotation.Roll = 0f;
		if (OwnerCharacter.GetVelocity().Size() < 0.05f)
		{
			bForceSetRot = false;
		}
		if (bForceSetRot)
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, newRotation, bTeleportPhysics: false);
		}
	}

	protected override void OnEnd()
	{
		base.OnEnd();
		BE.Evt_ResetProperty.Invoke(OrientRotationToMovementHandleID);
		ResetAllStatus();
		OrientRotationToMovementHandleID = 0u;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.SideWalk;
	}
}
