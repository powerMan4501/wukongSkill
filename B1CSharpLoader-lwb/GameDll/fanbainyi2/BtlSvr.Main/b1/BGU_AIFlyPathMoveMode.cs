using b1.Plugins.DonAINavigation;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_AIFlyPathMoveMode : BUC_MoveModeWithRotateBase
{
	private TWeakObject<AActor> mTargetActor;

	private BUS_GSEventCollection BE;

	private float MinimumProximityRequired { get; set; }

	private FDoNNavigationQueryParams QueryParams { get; set; }

	private FDoNNavigationDebugParams DebugParams { get; set; }

	private bool bVisualizePawnAsVoxels { get; set; }

	private bool bTeleportToDestinationUponFailure { get; set; }

	private float MinSelfRadiusPct { get; set; }

	private FVector TargetLocation { get; set; }

	protected AActor TargetActor
	{
		get
		{
			return mTargetActor.Get();
		}
		set
		{
			mTargetActor.Set(value);
		}
	}

	private bool bOverrideFacingTargetRotation { get; set; }

	private FRotator OverrideFacingTargetRotation { get; set; }

	private uint OrientRotationToMovementHandleID { get; set; }

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		BE = EvtCollection;
		MinimumProximityRequired = 2000f;
		bTeleportToDestinationUponFailure = false;
		MinSelfRadiusPct = 1.1f;
		bOverrideFacingTargetRotation = false;
		OverrideFacingTargetRotation = FRotator.ZeroRotator;
		OrientRotationToMovementHandleID = 0u;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.AIFlyMove;
	}

	public void BeginMoveToActor(AActor InTargetActor, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		TargetActor = InTargetActor;
		TargetLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(InTargetActor);
		BeginAIPathMoveImpl(SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
	}

	public void BeginMoveToLocation(FVector InTargetLocation, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		TargetActor = null;
		TargetLocation = InTargetLocation;
		BeginAIPathMoveImpl(SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
	}

	public void SetFacingTargetRotation(in FRotator TargetRotation)
	{
		bOverrideFacingTargetRotation = true;
		OverrideFacingTargetRotation = TargetRotation;
	}

	private void BeginAIPathMoveImpl(EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		if (!OwnerCharacter.IsNullOrDestroyed())
		{
			float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(OwnerCharacter, SpeedRateType);
			unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
			ChangeToTargetSpeed(unitSpeedRateByMoveSpeedType);
			MinimumProximityRequired = CalcGoalRadius(AcceptableRadius, IncludeSelfRadius, IncludeTargetRadius);
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
			MoveSys.MovementData.MoveAIType = MoveAIType;
			bool value = MoveAIType != EBGUMoveAIType.KeepFacingTarget && MoveAIType != EBGUMoveAIType.FacingVelocity;
			if (OrientRotationToMovementHandleID == 0)
			{
				BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, value);
				OrientRotationToMovementHandleID = MoveSys.PropMgrData.GetLastHandleID();
			}
			else
			{
				BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, value, OrientRotationToMovementHandleID);
			}
			if (GSGameplayCVar.CVar_AIPathMoveToDebugDraw.GetValueInGameThread() == 1)
			{
				UBGUFunctionLibraryForCS.BGUDrawLineArrowEx(OwnerCharacter.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter), (TargetActor != null) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor) : TargetLocation, 200f, FColor.Green, IsPersistentLines: false, 5f);
			}
			BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(OwnerCharacter);
			if (unPersistentReadOnlyData.DonNavManager == null || !unPersistentReadOnlyData.DonNavManager.IsLocationWithinNavigableWorld(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter)))
			{
				unPersistentReadOnlyData.DonNavManager = UDonNavigationHelper.DonNavigationManagerForActor(OwnerCharacter);
			}
			EBTNodeResult eBTNodeResult = SchedulePathfindingRequest(OwnerCharacter, TargetLocation);
			if (eBTNodeResult == EBTNodeResult.Failed || eBTNodeResult == EBTNodeResult.Aborted)
			{
				StopMove();
			}
		}
	}

	private float CalcGoalRadius(float AcceptableRadius, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		float actorBoundingSphereRadius = UGSE_CharacterFuncLib.GetActorBoundingSphereRadius(OwnerCharacter);
		float num = 0f;
		float num2 = 0f;
		if (TargetActor != null && IncludeTargetRadius)
		{
			num = UGSE_CharacterFuncLib.GetActorBoundingSphereRadius(TargetActor);
		}
		if (IncludeSelfRadius)
		{
			num2 = MinSelfRadiusPct;
		}
		return AcceptableRadius + num + actorBoundingSphereRadius * num2;
	}

	private bool IsTargetLocationChanged(float TriggerChangedThreshold)
	{
		if (TargetActor == null)
		{
			return false;
		}
		if ((BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor) - TargetLocation).Size() > TriggerChangedThreshold)
		{
			return true;
		}
		return false;
	}

	public void Pathfinding_OnFinish(ref FDoNNavigationQueryData Data)
	{
		APawn aPawn = Data.Actor.Get() as APawn;
		if (aPawn == null)
		{
			return;
		}
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(aPawn);
		if (unPersistentReadOnlyData == null)
		{
			return;
		}
		unPersistentReadOnlyData.QueryResults = Data;
		if (Data.PathSolutionOptimized.Count == 0)
		{
			if (bTeleportToDestinationUponFailure)
			{
				TeleportAndExit(aPawn, bWrapUpLatentTask: false);
				Data.QueryStatus = EDonNavigationQueryStatus.Success;
			}
			else
			{
				Data.QueryStatus = EDonNavigationQueryStatus.Failure;
			}
			unPersistentReadOnlyData.QueryResults = Data;
		}
		else if (unPersistentReadOnlyData.bIsANavigator)
		{
			UDonNavigationHelper.OnLocomotionBegin(aPawn);
			UDonNavigationHelper.OnNextSegment(aPawn, Data.PathSolutionOptimized[0]);
		}
	}

	public void Pathfinding_OnDynamicCollisionAlert(in FDonNavigationDynamicCollisionPayload Data)
	{
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(Data.OwnerPayload.Value);
		if (unPersistentReadOnlyData != null)
		{
			unPersistentReadOnlyData.bSolutionInvalidatedByDynamicObstacle = true;
		}
	}

	protected override void OnUpdate(float DeltaTime)
	{
		base.OnUpdate(DeltaTime);
		if (OwnerCharacter == null)
		{
			return;
		}
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(OwnerCharacter);
		if (unPersistentReadOnlyData.DonNavManager == null || !unPersistentReadOnlyData.DonNavManager.IsLocationWithinNavigableWorld(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter)))
		{
			unPersistentReadOnlyData.DonNavManager = UDonNavigationHelper.DonNavigationManagerForActor(OwnerCharacter);
		}
		if (unPersistentReadOnlyData.QueryResults.QueryStatus == EDonNavigationQueryStatus.InProgress)
		{
			return;
		}
		unPersistentReadOnlyData.bTargetLocationChanged = IsTargetLocationChanged(MinimumProximityRequired);
		switch (unPersistentReadOnlyData.QueryResults.QueryStatus)
		{
		case EDonNavigationQueryStatus.Success:
			if (unPersistentReadOnlyData.bSolutionInvalidatedByDynamicObstacle)
			{
				unPersistentReadOnlyData.DonNavManager.StopListeningToDynamicCollisionsForPath(unPersistentReadOnlyData.DynamicCollisionListener, unPersistentReadOnlyData.QueryResults);
				if (SchedulePathfindingRequest(OwnerCharacter, TargetLocation) == EBTNodeResult.Failed)
				{
					StopMove();
				}
			}
			else if (unPersistentReadOnlyData.bTargetLocationChanged)
			{
				TargetLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor);
				if (SchedulePathfindingRequest(OwnerCharacter, TargetLocation) == EBTNodeResult.Failed)
				{
					StopMove();
				}
			}
			else
			{
				TickPathNavigation(OwnerCharacter, DeltaTime);
			}
			break;
		case EDonNavigationQueryStatus.Unscheduled:
			USystemLibrary.PrintString(OwnerCharacter, "BGU_AIFlyPathMoveMode OnUpdate PathFinding Task Unscheduled", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 5f, FName.None);
			break;
		default:
			if (!unPersistentReadOnlyData.DonNavManager.HasTask(OwnerCharacter))
			{
				StopMove();
			}
			break;
		}
	}

	private void TickPathNavigation(APawn ControlledPawn, float DeltaSeconds)
	{
		BGUCharacterCS bGUCharacterCS = ControlledPawn as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(bGUCharacterCS);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData.DonNavManager == null)
		{
			return;
		}
		if (bVisualizePawnAsVoxels)
		{
			unPersistentReadOnlyData.DonNavManager.Debug_DrawVoxelCollisionProfile(bGUCharacterCS.RootComponent.Cast<UPrimitiveComponent>());
		}
		if (unPersistentReadOnlyData.QueryResults.PathSolutionOptimized.Count < unPersistentReadOnlyData.SolutionTraversalIndex)
		{
			StopMove();
			return;
		}
		FVector fVector = unPersistentReadOnlyData.QueryResults.PathSolutionOptimized[unPersistentReadOnlyData.SolutionTraversalIndex] - BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
		if (unPersistentReadOnlyData.bIsANavigator)
		{
			UDonNavigationHelper.AddMovementInputCustom(bGUCharacterCS, fVector, 1f);
		}
		else
		{
			EvtCollection?.Evt_SetMovementInput.Invoke(fVector, 1f, FromSvr: false);
		}
		UpdateRotation(bGUCharacterCS, fVector, DeltaSeconds);
		if (!(fVector.Size() <= MinimumProximityRequired))
		{
			return;
		}
		if (unPersistentReadOnlyData.SolutionTraversalIndex == unPersistentReadOnlyData.QueryResults.PathSolutionOptimized.Count - 1)
		{
			unPersistentReadOnlyData.bFlightResult = true;
			unPersistentReadOnlyData.bFlipFlopWhenTaskExits = !unPersistentReadOnlyData.bFlipFlopWhenTaskExits;
			unPersistentReadOnlyData.DonNavManager.StopListeningToDynamicCollisionsForPath(unPersistentReadOnlyData.DynamicCollisionListener, unPersistentReadOnlyData.QueryResults);
			if (unPersistentReadOnlyData.bIsANavigator)
			{
				UDonNavigationHelper.OnLocomotionEnd(bGUCharacterCS, bLocomotionSuccess: true);
			}
			StopMove();
			return;
		}
		unPersistentReadOnlyData.SolutionTraversalIndex++;
		if (!unPersistentReadOnlyData.DonNavManager.IsUnbound && UDonNavigationHelper.GetQueryDataVolumeSolutionOptimizedNum(unPersistentReadOnlyData.QueryResults) >= unPersistentReadOnlyData.SolutionTraversalIndex - 1)
		{
			unPersistentReadOnlyData.DonNavManager.StopListeningToDynamicCollisionsForPathIndex(unPersistentReadOnlyData.DynamicCollisionListener, unPersistentReadOnlyData.QueryResults, unPersistentReadOnlyData.SolutionTraversalIndex - 1);
		}
		if (unPersistentReadOnlyData.bIsANavigator && UDonNavigationHelper.GetQueryDataVolumeSolutionOptimizedNum(unPersistentReadOnlyData.QueryResults) >= unPersistentReadOnlyData.SolutionTraversalIndex)
		{
			FVector nextPoint = unPersistentReadOnlyData.QueryResults.PathSolutionOptimized[unPersistentReadOnlyData.SolutionTraversalIndex];
			UDonNavigationHelper.OnNextSegment(bGUCharacterCS, nextPoint);
		}
	}

	private void UpdateRotation(BGUCharacterCS OwnerCharacter, FVector FlightDirection, float DeltaSeconds)
	{
		if (OwnerCharacter == null)
		{
			return;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(OwnerCharacter);
		if (!(aActor == null))
		{
			FRotator Current = BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter);
			FRotator Target = (BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter)).ToOrientationRotator();
			BE.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, Value: false, OrientRotationToMovementHandleID);
			float interpSpeed = 60f;
			BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(OwnerCharacter);
			if (readOnlyData != null)
			{
				interpSpeed = readOnlyData.GetFloatValue(EBGUAttrFloat.KptturnSpeed);
			}
			FRotator TargetRot;
			switch (MoveSys.MovementData.MoveAIType)
			{
			default:
				return;
			case EBGUMoveAIType.KeepFacingTarget:
				TargetRot = MathLib.RInterpConstantTo(in Current, in Target, DeltaSeconds, interpSpeed);
				break;
			case EBGUMoveAIType.Flock:
			case EBGUMoveAIType.FacingVelocity:
				TargetRot = Current + FMath.RInterpConstantTo(FRotator.ZeroRotator, FlightDirection.Rotation() - Current.Clamp(), DeltaSeconds, interpSpeed);
				break;
			}
			bool bForceSetRot = true;
			UpdateTargetRotationForMotionMatching(ref TargetRot, ref bForceSetRot);
			if (bForceSetRot)
			{
				BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, TargetRot, bTeleportPhysics: false);
			}
		}
	}

	private EBTNodeResult SchedulePathfindingRequest(APawn ControlledPawn, FVector TargetLocation)
	{
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(ControlledPawn);
		BGUCharacterCS bGUCharacterCS = ControlledPawn as BGUCharacterCS;
		if (ControlledPawn == null || bGUCharacterCS == null || unPersistentReadOnlyData == null || unPersistentReadOnlyData.DonNavManager == null)
		{
			return HandleTaskFailure(ControlledPawn);
		}
		if (unPersistentReadOnlyData.DonNavManager.HasTask(ControlledPawn) && !unPersistentReadOnlyData.QueryParams.ForceRescheduleQuery)
		{
			return EBTNodeResult.Failed;
		}
		unPersistentReadOnlyData.Reset();
		FDoNNavigationQueryParams queryParams = QueryParams;
		queryParams.OwnerPayload = new TWeakObject<AActor>(ControlledPawn);
		queryParams.CollisionShapeInflation = -100f;
		queryParams.FlexibleOriginGoal = true;
		queryParams.ForceRescheduleQuery = true;
		unPersistentReadOnlyData.QueryParams = queryParams;
		unPersistentReadOnlyData.DebugParams = DebugParams;
		unPersistentReadOnlyData.bIsANavigator = ControlledPawn.GetClass().ImplementsInterface<IDonNavigator>();
		unPersistentReadOnlyData.TargetLocation = TargetLocation;
		FDoNNavigationResultHandler fDoNNavigationResultHandler = new FDoNNavigationResultHandler();
		fDoNNavigationResultHandler.Bind(MoveSys, B1GlobalFNames.AIFlyPathMoveMode_Pathfinding_OnFinish);
		unPersistentReadOnlyData.DynamicCollisionListener.Bind(MoveSys, B1GlobalFNames.AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert);
		if (unPersistentReadOnlyData.DonNavManager.SchedulePathfindingTask(ControlledPawn, unPersistentReadOnlyData.TargetLocation, unPersistentReadOnlyData.QueryParams, unPersistentReadOnlyData.DebugParams, fDoNNavigationResultHandler, unPersistentReadOnlyData.DynamicCollisionListener))
		{
			FDoNNavigationQueryData queryResults = unPersistentReadOnlyData.QueryResults;
			if (queryResults.QueryStatus == EDonNavigationQueryStatus.Success)
			{
				return EBTNodeResult.Succeeded;
			}
			queryResults.QueryStatus = EDonNavigationQueryStatus.InProgress;
			unPersistentReadOnlyData.QueryResults = queryResults;
			return EBTNodeResult.InProgress;
		}
		return HandleTaskFailure(ControlledPawn);
	}

	private EBTNodeResult HandleTaskFailure(APawn ControlledPawn)
	{
		AbortPathfindingRequest(ControlledPawn);
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(ControlledPawn);
		if (unPersistentReadOnlyData == null)
		{
			return EBTNodeResult.Failed;
		}
		bool flag = false;
		if (bTeleportToDestinationUponFailure)
		{
			flag = TeleportAndExit(ControlledPawn, bWrapUpLatentTask: false);
		}
		unPersistentReadOnlyData.bFlightResult = false;
		unPersistentReadOnlyData.bFlipFlopWhenTaskExits = !unPersistentReadOnlyData.bFlipFlopWhenTaskExits;
		if (unPersistentReadOnlyData.bIsANavigator)
		{
			UDonNavigationHelper.OnLocomotionEnd(ControlledPawn, flag);
		}
		if (flag)
		{
			return EBTNodeResult.Succeeded;
		}
		return EBTNodeResult.Failed;
	}

	private bool TeleportAndExit(APawn ControlledPawn, bool bWrapUpLatentTask = true)
	{
		bool result = false;
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(ControlledPawn);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.DonNavManager.IsLocationBeneathLandscape(unPersistentReadOnlyData.TargetLocation))
		{
			BGUFuncLibActorTransformCS.BGUSetActorLocation(ControlledPawn, unPersistentReadOnlyData.TargetLocation, bSweep: false, bTeleport: false);
			result = true;
		}
		if (bWrapUpLatentTask)
		{
			StopMove();
		}
		return result;
	}

	private void AbortPathfindingRequest(APawn ControlledPawn)
	{
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(ControlledPawn);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.DonNavManager != null)
		{
			unPersistentReadOnlyData.DonNavManager.AbortPathfindingTask(ControlledPawn);
			unPersistentReadOnlyData.DonNavManager.StopListeningToDynamicCollisionsForPath(unPersistentReadOnlyData.DynamicCollisionListener, unPersistentReadOnlyData.QueryResults);
		}
	}

	protected override void OnEnd()
	{
		base.OnEnd();
		bOverrideFacingTargetRotation = false;
		OverrideFacingTargetRotation = FRotator.ZeroRotator;
		APawn ownerCharacter = OwnerCharacter;
		AbortPathfindingRequest(ownerCharacter);
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(ownerCharacter);
		if (unPersistentReadOnlyData != null)
		{
			if (unPersistentReadOnlyData.QueryResults.PathSolutionOptimized.Count > 0 && unPersistentReadOnlyData.bIsANavigator)
			{
				UDonNavigationHelper.OnLocomotionAbort(ownerCharacter);
			}
			BE.Evt_ResetProperty.Invoke(OrientRotationToMovementHandleID);
			OrientRotationToMovementHandleID = 0u;
			ResetAllStatus();
		}
	}
}
