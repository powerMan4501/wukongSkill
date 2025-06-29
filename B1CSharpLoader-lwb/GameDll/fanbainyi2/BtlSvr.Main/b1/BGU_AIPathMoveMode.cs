using System;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_AIPathMoveMode : BUC_MoveModeWithRotateBase
{
	private BUS_GSEventCollection BE;

	private TStrongObjectPtr<UBGU_AIMover> mAIMover = new TStrongObjectPtr<UBGU_AIMover>();

	private int RequestID;

	private AController AICtrl;

	private uint OrientRotationToMovementHandleID;

	private bool bTriggerFromOnEnd;

	private bool bLastPathFollowingResultValid;

	private EPathFollowingResult LastPathFollowingResult;

	private bool bOverrideFacingTargetRotation;

	private FRotator OverrideFacingTargetRotation;

	private bool bTickTargetSoketLocation;

	private FVector LastTargetSoketLocation;

	private float LocationTetherSquareDistance;

	private FBGU_AIMoverRequest CurMoveRequest;

	private AActor CurAIMoveTargetActor;

	private IBUC_ActorTransformInfoData ActorTransformInfoData;

	private UBGU_AIMover AIMover
	{
		get
		{
			return mAIMover.Get();
		}
		set
		{
			mAIMover.Set(value);
		}
	}

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		AICtrl = null;
		AIMover = UObject.NewObject<UBGU_AIMover>(MoveSys);
		AIMover?.FBUE_OnMoveComplete.Bind(MoveSys, B1GlobalFNames.OnAIPathMoveModeMoveComplete);
		BE = EvtCollection;
		RequestID = -1;
		OrientRotationToMovementHandleID = 0u;
		bTriggerFromOnEnd = false;
		bOverrideFacingTargetRotation = false;
		OverrideFacingTargetRotation = FRotator.ZeroRotator;
		bTickTargetSoketLocation = false;
		LastTargetSoketLocation = FVector.ZeroVector;
		CurAIMoveTargetActor = null;
		LocationTetherSquareDistance = FMath.Square(100);
		ActorTransformInfoData = GetActorTransformInfoData();
	}

	public override void Release()
	{
		AIMover?.FBUE_OnMoveComplete.Unbind(MoveSys, B1GlobalFNames.OnAIPathMoveModeMoveComplete);
		AIMover = null;
		mAIMover.Dispose();
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.AIPathMove;
	}

	public bool IsOutOfRange()
	{
		return AIMover.IsOutOfRange();
	}

	public void BeginMoveToActor(AActor TargetActor, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		BeginAIPathMoveImpl(TargetActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor), SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
	}

	public void BeginMove(EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		BeginAIPathMoveImpl(SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
	}

	public void BeginMoveToLocation(FVector TargetLocation, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		BeginAIPathMoveImpl(null, TargetLocation, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
	}

	public void SetFacingTargetRotation(in FRotator TargetRotation)
	{
		bOverrideFacingTargetRotation = true;
		OverrideFacingTargetRotation = TargetRotation;
	}

	private void BeginAIPathMoveImpl(EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		AICtrl = OwnerCharacter.GetController();
		if (AICtrl != null)
		{
			AIMover.Init(AICtrl);
		}
		if (AICtrl == null)
		{
			return;
		}
		float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(OwnerCharacter, SpeedRateType);
		unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
		ChangeToTargetSpeed(unitSpeedRateByMoveSpeedType);
		UnitLockTargetInfo moveToTarget = GetTargetInfoData().GetMoveToTarget();
		FVector fVector = ((moveToTarget.LockTargetType != ELockTargetType.Point) ? BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(moveToTarget) : moveToTarget.LockPointLocation);
		AActor lockTargetActor = moveToTarget.LockTargetActor;
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
		BE.Evt_UnitStateTrigger.Invoke(triggerID, -1f);
		FBGU_AIMoverRequest fBGU_AIMoverRequest = default(FBGU_AIMoverRequest);
		fBGU_AIMoverRequest.AllowPartialPath = true;
		fBGU_AIMoverRequest.AcceptanceRadius = AcceptableRadius;
		fBGU_AIMoverRequest.CanStrafe = false;
		fBGU_AIMoverRequest.ReachTestIncludesAgentRadius = IncludeSelfRadius;
		fBGU_AIMoverRequest.ReachTestIncludesGoalRadius = IncludeTargetRadius;
		fBGU_AIMoverRequest.ProjectGoalLocation = true;
		fBGU_AIMoverRequest.UsePathfinding = true;
		MoveSys.MovementData.MoveAIType = MoveAIType;
		UBGUCrowdFollowingComponent uBGUCrowdFollowingComponent = AIMover.GetPathFollowingComponent() as UBGUCrowdFollowingComponent;
		if (uBGUCrowdFollowingComponent != null)
		{
			if (MoveSys.MovementData.MoveAIType == EBGUMoveAIType.Flock)
			{
				uBGUCrowdFollowingComponent.SupportFlock = true;
			}
			else
			{
				uBGUCrowdFollowingComponent.SupportFlock = false;
			}
		}
		bool value = MoveSys.MovementData.MoveAIType != EBGUMoveAIType.KeepFacingTarget && MoveSys.MovementData.MoveAIType != EBGUMoveAIType.FacingVelocity;
		if (OrientRotationToMovementHandleID == 0)
		{
			BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, value);
			OrientRotationToMovementHandleID = MoveSys.PropMgrData.GetLastHandleID();
		}
		else
		{
			BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, value, OrientRotationToMovementHandleID);
		}
		bool flag = false;
		if (lockTargetActor != null)
		{
			if (moveToTarget.LockTargetType != ELockTargetType.Actor)
			{
				fBGU_AIMoverRequest.TargetActor = null;
				fBGU_AIMoverRequest.TargetLocation = fVector;
				flag = true;
			}
			else
			{
				fBGU_AIMoverRequest.TargetActor = lockTargetActor;
				fBGU_AIMoverRequest.TargetLocation = lockTargetActor.GetActorLocation();
			}
		}
		else
		{
			fBGU_AIMoverRequest.TargetActor = null;
			fBGU_AIMoverRequest.TargetLocation = fVector;
		}
		if (GSGameplayCVar.CVar_AIPathMoveToDebugDraw.GetValueInGameThread() == 1)
		{
			UBGUFunctionLibraryForCS.BGUDrawLineArrowEx(OwnerCharacter.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter), (TargetInfo != null && TargetInfo.LockTargetActor != null) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetInfo.LockTargetActor) : fVector, 200f, FColor.Green, IsPersistentLines: false, 5f);
		}
		RequestID = -1;
		try
		{
			AIMover.MoveTo(fBGU_AIMoverRequest);
		}
		catch (Exception value2)
		{
			Console.WriteLine(value2);
			throw;
		}
		RequestID = AIMover.GetRequestID();
		ClearMoveRequestCache();
		if (flag)
		{
			LastTargetSoketLocation = fVector;
			CurAIMoveTargetActor = lockTargetActor;
			CurMoveRequest = fBGU_AIMoverRequest;
			bTickTargetSoketLocation = true;
		}
	}

	private void BeginAIPathMoveImpl(AActor TargetActor, FVector TargetLocation, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		AICtrl = OwnerCharacter.GetController();
		if (AICtrl != null)
		{
			AIMover.Init(AICtrl);
		}
		if (AICtrl == null)
		{
			return;
		}
		float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(OwnerCharacter, SpeedRateType);
		unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
		ChangeToTargetSpeed(unitSpeedRateByMoveSpeedType);
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
		BE.Evt_UnitStateTrigger.Invoke(triggerID, -1f);
		FBGU_AIMoverRequest request = default(FBGU_AIMoverRequest);
		request.AllowPartialPath = true;
		request.AcceptanceRadius = AcceptableRadius;
		request.CanStrafe = false;
		request.ReachTestIncludesAgentRadius = IncludeSelfRadius;
		request.ReachTestIncludesGoalRadius = IncludeTargetRadius;
		request.ProjectGoalLocation = true;
		request.UsePathfinding = true;
		MoveSys.MovementData.MoveAIType = MoveAIType;
		UBGUCrowdFollowingComponent uBGUCrowdFollowingComponent = AIMover.GetPathFollowingComponent() as UBGUCrowdFollowingComponent;
		if (uBGUCrowdFollowingComponent != null)
		{
			if (MoveSys.MovementData.MoveAIType == EBGUMoveAIType.Flock)
			{
				uBGUCrowdFollowingComponent.SupportFlock = true;
			}
			else
			{
				uBGUCrowdFollowingComponent.SupportFlock = false;
			}
		}
		bool value = MoveSys.MovementData.MoveAIType != EBGUMoveAIType.KeepFacingTarget && MoveSys.MovementData.MoveAIType != EBGUMoveAIType.FacingVelocity;
		if (OrientRotationToMovementHandleID == 0)
		{
			BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, value);
			OrientRotationToMovementHandleID = MoveSys.PropMgrData.GetLastHandleID();
		}
		else
		{
			BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, value, OrientRotationToMovementHandleID);
		}
		if (TargetActor != null)
		{
			request.TargetActor = TargetActor;
			request.TargetLocation = TargetLocation;
		}
		else
		{
			request.TargetActor = null;
			request.TargetLocation = TargetLocation;
		}
		if (GSGameplayCVar.CVar_AIPathMoveToDebugDraw.GetValueInGameThread() == 1)
		{
			UBGUFunctionLibraryForCS.BGUDrawLineArrowEx(OwnerCharacter.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter), (request.TargetActor != null) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(request.TargetActor) : request.TargetLocation, 200f, FColor.Green, IsPersistentLines: false, 5f);
		}
		RequestID = -1;
		try
		{
			AIMover.MoveTo(request);
		}
		catch (Exception value2)
		{
			Console.WriteLine(value2);
			throw;
		}
		RequestID = AIMover.GetRequestID();
	}

	private void ClearMoveRequestCache()
	{
		bTickTargetSoketLocation = false;
		LastTargetSoketLocation = FVector.ZeroVector;
		CurAIMoveTargetActor = null;
	}

	private bool CheckNeedRequestNewAIMove()
	{
		if (!bTickTargetSoketLocation)
		{
			return false;
		}
		if (CurAIMoveTargetActor == null || CurAIMoveTargetActor.IsNullOrDestroyed())
		{
			ClearMoveRequestCache();
			return false;
		}
		FBGU_AIMoverRequest curMoveRequest = CurMoveRequest;
		UnitLockTargetInfo moveToTarget = GetTargetInfoData().GetMoveToTarget();
		FVector fVector = BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(moveToTarget);
		if (moveToTarget.LockTargetActor as BGUCharacterCS == null || moveToTarget.LockTargetActor != CurAIMoveTargetActor)
		{
			ClearMoveRequestCache();
		}
		else
		{
			curMoveRequest.TargetActor = null;
			curMoveRequest.TargetLocation = fVector;
		}
		if (FVector.DistSquared2D(LastTargetSoketLocation, fVector) <= (double)LocationTetherSquareDistance)
		{
			return false;
		}
		RequestID = -1;
		try
		{
			AIMover.MoveTo(curMoveRequest);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			throw;
		}
		RequestID = AIMover.GetRequestID();
		CurMoveRequest = curMoveRequest;
		LastTargetSoketLocation = fVector;
		return true;
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (AICtrl == null || AICtrl.IsPendingKill)
		{
			StopMove();
			return;
		}
		if (AIMover.GetMoveStatus() != EPathFollowingStatus.Moving)
		{
			StopMove();
			return;
		}
		CheckNeedRequestNewAIMove();
		if (MoveSys.MovementData.MoveAIType == EBGUMoveAIType.KeepFacingTarget)
		{
			ActorTransformInfoData.GetNextUpdateRotation(out var OutRotator);
			FRotator TargetRot;
			if (bOverrideFacingTargetRotation)
			{
				TargetRot = OverrideFacingTargetRotation;
			}
			else
			{
				UnitLockTargetInfo moveToTarget = GetTargetInfoData().GetMoveToTarget();
				AActor lockTargetActor = moveToTarget.LockTargetActor;
				AActor aActor = ECSUtil.ToActor(MoveSys.AIData.Memory.LastTargetEntity);
				FVector fVector = ((lockTargetActor != null) ? ((moveToTarget.LockTargetType != ELockTargetType.SkeletonSocket || !(lockTargetActor as ABGUCharacter != null)) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor) : (lockTargetActor as ABGUCharacter).Mesh.GetSocketLocation(new FName(moveToTarget.LockTargetSkeletonSocketName))) : ((!(aActor != null)) ? MoveSys.AIData.Memory.TargetPosCache.GetLocation() : BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)));
				ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation);
				FVector fVector2 = OutRotator.Vector();
				FVector2D unitRotateAimDir = new FVector2D(fVector2.X, fVector2.Y);
				FVector2D unit2TargetDir = new FVector2D(fVector.X - OutLocation.X, fVector.Y - OutLocation.Y);
				float rotateAngle2D = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
				TargetRot = OutRotator;
				if (BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir))
				{
					TargetRot.Yaw = MathLib.NormalizeAxis(TargetRot.Yaw + rotateAngle2D);
				}
				else
				{
					TargetRot.Yaw = MathLib.NormalizeAxis(TargetRot.Yaw - rotateAngle2D);
				}
			}
			bool bForceSetRot = true;
			UpdateTargetRotationForMotionMatching(ref TargetRot, ref bForceSetRot);
			FRotator newRotation = MathLib.RInterpConstantTo(in OutRotator, in TargetRot, DeltaTime, 60f);
			if (MoveSys.AttrContainer != null)
			{
				newRotation = MathLib.RInterpConstantTo(in OutRotator, in TargetRot, DeltaTime, MoveSys.AttrContainer.GetFloatValue(EBGUAttrFloat.KptturnSpeed));
			}
			newRotation.Pitch = OutRotator.Pitch;
			newRotation.Roll = OutRotator.Roll;
			if (bForceSetRot)
			{
				EvtCollection.Evt_SetActorRotation.Invoke(newRotation, bTeleportPhysics: false);
			}
		}
		else if (MoveSys.MovementData.MoveAIType == EBGUMoveAIType.FacingVelocity)
		{
			ActorTransformInfoData.GetNextUpdateRotation(out var OutRotator2);
			FRotator TargetRot2 = OutRotator2;
			FVector velocity = OwnerCharacter.GetVelocity();
			if (velocity.Size() > 0.1f)
			{
				TargetRot2.Yaw = velocity.Rotation().Yaw;
			}
			bool bForceSetRot2 = true;
			UpdateTargetRotationForMotionMatching(ref TargetRot2, ref bForceSetRot2);
			TargetRot2 = FMath.RInterpTo(OutRotator2, TargetRot2, DeltaTime, 20f);
			TargetRot2.Pitch = OutRotator2.Pitch;
			TargetRot2.Roll = OutRotator2.Roll;
			if (bForceSetRot2)
			{
				EvtCollection.Evt_SetActorRotation.Invoke(TargetRot2, bTeleportPhysics: false);
			}
		}
	}

	public void OnAIPathMoveComplete(int MoveRequestID, EPathFollowingResult Result)
	{
		if (RequestID != MoveRequestID)
		{
			if (RequestID == -1)
			{
				bLastPathFollowingResultValid = true;
				LastPathFollowingResult = Result;
			}
			return;
		}
		ClearMoveRequestCache();
		if (Result != EPathFollowingResult.Success && Result != EPathFollowingResult.Aborted && Result != EPathFollowingResult.OffPath)
		{
			_ = 1;
		}
		int lastMoveIdx = GetActionRequestData().GetLastMoveIdx();
		AIMover.ResetRequest();
		if (!bTriggerFromOnEnd)
		{
			StopMove();
		}
		BE.Evt_AIPathMoveComplete.Invoke(lastMoveIdx, Result);
	}

	protected override void OnEnd()
	{
		bTriggerFromOnEnd = true;
		int requestID = RequestID;
		if (AIMover.IsRequestValid())
		{
			if (AIMover != null && AIMover.GetPathFollowingComponent() != null)
			{
				AIMover.AbortMove();
			}
			ResetAllStatus();
		}
		if (bLastPathFollowingResultValid)
		{
			OnAIPathMoveComplete(requestID, LastPathFollowingResult);
		}
		BE.Evt_ResetProperty.Invoke(OrientRotationToMovementHandleID);
		RequestID = -1;
		OrientRotationToMovementHandleID = 0u;
		bLastPathFollowingResultValid = false;
		bTriggerFromOnEnd = false;
		bOverrideFacingTargetRotation = false;
		OverrideFacingTargetRotation = FRotator.ZeroRotator;
	}
}
