using System;
using b1.Plugins.DonAINavigation;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Fly Move To")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIT_FlyMoveTo")]
public class BAIT_FlyMoveTo : BAIT_Base
{
	private static bool BTTargetType_IsValid;

	private static int BTTargetType_Offset;

	private static FFieldAddress BTTargetType_PropertyAddress;

	private static bool MinimumProximityRequired_IsValid;

	private static int MinimumProximityRequired_Offset;

	private static bool QueryParams_IsValid;

	private static int QueryParams_Offset;

	private static bool DebugParams_IsValid;

	private static int DebugParams_Offset;

	private static bool bVisualizePawnAsVoxels_IsValid;

	private static int bVisualizePawnAsVoxels_Offset;

	private static FFieldAddress bVisualizePawnAsVoxels_PropertyAddress;

	private static bool bTeleportToDestinationUponFailure_IsValid;

	private static int bTeleportToDestinationUponFailure_Offset;

	private static FFieldAddress bTeleportToDestinationUponFailure_PropertyAddress;

	private static bool Pathfinding_OnFinish_IsValid;

	private static IntPtr Pathfinding_OnFinish_FunctionAddress;

	private static int Pathfinding_OnFinish_ParamsSize;

	private static bool Pathfinding_OnFinish_Data_IsValid;

	private static int Pathfinding_OnFinish_Data_Offset;

	private static FFieldAddress Pathfinding_OnFinish_Data_PropertyAddress;

	private static bool Pathfinding_OnDynamicCollisionAlert_IsValid;

	private static IntPtr Pathfinding_OnDynamicCollisionAlert_FunctionAddress;

	private static int Pathfinding_OnDynamicCollisionAlert_ParamsSize;

	private static bool Pathfinding_OnDynamicCollisionAlert_Data_IsValid;

	private static int Pathfinding_OnDynamicCollisionAlert_Data_Offset;

