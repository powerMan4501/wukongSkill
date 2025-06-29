using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_ActorFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UpdateActorOverlaps_IsValid;

	private static IntPtr UpdateActorOverlaps_FunctionAddress;

	private static int UpdateActorOverlaps_ParamsSize;

	private static bool UpdateActorOverlaps_Actor_IsValid;

	private static FFieldAddress UpdateActorOverlaps_Actor_PropertyAddress;

	private static int UpdateActorOverlaps_Actor_Offset;

	private static bool StatLevelNaniteMemory_IsValid;

	private static IntPtr StatLevelNaniteMemory_FunctionAddress;

	private static int StatLevelNaniteMemory_ParamsSize;

	private static bool StatLevelNaniteMemory_LoadedLevels_IsValid;

	private static FFieldAddress StatLevelNaniteMemory_LoadedLevels_PropertyAddress;

	private static int StatLevelNaniteMemory_LoadedLevels_Offset;

	private static bool StatLevelNaniteMemory_WorldPositionFile_IsValid;

	private static FFieldAddress StatLevelNaniteMemory_WorldPositionFile_PropertyAddress;

	private static int StatLevelNaniteMemory_WorldPositionFile_Offset;

	private static bool StatLevelNaniteMemory_MemoryFile_IsValid;

	private static FFieldAddress StatLevelNaniteMemory_MemoryFile_PropertyAddress;

	private static int StatLevelNaniteMemory_MemoryFile_Offset;

	private static bool SpawnSphereUniformPoints_IsValid;

	private static IntPtr SpawnSphereUniformPoints_FunctionAddress;

	private static int SpawnSphereUniformPoints_ParamsSize;

	private static bool SpawnSphereUniformPoints_SphereUniformPoints_IsValid;

	private static FFieldAddress SpawnSphereUniformPoints_SphereUniformPoints_PropertyAddress;

	private static int SpawnSphereUniformPoints_SphereUniformPoints_Offset;

	private static bool SpawnSphereUniformPoints_NumOfPoints_IsValid;

	private static FFieldAddress SpawnSphereUniformPoints_NumOfPoints_PropertyAddress;

	private static int SpawnSphereUniformPoints_NumOfPoints_Offset;

	private static bool SpawnSphereUniformPoints_Radius_IsValid;

	private static FFieldAddress SpawnSphereUniformPoints_Radius_PropertyAddress;

	private static int SpawnSphereUniformPoints_Radius_Offset;

	private static bool SpawnBlueprintActorByFactory_BP_IsValid;

	private static IntPtr SpawnBlueprintActorByFactory_BP_FunctionAddress;

	private static int SpawnBlueprintActorByFactory_BP_ParamsSize;

	private static bool SpawnBlueprintActorByFactory_BP_InAsset_IsValid;

	private static FFieldAddress SpawnBlueprintActorByFactory_BP_InAsset_PropertyAddress;

	private static int SpawnBlueprintActorByFactory_BP_InAsset_Offset;

	private static bool SpawnBlueprintActorByFactory_BP_Obj_IsValid;

	private static FFieldAddress SpawnBlueprintActorByFactory_BP_Obj_PropertyAddress;

	private static int SpawnBlueprintActorByFactory_BP_Obj_Offset;

	private static bool SpawnBlueprintActorByFactory_BP_InTransform_IsValid;

	private static FFieldAddress SpawnBlueprintActorByFactory_BP_InTransform_PropertyAddress;

	private static int SpawnBlueprintActorByFactory_BP_InTransform_Offset;

	private static bool SpawnBlueprintActorByFactory_BP_ReturnValue_IsValid;

	private static FFieldAddress SpawnBlueprintActorByFactory_BP_ReturnValue_PropertyAddress;

	private static int SpawnBlueprintActorByFactory_BP_ReturnValue_Offset;

	private static bool SpawnBlueprintActorByFactory_IsValid;

	private static IntPtr SpawnBlueprintActorByFactory_FunctionAddress;

	private static int SpawnBlueprintActorByFactory_ParamsSize;

	private static bool SpawnBlueprintActorByFactory_InAsset_IsValid;

	private static FFieldAddress SpawnBlueprintActorByFactory_InAsset_PropertyAddress;

	private static int SpawnBlueprintActorByFactory_InAsset_Offset;

	private static bool SpawnBlueprintActorByFactory_InLevel_IsValid;

	private static FFieldAddress SpawnBlueprintActorByFactory_InLevel_PropertyAddress;

	private static int SpawnBlueprintActorByFactory_InLevel_Offset;

	private static bool SpawnBlueprintActorByFactory_InTransform_IsValid;

	private static FFieldAddress SpawnBlueprintActorByFactory_InTransform_PropertyAddress;

	private static int SpawnBlueprintActorByFactory_InTransform_Offset;

	private static bool SpawnBlueprintActorByFactory_ReturnValue_IsValid;

	private static FFieldAddress SpawnBlueprintActorByFactory_ReturnValue_PropertyAddress;

	private static int SpawnBlueprintActorByFactory_ReturnValue_Offset;

	private static bool SetMaterialInterfaceQualityLevel_IsValid;

	private static IntPtr SetMaterialInterfaceQualityLevel_FunctionAddress;

	private static int SetMaterialInterfaceQualityLevel_ParamsSize;

	private static bool SetMaterialInterfaceQualityLevel_Actor_IsValid;

	private static FFieldAddress SetMaterialInterfaceQualityLevel_Actor_PropertyAddress;

	private static int SetMaterialInterfaceQualityLevel_Actor_Offset;

	private static bool SetMaterialInterfaceQualityLevel_Material_IsValid;

	private static FFieldAddress SetMaterialInterfaceQualityLevel_Material_PropertyAddress;

	private static int SetMaterialInterfaceQualityLevel_Material_Offset;

	private static bool SetMaterialInterfaceQualityLevel_QualityLevel_IsValid;

	private static FFieldAddress SetMaterialInterfaceQualityLevel_QualityLevel_PropertyAddress;

	private static int SetMaterialInterfaceQualityLevel_QualityLevel_Offset;

	private static bool SetActorTransformSimple_IsValid;

	private static IntPtr SetActorTransformSimple_FunctionAddress;

	private static int SetActorTransformSimple_ParamsSize;

	private static bool SetActorTransformSimple_Actor_IsValid;

	private static FFieldAddress SetActorTransformSimple_Actor_PropertyAddress;

	private static int SetActorTransformSimple_Actor_Offset;

	private static bool SetActorTransformSimple_Trans_IsValid;

	private static FFieldAddress SetActorTransformSimple_Trans_PropertyAddress;

	private static int SetActorTransformSimple_Trans_Offset;

	private static bool SetActorTransformSimple_bSweep_IsValid;

	private static FFieldAddress SetActorTransformSimple_bSweep_PropertyAddress;

	private static int SetActorTransformSimple_bSweep_Offset;

	private static bool SetActorTransformSimple_iTeleportType_IsValid;

	private static FFieldAddress SetActorTransformSimple_iTeleportType_PropertyAddress;

	private static int SetActorTransformSimple_iTeleportType_Offset;

	private static bool SetActorRotationSimple_IsValid;

	private static IntPtr SetActorRotationSimple_FunctionAddress;

	private static int SetActorRotationSimple_ParamsSize;

	private static bool SetActorRotationSimple_Actor_IsValid;

	private static FFieldAddress SetActorRotationSimple_Actor_PropertyAddress;

	private static int SetActorRotationSimple_Actor_Offset;

	private static bool SetActorRotationSimple_Rot_IsValid;

	private static FFieldAddress SetActorRotationSimple_Rot_PropertyAddress;

	private static int SetActorRotationSimple_Rot_Offset;

	private static bool SetActorRotationSimple_iTeleportType_IsValid;

	private static FFieldAddress SetActorRotationSimple_iTeleportType_PropertyAddress;

	private static int SetActorRotationSimple_iTeleportType_Offset;

	private static bool SetActorLocationSimple_IsValid;

	private static IntPtr SetActorLocationSimple_FunctionAddress;

	private static int SetActorLocationSimple_ParamsSize;

	private static bool SetActorLocationSimple_Actor_IsValid;

	private static FFieldAddress SetActorLocationSimple_Actor_PropertyAddress;

	private static int SetActorLocationSimple_Actor_Offset;

	private static bool SetActorLocationSimple_Pos_IsValid;

	private static FFieldAddress SetActorLocationSimple_Pos_PropertyAddress;

	private static int SetActorLocationSimple_Pos_Offset;

	private static bool SetActorLocationSimple_bSweep_IsValid;

	private static FFieldAddress SetActorLocationSimple_bSweep_PropertyAddress;

	private static int SetActorLocationSimple_bSweep_Offset;

	private static bool SetActorLocationSimple_iTeleportType_IsValid;

	private static FFieldAddress SetActorLocationSimple_iTeleportType_PropertyAddress;

	private static int SetActorLocationSimple_iTeleportType_Offset;

	private static bool SetActorLocationAndRotationSimple_IsValid;

	private static IntPtr SetActorLocationAndRotationSimple_FunctionAddress;

	private static int SetActorLocationAndRotationSimple_ParamsSize;

	private static bool SetActorLocationAndRotationSimple_Actor_IsValid;

	private static FFieldAddress SetActorLocationAndRotationSimple_Actor_PropertyAddress;

	private static int SetActorLocationAndRotationSimple_Actor_Offset;

	private static bool SetActorLocationAndRotationSimple_Pos_IsValid;

	private static FFieldAddress SetActorLocationAndRotationSimple_Pos_PropertyAddress;

	private static int SetActorLocationAndRotationSimple_Pos_Offset;

	private static bool SetActorLocationAndRotationSimple_Rot_IsValid;

	private static FFieldAddress SetActorLocationAndRotationSimple_Rot_PropertyAddress;

	private static int SetActorLocationAndRotationSimple_Rot_Offset;

	private static bool SetActorLocationAndRotationSimple_bSweep_IsValid;

	private static FFieldAddress SetActorLocationAndRotationSimple_bSweep_PropertyAddress;

	private static int SetActorLocationAndRotationSimple_bSweep_Offset;

	private static bool SetActorLocationAndRotationSimple_iTeleportType_IsValid;

	private static FFieldAddress SetActorLocationAndRotationSimple_iTeleportType_PropertyAddress;

	private static int SetActorLocationAndRotationSimple_iTeleportType_Offset;

	private static bool SetActorComponentsTickInterval_IsValid;

	private static IntPtr SetActorComponentsTickInterval_FunctionAddress;

	private static int SetActorComponentsTickInterval_ParamsSize;

	private static bool SetActorComponentsTickInterval_Actor_IsValid;

	private static FFieldAddress SetActorComponentsTickInterval_Actor_PropertyAddress;

	private static int SetActorComponentsTickInterval_Actor_Offset;

	private static bool SetActorComponentsTickInterval_NewInterval_IsValid;

	private static FFieldAddress SetActorComponentsTickInterval_NewInterval_PropertyAddress;

	private static int SetActorComponentsTickInterval_NewInterval_Offset;

	private static bool SetActorComponentsTickEnable_IsValid;

	private static IntPtr SetActorComponentsTickEnable_FunctionAddress;

	private static int SetActorComponentsTickEnable_ParamsSize;

	private static bool SetActorComponentsTickEnable_Actor_IsValid;

	private static FFieldAddress SetActorComponentsTickEnable_Actor_PropertyAddress;

	private static int SetActorComponentsTickEnable_Actor_Offset;

	private static bool SetActorComponentsTickEnable_bEnable_IsValid;

	private static FFieldAddress SetActorComponentsTickEnable_bEnable_PropertyAddress;

	private static int SetActorComponentsTickEnable_bEnable_Offset;

	private static bool RemoveComponent_IsValid;

	private static IntPtr RemoveComponent_FunctionAddress;

	private static int RemoveComponent_ParamsSize;

	private static bool RemoveComponent_Component_IsValid;

	private static FFieldAddress RemoveComponent_Component_PropertyAddress;

	private static int RemoveComponent_Component_Offset;

	private static bool LoadReflectionCubeLocation_IsValid;

	private static IntPtr LoadReflectionCubeLocation_FunctionAddress;

	private static int LoadReflectionCubeLocation_ParamsSize;

	private static bool LoadReflectionCubeLocation_PathPointList_IsValid;

	private static FFieldAddress LoadReflectionCubeLocation_PathPointList_PropertyAddress;

	private static int LoadReflectionCubeLocation_PathPointList_Offset;

	private static bool LoadReflectionCubeLocation_FilePathUnderProjFolder_IsValid;

	private static FFieldAddress LoadReflectionCubeLocation_FilePathUnderProjFolder_PropertyAddress;

	private static int LoadReflectionCubeLocation_FilePathUnderProjFolder_Offset;

	private static bool LoadCapturingStreamingMeshLodStats_IsValid;

	private static IntPtr LoadCapturingStreamingMeshLodStats_FunctionAddress;

	private static int LoadCapturingStreamingMeshLodStats_ParamsSize;

	private static bool IsPointInVolume_IsValid;

	private static IntPtr IsPointInVolume_FunctionAddress;

	private static int IsPointInVolume_ParamsSize;

	private static bool IsPointInVolume_VolumeActor_IsValid;

	private static FFieldAddress IsPointInVolume_VolumeActor_PropertyAddress;

	private static int IsPointInVolume_VolumeActor_Offset;

	private static bool IsPointInVolume_Point_IsValid;

	private static FFieldAddress IsPointInVolume_Point_PropertyAddress;

	private static int IsPointInVolume_Point_Offset;

	private static bool IsPointInVolume_Radius_IsValid;

	private static FFieldAddress IsPointInVolume_Radius_PropertyAddress;

	private static int IsPointInVolume_Radius_Offset;

	private static bool IsPointInVolume_ReturnValue_IsValid;

	private static FFieldAddress IsPointInVolume_ReturnValue_PropertyAddress;

	private static int IsPointInVolume_ReturnValue_Offset;

	private static bool IsActorBeginningPlayFromLevelStreaming_IsValid;

	private static IntPtr IsActorBeginningPlayFromLevelStreaming_FunctionAddress;

	private static int IsActorBeginningPlayFromLevelStreaming_ParamsSize;

	private static bool IsActorBeginningPlayFromLevelStreaming_Actor_IsValid;

	private static FFieldAddress IsActorBeginningPlayFromLevelStreaming_Actor_PropertyAddress;

	private static int IsActorBeginningPlayFromLevelStreaming_Actor_Offset;

	private static bool IsActorBeginningPlayFromLevelStreaming_ReturnValue_IsValid;

	private static FFieldAddress IsActorBeginningPlayFromLevelStreaming_ReturnValue_PropertyAddress;

	private static int IsActorBeginningPlayFromLevelStreaming_ReturnValue_Offset;

	private static bool IsAABoundBoxInVolume_IsValid;

	private static IntPtr IsAABoundBoxInVolume_FunctionAddress;

	private static int IsAABoundBoxInVolume_ParamsSize;

	private static bool IsAABoundBoxInVolume_VolumeActor_IsValid;

	private static FFieldAddress IsAABoundBoxInVolume_VolumeActor_PropertyAddress;

	private static int IsAABoundBoxInVolume_VolumeActor_Offset;

	private static bool IsAABoundBoxInVolume_BoundOrigin_IsValid;

	private static FFieldAddress IsAABoundBoxInVolume_BoundOrigin_PropertyAddress;

	private static int IsAABoundBoxInVolume_BoundOrigin_Offset;

	private static bool IsAABoundBoxInVolume_BoundExtent_IsValid;

	private static FFieldAddress IsAABoundBoxInVolume_BoundExtent_PropertyAddress;

	private static int IsAABoundBoxInVolume_BoundExtent_Offset;

	private static bool IsAABoundBoxInVolume_isFullContain_IsValid;

	private static FFieldAddress IsAABoundBoxInVolume_isFullContain_PropertyAddress;

	private static int IsAABoundBoxInVolume_isFullContain_Offset;

	private static bool IsAABoundBoxInVolume_ReturnValue_IsValid;

	private static FFieldAddress IsAABoundBoxInVolume_ReturnValue_PropertyAddress;

	private static int IsAABoundBoxInVolume_ReturnValue_Offset;

	private static bool GetWorldTransformFast_IsValid;

	private static IntPtr GetWorldTransformFast_FunctionAddress;

	private static int GetWorldTransformFast_ParamsSize;

	private static bool GetWorldTransformFast_SceneComp_IsValid;

	private static FFieldAddress GetWorldTransformFast_SceneComp_PropertyAddress;

	private static int GetWorldTransformFast_SceneComp_Offset;

	private static bool GetWorldTransformFast_OutWorldTransform_IsValid;

	private static FFieldAddress GetWorldTransformFast_OutWorldTransform_PropertyAddress;

	private static int GetWorldTransformFast_OutWorldTransform_Offset;

	private static bool GetVelocity_IsValid;

	private static IntPtr GetVelocity_FunctionAddress;

	private static int GetVelocity_ParamsSize;

	private static bool GetVelocity_Actor_IsValid;

	private static FFieldAddress GetVelocity_Actor_PropertyAddress;

	private static int GetVelocity_Actor_Offset;

	private static bool GetVelocity_OutVelocity_IsValid;

	private static FFieldAddress GetVelocity_OutVelocity_PropertyAddress;

	private static int GetVelocity_OutVelocity_Offset;

	private static bool GetAttachParentActor_IsValid;

	private static IntPtr GetAttachParentActor_FunctionAddress;

	private static int GetAttachParentActor_ParamsSize;

	private static bool GetAttachParentActor_Actor_IsValid;

	private static FFieldAddress GetAttachParentActor_Actor_PropertyAddress;

	private static int GetAttachParentActor_Actor_Offset;

	private static bool GetAttachParentActor_AttachParentActor_IsValid;

	private static FFieldAddress GetAttachParentActor_AttachParentActor_PropertyAddress;

	private static int GetAttachParentActor_AttachParentActor_Offset;

	private static bool GetActorTransformSimple_IsValid;

	private static IntPtr GetActorTransformSimple_FunctionAddress;

	private static int GetActorTransformSimple_ParamsSize;

	private static bool GetActorTransformSimple_Actor_IsValid;

	private static FFieldAddress GetActorTransformSimple_Actor_PropertyAddress;

	private static int GetActorTransformSimple_Actor_Offset;

	private static bool GetActorTransformSimple_OutTrans_IsValid;

	private static FFieldAddress GetActorTransformSimple_OutTrans_PropertyAddress;

	private static int GetActorTransformSimple_OutTrans_Offset;

	private static bool GetActorRotationSimple_IsValid;

	private static IntPtr GetActorRotationSimple_FunctionAddress;

	private static int GetActorRotationSimple_ParamsSize;

	private static bool GetActorRotationSimple_Actor_IsValid;

	private static FFieldAddress GetActorRotationSimple_Actor_PropertyAddress;

	private static int GetActorRotationSimple_Actor_Offset;

	private static bool GetActorRotationSimple_OutRot_IsValid;

	private static FFieldAddress GetActorRotationSimple_OutRot_PropertyAddress;

	private static int GetActorRotationSimple_OutRot_Offset;

	private static bool GetActorLocationSimple_IsValid;

	private static IntPtr GetActorLocationSimple_FunctionAddress;

	private static int GetActorLocationSimple_ParamsSize;

	private static bool GetActorLocationSimple_Actor_IsValid;

	private static FFieldAddress GetActorLocationSimple_Actor_PropertyAddress;

	private static int GetActorLocationSimple_Actor_Offset;

	private static bool GetActorLocationSimple_OutPos_IsValid;

	private static FFieldAddress GetActorLocationSimple_OutPos_PropertyAddress;

	private static int GetActorLocationSimple_OutPos_Offset;

	private static bool GetActorHasAuthority_IsValid;

	private static IntPtr GetActorHasAuthority_FunctionAddress;

	private static int GetActorHasAuthority_ParamsSize;

	private static bool GetActorHasAuthority_Actor_IsValid;

	private static FFieldAddress GetActorHasAuthority_Actor_PropertyAddress;

	private static int GetActorHasAuthority_Actor_Offset;

	private static bool GetActorHasAuthority_OutHasAuthority_IsValid;

	private static FFieldAddress GetActorHasAuthority_OutHasAuthority_PropertyAddress;

	private static int GetActorHasAuthority_OutHasAuthority_Offset;

	private static bool GetActorForwardVector_IsValid;

	private static IntPtr GetActorForwardVector_FunctionAddress;

	private static int GetActorForwardVector_ParamsSize;

	private static bool GetActorForwardVector_Actor_IsValid;

	private static FFieldAddress GetActorForwardVector_Actor_PropertyAddress;

	private static int GetActorForwardVector_Actor_Offset;

	private static bool GetActorForwardVector_OutDir_IsValid;

	private static FFieldAddress GetActorForwardVector_OutDir_PropertyAddress;

	private static int GetActorForwardVector_OutDir_Offset;

	private static bool FinishAddComponent_IsValid;

	private static IntPtr FinishAddComponent_FunctionAddress;

	private static int FinishAddComponent_ParamsSize;

	private static bool FinishAddComponent_Actor_IsValid;

	private static FFieldAddress FinishAddComponent_Actor_PropertyAddress;

	private static int FinishAddComponent_Actor_Offset;

	private static bool FinishAddComponent_NewActorComp_IsValid;

	private static FFieldAddress FinishAddComponent_NewActorComp_PropertyAddress;

	private static int FinishAddComponent_NewActorComp_Offset;

	private static bool FinishAddComponent_bManualAttachment_IsValid;

	private static FFieldAddress FinishAddComponent_bManualAttachment_PropertyAddress;

	private static int FinishAddComponent_bManualAttachment_Offset;

	private static bool FinishAddComponent_RelativeTransform_IsValid;

	private static FFieldAddress FinishAddComponent_RelativeTransform_PropertyAddress;

	private static int FinishAddComponent_RelativeTransform_Offset;

	private static bool ExcuteStreamingMeshMemoryStats_IsValid;

	private static IntPtr ExcuteStreamingMeshMemoryStats_FunctionAddress;

	private static int ExcuteStreamingMeshMemoryStats_ParamsSize;

	private static bool EndCapturingStreamingMeshLodStats_IsValid;

	private static IntPtr EndCapturingStreamingMeshLodStats_FunctionAddress;

	private static int EndCapturingStreamingMeshLodStats_ParamsSize;

	private static bool DetectRegionCenter_IsValid;

	private static IntPtr DetectRegionCenter_FunctionAddress;

	private static int DetectRegionCenter_ParamsSize;

	private static bool DetectRegionCenter_Actor_IsValid;

	private static FFieldAddress DetectRegionCenter_Actor_PropertyAddress;

	private static int DetectRegionCenter_Actor_Offset;

	private static bool DetectRegionCenter_TraceDirectionList_IsValid;

	private static FFieldAddress DetectRegionCenter_TraceDirectionList_PropertyAddress;

	private static int DetectRegionCenter_TraceDirectionList_Offset;

	private static bool DetectRegionCenter_TraceDistance_IsValid;

	private static FFieldAddress DetectRegionCenter_TraceDistance_PropertyAddress;

	private static int DetectRegionCenter_TraceDistance_Offset;

	private static bool DetectRegionCenter_TraceChannel_IsValid;

	private static FFieldAddress DetectRegionCenter_TraceChannel_PropertyAddress;

	private static int DetectRegionCenter_TraceChannel_Offset;

	private static bool DetectRegionCenter_DrawDebugType_IsValid;

	private static FFieldAddress DetectRegionCenter_DrawDebugType_PropertyAddress;

	private static int DetectRegionCenter_DrawDebugType_Offset;

	private static bool DetectRegionCenter_DrawTime_IsValid;

	private static FFieldAddress DetectRegionCenter_DrawTime_PropertyAddress;

	private static int DetectRegionCenter_DrawTime_Offset;

	private static bool DetectRegionCenter_VaildRange_IsValid;

	private static FFieldAddress DetectRegionCenter_VaildRange_PropertyAddress;

	private static int DetectRegionCenter_VaildRange_Offset;

	private static bool DetectRegionCenter_AdjustedLocation_IsValid;

	private static FFieldAddress DetectRegionCenter_AdjustedLocation_PropertyAddress;

	private static int DetectRegionCenter_AdjustedLocation_Offset;

	private static bool DetectRegionCenter_AdjustedRadius_IsValid;

	private static FFieldAddress DetectRegionCenter_AdjustedRadius_PropertyAddress;

	private static int DetectRegionCenter_AdjustedRadius_Offset;

	private static bool DetectRegionCenter_IsSuccess_IsValid;

	private static FFieldAddress DetectRegionCenter_IsSuccess_PropertyAddress;

	private static int DetectRegionCenter_IsSuccess_Offset;

	private static bool CheckActorWasRecentlyRendered_IsValid;

	private static IntPtr CheckActorWasRecentlyRendered_FunctionAddress;

	private static int CheckActorWasRecentlyRendered_ParamsSize;

	private static bool CheckActorWasRecentlyRendered_Actor_IsValid;

	private static FFieldAddress CheckActorWasRecentlyRendered_Actor_PropertyAddress;

	private static int CheckActorWasRecentlyRendered_Actor_Offset;

	private static bool CheckActorWasRecentlyRendered_ReturnValue_IsValid;

	private static FFieldAddress CheckActorWasRecentlyRendered_ReturnValue_PropertyAddress;

	private static int CheckActorWasRecentlyRendered_ReturnValue_Offset;

	private static bool CaptureStreamingMeshLodStats_IsValid;

	private static IntPtr CaptureStreamingMeshLodStats_FunctionAddress;

	private static int CaptureStreamingMeshLodStats_ParamsSize;

	private static bool CacheCapturingStreamingMeshLodStats_IsValid;

	private static IntPtr CacheCapturingStreamingMeshLodStats_FunctionAddress;

	private static int CacheCapturingStreamingMeshLodStats_ParamsSize;

	private static bool AddNamePrefix_IsValid;

	private static IntPtr AddNamePrefix_FunctionAddress;

	private static int AddNamePrefix_ParamsSize;

	private static bool AddNamePrefix_Actor_IsValid;

	private static FFieldAddress AddNamePrefix_Actor_PropertyAddress;

	private static int AddNamePrefix_Actor_Offset;

	private static bool AddNamePrefix_NamePrefix_IsValid;

	private static FFieldAddress AddNamePrefix_NamePrefix_PropertyAddress;

	private static int AddNamePrefix_NamePrefix_Offset;

	private static bool AddInstanceComponent_IsValid;

	private static IntPtr AddInstanceComponent_FunctionAddress;

	private static int AddInstanceComponent_ParamsSize;

	private static bool AddInstanceComponent_Actor_IsValid;

	private static FFieldAddress AddInstanceComponent_Actor_PropertyAddress;

	private static int AddInstanceComponent_Actor_Offset;

	private static bool AddInstanceComponent_Component_IsValid;

	private static FFieldAddress AddInstanceComponent_Component_PropertyAddress;

	private static int AddInstanceComponent_Component_Offset;

	private static bool AddComponentByClass_IsValid;

	private static IntPtr AddComponentByClass_FunctionAddress;

	private static int AddComponentByClass_ParamsSize;

	private static bool AddComponentByClass_Actor_IsValid;

	private static FFieldAddress AddComponentByClass_Actor_PropertyAddress;

	private static int AddComponentByClass_Actor_Offset;

	private static bool AddComponentByClass_Class_IsValid;

	private static FFieldAddress AddComponentByClass_Class_PropertyAddress;

	private static int AddComponentByClass_Class_Offset;

	private static bool AddComponentByClass_bManualAttachment_IsValid;

	private static FFieldAddress AddComponentByClass_bManualAttachment_PropertyAddress;

	private static int AddComponentByClass_bManualAttachment_Offset;

	private static bool AddComponentByClass_RelativeTransform_IsValid;

	private static FFieldAddress AddComponentByClass_RelativeTransform_PropertyAddress;

	private static int AddComponentByClass_RelativeTransform_Offset;

	private static bool AddComponentByClass_bDeferredFinish_IsValid;

	private static FFieldAddress AddComponentByClass_bDeferredFinish_PropertyAddress;

	private static int AddComponentByClass_bDeferredFinish_Offset;

	private static bool AddComponentByClass_ReturnValue_IsValid;

	private static FFieldAddress AddComponentByClass_ReturnValue_PropertyAddress;

	private static int AddComponentByClass_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:UpdateActorOverlaps")]
	public unsafe static void UpdateActorOverlaps(AActor Actor)
	{
		if (!UpdateActorOverlaps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:UpdateActorOverlaps");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateActorOverlaps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateActorOverlaps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, UpdateActorOverlaps_Actor_Offset), 0, UpdateActorOverlaps_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateActorOverlaps_FunctionAddress, intPtr, UpdateActorOverlaps_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:StatLevelNaniteMemory")]
	public unsafe static void StatLevelNaniteMemory(List<ULevel> LoadedLevels, string WorldPositionFile, string MemoryFile)
	{
		if (!StatLevelNaniteMemory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:StatLevelNaniteMemory");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StatLevelNaniteMemory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StatLevelNaniteMemory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<ULevel>(1, StatLevelNaniteMemory_LoadedLevels_PropertyAddress, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.FromNative, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.ToNative).ToNative(IntPtr.Add(intPtr, StatLevelNaniteMemory_LoadedLevels_Offset), LoadedLevels);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StatLevelNaniteMemory_WorldPositionFile_Offset), 0, StatLevelNaniteMemory_WorldPositionFile_PropertyAddress.Address, WorldPositionFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StatLevelNaniteMemory_MemoryFile_Offset), 0, StatLevelNaniteMemory_MemoryFile_PropertyAddress.Address, MemoryFile);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StatLevelNaniteMemory_FunctionAddress, intPtr, StatLevelNaniteMemory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StatLevelNaniteMemory_LoadedLevels_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StatLevelNaniteMemory_WorldPositionFile_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StatLevelNaniteMemory_MemoryFile_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SpawnSphereUniformPoints")]
	public unsafe static void SpawnSphereUniformPoints(out List<FVector> SphereUniformPoints, int NumOfPoints, float Radius)
	{
		if (!SpawnSphereUniformPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SpawnSphereUniformPoints");
			SphereUniformPoints = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnSphereUniformPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnSphereUniformPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SpawnSphereUniformPoints_NumOfPoints_Offset), 0, SpawnSphereUniformPoints_NumOfPoints_PropertyAddress.Address, NumOfPoints);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SpawnSphereUniformPoints_Radius_Offset), 0, SpawnSphereUniformPoints_Radius_PropertyAddress.Address, Radius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnSphereUniformPoints_FunctionAddress, intPtr, SpawnSphereUniformPoints_ParamsSize);
		SphereUniformPoints = new TArrayCopyMarshaler<FVector>(1, SpawnSphereUniformPoints_SphereUniformPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, SpawnSphereUniformPoints_SphereUniformPoints_Offset));
		NativeReflection.DestroyValue_InContainer(SpawnSphereUniformPoints_SphereUniformPoints_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SpawnBlueprintActorByFactory_BP")]
	public unsafe static AActor SpawnBlueprintActorByFactory_BP(UBlueprint InAsset, UObject Obj, FTransform InTransform)
	{
		if (!SpawnBlueprintActorByFactory_BP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SpawnBlueprintActorByFactory_BP");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnBlueprintActorByFactory_BP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnBlueprintActorByFactory_BP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, SpawnBlueprintActorByFactory_BP_InAsset_Offset), 0, SpawnBlueprintActorByFactory_BP_InAsset_PropertyAddress.Address, InAsset);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnBlueprintActorByFactory_BP_Obj_Offset), 0, SpawnBlueprintActorByFactory_BP_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InitializeValue_InContainer(SpawnBlueprintActorByFactory_BP_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SpawnBlueprintActorByFactory_BP_InTransform_Offset), 0, SpawnBlueprintActorByFactory_BP_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnBlueprintActorByFactory_BP_FunctionAddress, intPtr, SpawnBlueprintActorByFactory_BP_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, SpawnBlueprintActorByFactory_BP_ReturnValue_Offset), 0, SpawnBlueprintActorByFactory_BP_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SpawnBlueprintActorByFactory")]
	public unsafe static AActor SpawnBlueprintActorByFactory(UBlueprint InAsset, ULevel InLevel, FTransform InTransform)
	{
		if (!SpawnBlueprintActorByFactory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SpawnBlueprintActorByFactory");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnBlueprintActorByFactory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnBlueprintActorByFactory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, SpawnBlueprintActorByFactory_InAsset_Offset), 0, SpawnBlueprintActorByFactory_InAsset_PropertyAddress.Address, InAsset);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, SpawnBlueprintActorByFactory_InLevel_Offset), 0, SpawnBlueprintActorByFactory_InLevel_PropertyAddress.Address, InLevel);
		NativeReflection.InitializeValue_InContainer(SpawnBlueprintActorByFactory_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SpawnBlueprintActorByFactory_InTransform_Offset), 0, SpawnBlueprintActorByFactory_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnBlueprintActorByFactory_FunctionAddress, intPtr, SpawnBlueprintActorByFactory_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, SpawnBlueprintActorByFactory_ReturnValue_Offset), 0, SpawnBlueprintActorByFactory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SetMaterialInterfaceQualityLevel")]
	public unsafe static void SetMaterialInterfaceQualityLevel(AActor Actor, UMaterialInterface Material, int QualityLevel)
	{
		if (!SetMaterialInterfaceQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SetMaterialInterfaceQualityLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterialInterfaceQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterialInterfaceQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetMaterialInterfaceQualityLevel_Actor_Offset), 0, SetMaterialInterfaceQualityLevel_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterialInterfaceQualityLevel_Material_Offset), 0, SetMaterialInterfaceQualityLevel_Material_PropertyAddress.Address, Material);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMaterialInterfaceQualityLevel_QualityLevel_Offset), 0, SetMaterialInterfaceQualityLevel_QualityLevel_PropertyAddress.Address, QualityLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMaterialInterfaceQualityLevel_FunctionAddress, intPtr, SetMaterialInterfaceQualityLevel_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorTransformSimple")]
	public unsafe static void SetActorTransformSimple(AActor Actor, FTransform Trans, bool bSweep, int iTeleportType)
	{
		if (!SetActorTransformSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorTransformSimple");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorTransformSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorTransformSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorTransformSimple_Actor_Offset), 0, SetActorTransformSimple_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InitializeValue_InContainer(SetActorTransformSimple_Trans_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetActorTransformSimple_Trans_Offset), 0, SetActorTransformSimple_Trans_PropertyAddress.Address, Trans);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorTransformSimple_bSweep_Offset), 0, SetActorTransformSimple_bSweep_PropertyAddress.Address, bSweep);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetActorTransformSimple_iTeleportType_Offset), 0, SetActorTransformSimple_iTeleportType_PropertyAddress.Address, iTeleportType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorTransformSimple_FunctionAddress, intPtr, SetActorTransformSimple_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorRotationSimple")]
	public unsafe static void SetActorRotationSimple(AActor Actor, FRotator Rot, int iTeleportType)
	{
		if (!SetActorRotationSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorRotationSimple");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorRotationSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorRotationSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorRotationSimple_Actor_Offset), 0, SetActorRotationSimple_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetActorRotationSimple_Rot_Offset), 0, SetActorRotationSimple_Rot_PropertyAddress.Address, Rot);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetActorRotationSimple_iTeleportType_Offset), 0, SetActorRotationSimple_iTeleportType_PropertyAddress.Address, iTeleportType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorRotationSimple_FunctionAddress, intPtr, SetActorRotationSimple_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorLocationSimple")]
	public unsafe static void SetActorLocationSimple(AActor Actor, FVector Pos, bool bSweep, int iTeleportType)
	{
		if (!SetActorLocationSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorLocationSimple");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLocationSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLocationSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorLocationSimple_Actor_Offset), 0, SetActorLocationSimple_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetActorLocationSimple_Pos_Offset), 0, SetActorLocationSimple_Pos_PropertyAddress.Address, Pos);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLocationSimple_bSweep_Offset), 0, SetActorLocationSimple_bSweep_PropertyAddress.Address, bSweep);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetActorLocationSimple_iTeleportType_Offset), 0, SetActorLocationSimple_iTeleportType_PropertyAddress.Address, iTeleportType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorLocationSimple_FunctionAddress, intPtr, SetActorLocationSimple_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorLocationAndRotationSimple")]
	public unsafe static void SetActorLocationAndRotationSimple(AActor Actor, FVector Pos, FRotator Rot, bool bSweep, int iTeleportType)
	{
		if (!SetActorLocationAndRotationSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorLocationAndRotationSimple");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLocationAndRotationSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLocationAndRotationSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorLocationAndRotationSimple_Actor_Offset), 0, SetActorLocationAndRotationSimple_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetActorLocationAndRotationSimple_Pos_Offset), 0, SetActorLocationAndRotationSimple_Pos_PropertyAddress.Address, Pos);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetActorLocationAndRotationSimple_Rot_Offset), 0, SetActorLocationAndRotationSimple_Rot_PropertyAddress.Address, Rot);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLocationAndRotationSimple_bSweep_Offset), 0, SetActorLocationAndRotationSimple_bSweep_PropertyAddress.Address, bSweep);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetActorLocationAndRotationSimple_iTeleportType_Offset), 0, SetActorLocationAndRotationSimple_iTeleportType_PropertyAddress.Address, iTeleportType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorLocationAndRotationSimple_FunctionAddress, intPtr, SetActorLocationAndRotationSimple_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorComponentsTickInterval")]
	public unsafe static void SetActorComponentsTickInterval(AActor Actor, float NewInterval)
	{
		if (!SetActorComponentsTickInterval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorComponentsTickInterval");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorComponentsTickInterval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorComponentsTickInterval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorComponentsTickInterval_Actor_Offset), 0, SetActorComponentsTickInterval_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetActorComponentsTickInterval_NewInterval_Offset), 0, SetActorComponentsTickInterval_NewInterval_PropertyAddress.Address, NewInterval);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorComponentsTickInterval_FunctionAddress, intPtr, SetActorComponentsTickInterval_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorComponentsTickEnable")]
	public unsafe static void SetActorComponentsTickEnable(AActor Actor, bool bEnable)
	{
		if (!SetActorComponentsTickEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorComponentsTickEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorComponentsTickEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorComponentsTickEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorComponentsTickEnable_Actor_Offset), 0, SetActorComponentsTickEnable_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorComponentsTickEnable_bEnable_Offset), 0, SetActorComponentsTickEnable_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorComponentsTickEnable_FunctionAddress, intPtr, SetActorComponentsTickEnable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:RemoveComponent")]
	public unsafe static void RemoveComponent(UActorComponent Component)
	{
		if (!RemoveComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:RemoveComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, RemoveComponent_Component_Offset), 0, RemoveComponent_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveComponent_FunctionAddress, intPtr, RemoveComponent_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:LoadReflectionCubeLocation")]
	public unsafe static void LoadReflectionCubeLocation(out List<FVector> PathPointList, string FilePathUnderProjFolder)
	{
		if (!LoadReflectionCubeLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:LoadReflectionCubeLocation");
			PathPointList = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadReflectionCubeLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadReflectionCubeLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadReflectionCubeLocation_FilePathUnderProjFolder_Offset), 0, LoadReflectionCubeLocation_FilePathUnderProjFolder_PropertyAddress.Address, FilePathUnderProjFolder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadReflectionCubeLocation_FunctionAddress, intPtr, LoadReflectionCubeLocation_ParamsSize);
		PathPointList = new TArrayCopyMarshaler<FVector>(1, LoadReflectionCubeLocation_PathPointList_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, LoadReflectionCubeLocation_PathPointList_Offset));
		NativeReflection.DestroyValue_InContainer(LoadReflectionCubeLocation_PathPointList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(LoadReflectionCubeLocation_FilePathUnderProjFolder_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:LoadCapturingStreamingMeshLodStats")]
	public unsafe static void LoadCapturingStreamingMeshLodStats()
	{
		if (!LoadCapturingStreamingMeshLodStats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:LoadCapturingStreamingMeshLodStats");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadCapturingStreamingMeshLodStats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadCapturingStreamingMeshLodStats_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: LoadCapturingStreamingMeshLodStats_FunctionAddress, argsSize: LoadCapturingStreamingMeshLodStats_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:IsPointInVolume")]
	public unsafe static bool IsPointInVolume(AVolume VolumeActor, FVector Point, float Radius = 0f)
	{
		if (!IsPointInVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:IsPointInVolume");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPointInVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPointInVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AVolume>.ToNative(IntPtr.Add(intPtr, IsPointInVolume_VolumeActor_Offset), 0, IsPointInVolume_VolumeActor_PropertyAddress.Address, VolumeActor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsPointInVolume_Point_Offset), 0, IsPointInVolume_Point_PropertyAddress.Address, Point);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IsPointInVolume_Radius_Offset), 0, IsPointInVolume_Radius_PropertyAddress.Address, Radius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPointInVolume_FunctionAddress, intPtr, IsPointInVolume_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPointInVolume_ReturnValue_Offset), 0, IsPointInVolume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:IsActorBeginningPlayFromLevelStreaming")]
	public unsafe static bool IsActorBeginningPlayFromLevelStreaming(AActor Actor)
	{
		if (!IsActorBeginningPlayFromLevelStreaming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:IsActorBeginningPlayFromLevelStreaming");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActorBeginningPlayFromLevelStreaming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActorBeginningPlayFromLevelStreaming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IsActorBeginningPlayFromLevelStreaming_Actor_Offset), 0, IsActorBeginningPlayFromLevelStreaming_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsActorBeginningPlayFromLevelStreaming_FunctionAddress, intPtr, IsActorBeginningPlayFromLevelStreaming_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActorBeginningPlayFromLevelStreaming_ReturnValue_Offset), 0, IsActorBeginningPlayFromLevelStreaming_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:IsAABoundBoxInVolume")]
	public unsafe static bool IsAABoundBoxInVolume(AVolume VolumeActor, FVector BoundOrigin, FVector BoundExtent, out bool isFullContain)
	{
		if (!IsAABoundBoxInVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:IsAABoundBoxInVolume");
			isFullContain = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAABoundBoxInVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAABoundBoxInVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AVolume>.ToNative(IntPtr.Add(intPtr, IsAABoundBoxInVolume_VolumeActor_Offset), 0, IsAABoundBoxInVolume_VolumeActor_PropertyAddress.Address, VolumeActor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsAABoundBoxInVolume_BoundOrigin_Offset), 0, IsAABoundBoxInVolume_BoundOrigin_PropertyAddress.Address, BoundOrigin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsAABoundBoxInVolume_BoundExtent_Offset), 0, IsAABoundBoxInVolume_BoundExtent_PropertyAddress.Address, BoundExtent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAABoundBoxInVolume_FunctionAddress, intPtr, IsAABoundBoxInVolume_ParamsSize);
		isFullContain = BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAABoundBoxInVolume_isFullContain_Offset), 0, IsAABoundBoxInVolume_isFullContain_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAABoundBoxInVolume_ReturnValue_Offset), 0, IsAABoundBoxInVolume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:GetWorldTransformFast")]
	public unsafe static void GetWorldTransformFast(USceneComponent SceneComp, out FTransform OutWorldTransform)
	{
		if (!GetWorldTransformFast_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:GetWorldTransformFast");
			OutWorldTransform = default(FTransform);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldTransformFast_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldTransformFast_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, GetWorldTransformFast_SceneComp_Offset), 0, GetWorldTransformFast_SceneComp_PropertyAddress.Address, SceneComp);
		NativeReflection.InitializeValue_InContainer(GetWorldTransformFast_OutWorldTransform_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWorldTransformFast_FunctionAddress, intPtr, GetWorldTransformFast_ParamsSize);
		OutWorldTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetWorldTransformFast_OutWorldTransform_Offset), 0, GetWorldTransformFast_OutWorldTransform_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:GetVelocity")]
	public unsafe static void GetVelocity(AActor Actor, out FVector OutVelocity)
	{
		if (!GetVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:GetVelocity");
			OutVelocity = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetVelocity_Actor_Offset), 0, GetVelocity_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVelocity_FunctionAddress, intPtr, GetVelocity_ParamsSize);
		OutVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVelocity_OutVelocity_Offset), 0, GetVelocity_OutVelocity_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:GetAttachParentActor")]
	public unsafe static void GetAttachParentActor(AActor Actor, AActor AttachParentActor)
	{
		if (!GetAttachParentActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:GetAttachParentActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttachParentActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttachParentActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetAttachParentActor_Actor_Offset), 0, GetAttachParentActor_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetAttachParentActor_AttachParentActor_Offset), 0, GetAttachParentActor_AttachParentActor_PropertyAddress.Address, AttachParentActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAttachParentActor_FunctionAddress, intPtr, GetAttachParentActor_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorTransformSimple")]
	public unsafe static void GetActorTransformSimple(AActor Actor, out FTransform OutTrans)
	{
		if (!GetActorTransformSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorTransformSimple");
			OutTrans = default(FTransform);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorTransformSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorTransformSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorTransformSimple_Actor_Offset), 0, GetActorTransformSimple_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InitializeValue_InContainer(GetActorTransformSimple_OutTrans_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorTransformSimple_FunctionAddress, intPtr, GetActorTransformSimple_ParamsSize);
		OutTrans = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetActorTransformSimple_OutTrans_Offset), 0, GetActorTransformSimple_OutTrans_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorRotationSimple")]
	public unsafe static void GetActorRotationSimple(AActor Actor, out FRotator OutRot)
	{
		if (!GetActorRotationSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorRotationSimple");
			OutRot = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorRotationSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorRotationSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorRotationSimple_Actor_Offset), 0, GetActorRotationSimple_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorRotationSimple_FunctionAddress, intPtr, GetActorRotationSimple_ParamsSize);
		OutRot = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetActorRotationSimple_OutRot_Offset), 0, GetActorRotationSimple_OutRot_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorLocationSimple")]
	public unsafe static void GetActorLocationSimple(AActor Actor, out FVector OutPos)
	{
		if (!GetActorLocationSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorLocationSimple");
			OutPos = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorLocationSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorLocationSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorLocationSimple_Actor_Offset), 0, GetActorLocationSimple_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorLocationSimple_FunctionAddress, intPtr, GetActorLocationSimple_ParamsSize);
		OutPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorLocationSimple_OutPos_Offset), 0, GetActorLocationSimple_OutPos_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorHasAuthority")]
	public unsafe static void GetActorHasAuthority(AActor Actor, out bool OutHasAuthority)
	{
		if (!GetActorHasAuthority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorHasAuthority");
			OutHasAuthority = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorHasAuthority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorHasAuthority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorHasAuthority_Actor_Offset), 0, GetActorHasAuthority_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorHasAuthority_FunctionAddress, intPtr, GetActorHasAuthority_ParamsSize);
		OutHasAuthority = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorHasAuthority_OutHasAuthority_Offset), 0, GetActorHasAuthority_OutHasAuthority_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorForwardVector")]
	public unsafe static void GetActorForwardVector(AActor Actor, out FVector OutDir)
	{
		if (!GetActorForwardVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorForwardVector");
			OutDir = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorForwardVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorForwardVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorForwardVector_Actor_Offset), 0, GetActorForwardVector_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorForwardVector_FunctionAddress, intPtr, GetActorForwardVector_ParamsSize);
		OutDir = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorForwardVector_OutDir_Offset), 0, GetActorForwardVector_OutDir_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:FinishAddComponent")]
	public unsafe static void FinishAddComponent(AActor Actor, UActorComponent NewActorComp, bool bManualAttachment, FTransform RelativeTransform)
	{
		if (!FinishAddComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:FinishAddComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishAddComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishAddComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, FinishAddComponent_Actor_Offset), 0, FinishAddComponent_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, FinishAddComponent_NewActorComp_Offset), 0, FinishAddComponent_NewActorComp_PropertyAddress.Address, NewActorComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FinishAddComponent_bManualAttachment_Offset), 0, FinishAddComponent_bManualAttachment_PropertyAddress.Address, bManualAttachment);
		NativeReflection.InitializeValue_InContainer(FinishAddComponent_RelativeTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, FinishAddComponent_RelativeTransform_Offset), 0, FinishAddComponent_RelativeTransform_PropertyAddress.Address, RelativeTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FinishAddComponent_FunctionAddress, intPtr, FinishAddComponent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:ExcuteStreamingMeshMemoryStats")]
	public unsafe static void ExcuteStreamingMeshMemoryStats()
	{
		if (!ExcuteStreamingMeshMemoryStats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:ExcuteStreamingMeshMemoryStats");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExcuteStreamingMeshMemoryStats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExcuteStreamingMeshMemoryStats_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ExcuteStreamingMeshMemoryStats_FunctionAddress, argsSize: ExcuteStreamingMeshMemoryStats_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:EndCapturingStreamingMeshLodStats")]
	public unsafe static void EndCapturingStreamingMeshLodStats()
	{
		if (!EndCapturingStreamingMeshLodStats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:EndCapturingStreamingMeshLodStats");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndCapturingStreamingMeshLodStats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndCapturingStreamingMeshLodStats_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: EndCapturingStreamingMeshLodStats_FunctionAddress, argsSize: EndCapturingStreamingMeshLodStats_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:DetectRegionCenter")]
	public unsafe static void DetectRegionCenter(AActor Actor, List<FVector> TraceDirectionList, float TraceDistance, ETraceTypeQuery TraceChannel, EDrawDebugTrace DrawDebugType, float DrawTime, float VaildRange, out FVector AdjustedLocation, out double AdjustedRadius, out bool IsSuccess)
	{
		if (!DetectRegionCenter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:DetectRegionCenter");
			AdjustedLocation = default(FVector);
			AdjustedRadius = 0.0;
			IsSuccess = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetectRegionCenter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetectRegionCenter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, DetectRegionCenter_Actor_Offset), 0, DetectRegionCenter_Actor_PropertyAddress.Address, Actor);
		new TArrayCopyMarshaler<FVector>(1, DetectRegionCenter_TraceDirectionList_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, DetectRegionCenter_TraceDirectionList_Offset), TraceDirectionList);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DetectRegionCenter_TraceDistance_Offset), 0, DetectRegionCenter_TraceDistance_PropertyAddress.Address, TraceDistance);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(intPtr, DetectRegionCenter_TraceChannel_Offset), 0, DetectRegionCenter_TraceChannel_PropertyAddress.Address, TraceChannel);
		EnumMarshaler<EDrawDebugTrace>.ToNative(IntPtr.Add(intPtr, DetectRegionCenter_DrawDebugType_Offset), 0, DetectRegionCenter_DrawDebugType_PropertyAddress.Address, DrawDebugType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DetectRegionCenter_DrawTime_Offset), 0, DetectRegionCenter_DrawTime_PropertyAddress.Address, DrawTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DetectRegionCenter_VaildRange_Offset), 0, DetectRegionCenter_VaildRange_PropertyAddress.Address, VaildRange);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DetectRegionCenter_FunctionAddress, intPtr, DetectRegionCenter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DetectRegionCenter_TraceDirectionList_PropertyAddress.Address, intPtr);
		AdjustedLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, DetectRegionCenter_AdjustedLocation_Offset), 0, DetectRegionCenter_AdjustedLocation_PropertyAddress.Address);
		AdjustedRadius = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, DetectRegionCenter_AdjustedRadius_Offset), 0, DetectRegionCenter_AdjustedRadius_PropertyAddress.Address);
		IsSuccess = BoolMarshaler.FromNative(IntPtr.Add(intPtr, DetectRegionCenter_IsSuccess_Offset), 0, DetectRegionCenter_IsSuccess_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:CheckActorWasRecentlyRendered")]
	public unsafe static bool CheckActorWasRecentlyRendered(AActor Actor)
	{
		if (!CheckActorWasRecentlyRendered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:CheckActorWasRecentlyRendered");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckActorWasRecentlyRendered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckActorWasRecentlyRendered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CheckActorWasRecentlyRendered_Actor_Offset), 0, CheckActorWasRecentlyRendered_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckActorWasRecentlyRendered_FunctionAddress, intPtr, CheckActorWasRecentlyRendered_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckActorWasRecentlyRendered_ReturnValue_Offset), 0, CheckActorWasRecentlyRendered_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:CaptureStreamingMeshLodStats")]
	public unsafe static void CaptureStreamingMeshLodStats()
	{
		if (!CaptureStreamingMeshLodStats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:CaptureStreamingMeshLodStats");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureStreamingMeshLodStats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureStreamingMeshLodStats_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CaptureStreamingMeshLodStats_FunctionAddress, argsSize: CaptureStreamingMeshLodStats_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:CacheCapturingStreamingMeshLodStats")]
	public unsafe static void CacheCapturingStreamingMeshLodStats()
	{
		if (!CacheCapturingStreamingMeshLodStats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:CacheCapturingStreamingMeshLodStats");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CacheCapturingStreamingMeshLodStats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CacheCapturingStreamingMeshLodStats_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CacheCapturingStreamingMeshLodStats_FunctionAddress, argsSize: CacheCapturingStreamingMeshLodStats_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:AddNamePrefix")]
	public unsafe static void AddNamePrefix(AActor Actor, string NamePrefix)
	{
		if (!AddNamePrefix_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:AddNamePrefix");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNamePrefix_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNamePrefix_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddNamePrefix_Actor_Offset), 0, AddNamePrefix_Actor_PropertyAddress.Address, Actor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddNamePrefix_NamePrefix_Offset), 0, AddNamePrefix_NamePrefix_PropertyAddress.Address, NamePrefix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddNamePrefix_FunctionAddress, intPtr, AddNamePrefix_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddNamePrefix_NamePrefix_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:AddInstanceComponent")]
	public unsafe static void AddInstanceComponent(AActor Actor, UActorComponent Component)
	{
		if (!AddInstanceComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:AddInstanceComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInstanceComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInstanceComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddInstanceComponent_Actor_Offset), 0, AddInstanceComponent_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, AddInstanceComponent_Component_Offset), 0, AddInstanceComponent_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddInstanceComponent_FunctionAddress, intPtr, AddInstanceComponent_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ActorFuncLib:AddComponentByClass")]
	public unsafe static UActorComponent AddComponentByClass(AActor Actor, TSubclassOf<UActorComponent> Class, bool bManualAttachment, FTransform RelativeTransform, bool bDeferredFinish)
	{
		if (!AddComponentByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ActorFuncLib:AddComponentByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddComponentByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddComponentByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddComponentByClass_Actor_Offset), 0, AddComponentByClass_Actor_PropertyAddress.Address, Actor);
		TSubclassOfMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, AddComponentByClass_Class_Offset), 0, AddComponentByClass_Class_PropertyAddress.Address, Class);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddComponentByClass_bManualAttachment_Offset), 0, AddComponentByClass_bManualAttachment_PropertyAddress.Address, bManualAttachment);
		NativeReflection.InitializeValue_InContainer(AddComponentByClass_RelativeTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddComponentByClass_RelativeTransform_Offset), 0, AddComponentByClass_RelativeTransform_PropertyAddress.Address, RelativeTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddComponentByClass_bDeferredFinish_Offset), 0, AddComponentByClass_bDeferredFinish_PropertyAddress.Address, bDeferredFinish);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddComponentByClass_FunctionAddress, intPtr, AddComponentByClass_ParamsSize);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, AddComponentByClass_ReturnValue_Offset), 0, AddComponentByClass_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_ActorFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_ActorFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_ActorFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_ActorFuncLib");
		UpdateActorOverlaps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateActorOverlaps");
		UpdateActorOverlaps_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateActorOverlaps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateActorOverlaps_Actor_PropertyAddress, UpdateActorOverlaps_FunctionAddress, "Actor");
		UpdateActorOverlaps_Actor_Offset = NativeReflectionCached.GetPropertyOffset(UpdateActorOverlaps_FunctionAddress, "Actor");
		UpdateActorOverlaps_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateActorOverlaps_FunctionAddress, "Actor", Classes.FObjectProperty);
		UpdateActorOverlaps_IsValid = UpdateActorOverlaps_FunctionAddress != IntPtr.Zero && UpdateActorOverlaps_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:UpdateActorOverlaps", UpdateActorOverlaps_IsValid);
		StatLevelNaniteMemory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StatLevelNaniteMemory");
		StatLevelNaniteMemory_ParamsSize = NativeReflection.GetFunctionParamsSize(StatLevelNaniteMemory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StatLevelNaniteMemory_LoadedLevels_PropertyAddress, StatLevelNaniteMemory_FunctionAddress, "LoadedLevels");
		StatLevelNaniteMemory_LoadedLevels_Offset = NativeReflectionCached.GetPropertyOffset(StatLevelNaniteMemory_FunctionAddress, "LoadedLevels");
		StatLevelNaniteMemory_LoadedLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(StatLevelNaniteMemory_FunctionAddress, "LoadedLevels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref StatLevelNaniteMemory_WorldPositionFile_PropertyAddress, StatLevelNaniteMemory_FunctionAddress, "WorldPositionFile");
		StatLevelNaniteMemory_WorldPositionFile_Offset = NativeReflectionCached.GetPropertyOffset(StatLevelNaniteMemory_FunctionAddress, "WorldPositionFile");
		StatLevelNaniteMemory_WorldPositionFile_IsValid = NativeReflectionCached.ValidatePropertyClass(StatLevelNaniteMemory_FunctionAddress, "WorldPositionFile", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StatLevelNaniteMemory_MemoryFile_PropertyAddress, StatLevelNaniteMemory_FunctionAddress, "MemoryFile");
		StatLevelNaniteMemory_MemoryFile_Offset = NativeReflectionCached.GetPropertyOffset(StatLevelNaniteMemory_FunctionAddress, "MemoryFile");
		StatLevelNaniteMemory_MemoryFile_IsValid = NativeReflectionCached.ValidatePropertyClass(StatLevelNaniteMemory_FunctionAddress, "MemoryFile", Classes.FStrProperty);
		StatLevelNaniteMemory_IsValid = StatLevelNaniteMemory_FunctionAddress != IntPtr.Zero && StatLevelNaniteMemory_LoadedLevels_IsValid && StatLevelNaniteMemory_WorldPositionFile_IsValid && StatLevelNaniteMemory_MemoryFile_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:StatLevelNaniteMemory", StatLevelNaniteMemory_IsValid);
		SpawnSphereUniformPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnSphereUniformPoints");
		SpawnSphereUniformPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnSphereUniformPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnSphereUniformPoints_SphereUniformPoints_PropertyAddress, SpawnSphereUniformPoints_FunctionAddress, "SphereUniformPoints");
		SpawnSphereUniformPoints_SphereUniformPoints_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSphereUniformPoints_FunctionAddress, "SphereUniformPoints");
		SpawnSphereUniformPoints_SphereUniformPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSphereUniformPoints_FunctionAddress, "SphereUniformPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSphereUniformPoints_NumOfPoints_PropertyAddress, SpawnSphereUniformPoints_FunctionAddress, "NumOfPoints");
		SpawnSphereUniformPoints_NumOfPoints_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSphereUniformPoints_FunctionAddress, "NumOfPoints");
		SpawnSphereUniformPoints_NumOfPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSphereUniformPoints_FunctionAddress, "NumOfPoints", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSphereUniformPoints_Radius_PropertyAddress, SpawnSphereUniformPoints_FunctionAddress, "Radius");
		SpawnSphereUniformPoints_Radius_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSphereUniformPoints_FunctionAddress, "Radius");
		SpawnSphereUniformPoints_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSphereUniformPoints_FunctionAddress, "Radius", Classes.FFloatProperty);
		SpawnSphereUniformPoints_IsValid = SpawnSphereUniformPoints_FunctionAddress != IntPtr.Zero && SpawnSphereUniformPoints_SphereUniformPoints_IsValid && SpawnSphereUniformPoints_NumOfPoints_IsValid && SpawnSphereUniformPoints_Radius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SpawnSphereUniformPoints", SpawnSphereUniformPoints_IsValid);
		SpawnBlueprintActorByFactory_BP_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnBlueprintActorByFactory_BP");
		SpawnBlueprintActorByFactory_BP_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnBlueprintActorByFactory_BP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnBlueprintActorByFactory_BP_InAsset_PropertyAddress, SpawnBlueprintActorByFactory_BP_FunctionAddress, "InAsset");
		SpawnBlueprintActorByFactory_BP_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(SpawnBlueprintActorByFactory_BP_FunctionAddress, "InAsset");
		SpawnBlueprintActorByFactory_BP_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnBlueprintActorByFactory_BP_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnBlueprintActorByFactory_BP_Obj_PropertyAddress, SpawnBlueprintActorByFactory_BP_FunctionAddress, "Obj");
		SpawnBlueprintActorByFactory_BP_Obj_Offset = NativeReflectionCached.GetPropertyOffset(SpawnBlueprintActorByFactory_BP_FunctionAddress, "Obj");
		SpawnBlueprintActorByFactory_BP_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnBlueprintActorByFactory_BP_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnBlueprintActorByFactory_BP_InTransform_PropertyAddress, SpawnBlueprintActorByFactory_BP_FunctionAddress, "InTransform");
		SpawnBlueprintActorByFactory_BP_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SpawnBlueprintActorByFactory_BP_FunctionAddress, "InTransform");
		SpawnBlueprintActorByFactory_BP_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnBlueprintActorByFactory_BP_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnBlueprintActorByFactory_BP_ReturnValue_PropertyAddress, SpawnBlueprintActorByFactory_BP_FunctionAddress, "ReturnValue");
		SpawnBlueprintActorByFactory_BP_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnBlueprintActorByFactory_BP_FunctionAddress, "ReturnValue");
		SpawnBlueprintActorByFactory_BP_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnBlueprintActorByFactory_BP_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnBlueprintActorByFactory_BP_IsValid = SpawnBlueprintActorByFactory_BP_FunctionAddress != IntPtr.Zero && SpawnBlueprintActorByFactory_BP_InAsset_IsValid && SpawnBlueprintActorByFactory_BP_Obj_IsValid && SpawnBlueprintActorByFactory_BP_InTransform_IsValid && SpawnBlueprintActorByFactory_BP_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SpawnBlueprintActorByFactory_BP", SpawnBlueprintActorByFactory_BP_IsValid);
		SpawnBlueprintActorByFactory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnBlueprintActorByFactory");
		SpawnBlueprintActorByFactory_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnBlueprintActorByFactory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnBlueprintActorByFactory_InAsset_PropertyAddress, SpawnBlueprintActorByFactory_FunctionAddress, "InAsset");
		SpawnBlueprintActorByFactory_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(SpawnBlueprintActorByFactory_FunctionAddress, "InAsset");
		SpawnBlueprintActorByFactory_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnBlueprintActorByFactory_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnBlueprintActorByFactory_InLevel_PropertyAddress, SpawnBlueprintActorByFactory_FunctionAddress, "InLevel");
		SpawnBlueprintActorByFactory_InLevel_Offset = NativeReflectionCached.GetPropertyOffset(SpawnBlueprintActorByFactory_FunctionAddress, "InLevel");
		SpawnBlueprintActorByFactory_InLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnBlueprintActorByFactory_FunctionAddress, "InLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnBlueprintActorByFactory_InTransform_PropertyAddress, SpawnBlueprintActorByFactory_FunctionAddress, "InTransform");
		SpawnBlueprintActorByFactory_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SpawnBlueprintActorByFactory_FunctionAddress, "InTransform");
		SpawnBlueprintActorByFactory_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnBlueprintActorByFactory_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnBlueprintActorByFactory_ReturnValue_PropertyAddress, SpawnBlueprintActorByFactory_FunctionAddress, "ReturnValue");
		SpawnBlueprintActorByFactory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnBlueprintActorByFactory_FunctionAddress, "ReturnValue");
		SpawnBlueprintActorByFactory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnBlueprintActorByFactory_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnBlueprintActorByFactory_IsValid = SpawnBlueprintActorByFactory_FunctionAddress != IntPtr.Zero && SpawnBlueprintActorByFactory_InAsset_IsValid && SpawnBlueprintActorByFactory_InLevel_IsValid && SpawnBlueprintActorByFactory_InTransform_IsValid && SpawnBlueprintActorByFactory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SpawnBlueprintActorByFactory", SpawnBlueprintActorByFactory_IsValid);
		SetMaterialInterfaceQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMaterialInterfaceQualityLevel");
		SetMaterialInterfaceQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterialInterfaceQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialInterfaceQualityLevel_Actor_PropertyAddress, SetMaterialInterfaceQualityLevel_FunctionAddress, "Actor");
		SetMaterialInterfaceQualityLevel_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialInterfaceQualityLevel_FunctionAddress, "Actor");
		SetMaterialInterfaceQualityLevel_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialInterfaceQualityLevel_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialInterfaceQualityLevel_Material_PropertyAddress, SetMaterialInterfaceQualityLevel_FunctionAddress, "Material");
		SetMaterialInterfaceQualityLevel_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialInterfaceQualityLevel_FunctionAddress, "Material");
		SetMaterialInterfaceQualityLevel_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialInterfaceQualityLevel_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialInterfaceQualityLevel_QualityLevel_PropertyAddress, SetMaterialInterfaceQualityLevel_FunctionAddress, "QualityLevel");
		SetMaterialInterfaceQualityLevel_QualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialInterfaceQualityLevel_FunctionAddress, "QualityLevel");
		SetMaterialInterfaceQualityLevel_QualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialInterfaceQualityLevel_FunctionAddress, "QualityLevel", Classes.FIntProperty);
		SetMaterialInterfaceQualityLevel_IsValid = SetMaterialInterfaceQualityLevel_FunctionAddress != IntPtr.Zero && SetMaterialInterfaceQualityLevel_Actor_IsValid && SetMaterialInterfaceQualityLevel_Material_IsValid && SetMaterialInterfaceQualityLevel_QualityLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SetMaterialInterfaceQualityLevel", SetMaterialInterfaceQualityLevel_IsValid);
		SetActorTransformSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorTransformSimple");
		SetActorTransformSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorTransformSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransformSimple_Actor_PropertyAddress, SetActorTransformSimple_FunctionAddress, "Actor");
		SetActorTransformSimple_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransformSimple_FunctionAddress, "Actor");
		SetActorTransformSimple_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransformSimple_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransformSimple_Trans_PropertyAddress, SetActorTransformSimple_FunctionAddress, "Trans");
		SetActorTransformSimple_Trans_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransformSimple_FunctionAddress, "Trans");
		SetActorTransformSimple_Trans_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransformSimple_FunctionAddress, "Trans", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransformSimple_bSweep_PropertyAddress, SetActorTransformSimple_FunctionAddress, "bSweep");
		SetActorTransformSimple_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransformSimple_FunctionAddress, "bSweep");
		SetActorTransformSimple_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransformSimple_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransformSimple_iTeleportType_PropertyAddress, SetActorTransformSimple_FunctionAddress, "iTeleportType");
		SetActorTransformSimple_iTeleportType_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransformSimple_FunctionAddress, "iTeleportType");
		SetActorTransformSimple_iTeleportType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransformSimple_FunctionAddress, "iTeleportType", Classes.FIntProperty);
		SetActorTransformSimple_IsValid = SetActorTransformSimple_FunctionAddress != IntPtr.Zero && SetActorTransformSimple_Actor_IsValid && SetActorTransformSimple_Trans_IsValid && SetActorTransformSimple_bSweep_IsValid && SetActorTransformSimple_iTeleportType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorTransformSimple", SetActorTransformSimple_IsValid);
		SetActorRotationSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorRotationSimple");
		SetActorRotationSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorRotationSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorRotationSimple_Actor_PropertyAddress, SetActorRotationSimple_FunctionAddress, "Actor");
		SetActorRotationSimple_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRotationSimple_FunctionAddress, "Actor");
		SetActorRotationSimple_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRotationSimple_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRotationSimple_Rot_PropertyAddress, SetActorRotationSimple_FunctionAddress, "Rot");
		SetActorRotationSimple_Rot_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRotationSimple_FunctionAddress, "Rot");
		SetActorRotationSimple_Rot_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRotationSimple_FunctionAddress, "Rot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRotationSimple_iTeleportType_PropertyAddress, SetActorRotationSimple_FunctionAddress, "iTeleportType");
		SetActorRotationSimple_iTeleportType_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRotationSimple_FunctionAddress, "iTeleportType");
		SetActorRotationSimple_iTeleportType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRotationSimple_FunctionAddress, "iTeleportType", Classes.FIntProperty);
		SetActorRotationSimple_IsValid = SetActorRotationSimple_FunctionAddress != IntPtr.Zero && SetActorRotationSimple_Actor_IsValid && SetActorRotationSimple_Rot_IsValid && SetActorRotationSimple_iTeleportType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorRotationSimple", SetActorRotationSimple_IsValid);
		SetActorLocationSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorLocationSimple");
		SetActorLocationSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLocationSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationSimple_Actor_PropertyAddress, SetActorLocationSimple_FunctionAddress, "Actor");
		SetActorLocationSimple_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationSimple_FunctionAddress, "Actor");
		SetActorLocationSimple_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationSimple_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationSimple_Pos_PropertyAddress, SetActorLocationSimple_FunctionAddress, "Pos");
		SetActorLocationSimple_Pos_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationSimple_FunctionAddress, "Pos");
		SetActorLocationSimple_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationSimple_FunctionAddress, "Pos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationSimple_bSweep_PropertyAddress, SetActorLocationSimple_FunctionAddress, "bSweep");
		SetActorLocationSimple_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationSimple_FunctionAddress, "bSweep");
		SetActorLocationSimple_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationSimple_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationSimple_iTeleportType_PropertyAddress, SetActorLocationSimple_FunctionAddress, "iTeleportType");
		SetActorLocationSimple_iTeleportType_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationSimple_FunctionAddress, "iTeleportType");
		SetActorLocationSimple_iTeleportType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationSimple_FunctionAddress, "iTeleportType", Classes.FIntProperty);
		SetActorLocationSimple_IsValid = SetActorLocationSimple_FunctionAddress != IntPtr.Zero && SetActorLocationSimple_Actor_IsValid && SetActorLocationSimple_Pos_IsValid && SetActorLocationSimple_bSweep_IsValid && SetActorLocationSimple_iTeleportType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorLocationSimple", SetActorLocationSimple_IsValid);
		SetActorLocationAndRotationSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorLocationAndRotationSimple");
		SetActorLocationAndRotationSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLocationAndRotationSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotationSimple_Actor_PropertyAddress, SetActorLocationAndRotationSimple_FunctionAddress, "Actor");
		SetActorLocationAndRotationSimple_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotationSimple_FunctionAddress, "Actor");
		SetActorLocationAndRotationSimple_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotationSimple_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotationSimple_Pos_PropertyAddress, SetActorLocationAndRotationSimple_FunctionAddress, "Pos");
		SetActorLocationAndRotationSimple_Pos_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotationSimple_FunctionAddress, "Pos");
		SetActorLocationAndRotationSimple_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotationSimple_FunctionAddress, "Pos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotationSimple_Rot_PropertyAddress, SetActorLocationAndRotationSimple_FunctionAddress, "Rot");
		SetActorLocationAndRotationSimple_Rot_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotationSimple_FunctionAddress, "Rot");
		SetActorLocationAndRotationSimple_Rot_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotationSimple_FunctionAddress, "Rot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotationSimple_bSweep_PropertyAddress, SetActorLocationAndRotationSimple_FunctionAddress, "bSweep");
		SetActorLocationAndRotationSimple_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotationSimple_FunctionAddress, "bSweep");
		SetActorLocationAndRotationSimple_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotationSimple_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotationSimple_iTeleportType_PropertyAddress, SetActorLocationAndRotationSimple_FunctionAddress, "iTeleportType");
		SetActorLocationAndRotationSimple_iTeleportType_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotationSimple_FunctionAddress, "iTeleportType");
		SetActorLocationAndRotationSimple_iTeleportType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotationSimple_FunctionAddress, "iTeleportType", Classes.FIntProperty);
		SetActorLocationAndRotationSimple_IsValid = SetActorLocationAndRotationSimple_FunctionAddress != IntPtr.Zero && SetActorLocationAndRotationSimple_Actor_IsValid && SetActorLocationAndRotationSimple_Pos_IsValid && SetActorLocationAndRotationSimple_Rot_IsValid && SetActorLocationAndRotationSimple_bSweep_IsValid && SetActorLocationAndRotationSimple_iTeleportType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorLocationAndRotationSimple", SetActorLocationAndRotationSimple_IsValid);
		SetActorComponentsTickInterval_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorComponentsTickInterval");
		SetActorComponentsTickInterval_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorComponentsTickInterval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorComponentsTickInterval_Actor_PropertyAddress, SetActorComponentsTickInterval_FunctionAddress, "Actor");
		SetActorComponentsTickInterval_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorComponentsTickInterval_FunctionAddress, "Actor");
		SetActorComponentsTickInterval_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorComponentsTickInterval_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorComponentsTickInterval_NewInterval_PropertyAddress, SetActorComponentsTickInterval_FunctionAddress, "NewInterval");
		SetActorComponentsTickInterval_NewInterval_Offset = NativeReflectionCached.GetPropertyOffset(SetActorComponentsTickInterval_FunctionAddress, "NewInterval");
		SetActorComponentsTickInterval_NewInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorComponentsTickInterval_FunctionAddress, "NewInterval", Classes.FFloatProperty);
		SetActorComponentsTickInterval_IsValid = SetActorComponentsTickInterval_FunctionAddress != IntPtr.Zero && SetActorComponentsTickInterval_Actor_IsValid && SetActorComponentsTickInterval_NewInterval_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorComponentsTickInterval", SetActorComponentsTickInterval_IsValid);
		SetActorComponentsTickEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorComponentsTickEnable");
		SetActorComponentsTickEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorComponentsTickEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorComponentsTickEnable_Actor_PropertyAddress, SetActorComponentsTickEnable_FunctionAddress, "Actor");
		SetActorComponentsTickEnable_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorComponentsTickEnable_FunctionAddress, "Actor");
		SetActorComponentsTickEnable_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorComponentsTickEnable_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorComponentsTickEnable_bEnable_PropertyAddress, SetActorComponentsTickEnable_FunctionAddress, "bEnable");
		SetActorComponentsTickEnable_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetActorComponentsTickEnable_FunctionAddress, "bEnable");
		SetActorComponentsTickEnable_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorComponentsTickEnable_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetActorComponentsTickEnable_IsValid = SetActorComponentsTickEnable_FunctionAddress != IntPtr.Zero && SetActorComponentsTickEnable_Actor_IsValid && SetActorComponentsTickEnable_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:SetActorComponentsTickEnable", SetActorComponentsTickEnable_IsValid);
		RemoveComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveComponent");
		RemoveComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveComponent_Component_PropertyAddress, RemoveComponent_FunctionAddress, "Component");
		RemoveComponent_Component_Offset = NativeReflectionCached.GetPropertyOffset(RemoveComponent_FunctionAddress, "Component");
		RemoveComponent_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveComponent_FunctionAddress, "Component", Classes.FObjectProperty);
		RemoveComponent_IsValid = RemoveComponent_FunctionAddress != IntPtr.Zero && RemoveComponent_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:RemoveComponent", RemoveComponent_IsValid);
		LoadReflectionCubeLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadReflectionCubeLocation");
		LoadReflectionCubeLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadReflectionCubeLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadReflectionCubeLocation_PathPointList_PropertyAddress, LoadReflectionCubeLocation_FunctionAddress, "PathPointList");
		LoadReflectionCubeLocation_PathPointList_Offset = NativeReflectionCached.GetPropertyOffset(LoadReflectionCubeLocation_FunctionAddress, "PathPointList");
		LoadReflectionCubeLocation_PathPointList_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadReflectionCubeLocation_FunctionAddress, "PathPointList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadReflectionCubeLocation_FilePathUnderProjFolder_PropertyAddress, LoadReflectionCubeLocation_FunctionAddress, "FilePathUnderProjFolder");
		LoadReflectionCubeLocation_FilePathUnderProjFolder_Offset = NativeReflectionCached.GetPropertyOffset(LoadReflectionCubeLocation_FunctionAddress, "FilePathUnderProjFolder");
		LoadReflectionCubeLocation_FilePathUnderProjFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadReflectionCubeLocation_FunctionAddress, "FilePathUnderProjFolder", Classes.FStrProperty);
		LoadReflectionCubeLocation_IsValid = LoadReflectionCubeLocation_FunctionAddress != IntPtr.Zero && LoadReflectionCubeLocation_PathPointList_IsValid && LoadReflectionCubeLocation_FilePathUnderProjFolder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:LoadReflectionCubeLocation", LoadReflectionCubeLocation_IsValid);
		LoadCapturingStreamingMeshLodStats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadCapturingStreamingMeshLodStats");
		LoadCapturingStreamingMeshLodStats_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadCapturingStreamingMeshLodStats_FunctionAddress);
		LoadCapturingStreamingMeshLodStats_IsValid = LoadCapturingStreamingMeshLodStats_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:LoadCapturingStreamingMeshLodStats", LoadCapturingStreamingMeshLodStats_IsValid);
		IsPointInVolume_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPointInVolume");
		IsPointInVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPointInVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPointInVolume_VolumeActor_PropertyAddress, IsPointInVolume_FunctionAddress, "VolumeActor");
		IsPointInVolume_VolumeActor_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInVolume_FunctionAddress, "VolumeActor");
		IsPointInVolume_VolumeActor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInVolume_FunctionAddress, "VolumeActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInVolume_Point_PropertyAddress, IsPointInVolume_FunctionAddress, "Point");
		IsPointInVolume_Point_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInVolume_FunctionAddress, "Point");
		IsPointInVolume_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInVolume_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInVolume_Radius_PropertyAddress, IsPointInVolume_FunctionAddress, "Radius");
		IsPointInVolume_Radius_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInVolume_FunctionAddress, "Radius");
		IsPointInVolume_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInVolume_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInVolume_ReturnValue_PropertyAddress, IsPointInVolume_FunctionAddress, "ReturnValue");
		IsPointInVolume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInVolume_FunctionAddress, "ReturnValue");
		IsPointInVolume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInVolume_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPointInVolume_IsValid = IsPointInVolume_FunctionAddress != IntPtr.Zero && IsPointInVolume_VolumeActor_IsValid && IsPointInVolume_Point_IsValid && IsPointInVolume_Radius_IsValid && IsPointInVolume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:IsPointInVolume", IsPointInVolume_IsValid);
		IsActorBeginningPlayFromLevelStreaming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsActorBeginningPlayFromLevelStreaming");
		IsActorBeginningPlayFromLevelStreaming_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActorBeginningPlayFromLevelStreaming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActorBeginningPlayFromLevelStreaming_Actor_PropertyAddress, IsActorBeginningPlayFromLevelStreaming_FunctionAddress, "Actor");
		IsActorBeginningPlayFromLevelStreaming_Actor_Offset = NativeReflectionCached.GetPropertyOffset(IsActorBeginningPlayFromLevelStreaming_FunctionAddress, "Actor");
		IsActorBeginningPlayFromLevelStreaming_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorBeginningPlayFromLevelStreaming_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActorBeginningPlayFromLevelStreaming_ReturnValue_PropertyAddress, IsActorBeginningPlayFromLevelStreaming_FunctionAddress, "ReturnValue");
		IsActorBeginningPlayFromLevelStreaming_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActorBeginningPlayFromLevelStreaming_FunctionAddress, "ReturnValue");
		IsActorBeginningPlayFromLevelStreaming_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorBeginningPlayFromLevelStreaming_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActorBeginningPlayFromLevelStreaming_IsValid = IsActorBeginningPlayFromLevelStreaming_FunctionAddress != IntPtr.Zero && IsActorBeginningPlayFromLevelStreaming_Actor_IsValid && IsActorBeginningPlayFromLevelStreaming_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:IsActorBeginningPlayFromLevelStreaming", IsActorBeginningPlayFromLevelStreaming_IsValid);
		IsAABoundBoxInVolume_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAABoundBoxInVolume");
		IsAABoundBoxInVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAABoundBoxInVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAABoundBoxInVolume_VolumeActor_PropertyAddress, IsAABoundBoxInVolume_FunctionAddress, "VolumeActor");
		IsAABoundBoxInVolume_VolumeActor_Offset = NativeReflectionCached.GetPropertyOffset(IsAABoundBoxInVolume_FunctionAddress, "VolumeActor");
		IsAABoundBoxInVolume_VolumeActor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAABoundBoxInVolume_FunctionAddress, "VolumeActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAABoundBoxInVolume_BoundOrigin_PropertyAddress, IsAABoundBoxInVolume_FunctionAddress, "BoundOrigin");
		IsAABoundBoxInVolume_BoundOrigin_Offset = NativeReflectionCached.GetPropertyOffset(IsAABoundBoxInVolume_FunctionAddress, "BoundOrigin");
		IsAABoundBoxInVolume_BoundOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAABoundBoxInVolume_FunctionAddress, "BoundOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAABoundBoxInVolume_BoundExtent_PropertyAddress, IsAABoundBoxInVolume_FunctionAddress, "BoundExtent");
		IsAABoundBoxInVolume_BoundExtent_Offset = NativeReflectionCached.GetPropertyOffset(IsAABoundBoxInVolume_FunctionAddress, "BoundExtent");
		IsAABoundBoxInVolume_BoundExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAABoundBoxInVolume_FunctionAddress, "BoundExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAABoundBoxInVolume_isFullContain_PropertyAddress, IsAABoundBoxInVolume_FunctionAddress, "isFullContain");
		IsAABoundBoxInVolume_isFullContain_Offset = NativeReflectionCached.GetPropertyOffset(IsAABoundBoxInVolume_FunctionAddress, "isFullContain");
		IsAABoundBoxInVolume_isFullContain_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAABoundBoxInVolume_FunctionAddress, "isFullContain", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAABoundBoxInVolume_ReturnValue_PropertyAddress, IsAABoundBoxInVolume_FunctionAddress, "ReturnValue");
		IsAABoundBoxInVolume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAABoundBoxInVolume_FunctionAddress, "ReturnValue");
		IsAABoundBoxInVolume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAABoundBoxInVolume_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAABoundBoxInVolume_IsValid = IsAABoundBoxInVolume_FunctionAddress != IntPtr.Zero && IsAABoundBoxInVolume_VolumeActor_IsValid && IsAABoundBoxInVolume_BoundOrigin_IsValid && IsAABoundBoxInVolume_BoundExtent_IsValid && IsAABoundBoxInVolume_isFullContain_IsValid && IsAABoundBoxInVolume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:IsAABoundBoxInVolume", IsAABoundBoxInVolume_IsValid);
		GetWorldTransformFast_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWorldTransformFast");
		GetWorldTransformFast_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldTransformFast_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldTransformFast_SceneComp_PropertyAddress, GetWorldTransformFast_FunctionAddress, "SceneComp");
		GetWorldTransformFast_SceneComp_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldTransformFast_FunctionAddress, "SceneComp");
		GetWorldTransformFast_SceneComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldTransformFast_FunctionAddress, "SceneComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorldTransformFast_OutWorldTransform_PropertyAddress, GetWorldTransformFast_FunctionAddress, "OutWorldTransform");
		GetWorldTransformFast_OutWorldTransform_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldTransformFast_FunctionAddress, "OutWorldTransform");
		GetWorldTransformFast_OutWorldTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldTransformFast_FunctionAddress, "OutWorldTransform", Classes.FStructProperty);
		GetWorldTransformFast_IsValid = GetWorldTransformFast_FunctionAddress != IntPtr.Zero && GetWorldTransformFast_SceneComp_IsValid && GetWorldTransformFast_OutWorldTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:GetWorldTransformFast", GetWorldTransformFast_IsValid);
		GetVelocity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVelocity");
		GetVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVelocity_Actor_PropertyAddress, GetVelocity_FunctionAddress, "Actor");
		GetVelocity_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetVelocity_FunctionAddress, "Actor");
		GetVelocity_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVelocity_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVelocity_OutVelocity_PropertyAddress, GetVelocity_FunctionAddress, "OutVelocity");
		GetVelocity_OutVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetVelocity_FunctionAddress, "OutVelocity");
		GetVelocity_OutVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVelocity_FunctionAddress, "OutVelocity", Classes.FStructProperty);
		GetVelocity_IsValid = GetVelocity_FunctionAddress != IntPtr.Zero && GetVelocity_Actor_IsValid && GetVelocity_OutVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:GetVelocity", GetVelocity_IsValid);
		GetAttachParentActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAttachParentActor");
		GetAttachParentActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttachParentActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttachParentActor_Actor_PropertyAddress, GetAttachParentActor_FunctionAddress, "Actor");
		GetAttachParentActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachParentActor_FunctionAddress, "Actor");
		GetAttachParentActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachParentActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttachParentActor_AttachParentActor_PropertyAddress, GetAttachParentActor_FunctionAddress, "AttachParentActor");
		GetAttachParentActor_AttachParentActor_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachParentActor_FunctionAddress, "AttachParentActor");
		GetAttachParentActor_AttachParentActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachParentActor_FunctionAddress, "AttachParentActor", Classes.FObjectProperty);
		GetAttachParentActor_IsValid = GetAttachParentActor_FunctionAddress != IntPtr.Zero && GetAttachParentActor_Actor_IsValid && GetAttachParentActor_AttachParentActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:GetAttachParentActor", GetAttachParentActor_IsValid);
		GetActorTransformSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorTransformSimple");
		GetActorTransformSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorTransformSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorTransformSimple_Actor_PropertyAddress, GetActorTransformSimple_FunctionAddress, "Actor");
		GetActorTransformSimple_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorTransformSimple_FunctionAddress, "Actor");
		GetActorTransformSimple_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorTransformSimple_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorTransformSimple_OutTrans_PropertyAddress, GetActorTransformSimple_FunctionAddress, "OutTrans");
		GetActorTransformSimple_OutTrans_Offset = NativeReflectionCached.GetPropertyOffset(GetActorTransformSimple_FunctionAddress, "OutTrans");
		GetActorTransformSimple_OutTrans_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorTransformSimple_FunctionAddress, "OutTrans", Classes.FStructProperty);
		GetActorTransformSimple_IsValid = GetActorTransformSimple_FunctionAddress != IntPtr.Zero && GetActorTransformSimple_Actor_IsValid && GetActorTransformSimple_OutTrans_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorTransformSimple", GetActorTransformSimple_IsValid);
		GetActorRotationSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorRotationSimple");
		GetActorRotationSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorRotationSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorRotationSimple_Actor_PropertyAddress, GetActorRotationSimple_FunctionAddress, "Actor");
		GetActorRotationSimple_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorRotationSimple_FunctionAddress, "Actor");
		GetActorRotationSimple_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorRotationSimple_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorRotationSimple_OutRot_PropertyAddress, GetActorRotationSimple_FunctionAddress, "OutRot");
		GetActorRotationSimple_OutRot_Offset = NativeReflectionCached.GetPropertyOffset(GetActorRotationSimple_FunctionAddress, "OutRot");
		GetActorRotationSimple_OutRot_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorRotationSimple_FunctionAddress, "OutRot", Classes.FStructProperty);
		GetActorRotationSimple_IsValid = GetActorRotationSimple_FunctionAddress != IntPtr.Zero && GetActorRotationSimple_Actor_IsValid && GetActorRotationSimple_OutRot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorRotationSimple", GetActorRotationSimple_IsValid);
		GetActorLocationSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorLocationSimple");
		GetActorLocationSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorLocationSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorLocationSimple_Actor_PropertyAddress, GetActorLocationSimple_FunctionAddress, "Actor");
		GetActorLocationSimple_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLocationSimple_FunctionAddress, "Actor");
		GetActorLocationSimple_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLocationSimple_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorLocationSimple_OutPos_PropertyAddress, GetActorLocationSimple_FunctionAddress, "OutPos");
		GetActorLocationSimple_OutPos_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLocationSimple_FunctionAddress, "OutPos");
		GetActorLocationSimple_OutPos_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLocationSimple_FunctionAddress, "OutPos", Classes.FStructProperty);
		GetActorLocationSimple_IsValid = GetActorLocationSimple_FunctionAddress != IntPtr.Zero && GetActorLocationSimple_Actor_IsValid && GetActorLocationSimple_OutPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorLocationSimple", GetActorLocationSimple_IsValid);
		GetActorHasAuthority_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorHasAuthority");
		GetActorHasAuthority_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorHasAuthority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorHasAuthority_Actor_PropertyAddress, GetActorHasAuthority_FunctionAddress, "Actor");
		GetActorHasAuthority_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorHasAuthority_FunctionAddress, "Actor");
		GetActorHasAuthority_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorHasAuthority_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorHasAuthority_OutHasAuthority_PropertyAddress, GetActorHasAuthority_FunctionAddress, "OutHasAuthority");
		GetActorHasAuthority_OutHasAuthority_Offset = NativeReflectionCached.GetPropertyOffset(GetActorHasAuthority_FunctionAddress, "OutHasAuthority");
		GetActorHasAuthority_OutHasAuthority_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorHasAuthority_FunctionAddress, "OutHasAuthority", Classes.FBoolProperty);
		GetActorHasAuthority_IsValid = GetActorHasAuthority_FunctionAddress != IntPtr.Zero && GetActorHasAuthority_Actor_IsValid && GetActorHasAuthority_OutHasAuthority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorHasAuthority", GetActorHasAuthority_IsValid);
		GetActorForwardVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorForwardVector");
		GetActorForwardVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorForwardVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorForwardVector_Actor_PropertyAddress, GetActorForwardVector_FunctionAddress, "Actor");
		GetActorForwardVector_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorForwardVector_FunctionAddress, "Actor");
		GetActorForwardVector_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorForwardVector_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorForwardVector_OutDir_PropertyAddress, GetActorForwardVector_FunctionAddress, "OutDir");
		GetActorForwardVector_OutDir_Offset = NativeReflectionCached.GetPropertyOffset(GetActorForwardVector_FunctionAddress, "OutDir");
		GetActorForwardVector_OutDir_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorForwardVector_FunctionAddress, "OutDir", Classes.FStructProperty);
		GetActorForwardVector_IsValid = GetActorForwardVector_FunctionAddress != IntPtr.Zero && GetActorForwardVector_Actor_IsValid && GetActorForwardVector_OutDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:GetActorForwardVector", GetActorForwardVector_IsValid);
		FinishAddComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FinishAddComponent");
		FinishAddComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishAddComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FinishAddComponent_Actor_PropertyAddress, FinishAddComponent_FunctionAddress, "Actor");
		FinishAddComponent_Actor_Offset = NativeReflectionCached.GetPropertyOffset(FinishAddComponent_FunctionAddress, "Actor");
		FinishAddComponent_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(FinishAddComponent_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FinishAddComponent_NewActorComp_PropertyAddress, FinishAddComponent_FunctionAddress, "NewActorComp");
		FinishAddComponent_NewActorComp_Offset = NativeReflectionCached.GetPropertyOffset(FinishAddComponent_FunctionAddress, "NewActorComp");
		FinishAddComponent_NewActorComp_IsValid = NativeReflectionCached.ValidatePropertyClass(FinishAddComponent_FunctionAddress, "NewActorComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FinishAddComponent_bManualAttachment_PropertyAddress, FinishAddComponent_FunctionAddress, "bManualAttachment");
		FinishAddComponent_bManualAttachment_Offset = NativeReflectionCached.GetPropertyOffset(FinishAddComponent_FunctionAddress, "bManualAttachment");
		FinishAddComponent_bManualAttachment_IsValid = NativeReflectionCached.ValidatePropertyClass(FinishAddComponent_FunctionAddress, "bManualAttachment", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FinishAddComponent_RelativeTransform_PropertyAddress, FinishAddComponent_FunctionAddress, "RelativeTransform");
		FinishAddComponent_RelativeTransform_Offset = NativeReflectionCached.GetPropertyOffset(FinishAddComponent_FunctionAddress, "RelativeTransform");
		FinishAddComponent_RelativeTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(FinishAddComponent_FunctionAddress, "RelativeTransform", Classes.FStructProperty);
		FinishAddComponent_IsValid = FinishAddComponent_FunctionAddress != IntPtr.Zero && FinishAddComponent_Actor_IsValid && FinishAddComponent_NewActorComp_IsValid && FinishAddComponent_bManualAttachment_IsValid && FinishAddComponent_RelativeTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:FinishAddComponent", FinishAddComponent_IsValid);
		ExcuteStreamingMeshMemoryStats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExcuteStreamingMeshMemoryStats");
		ExcuteStreamingMeshMemoryStats_ParamsSize = NativeReflection.GetFunctionParamsSize(ExcuteStreamingMeshMemoryStats_FunctionAddress);
		ExcuteStreamingMeshMemoryStats_IsValid = ExcuteStreamingMeshMemoryStats_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:ExcuteStreamingMeshMemoryStats", ExcuteStreamingMeshMemoryStats_IsValid);
		EndCapturingStreamingMeshLodStats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EndCapturingStreamingMeshLodStats");
		EndCapturingStreamingMeshLodStats_ParamsSize = NativeReflection.GetFunctionParamsSize(EndCapturingStreamingMeshLodStats_FunctionAddress);
		EndCapturingStreamingMeshLodStats_IsValid = EndCapturingStreamingMeshLodStats_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:EndCapturingStreamingMeshLodStats", EndCapturingStreamingMeshLodStats_IsValid);
		DetectRegionCenter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DetectRegionCenter");
		DetectRegionCenter_ParamsSize = NativeReflection.GetFunctionParamsSize(DetectRegionCenter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_Actor_PropertyAddress, DetectRegionCenter_FunctionAddress, "Actor");
		DetectRegionCenter_Actor_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "Actor");
		DetectRegionCenter_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_TraceDirectionList_PropertyAddress, DetectRegionCenter_FunctionAddress, "TraceDirectionList");
		DetectRegionCenter_TraceDirectionList_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "TraceDirectionList");
		DetectRegionCenter_TraceDirectionList_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "TraceDirectionList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_TraceDistance_PropertyAddress, DetectRegionCenter_FunctionAddress, "TraceDistance");
		DetectRegionCenter_TraceDistance_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "TraceDistance");
		DetectRegionCenter_TraceDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "TraceDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_TraceChannel_PropertyAddress, DetectRegionCenter_FunctionAddress, "TraceChannel");
		DetectRegionCenter_TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "TraceChannel");
		DetectRegionCenter_TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_DrawDebugType_PropertyAddress, DetectRegionCenter_FunctionAddress, "DrawDebugType");
		DetectRegionCenter_DrawDebugType_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "DrawDebugType");
		DetectRegionCenter_DrawDebugType_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "DrawDebugType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_DrawTime_PropertyAddress, DetectRegionCenter_FunctionAddress, "DrawTime");
		DetectRegionCenter_DrawTime_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "DrawTime");
		DetectRegionCenter_DrawTime_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "DrawTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_VaildRange_PropertyAddress, DetectRegionCenter_FunctionAddress, "VaildRange");
		DetectRegionCenter_VaildRange_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "VaildRange");
		DetectRegionCenter_VaildRange_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "VaildRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_AdjustedLocation_PropertyAddress, DetectRegionCenter_FunctionAddress, "AdjustedLocation");
		DetectRegionCenter_AdjustedLocation_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "AdjustedLocation");
		DetectRegionCenter_AdjustedLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "AdjustedLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_AdjustedRadius_PropertyAddress, DetectRegionCenter_FunctionAddress, "AdjustedRadius");
		DetectRegionCenter_AdjustedRadius_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "AdjustedRadius");
		DetectRegionCenter_AdjustedRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "AdjustedRadius", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectRegionCenter_IsSuccess_PropertyAddress, DetectRegionCenter_FunctionAddress, "IsSuccess");
		DetectRegionCenter_IsSuccess_Offset = NativeReflectionCached.GetPropertyOffset(DetectRegionCenter_FunctionAddress, "IsSuccess");
		DetectRegionCenter_IsSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectRegionCenter_FunctionAddress, "IsSuccess", Classes.FBoolProperty);
		DetectRegionCenter_IsValid = DetectRegionCenter_FunctionAddress != IntPtr.Zero && DetectRegionCenter_Actor_IsValid && DetectRegionCenter_TraceDirectionList_IsValid && DetectRegionCenter_TraceDistance_IsValid && DetectRegionCenter_TraceChannel_IsValid && DetectRegionCenter_DrawDebugType_IsValid && DetectRegionCenter_DrawTime_IsValid && DetectRegionCenter_VaildRange_IsValid && DetectRegionCenter_AdjustedLocation_IsValid && DetectRegionCenter_AdjustedRadius_IsValid && DetectRegionCenter_IsSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:DetectRegionCenter", DetectRegionCenter_IsValid);
		CheckActorWasRecentlyRendered_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckActorWasRecentlyRendered");
		CheckActorWasRecentlyRendered_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckActorWasRecentlyRendered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckActorWasRecentlyRendered_Actor_PropertyAddress, CheckActorWasRecentlyRendered_FunctionAddress, "Actor");
		CheckActorWasRecentlyRendered_Actor_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorWasRecentlyRendered_FunctionAddress, "Actor");
		CheckActorWasRecentlyRendered_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorWasRecentlyRendered_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckActorWasRecentlyRendered_ReturnValue_PropertyAddress, CheckActorWasRecentlyRendered_FunctionAddress, "ReturnValue");
		CheckActorWasRecentlyRendered_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorWasRecentlyRendered_FunctionAddress, "ReturnValue");
		CheckActorWasRecentlyRendered_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorWasRecentlyRendered_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckActorWasRecentlyRendered_IsValid = CheckActorWasRecentlyRendered_FunctionAddress != IntPtr.Zero && CheckActorWasRecentlyRendered_Actor_IsValid && CheckActorWasRecentlyRendered_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:CheckActorWasRecentlyRendered", CheckActorWasRecentlyRendered_IsValid);
		CaptureStreamingMeshLodStats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CaptureStreamingMeshLodStats");
		CaptureStreamingMeshLodStats_ParamsSize = NativeReflection.GetFunctionParamsSize(CaptureStreamingMeshLodStats_FunctionAddress);
		CaptureStreamingMeshLodStats_IsValid = CaptureStreamingMeshLodStats_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:CaptureStreamingMeshLodStats", CaptureStreamingMeshLodStats_IsValid);
		CacheCapturingStreamingMeshLodStats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CacheCapturingStreamingMeshLodStats");
		CacheCapturingStreamingMeshLodStats_ParamsSize = NativeReflection.GetFunctionParamsSize(CacheCapturingStreamingMeshLodStats_FunctionAddress);
		CacheCapturingStreamingMeshLodStats_IsValid = CacheCapturingStreamingMeshLodStats_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:CacheCapturingStreamingMeshLodStats", CacheCapturingStreamingMeshLodStats_IsValid);
		AddNamePrefix_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddNamePrefix");
		AddNamePrefix_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNamePrefix_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNamePrefix_Actor_PropertyAddress, AddNamePrefix_FunctionAddress, "Actor");
		AddNamePrefix_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AddNamePrefix_FunctionAddress, "Actor");
		AddNamePrefix_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNamePrefix_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNamePrefix_NamePrefix_PropertyAddress, AddNamePrefix_FunctionAddress, "NamePrefix");
		AddNamePrefix_NamePrefix_Offset = NativeReflectionCached.GetPropertyOffset(AddNamePrefix_FunctionAddress, "NamePrefix");
		AddNamePrefix_NamePrefix_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNamePrefix_FunctionAddress, "NamePrefix", Classes.FStrProperty);
		AddNamePrefix_IsValid = AddNamePrefix_FunctionAddress != IntPtr.Zero && AddNamePrefix_Actor_IsValid && AddNamePrefix_NamePrefix_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:AddNamePrefix", AddNamePrefix_IsValid);
		AddInstanceComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddInstanceComponent");
		AddInstanceComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInstanceComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInstanceComponent_Actor_PropertyAddress, AddInstanceComponent_FunctionAddress, "Actor");
		AddInstanceComponent_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AddInstanceComponent_FunctionAddress, "Actor");
		AddInstanceComponent_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstanceComponent_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstanceComponent_Component_PropertyAddress, AddInstanceComponent_FunctionAddress, "Component");
		AddInstanceComponent_Component_Offset = NativeReflectionCached.GetPropertyOffset(AddInstanceComponent_FunctionAddress, "Component");
		AddInstanceComponent_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstanceComponent_FunctionAddress, "Component", Classes.FObjectProperty);
		AddInstanceComponent_IsValid = AddInstanceComponent_FunctionAddress != IntPtr.Zero && AddInstanceComponent_Actor_IsValid && AddInstanceComponent_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:AddInstanceComponent", AddInstanceComponent_IsValid);
		AddComponentByClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddComponentByClass");
		AddComponentByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(AddComponentByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddComponentByClass_Actor_PropertyAddress, AddComponentByClass_FunctionAddress, "Actor");
		AddComponentByClass_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentByClass_FunctionAddress, "Actor");
		AddComponentByClass_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentByClass_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentByClass_Class_PropertyAddress, AddComponentByClass_FunctionAddress, "Class");
		AddComponentByClass_Class_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentByClass_FunctionAddress, "Class");
		AddComponentByClass_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentByClass_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentByClass_bManualAttachment_PropertyAddress, AddComponentByClass_FunctionAddress, "bManualAttachment");
		AddComponentByClass_bManualAttachment_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentByClass_FunctionAddress, "bManualAttachment");
		AddComponentByClass_bManualAttachment_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentByClass_FunctionAddress, "bManualAttachment", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentByClass_RelativeTransform_PropertyAddress, AddComponentByClass_FunctionAddress, "RelativeTransform");
		AddComponentByClass_RelativeTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentByClass_FunctionAddress, "RelativeTransform");
		AddComponentByClass_RelativeTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentByClass_FunctionAddress, "RelativeTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentByClass_bDeferredFinish_PropertyAddress, AddComponentByClass_FunctionAddress, "bDeferredFinish");
		AddComponentByClass_bDeferredFinish_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentByClass_FunctionAddress, "bDeferredFinish");
		AddComponentByClass_bDeferredFinish_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentByClass_FunctionAddress, "bDeferredFinish", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentByClass_ReturnValue_PropertyAddress, AddComponentByClass_FunctionAddress, "ReturnValue");
		AddComponentByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentByClass_FunctionAddress, "ReturnValue");
		AddComponentByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddComponentByClass_IsValid = AddComponentByClass_FunctionAddress != IntPtr.Zero && AddComponentByClass_Actor_IsValid && AddComponentByClass_Class_IsValid && AddComponentByClass_bManualAttachment_IsValid && AddComponentByClass_RelativeTransform_IsValid && AddComponentByClass_bDeferredFinish_IsValid && AddComponentByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ActorFuncLib:AddComponentByClass", AddComponentByClass_IsValid);
	}
}
