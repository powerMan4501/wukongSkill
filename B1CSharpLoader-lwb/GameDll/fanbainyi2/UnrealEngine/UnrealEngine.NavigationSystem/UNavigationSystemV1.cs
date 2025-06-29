using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UClass(Flags = (ClassFlags)818938030uL, Config = "Engine")]
[UMetaPath("/Script/NavigationSystem.NavigationSystemV1", "NavigationSystem", UnrealModuleType.Engine)]
public class UNavigationSystemV1 : UNavigationSystemBase
{
	private static IntPtr classAddress;

	private static bool DefaultAgentName_IsValid;

	private static int DefaultAgentName_Offset;

	private static bool CrowdManagerClass_IsValid;

	private static int CrowdManagerClass_Offset;

	private static bool OnNavigationGenerationFinishedDelegate_IsValid;

	private static int OnNavigationGenerationFinishedDelegate_Offset;

	private FOnNavDataGenericEvent OnNavigationGenerationFinishedDelegate_DelegateCached;

	private static bool UnregisterNavigationInvoker_IsValid;

	private static IntPtr UnregisterNavigationInvoker_FunctionAddress;

	private static int UnregisterNavigationInvoker_ParamsSize;

	private static bool UnregisterNavigationInvoker_Invoker_IsValid;

	private static FFieldAddress UnregisterNavigationInvoker_Invoker_PropertyAddress;

	private static int UnregisterNavigationInvoker_Invoker_Offset;

	private static bool SetMaxSimultaneousTileGenerationJobsCount_IsValid;

	private static IntPtr SetMaxSimultaneousTileGenerationJobsCount_FunctionAddress;

	private static int SetMaxSimultaneousTileGenerationJobsCount_ParamsSize;

	private static bool SetMaxSimultaneousTileGenerationJobsCount_MaxNumberOfJobs_IsValid;

	private static FFieldAddress SetMaxSimultaneousTileGenerationJobsCount_MaxNumberOfJobs_PropertyAddress;

	private static int SetMaxSimultaneousTileGenerationJobsCount_MaxNumberOfJobs_Offset;

	private static bool SetGeometryGatheringMode_IsValid;

	private static IntPtr SetGeometryGatheringMode_FunctionAddress;

	private static int SetGeometryGatheringMode_ParamsSize;

	private static bool SetGeometryGatheringMode_NewMode_IsValid;

	private static FFieldAddress SetGeometryGatheringMode_NewMode_PropertyAddress;

	private static int SetGeometryGatheringMode_NewMode_Offset;

	private static bool ResetMaxSimultaneousTileGenerationJobsCount_IsValid;

	private static IntPtr ResetMaxSimultaneousTileGenerationJobsCount_FunctionAddress;

	private static int ResetMaxSimultaneousTileGenerationJobsCount_ParamsSize;

	private static bool RegisterNavigationInvoker_IsValid;

	private static IntPtr RegisterNavigationInvoker_FunctionAddress;

	private static int RegisterNavigationInvoker_ParamsSize;

	private static bool RegisterNavigationInvoker_Invoker_IsValid;

	private static FFieldAddress RegisterNavigationInvoker_Invoker_PropertyAddress;

	private static int RegisterNavigationInvoker_Invoker_Offset;

	private static bool RegisterNavigationInvoker_TileGenerationRadius_IsValid;

	private static FFieldAddress RegisterNavigationInvoker_TileGenerationRadius_PropertyAddress;

	private static int RegisterNavigationInvoker_TileGenerationRadius_Offset;

	private static bool RegisterNavigationInvoker_TileRemovalRadius_IsValid;

	private static FFieldAddress RegisterNavigationInvoker_TileRemovalRadius_PropertyAddress;

	private static int RegisterNavigationInvoker_TileRemovalRadius_Offset;

	private static bool OnNavigationBoundsUpdated_IsValid;

	private static IntPtr OnNavigationBoundsUpdated_FunctionAddress;

	private static int OnNavigationBoundsUpdated_ParamsSize;

	private static bool OnNavigationBoundsUpdated_NavVolume_IsValid;

	private static FFieldAddress OnNavigationBoundsUpdated_NavVolume_PropertyAddress;

	private static int OnNavigationBoundsUpdated_NavVolume_Offset;

	private static bool NavigationRaycast_IsValid;

	private static IntPtr NavigationRaycast_FunctionAddress;

	private static int NavigationRaycast_ParamsSize;

	private static bool NavigationRaycast_WorldContextObject_IsValid;

	private static FFieldAddress NavigationRaycast_WorldContextObject_PropertyAddress;

	private static int NavigationRaycast_WorldContextObject_Offset;

	private static bool NavigationRaycast_RayStart_IsValid;

	private static FFieldAddress NavigationRaycast_RayStart_PropertyAddress;

	private static int NavigationRaycast_RayStart_Offset;

	private static bool NavigationRaycast_RayEnd_IsValid;

	private static FFieldAddress NavigationRaycast_RayEnd_PropertyAddress;

	private static int NavigationRaycast_RayEnd_Offset;

	private static bool NavigationRaycast_HitLocation_IsValid;

	private static FFieldAddress NavigationRaycast_HitLocation_PropertyAddress;

	private static int NavigationRaycast_HitLocation_Offset;

	private static bool NavigationRaycast_FilterClass_IsValid;

	private static FFieldAddress NavigationRaycast_FilterClass_PropertyAddress;

	private static int NavigationRaycast_FilterClass_Offset;

	private static bool NavigationRaycast_Querier_IsValid;

	private static FFieldAddress NavigationRaycast_Querier_PropertyAddress;

	private static int NavigationRaycast_Querier_Offset;

	private static bool NavigationRaycast_ReturnValue_IsValid;

	private static FFieldAddress NavigationRaycast_ReturnValue_PropertyAddress;

	private static int NavigationRaycast_ReturnValue_Offset;

	private static bool ReplaceAreaInOctreeData_IsValid;

	private static IntPtr ReplaceAreaInOctreeData_FunctionAddress;

	private static int ReplaceAreaInOctreeData_ParamsSize;

	private static bool ReplaceAreaInOctreeData_Object_IsValid;

	private static FFieldAddress ReplaceAreaInOctreeData_Object_PropertyAddress;

	private static int ReplaceAreaInOctreeData_Object_Offset;

	private static bool ReplaceAreaInOctreeData_OldArea_IsValid;

	private static FFieldAddress ReplaceAreaInOctreeData_OldArea_PropertyAddress;

	private static int ReplaceAreaInOctreeData_OldArea_Offset;

	private static bool ReplaceAreaInOctreeData_NewArea_IsValid;

	private static FFieldAddress ReplaceAreaInOctreeData_NewArea_PropertyAddress;

	private static int ReplaceAreaInOctreeData_NewArea_Offset;

	private static bool ReplaceAreaInOctreeData_ReturnValue_IsValid;

	private static FFieldAddress ReplaceAreaInOctreeData_ReturnValue_PropertyAddress;

	private static int ReplaceAreaInOctreeData_ReturnValue_Offset;

	private static bool ProjectPointToNavigation_IsValid;

	private static IntPtr ProjectPointToNavigation_FunctionAddress;

	private static int ProjectPointToNavigation_ParamsSize;

	private static bool ProjectPointToNavigation_WorldContextObject_IsValid;

	private static FFieldAddress ProjectPointToNavigation_WorldContextObject_PropertyAddress;

	private static int ProjectPointToNavigation_WorldContextObject_Offset;

	private static bool ProjectPointToNavigation_Point_IsValid;

	private static FFieldAddress ProjectPointToNavigation_Point_PropertyAddress;

	private static int ProjectPointToNavigation_Point_Offset;

	private static bool ProjectPointToNavigation_ProjectedLocation_IsValid;

	private static FFieldAddress ProjectPointToNavigation_ProjectedLocation_PropertyAddress;

	private static int ProjectPointToNavigation_ProjectedLocation_Offset;

	private static bool ProjectPointToNavigation_NavData_IsValid;

	private static FFieldAddress ProjectPointToNavigation_NavData_PropertyAddress;

	private static int ProjectPointToNavigation_NavData_Offset;

	private static bool ProjectPointToNavigation_FilterClass_IsValid;

	private static FFieldAddress ProjectPointToNavigation_FilterClass_PropertyAddress;

	private static int ProjectPointToNavigation_FilterClass_Offset;

	private static bool ProjectPointToNavigation_QueryExtent_IsValid;

	private static FFieldAddress ProjectPointToNavigation_QueryExtent_PropertyAddress;

	private static int ProjectPointToNavigation_QueryExtent_Offset;

	private static bool ProjectPointToNavigation_ReturnValue_IsValid;

	private static FFieldAddress ProjectPointToNavigation_ReturnValue_PropertyAddress;

	private static int ProjectPointToNavigation_ReturnValue_Offset;

	private static bool GetRandomReachablePointInRadius_IsValid;

	private static IntPtr GetRandomReachablePointInRadius_FunctionAddress;

	private static int GetRandomReachablePointInRadius_ParamsSize;

	private static bool GetRandomReachablePointInRadius_WorldContextObject_IsValid;

	private static FFieldAddress GetRandomReachablePointInRadius_WorldContextObject_PropertyAddress;

	private static int GetRandomReachablePointInRadius_WorldContextObject_Offset;

	private static bool GetRandomReachablePointInRadius_Origin_IsValid;

	private static FFieldAddress GetRandomReachablePointInRadius_Origin_PropertyAddress;

	private static int GetRandomReachablePointInRadius_Origin_Offset;

	private static bool GetRandomReachablePointInRadius_RandomLocation_IsValid;

	private static FFieldAddress GetRandomReachablePointInRadius_RandomLocation_PropertyAddress;

	private static int GetRandomReachablePointInRadius_RandomLocation_Offset;

	private static bool GetRandomReachablePointInRadius_Radius_IsValid;

	private static FFieldAddress GetRandomReachablePointInRadius_Radius_PropertyAddress;

	private static int GetRandomReachablePointInRadius_Radius_Offset;

	private static bool GetRandomReachablePointInRadius_NavData_IsValid;

	private static FFieldAddress GetRandomReachablePointInRadius_NavData_PropertyAddress;

	private static int GetRandomReachablePointInRadius_NavData_Offset;

	private static bool GetRandomReachablePointInRadius_FilterClass_IsValid;

	private static FFieldAddress GetRandomReachablePointInRadius_FilterClass_PropertyAddress;

	private static int GetRandomReachablePointInRadius_FilterClass_Offset;

	private static bool GetRandomReachablePointInRadius_ReturnValue_IsValid;

	private static FFieldAddress GetRandomReachablePointInRadius_ReturnValue_PropertyAddress;

	private static int GetRandomReachablePointInRadius_ReturnValue_Offset;

	private static bool GetRandomPointInNavigableRadius_IsValid;

	private static IntPtr GetRandomPointInNavigableRadius_FunctionAddress;

	private static int GetRandomPointInNavigableRadius_ParamsSize;

	private static bool GetRandomPointInNavigableRadius_WorldContextObject_IsValid;

