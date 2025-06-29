using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_AIWallAndCellMove : BUC_MoveModeWithRotateBase
{
	private BUS_GSEventCollection BE;

	private uint OrientRotationToMovementHandleID;

	private AController AICtrl;

	private FVector TargetLoc;

	private bool IncludeSelf;

	private float Radius;

	private float TurnSpeed;

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		BE = EvtCollection;
		OrientRotationToMovementHandleID = 0u;
		AICtrl = null;
		IncludeSelf = false;
		Radius = 0f;
		TurnSpeed = 0f;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.AIWallAndCellMove;
	}

	public void BeginMoveToLocation(FVector TargetLocation, EAIMoveSpeedType SpeedRateType, float TurnSpeed, float AcceptableRadius, bool IncludeSelfRadius)
	{
		if (AICtrl == null)
		{
			AICtrl = MoveSys.CharacterComps.OwnerController;
		}
		if (!(AICtrl == null))
		{
			float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(OwnerCharacter, SpeedRateType);
			MoveSys.MovementData.MoveAIType = EBGUMoveAIType.Flock;
			TargetLoc = TargetLocation;
			this.TurnSpeed = TurnSpeed;
			Radius = AcceptableRadius;
			IncludeSelf = IncludeSelfRadius;
			ChangeToTargetSpeed((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
			EBUStateTrigger triggerID = EBUStateTrigger.AIInputRun;
			switch (SpeedRateType)
			{
			case EAIMoveSpeedType.JOG:
				triggerID = EBUStateTrigger.AIInputWalk;
				break;
			case EAIMoveSpeedType.RUN:
				triggerID = EBUStateTrigger.AIInputRun;
				break;
			case EAIMoveSpeedType.SPRINT:
				triggerID = EBUStateTrigger.AIInputSprint;
				break;
			}
			EvtCollection.Evt_UnitStateTrigger.Invoke(triggerID, -1f);
		}
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (AICtrl == null || AICtrl.IsPendingKill)
		{
			StopMove();
			return;
		}
		FRotator Current = BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter);
		FVector start = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter);
		FVector actorForwardVector = OwnerCharacter.GetActorForwardVector();
		bool flag = false;
		IBUC_ABPCommonSettingData commonData = MoveSys.CommonData;
		if (commonData == null)
		{
			return;
		}
		bool bForceSetRot = true;
		if (commonData.FinalABPMoveMode == EABPMoveMode.MotionMatching)
		{
			flag = true;
			FVector2D unitRotateAimDir = new FVector2D(actorForwardVector.X, actorForwardVector.Y);
			FVector2D unit2TargetDir = new FVector2D(TargetLoc.X - start.X, TargetLoc.Y - start.Y);
			FRotator TargetRot = Current;
			float rotateAngle2D = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
			if (BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir))
			{
				TargetRot.Yaw = MathLib.NormalizeAxis(TargetRot.Yaw - rotateAngle2D);
			}
			else
			{
				TargetRot.Yaw = MathLib.NormalizeAxis(TargetRot.Yaw + rotateAngle2D);
			}
			UpdateTargetRotationForMotionMatching(ref TargetRot, ref bForceSetRot);
			FRotator newRotation = MathLib.RInterpConstantTo(in Current, in TargetRot, DeltaTime, 60f);
			BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(OwnerCharacter);
			if (readOnlyData != null)
			{
				newRotation = MathLib.RInterpConstantTo(in Current, in TargetRot, DeltaTime, readOnlyData.GetFloatValue(EBGUAttrFloat.KptturnSpeed));
			}
			newRotation.Roll = Current.Roll;
			newRotation.Pitch = Current.Pitch;
			if (bForceSetRot)
			{
				BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, newRotation, bTeleportPhysics: false);
			}
		}
		if (!flag)
		{
			FRotator Target = MathLib.FindLookAtRotation(start, TargetLoc);
			FRotator fRotator = MathLib.RInterpConstantTo(in Current, in Target, DeltaTime, TurnSpeed);
			fRotator.Pitch = Target.Pitch;
			fRotator.Roll = Current.Roll;
			if (OrientRotationToMovementHandleID == 0)
			{
				BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, Value: true);
				OrientRotationToMovementHandleID = MoveSys.PropMgrData.GetLastHandleID();
			}
			else
			{
				BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, Value: true, OrientRotationToMovementHandleID);
			}
			base.CppCharacterMovementComp.AddInputVector(fRotator.Vector().GetSafeNormal());
		}
		float num = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter), TargetLoc);
		float num2 = (IncludeSelf ? 0 : 0);
		num2 += Radius;
		if (num <= num2)
		{
			StopMove();
		}
	}

	protected override void OnEnd()
	{
		BE.Evt_ResetProperty.Invoke(OrientRotationToMovementHandleID);
		OrientRotationToMovementHandleID = 0u;
		ResetAllStatus();
	}

	private void RotateMesh(FVector CurLoc, float DeltaTime)
	{
		FVector forwardVector = OwnerCharacter.Mesh.GetForwardVector();
		FRotator Current = OwnerCharacter.Mesh.RelativeRotation;
		FVector worldLocation = OwnerCharacter.Mesh.GetWorldLocation();
		FVector2D unitRotateAimDir = new FVector2D(forwardVector.X, forwardVector.Z);
		FVector2D unit2TargetDir = new FVector2D(TargetLoc.X - worldLocation.X, TargetLoc.Z - worldLocation.Z);
		FRotator Target = Current;
		float rotateAngle2D = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
		if (BGU_MoveUtil.IsBendDown(CurLoc, TargetLoc, IsFlip: true))
		{
			Target.Pitch = MathLib.NormalizeAxis(0f - rotateAngle2D);
		}
		else
		{
			Target.Pitch = MathLib.NormalizeAxis(rotateAngle2D);
		}
		FRotator newRotation = MathLib.RInterpConstantTo(in Current, in Target, DeltaTime, 60f);
		newRotation.Roll = Current.Roll;
		newRotation.Yaw = Current.Yaw;
		newRotation.Pitch = FMath.Clamp(newRotation.Pitch, -80f, 80f);
		OwnerCharacter.Mesh.SetRelativeRotation(newRotation, bSweep: false, out var _, bTeleport: false);
	}
}
