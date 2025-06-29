using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGUFuncLibForMove
{
	public static bool BeginMoveToPos(AActor Owner, FVector TargetPos, float AcceptableRadius, EAIMoveSpeedType SpeedRateType, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius, out int RequestIdx)
	{
		RequestIdx = 0;
		if (Owner != null && (RequestIdx = BGUFuncLibAICS.BGURequestAIMoveToLocation(Owner, TargetPos, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius)) > 0)
		{
			return true;
		}
		return false;
	}

	public static bool BeginMoveToPosOnWallOrCell(AActor Owner, FVector TargetPos, float AcceptableRadius, EAIMoveSpeedType SpeedRateType, float TurnSpeed, bool IncludeSelfRadius, out int RequestIdx)
	{
		RequestIdx = 0;
		if (Owner != null)
		{
			UBUC_ACharacterComponent unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<UBUC_ACharacterComponent>(Owner);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.OwnerMovement != null && unPersistentReadOnlyData.OwnerMovement.MovementMode == EMovementMode.MOVE_Flying && (RequestIdx = BGUFuncLibAICS.BGURequestAIWallAndCellMoveToLocation(Owner, TargetPos, SpeedRateType, TurnSpeed, AcceptableRadius, IncludeSelfRadius)) > 0)
			{
				return true;
			}
		}
		return false;
	}

	public static bool BeginMoveToTarget(AActor Owner, UnitLockTargetInfo TargetData, float AcceptableRadius, EAIMoveSpeedType SpeedRateType, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius, out int RequestIdx)
	{
		RequestIdx = 0;
		if (Owner != null && TargetData != null && TargetData.LockTargetActor != null && (RequestIdx = BGUFuncLibAICS.BGURequestAIMoveToTarget(Owner, TargetData, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius)) > 0)
		{
			return true;
		}
		return false;
	}

	public static bool BeginMoveToTarget(AActor Owner, AActor TargetActor, float AcceptableRadius, EAIMoveSpeedType SpeedRateType, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius, out int RequestIdx)
	{
		RequestIdx = 0;
		if (Owner != null && TargetActor != null && (RequestIdx = BGUFuncLibAICS.BGURequestAIMoveToTarget(Owner, TargetActor, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius)) > 0)
		{
			return true;
		}
		return false;
	}

	public static bool BeginRotateToTargetPos(AActor Owner, FVector TargetPos, float RotateSpeed, out int RequestIdx)
	{
		RequestIdx = 0;
		if (Owner != null && (RequestIdx = BGURotateToTargetPosInt(Owner, TargetPos, RotateSpeed)) > 0)
		{
			return true;
		}
		return false;
	}

	public static bool BeginMontageMoveToPos(AActor Owner, UAnimMontage Montage, FVector TargetPos, float PlayTimeRate, float PosOffset, out int RequestIdx)
	{
		RequestIdx = 0;
		if (Owner != null && Montage != null)
		{
			UGSE_AnimFuncLib.AnimMontageGetRootMotionLocationForScale(Montage, out var OutStartPos, out var OutEndPos, 0f, Montage.GetPlayLength());
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			FVector fVector2 = OutEndPos - OutStartPos;
			float scaleRate = (TargetPos - fVector).Size2D() / fVector2.Size2D();
			if ((RequestIdx = BGUFuncLibAICS.BGURequestAIMontageMoveTo(Owner, Montage, scaleRate, PlayTimeRate, PosOffset)) > 0)
			{
				return true;
			}
		}
		return false;
	}

	public static bool BeginMontageMoveToTarget(AActor Owner, UAnimMontage Montage, AActor Target, float PlayTimeRate, float PosOffset, out int RequestIdx)
	{
		RequestIdx = 0;
		if (Owner != null && Montage != null && Target != null)
		{
			UGSE_AnimFuncLib.AnimMontageGetRootMotionLocationForScale(Montage, out var OutStartPos, out var OutEndPos, 0f, Montage.GetPlayLength());
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			FVector fVector2 = OutEndPos - OutStartPos;
			float scaleRate = (BGUFuncLibActorTransformCS.BGUGetActorLocation(Target) - fVector).Size2D() / fVector2.Size2D();
			if ((RequestIdx = BGUFuncLibAICS.BGURequestAIMontageMoveTo(Owner, Montage, scaleRate, PlayTimeRate, PosOffset)) > 0)
			{
				return true;
			}
		}
		return false;
	}

	public static bool BeginMontageScaleMove(AActor Owner, UAnimMontage Montage, float ScaleRate, float PlayTimeRate, float PosOffset, out int RequestIdx)
	{
		RequestIdx = 0;
		if (Owner != null && Montage != null && (RequestIdx = BGUFuncLibAICS.BGURequestAIMontageMoveTo(Owner, Montage, ScaleRate, PlayTimeRate, PosOffset)) > 0)
		{
			return true;
		}
		return false;
	}

	public static void CancelMove(AActor Owner)
	{
		if (Owner != null)
		{
			BGUFuncLibAICS.BGUCancelAICurrentMove(Owner);
		}
	}

	public static bool IsMoveActive(AActor Owner)
	{
		bool result = false;
		if (Owner != null)
		{
			result = BGUFunctionLibraryCS.BGUIsMoving(Owner);
		}
		return result;
	}

	public static bool IsNeedIdleRotate(AActor Owner, AActor TargetActor)
	{
		if (Owner != null)
		{
			FVector start = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			FVector target = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor);
			FRotator fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			if (FMath.Abs(UMathLibrary.FindLookAtRotation(start, target).Yaw - fRotator.Yaw) > 80f)
			{
				return true;
			}
		}
		return false;
	}

	public static void BGUAISpiderMoveTo(AActor Owner, FVector TargetPos, FVector TargetNormal, ESpiderNavPositionType TargetPosType, float AcceptableRadius, EAIMoveSpeedType MoveSpeed)
	{
		if (Owner == null)
		{
			return;
		}
		if (Owner is BUTamerActor bUTamerActor)
		{
			Owner = bUTamerActor.GetMonster();
			if (Owner == null)
			{
				return;
			}
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_AISpiderMoveTo.Invoke(TargetPos, TargetNormal, TargetPosType, AcceptableRadius, MoveSpeed);
				bUS_GSEventCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.AISpiderMove, SetActive: true);
			}
		}
	}

	public static void BGUSetCharacterRotation(AActor Character, FRotator NewRotator)
	{
		BGUFuncLibActorTransformCS.BGUSetActorRotation(Character, NewRotator, bTeleportPhysics: false);
	}

	[Category("BGU|Move")]
	[BlueprintCallable]
	[UFunction]
	public static int BGURotateToTargetPosInt(AActor Unit, FVector TargetPos, float RotateSpeed)
	{
		if (Unit.IsNullOrDestroyed())
		{
			return 0;
		}
		BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
		if (unPersistentReadOnlyData == null)
		{
			return 0;
		}
		int lastMoveIdx = unPersistentReadOnlyData.GetLastMoveIdx();
		BUS_EventCollectionCS.Get(Unit).Evt_ActorRotateToPos.Invoke(TargetPos, RotateSpeed, bForceUpdate: false);
		int lastMoveIdx2 = unPersistentReadOnlyData.GetLastMoveIdx();
		if (lastMoveIdx2 != lastMoveIdx)
		{
			return lastMoveIdx2;
		}
		return 0;
	}

	[UFunction]
	[Category("BGU|Move")]
	[BlueprintCallable]
	public static void BGUMontageMove(AActor Character, UAnimMontage NeedPlayMontage, float ScaleRate, float PlayTimeRate, float MontagePosOffset, FName StartSectionName)
	{
		if (!(Character == null) && NeedPlayMontage != null)
		{
			BGUFuncLibAnim.BGUActorTryPlayMontage(Character, NeedPlayMontage, StartSectionName, EMontageBindReason.Default, ScaleRate, PlayTimeRate, MontagePosOffset);
		}
	}

	[Category("BGU|Move")]
	[BlueprintCallable]
	[UFunction]
	public static int BGUSetCanWalkOffLedge(AActor Unit, bool CanWalkOffLedge, int HandleID = 0)
	{
		if (Unit == null || Unit.IsPendingKill)
		{
			return 0;
		}
		if (HandleID == 0)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_SetBoolProperty.Invoke(EPropType.Movement_CanWalkOffLedges, CanWalkOffLedge);
			IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(Unit);
			if (readOnlyData != null)
			{
				return (int)readOnlyData.GetLastHandleID();
			}
		}
		else
		{
			BUS_EventCollectionCS.Get(Unit).Evt_SetBoolProperty.Invoke(EPropType.Movement_CanWalkOffLedges, CanWalkOffLedge, (uint)HandleID);
		}
		return HandleID;
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|Move")]
	public static void BGUResetCanWalkOffLedge(AActor Unit, int HandleID)
	{
		if (!(Unit == null) && !Unit.IsPendingKill)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_ResetProperty.Invoke((uint)HandleID);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[UMeta(MDFunc.WorldContext, "WorldContextObj")]
	[Category("BGU|Move")]
	public static void BGUTriggerPlayerJump(UObject WorldContextObj, FRotator JumpRotation)
	{
		ACharacter aCharacter = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContextObj).GetControlledPawn() as ACharacter;
		if (!(aCharacter == null))
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(aCharacter).TryGetCachedResourceObj<UAnimMontage>("AnimMontage'/Game/00Main/Animation/Player/Sunwukong/Montage/AM_Wukong_V4_Jump_Bridge.AM_Wukong_V4_Jump_Bridge'", ELoadResourceType.SyncLoadAndCache);
			if (!(uAnimMontage == null) && BGUFuncLibAnim.BGUActorTryPlayMontage(aCharacter, uAnimMontage, FName.None) != 0f)
			{
				BGUFunctionLibraryCS.BGUTriggerUnitState(aCharacter, EBUStateTrigger.AttackStateBegin, -1f);
				BGUFuncLibActorTransformCS.BGUSetActorRotation(aCharacter, JumpRotation, bTeleportPhysics: true);
			}
		}
	}

	[Category("BGU|Move")]
	[UFunction]
	[BlueprintPure]
	public static FVector4 BGUCalcRelativeVectorDirectionAlpha(FVector Vector, FRotator Rotation)
	{
		float num = 1f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		if (Vector.Size2D() > 0f)
		{
			Vector.Normalize();
			FVector fVector = Rotation.UnrotateVector(Vector);
			FVector fVector2 = fVector / (FMath.Abs(fVector.X) + FMath.Abs(fVector.Y) + FMath.Abs(fVector.Z));
			num = FMath.Clamp(fVector2.X, 0f, 1f);
			num2 = FMath.Abs(FMath.Clamp(fVector2.X, -1f, 0f));
			num3 = FMath.Abs(FMath.Clamp(fVector2.Y, -1f, 0f));
			num4 = FMath.Clamp(fVector2.Y, 0f, 1f);
		}
		return new FVector4(num, num2, num3, num4);
	}

	[Category("BGU|Move")]
	[BlueprintCallable]
	[UFunction]
	public static void BGUSplineFlyMove(bool bEnableSplineFlyMove, AActor Owner, BGUSplineActor SplineActor, FGSSplineFlyMoveInfo SplineFlyMoveInfo, EAIMoveSpeedType SpeedRateType = EAIMoveSpeedType.RUN, float TraceVelocityCameraSpeedRate = 1f)
	{
		if (Owner == null)
		{
			return;
		}
		ACharacter aCharacter = null;
		if (Owner as BUTamerActor != null)
		{
			aCharacter = (Owner as BUTamerActor).GetMonster();
		}
		if (aCharacter == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		if (bEnableSplineFlyMove && SplineActor != null)
		{
			bUS_GSEventCollection.Evt_SetSplineFlyControlInfo.Invoke(SplineActor, SplineFlyMoveInfo);
			bUS_GSEventCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.SplineFlyControl, SetActive: true);
			bUS_GSEventCollection.Evt_SetTraceVelocityCameraInfo.Invoke(bUseTraceVelocityCamera: true, TraceVelocityCameraSpeedRate);
			float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(aCharacter, SpeedRateType);
			unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
			bUS_GSEventCollection.Evt_AISetSpeedRate.Invoke(unitSpeedRateByMoveSpeedType, EBGUSpeedCtrlID.MoveSpeedRate);
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
			BUS_EventCollectionCS.Get(aCharacter).Evt_UnitStateTrigger.Invoke(triggerID, -1f);
		}
		else
		{
			bUS_GSEventCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.SplineFlyControl, SetActive: false);
			bUS_GSEventCollection.Evt_SetTraceVelocityCameraInfo.Invoke(bUseTraceVelocityCamera: false, 0f);
			UCharacterMovementComponent uCharacterMovementComponent = aCharacter.GetMovementComponent() as UCharacterMovementComponent;
			if (uCharacterMovementComponent != null)
			{
				uCharacterMovementComponent.Velocity = FVector.ZeroVector;
			}
		}
	}

	[Category("BGU|Move")]
	[BlueprintCallable]
	[UFunction]
	public static void BGUNpcGuideSplineMove(bool bEnableNpcGuideSplineMove, AActor Owner, string SplineGuid, bool NeedSwitchSpeedByDistanceToPlayer, EAIMoveSpeedType SplineMoveSpeed, float MaxDistance_Sprint, float MaxDistance_Run, float MaxDistance_Jog, float DistanceBuffer)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
		if (!(bUS_GSEventCollection == null))
		{
			if (bEnableNpcGuideSplineMove)
			{
				bUS_GSEventCollection.Evt_SetNpcGuideSplineMoveInfo.Invoke(SplineGuid, NeedSwitchSpeedByDistanceToPlayer, SplineMoveSpeed, MaxDistance_Sprint, MaxDistance_Run, MaxDistance_Jog, DistanceBuffer);
				bUS_GSEventCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.NpcGuideSplineMove, SetActive: true);
				bUS_GSEventCollection.Evt_AISetSpeedRate.Invoke(1f, EBGUSpeedCtrlID.MoveSpeedRate);
			}
			else
			{
				bUS_GSEventCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.NpcGuideSplineMove, SetActive: false);
			}
		}
	}

	[Category("BGU|Move")]
	[BlueprintCallable]
	[UFunction]
	public static void BGUNpcGuideSplineMoveTamer(bool bEnableNpcGuideSplineMove, ABGUTamerBase Owner, string SplineGuid, bool NeedSwitchSpeedByDistanceToPlayer, EAIMoveSpeedType SplineMoveSpeed, float MaxDistance_Sprint, float MaxDistance_Run, float MaxDistance_Jog, float DistanceBuffer)
	{
		if (Owner.GetActorGuid(out var OutActorGuid))
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, OutActorGuid);
			BUS_EventCollectionCS.Get(actorByGuid)?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AIInputWalk, -1f);
			BGUNpcGuideSplineMove(bEnableNpcGuideSplineMove, actorByGuid, SplineGuid, NeedSwitchSpeedByDistanceToPlayer, SplineMoveSpeed, MaxDistance_Sprint, MaxDistance_Run, MaxDistance_Jog, DistanceBuffer);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Move")]
	public static void BGUAISpiderMoveAction(AActor Owner, float MaxMoveTime, float AcceptableRadius, bool IncludeSelfRadius, bool IncludeTargetRadius, EBTTargetType BTTargetType, FTransform TargetTransform, ESpiderNavPositionType TargetPositionType, EAIMoveSpeedType MoveSpeed)
	{
		if (Owner == null)
		{
			return;
		}
		if (Owner is BUTamerActor bUTamerActor)
		{
			Owner = bUTamerActor.GetMonster();
			if (Owner == null)
			{
				return;
			}
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.SpiderMoveTo, new AINodeAction_SpiderMoveToParamInfo
				{
					MaxMoveTime = MaxMoveTime,
					AcceptableRadius = AcceptableRadius,
					IncludeSelfRadius = IncludeSelfRadius,
					IncludeTargetRadius = IncludeTargetRadius,
					BTTargetType = BTTargetType,
					TargetLocation = TargetTransform.Translation,
					TargetNormal = TargetTransform.Rotation.GetForwardVector(),
					TargetPositionType = TargetPositionType,
					SpeedRateType = MoveSpeed
				});
			}
		}
	}

	[BlueprintCallable]
	[Category("BGU|Move")]
	[UFunction]
	public static bool IsSpiderNavMoveActive(AActor Owner)
	{
		if (Owner == null)
		{
			return false;
		}
		IBUC_MovementData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MovementData, BUC_MovementData>(Owner);
		if (readOnlyData == null || !readOnlyData.IsMoveModeActive(EBGUMoveMode.AISpiderMove))
		{
			return false;
		}
		return !readOnlyData.IsSpiderMoveReached;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Move")]
	public static void BGURelativeFloatMove(AActor Owner, bool bEnableRelativeFloatMove)
	{
		if (Owner == null)
		{
			return;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
		if (bUS_GSEventCollection == null || !aCharacter.GetComponentByClass<BUS_ExtendConfigComp>().FloatRelativeSpotActor.IsValid())
		{
			return;
		}
		if (bEnableRelativeFloatMove)
		{
			bUS_GSEventCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.RelativeFloatMove, SetActive: true);
			return;
		}
		bUS_GSEventCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.RelativeFloatMove, SetActive: false);
		UCharacterMovementComponent uCharacterMovementComponent = aCharacter.GetMovementComponent() as UCharacterMovementComponent;
		if (uCharacterMovementComponent != null)
		{
			uCharacterMovementComponent.Velocity = FVector.ZeroVector;
		}
	}
}