	private static FFieldAddress GetRandomPointInNavigableRadius_WorldContextObject_PropertyAddress;

	private static int GetRandomPointInNavigableRadius_WorldContextObject_Offset;

	private static bool GetRandomPointInNavigableRadius_Origin_IsValid;

	private static FFieldAddress GetRandomPointInNavigableRadius_Origin_PropertyAddress;

	private static int GetRandomPointInNavigableRadius_Origin_Offset;

	private static bool GetRandomPointInNavigableRadius_RandomLocation_IsValid;

	private static FFieldAddress GetRandomPointInNavigableRadius_RandomLocation_PropertyAddress;

	private static int GetRandomPointInNavigableRadius_RandomLocation_Offset;

	private static bool GetRandomPointInNavigableRadius_Radius_IsValid;

	private static FFieldAddress GetRandomPointInNavigableRadius_Radius_PropertyAddress;

	private static int GetRandomPointInNavigableRadius_Radius_Offset;

	private static bool GetRandomPointInNavigableRadius_NavData_IsValid;

	private static FFieldAddress GetRandomPointInNavigableRadius_NavData_PropertyAddress;

	private static int GetRandomPointInNavigableRadius_NavData_Offset;

	private static bool GetRandomPointInNavigableRadius_FilterClass_IsValid;

	private static FFieldAddress GetRandomPointInNavigableRadius_FilterClass_PropertyAddress;

	private static int GetRandomPointInNavigableRadius_FilterClass_Offset;

	private static bool GetRandomPointInNavigableRadius_ReturnValue_IsValid;

	private static FFieldAddress GetRandomPointInNavigableRadius_ReturnValue_PropertyAddress;

	private static int GetRandomPointInNavigableRadius_ReturnValue_Offset;

	private static bool GetRandomLocationInNavigableRadius_IsValid;

	private static IntPtr GetRandomLocationInNavigableRadius_FunctionAddress;

	private static int GetRandomLocationInNavigableRadius_ParamsSize;

	private static bool GetRandomLocationInNavigableRadius_WorldContextObject_IsValid;

	private static FFieldAddress GetRandomLocationInNavigableRadius_WorldContextObject_PropertyAddress;

	private static int GetRandomLocationInNavigableRadius_WorldContextObject_Offset;

	private static bool GetRandomLocationInNavigableRadius_Origin_IsValid;

	private static FFieldAddress GetRandomLocationInNavigableRadius_Origin_PropertyAddress;

	private static int GetRandomLocationInNavigableRadius_Origin_Offset;

	private static bool GetRandomLocationInNavigableRadius_RandomLocation_IsValid;

	private static FFieldAddress GetRandomLocationInNavigableRadius_RandomLocation_PropertyAddress;

	private static int GetRandomLocationInNavigableRadius_RandomLocation_Offset;

	private static bool GetRandomLocationInNavigableRadius_Radius_IsValid;

	private static FFieldAddress GetRandomLocationInNavigableRadius_Radius_PropertyAddress;

	private static int GetRandomLocationInNavigableRadius_Radius_Offset;

	private static bool GetRandomLocationInNavigableRadius_NavData_IsValid;

	private static FFieldAddress GetRandomLocationInNavigableRadius_NavData_PropertyAddress;

	private static int GetRandomLocationInNavigableRadius_NavData_Offset;

	private static bool GetRandomLocationInNavigableRadius_FilterClass_IsValid;

	private static FFieldAddress GetRandomLocationInNavigableRadius_FilterClass_PropertyAddress;

	private static int GetRandomLocationInNavigableRadius_FilterClass_Offset;

	private static bool GetRandomLocationInNavigableRadius_ReturnValue_IsValid;

	private static FFieldAddress GetRandomLocationInNavigableRadius_ReturnValue_PropertyAddress;

	private static int GetRandomLocationInNavigableRadius_ReturnValue_Offset;

	private static bool IsNavigationBeingBuiltOrLocked_IsValid;

	private static IntPtr IsNavigationBeingBuiltOrLocked_FunctionAddress;

	private static int IsNavigationBeingBuiltOrLocked_ParamsSize;

	private static bool IsNavigationBeingBuiltOrLocked_WorldContextObject_IsValid;

	private static FFieldAddress IsNavigationBeingBuiltOrLocked_WorldContextObject_PropertyAddress;

	private static int IsNavigationBeingBuiltOrLocked_WorldContextObject_Offset;

	private static bool IsNavigationBeingBuiltOrLocked_ReturnValue_IsValid;

	private static FFieldAddress IsNavigationBeingBuiltOrLocked_ReturnValue_PropertyAddress;

	private static int IsNavigationBeingBuiltOrLocked_ReturnValue_Offset;

	private static bool IsNavigationBeingBuilt_IsValid;

	private static IntPtr IsNavigationBeingBuilt_FunctionAddress;

	private static int IsNavigationBeingBuilt_ParamsSize;

	private static bool IsNavigationBeingBuilt_WorldContextObject_IsValid;

	private static FFieldAddress IsNavigationBeingBuilt_WorldContextObject_PropertyAddress;

	private static int IsNavigationBeingBuilt_WorldContextObject_Offset;

	private static bool IsNavigationBeingBuilt_ReturnValue_IsValid;

	private static FFieldAddress IsNavigationBeingBuilt_ReturnValue_PropertyAddress;

	private static int IsNavigationBeingBuilt_ReturnValue_Offset;

	private static bool GetPathLength_IsValid;

	private static IntPtr GetPathLength_FunctionAddress;

	private static int GetPathLength_ParamsSize;

	private static bool GetPathLength_WorldContextObject_IsValid;

	private static FFieldAddress GetPathLength_WorldContextObject_PropertyAddress;

	private static int GetPathLength_WorldContextObject_Offset;

	private static bool GetPathLength_PathStart_IsValid;

	private static FFieldAddress GetPathLength_PathStart_PropertyAddress;

	private static int GetPathLength_PathStart_Offset;

	private static bool GetPathLength_PathEnd_IsValid;

	private static FFieldAddress GetPathLength_PathEnd_PropertyAddress;

	private static int GetPathLength_PathEnd_Offset;

	private static bool GetPathLength_PathLength_IsValid;

	private static FFieldAddress GetPathLength_PathLength_PropertyAddress;

	private static int GetPathLength_PathLength_Offset;

	private static bool GetPathLength_NavData_IsValid;

	private static FFieldAddress GetPathLength_NavData_PropertyAddress;

	private static int GetPathLength_NavData_Offset;

	private static bool GetPathLength_FilterClass_IsValid;

	private static FFieldAddress GetPathLength_FilterClass_PropertyAddress;

	private static int GetPathLength_FilterClass_Offset;

	private static bool GetPathLength_ReturnValue_IsValid;

	private static FFieldAddress GetPathLength_ReturnValue_PropertyAddress;

	private static int GetPathLength_ReturnValue_Offset;

	private static bool GetPathCost_IsValid;

	private static IntPtr GetPathCost_FunctionAddress;

	private static int GetPathCost_ParamsSize;

	private static bool GetPathCost_WorldContextObject_IsValid;

	private static FFieldAddress GetPathCost_WorldContextObject_PropertyAddress;

	private static int GetPathCost_WorldContextObject_Offset;

	private static bool GetPathCost_PathStart_IsValid;

	private static FFieldAddress GetPathCost_PathStart_PropertyAddress;

	private static int GetPathCost_PathStart_Offset;

	private static bool GetPathCost_PathEnd_IsValid;

	private static FFieldAddress GetPathCost_PathEnd_PropertyAddress;

	private static int GetPathCost_PathEnd_Offset;

	private static bool GetPathCost_PathCost_IsValid;

	private static FFieldAddress GetPathCost_PathCost_PropertyAddress;

	private static int GetPathCost_PathCost_Offset;

	private static bool GetPathCost_NavData_IsValid;

	private static FFieldAddress GetPathCost_NavData_PropertyAddress;

	private static int GetPathCost_NavData_Offset;

	private static bool GetPathCost_FilterClass_IsValid;

	private static FFieldAddress GetPathCost_FilterClass_PropertyAddress;

	private static int GetPathCost_FilterClass_Offset;

	private static bool GetPathCost_ReturnValue_IsValid;

	private static FFieldAddress GetPathCost_ReturnValue_PropertyAddress;

	private static int GetPathCost_ReturnValue_Offset;

	private static bool GetNavigationSystem_IsValid;

	private static IntPtr GetNavigationSystem_FunctionAddress;

	private static int GetNavigationSystem_ParamsSize;

	private static bool GetNavigationSystem_WorldContextObject_IsValid;

	private static FFieldAddress GetNavigationSystem_WorldContextObject_PropertyAddress;

	private static int GetNavigationSystem_WorldContextObject_Offset;

	private static bool GetNavigationSystem_ReturnValue_IsValid;

	private static FFieldAddress GetNavigationSystem_ReturnValue_PropertyAddress;

	private static int GetNavigationSystem_ReturnValue_Offset;

	private static bool FindPathToLocationSynchronously_IsValid;

	private static IntPtr FindPathToLocationSynchronously_FunctionAddress;

	private static int FindPathToLocationSynchronously_ParamsSize;

	private static bool FindPathToLocationSynchronously_WorldContextObject_IsValid;

	private static FFieldAddress FindPathToLocationSynchronously_WorldContextObject_PropertyAddress;

	private static int FindPathToLocationSynchronously_WorldContextObject_Offset;

	private static bool FindPathToLocationSynchronously_PathStart_IsValid;

	private static FFieldAddress FindPathToLocationSynchronously_PathStart_PropertyAddress;

	private static int FindPathToLocationSynchronously_PathStart_Offset;

	private static bool FindPathToLocationSynchronously_PathEnd_IsValid;

	private static FFieldAddress FindPathToLocationSynchronously_PathEnd_PropertyAddress;

	private static int FindPathToLocationSynchronously_PathEnd_Offset;

	private static bool FindPathToLocationSynchronously_PathfindingContext_IsValid;

	private static FFieldAddress FindPathToLocationSynchronously_PathfindingContext_PropertyAddress;

	private static int FindPathToLocationSynchronously_PathfindingContext_Offset;

	private static bool FindPathToLocationSynchronously_FilterClass_IsValid;

	private static FFieldAddress FindPathToLocationSynchronously_FilterClass_PropertyAddress;

	private static int FindPathToLocationSynchronously_FilterClass_Offset;

	private static bool FindPathToLocationSynchronously_ReturnValue_IsValid;

	private static FFieldAddress FindPathToLocationSynchronously_ReturnValue_PropertyAddress;

	private static int FindPathToLocationSynchronously_ReturnValue_Offset;

	private static bool FindPathToActorSynchronously_IsValid;

	private static IntPtr FindPathToActorSynchronously_FunctionAddress;

	private static int FindPathToActorSynchronously_ParamsSize;

	private static bool FindPathToActorSynchronously_WorldContextObject_IsValid;

	private static FFieldAddress FindPathToActorSynchronously_WorldContextObject_PropertyAddress;