	private static FFieldAddress Pathfinding_OnDynamicCollisionAlert_Data_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_FlyMoveTo:BTTargetType")]
	public EBTTargetType BTTargetType
	{
		get
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:BTTargetType");
				return EBTTargetType.Target;
			}
			return EnumMarshaler<EBTTargetType>.FromNative(IntPtr.Add(base.Address, BTTargetType_Offset), 0, BTTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:BTTargetType");
			}
			else
			{
				EnumMarshaler<EBTTargetType>.ToNative(IntPtr.Add(base.Address, BTTargetType_Offset), 0, BTTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("DoN Navigation")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_FlyMoveTo:MinimumProximityRequired")]
	public float MinimumProximityRequired
	{
		get
		{
			CheckDestroyed();
			if (!MinimumProximityRequired_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:MinimumProximityRequired");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumProximityRequired_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumProximityRequired_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:MinimumProximityRequired");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumProximityRequired_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("DoN Navigation")]
	[USharpPath("/Script/b1-Managed.BAIT_FlyMoveTo:QueryParams")]
	public FDoNNavigationQueryParams QueryParams
	{
		get
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:QueryParams");
				return default(FDoNNavigationQueryParams);
			}
			return FDoNNavigationQueryParams.FromNative(IntPtr.Add(base.Address, QueryParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:QueryParams");
			}
			else
			{
				FDoNNavigationQueryParams.ToNative(IntPtr.Add(base.Address, QueryParams_Offset), value);
			}
		}
	}

	[Category("DoN Navigation")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_FlyMoveTo:DebugParams")]
	public FDoNNavigationDebugParams DebugParams
	{
		get
		{
			CheckDestroyed();
			if (!DebugParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:DebugParams");
				return default(FDoNNavigationDebugParams);
			}
			return FDoNNavigationDebugParams.FromNative(IntPtr.Add(base.Address, DebugParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:DebugParams");
			}
			else
			{
				FDoNNavigationDebugParams.ToNative(IntPtr.Add(base.Address, DebugParams_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("DoN Navigation")]
	[USharpPath("/Script/b1-Managed.BAIT_FlyMoveTo:bVisualizePawnAsVoxels")]
	public bool bVisualizePawnAsVoxels
	{
		get
		{
			CheckDestroyed();
			if (!bVisualizePawnAsVoxels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:bVisualizePawnAsVoxels");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bVisualizePawnAsVoxels_Offset), 0, bVisualizePawnAsVoxels_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bVisualizePawnAsVoxels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:bVisualizePawnAsVoxels");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bVisualizePawnAsVoxels_Offset), 0, bVisualizePawnAsVoxels_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DoN Navigation")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_FlyMoveTo:bTeleportToDestinationUponFailure")]
	public bool bTeleportToDestinationUponFailure
	{
		get
		{
			CheckDestroyed();
			if (!bTeleportToDestinationUponFailure_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:bTeleportToDestinationUponFailure");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTeleportToDestinationUponFailure_Offset), 0, bTeleportToDestinationUponFailure_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTeleportToDestinationUponFailure_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FlyMoveTo:bTeleportToDestinationUponFailure");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTeleportToDestinationUponFailure_Offset), 0, bTeleportToDestinationUponFailure_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		MinimumProximityRequired = 2000f;
		bTeleportToDestinationUponFailure = false;
	}

	[BlueprintCallable]
	[Category("DoN Navigation")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BAIT_FlyMoveTo:Pathfinding_OnFinish")]
	public void Pathfinding_OnFinish(FDoNNavigationQueryData Data)
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

	[Category("DoN Navigation")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BAIT_FlyMoveTo:Pathfinding_OnDynamicCollisionAlert")]
	public void Pathfinding_OnDynamicCollisionAlert(FDonNavigationDynamicCollisionPayload Data)
	{
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(Data.OwnerPayload.Value);
		if (unPersistentReadOnlyData != null)
		{
			unPersistentReadOnlyData.bSolutionInvalidatedByDynamicObstacle = true;
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(OwnerActor);
		if (unPersistentReadOnlyData.DonNavManager == null || !unPersistentReadOnlyData.DonNavManager.IsLocationWithinNavigableWorld(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor)))
		{
			unPersistentReadOnlyData.DonNavManager = UDonNavigationHelper.DonNavigationManagerForActor(OwnerActor);
		}
		SchedulePathfindingRequest(OwnerActor as APawn);
	}

	public override void ReceiveAbort(AActor OwnerActor)
	{
		AbortPathfindingRequest(OwnerActor as APawn);
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(OwnerActor);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.QueryResults.PathSolutionOptimized.Count > 0 && unPersistentReadOnlyData.bIsANavigator)
		{
			UDonNavigationHelper.OnLocomotionAbort(OwnerActor);
		}
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(OwnerActor);
		if (unPersistentReadOnlyData.DonNavManager == null || !unPersistentReadOnlyData.DonNavManager.IsLocationWithinNavigableWorld(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor)))
		{
			unPersistentReadOnlyData.DonNavManager = UDonNavigationHelper.DonNavigationManagerForActor(OwnerActor);
		}
		if (unPersistentReadOnlyData.QueryResults.QueryStatus == EDonNavigationQueryStatus.InProgress)
		{
			return;
		}
		switch (unPersistentReadOnlyData.QueryResults.QueryStatus)
		{
		case EDonNavigationQueryStatus.Success:
			if (unPersistentReadOnlyData.bSolutionInvalidatedByDynamicObstacle)
			{
				unPersistentReadOnlyData.DonNavManager.StopListeningToDynamicCollisionsForPath(unPersistentReadOnlyData.DynamicCollisionListener, unPersistentReadOnlyData.QueryResults);
				if (SchedulePathfindingRequest(OwnerActor as APawn) == EBTNodeResult.Failed)
				{
					FinishExecute(bSuccess: false);
				}
			}
			else if (unPersistentReadOnlyData.bTargetLocationChanged)
			{
				if (SchedulePathfindingRequest(OwnerActor as APawn) == EBTNodeResult.Failed)
				{
					FinishExecute(bSuccess: false);
				}
			}
			else
			{
				TickPathNavigation(OwnerActor as APawn, DeltaSeconds);
			}
			break;
		case EDonNavigationQueryStatus.TimedOut:
			HandleTaskFailureAndExit(OwnerActor as APawn);
			break;
		default:
			if (!unPersistentReadOnlyData.DonNavManager.HasTask(OwnerActor))
			{
				HandleTaskFailureAndExit(OwnerActor as APawn);
			}
			break;
		case EDonNavigationQueryStatus.Unscheduled:
		case EDonNavigationQueryStatus.Failure:
		case EDonNavigationQueryStatus.QueryHasNoSolution:
			break;
		}
	}

	private void TickPathNavigation(APawn ControlledPawn, float DeltaSeconds)
	{
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(ControlledPawn);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData.DonNavManager == null)
		{
			return;
		}
		if (bVisualizePawnAsVoxels)
		{
			unPersistentReadOnlyData.DonNavManager.Debug_DrawVoxelCollisionProfile(ControlledPawn.RootComponent.Cast<UPrimitiveComponent>());
		}
		if (unPersistentReadOnlyData.QueryResults.PathSolutionOptimized.Count < unPersistentReadOnlyData.SolutionTraversalIndex)
		{
			HandleTaskFailureAndExit(ControlledPawn);
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(ControlledPawn);
		FVector fVector2 = unPersistentReadOnlyData.QueryResults.PathSolutionOptimized[unPersistentReadOnlyData.SolutionTraversalIndex] - fVector;
		if (unPersistentReadOnlyData.bIsANavigator)
		{
			UDonNavigationHelper.AddMovementInputCustom(ControlledPawn, fVector2, 1f);
		}
		else
		{
			BUS_EventCollectionCS.Get(ControlledPawn).Evt_SetMovementInput.Invoke(fVector2, 1f, FromSvr: false);
		}
		if (!(fVector2.Size() <= MinimumProximityRequired))
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
				UDonNavigationHelper.OnLocomotionEnd(ControlledPawn, bLocomotionSuccess: true);
			}
			FinishExecute(bSuccess: true);
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
			UDonNavigationHelper.OnNextSegment(ControlledPawn, nextPoint);
		}
	}

	private EBTNodeResult SchedulePathfindingRequest(APawn ControlledPawn)
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
		unPersistentReadOnlyData.QueryParams = queryParams;
		unPersistentReadOnlyData.DebugParams = DebugParams;
		unPersistentReadOnlyData.bIsANavigator = ControlledPawn.GetClass().ImplementsInterface<IDonNavigator>();
		unPersistentReadOnlyData.TargetLocation = GetTargetLocation(ControlledPawn);
		FDoNNavigationResultHandler fDoNNavigationResultHandler = new FDoNNavigationResultHandler();
		fDoNNavigationResultHandler.Bind(this, B1GlobalFNames.Pathfinding_OnFinish);
		unPersistentReadOnlyData.DynamicCollisionListener.Bind(this, B1GlobalFNames.Pathfinding_OnDynamicCollisionAlert);
		if (unPersistentReadOnlyData.DonNavManager.SchedulePathfindingTask(ControlledPawn, unPersistentReadOnlyData.TargetLocation, unPersistentReadOnlyData.QueryParams, unPersistentReadOnlyData.DebugParams, fDoNNavigationResultHandler, unPersistentReadOnlyData.DynamicCollisionListener))
		{
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

	private void HandleTaskFailureAndExit(APawn ControlledPawn)
	{
		FinishExecute(HandleTaskFailure(ControlledPawn) != EBTNodeResult.Failed);
	}

	private bool TeleportAndExit(APawn ControlledPawn, bool bWrapUpLatentTask = true)
	{
		bool flag = false;
		BUC_FlyMoveToData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FlyMoveToData>(ControlledPawn);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.DonNavManager.IsLocationBeneathLandscape(unPersistentReadOnlyData.TargetLocation))
		{
			BGUFuncLibActorTransformCS.BGUSetActorLocation(ControlledPawn, unPersistentReadOnlyData.TargetLocation, bSweep: false, bTeleport: false);
			flag = true;
		}
		if (bWrapUpLatentTask)
		{
			FinishExecute(flag);
		}
		return flag;
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

	private FVector GetTargetLocation(APawn ControlledPawn)
	{
		AActor aActor = null;
		switch (BTTargetType)
		{
		case EBTTargetType.Target:
			aActor = BGUFunctionLibraryCS.BGUGetTarget(ControlledPawn);
			break;
		case EBTTargetType.Player:
			aActor = BGU_UnrealWorldUtil.GetNearestPlayerActor(ControlledPawn);
			break;
		case EBTTargetType.SceneItem:
		{
			BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(ControlledPawn);
			if (readOnlyData != null)
			{
				aActor = readOnlyData.SceneItemCatch;
			}
			break;
		}
		}
		if (aActor == null)
		{
			return FVector.OneVector;
		}
		return BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAIT_FlyMoveTo:Pathfinding_OnFinish")]
	private static void Pathfinding_OnFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAIT_FlyMoveTo bAIT_FlyMoveTo = GCHelper.Find<BAIT_FlyMoveTo>(obj);
		FDoNNavigationQueryData data = FDoNNavigationQueryData.FromNative(IntPtr.Add(buffer, Pathfinding_OnFinish_Data_Offset));
		bAIT_FlyMoveTo.Pathfinding_OnFinish(data);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAIT_FlyMoveTo:Pathfinding_OnDynamicCollisionAlert")]
	private static void Pathfinding_OnDynamicCollisionAlert__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAIT_FlyMoveTo bAIT_FlyMoveTo = GCHelper.Find<BAIT_FlyMoveTo>(obj);
		FDonNavigationDynamicCollisionPayload data = FDonNavigationDynamicCollisionPayload.FromNative(IntPtr.Add(buffer, Pathfinding_OnDynamicCollisionAlert_Data_Offset));
		bAIT_FlyMoveTo.Pathfinding_OnDynamicCollisionAlert(data);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_FlyMoveTo");
		NativeReflection.GetPropertyRef(ref BTTargetType_PropertyAddress, intPtr, "BTTargetType");
		BTTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "BTTargetType");
		BTTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BTTargetType", Classes.FEnumProperty);
		MinimumProximityRequired_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinimumProximityRequired");
		MinimumProximityRequired_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinimumProximityRequired", Classes.FFloatProperty);
		QueryParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueryParams");
		QueryParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueryParams", Classes.FStructProperty);
		DebugParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugParams");
		DebugParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugParams", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bVisualizePawnAsVoxels_PropertyAddress, intPtr, "bVisualizePawnAsVoxels");
		bVisualizePawnAsVoxels_Offset = NativeReflection.GetPropertyOffset(intPtr, "bVisualizePawnAsVoxels");
		bVisualizePawnAsVoxels_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bVisualizePawnAsVoxels", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bTeleportToDestinationUponFailure_PropertyAddress, intPtr, "bTeleportToDestinationUponFailure");
		bTeleportToDestinationUponFailure_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTeleportToDestinationUponFailure");
		bTeleportToDestinationUponFailure_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTeleportToDestinationUponFailure", Classes.FBoolProperty);
		Pathfinding_OnFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Pathfinding_OnFinish");
		Pathfinding_OnFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(Pathfinding_OnFinish_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Pathfinding_OnFinish_Data_PropertyAddress, Pathfinding_OnFinish_FunctionAddress, "Data");
		Pathfinding_OnFinish_Data_Offset = NativeReflection.GetPropertyOffset(Pathfinding_OnFinish_FunctionAddress, "Data");
		Pathfinding_OnFinish_Data_IsValid = NativeReflection.ValidatePropertyClass(Pathfinding_OnFinish_FunctionAddress, "Data", Classes.FStructProperty);
		Pathfinding_OnFinish_IsValid = Pathfinding_OnFinish_FunctionAddress != IntPtr.Zero && Pathfinding_OnFinish_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAIT_FlyMoveTo:Pathfinding_OnFinish", Pathfinding_OnFinish_IsValid);
		Pathfinding_OnDynamicCollisionAlert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Pathfinding_OnDynamicCollisionAlert");
		Pathfinding_OnDynamicCollisionAlert_ParamsSize = NativeReflection.GetFunctionParamsSize(Pathfinding_OnDynamicCollisionAlert_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Pathfinding_OnDynamicCollisionAlert_Data_PropertyAddress, Pathfinding_OnDynamicCollisionAlert_FunctionAddress, "Data");
		Pathfinding_OnDynamicCollisionAlert_Data_Offset = NativeReflection.GetPropertyOffset(Pathfinding_OnDynamicCollisionAlert_FunctionAddress, "Data");
		Pathfinding_OnDynamicCollisionAlert_Data_IsValid = NativeReflection.ValidatePropertyClass(Pathfinding_OnDynamicCollisionAlert_FunctionAddress, "Data", Classes.FStructProperty);
		Pathfinding_OnDynamicCollisionAlert_IsValid = Pathfinding_OnDynamicCollisionAlert_FunctionAddress != IntPtr.Zero && Pathfinding_OnDynamicCollisionAlert_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAIT_FlyMoveTo:Pathfinding_OnDynamicCollisionAlert", Pathfinding_OnDynamicCollisionAlert_IsValid);
	}

	static BAIT_FlyMoveTo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAIT_FlyMoveTo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAIT_FlyMoveTo));
	}
}