	private static int FindPathToActorSynchronously_WorldContextObject_Offset;

	private static bool FindPathToActorSynchronously_PathStart_IsValid;

	private static FFieldAddress FindPathToActorSynchronously_PathStart_PropertyAddress;

	private static int FindPathToActorSynchronously_PathStart_Offset;

	private static bool FindPathToActorSynchronously_GoalActor_IsValid;

	private static FFieldAddress FindPathToActorSynchronously_GoalActor_PropertyAddress;

	private static int FindPathToActorSynchronously_GoalActor_Offset;

	private static bool FindPathToActorSynchronously_TetherDistance_IsValid;

	private static FFieldAddress FindPathToActorSynchronously_TetherDistance_PropertyAddress;

	private static int FindPathToActorSynchronously_TetherDistance_Offset;

	private static bool FindPathToActorSynchronously_PathfindingContext_IsValid;

	private static FFieldAddress FindPathToActorSynchronously_PathfindingContext_PropertyAddress;

	private static int FindPathToActorSynchronously_PathfindingContext_Offset;

	private static bool FindPathToActorSynchronously_FilterClass_IsValid;

	private static FFieldAddress FindPathToActorSynchronously_FilterClass_PropertyAddress;

	private static int FindPathToActorSynchronously_FilterClass_Offset;

	private static bool FindPathToActorSynchronously_ReturnValue_IsValid;

	private static FFieldAddress FindPathToActorSynchronously_ReturnValue_PropertyAddress;

	private static int FindPathToActorSynchronously_ReturnValue_Offset;

	private static bool FindNearestPoly_IsValid;

	private static IntPtr FindNearestPoly_FunctionAddress;

	private static int FindNearestPoly_ParamsSize;

	private static bool FindNearestPoly_WorldContextObject_IsValid;

	private static FFieldAddress FindNearestPoly_WorldContextObject_PropertyAddress;

	private static int FindNearestPoly_WorldContextObject_Offset;

	private static bool FindNearestPoly_Loc_IsValid;

	private static FFieldAddress FindNearestPoly_Loc_PropertyAddress;

	private static int FindNearestPoly_Loc_Offset;

	private static bool FindNearestPoly_Extent_IsValid;

	private static FFieldAddress FindNearestPoly_Extent_PropertyAddress;

	private static int FindNearestPoly_Extent_Offset;

	private static bool FindNearestPoly_NavData_IsValid;

	private static FFieldAddress FindNearestPoly_NavData_PropertyAddress;

	private static int FindNearestPoly_NavData_Offset;

	private static bool FindNearestPoly_FilterClass_IsValid;

	private static FFieldAddress FindNearestPoly_FilterClass_PropertyAddress;

	private static int FindNearestPoly_FilterClass_Offset;

	private static bool FindNearestPoly_ReturnValue_IsValid;

	private static FFieldAddress FindNearestPoly_ReturnValue_PropertyAddress;

	private static int FindNearestPoly_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954683925uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:DefaultAgentName")]
	protected FName DefaultAgentName
	{
		get
		{
			CheckDestroyed();
			if (!DefaultAgentName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationSystemV1:DefaultAgentName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DefaultAgentName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultAgentName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationSystemV1:DefaultAgentName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DefaultAgentName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393695068307477uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:CrowdManagerClass")]
	protected TSoftClass<UCrowdManagerBase> CrowdManagerClass
	{
		get
		{
			CheckDestroyed();
			if (!CrowdManagerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationSystemV1:CrowdManagerClass");
				return default(TSoftClass<UCrowdManagerBase>);
			}
			return TSoftClassMarshaler<UCrowdManagerBase>.FromNative(IntPtr.Add(base.Address, CrowdManagerClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CrowdManagerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationSystemV1:CrowdManagerClass");
			}
			else
			{
				TSoftClassMarshaler<UCrowdManagerBase>.ToNative(IntPtr.Add(base.Address, CrowdManagerClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896338944uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:OnNavigationGenerationFinishedDelegate")]
	public FOnNavDataGenericEvent OnNavigationGenerationFinishedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnNavigationGenerationFinishedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationSystemV1:OnNavigationGenerationFinishedDelegate");
				return new FOnNavDataGenericEvent();
			}
			if (OnNavigationGenerationFinishedDelegate_DelegateCached == null)
			{
				OnNavigationGenerationFinishedDelegate_DelegateCached = new FOnNavDataGenericEvent();
				OnNavigationGenerationFinishedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnNavigationGenerationFinishedDelegate_Offset));
			}
			return OnNavigationGenerationFinishedDelegate_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:UnregisterNavigationInvoker")]
	public unsafe void UnregisterNavigationInvoker(AActor Invoker)
	{
		CheckDestroyed();
		if (!UnregisterNavigationInvoker_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:UnregisterNavigationInvoker");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterNavigationInvoker_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterNavigationInvoker_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, UnregisterNavigationInvoker_Invoker_Offset), 0, UnregisterNavigationInvoker_Invoker_PropertyAddress.Address, Invoker);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnregisterNavigationInvoker_FunctionAddress, intPtr, UnregisterNavigationInvoker_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:SetMaxSimultaneousTileGenerationJobsCount")]
	public unsafe void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs)
	{
		CheckDestroyed();
		if (!SetMaxSimultaneousTileGenerationJobsCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:SetMaxSimultaneousTileGenerationJobsCount");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaxSimultaneousTileGenerationJobsCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaxSimultaneousTileGenerationJobsCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMaxSimultaneousTileGenerationJobsCount_MaxNumberOfJobs_Offset), 0, SetMaxSimultaneousTileGenerationJobsCount_MaxNumberOfJobs_PropertyAddress.Address, MaxNumberOfJobs);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaxSimultaneousTileGenerationJobsCount_FunctionAddress, intPtr, SetMaxSimultaneousTileGenerationJobsCount_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:SetGeometryGatheringMode")]
	public unsafe void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode)
	{
		CheckDestroyed();
		if (!SetGeometryGatheringMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:SetGeometryGatheringMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGeometryGatheringMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGeometryGatheringMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ENavDataGatheringModeConfig>.ToNative(IntPtr.Add(intPtr, SetGeometryGatheringMode_NewMode_Offset), 0, SetGeometryGatheringMode_NewMode_PropertyAddress.Address, NewMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGeometryGatheringMode_FunctionAddress, intPtr, SetGeometryGatheringMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:ResetMaxSimultaneousTileGenerationJobsCount")]
	public unsafe void ResetMaxSimultaneousTileGenerationJobsCount()
	{
		CheckDestroyed();
		if (!ResetMaxSimultaneousTileGenerationJobsCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:ResetMaxSimultaneousTileGenerationJobsCount");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetMaxSimultaneousTileGenerationJobsCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetMaxSimultaneousTileGenerationJobsCount_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetMaxSimultaneousTileGenerationJobsCount_FunctionAddress, argsSize: ResetMaxSimultaneousTileGenerationJobsCount_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:RegisterNavigationInvoker")]
	public unsafe void RegisterNavigationInvoker(AActor Invoker, float TileGenerationRadius = 3000f, float TileRemovalRadius = 5000f)
	{
		CheckDestroyed();
		if (!RegisterNavigationInvoker_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:RegisterNavigationInvoker");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterNavigationInvoker_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterNavigationInvoker_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RegisterNavigationInvoker_Invoker_Offset), 0, RegisterNavigationInvoker_Invoker_PropertyAddress.Address, Invoker);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RegisterNavigationInvoker_TileGenerationRadius_Offset), 0, RegisterNavigationInvoker_TileGenerationRadius_PropertyAddress.Address, TileGenerationRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RegisterNavigationInvoker_TileRemovalRadius_Offset), 0, RegisterNavigationInvoker_TileRemovalRadius_PropertyAddress.Address, TileRemovalRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterNavigationInvoker_FunctionAddress, intPtr, RegisterNavigationInvoker_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:OnNavigationBoundsUpdated")]
	public unsafe void OnNavigationBoundsUpdated(ANavMeshBoundsVolume NavVolume)
	{
		CheckDestroyed();
		if (!OnNavigationBoundsUpdated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:OnNavigationBoundsUpdated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNavigationBoundsUpdated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNavigationBoundsUpdated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ANavMeshBoundsVolume>.ToNative(IntPtr.Add(intPtr, OnNavigationBoundsUpdated_NavVolume_Offset), 0, OnNavigationBoundsUpdated_NavVolume_PropertyAddress.Address, NavVolume);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNavigationBoundsUpdated_FunctionAddress, intPtr, OnNavigationBoundsUpdated_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:NavigationRaycast")]
	public unsafe static bool NavigationRaycast(UObject WorldContextObject, FVector RayStart, FVector RayEnd, out FVector HitLocation, TSubclassOf<UNavigationQueryFilter> FilterClass, AController Querier)
	{
		if (!NavigationRaycast_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:NavigationRaycast");
			HitLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NavigationRaycast_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NavigationRaycast_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, NavigationRaycast_WorldContextObject_Offset), 0, NavigationRaycast_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, NavigationRaycast_RayStart_Offset), 0, NavigationRaycast_RayStart_PropertyAddress.Address, RayStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, NavigationRaycast_RayEnd_Offset), 0, NavigationRaycast_RayEnd_PropertyAddress.Address, RayEnd);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, NavigationRaycast_FilterClass_Offset), 0, NavigationRaycast_FilterClass_PropertyAddress.Address, FilterClass);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, NavigationRaycast_Querier_Offset), 0, NavigationRaycast_Querier_PropertyAddress.Address, Querier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NavigationRaycast_FunctionAddress, intPtr, NavigationRaycast_ParamsSize);
		HitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, NavigationRaycast_HitLocation_Offset), 0, NavigationRaycast_HitLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NavigationRaycast_ReturnValue_Offset), 0, NavigationRaycast_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_ReplaceAreaInOctreeData")]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:K2_ReplaceAreaInOctreeData")]
	public unsafe bool ReplaceAreaInOctreeData(UObject Object, TSubclassOf<UNavArea> OldArea, TSubclassOf<UNavArea> NewArea)
	{
		CheckDestroyed();
		if (!ReplaceAreaInOctreeData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:K2_ReplaceAreaInOctreeData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceAreaInOctreeData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceAreaInOctreeData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReplaceAreaInOctreeData_Object_Offset), 0, ReplaceAreaInOctreeData_Object_PropertyAddress.Address, Object);
		TSubclassOfMarshaler<UNavArea>.ToNative(IntPtr.Add(intPtr, ReplaceAreaInOctreeData_OldArea_Offset), 0, ReplaceAreaInOctreeData_OldArea_PropertyAddress.Address, OldArea);
		TSubclassOfMarshaler<UNavArea>.ToNative(IntPtr.Add(intPtr, ReplaceAreaInOctreeData_NewArea_Offset), 0, ReplaceAreaInOctreeData_NewArea_PropertyAddress.Address, NewArea);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReplaceAreaInOctreeData_FunctionAddress, intPtr, ReplaceAreaInOctreeData_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReplaceAreaInOctreeData_ReturnValue_Offset), 0, ReplaceAreaInOctreeData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u, OriginalName = "K2_ProjectPointToNavigation")]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:K2_ProjectPointToNavigation")]
	public unsafe static bool ProjectPointToNavigation(UObject WorldContextObject, FVector Point, out FVector ProjectedLocation, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass, FVector QueryExtent)
	{
		if (!ProjectPointToNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:K2_ProjectPointToNavigation");
			ProjectedLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectPointToNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectPointToNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProjectPointToNavigation_WorldContextObject_Offset), 0, ProjectPointToNavigation_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ProjectPointToNavigation_Point_Offset), 0, ProjectPointToNavigation_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<ANavigationData>.ToNative(IntPtr.Add(intPtr, ProjectPointToNavigation_NavData_Offset), 0, ProjectPointToNavigation_NavData_PropertyAddress.Address, NavData);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, ProjectPointToNavigation_FilterClass_Offset), 0, ProjectPointToNavigation_FilterClass_PropertyAddress.Address, FilterClass);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ProjectPointToNavigation_QueryExtent_Offset), 0, ProjectPointToNavigation_QueryExtent_PropertyAddress.Address, QueryExtent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectPointToNavigation_FunctionAddress, intPtr, ProjectPointToNavigation_ParamsSize);
		ProjectedLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ProjectPointToNavigation_ProjectedLocation_Offset), 0, ProjectPointToNavigation_ProjectedLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ProjectPointToNavigation_ReturnValue_Offset), 0, ProjectPointToNavigation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u, OriginalName = "K2_GetRandomReachablePointInRadius")]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:K2_GetRandomReachablePointInRadius")]
	public unsafe static bool GetRandomReachablePointInRadius(UObject WorldContextObject, FVector Origin, out FVector RandomLocation, float Radius, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		if (!GetRandomReachablePointInRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:K2_GetRandomReachablePointInRadius");
			RandomLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRandomReachablePointInRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRandomReachablePointInRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetRandomReachablePointInRadius_WorldContextObject_Offset), 0, GetRandomReachablePointInRadius_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetRandomReachablePointInRadius_Origin_Offset), 0, GetRandomReachablePointInRadius_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRandomReachablePointInRadius_Radius_Offset), 0, GetRandomReachablePointInRadius_Radius_PropertyAddress.Address, Radius);
		UObjectMarshaler<ANavigationData>.ToNative(IntPtr.Add(intPtr, GetRandomReachablePointInRadius_NavData_Offset), 0, GetRandomReachablePointInRadius_NavData_PropertyAddress.Address, NavData);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, GetRandomReachablePointInRadius_FilterClass_Offset), 0, GetRandomReachablePointInRadius_FilterClass_PropertyAddress.Address, FilterClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRandomReachablePointInRadius_FunctionAddress, intPtr, GetRandomReachablePointInRadius_ParamsSize);
		RandomLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetRandomReachablePointInRadius_RandomLocation_Offset), 0, GetRandomReachablePointInRadius_RandomLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetRandomReachablePointInRadius_ReturnValue_Offset), 0, GetRandomReachablePointInRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u, OriginalName = "K2_GetRandomPointInNavigableRadius")]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:K2_GetRandomPointInNavigableRadius")]
	public unsafe static bool GetRandomPointInNavigableRadius(UObject WorldContextObject, FVector Origin, out FVector RandomLocation, float Radius, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		if (!GetRandomPointInNavigableRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:K2_GetRandomPointInNavigableRadius");
			RandomLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRandomPointInNavigableRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRandomPointInNavigableRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetRandomPointInNavigableRadius_WorldContextObject_Offset), 0, GetRandomPointInNavigableRadius_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetRandomPointInNavigableRadius_Origin_Offset), 0, GetRandomPointInNavigableRadius_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRandomPointInNavigableRadius_Radius_Offset), 0, GetRandomPointInNavigableRadius_Radius_PropertyAddress.Address, Radius);
		UObjectMarshaler<ANavigationData>.ToNative(IntPtr.Add(intPtr, GetRandomPointInNavigableRadius_NavData_Offset), 0, GetRandomPointInNavigableRadius_NavData_PropertyAddress.Address, NavData);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, GetRandomPointInNavigableRadius_FilterClass_Offset), 0, GetRandomPointInNavigableRadius_FilterClass_PropertyAddress.Address, FilterClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRandomPointInNavigableRadius_FunctionAddress, intPtr, GetRandomPointInNavigableRadius_ParamsSize);
		RandomLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetRandomPointInNavigableRadius_RandomLocation_Offset), 0, GetRandomPointInNavigableRadius_RandomLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetRandomPointInNavigableRadius_ReturnValue_Offset), 0, GetRandomPointInNavigableRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u, OriginalName = "K2_GetRandomLocationInNavigableRadius")]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:K2_GetRandomLocationInNavigableRadius")]
	public unsafe static bool GetRandomLocationInNavigableRadius(UObject WorldContextObject, FVector Origin, out FVector RandomLocation, float Radius, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		if (!GetRandomLocationInNavigableRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:K2_GetRandomLocationInNavigableRadius");
			RandomLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRandomLocationInNavigableRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRandomLocationInNavigableRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetRandomLocationInNavigableRadius_WorldContextObject_Offset), 0, GetRandomLocationInNavigableRadius_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetRandomLocationInNavigableRadius_Origin_Offset), 0, GetRandomLocationInNavigableRadius_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRandomLocationInNavigableRadius_Radius_Offset), 0, GetRandomLocationInNavigableRadius_Radius_PropertyAddress.Address, Radius);
		UObjectMarshaler<ANavigationData>.ToNative(IntPtr.Add(intPtr, GetRandomLocationInNavigableRadius_NavData_Offset), 0, GetRandomLocationInNavigableRadius_NavData_PropertyAddress.Address, NavData);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, GetRandomLocationInNavigableRadius_FilterClass_Offset), 0, GetRandomLocationInNavigableRadius_FilterClass_PropertyAddress.Address, FilterClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRandomLocationInNavigableRadius_FunctionAddress, intPtr, GetRandomLocationInNavigableRadius_ParamsSize);
		RandomLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetRandomLocationInNavigableRadius_RandomLocation_Offset), 0, GetRandomLocationInNavigableRadius_RandomLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetRandomLocationInNavigableRadius_ReturnValue_Offset), 0, GetRandomLocationInNavigableRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:IsNavigationBeingBuiltOrLocked")]
	public unsafe static bool IsNavigationBeingBuiltOrLocked(UObject WorldContextObject)
	{
		if (!IsNavigationBeingBuiltOrLocked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:IsNavigationBeingBuiltOrLocked");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNavigationBeingBuiltOrLocked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNavigationBeingBuiltOrLocked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsNavigationBeingBuiltOrLocked_WorldContextObject_Offset), 0, IsNavigationBeingBuiltOrLocked_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsNavigationBeingBuiltOrLocked_FunctionAddress, intPtr, IsNavigationBeingBuiltOrLocked_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNavigationBeingBuiltOrLocked_ReturnValue_Offset), 0, IsNavigationBeingBuiltOrLocked_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:IsNavigationBeingBuilt")]
	public unsafe static bool IsNavigationBeingBuilt(UObject WorldContextObject)
	{
		if (!IsNavigationBeingBuilt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:IsNavigationBeingBuilt");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNavigationBeingBuilt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNavigationBeingBuilt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsNavigationBeingBuilt_WorldContextObject_Offset), 0, IsNavigationBeingBuilt_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsNavigationBeingBuilt_FunctionAddress, intPtr, IsNavigationBeingBuilt_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNavigationBeingBuilt_ReturnValue_Offset), 0, IsNavigationBeingBuilt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:GetPathLength")]
	public unsafe static ENavigationQueryResult GetPathLength(UObject WorldContextObject, FVector PathStart, FVector PathEnd, out float PathLength, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		if (!GetPathLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:GetPathLength");
			PathLength = 0f;
			return ENavigationQueryResult.Invalid;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPathLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPathLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetPathLength_WorldContextObject_Offset), 0, GetPathLength_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetPathLength_PathStart_Offset), 0, GetPathLength_PathStart_PropertyAddress.Address, PathStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetPathLength_PathEnd_Offset), 0, GetPathLength_PathEnd_PropertyAddress.Address, PathEnd);
		UObjectMarshaler<ANavigationData>.ToNative(IntPtr.Add(intPtr, GetPathLength_NavData_Offset), 0, GetPathLength_NavData_PropertyAddress.Address, NavData);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, GetPathLength_FilterClass_Offset), 0, GetPathLength_FilterClass_PropertyAddress.Address, FilterClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPathLength_FunctionAddress, intPtr, GetPathLength_ParamsSize);
		PathLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPathLength_PathLength_Offset), 0, GetPathLength_PathLength_PropertyAddress.Address);
		return EnumMarshaler<ENavigationQueryResult>.FromNative(IntPtr.Add(intPtr, GetPathLength_ReturnValue_Offset), 0, GetPathLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:GetPathCost")]
	public unsafe static ENavigationQueryResult GetPathCost(UObject WorldContextObject, FVector PathStart, FVector PathEnd, out float PathCost, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		if (!GetPathCost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:GetPathCost");
			PathCost = 0f;
			return ENavigationQueryResult.Invalid;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPathCost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPathCost_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetPathCost_WorldContextObject_Offset), 0, GetPathCost_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetPathCost_PathStart_Offset), 0, GetPathCost_PathStart_PropertyAddress.Address, PathStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetPathCost_PathEnd_Offset), 0, GetPathCost_PathEnd_PropertyAddress.Address, PathEnd);
		UObjectMarshaler<ANavigationData>.ToNative(IntPtr.Add(intPtr, GetPathCost_NavData_Offset), 0, GetPathCost_NavData_PropertyAddress.Address, NavData);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, GetPathCost_FilterClass_Offset), 0, GetPathCost_FilterClass_PropertyAddress.Address, FilterClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPathCost_FunctionAddress, intPtr, GetPathCost_ParamsSize);
		PathCost = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPathCost_PathCost_Offset), 0, GetPathCost_PathCost_PropertyAddress.Address);
		return EnumMarshaler<ENavigationQueryResult>.FromNative(IntPtr.Add(intPtr, GetPathCost_ReturnValue_Offset), 0, GetPathCost_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:GetNavigationSystem")]
	public unsafe static UNavigationSystemV1 GetNavigationSystem(UObject WorldContextObject)
	{
		if (!GetNavigationSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:GetNavigationSystem");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNavigationSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNavigationSystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetNavigationSystem_WorldContextObject_Offset), 0, GetNavigationSystem_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNavigationSystem_FunctionAddress, intPtr, GetNavigationSystem_ParamsSize);
		return UObjectMarshaler<UNavigationSystemV1>.FromNative(IntPtr.Add(intPtr, GetNavigationSystem_ReturnValue_Offset), 0, GetNavigationSystem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:FindPathToLocationSynchronously")]
	public unsafe static UNavigationPath FindPathToLocationSynchronously(UObject WorldContextObject, FVector PathStart, FVector PathEnd, AActor PathfindingContext, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		if (!FindPathToLocationSynchronously_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:FindPathToLocationSynchronously");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPathToLocationSynchronously_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPathToLocationSynchronously_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindPathToLocationSynchronously_WorldContextObject_Offset), 0, FindPathToLocationSynchronously_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindPathToLocationSynchronously_PathStart_Offset), 0, FindPathToLocationSynchronously_PathStart_PropertyAddress.Address, PathStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindPathToLocationSynchronously_PathEnd_Offset), 0, FindPathToLocationSynchronously_PathEnd_PropertyAddress.Address, PathEnd);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, FindPathToLocationSynchronously_PathfindingContext_Offset), 0, FindPathToLocationSynchronously_PathfindingContext_PropertyAddress.Address, PathfindingContext);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, FindPathToLocationSynchronously_FilterClass_Offset), 0, FindPathToLocationSynchronously_FilterClass_PropertyAddress.Address, FilterClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindPathToLocationSynchronously_FunctionAddress, intPtr, FindPathToLocationSynchronously_ParamsSize);
		return UObjectMarshaler<UNavigationPath>.FromNative(IntPtr.Add(intPtr, FindPathToLocationSynchronously_ReturnValue_Offset), 0, FindPathToLocationSynchronously_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:FindPathToActorSynchronously")]
	public unsafe static UNavigationPath FindPathToActorSynchronously(UObject WorldContextObject, FVector PathStart, AActor GoalActor, float TetherDistance, AActor PathfindingContext, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		if (!FindPathToActorSynchronously_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:FindPathToActorSynchronously");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPathToActorSynchronously_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPathToActorSynchronously_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindPathToActorSynchronously_WorldContextObject_Offset), 0, FindPathToActorSynchronously_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindPathToActorSynchronously_PathStart_Offset), 0, FindPathToActorSynchronously_PathStart_PropertyAddress.Address, PathStart);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, FindPathToActorSynchronously_GoalActor_Offset), 0, FindPathToActorSynchronously_GoalActor_PropertyAddress.Address, GoalActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindPathToActorSynchronously_TetherDistance_Offset), 0, FindPathToActorSynchronously_TetherDistance_PropertyAddress.Address, TetherDistance);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, FindPathToActorSynchronously_PathfindingContext_Offset), 0, FindPathToActorSynchronously_PathfindingContext_PropertyAddress.Address, PathfindingContext);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, FindPathToActorSynchronously_FilterClass_Offset), 0, FindPathToActorSynchronously_FilterClass_PropertyAddress.Address, FilterClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindPathToActorSynchronously_FunctionAddress, intPtr, FindPathToActorSynchronously_ParamsSize);
		return UObjectMarshaler<UNavigationPath>.FromNative(IntPtr.Add(intPtr, FindPathToActorSynchronously_ReturnValue_Offset), 0, FindPathToActorSynchronously_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/NavigationSystem.NavigationSystemV1:FindNearestPoly")]
	public unsafe static int FindNearestPoly(UObject WorldContextObject, FVector Loc, FVector Extent, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		if (!FindNearestPoly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationSystemV1:FindNearestPoly");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNearestPoly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNearestPoly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindNearestPoly_WorldContextObject_Offset), 0, FindNearestPoly_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindNearestPoly_Loc_Offset), 0, FindNearestPoly_Loc_PropertyAddress.Address, Loc);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindNearestPoly_Extent_Offset), 0, FindNearestPoly_Extent_PropertyAddress.Address, Extent);
		UObjectMarshaler<ANavigationData>.ToNative(IntPtr.Add(intPtr, FindNearestPoly_NavData_Offset), 0, FindNearestPoly_NavData_PropertyAddress.Address, NavData);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, FindNearestPoly_FilterClass_Offset), 0, FindNearestPoly_FilterClass_PropertyAddress.Address, FilterClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindNearestPoly_FunctionAddress, intPtr, FindNearestPoly_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindNearestPoly_ReturnValue_Offset), 0, FindNearestPoly_ReturnValue_PropertyAddress.Address);
	}

	static UNavigationSystemV1()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNavigationSystemV1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNavigationSystemV1));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/NavigationSystem.NavigationSystemV1");
		DefaultAgentName_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "DefaultAgentName");
		DefaultAgentName_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "DefaultAgentName", Classes.FNameProperty);
		CrowdManagerClass_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "CrowdManagerClass");
		CrowdManagerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "CrowdManagerClass", Classes.FSoftClassProperty);
		OnNavigationGenerationFinishedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnNavigationGenerationFinishedDelegate");
		OnNavigationGenerationFinishedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnNavigationGenerationFinishedDelegate", Classes.FMulticastDelegateProperty);
		UnregisterNavigationInvoker_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnregisterNavigationInvoker");
		UnregisterNavigationInvoker_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterNavigationInvoker_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterNavigationInvoker_Invoker_PropertyAddress, UnregisterNavigationInvoker_FunctionAddress, "Invoker");
		UnregisterNavigationInvoker_Invoker_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterNavigationInvoker_FunctionAddress, "Invoker");
		UnregisterNavigationInvoker_Invoker_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterNavigationInvoker_FunctionAddress, "Invoker", Classes.FObjectProperty);
		UnregisterNavigationInvoker_IsValid = UnregisterNavigationInvoker_FunctionAddress != IntPtr.Zero && UnregisterNavigationInvoker_Invoker_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:UnregisterNavigationInvoker", UnregisterNavigationInvoker_IsValid);
		SetMaxSimultaneousTileGenerationJobsCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMaxSimultaneousTileGenerationJobsCount");
		SetMaxSimultaneousTileGenerationJobsCount_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxSimultaneousTileGenerationJobsCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaxSimultaneousTileGenerationJobsCount_MaxNumberOfJobs_PropertyAddress, SetMaxSimultaneousTileGenerationJobsCount_FunctionAddress, "MaxNumberOfJobs");
		SetMaxSimultaneousTileGenerationJobsCount_MaxNumberOfJobs_Offset = NativeReflectionCached.GetPropertyOffset(SetMaxSimultaneousTileGenerationJobsCount_FunctionAddress, "MaxNumberOfJobs");
		SetMaxSimultaneousTileGenerationJobsCount_MaxNumberOfJobs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaxSimultaneousTileGenerationJobsCount_FunctionAddress, "MaxNumberOfJobs", Classes.FIntProperty);
		SetMaxSimultaneousTileGenerationJobsCount_IsValid = SetMaxSimultaneousTileGenerationJobsCount_FunctionAddress != IntPtr.Zero && SetMaxSimultaneousTileGenerationJobsCount_MaxNumberOfJobs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:SetMaxSimultaneousTileGenerationJobsCount", SetMaxSimultaneousTileGenerationJobsCount_IsValid);
		SetGeometryGatheringMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGeometryGatheringMode");
		SetGeometryGatheringMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGeometryGatheringMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGeometryGatheringMode_NewMode_PropertyAddress, SetGeometryGatheringMode_FunctionAddress, "NewMode");
		SetGeometryGatheringMode_NewMode_Offset = NativeReflectionCached.GetPropertyOffset(SetGeometryGatheringMode_FunctionAddress, "NewMode");
		SetGeometryGatheringMode_NewMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGeometryGatheringMode_FunctionAddress, "NewMode", Classes.FEnumProperty);
		SetGeometryGatheringMode_IsValid = SetGeometryGatheringMode_FunctionAddress != IntPtr.Zero && SetGeometryGatheringMode_NewMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:SetGeometryGatheringMode", SetGeometryGatheringMode_IsValid);
		ResetMaxSimultaneousTileGenerationJobsCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetMaxSimultaneousTileGenerationJobsCount");
		ResetMaxSimultaneousTileGenerationJobsCount_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetMaxSimultaneousTileGenerationJobsCount_FunctionAddress);
		ResetMaxSimultaneousTileGenerationJobsCount_IsValid = ResetMaxSimultaneousTileGenerationJobsCount_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:ResetMaxSimultaneousTileGenerationJobsCount", ResetMaxSimultaneousTileGenerationJobsCount_IsValid);
		RegisterNavigationInvoker_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterNavigationInvoker");
		RegisterNavigationInvoker_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterNavigationInvoker_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterNavigationInvoker_Invoker_PropertyAddress, RegisterNavigationInvoker_FunctionAddress, "Invoker");
		RegisterNavigationInvoker_Invoker_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNavigationInvoker_FunctionAddress, "Invoker");
		RegisterNavigationInvoker_Invoker_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNavigationInvoker_FunctionAddress, "Invoker", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterNavigationInvoker_TileGenerationRadius_PropertyAddress, RegisterNavigationInvoker_FunctionAddress, "TileGenerationRadius");
		RegisterNavigationInvoker_TileGenerationRadius_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNavigationInvoker_FunctionAddress, "TileGenerationRadius");
		RegisterNavigationInvoker_TileGenerationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNavigationInvoker_FunctionAddress, "TileGenerationRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterNavigationInvoker_TileRemovalRadius_PropertyAddress, RegisterNavigationInvoker_FunctionAddress, "TileRemovalRadius");
		RegisterNavigationInvoker_TileRemovalRadius_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNavigationInvoker_FunctionAddress, "TileRemovalRadius");
		RegisterNavigationInvoker_TileRemovalRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNavigationInvoker_FunctionAddress, "TileRemovalRadius", Classes.FFloatProperty);
		RegisterNavigationInvoker_IsValid = RegisterNavigationInvoker_FunctionAddress != IntPtr.Zero && RegisterNavigationInvoker_Invoker_IsValid && RegisterNavigationInvoker_TileGenerationRadius_IsValid && RegisterNavigationInvoker_TileRemovalRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:RegisterNavigationInvoker", RegisterNavigationInvoker_IsValid);
		OnNavigationBoundsUpdated_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnNavigationBoundsUpdated");
		OnNavigationBoundsUpdated_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNavigationBoundsUpdated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNavigationBoundsUpdated_NavVolume_PropertyAddress, OnNavigationBoundsUpdated_FunctionAddress, "NavVolume");
		OnNavigationBoundsUpdated_NavVolume_Offset = NativeReflectionCached.GetPropertyOffset(OnNavigationBoundsUpdated_FunctionAddress, "NavVolume");
		OnNavigationBoundsUpdated_NavVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNavigationBoundsUpdated_FunctionAddress, "NavVolume", Classes.FObjectProperty);
		OnNavigationBoundsUpdated_IsValid = OnNavigationBoundsUpdated_FunctionAddress != IntPtr.Zero && OnNavigationBoundsUpdated_NavVolume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:OnNavigationBoundsUpdated", OnNavigationBoundsUpdated_IsValid);
		NavigationRaycast_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NavigationRaycast");
		NavigationRaycast_ParamsSize = NativeReflection.GetFunctionParamsSize(NavigationRaycast_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NavigationRaycast_WorldContextObject_PropertyAddress, NavigationRaycast_FunctionAddress, "WorldContextObject");
		NavigationRaycast_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(NavigationRaycast_FunctionAddress, "WorldContextObject");
		NavigationRaycast_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(NavigationRaycast_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NavigationRaycast_RayStart_PropertyAddress, NavigationRaycast_FunctionAddress, "RayStart");
		NavigationRaycast_RayStart_Offset = NativeReflectionCached.GetPropertyOffset(NavigationRaycast_FunctionAddress, "RayStart");
		NavigationRaycast_RayStart_IsValid = NativeReflectionCached.ValidatePropertyClass(NavigationRaycast_FunctionAddress, "RayStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NavigationRaycast_RayEnd_PropertyAddress, NavigationRaycast_FunctionAddress, "RayEnd");
		NavigationRaycast_RayEnd_Offset = NativeReflectionCached.GetPropertyOffset(NavigationRaycast_FunctionAddress, "RayEnd");
		NavigationRaycast_RayEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(NavigationRaycast_FunctionAddress, "RayEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NavigationRaycast_HitLocation_PropertyAddress, NavigationRaycast_FunctionAddress, "HitLocation");
		NavigationRaycast_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(NavigationRaycast_FunctionAddress, "HitLocation");
		NavigationRaycast_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(NavigationRaycast_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NavigationRaycast_FilterClass_PropertyAddress, NavigationRaycast_FunctionAddress, "FilterClass");
		NavigationRaycast_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(NavigationRaycast_FunctionAddress, "FilterClass");
		NavigationRaycast_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(NavigationRaycast_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref NavigationRaycast_Querier_PropertyAddress, NavigationRaycast_FunctionAddress, "Querier");
		NavigationRaycast_Querier_Offset = NativeReflectionCached.GetPropertyOffset(NavigationRaycast_FunctionAddress, "Querier");
		NavigationRaycast_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(NavigationRaycast_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NavigationRaycast_ReturnValue_PropertyAddress, NavigationRaycast_FunctionAddress, "ReturnValue");
		NavigationRaycast_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NavigationRaycast_FunctionAddress, "ReturnValue");
		NavigationRaycast_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NavigationRaycast_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NavigationRaycast_IsValid = NavigationRaycast_FunctionAddress != IntPtr.Zero && NavigationRaycast_WorldContextObject_IsValid && NavigationRaycast_RayStart_IsValid && NavigationRaycast_RayEnd_IsValid && NavigationRaycast_HitLocation_IsValid && NavigationRaycast_FilterClass_IsValid && NavigationRaycast_Querier_IsValid && NavigationRaycast_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:NavigationRaycast", NavigationRaycast_IsValid);
		ReplaceAreaInOctreeData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_ReplaceAreaInOctreeData");
		ReplaceAreaInOctreeData_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceAreaInOctreeData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAreaInOctreeData_Object_PropertyAddress, ReplaceAreaInOctreeData_FunctionAddress, "Object");
		ReplaceAreaInOctreeData_Object_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAreaInOctreeData_FunctionAddress, "Object");
		ReplaceAreaInOctreeData_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAreaInOctreeData_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAreaInOctreeData_OldArea_PropertyAddress, ReplaceAreaInOctreeData_FunctionAddress, "OldArea");
		ReplaceAreaInOctreeData_OldArea_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAreaInOctreeData_FunctionAddress, "OldArea");
		ReplaceAreaInOctreeData_OldArea_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAreaInOctreeData_FunctionAddress, "OldArea", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAreaInOctreeData_NewArea_PropertyAddress, ReplaceAreaInOctreeData_FunctionAddress, "NewArea");
		ReplaceAreaInOctreeData_NewArea_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAreaInOctreeData_FunctionAddress, "NewArea");
		ReplaceAreaInOctreeData_NewArea_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAreaInOctreeData_FunctionAddress, "NewArea", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAreaInOctreeData_ReturnValue_PropertyAddress, ReplaceAreaInOctreeData_FunctionAddress, "ReturnValue");
		ReplaceAreaInOctreeData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAreaInOctreeData_FunctionAddress, "ReturnValue");
		ReplaceAreaInOctreeData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAreaInOctreeData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReplaceAreaInOctreeData_IsValid = ReplaceAreaInOctreeData_FunctionAddress != IntPtr.Zero && ReplaceAreaInOctreeData_Object_IsValid && ReplaceAreaInOctreeData_OldArea_IsValid && ReplaceAreaInOctreeData_NewArea_IsValid && ReplaceAreaInOctreeData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:K2_ReplaceAreaInOctreeData", ReplaceAreaInOctreeData_IsValid);
		ProjectPointToNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_ProjectPointToNavigation");
		ProjectPointToNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectPointToNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectPointToNavigation_WorldContextObject_PropertyAddress, ProjectPointToNavigation_FunctionAddress, "WorldContextObject");
		ProjectPointToNavigation_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPointToNavigation_FunctionAddress, "WorldContextObject");
		ProjectPointToNavigation_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPointToNavigation_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPointToNavigation_Point_PropertyAddress, ProjectPointToNavigation_FunctionAddress, "Point");
		ProjectPointToNavigation_Point_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPointToNavigation_FunctionAddress, "Point");
		ProjectPointToNavigation_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPointToNavigation_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPointToNavigation_ProjectedLocation_PropertyAddress, ProjectPointToNavigation_FunctionAddress, "ProjectedLocation");
		ProjectPointToNavigation_ProjectedLocation_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPointToNavigation_FunctionAddress, "ProjectedLocation");
		ProjectPointToNavigation_ProjectedLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPointToNavigation_FunctionAddress, "ProjectedLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPointToNavigation_NavData_PropertyAddress, ProjectPointToNavigation_FunctionAddress, "NavData");
		ProjectPointToNavigation_NavData_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPointToNavigation_FunctionAddress, "NavData");
		ProjectPointToNavigation_NavData_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPointToNavigation_FunctionAddress, "NavData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPointToNavigation_FilterClass_PropertyAddress, ProjectPointToNavigation_FunctionAddress, "FilterClass");
		ProjectPointToNavigation_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPointToNavigation_FunctionAddress, "FilterClass");
		ProjectPointToNavigation_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPointToNavigation_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPointToNavigation_QueryExtent_PropertyAddress, ProjectPointToNavigation_FunctionAddress, "QueryExtent");
		ProjectPointToNavigation_QueryExtent_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPointToNavigation_FunctionAddress, "QueryExtent");
		ProjectPointToNavigation_QueryExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPointToNavigation_FunctionAddress, "QueryExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPointToNavigation_ReturnValue_PropertyAddress, ProjectPointToNavigation_FunctionAddress, "ReturnValue");
		ProjectPointToNavigation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPointToNavigation_FunctionAddress, "ReturnValue");
		ProjectPointToNavigation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPointToNavigation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProjectPointToNavigation_IsValid = ProjectPointToNavigation_FunctionAddress != IntPtr.Zero && ProjectPointToNavigation_WorldContextObject_IsValid && ProjectPointToNavigation_Point_IsValid && ProjectPointToNavigation_ProjectedLocation_IsValid && ProjectPointToNavigation_NavData_IsValid && ProjectPointToNavigation_FilterClass_IsValid && ProjectPointToNavigation_QueryExtent_IsValid && ProjectPointToNavigation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:K2_ProjectPointToNavigation", ProjectPointToNavigation_IsValid);
		GetRandomReachablePointInRadius_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_GetRandomReachablePointInRadius");
		GetRandomReachablePointInRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomReachablePointInRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRandomReachablePointInRadius_WorldContextObject_PropertyAddress, GetRandomReachablePointInRadius_FunctionAddress, "WorldContextObject");
		GetRandomReachablePointInRadius_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomReachablePointInRadius_FunctionAddress, "WorldContextObject");
		GetRandomReachablePointInRadius_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomReachablePointInRadius_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomReachablePointInRadius_Origin_PropertyAddress, GetRandomReachablePointInRadius_FunctionAddress, "Origin");
		GetRandomReachablePointInRadius_Origin_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomReachablePointInRadius_FunctionAddress, "Origin");
		GetRandomReachablePointInRadius_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomReachablePointInRadius_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomReachablePointInRadius_RandomLocation_PropertyAddress, GetRandomReachablePointInRadius_FunctionAddress, "RandomLocation");
		GetRandomReachablePointInRadius_RandomLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomReachablePointInRadius_FunctionAddress, "RandomLocation");
		GetRandomReachablePointInRadius_RandomLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomReachablePointInRadius_FunctionAddress, "RandomLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomReachablePointInRadius_Radius_PropertyAddress, GetRandomReachablePointInRadius_FunctionAddress, "Radius");
		GetRandomReachablePointInRadius_Radius_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomReachablePointInRadius_FunctionAddress, "Radius");
		GetRandomReachablePointInRadius_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomReachablePointInRadius_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomReachablePointInRadius_NavData_PropertyAddress, GetRandomReachablePointInRadius_FunctionAddress, "NavData");
		GetRandomReachablePointInRadius_NavData_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomReachablePointInRadius_FunctionAddress, "NavData");
		GetRandomReachablePointInRadius_NavData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomReachablePointInRadius_FunctionAddress, "NavData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomReachablePointInRadius_FilterClass_PropertyAddress, GetRandomReachablePointInRadius_FunctionAddress, "FilterClass");
		GetRandomReachablePointInRadius_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomReachablePointInRadius_FunctionAddress, "FilterClass");
		GetRandomReachablePointInRadius_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomReachablePointInRadius_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomReachablePointInRadius_ReturnValue_PropertyAddress, GetRandomReachablePointInRadius_FunctionAddress, "ReturnValue");
		GetRandomReachablePointInRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomReachablePointInRadius_FunctionAddress, "ReturnValue");
		GetRandomReachablePointInRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomReachablePointInRadius_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetRandomReachablePointInRadius_IsValid = GetRandomReachablePointInRadius_FunctionAddress != IntPtr.Zero && GetRandomReachablePointInRadius_WorldContextObject_IsValid && GetRandomReachablePointInRadius_Origin_IsValid && GetRandomReachablePointInRadius_RandomLocation_IsValid && GetRandomReachablePointInRadius_Radius_IsValid && GetRandomReachablePointInRadius_NavData_IsValid && GetRandomReachablePointInRadius_FilterClass_IsValid && GetRandomReachablePointInRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:K2_GetRandomReachablePointInRadius", GetRandomReachablePointInRadius_IsValid);
		GetRandomPointInNavigableRadius_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_GetRandomPointInNavigableRadius");
		GetRandomPointInNavigableRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomPointInNavigableRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRandomPointInNavigableRadius_WorldContextObject_PropertyAddress, GetRandomPointInNavigableRadius_FunctionAddress, "WorldContextObject");
		GetRandomPointInNavigableRadius_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomPointInNavigableRadius_FunctionAddress, "WorldContextObject");
		GetRandomPointInNavigableRadius_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomPointInNavigableRadius_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomPointInNavigableRadius_Origin_PropertyAddress, GetRandomPointInNavigableRadius_FunctionAddress, "Origin");
		GetRandomPointInNavigableRadius_Origin_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomPointInNavigableRadius_FunctionAddress, "Origin");
		GetRandomPointInNavigableRadius_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomPointInNavigableRadius_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomPointInNavigableRadius_RandomLocation_PropertyAddress, GetRandomPointInNavigableRadius_FunctionAddress, "RandomLocation");
		GetRandomPointInNavigableRadius_RandomLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomPointInNavigableRadius_FunctionAddress, "RandomLocation");
		GetRandomPointInNavigableRadius_RandomLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomPointInNavigableRadius_FunctionAddress, "RandomLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomPointInNavigableRadius_Radius_PropertyAddress, GetRandomPointInNavigableRadius_FunctionAddress, "Radius");
		GetRandomPointInNavigableRadius_Radius_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomPointInNavigableRadius_FunctionAddress, "Radius");
		GetRandomPointInNavigableRadius_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomPointInNavigableRadius_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomPointInNavigableRadius_NavData_PropertyAddress, GetRandomPointInNavigableRadius_FunctionAddress, "NavData");
		GetRandomPointInNavigableRadius_NavData_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomPointInNavigableRadius_FunctionAddress, "NavData");
		GetRandomPointInNavigableRadius_NavData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomPointInNavigableRadius_FunctionAddress, "NavData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomPointInNavigableRadius_FilterClass_PropertyAddress, GetRandomPointInNavigableRadius_FunctionAddress, "FilterClass");
		GetRandomPointInNavigableRadius_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomPointInNavigableRadius_FunctionAddress, "FilterClass");
		GetRandomPointInNavigableRadius_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomPointInNavigableRadius_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomPointInNavigableRadius_ReturnValue_PropertyAddress, GetRandomPointInNavigableRadius_FunctionAddress, "ReturnValue");
		GetRandomPointInNavigableRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomPointInNavigableRadius_FunctionAddress, "ReturnValue");
		GetRandomPointInNavigableRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomPointInNavigableRadius_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetRandomPointInNavigableRadius_IsValid = GetRandomPointInNavigableRadius_FunctionAddress != IntPtr.Zero && GetRandomPointInNavigableRadius_WorldContextObject_IsValid && GetRandomPointInNavigableRadius_Origin_IsValid && GetRandomPointInNavigableRadius_RandomLocation_IsValid && GetRandomPointInNavigableRadius_Radius_IsValid && GetRandomPointInNavigableRadius_NavData_IsValid && GetRandomPointInNavigableRadius_FilterClass_IsValid && GetRandomPointInNavigableRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:K2_GetRandomPointInNavigableRadius", GetRandomPointInNavigableRadius_IsValid);
		GetRandomLocationInNavigableRadius_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_GetRandomLocationInNavigableRadius");
		GetRandomLocationInNavigableRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomLocationInNavigableRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRandomLocationInNavigableRadius_WorldContextObject_PropertyAddress, GetRandomLocationInNavigableRadius_FunctionAddress, "WorldContextObject");
		GetRandomLocationInNavigableRadius_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomLocationInNavigableRadius_FunctionAddress, "WorldContextObject");
		GetRandomLocationInNavigableRadius_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomLocationInNavigableRadius_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomLocationInNavigableRadius_Origin_PropertyAddress, GetRandomLocationInNavigableRadius_FunctionAddress, "Origin");
		GetRandomLocationInNavigableRadius_Origin_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomLocationInNavigableRadius_FunctionAddress, "Origin");
		GetRandomLocationInNavigableRadius_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomLocationInNavigableRadius_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomLocationInNavigableRadius_RandomLocation_PropertyAddress, GetRandomLocationInNavigableRadius_FunctionAddress, "RandomLocation");
		GetRandomLocationInNavigableRadius_RandomLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomLocationInNavigableRadius_FunctionAddress, "RandomLocation");
		GetRandomLocationInNavigableRadius_RandomLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomLocationInNavigableRadius_FunctionAddress, "RandomLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomLocationInNavigableRadius_Radius_PropertyAddress, GetRandomLocationInNavigableRadius_FunctionAddress, "Radius");
		GetRandomLocationInNavigableRadius_Radius_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomLocationInNavigableRadius_FunctionAddress, "Radius");
		GetRandomLocationInNavigableRadius_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomLocationInNavigableRadius_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomLocationInNavigableRadius_NavData_PropertyAddress, GetRandomLocationInNavigableRadius_FunctionAddress, "NavData");
		GetRandomLocationInNavigableRadius_NavData_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomLocationInNavigableRadius_FunctionAddress, "NavData");
		GetRandomLocationInNavigableRadius_NavData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomLocationInNavigableRadius_FunctionAddress, "NavData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomLocationInNavigableRadius_FilterClass_PropertyAddress, GetRandomLocationInNavigableRadius_FunctionAddress, "FilterClass");
		GetRandomLocationInNavigableRadius_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomLocationInNavigableRadius_FunctionAddress, "FilterClass");
		GetRandomLocationInNavigableRadius_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomLocationInNavigableRadius_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomLocationInNavigableRadius_ReturnValue_PropertyAddress, GetRandomLocationInNavigableRadius_FunctionAddress, "ReturnValue");
		GetRandomLocationInNavigableRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomLocationInNavigableRadius_FunctionAddress, "ReturnValue");
		GetRandomLocationInNavigableRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomLocationInNavigableRadius_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetRandomLocationInNavigableRadius_IsValid = GetRandomLocationInNavigableRadius_FunctionAddress != IntPtr.Zero && GetRandomLocationInNavigableRadius_WorldContextObject_IsValid && GetRandomLocationInNavigableRadius_Origin_IsValid && GetRandomLocationInNavigableRadius_RandomLocation_IsValid && GetRandomLocationInNavigableRadius_Radius_IsValid && GetRandomLocationInNavigableRadius_NavData_IsValid && GetRandomLocationInNavigableRadius_FilterClass_IsValid && GetRandomLocationInNavigableRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:K2_GetRandomLocationInNavigableRadius", GetRandomLocationInNavigableRadius_IsValid);
		IsNavigationBeingBuiltOrLocked_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsNavigationBeingBuiltOrLocked");
		IsNavigationBeingBuiltOrLocked_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNavigationBeingBuiltOrLocked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNavigationBeingBuiltOrLocked_WorldContextObject_PropertyAddress, IsNavigationBeingBuiltOrLocked_FunctionAddress, "WorldContextObject");
		IsNavigationBeingBuiltOrLocked_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(IsNavigationBeingBuiltOrLocked_FunctionAddress, "WorldContextObject");
		IsNavigationBeingBuiltOrLocked_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNavigationBeingBuiltOrLocked_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNavigationBeingBuiltOrLocked_ReturnValue_PropertyAddress, IsNavigationBeingBuiltOrLocked_FunctionAddress, "ReturnValue");
		IsNavigationBeingBuiltOrLocked_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNavigationBeingBuiltOrLocked_FunctionAddress, "ReturnValue");
		IsNavigationBeingBuiltOrLocked_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNavigationBeingBuiltOrLocked_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNavigationBeingBuiltOrLocked_IsValid = IsNavigationBeingBuiltOrLocked_FunctionAddress != IntPtr.Zero && IsNavigationBeingBuiltOrLocked_WorldContextObject_IsValid && IsNavigationBeingBuiltOrLocked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:IsNavigationBeingBuiltOrLocked", IsNavigationBeingBuiltOrLocked_IsValid);
		IsNavigationBeingBuilt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsNavigationBeingBuilt");
		IsNavigationBeingBuilt_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNavigationBeingBuilt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNavigationBeingBuilt_WorldContextObject_PropertyAddress, IsNavigationBeingBuilt_FunctionAddress, "WorldContextObject");
		IsNavigationBeingBuilt_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(IsNavigationBeingBuilt_FunctionAddress, "WorldContextObject");
		IsNavigationBeingBuilt_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNavigationBeingBuilt_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNavigationBeingBuilt_ReturnValue_PropertyAddress, IsNavigationBeingBuilt_FunctionAddress, "ReturnValue");
		IsNavigationBeingBuilt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNavigationBeingBuilt_FunctionAddress, "ReturnValue");
		IsNavigationBeingBuilt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNavigationBeingBuilt_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNavigationBeingBuilt_IsValid = IsNavigationBeingBuilt_FunctionAddress != IntPtr.Zero && IsNavigationBeingBuilt_WorldContextObject_IsValid && IsNavigationBeingBuilt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:IsNavigationBeingBuilt", IsNavigationBeingBuilt_IsValid);
		GetPathLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPathLength");
		GetPathLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPathLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPathLength_WorldContextObject_PropertyAddress, GetPathLength_FunctionAddress, "WorldContextObject");
		GetPathLength_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetPathLength_FunctionAddress, "WorldContextObject");
		GetPathLength_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathLength_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathLength_PathStart_PropertyAddress, GetPathLength_FunctionAddress, "PathStart");
		GetPathLength_PathStart_Offset = NativeReflectionCached.GetPropertyOffset(GetPathLength_FunctionAddress, "PathStart");
		GetPathLength_PathStart_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathLength_FunctionAddress, "PathStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathLength_PathEnd_PropertyAddress, GetPathLength_FunctionAddress, "PathEnd");
		GetPathLength_PathEnd_Offset = NativeReflectionCached.GetPropertyOffset(GetPathLength_FunctionAddress, "PathEnd");
		GetPathLength_PathEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathLength_FunctionAddress, "PathEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathLength_PathLength_PropertyAddress, GetPathLength_FunctionAddress, "PathLength");
		GetPathLength_PathLength_Offset = NativeReflectionCached.GetPropertyOffset(GetPathLength_FunctionAddress, "PathLength");
		GetPathLength_PathLength_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathLength_FunctionAddress, "PathLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathLength_NavData_PropertyAddress, GetPathLength_FunctionAddress, "NavData");
		GetPathLength_NavData_Offset = NativeReflectionCached.GetPropertyOffset(GetPathLength_FunctionAddress, "NavData");
		GetPathLength_NavData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathLength_FunctionAddress, "NavData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathLength_FilterClass_PropertyAddress, GetPathLength_FunctionAddress, "FilterClass");
		GetPathLength_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(GetPathLength_FunctionAddress, "FilterClass");
		GetPathLength_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathLength_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathLength_ReturnValue_PropertyAddress, GetPathLength_FunctionAddress, "ReturnValue");
		GetPathLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPathLength_FunctionAddress, "ReturnValue");
		GetPathLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathLength_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetPathLength_IsValid = GetPathLength_FunctionAddress != IntPtr.Zero && GetPathLength_WorldContextObject_IsValid && GetPathLength_PathStart_IsValid && GetPathLength_PathEnd_IsValid && GetPathLength_PathLength_IsValid && GetPathLength_NavData_IsValid && GetPathLength_FilterClass_IsValid && GetPathLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:GetPathLength", GetPathLength_IsValid);
		GetPathCost_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPathCost");
		GetPathCost_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPathCost_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPathCost_WorldContextObject_PropertyAddress, GetPathCost_FunctionAddress, "WorldContextObject");
		GetPathCost_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetPathCost_FunctionAddress, "WorldContextObject");
		GetPathCost_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathCost_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathCost_PathStart_PropertyAddress, GetPathCost_FunctionAddress, "PathStart");
		GetPathCost_PathStart_Offset = NativeReflectionCached.GetPropertyOffset(GetPathCost_FunctionAddress, "PathStart");
		GetPathCost_PathStart_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathCost_FunctionAddress, "PathStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathCost_PathEnd_PropertyAddress, GetPathCost_FunctionAddress, "PathEnd");
		GetPathCost_PathEnd_Offset = NativeReflectionCached.GetPropertyOffset(GetPathCost_FunctionAddress, "PathEnd");
		GetPathCost_PathEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathCost_FunctionAddress, "PathEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathCost_PathCost_PropertyAddress, GetPathCost_FunctionAddress, "PathCost");
		GetPathCost_PathCost_Offset = NativeReflectionCached.GetPropertyOffset(GetPathCost_FunctionAddress, "PathCost");
		GetPathCost_PathCost_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathCost_FunctionAddress, "PathCost", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathCost_NavData_PropertyAddress, GetPathCost_FunctionAddress, "NavData");
		GetPathCost_NavData_Offset = NativeReflectionCached.GetPropertyOffset(GetPathCost_FunctionAddress, "NavData");
		GetPathCost_NavData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathCost_FunctionAddress, "NavData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathCost_FilterClass_PropertyAddress, GetPathCost_FunctionAddress, "FilterClass");
		GetPathCost_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(GetPathCost_FunctionAddress, "FilterClass");
		GetPathCost_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathCost_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathCost_ReturnValue_PropertyAddress, GetPathCost_FunctionAddress, "ReturnValue");
		GetPathCost_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPathCost_FunctionAddress, "ReturnValue");
		GetPathCost_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathCost_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetPathCost_IsValid = GetPathCost_FunctionAddress != IntPtr.Zero && GetPathCost_WorldContextObject_IsValid && GetPathCost_PathStart_IsValid && GetPathCost_PathEnd_IsValid && GetPathCost_PathCost_IsValid && GetPathCost_NavData_IsValid && GetPathCost_FilterClass_IsValid && GetPathCost_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:GetPathCost", GetPathCost_IsValid);
		GetNavigationSystem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNavigationSystem");
		GetNavigationSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNavigationSystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNavigationSystem_WorldContextObject_PropertyAddress, GetNavigationSystem_FunctionAddress, "WorldContextObject");
		GetNavigationSystem_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetNavigationSystem_FunctionAddress, "WorldContextObject");
		GetNavigationSystem_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNavigationSystem_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNavigationSystem_ReturnValue_PropertyAddress, GetNavigationSystem_FunctionAddress, "ReturnValue");
		GetNavigationSystem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNavigationSystem_FunctionAddress, "ReturnValue");
		GetNavigationSystem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNavigationSystem_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNavigationSystem_IsValid = GetNavigationSystem_FunctionAddress != IntPtr.Zero && GetNavigationSystem_WorldContextObject_IsValid && GetNavigationSystem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:GetNavigationSystem", GetNavigationSystem_IsValid);
		FindPathToLocationSynchronously_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindPathToLocationSynchronously");
		FindPathToLocationSynchronously_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPathToLocationSynchronously_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPathToLocationSynchronously_WorldContextObject_PropertyAddress, FindPathToLocationSynchronously_FunctionAddress, "WorldContextObject");
		FindPathToLocationSynchronously_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToLocationSynchronously_FunctionAddress, "WorldContextObject");
		FindPathToLocationSynchronously_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToLocationSynchronously_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToLocationSynchronously_PathStart_PropertyAddress, FindPathToLocationSynchronously_FunctionAddress, "PathStart");
		FindPathToLocationSynchronously_PathStart_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToLocationSynchronously_FunctionAddress, "PathStart");
		FindPathToLocationSynchronously_PathStart_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToLocationSynchronously_FunctionAddress, "PathStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToLocationSynchronously_PathEnd_PropertyAddress, FindPathToLocationSynchronously_FunctionAddress, "PathEnd");
		FindPathToLocationSynchronously_PathEnd_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToLocationSynchronously_FunctionAddress, "PathEnd");
		FindPathToLocationSynchronously_PathEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToLocationSynchronously_FunctionAddress, "PathEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToLocationSynchronously_PathfindingContext_PropertyAddress, FindPathToLocationSynchronously_FunctionAddress, "PathfindingContext");
		FindPathToLocationSynchronously_PathfindingContext_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToLocationSynchronously_FunctionAddress, "PathfindingContext");
		FindPathToLocationSynchronously_PathfindingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToLocationSynchronously_FunctionAddress, "PathfindingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToLocationSynchronously_FilterClass_PropertyAddress, FindPathToLocationSynchronously_FunctionAddress, "FilterClass");
		FindPathToLocationSynchronously_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToLocationSynchronously_FunctionAddress, "FilterClass");
		FindPathToLocationSynchronously_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToLocationSynchronously_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToLocationSynchronously_ReturnValue_PropertyAddress, FindPathToLocationSynchronously_FunctionAddress, "ReturnValue");
		FindPathToLocationSynchronously_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToLocationSynchronously_FunctionAddress, "ReturnValue");
		FindPathToLocationSynchronously_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToLocationSynchronously_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindPathToLocationSynchronously_IsValid = FindPathToLocationSynchronously_FunctionAddress != IntPtr.Zero && FindPathToLocationSynchronously_WorldContextObject_IsValid && FindPathToLocationSynchronously_PathStart_IsValid && FindPathToLocationSynchronously_PathEnd_IsValid && FindPathToLocationSynchronously_PathfindingContext_IsValid && FindPathToLocationSynchronously_FilterClass_IsValid && FindPathToLocationSynchronously_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:FindPathToLocationSynchronously", FindPathToLocationSynchronously_IsValid);
		FindPathToActorSynchronously_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindPathToActorSynchronously");
		FindPathToActorSynchronously_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPathToActorSynchronously_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPathToActorSynchronously_WorldContextObject_PropertyAddress, FindPathToActorSynchronously_FunctionAddress, "WorldContextObject");
		FindPathToActorSynchronously_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToActorSynchronously_FunctionAddress, "WorldContextObject");
		FindPathToActorSynchronously_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToActorSynchronously_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToActorSynchronously_PathStart_PropertyAddress, FindPathToActorSynchronously_FunctionAddress, "PathStart");
		FindPathToActorSynchronously_PathStart_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToActorSynchronously_FunctionAddress, "PathStart");
		FindPathToActorSynchronously_PathStart_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToActorSynchronously_FunctionAddress, "PathStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToActorSynchronously_GoalActor_PropertyAddress, FindPathToActorSynchronously_FunctionAddress, "GoalActor");
		FindPathToActorSynchronously_GoalActor_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToActorSynchronously_FunctionAddress, "GoalActor");
		FindPathToActorSynchronously_GoalActor_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToActorSynchronously_FunctionAddress, "GoalActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToActorSynchronously_TetherDistance_PropertyAddress, FindPathToActorSynchronously_FunctionAddress, "TetherDistance");
		FindPathToActorSynchronously_TetherDistance_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToActorSynchronously_FunctionAddress, "TetherDistance");
		FindPathToActorSynchronously_TetherDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToActorSynchronously_FunctionAddress, "TetherDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToActorSynchronously_PathfindingContext_PropertyAddress, FindPathToActorSynchronously_FunctionAddress, "PathfindingContext");
		FindPathToActorSynchronously_PathfindingContext_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToActorSynchronously_FunctionAddress, "PathfindingContext");
		FindPathToActorSynchronously_PathfindingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToActorSynchronously_FunctionAddress, "PathfindingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToActorSynchronously_FilterClass_PropertyAddress, FindPathToActorSynchronously_FunctionAddress, "FilterClass");
		FindPathToActorSynchronously_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToActorSynchronously_FunctionAddress, "FilterClass");
		FindPathToActorSynchronously_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToActorSynchronously_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathToActorSynchronously_ReturnValue_PropertyAddress, FindPathToActorSynchronously_FunctionAddress, "ReturnValue");
		FindPathToActorSynchronously_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPathToActorSynchronously_FunctionAddress, "ReturnValue");
		FindPathToActorSynchronously_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathToActorSynchronously_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindPathToActorSynchronously_IsValid = FindPathToActorSynchronously_FunctionAddress != IntPtr.Zero && FindPathToActorSynchronously_WorldContextObject_IsValid && FindPathToActorSynchronously_PathStart_IsValid && FindPathToActorSynchronously_GoalActor_IsValid && FindPathToActorSynchronously_TetherDistance_IsValid && FindPathToActorSynchronously_PathfindingContext_IsValid && FindPathToActorSynchronously_FilterClass_IsValid && FindPathToActorSynchronously_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:FindPathToActorSynchronously", FindPathToActorSynchronously_IsValid);
		FindNearestPoly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindNearestPoly");
		FindNearestPoly_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNearestPoly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPoly_WorldContextObject_PropertyAddress, FindNearestPoly_FunctionAddress, "WorldContextObject");
		FindNearestPoly_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPoly_FunctionAddress, "WorldContextObject");
		FindNearestPoly_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPoly_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPoly_Loc_PropertyAddress, FindNearestPoly_FunctionAddress, "Loc");
		FindNearestPoly_Loc_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPoly_FunctionAddress, "Loc");
		FindNearestPoly_Loc_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPoly_FunctionAddress, "Loc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPoly_Extent_PropertyAddress, FindNearestPoly_FunctionAddress, "Extent");
		FindNearestPoly_Extent_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPoly_FunctionAddress, "Extent");
		FindNearestPoly_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPoly_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPoly_NavData_PropertyAddress, FindNearestPoly_FunctionAddress, "NavData");
		FindNearestPoly_NavData_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPoly_FunctionAddress, "NavData");
		FindNearestPoly_NavData_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPoly_FunctionAddress, "NavData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPoly_FilterClass_PropertyAddress, FindNearestPoly_FunctionAddress, "FilterClass");
		FindNearestPoly_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPoly_FunctionAddress, "FilterClass");
		FindNearestPoly_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPoly_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPoly_ReturnValue_PropertyAddress, FindNearestPoly_FunctionAddress, "ReturnValue");
		FindNearestPoly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPoly_FunctionAddress, "ReturnValue");
		FindNearestPoly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPoly_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindNearestPoly_IsValid = FindNearestPoly_FunctionAddress != IntPtr.Zero && FindNearestPoly_WorldContextObject_IsValid && FindNearestPoly_Loc_IsValid && FindNearestPoly_Extent_IsValid && FindNearestPoly_NavData_IsValid && FindNearestPoly_FilterClass_IsValid && FindNearestPoly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationSystemV1:FindNearestPoly", FindNearestPoly_IsValid);
	}
}
