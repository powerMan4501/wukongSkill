using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.LevelSequence;
using UnrealEngine.Plugins.Paper2D;
using UnrealEngine.Plugins.ProceduralMeshComponent;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFunctionLibraryForCS", "b1", UnrealModuleType.Game)]
public class UBGUFunctionLibraryForCS : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ValidateMontagesForCrossSectionNS_IsValid;

	private static IntPtr ValidateMontagesForCrossSectionNS_FunctionAddress;

	private static int ValidateMontagesForCrossSectionNS_ParamsSize;

	private static bool ValidateMontagesForCrossSectionNS_ResourcePath_IsValid;

	private static FFieldAddress ValidateMontagesForCrossSectionNS_ResourcePath_PropertyAddress;

	private static int ValidateMontagesForCrossSectionNS_ResourcePath_Offset;

	private static bool RequestGameplayTag_IsValid;

	private static IntPtr RequestGameplayTag_FunctionAddress;

	private static int RequestGameplayTag_ParamsSize;

	private static bool RequestGameplayTag_TagName_IsValid;

	private static FFieldAddress RequestGameplayTag_TagName_PropertyAddress;

	private static int RequestGameplayTag_TagName_Offset;

	private static bool RequestGameplayTag_ErrorIfNotFound_IsValid;

	private static FFieldAddress RequestGameplayTag_ErrorIfNotFound_PropertyAddress;

	private static int RequestGameplayTag_ErrorIfNotFound_Offset;

	private static bool RequestGameplayTag_ReturnValue_IsValid;

	private static FFieldAddress RequestGameplayTag_ReturnValue_PropertyAddress;

	private static int RequestGameplayTag_ReturnValue_Offset;

	private static bool RemoveAllQueriesByQuerier_IsValid;

	private static IntPtr RemoveAllQueriesByQuerier_FunctionAddress;

	private static int RemoveAllQueriesByQuerier_ParamsSize;

	private static bool RemoveAllQueriesByQuerier_Querier_IsValid;

	private static FFieldAddress RemoveAllQueriesByQuerier_Querier_PropertyAddress;

	private static int RemoveAllQueriesByQuerier_Querier_Offset;

	private static bool CopyProceduralMeshFromStaticMeshComponent_IsValid;

	private static IntPtr CopyProceduralMeshFromStaticMeshComponent_FunctionAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_ParamsSize;

	private static bool CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_IsValid;

	private static FFieldAddress CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_PropertyAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_Offset;

	private static bool CopyProceduralMeshFromStaticMeshComponent_LODIndex_IsValid;

	private static FFieldAddress CopyProceduralMeshFromStaticMeshComponent_LODIndex_PropertyAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_LODIndex_Offset;

	private static bool CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_IsValid;

	private static FFieldAddress CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_PropertyAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_Offset;

	private static bool CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_IsValid;

	private static FFieldAddress CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_PropertyAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_Offset;

	private static bool ConvertTraceTypeToCollisionChannel_IsValid;

	private static IntPtr ConvertTraceTypeToCollisionChannel_FunctionAddress;

	private static int ConvertTraceTypeToCollisionChannel_ParamsSize;

	private static bool ConvertTraceTypeToCollisionChannel_TraceType_IsValid;

	private static FFieldAddress ConvertTraceTypeToCollisionChannel_TraceType_PropertyAddress;

	private static int ConvertTraceTypeToCollisionChannel_TraceType_Offset;

	private static bool ConvertTraceTypeToCollisionChannel_ReturnValue_IsValid;

	private static FFieldAddress ConvertTraceTypeToCollisionChannel_ReturnValue_PropertyAddress;

	private static int ConvertTraceTypeToCollisionChannel_ReturnValue_Offset;

	private static bool ConvertToTraceType_IsValid;

	private static IntPtr ConvertToTraceType_FunctionAddress;

	private static int ConvertToTraceType_ParamsSize;

	private static bool ConvertToTraceType_CollisionChannel_IsValid;

	private static FFieldAddress ConvertToTraceType_CollisionChannel_PropertyAddress;

	private static int ConvertToTraceType_CollisionChannel_Offset;

	private static bool ConvertToTraceType_ReturnValue_IsValid;

	private static FFieldAddress ConvertToTraceType_ReturnValue_PropertyAddress;

	private static int ConvertToTraceType_ReturnValue_Offset;

	private static bool ConvertToObjectType_IsValid;

	private static IntPtr ConvertToObjectType_FunctionAddress;

	private static int ConvertToObjectType_ParamsSize;

	private static bool ConvertToObjectType_CollisionChannel_IsValid;

	private static FFieldAddress ConvertToObjectType_CollisionChannel_PropertyAddress;

	private static int ConvertToObjectType_CollisionChannel_Offset;

	private static bool ConvertToObjectType_ReturnValue_IsValid;

	private static FFieldAddress ConvertToObjectType_ReturnValue_PropertyAddress;

	private static int ConvertToObjectType_ReturnValue_Offset;

	private static bool ConvertObjectTypeToCollisionChannel_IsValid;

	private static IntPtr ConvertObjectTypeToCollisionChannel_FunctionAddress;

	private static int ConvertObjectTypeToCollisionChannel_ParamsSize;

	private static bool ConvertObjectTypeToCollisionChannel_ObjectType_IsValid;

	private static FFieldAddress ConvertObjectTypeToCollisionChannel_ObjectType_PropertyAddress;

	private static int ConvertObjectTypeToCollisionChannel_ObjectType_Offset;

	private static bool ConvertObjectTypeToCollisionChannel_ReturnValue_IsValid;

	private static FFieldAddress ConvertObjectTypeToCollisionChannel_ReturnValue_PropertyAddress;

	private static int ConvertObjectTypeToCollisionChannel_ReturnValue_Offset;

	private static bool CompForceUpdateOverlaps_IsValid;

	private static IntPtr CompForceUpdateOverlaps_FunctionAddress;

	private static int CompForceUpdateOverlaps_ParamsSize;

	private static bool CompForceUpdateOverlaps_Comp_IsValid;

	private static FFieldAddress CompForceUpdateOverlaps_Comp_PropertyAddress;

	private static int CompForceUpdateOverlaps_Comp_Offset;

	private static bool CompForceUpdateOverlaps_bDoNotifies_IsValid;

	private static FFieldAddress CompForceUpdateOverlaps_bDoNotifies_PropertyAddress;

	private static int CompForceUpdateOverlaps_bDoNotifies_Offset;

	private static bool CompForceUpdateOverlaps_ReturnValue_IsValid;

	private static FFieldAddress CompForceUpdateOverlaps_ReturnValue_PropertyAddress;

	private static int CompForceUpdateOverlaps_ReturnValue_Offset;

	private static bool CallSectionManuallyChangeOnCrossSectionNotifies_IsValid;

	private static IntPtr CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress;

	private static int CallSectionManuallyChangeOnCrossSectionNotifies_ParamsSize;

	private static bool CallSectionManuallyChangeOnCrossSectionNotifies_OwnerChar_IsValid;

	private static FFieldAddress CallSectionManuallyChangeOnCrossSectionNotifies_OwnerChar_PropertyAddress;

	private static int CallSectionManuallyChangeOnCrossSectionNotifies_OwnerChar_Offset;

	private static bool CallSectionManuallyChangeOnCrossSectionNotifies_NewSectionName_IsValid;

	private static FFieldAddress CallSectionManuallyChangeOnCrossSectionNotifies_NewSectionName_PropertyAddress;

	private static int CallSectionManuallyChangeOnCrossSectionNotifies_NewSectionName_Offset;

	private static bool BGUUnBindOnSetLevelsStateFinished_IsValid;

	private static IntPtr BGUUnBindOnSetLevelsStateFinished_FunctionAddress;

	private static int BGUUnBindOnSetLevelsStateFinished_ParamsSize;

	private static bool BGUUnBindOnSetLevelsStateFinished_Obj_IsValid;

	private static FFieldAddress BGUUnBindOnSetLevelsStateFinished_Obj_PropertyAddress;

	private static int BGUUnBindOnSetLevelsStateFinished_Obj_Offset;

	private static bool BGUUnBindOnSetLevelsStateFinished_FuncName_IsValid;

	private static FFieldAddress BGUUnBindOnSetLevelsStateFinished_FuncName_PropertyAddress;

	private static int BGUUnBindOnSetLevelsStateFinished_FuncName_Offset;

	private static bool BGUUnBindOnComponentHitEvent_IsValid;

	private static IntPtr BGUUnBindOnComponentHitEvent_FunctionAddress;

	private static int BGUUnBindOnComponentHitEvent_ParamsSize;

	private static bool BGUUnBindOnComponentHitEvent_Comp_IsValid;

	private static FFieldAddress BGUUnBindOnComponentHitEvent_Comp_PropertyAddress;

	private static int BGUUnBindOnComponentHitEvent_Comp_Offset;

	private static bool BGUUnBindOnComponentHitEvent_Obj_IsValid;

	private static FFieldAddress BGUUnBindOnComponentHitEvent_Obj_PropertyAddress;

	private static int BGUUnBindOnComponentHitEvent_Obj_Offset;

	private static bool BGUUnBindOnComponentHitEvent_Func_IsValid;

	private static FFieldAddress BGUUnBindOnComponentHitEvent_Func_PropertyAddress;

	private static int BGUUnBindOnComponentHitEvent_Func_Offset;

	private static bool BGUUnBindOnComponentEndOverlapEvent_IsValid;

	private static IntPtr BGUUnBindOnComponentEndOverlapEvent_FunctionAddress;

	private static int BGUUnBindOnComponentEndOverlapEvent_ParamsSize;

	private static bool BGUUnBindOnComponentEndOverlapEvent_Comp_IsValid;

	private static FFieldAddress BGUUnBindOnComponentEndOverlapEvent_Comp_PropertyAddress;

	private static int BGUUnBindOnComponentEndOverlapEvent_Comp_Offset;

	private static bool BGUUnBindOnComponentEndOverlapEvent_Obj_IsValid;

	private static FFieldAddress BGUUnBindOnComponentEndOverlapEvent_Obj_PropertyAddress;

	private static int BGUUnBindOnComponentEndOverlapEvent_Obj_Offset;

	private static bool BGUUnBindOnComponentEndOverlapEvent_FuncName_IsValid;

	private static FFieldAddress BGUUnBindOnComponentEndOverlapEvent_FuncName_PropertyAddress;

	private static int BGUUnBindOnComponentEndOverlapEvent_FuncName_Offset;

	private static bool BGUUnBindOnComponentBeginOverlapEvent_IsValid;

	private static IntPtr BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress;

	private static int BGUUnBindOnComponentBeginOverlapEvent_ParamsSize;

	private static bool BGUUnBindOnComponentBeginOverlapEvent_Comp_IsValid;

	private static FFieldAddress BGUUnBindOnComponentBeginOverlapEvent_Comp_PropertyAddress;

	private static int BGUUnBindOnComponentBeginOverlapEvent_Comp_Offset;

	private static bool BGUUnBindOnComponentBeginOverlapEvent_Obj_IsValid;

	private static FFieldAddress BGUUnBindOnComponentBeginOverlapEvent_Obj_PropertyAddress;

	private static int BGUUnBindOnComponentBeginOverlapEvent_Obj_Offset;

	private static bool BGUUnBindOnComponentBeginOverlapEvent_FuncName_IsValid;

	private static FFieldAddress BGUUnBindOnComponentBeginOverlapEvent_FuncName_PropertyAddress;

	private static int BGUUnBindOnComponentBeginOverlapEvent_FuncName_Offset;

	private static bool BGUUnBindOnAllSetLevelsStateFinished_IsValid;

	private static IntPtr BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress;

	private static int BGUUnBindOnAllSetLevelsStateFinished_ParamsSize;

	private static bool BGUUnBindOnAllSetLevelsStateFinished_Obj_IsValid;

	private static FFieldAddress BGUUnBindOnAllSetLevelsStateFinished_Obj_PropertyAddress;

	private static int BGUUnBindOnAllSetLevelsStateFinished_Obj_Offset;

	private static bool BGUUnBindOnAllSetLevelsStateFinished_FuncName_IsValid;

	private static FFieldAddress BGUUnBindOnAllSetLevelsStateFinished_FuncName_PropertyAddress;

	private static int BGUUnBindOnAllSetLevelsStateFinished_FuncName_Offset;

	private static bool BGUTeleportTo_IsValid;

	private static IntPtr BGUTeleportTo_FunctionAddress;

	private static int BGUTeleportTo_ParamsSize;

	private static bool BGUTeleportTo_Owner_IsValid;

	private static FFieldAddress BGUTeleportTo_Owner_PropertyAddress;

	private static int BGUTeleportTo_Owner_Offset;

	private static bool BGUTeleportTo_DestLocation_IsValid;

	private static FFieldAddress BGUTeleportTo_DestLocation_PropertyAddress;

	private static int BGUTeleportTo_DestLocation_Offset;

	private static bool BGUTeleportTo_DestRotation_IsValid;

	private static FFieldAddress BGUTeleportTo_DestRotation_PropertyAddress;

	private static int BGUTeleportTo_DestRotation_Offset;

	private static bool BGUTeleportTo_bIsATest_IsValid;

	private static FFieldAddress BGUTeleportTo_bIsATest_PropertyAddress;

	private static int BGUTeleportTo_bIsATest_Offset;

	private static bool BGUTeleportTo_bNoCheck_IsValid;

	private static FFieldAddress BGUTeleportTo_bNoCheck_PropertyAddress;

	private static int BGUTeleportTo_bNoCheck_Offset;

	private static bool BGUTeleportTo_ReturnValue_IsValid;

	private static FFieldAddress BGUTeleportTo_ReturnValue_PropertyAddress;

	private static int BGUTeleportTo_ReturnValue_Offset;

	private static bool BGUSpawnDecalAttached_IsValid;

	private static IntPtr BGUSpawnDecalAttached_FunctionAddress;

	private static int BGUSpawnDecalAttached_ParamsSize;

	private static bool BGUSpawnDecalAttached_DecalMaterial_IsValid;

	private static FFieldAddress BGUSpawnDecalAttached_DecalMaterial_PropertyAddress;

	private static int BGUSpawnDecalAttached_DecalMaterial_Offset;

	private static bool BGUSpawnDecalAttached_DecalSize_IsValid;

	private static FFieldAddress BGUSpawnDecalAttached_DecalSize_PropertyAddress;

	private static int BGUSpawnDecalAttached_DecalSize_Offset;

	private static bool BGUSpawnDecalAttached_AttachToComponent_IsValid;

	private static FFieldAddress BGUSpawnDecalAttached_AttachToComponent_PropertyAddress;

	private static int BGUSpawnDecalAttached_AttachToComponent_Offset;

	private static bool BGUSpawnDecalAttached_AttachPointName_IsValid;

	private static FFieldAddress BGUSpawnDecalAttached_AttachPointName_PropertyAddress;

	private static int BGUSpawnDecalAttached_AttachPointName_Offset;

	private static bool BGUSpawnDecalAttached_Location_IsValid;

	private static FFieldAddress BGUSpawnDecalAttached_Location_PropertyAddress;

	private static int BGUSpawnDecalAttached_Location_Offset;

	private static bool BGUSpawnDecalAttached_Rotation_IsValid;

	private static FFieldAddress BGUSpawnDecalAttached_Rotation_PropertyAddress;

	private static int BGUSpawnDecalAttached_Rotation_Offset;

	private static bool BGUSpawnDecalAttached_LocationType_IsValid;

	private static FFieldAddress BGUSpawnDecalAttached_LocationType_PropertyAddress;

	private static int BGUSpawnDecalAttached_LocationType_Offset;

	private static bool BGUSpawnDecalAttached_LifeSpan_IsValid;

	private static FFieldAddress BGUSpawnDecalAttached_LifeSpan_PropertyAddress;

	private static int BGUSpawnDecalAttached_LifeSpan_Offset;

	private static bool BGUSpawnDecalAttached_ReturnValue_IsValid;

	private static FFieldAddress BGUSpawnDecalAttached_ReturnValue_PropertyAddress;

	private static int BGUSpawnDecalAttached_ReturnValue_Offset;

	private static bool BGUSliceProceduralMesh_IsValid;

	private static IntPtr BGUSliceProceduralMesh_FunctionAddress;

	private static int BGUSliceProceduralMesh_ParamsSize;

	private static bool BGUSliceProceduralMesh_InProcMesh_IsValid;

	private static FFieldAddress BGUSliceProceduralMesh_InProcMesh_PropertyAddress;

	private static int BGUSliceProceduralMesh_InProcMesh_Offset;

	private static bool BGUSliceProceduralMesh_PlanePosition_IsValid;

	private static FFieldAddress BGUSliceProceduralMesh_PlanePosition_PropertyAddress;

	private static int BGUSliceProceduralMesh_PlanePosition_Offset;

	private static bool BGUSliceProceduralMesh_PlaneNormal_IsValid;

	private static FFieldAddress BGUSliceProceduralMesh_PlaneNormal_PropertyAddress;

	private static int BGUSliceProceduralMesh_PlaneNormal_Offset;

	private static bool BGUSliceProceduralMesh_bCreateOtherHalf_IsValid;

	private static FFieldAddress BGUSliceProceduralMesh_bCreateOtherHalf_PropertyAddress;

	private static int BGUSliceProceduralMesh_bCreateOtherHalf_Offset;

	private static bool BGUSliceProceduralMesh_OutOtherHalfProcMesh_IsValid;

	private static FFieldAddress BGUSliceProceduralMesh_OutOtherHalfProcMesh_PropertyAddress;

	private static int BGUSliceProceduralMesh_OutOtherHalfProcMesh_Offset;

	private static bool BGUSliceProceduralMesh_CapOption_IsValid;

	private static FFieldAddress BGUSliceProceduralMesh_CapOption_PropertyAddress;

	private static int BGUSliceProceduralMesh_CapOption_Offset;

	private static bool BGUSliceProceduralMesh_CapMaterial_IsValid;

	private static FFieldAddress BGUSliceProceduralMesh_CapMaterial_PropertyAddress;

	private static int BGUSliceProceduralMesh_CapMaterial_Offset;

	private static bool BGUSetParticleSysSortPriority_IsValid;

	private static IntPtr BGUSetParticleSysSortPriority_FunctionAddress;

	private static int BGUSetParticleSysSortPriority_ParamsSize;

	private static bool BGUSetParticleSysSortPriority_ParticleSystemComp_IsValid;

	private static FFieldAddress BGUSetParticleSysSortPriority_ParticleSystemComp_PropertyAddress;

	private static int BGUSetParticleSysSortPriority_ParticleSystemComp_Offset;

	private static bool BGUSetParticleSysSortPriority_SortPriority_IsValid;

	private static FFieldAddress BGUSetParticleSysSortPriority_SortPriority_PropertyAddress;

	private static int BGUSetParticleSysSortPriority_SortPriority_Offset;

	private static bool BGUSetParticleSysCompPoolingMethod_IsValid;

	private static IntPtr BGUSetParticleSysCompPoolingMethod_FunctionAddress;

	private static int BGUSetParticleSysCompPoolingMethod_ParamsSize;

	private static bool BGUSetParticleSysCompPoolingMethod_ParticleComp_IsValid;

	private static FFieldAddress BGUSetParticleSysCompPoolingMethod_ParticleComp_PropertyAddress;

	private static int BGUSetParticleSysCompPoolingMethod_ParticleComp_Offset;

	private static bool BGUSetParticleSysCompPoolingMethod_PoolMethod_IsValid;

	private static FFieldAddress BGUSetParticleSysCompPoolingMethod_PoolMethod_PropertyAddress;

	private static int BGUSetParticleSysCompPoolingMethod_PoolMethod_Offset;

	private static bool BGUSetIKComponentValid_IsValid;

	private static IntPtr BGUSetIKComponentValid_FunctionAddress;

	private static int BGUSetIKComponentValid_ParamsSize;

	private static bool BGUSetIKComponentValid_Character_IsValid;

	private static FFieldAddress BGUSetIKComponentValid_Character_PropertyAddress;

	private static int BGUSetIKComponentValid_Character_Offset;

	private static bool BGUSetIKComponentValid_NewValid_IsValid;

	private static FFieldAddress BGUSetIKComponentValid_NewValid_PropertyAddress;

	private static int BGUSetIKComponentValid_NewValid_Offset;

	private static bool BGUSetDecalSize_IsValid;

	private static IntPtr BGUSetDecalSize_FunctionAddress;

	private static int BGUSetDecalSize_ParamsSize;

	private static bool BGUSetDecalSize_DecalComp_IsValid;

	private static FFieldAddress BGUSetDecalSize_DecalComp_PropertyAddress;

	private static int BGUSetDecalSize_DecalComp_Offset;

	private static bool BGUSetDecalSize_Size_IsValid;

	private static FFieldAddress BGUSetDecalSize_Size_PropertyAddress;

	private static int BGUSetDecalSize_Size_Offset;

	private static bool BGURestartBT_IsValid;

	private static IntPtr BGURestartBT_FunctionAddress;

	private static int BGURestartBT_ParamsSize;

	private static bool BGURestartBT_AIController_IsValid;

	private static FFieldAddress BGURestartBT_AIController_PropertyAddress;

	private static int BGURestartBT_AIController_Offset;

	private static bool BGURegistComp_IsValid;

	private static IntPtr BGURegistComp_FunctionAddress;

	private static int BGURegistComp_ParamsSize;

	private static bool BGURegistComp_WorldContextObject_IsValid;

	private static FFieldAddress BGURegistComp_WorldContextObject_PropertyAddress;

	private static int BGURegistComp_WorldContextObject_Offset;

	private static bool BGURegistComp_ActorComp_IsValid;

	private static FFieldAddress BGURegistComp_ActorComp_PropertyAddress;

	private static int BGURegistComp_ActorComp_Offset;

	private static bool BGURegistComp_ReturnValue_IsValid;

	private static FFieldAddress BGURegistComp_ReturnValue_PropertyAddress;

	private static int BGURegistComp_ReturnValue_Offset;

	private static bool BGUMovementComponentSlideAlongSurface_IsValid;

	private static IntPtr BGUMovementComponentSlideAlongSurface_FunctionAddress;

	private static int BGUMovementComponentSlideAlongSurface_ParamsSize;

	private static bool BGUMovementComponentSlideAlongSurface_MoveComp_IsValid;

	private static FFieldAddress BGUMovementComponentSlideAlongSurface_MoveComp_PropertyAddress;

	private static int BGUMovementComponentSlideAlongSurface_MoveComp_Offset;

	private static bool BGUMovementComponentSlideAlongSurface_Delta_IsValid;

	private static FFieldAddress BGUMovementComponentSlideAlongSurface_Delta_PropertyAddress;

	private static int BGUMovementComponentSlideAlongSurface_Delta_Offset;

	private static bool BGUMovementComponentSlideAlongSurface_Time_IsValid;

	private static FFieldAddress BGUMovementComponentSlideAlongSurface_Time_PropertyAddress;

	private static int BGUMovementComponentSlideAlongSurface_Time_Offset;

	private static bool BGUMovementComponentSlideAlongSurface_Normal_IsValid;

	private static FFieldAddress BGUMovementComponentSlideAlongSurface_Normal_PropertyAddress;

	private static int BGUMovementComponentSlideAlongSurface_Normal_Offset;

	private static bool BGUMovementComponentSlideAlongSurface_InHit_IsValid;

	private static FFieldAddress BGUMovementComponentSlideAlongSurface_InHit_PropertyAddress;

	private static int BGUMovementComponentSlideAlongSurface_InHit_Offset;

	private static bool BGUMovementComponentSlideAlongSurface_bHandleImpact_IsValid;

	private static FFieldAddress BGUMovementComponentSlideAlongSurface_bHandleImpact_PropertyAddress;

	private static int BGUMovementComponentSlideAlongSurface_bHandleImpact_Offset;

	private static bool BGUMovementComponentSlideAlongSurface_OutHit_IsValid;

	private static FFieldAddress BGUMovementComponentSlideAlongSurface_OutHit_PropertyAddress;

	private static int BGUMovementComponentSlideAlongSurface_OutHit_Offset;

	private static bool BGUMovementComponentSlideAlongSurface_ReturnValue_IsValid;

	private static FFieldAddress BGUMovementComponentSlideAlongSurface_ReturnValue_PropertyAddress;

	private static int BGUMovementComponentSlideAlongSurface_ReturnValue_Offset;

	private static bool BGUMovementComponentHandleImpact_IsValid;

	private static IntPtr BGUMovementComponentHandleImpact_FunctionAddress;

	private static int BGUMovementComponentHandleImpact_ParamsSize;

	private static bool BGUMovementComponentHandleImpact_MoveComp_IsValid;

	private static FFieldAddress BGUMovementComponentHandleImpact_MoveComp_PropertyAddress;

	private static int BGUMovementComponentHandleImpact_MoveComp_Offset;

	private static bool BGUMovementComponentHandleImpact_Hit_IsValid;

	private static FFieldAddress BGUMovementComponentHandleImpact_Hit_PropertyAddress;

	private static int BGUMovementComponentHandleImpact_Hit_Offset;

	private static bool BGUMovementComponentHandleImpact_TimeSlice_IsValid;

	private static FFieldAddress BGUMovementComponentHandleImpact_TimeSlice_PropertyAddress;

	private static int BGUMovementComponentHandleImpact_TimeSlice_Offset;

	private static bool BGUMovementComponentHandleImpact_MoveDelta_IsValid;

	private static FFieldAddress BGUMovementComponentHandleImpact_MoveDelta_PropertyAddress;

	private static int BGUMovementComponentHandleImpact_MoveDelta_Offset;

	private static bool BGUIsBlackBoardKeyTypeMatch_IsValid;

	private static IntPtr BGUIsBlackBoardKeyTypeMatch_FunctionAddress;

	private static int BGUIsBlackBoardKeyTypeMatch_ParamsSize;

	private static bool BGUIsBlackBoardKeyTypeMatch_BBKey_IsValid;

	private static FFieldAddress BGUIsBlackBoardKeyTypeMatch_BBKey_PropertyAddress;

	private static int BGUIsBlackBoardKeyTypeMatch_BBKey_Offset;

	private static bool BGUIsBlackBoardKeyTypeMatch_BBKeyType_IsValid;

	private static FFieldAddress BGUIsBlackBoardKeyTypeMatch_BBKeyType_PropertyAddress;

	private static int BGUIsBlackBoardKeyTypeMatch_BBKeyType_Offset;

	private static bool BGUIsBlackBoardKeyTypeMatch_ReturnValue_IsValid;

	private static FFieldAddress BGUIsBlackBoardKeyTypeMatch_ReturnValue_PropertyAddress;

	private static int BGUIsBlackBoardKeyTypeMatch_ReturnValue_Offset;

	private static bool BGUGetUWorld_IsValid;

	private static IntPtr BGUGetUWorld_FunctionAddress;

	private static int BGUGetUWorld_ParamsSize;

	private static bool BGUGetUWorld_InnerObject_IsValid;

	private static FFieldAddress BGUGetUWorld_InnerObject_PropertyAddress;

	private static int BGUGetUWorld_InnerObject_Offset;

	private static bool BGUGetUWorld_ReturnValue_IsValid;

	private static FFieldAddress BGUGetUWorld_ReturnValue_PropertyAddress;

	private static int BGUGetUWorld_ReturnValue_Offset;

	private static bool BGUGetSectionFromProceduralMesh_IsValid;

	private static IntPtr BGUGetSectionFromProceduralMesh_FunctionAddress;

	private static int BGUGetSectionFromProceduralMesh_ParamsSize;

	private static bool BGUGetSectionFromProceduralMesh_InProcMesh_IsValid;

	private static FFieldAddress BGUGetSectionFromProceduralMesh_InProcMesh_PropertyAddress;

	private static int BGUGetSectionFromProceduralMesh_InProcMesh_Offset;

	private static bool BGUGetSectionFromProceduralMesh_SectionIndex_IsValid;

	private static FFieldAddress BGUGetSectionFromProceduralMesh_SectionIndex_PropertyAddress;

	private static int BGUGetSectionFromProceduralMesh_SectionIndex_Offset;

	private static bool BGUGetSectionFromProceduralMesh_Vertices_IsValid;

	private static FFieldAddress BGUGetSectionFromProceduralMesh_Vertices_PropertyAddress;

	private static int BGUGetSectionFromProceduralMesh_Vertices_Offset;

	private static bool BGUGetSectionFromProceduralMesh_Triangles_IsValid;

	private static FFieldAddress BGUGetSectionFromProceduralMesh_Triangles_PropertyAddress;

	private static int BGUGetSectionFromProceduralMesh_Triangles_Offset;

	private static bool BGUGetSectionFromProceduralMesh_Normals_IsValid;

	private static FFieldAddress BGUGetSectionFromProceduralMesh_Normals_PropertyAddress;

	private static int BGUGetSectionFromProceduralMesh_Normals_Offset;

	private static bool BGUGetSectionFromProceduralMesh_UVs_IsValid;

	private static FFieldAddress BGUGetSectionFromProceduralMesh_UVs_PropertyAddress;

	private static int BGUGetSectionFromProceduralMesh_UVs_Offset;

	private static bool BGUGetSectionFromProceduralMesh_Tangents_IsValid;

	private static FFieldAddress BGUGetSectionFromProceduralMesh_Tangents_PropertyAddress;

	private static int BGUGetSectionFromProceduralMesh_Tangents_Offset;

	private static bool BGUGetParticleSystemIsLooping_IsValid;

	private static IntPtr BGUGetParticleSystemIsLooping_FunctionAddress;

	private static int BGUGetParticleSystemIsLooping_ParamsSize;

	private static bool BGUGetParticleSystemIsLooping_ParticleForPlay_IsValid;

	private static FFieldAddress BGUGetParticleSystemIsLooping_ParticleForPlay_PropertyAddress;

	private static int BGUGetParticleSystemIsLooping_ParticleForPlay_Offset;

	private static bool BGUGetParticleSystemIsLooping_ReturnValue_IsValid;

	private static FFieldAddress BGUGetParticleSystemIsLooping_ReturnValue_PropertyAddress;

	private static int BGUGetParticleSystemIsLooping_ReturnValue_Offset;

	private static bool BGUGetPARadiusByBoneName_IsValid;

	private static IntPtr BGUGetPARadiusByBoneName_FunctionAddress;

	private static int BGUGetPARadiusByBoneName_ParamsSize;

	private static bool BGUGetPARadiusByBoneName_PA_IsValid;

	private static FFieldAddress BGUGetPARadiusByBoneName_PA_PropertyAddress;

	private static int BGUGetPARadiusByBoneName_PA_Offset;

	private static bool BGUGetPARadiusByBoneName_BoneName_IsValid;

	private static FFieldAddress BGUGetPARadiusByBoneName_BoneName_PropertyAddress;

	private static int BGUGetPARadiusByBoneName_BoneName_Offset;

	private static bool BGUGetPARadiusByBoneName_BodyRadius_IsValid;

	private static FFieldAddress BGUGetPARadiusByBoneName_BodyRadius_PropertyAddress;

	private static int BGUGetPARadiusByBoneName_BodyRadius_Offset;

	private static bool BGUGetPARadiusByBoneName_ReturnValue_IsValid;

	private static FFieldAddress BGUGetPARadiusByBoneName_ReturnValue_PropertyAddress;

	private static int BGUGetPARadiusByBoneName_ReturnValue_Offset;

	private static bool BGUGetPaperSpriteSize_IsValid;

	private static IntPtr BGUGetPaperSpriteSize_FunctionAddress;

	private static int BGUGetPaperSpriteSize_ParamsSize;

	private static bool BGUGetPaperSpriteSize_PaperSprite_IsValid;

	private static FFieldAddress BGUGetPaperSpriteSize_PaperSprite_PropertyAddress;

	private static int BGUGetPaperSpriteSize_PaperSprite_Offset;

	private static bool BGUGetPaperSpriteSize_ReturnValue_IsValid;

	private static FFieldAddress BGUGetPaperSpriteSize_ReturnValue_PropertyAddress;

	private static int BGUGetPaperSpriteSize_ReturnValue_Offset;

	private static bool BGUGetMeshPredictedLODLevel_IsValid;

	private static IntPtr BGUGetMeshPredictedLODLevel_FunctionAddress;

	private static int BGUGetMeshPredictedLODLevel_ParamsSize;

	private static bool BGUGetMeshPredictedLODLevel_MeshComp_IsValid;

	private static FFieldAddress BGUGetMeshPredictedLODLevel_MeshComp_PropertyAddress;

	private static int BGUGetMeshPredictedLODLevel_MeshComp_Offset;

	private static bool BGUGetMeshPredictedLODLevel_ReturnValue_IsValid;

	private static FFieldAddress BGUGetMeshPredictedLODLevel_ReturnValue_PropertyAddress;

	private static int BGUGetMeshPredictedLODLevel_ReturnValue_Offset;

	private static bool BGUGetLevelSequenceLength_IsValid;

	private static IntPtr BGUGetLevelSequenceLength_FunctionAddress;

	private static int BGUGetLevelSequenceLength_ParamsSize;

	private static bool BGUGetLevelSequenceLength_LeveleSequencePlayer_IsValid;

	private static FFieldAddress BGUGetLevelSequenceLength_LeveleSequencePlayer_PropertyAddress;

	private static int BGUGetLevelSequenceLength_LeveleSequencePlayer_Offset;

	private static bool BGUGetLevelSequenceLength_ReturnValue_IsValid;

	private static FFieldAddress BGUGetLevelSequenceLength_ReturnValue_PropertyAddress;

	private static int BGUGetLevelSequenceLength_ReturnValue_Offset;

	private static bool BGUGetLevelSequenceCurTime_IsValid;

	private static IntPtr BGUGetLevelSequenceCurTime_FunctionAddress;

	private static int BGUGetLevelSequenceCurTime_ParamsSize;

	private static bool BGUGetLevelSequenceCurTime_LeveleSequencePlayer_IsValid;

	private static FFieldAddress BGUGetLevelSequenceCurTime_LeveleSequencePlayer_PropertyAddress;

	private static int BGUGetLevelSequenceCurTime_LeveleSequencePlayer_Offset;

	private static bool BGUGetLevelSequenceCurTime_ReturnValue_IsValid;

	private static FFieldAddress BGUGetLevelSequenceCurTime_ReturnValue_PropertyAddress;

	private static int BGUGetLevelSequenceCurTime_ReturnValue_Offset;

	private static bool BGUGetLandscapeExtent_IsValid;

	private static IntPtr BGUGetLandscapeExtent_FunctionAddress;

	private static int BGUGetLandscapeExtent_ParamsSize;

	private static bool BGUGetLandscapeExtent_Landscape_IsValid;

	private static FFieldAddress BGUGetLandscapeExtent_Landscape_PropertyAddress;

	private static int BGUGetLandscapeExtent_Landscape_Offset;

	private static bool BGUGetLandscapeExtent_MinX_IsValid;

	private static FFieldAddress BGUGetLandscapeExtent_MinX_PropertyAddress;

	private static int BGUGetLandscapeExtent_MinX_Offset;

	private static bool BGUGetLandscapeExtent_MinY_IsValid;

	private static FFieldAddress BGUGetLandscapeExtent_MinY_PropertyAddress;

	private static int BGUGetLandscapeExtent_MinY_Offset;

	private static bool BGUGetLandscapeExtent_MaxX_IsValid;

	private static FFieldAddress BGUGetLandscapeExtent_MaxX_PropertyAddress;

	private static int BGUGetLandscapeExtent_MaxX_Offset;

	private static bool BGUGetLandscapeExtent_MaxY_IsValid;

	private static FFieldAddress BGUGetLandscapeExtent_MaxY_PropertyAddress;

	private static int BGUGetLandscapeExtent_MaxY_Offset;

	private static bool BGUGetIsRuntionShowCollision_IsValid;

	private static IntPtr BGUGetIsRuntionShowCollision_FunctionAddress;

	private static int BGUGetIsRuntionShowCollision_ParamsSize;

	private static bool BGUGetIsRuntionShowCollision_WorldContextObject_IsValid;

	private static FFieldAddress BGUGetIsRuntionShowCollision_WorldContextObject_PropertyAddress;

	private static int BGUGetIsRuntionShowCollision_WorldContextObject_Offset;

	private static bool BGUGetIsRuntionShowCollision_ReturnValue_IsValid;

	private static FFieldAddress BGUGetIsRuntionShowCollision_ReturnValue_PropertyAddress;

	private static int BGUGetIsRuntionShowCollision_ReturnValue_Offset;

	private static bool BGUGetIsInGameWorld_IsValid;

	private static IntPtr BGUGetIsInGameWorld_FunctionAddress;

	private static int BGUGetIsInGameWorld_ParamsSize;

	private static bool BGUGetIsInGameWorld_WorldContextObject_IsValid;

	private static FFieldAddress BGUGetIsInGameWorld_WorldContextObject_PropertyAddress;

	private static int BGUGetIsInGameWorld_WorldContextObject_Offset;

	private static bool BGUGetIsInGameWorld_ReturnValue_IsValid;

	private static FFieldAddress BGUGetIsInGameWorld_ReturnValue_PropertyAddress;

	private static int BGUGetIsInGameWorld_ReturnValue_Offset;

	private static bool BGUGetIsInEditorPreview_IsValid;

	private static IntPtr BGUGetIsInEditorPreview_FunctionAddress;

	private static int BGUGetIsInEditorPreview_ParamsSize;

	private static bool BGUGetIsInEditorPreview_WorldContextObject_IsValid;

	private static FFieldAddress BGUGetIsInEditorPreview_WorldContextObject_PropertyAddress;

	private static int BGUGetIsInEditorPreview_WorldContextObject_Offset;

	private static bool BGUGetIsInEditorPreview_ReturnValue_IsValid;

	private static FFieldAddress BGUGetIsInEditorPreview_ReturnValue_PropertyAddress;

	private static int BGUGetIsInEditorPreview_ReturnValue_Offset;

	private static bool BGUGetIsEditor_IsValid;

	private static IntPtr BGUGetIsEditor_FunctionAddress;

	private static int BGUGetIsEditor_ParamsSize;

	private static bool BGUGetIsEditor_ReturnValue_IsValid;

	private static FFieldAddress BGUGetIsEditor_ReturnValue_PropertyAddress;

	private static int BGUGetIsEditor_ReturnValue_Offset;

	private static bool BGUGetIsBuildShipping_IsValid;

	private static IntPtr BGUGetIsBuildShipping_FunctionAddress;

	private static int BGUGetIsBuildShipping_ParamsSize;

	private static bool BGUGetIsBuildShipping_ReturnValue_IsValid;

	private static FFieldAddress BGUGetIsBuildShipping_ReturnValue_PropertyAddress;

	private static int BGUGetIsBuildShipping_ReturnValue_Offset;

	private static bool BGUGetFloatValueTableRow_IsValid;

	private static IntPtr BGUGetFloatValueTableRow_FunctionAddress;

	private static int BGUGetFloatValueTableRow_ParamsSize;

	private static bool BGUGetFloatValueTableRow_DataTable_IsValid;

	private static FFieldAddress BGUGetFloatValueTableRow_DataTable_PropertyAddress;

	private static int BGUGetFloatValueTableRow_DataTable_Offset;

	private static bool BGUGetFloatValueTableRow_RowName_IsValid;

	private static FFieldAddress BGUGetFloatValueTableRow_RowName_PropertyAddress;

	private static int BGUGetFloatValueTableRow_RowName_Offset;

	private static bool BGUGetFloatValueTableRow_Result_IsValid;

	private static FFieldAddress BGUGetFloatValueTableRow_Result_PropertyAddress;

	private static int BGUGetFloatValueTableRow_Result_Offset;

	private static bool BGUGetFloatValueTableRow_ContextString_IsValid;

	private static FFieldAddress BGUGetFloatValueTableRow_ContextString_PropertyAddress;

	private static int BGUGetFloatValueTableRow_ContextString_Offset;

	private static bool BGUGetFloatValueTableRow_bWarnIfRowMissing_IsValid;

	private static FFieldAddress BGUGetFloatValueTableRow_bWarnIfRowMissing_PropertyAddress;

	private static int BGUGetFloatValueTableRow_bWarnIfRowMissing_Offset;

	private static bool BGUGetFloatValueTableRow_ReturnValue_IsValid;

	private static FFieldAddress BGUGetFloatValueTableRow_ReturnValue_PropertyAddress;

	private static int BGUGetFloatValueTableRow_ReturnValue_Offset;

	private static bool BGUGetCurrentTime_IsValid;

	private static IntPtr BGUGetCurrentTime_FunctionAddress;

	private static int BGUGetCurrentTime_ParamsSize;

	private static bool BGUGetCurrentTime_WorldContextObject_IsValid;

	private static FFieldAddress BGUGetCurrentTime_WorldContextObject_PropertyAddress;

	private static int BGUGetCurrentTime_WorldContextObject_Offset;

	private static bool BGUGetCurrentTime_IsValid_IsValid;

	private static FFieldAddress BGUGetCurrentTime_IsValid_PropertyAddress;

	private static int BGUGetCurrentTime_IsValid_Offset;

	private static bool BGUGetCurrentTime_ReturnValue_IsValid;

	private static FFieldAddress BGUGetCurrentTime_ReturnValue_PropertyAddress;

	private static int BGUGetCurrentTime_ReturnValue_Offset;

	private static bool BGUGetCurActiveMontageInstID_IsValid;

	private static IntPtr BGUGetCurActiveMontageInstID_FunctionAddress;

	private static int BGUGetCurActiveMontageInstID_ParamsSize;

	private static bool BGUGetCurActiveMontageInstID_AnimInstance_IsValid;

	private static FFieldAddress BGUGetCurActiveMontageInstID_AnimInstance_PropertyAddress;

	private static int BGUGetCurActiveMontageInstID_AnimInstance_Offset;

	private static bool BGUGetCurActiveMontageInstID_ReturnValue_IsValid;

	private static FFieldAddress BGUGetCurActiveMontageInstID_ReturnValue_PropertyAddress;

	private static int BGUGetCurActiveMontageInstID_ReturnValue_Offset;

	private static bool BGUGetBounds_IsValid;

	private static IntPtr BGUGetBounds_FunctionAddress;

	private static int BGUGetBounds_ParamsSize;

	private static bool BGUGetBounds_PrimComp_IsValid;

	private static FFieldAddress BGUGetBounds_PrimComp_PropertyAddress;

	private static int BGUGetBounds_PrimComp_Offset;

	private static bool BGUGetBounds_Origin_IsValid;

	private static FFieldAddress BGUGetBounds_Origin_PropertyAddress;

	private static int BGUGetBounds_Origin_Offset;

	private static bool BGUGetBounds_BoxExtent_IsValid;

	private static FFieldAddress BGUGetBounds_BoxExtent_PropertyAddress;

	private static int BGUGetBounds_BoxExtent_Offset;

	private static bool BGUGetBodyRadius_IsValid;

	private static IntPtr BGUGetBodyRadius_FunctionAddress;

	private static int BGUGetBodyRadius_ParamsSize;

	private static bool BGUGetBodyRadius_SkMeshComp_IsValid;

	private static FFieldAddress BGUGetBodyRadius_SkMeshComp_PropertyAddress;

	private static int BGUGetBodyRadius_SkMeshComp_Offset;

	private static bool BGUGetBodyRadius_BoneName_IsValid;

	private static FFieldAddress BGUGetBodyRadius_BoneName_PropertyAddress;

	private static int BGUGetBodyRadius_BoneName_Offset;

	private static bool BGUGetBodyRadius_bGetWelded_IsValid;

	private static FFieldAddress BGUGetBodyRadius_bGetWelded_PropertyAddress;

	private static int BGUGetBodyRadius_bGetWelded_Offset;

	private static bool BGUGetBodyRadius_ReturnValue_IsValid;

	private static FFieldAddress BGUGetBodyRadius_ReturnValue_PropertyAddress;

	private static int BGUGetBodyRadius_ReturnValue_Offset;

	private static bool BGUGetAllActorsFromGroupActor_IsValid;

	private static IntPtr BGUGetAllActorsFromGroupActor_FunctionAddress;

	private static int BGUGetAllActorsFromGroupActor_ParamsSize;

	private static bool BGUGetAllActorsFromGroupActor_GroupActor_IsValid;

	private static FFieldAddress BGUGetAllActorsFromGroupActor_GroupActor_PropertyAddress;

	private static int BGUGetAllActorsFromGroupActor_GroupActor_Offset;

	private static bool BGUGetAllActorsFromGroupActor_bRecurse_IsValid;

	private static FFieldAddress BGUGetAllActorsFromGroupActor_bRecurse_PropertyAddress;

	private static int BGUGetAllActorsFromGroupActor_bRecurse_Offset;

	private static bool BGUGetAllActorsFromGroupActor_ReturnValue_IsValid;

	private static FFieldAddress BGUGetAllActorsFromGroupActor_ReturnValue_PropertyAddress;

	private static int BGUGetAllActorsFromGroupActor_ReturnValue_Offset;

	private static bool BGUGetAIStimulusWasSuccessfullySensed_IsValid;

	private static IntPtr BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress;

	private static int BGUGetAIStimulusWasSuccessfullySensed_ParamsSize;

	private static bool BGUGetAIStimulusWasSuccessfullySensed_Stimulus_IsValid;

	private static FFieldAddress BGUGetAIStimulusWasSuccessfullySensed_Stimulus_PropertyAddress;

	private static int BGUGetAIStimulusWasSuccessfullySensed_Stimulus_Offset;

	private static bool BGUGetAIStimulusWasSuccessfullySensed_ReturnValue_IsValid;

	private static FFieldAddress BGUGetAIStimulusWasSuccessfullySensed_ReturnValue_PropertyAddress;

	private static int BGUGetAIStimulusWasSuccessfullySensed_ReturnValue_Offset;

	private static bool BGUGetActorLevelName_IsValid;

	private static IntPtr BGUGetActorLevelName_FunctionAddress;

	private static int BGUGetActorLevelName_ParamsSize;

	private static bool BGUGetActorLevelName_Unit_IsValid;

	private static FFieldAddress BGUGetActorLevelName_Unit_PropertyAddress;

	private static int BGUGetActorLevelName_Unit_Offset;

	private static bool BGUGetActorLevelName_ReturnValue_IsValid;

	private static FFieldAddress BGUGetActorLevelName_ReturnValue_PropertyAddress;

	private static int BGUGetActorLevelName_ReturnValue_Offset;

	private static bool BGUExceutePyCode_IsValid;

	private static IntPtr BGUExceutePyCode_FunctionAddress;

	private static int BGUExceutePyCode_ParamsSize;

	private static bool BGUExceutePyCode_PyPath_IsValid;

	private static FFieldAddress BGUExceutePyCode_PyPath_PropertyAddress;

	private static int BGUExceutePyCode_PyPath_Offset;

	private static bool BGUEnableActorTick_IsValid;

	private static IntPtr BGUEnableActorTick_FunctionAddress;

	private static int BGUEnableActorTick_ParamsSize;

	private static bool BGUEnableActorTick_Actor_IsValid;

	private static FFieldAddress BGUEnableActorTick_Actor_PropertyAddress;

	private static int BGUEnableActorTick_Actor_Offset;

	private static bool BGUEnableActorTick_bEnable_IsValid;

	private static FFieldAddress BGUEnableActorTick_bEnable_PropertyAddress;

	private static int BGUEnableActorTick_bEnable_Offset;

	private static bool BguDrawSweepCheckShapeWithColor_IsValid;

	private static IntPtr BguDrawSweepCheckShapeWithColor_FunctionAddress;

	private static int BguDrawSweepCheckShapeWithColor_ParamsSize;

	private static bool BguDrawSweepCheckShapeWithColor_World_IsValid;

	private static FFieldAddress BguDrawSweepCheckShapeWithColor_World_PropertyAddress;

	private static int BguDrawSweepCheckShapeWithColor_World_Offset;

	private static bool BguDrawSweepCheckShapeWithColor_CenterPos_IsValid;

	private static FFieldAddress BguDrawSweepCheckShapeWithColor_CenterPos_PropertyAddress;

	private static int BguDrawSweepCheckShapeWithColor_CenterPos_Offset;

	private static bool BguDrawSweepCheckShapeWithColor_Rot_IsValid;

	private static FFieldAddress BguDrawSweepCheckShapeWithColor_Rot_PropertyAddress;

	private static int BguDrawSweepCheckShapeWithColor_Rot_Offset;

	private static bool BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_IsValid;

	private static FFieldAddress BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_PropertyAddress;

	private static int BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_Offset;

	private static bool BguDrawSweepCheckShapeWithColor_Color_IsValid;

	private static FFieldAddress BguDrawSweepCheckShapeWithColor_Color_PropertyAddress;

	private static int BguDrawSweepCheckShapeWithColor_Color_Offset;

	private static bool BGUDrawSweepCheckShape_IsValid;

	private static IntPtr BGUDrawSweepCheckShape_FunctionAddress;

	private static int BGUDrawSweepCheckShape_ParamsSize;

	private static bool BGUDrawSweepCheckShape_World_IsValid;

	private static FFieldAddress BGUDrawSweepCheckShape_World_PropertyAddress;

	private static int BGUDrawSweepCheckShape_World_Offset;

	private static bool BGUDrawSweepCheckShape_CenterPos_IsValid;

	private static FFieldAddress BGUDrawSweepCheckShape_CenterPos_PropertyAddress;

	private static int BGUDrawSweepCheckShape_CenterPos_Offset;

	private static bool BGUDrawSweepCheckShape_Rot_IsValid;

	private static FFieldAddress BGUDrawSweepCheckShape_Rot_PropertyAddress;

	private static int BGUDrawSweepCheckShape_Rot_Offset;

	private static bool BGUDrawSweepCheckShape_SweepCheckShapeInfo_IsValid;

	private static FFieldAddress BGUDrawSweepCheckShape_SweepCheckShapeInfo_PropertyAddress;

	private static int BGUDrawSweepCheckShape_SweepCheckShapeInfo_Offset;

	private static bool BguDrawSphereSweepWithColor_IsValid;

	private static IntPtr BguDrawSphereSweepWithColor_FunctionAddress;

	private static int BguDrawSphereSweepWithColor_ParamsSize;

	private static bool BguDrawSphereSweepWithColor_World_IsValid;

	private static FFieldAddress BguDrawSphereSweepWithColor_World_PropertyAddress;

	private static int BguDrawSphereSweepWithColor_World_Offset;

	private static bool BguDrawSphereSweepWithColor_Start_IsValid;

	private static FFieldAddress BguDrawSphereSweepWithColor_Start_PropertyAddress;

	private static int BguDrawSphereSweepWithColor_Start_Offset;

	private static bool BguDrawSphereSweepWithColor_End_IsValid;

	private static FFieldAddress BguDrawSphereSweepWithColor_End_PropertyAddress;

	private static int BguDrawSphereSweepWithColor_End_Offset;

	private static bool BguDrawSphereSweepWithColor_Radius_IsValid;

	private static FFieldAddress BguDrawSphereSweepWithColor_Radius_PropertyAddress;

	private static int BguDrawSphereSweepWithColor_Radius_Offset;

	private static bool BguDrawSphereSweepWithColor_Color_IsValid;

	private static FFieldAddress BguDrawSphereSweepWithColor_Color_PropertyAddress;

	private static int BguDrawSphereSweepWithColor_Color_Offset;

	private static bool BGUDrawSphereSweep_IsValid;

	private static IntPtr BGUDrawSphereSweep_FunctionAddress;

	private static int BGUDrawSphereSweep_ParamsSize;

	private static bool BGUDrawSphereSweep_World_IsValid;

	private static FFieldAddress BGUDrawSphereSweep_World_PropertyAddress;

	private static int BGUDrawSphereSweep_World_Offset;

	private static bool BGUDrawSphereSweep_Start_IsValid;

	private static FFieldAddress BGUDrawSphereSweep_Start_PropertyAddress;

	private static int BGUDrawSphereSweep_Start_Offset;

	private static bool BGUDrawSphereSweep_End_IsValid;

	private static FFieldAddress BGUDrawSphereSweep_End_PropertyAddress;

	private static int BGUDrawSphereSweep_End_Offset;

	private static bool BGUDrawSphereSweep_Radius_IsValid;

	private static FFieldAddress BGUDrawSphereSweep_Radius_PropertyAddress;

	private static int BGUDrawSphereSweep_Radius_Offset;

	private static bool BGUDrawLineArrowEx_IsValid;

	private static IntPtr BGUDrawLineArrowEx_FunctionAddress;

	private static int BGUDrawLineArrowEx_ParamsSize;

	private static bool BGUDrawLineArrowEx_World_IsValid;

	private static FFieldAddress BGUDrawLineArrowEx_World_PropertyAddress;

	private static int BGUDrawLineArrowEx_World_Offset;

	private static bool BGUDrawLineArrowEx_LineStart_IsValid;

	private static FFieldAddress BGUDrawLineArrowEx_LineStart_PropertyAddress;

	private static int BGUDrawLineArrowEx_LineStart_Offset;

	private static bool BGUDrawLineArrowEx_LineEnd_IsValid;

	private static FFieldAddress BGUDrawLineArrowEx_LineEnd_PropertyAddress;

	private static int BGUDrawLineArrowEx_LineEnd_Offset;

	private static bool BGUDrawLineArrowEx_ArrowSize_IsValid;

	private static FFieldAddress BGUDrawLineArrowEx_ArrowSize_PropertyAddress;

	private static int BGUDrawLineArrowEx_ArrowSize_Offset;

	private static bool BGUDrawLineArrowEx_Color_IsValid;

	private static FFieldAddress BGUDrawLineArrowEx_Color_PropertyAddress;

	private static int BGUDrawLineArrowEx_Color_Offset;

	private static bool BGUDrawLineArrowEx_IsPersistentLines_IsValid;

	private static FFieldAddress BGUDrawLineArrowEx_IsPersistentLines_PropertyAddress;

	private static int BGUDrawLineArrowEx_IsPersistentLines_Offset;

	private static bool BGUDrawLineArrowEx_LifeTime_IsValid;

	private static FFieldAddress BGUDrawLineArrowEx_LifeTime_PropertyAddress;

	private static int BGUDrawLineArrowEx_LifeTime_Offset;

	private static bool BGUDrawLineArrow_IsValid;

	private static IntPtr BGUDrawLineArrow_FunctionAddress;

	private static int BGUDrawLineArrow_ParamsSize;

	private static bool BGUDrawLineArrow_World_IsValid;

	private static FFieldAddress BGUDrawLineArrow_World_PropertyAddress;

	private static int BGUDrawLineArrow_World_Offset;

	private static bool BGUDrawLineArrow_LineStart_IsValid;

	private static FFieldAddress BGUDrawLineArrow_LineStart_PropertyAddress;

	private static int BGUDrawLineArrow_LineStart_Offset;

	private static bool BGUDrawLineArrow_LineEnd_IsValid;

	private static FFieldAddress BGUDrawLineArrow_LineEnd_PropertyAddress;

	private static int BGUDrawLineArrow_LineEnd_Offset;

	private static bool BGUDrawLineArrow_ArrowSize_IsValid;

	private static FFieldAddress BGUDrawLineArrow_ArrowSize_PropertyAddress;

	private static int BGUDrawLineArrow_ArrowSize_Offset;

	private static bool BGUDrawDebugSphereEx_IsValid;

	private static IntPtr BGUDrawDebugSphereEx_FunctionAddress;

	private static int BGUDrawDebugSphereEx_ParamsSize;

	private static bool BGUDrawDebugSphereEx_World_IsValid;

	private static FFieldAddress BGUDrawDebugSphereEx_World_PropertyAddress;

	private static int BGUDrawDebugSphereEx_World_Offset;

	private static bool BGUDrawDebugSphereEx_CenterPos_IsValid;

	private static FFieldAddress BGUDrawDebugSphereEx_CenterPos_PropertyAddress;

	private static int BGUDrawDebugSphereEx_CenterPos_Offset;

	private static bool BGUDrawDebugSphereEx_Raidus_IsValid;

	private static FFieldAddress BGUDrawDebugSphereEx_Raidus_PropertyAddress;

	private static int BGUDrawDebugSphereEx_Raidus_Offset;

	private static bool BGUDrawDebugSphereEx_KeepTime_IsValid;

	private static FFieldAddress BGUDrawDebugSphereEx_KeepTime_PropertyAddress;

	private static int BGUDrawDebugSphereEx_KeepTime_Offset;

	private static bool BGUDrawDebugSphereEx_Color_IsValid;

	private static FFieldAddress BGUDrawDebugSphereEx_Color_PropertyAddress;

	private static int BGUDrawDebugSphereEx_Color_Offset;

	private static bool BGUDrawDebugSphere_IsValid;

	private static IntPtr BGUDrawDebugSphere_FunctionAddress;

	private static int BGUDrawDebugSphere_ParamsSize;

	private static bool BGUDrawDebugSphere_World_IsValid;

	private static FFieldAddress BGUDrawDebugSphere_World_PropertyAddress;

	private static int BGUDrawDebugSphere_World_Offset;

	private static bool BGUDrawDebugSphere_CenterPos_IsValid;

	private static FFieldAddress BGUDrawDebugSphere_CenterPos_PropertyAddress;

	private static int BGUDrawDebugSphere_CenterPos_Offset;

	private static bool BGUDrawDebugSphere_Raidus_IsValid;

	private static FFieldAddress BGUDrawDebugSphere_Raidus_PropertyAddress;

	private static int BGUDrawDebugSphere_Raidus_Offset;

	private static bool BGUDrawDebugRect_IsValid;

	private static IntPtr BGUDrawDebugRect_FunctionAddress;

	private static int BGUDrawDebugRect_ParamsSize;

	private static bool BGUDrawDebugRect_World_IsValid;

	private static FFieldAddress BGUDrawDebugRect_World_PropertyAddress;

	private static int BGUDrawDebugRect_World_Offset;

	private static bool BGUDrawDebugRect_CenterPos_IsValid;

	private static FFieldAddress BGUDrawDebugRect_CenterPos_PropertyAddress;

	private static int BGUDrawDebugRect_CenterPos_Offset;

	private static bool BGUDrawDebugRect_Direction_IsValid;

	private static FFieldAddress BGUDrawDebugRect_Direction_PropertyAddress;

	private static int BGUDrawDebugRect_Direction_Offset;

	private static bool BGUDrawDebugRect_Width_IsValid;

	private static FFieldAddress BGUDrawDebugRect_Width_PropertyAddress;

	private static int BGUDrawDebugRect_Width_Offset;

	private static bool BGUDrawDebugRect_Length_IsValid;

	private static FFieldAddress BGUDrawDebugRect_Length_PropertyAddress;

	private static int BGUDrawDebugRect_Length_Offset;

	private static bool BGUDrawDebugCircleEx_IsValid;

	private static IntPtr BGUDrawDebugCircleEx_FunctionAddress;

	private static int BGUDrawDebugCircleEx_ParamsSize;

	private static bool BGUDrawDebugCircleEx_World_IsValid;

	private static FFieldAddress BGUDrawDebugCircleEx_World_PropertyAddress;

	private static int BGUDrawDebugCircleEx_World_Offset;

	private static bool BGUDrawDebugCircleEx_CenterPos_IsValid;

	private static FFieldAddress BGUDrawDebugCircleEx_CenterPos_PropertyAddress;

	private static int BGUDrawDebugCircleEx_CenterPos_Offset;

	private static bool BGUDrawDebugCircleEx_Raidus_IsValid;

	private static FFieldAddress BGUDrawDebugCircleEx_Raidus_PropertyAddress;

	private static int BGUDrawDebugCircleEx_Raidus_Offset;

	private static bool BGUDrawDebugCircleEx_KeepTime_IsValid;

	private static FFieldAddress BGUDrawDebugCircleEx_KeepTime_PropertyAddress;

	private static int BGUDrawDebugCircleEx_KeepTime_Offset;

	private static bool BGUDrawDebugCircleEx_Color_IsValid;

	private static FFieldAddress BGUDrawDebugCircleEx_Color_PropertyAddress;

	private static int BGUDrawDebugCircleEx_Color_Offset;

	private static bool BGUDrawDebugCircle_IsValid;

	private static IntPtr BGUDrawDebugCircle_FunctionAddress;

	private static int BGUDrawDebugCircle_ParamsSize;

	private static bool BGUDrawDebugCircle_World_IsValid;

	private static FFieldAddress BGUDrawDebugCircle_World_PropertyAddress;

	private static int BGUDrawDebugCircle_World_Offset;

	private static bool BGUDrawDebugCircle_CenterPos_IsValid;

	private static FFieldAddress BGUDrawDebugCircle_CenterPos_PropertyAddress;

	private static int BGUDrawDebugCircle_CenterPos_Offset;

	private static bool BGUDrawDebugCircle_Raidus_IsValid;

	private static FFieldAddress BGUDrawDebugCircle_Raidus_PropertyAddress;

	private static int BGUDrawDebugCircle_Raidus_Offset;

	private static bool BGUDrawDebugAnnularSector_IsValid;

	private static IntPtr BGUDrawDebugAnnularSector_FunctionAddress;

	private static int BGUDrawDebugAnnularSector_ParamsSize;

	private static bool BGUDrawDebugAnnularSector_World_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_World_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_World_Offset;

	private static bool BGUDrawDebugAnnularSector_CenterPos_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_CenterPos_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_CenterPos_Offset;

	private static bool BGUDrawDebugAnnularSector_Direction_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_Direction_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_Direction_Offset;

	private static bool BGUDrawDebugAnnularSector_InnerRadius_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_InnerRadius_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_InnerRadius_Offset;

	private static bool BGUDrawDebugAnnularSector_OuterRadius_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_OuterRadius_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_OuterRadius_Offset;

	private static bool BGUDrawDebugAnnularSector_HalfAngle_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_HalfAngle_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_HalfAngle_Offset;

	private static bool BGUDrawDebugAnnularSector_Color_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_Color_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_Color_Offset;

	private static bool BGUDrawDebugAnnularSector_Duration_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_Duration_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_Duration_Offset;

	private static bool BGUDrawDebugAnnularSector_Thickness_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_Thickness_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_Thickness_Offset;

	private static bool BGUDrawDebugAnnularSector_Segments_IsValid;

	private static FFieldAddress BGUDrawDebugAnnularSector_Segments_PropertyAddress;

	private static int BGUDrawDebugAnnularSector_Segments_Offset;

	private static bool BGUCreateLandscapeHeightMap_IsValid;

	private static IntPtr BGUCreateLandscapeHeightMap_FunctionAddress;

	private static int BGUCreateLandscapeHeightMap_ParamsSize;

	private static bool BGUCreateLandscapeHeightMap_Landscape_IsValid;

	private static FFieldAddress BGUCreateLandscapeHeightMap_Landscape_PropertyAddress;

	private static int BGUCreateLandscapeHeightMap_Landscape_Offset;

	private static bool BGUCreateLandscapeHeightMap_PackageName_IsValid;

	private static FFieldAddress BGUCreateLandscapeHeightMap_PackageName_PropertyAddress;

	private static int BGUCreateLandscapeHeightMap_PackageName_Offset;

	private static bool BGUCreateLandscapeHeightMap_AssetName_IsValid;

	private static FFieldAddress BGUCreateLandscapeHeightMap_AssetName_PropertyAddress;

	private static int BGUCreateLandscapeHeightMap_AssetName_Offset;

	private static bool BGUCreateLandscapeHeightMap_ReturnValue_IsValid;

	private static FFieldAddress BGUCreateLandscapeHeightMap_ReturnValue_PropertyAddress;

	private static int BGUCreateLandscapeHeightMap_ReturnValue_Offset;

	private static bool BGUComputeActorHitMovePenetration_IsValid;

	private static IntPtr BGUComputeActorHitMovePenetration_FunctionAddress;

	private static int BGUComputeActorHitMovePenetration_ParamsSize;

	private static bool BGUComputeActorHitMovePenetration_SelfActor_IsValid;

	private static FFieldAddress BGUComputeActorHitMovePenetration_SelfActor_PropertyAddress;

	private static int BGUComputeActorHitMovePenetration_SelfActor_Offset;

	private static bool BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_IsValid;

	private static FFieldAddress BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_PropertyAddress;

	private static int BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_Offset;

	private static bool BGUComputeActorHitMovePenetration_SelfWeight_IsValid;

	private static FFieldAddress BGUComputeActorHitMovePenetration_SelfWeight_PropertyAddress;

	private static int BGUComputeActorHitMovePenetration_SelfWeight_Offset;

	private static bool BGUComputeActorHitMovePenetration_PlaneNormalVector_IsValid;

	private static FFieldAddress BGUComputeActorHitMovePenetration_PlaneNormalVector_PropertyAddress;

	private static int BGUComputeActorHitMovePenetration_PlaneNormalVector_Offset;

	private static bool BGUComputeActorHitMovePenetration_MaxComputeRound_IsValid;

	private static FFieldAddress BGUComputeActorHitMovePenetration_MaxComputeRound_PropertyAddress;

	private static int BGUComputeActorHitMovePenetration_MaxComputeRound_Offset;

	private static bool BGUComputeActorHitMovePenetration_Epsilon_IsValid;

	private static FFieldAddress BGUComputeActorHitMovePenetration_Epsilon_PropertyAddress;

	private static int BGUComputeActorHitMovePenetration_Epsilon_Offset;

	private static bool BGUComputeActorHitMovePenetration_ReturnValue_IsValid;

	private static FFieldAddress BGUComputeActorHitMovePenetration_ReturnValue_PropertyAddress;

	private static int BGUComputeActorHitMovePenetration_ReturnValue_Offset;

	private static bool BGUBindOnSetLevelsStateFinished_IsValid;

	private static IntPtr BGUBindOnSetLevelsStateFinished_FunctionAddress;

	private static int BGUBindOnSetLevelsStateFinished_ParamsSize;

	private static bool BGUBindOnSetLevelsStateFinished_Obj_IsValid;

	private static FFieldAddress BGUBindOnSetLevelsStateFinished_Obj_PropertyAddress;

	private static int BGUBindOnSetLevelsStateFinished_Obj_Offset;

	private static bool BGUBindOnSetLevelsStateFinished_FuncName_IsValid;

	private static FFieldAddress BGUBindOnSetLevelsStateFinished_FuncName_PropertyAddress;

	private static int BGUBindOnSetLevelsStateFinished_FuncName_Offset;

	private static bool BGUBindOnComponentHitEvent_IsValid;

	private static IntPtr BGUBindOnComponentHitEvent_FunctionAddress;

	private static int BGUBindOnComponentHitEvent_ParamsSize;

	private static bool BGUBindOnComponentHitEvent_Comp_IsValid;

	private static FFieldAddress BGUBindOnComponentHitEvent_Comp_PropertyAddress;

	private static int BGUBindOnComponentHitEvent_Comp_Offset;

	private static bool BGUBindOnComponentHitEvent_Obj_IsValid;

	private static FFieldAddress BGUBindOnComponentHitEvent_Obj_PropertyAddress;

	private static int BGUBindOnComponentHitEvent_Obj_Offset;

	private static bool BGUBindOnComponentHitEvent_Func_IsValid;

	private static FFieldAddress BGUBindOnComponentHitEvent_Func_PropertyAddress;

	private static int BGUBindOnComponentHitEvent_Func_Offset;

	private static bool BGUBindOnComponentEndOverlapEvent_IsValid;

	private static IntPtr BGUBindOnComponentEndOverlapEvent_FunctionAddress;

	private static int BGUBindOnComponentEndOverlapEvent_ParamsSize;

	private static bool BGUBindOnComponentEndOverlapEvent_Comp_IsValid;

	private static FFieldAddress BGUBindOnComponentEndOverlapEvent_Comp_PropertyAddress;

	private static int BGUBindOnComponentEndOverlapEvent_Comp_Offset;

	private static bool BGUBindOnComponentEndOverlapEvent_Obj_IsValid;

	private static FFieldAddress BGUBindOnComponentEndOverlapEvent_Obj_PropertyAddress;

	private static int BGUBindOnComponentEndOverlapEvent_Obj_Offset;

	private static bool BGUBindOnComponentEndOverlapEvent_FuncName_IsValid;

	private static FFieldAddress BGUBindOnComponentEndOverlapEvent_FuncName_PropertyAddress;

	private static int BGUBindOnComponentEndOverlapEvent_FuncName_Offset;

	private static bool BGUBindOnComponentBeginOverlapEvent_IsValid;

	private static IntPtr BGUBindOnComponentBeginOverlapEvent_FunctionAddress;

	private static int BGUBindOnComponentBeginOverlapEvent_ParamsSize;

	private static bool BGUBindOnComponentBeginOverlapEvent_Comp_IsValid;

	private static FFieldAddress BGUBindOnComponentBeginOverlapEvent_Comp_PropertyAddress;

	private static int BGUBindOnComponentBeginOverlapEvent_Comp_Offset;

	private static bool BGUBindOnComponentBeginOverlapEvent_Obj_IsValid;

	private static FFieldAddress BGUBindOnComponentBeginOverlapEvent_Obj_PropertyAddress;

	private static int BGUBindOnComponentBeginOverlapEvent_Obj_Offset;

	private static bool BGUBindOnComponentBeginOverlapEvent_FuncName_IsValid;

	private static FFieldAddress BGUBindOnComponentBeginOverlapEvent_FuncName_PropertyAddress;

	private static int BGUBindOnComponentBeginOverlapEvent_FuncName_Offset;

	private static bool BGUBindOnAllSetLevelsStateFinished_IsValid;

	private static IntPtr BGUBindOnAllSetLevelsStateFinished_FunctionAddress;

	private static int BGUBindOnAllSetLevelsStateFinished_ParamsSize;

	private static bool BGUBindOnAllSetLevelsStateFinished_Obj_IsValid;

	private static FFieldAddress BGUBindOnAllSetLevelsStateFinished_Obj_PropertyAddress;

	private static int BGUBindOnAllSetLevelsStateFinished_Obj_Offset;

	private static bool BGUBindOnAllSetLevelsStateFinished_FuncName_IsValid;

	private static FFieldAddress BGUBindOnAllSetLevelsStateFinished_FuncName_PropertyAddress;

	private static int BGUBindOnAllSetLevelsStateFinished_FuncName_Offset;

	private static bool BGUBindOnActorEndOverlapEvent_IsValid;

	private static IntPtr BGUBindOnActorEndOverlapEvent_FunctionAddress;

	private static int BGUBindOnActorEndOverlapEvent_ParamsSize;

	private static bool BGUBindOnActorEndOverlapEvent_Actor_IsValid;

	private static FFieldAddress BGUBindOnActorEndOverlapEvent_Actor_PropertyAddress;

	private static int BGUBindOnActorEndOverlapEvent_Actor_Offset;

	private static bool BGUBindOnActorEndOverlapEvent_Obj_IsValid;

	private static FFieldAddress BGUBindOnActorEndOverlapEvent_Obj_PropertyAddress;

	private static int BGUBindOnActorEndOverlapEvent_Obj_Offset;

	private static bool BGUBindOnActorEndOverlapEvent_FuncName_IsValid;

	private static FFieldAddress BGUBindOnActorEndOverlapEvent_FuncName_PropertyAddress;

	private static int BGUBindOnActorEndOverlapEvent_FuncName_Offset;

	private static bool BGUBindOnActorBeginOverlapEvent_IsValid;

	private static IntPtr BGUBindOnActorBeginOverlapEvent_FunctionAddress;

	private static int BGUBindOnActorBeginOverlapEvent_ParamsSize;

	private static bool BGUBindOnActorBeginOverlapEvent_Actor_IsValid;

	private static FFieldAddress BGUBindOnActorBeginOverlapEvent_Actor_PropertyAddress;

	private static int BGUBindOnActorBeginOverlapEvent_Actor_Offset;

	private static bool BGUBindOnActorBeginOverlapEvent_Obj_IsValid;

	private static FFieldAddress BGUBindOnActorBeginOverlapEvent_Obj_PropertyAddress;

	private static int BGUBindOnActorBeginOverlapEvent_Obj_Offset;

	private static bool BGUBindOnActorBeginOverlapEvent_FuncName_IsValid;

	private static FFieldAddress BGUBindOnActorBeginOverlapEvent_FuncName_PropertyAddress;

	private static int BGUBindOnActorBeginOverlapEvent_FuncName_Offset;

	private static bool AddNotifyPreloadedAsset_IsValid;

	private static IntPtr AddNotifyPreloadedAsset_FunctionAddress;

	private static int AddNotifyPreloadedAsset_ParamsSize;

	private static bool AddNotifyPreloadedAsset_Notify_IsValid;

	private static FFieldAddress AddNotifyPreloadedAsset_Notify_PropertyAddress;

	private static int AddNotifyPreloadedAsset_Notify_Offset;

	private static bool AddNotifyPreloadedAsset_Asset_IsValid;

	private static FFieldAddress AddNotifyPreloadedAsset_Asset_PropertyAddress;

	private static int AddNotifyPreloadedAsset_Asset_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:ValidateMontagesForCrossSectionNS")]
	public unsafe static void ValidateMontagesForCrossSectionNS(string ResourcePath)
	{
		if (!ValidateMontagesForCrossSectionNS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:ValidateMontagesForCrossSectionNS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ValidateMontagesForCrossSectionNS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ValidateMontagesForCrossSectionNS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ValidateMontagesForCrossSectionNS_ResourcePath_Offset), 0, ValidateMontagesForCrossSectionNS_ResourcePath_PropertyAddress.Address, ResourcePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ValidateMontagesForCrossSectionNS_FunctionAddress, intPtr, ValidateMontagesForCrossSectionNS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ValidateMontagesForCrossSectionNS_ResourcePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:RequestGameplayTag")]
	public unsafe static FGameplayTag RequestGameplayTag(FName TagName, bool ErrorIfNotFound = true)
	{
		if (!RequestGameplayTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:RequestGameplayTag");
			return default(FGameplayTag);
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestGameplayTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestGameplayTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RequestGameplayTag_TagName_Offset), 0, RequestGameplayTag_TagName_PropertyAddress.Address, TagName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestGameplayTag_ErrorIfNotFound_Offset), 0, RequestGameplayTag_ErrorIfNotFound_PropertyAddress.Address, ErrorIfNotFound);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestGameplayTag_FunctionAddress, intPtr, RequestGameplayTag_ParamsSize);
		return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(intPtr, RequestGameplayTag_ReturnValue_Offset), 0, RequestGameplayTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:RemoveAllQueriesByQuerier")]
	public unsafe static void RemoveAllQueriesByQuerier(UObject Querier)
	{
		if (!RemoveAllQueriesByQuerier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:RemoveAllQueriesByQuerier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllQueriesByQuerier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllQueriesByQuerier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveAllQueriesByQuerier_Querier_Offset), 0, RemoveAllQueriesByQuerier_Querier_PropertyAddress.Address, Querier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllQueriesByQuerier_FunctionAddress, intPtr, RemoveAllQueriesByQuerier_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:CopyProceduralMeshFromStaticMeshComponent")]
	public unsafe static void CopyProceduralMeshFromStaticMeshComponent(UStaticMeshComponent StaticMeshComponent, int LODIndex, UProceduralMeshComponent ProcMeshComponent, bool bCreateCollision)
	{
		if (!CopyProceduralMeshFromStaticMeshComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:CopyProceduralMeshFromStaticMeshComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyProceduralMeshFromStaticMeshComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyProceduralMeshFromStaticMeshComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_Offset), 0, CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_PropertyAddress.Address, StaticMeshComponent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CopyProceduralMeshFromStaticMeshComponent_LODIndex_Offset), 0, CopyProceduralMeshFromStaticMeshComponent_LODIndex_PropertyAddress.Address, LODIndex);
		UObjectMarshaler<UProceduralMeshComponent>.ToNative(IntPtr.Add(intPtr, CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_Offset), 0, CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_PropertyAddress.Address, ProcMeshComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_Offset), 0, CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_PropertyAddress.Address, bCreateCollision);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, intPtr, CopyProceduralMeshFromStaticMeshComponent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:ConvertTraceTypeToCollisionChannel")]
	public unsafe static ECollisionChannel ConvertTraceTypeToCollisionChannel(ETraceTypeQuery TraceType)
	{
		if (!ConvertTraceTypeToCollisionChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:ConvertTraceTypeToCollisionChannel");
			return ECollisionChannel.ECC_WorldStatic;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertTraceTypeToCollisionChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertTraceTypeToCollisionChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(intPtr, ConvertTraceTypeToCollisionChannel_TraceType_Offset), 0, ConvertTraceTypeToCollisionChannel_TraceType_PropertyAddress.Address, TraceType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertTraceTypeToCollisionChannel_FunctionAddress, intPtr, ConvertTraceTypeToCollisionChannel_ParamsSize);
		return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(intPtr, ConvertTraceTypeToCollisionChannel_ReturnValue_Offset), 0, ConvertTraceTypeToCollisionChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:ConvertToTraceType")]
	public unsafe static ETraceTypeQuery ConvertToTraceType(ECollisionChannel CollisionChannel)
	{
		if (!ConvertToTraceType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:ConvertToTraceType");
			return ETraceTypeQuery.TraceTypeQuery1;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToTraceType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToTraceType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, ConvertToTraceType_CollisionChannel_Offset), 0, ConvertToTraceType_CollisionChannel_PropertyAddress.Address, CollisionChannel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToTraceType_FunctionAddress, intPtr, ConvertToTraceType_ParamsSize);
		return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(intPtr, ConvertToTraceType_ReturnValue_Offset), 0, ConvertToTraceType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:ConvertToObjectType")]
	public unsafe static EObjectTypeQuery ConvertToObjectType(ECollisionChannel CollisionChannel)
	{
		if (!ConvertToObjectType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:ConvertToObjectType");
			return EObjectTypeQuery.ObjectTypeQuery1;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToObjectType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToObjectType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, ConvertToObjectType_CollisionChannel_Offset), 0, ConvertToObjectType_CollisionChannel_PropertyAddress.Address, CollisionChannel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToObjectType_FunctionAddress, intPtr, ConvertToObjectType_ParamsSize);
		return EnumMarshaler<EObjectTypeQuery>.FromNative(IntPtr.Add(intPtr, ConvertToObjectType_ReturnValue_Offset), 0, ConvertToObjectType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:ConvertObjectTypeToCollisionChannel")]
	public unsafe static ECollisionChannel ConvertObjectTypeToCollisionChannel(EObjectTypeQuery ObjectType)
	{
		if (!ConvertObjectTypeToCollisionChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:ConvertObjectTypeToCollisionChannel");
			return ECollisionChannel.ECC_WorldStatic;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertObjectTypeToCollisionChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertObjectTypeToCollisionChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EObjectTypeQuery>.ToNative(IntPtr.Add(intPtr, ConvertObjectTypeToCollisionChannel_ObjectType_Offset), 0, ConvertObjectTypeToCollisionChannel_ObjectType_PropertyAddress.Address, ObjectType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertObjectTypeToCollisionChannel_FunctionAddress, intPtr, ConvertObjectTypeToCollisionChannel_ParamsSize);
		return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(intPtr, ConvertObjectTypeToCollisionChannel_ReturnValue_Offset), 0, ConvertObjectTypeToCollisionChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:CompForceUpdateOverlaps")]
	public unsafe static bool CompForceUpdateOverlaps(UPrimitiveComponent Comp, bool bDoNotifies = true)
	{
		if (!CompForceUpdateOverlaps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:CompForceUpdateOverlaps");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompForceUpdateOverlaps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompForceUpdateOverlaps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, CompForceUpdateOverlaps_Comp_Offset), 0, CompForceUpdateOverlaps_Comp_PropertyAddress.Address, Comp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CompForceUpdateOverlaps_bDoNotifies_Offset), 0, CompForceUpdateOverlaps_bDoNotifies_PropertyAddress.Address, bDoNotifies);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CompForceUpdateOverlaps_FunctionAddress, intPtr, CompForceUpdateOverlaps_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CompForceUpdateOverlaps_ReturnValue_Offset), 0, CompForceUpdateOverlaps_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:CallSectionManuallyChangeOnCrossSectionNotifies")]
	public unsafe static void CallSectionManuallyChangeOnCrossSectionNotifies(ABGUCharacter OwnerChar, FName NewSectionName)
	{
		if (!CallSectionManuallyChangeOnCrossSectionNotifies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:CallSectionManuallyChangeOnCrossSectionNotifies");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CallSectionManuallyChangeOnCrossSectionNotifies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CallSectionManuallyChangeOnCrossSectionNotifies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, CallSectionManuallyChangeOnCrossSectionNotifies_OwnerChar_Offset), 0, CallSectionManuallyChangeOnCrossSectionNotifies_OwnerChar_PropertyAddress.Address, OwnerChar);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CallSectionManuallyChangeOnCrossSectionNotifies_NewSectionName_Offset), 0, CallSectionManuallyChangeOnCrossSectionNotifies_NewSectionName_PropertyAddress.Address, NewSectionName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress, intPtr, CallSectionManuallyChangeOnCrossSectionNotifies_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnSetLevelsStateFinished")]
	public unsafe static void BGUUnBindOnSetLevelsStateFinished(UObject Obj, FName FuncName)
	{
		if (!BGUUnBindOnSetLevelsStateFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnSetLevelsStateFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUnBindOnSetLevelsStateFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUnBindOnSetLevelsStateFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnSetLevelsStateFinished_Obj_Offset), 0, BGUUnBindOnSetLevelsStateFinished_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnSetLevelsStateFinished_FuncName_Offset), 0, BGUUnBindOnSetLevelsStateFinished_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUnBindOnSetLevelsStateFinished_FunctionAddress, intPtr, BGUUnBindOnSetLevelsStateFinished_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnComponentHitEvent")]
	public unsafe static void BGUUnBindOnComponentHitEvent(UPrimitiveComponent Comp, UObject Obj, FName Func)
	{
		if (!BGUUnBindOnComponentHitEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnComponentHitEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUnBindOnComponentHitEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUnBindOnComponentHitEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnComponentHitEvent_Comp_Offset), 0, BGUUnBindOnComponentHitEvent_Comp_PropertyAddress.Address, Comp);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnComponentHitEvent_Obj_Offset), 0, BGUUnBindOnComponentHitEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnComponentHitEvent_Func_Offset), 0, BGUUnBindOnComponentHitEvent_Func_PropertyAddress.Address, Func);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUnBindOnComponentHitEvent_FunctionAddress, intPtr, BGUUnBindOnComponentHitEvent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnComponentEndOverlapEvent")]
	public unsafe static void BGUUnBindOnComponentEndOverlapEvent(UPrimitiveComponent Comp, UObject Obj, FName FuncName)
	{
		if (!BGUUnBindOnComponentEndOverlapEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnComponentEndOverlapEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUnBindOnComponentEndOverlapEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUnBindOnComponentEndOverlapEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnComponentEndOverlapEvent_Comp_Offset), 0, BGUUnBindOnComponentEndOverlapEvent_Comp_PropertyAddress.Address, Comp);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnComponentEndOverlapEvent_Obj_Offset), 0, BGUUnBindOnComponentEndOverlapEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnComponentEndOverlapEvent_FuncName_Offset), 0, BGUUnBindOnComponentEndOverlapEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, intPtr, BGUUnBindOnComponentEndOverlapEvent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnComponentBeginOverlapEvent")]
	public unsafe static void BGUUnBindOnComponentBeginOverlapEvent(UPrimitiveComponent Comp, UObject Obj, FName FuncName)
	{
		if (!BGUUnBindOnComponentBeginOverlapEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnComponentBeginOverlapEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUnBindOnComponentBeginOverlapEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUnBindOnComponentBeginOverlapEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnComponentBeginOverlapEvent_Comp_Offset), 0, BGUUnBindOnComponentBeginOverlapEvent_Comp_PropertyAddress.Address, Comp);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnComponentBeginOverlapEvent_Obj_Offset), 0, BGUUnBindOnComponentBeginOverlapEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnComponentBeginOverlapEvent_FuncName_Offset), 0, BGUUnBindOnComponentBeginOverlapEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, intPtr, BGUUnBindOnComponentBeginOverlapEvent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnAllSetLevelsStateFinished")]
	public unsafe static void BGUUnBindOnAllSetLevelsStateFinished(UObject Obj, FName FuncName)
	{
		if (!BGUUnBindOnAllSetLevelsStateFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnAllSetLevelsStateFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUnBindOnAllSetLevelsStateFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUnBindOnAllSetLevelsStateFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnAllSetLevelsStateFinished_Obj_Offset), 0, BGUUnBindOnAllSetLevelsStateFinished_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnAllSetLevelsStateFinished_FuncName_Offset), 0, BGUUnBindOnAllSetLevelsStateFinished_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress, intPtr, BGUUnBindOnAllSetLevelsStateFinished_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUTeleportTo")]
	public unsafe static bool BGUTeleportTo(AActor Owner, FVector DestLocation, FRotator DestRotation, bool bIsATest = false, bool bNoCheck = false)
	{
		if (!BGUTeleportTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUTeleportTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUTeleportTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUTeleportTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUTeleportTo_Owner_Offset), 0, BGUTeleportTo_Owner_PropertyAddress.Address, Owner);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUTeleportTo_DestLocation_Offset), 0, BGUTeleportTo_DestLocation_PropertyAddress.Address, DestLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, BGUTeleportTo_DestRotation_Offset), 0, BGUTeleportTo_DestRotation_PropertyAddress.Address, DestRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUTeleportTo_bIsATest_Offset), 0, BGUTeleportTo_bIsATest_PropertyAddress.Address, bIsATest);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUTeleportTo_bNoCheck_Offset), 0, BGUTeleportTo_bNoCheck_PropertyAddress.Address, bNoCheck);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUTeleportTo_FunctionAddress, intPtr, BGUTeleportTo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUTeleportTo_ReturnValue_Offset), 0, BGUTeleportTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUSpawnDecalAttached")]
	public unsafe static UDecalComponent BGUSpawnDecalAttached(UMaterialInterface DecalMaterial, FVector DecalSize, USceneComponent AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, EAttachLocation LocationType, float LifeSpan)
	{
		if (!BGUSpawnDecalAttached_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUSpawnDecalAttached");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSpawnDecalAttached_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSpawnDecalAttached_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, BGUSpawnDecalAttached_DecalMaterial_Offset), 0, BGUSpawnDecalAttached_DecalMaterial_PropertyAddress.Address, DecalMaterial);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUSpawnDecalAttached_DecalSize_Offset), 0, BGUSpawnDecalAttached_DecalSize_PropertyAddress.Address, DecalSize);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, BGUSpawnDecalAttached_AttachToComponent_Offset), 0, BGUSpawnDecalAttached_AttachToComponent_PropertyAddress.Address, AttachToComponent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUSpawnDecalAttached_AttachPointName_Offset), 0, BGUSpawnDecalAttached_AttachPointName_PropertyAddress.Address, AttachPointName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUSpawnDecalAttached_Location_Offset), 0, BGUSpawnDecalAttached_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, BGUSpawnDecalAttached_Rotation_Offset), 0, BGUSpawnDecalAttached_Rotation_PropertyAddress.Address, Rotation);
		EnumMarshaler<EAttachLocation>.ToNative(IntPtr.Add(intPtr, BGUSpawnDecalAttached_LocationType_Offset), 0, BGUSpawnDecalAttached_LocationType_PropertyAddress.Address, LocationType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUSpawnDecalAttached_LifeSpan_Offset), 0, BGUSpawnDecalAttached_LifeSpan_PropertyAddress.Address, LifeSpan);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSpawnDecalAttached_FunctionAddress, intPtr, BGUSpawnDecalAttached_ParamsSize);
		return UObjectMarshaler<UDecalComponent>.FromNative(IntPtr.Add(intPtr, BGUSpawnDecalAttached_ReturnValue_Offset), 0, BGUSpawnDecalAttached_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUSliceProceduralMesh")]
	public unsafe static void BGUSliceProceduralMesh(UProceduralMeshComponent InProcMesh, FVector PlanePosition, FVector PlaneNormal, bool bCreateOtherHalf, out UProceduralMeshComponent OutOtherHalfProcMesh, EProcMeshSliceCapOption CapOption, UMaterialInterface CapMaterial)
	{
		if (!BGUSliceProceduralMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUSliceProceduralMesh");
			OutOtherHalfProcMesh = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSliceProceduralMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSliceProceduralMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UProceduralMeshComponent>.ToNative(IntPtr.Add(intPtr, BGUSliceProceduralMesh_InProcMesh_Offset), 0, BGUSliceProceduralMesh_InProcMesh_PropertyAddress.Address, InProcMesh);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUSliceProceduralMesh_PlanePosition_Offset), 0, BGUSliceProceduralMesh_PlanePosition_PropertyAddress.Address, PlanePosition);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUSliceProceduralMesh_PlaneNormal_Offset), 0, BGUSliceProceduralMesh_PlaneNormal_PropertyAddress.Address, PlaneNormal);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUSliceProceduralMesh_bCreateOtherHalf_Offset), 0, BGUSliceProceduralMesh_bCreateOtherHalf_PropertyAddress.Address, bCreateOtherHalf);
		EnumMarshaler<EProcMeshSliceCapOption>.ToNative(IntPtr.Add(intPtr, BGUSliceProceduralMesh_CapOption_Offset), 0, BGUSliceProceduralMesh_CapOption_PropertyAddress.Address, CapOption);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, BGUSliceProceduralMesh_CapMaterial_Offset), 0, BGUSliceProceduralMesh_CapMaterial_PropertyAddress.Address, CapMaterial);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSliceProceduralMesh_FunctionAddress, intPtr, BGUSliceProceduralMesh_ParamsSize);
		OutOtherHalfProcMesh = UObjectMarshaler<UProceduralMeshComponent>.FromNative(IntPtr.Add(intPtr, BGUSliceProceduralMesh_OutOtherHalfProcMesh_Offset), 0, BGUSliceProceduralMesh_OutOtherHalfProcMesh_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUSetParticleSysSortPriority")]
	public unsafe static void BGUSetParticleSysSortPriority(UParticleSystemComponent ParticleSystemComp, int SortPriority)
	{
		if (!BGUSetParticleSysSortPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUSetParticleSysSortPriority");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetParticleSysSortPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetParticleSysSortPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UParticleSystemComponent>.ToNative(IntPtr.Add(intPtr, BGUSetParticleSysSortPriority_ParticleSystemComp_Offset), 0, BGUSetParticleSysSortPriority_ParticleSystemComp_PropertyAddress.Address, ParticleSystemComp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUSetParticleSysSortPriority_SortPriority_Offset), 0, BGUSetParticleSysSortPriority_SortPriority_PropertyAddress.Address, SortPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetParticleSysSortPriority_FunctionAddress, intPtr, BGUSetParticleSysSortPriority_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUSetParticleSysCompPoolingMethod")]
	public unsafe static void BGUSetParticleSysCompPoolingMethod(UParticleSystemComponent ParticleComp, EPSCPoolMethod PoolMethod)
	{
		if (!BGUSetParticleSysCompPoolingMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUSetParticleSysCompPoolingMethod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetParticleSysCompPoolingMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetParticleSysCompPoolingMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UParticleSystemComponent>.ToNative(IntPtr.Add(intPtr, BGUSetParticleSysCompPoolingMethod_ParticleComp_Offset), 0, BGUSetParticleSysCompPoolingMethod_ParticleComp_PropertyAddress.Address, ParticleComp);
		EnumMarshaler<EPSCPoolMethod>.ToNative(IntPtr.Add(intPtr, BGUSetParticleSysCompPoolingMethod_PoolMethod_Offset), 0, BGUSetParticleSysCompPoolingMethod_PoolMethod_PropertyAddress.Address, PoolMethod);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetParticleSysCompPoolingMethod_FunctionAddress, intPtr, BGUSetParticleSysCompPoolingMethod_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUSetIKComponentValid")]
	public unsafe static void BGUSetIKComponentValid(ACharacter Character, bool NewValid)
	{
		if (!BGUSetIKComponentValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUSetIKComponentValid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetIKComponentValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetIKComponentValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, BGUSetIKComponentValid_Character_Offset), 0, BGUSetIKComponentValid_Character_PropertyAddress.Address, Character);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUSetIKComponentValid_NewValid_Offset), 0, BGUSetIKComponentValid_NewValid_PropertyAddress.Address, NewValid);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetIKComponentValid_FunctionAddress, intPtr, BGUSetIKComponentValid_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUSetDecalSize")]
	public unsafe static void BGUSetDecalSize(UDecalComponent DecalComp, FVector Size)
	{
		if (!BGUSetDecalSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUSetDecalSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetDecalSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetDecalSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDecalComponent>.ToNative(IntPtr.Add(intPtr, BGUSetDecalSize_DecalComp_Offset), 0, BGUSetDecalSize_DecalComp_PropertyAddress.Address, DecalComp);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUSetDecalSize_Size_Offset), 0, BGUSetDecalSize_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetDecalSize_FunctionAddress, intPtr, BGUSetDecalSize_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGURestartBT")]
	public unsafe static void BGURestartBT(ABGUAIController AIController)
	{
		if (!BGURestartBT_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGURestartBT");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGURestartBT_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGURestartBT_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUAIController>.ToNative(IntPtr.Add(intPtr, BGURestartBT_AIController_Offset), 0, BGURestartBT_AIController_PropertyAddress.Address, AIController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGURestartBT_FunctionAddress, intPtr, BGURestartBT_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGURegistComp")]
	public unsafe static bool BGURegistComp(UObject WorldContextObject, UActorComponent ActorComp)
	{
		if (!BGURegistComp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGURegistComp");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGURegistComp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGURegistComp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGURegistComp_WorldContextObject_Offset), 0, BGURegistComp_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, BGURegistComp_ActorComp_Offset), 0, BGURegistComp_ActorComp_PropertyAddress.Address, ActorComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGURegistComp_FunctionAddress, intPtr, BGURegistComp_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGURegistComp_ReturnValue_Offset), 0, BGURegistComp_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUMovementComponentSlideAlongSurface")]
	public unsafe static float BGUMovementComponentSlideAlongSurface(UMovementComponent MoveComp, FVector Delta, float Time, FVector Normal, FHitResult InHit, bool bHandleImpact, out FHitResult OutHit)
	{
		if (!BGUMovementComponentSlideAlongSurface_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUMovementComponentSlideAlongSurface");
			OutHit = default(FHitResult);
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUMovementComponentSlideAlongSurface_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUMovementComponentSlideAlongSurface_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovementComponent>.ToNative(IntPtr.Add(intPtr, BGUMovementComponentSlideAlongSurface_MoveComp_Offset), 0, BGUMovementComponentSlideAlongSurface_MoveComp_PropertyAddress.Address, MoveComp);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUMovementComponentSlideAlongSurface_Delta_Offset), 0, BGUMovementComponentSlideAlongSurface_Delta_PropertyAddress.Address, Delta);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUMovementComponentSlideAlongSurface_Time_Offset), 0, BGUMovementComponentSlideAlongSurface_Time_PropertyAddress.Address, Time);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUMovementComponentSlideAlongSurface_Normal_Offset), 0, BGUMovementComponentSlideAlongSurface_Normal_PropertyAddress.Address, Normal);
		NativeReflection.InitializeValue_InContainer(BGUMovementComponentSlideAlongSurface_InHit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, BGUMovementComponentSlideAlongSurface_InHit_Offset), 0, BGUMovementComponentSlideAlongSurface_InHit_PropertyAddress.Address, InHit);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUMovementComponentSlideAlongSurface_bHandleImpact_Offset), 0, BGUMovementComponentSlideAlongSurface_bHandleImpact_PropertyAddress.Address, bHandleImpact);
		NativeReflection.InitializeValue_InContainer(BGUMovementComponentSlideAlongSurface_OutHit_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUMovementComponentSlideAlongSurface_FunctionAddress, intPtr, BGUMovementComponentSlideAlongSurface_ParamsSize);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, BGUMovementComponentSlideAlongSurface_OutHit_Offset), 0, BGUMovementComponentSlideAlongSurface_OutHit_PropertyAddress.Address);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUMovementComponentSlideAlongSurface_ReturnValue_Offset), 0, BGUMovementComponentSlideAlongSurface_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUMovementComponentHandleImpact")]
	public unsafe static void BGUMovementComponentHandleImpact(UMovementComponent MoveComp, FHitResult Hit, float TimeSlice, FVector MoveDelta)
	{
		if (!BGUMovementComponentHandleImpact_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUMovementComponentHandleImpact");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUMovementComponentHandleImpact_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUMovementComponentHandleImpact_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovementComponent>.ToNative(IntPtr.Add(intPtr, BGUMovementComponentHandleImpact_MoveComp_Offset), 0, BGUMovementComponentHandleImpact_MoveComp_PropertyAddress.Address, MoveComp);
		NativeReflection.InitializeValue_InContainer(BGUMovementComponentHandleImpact_Hit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, BGUMovementComponentHandleImpact_Hit_Offset), 0, BGUMovementComponentHandleImpact_Hit_PropertyAddress.Address, Hit);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUMovementComponentHandleImpact_TimeSlice_Offset), 0, BGUMovementComponentHandleImpact_TimeSlice_PropertyAddress.Address, TimeSlice);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUMovementComponentHandleImpact_MoveDelta_Offset), 0, BGUMovementComponentHandleImpact_MoveDelta_PropertyAddress.Address, MoveDelta);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUMovementComponentHandleImpact_FunctionAddress, intPtr, BGUMovementComponentHandleImpact_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUIsBlackBoardKeyTypeMatch")]
	public unsafe static bool BGUIsBlackBoardKeyTypeMatch(UBlackboardKeyType BBKey, EBBKeyType BBKeyType)
	{
		if (!BGUIsBlackBoardKeyTypeMatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUIsBlackBoardKeyTypeMatch");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUIsBlackBoardKeyTypeMatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUIsBlackBoardKeyTypeMatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlackboardKeyType>.ToNative(IntPtr.Add(intPtr, BGUIsBlackBoardKeyTypeMatch_BBKey_Offset), 0, BGUIsBlackBoardKeyTypeMatch_BBKey_PropertyAddress.Address, BBKey);
		EnumMarshaler<EBBKeyType>.ToNative(IntPtr.Add(intPtr, BGUIsBlackBoardKeyTypeMatch_BBKeyType_Offset), 0, BGUIsBlackBoardKeyTypeMatch_BBKeyType_PropertyAddress.Address, BBKeyType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUIsBlackBoardKeyTypeMatch_FunctionAddress, intPtr, BGUIsBlackBoardKeyTypeMatch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUIsBlackBoardKeyTypeMatch_ReturnValue_Offset), 0, BGUIsBlackBoardKeyTypeMatch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetUWorld")]
	public unsafe static UWorld BGUGetUWorld(UObject InnerObject)
	{
		if (!BGUGetUWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetUWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetUWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetUWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUGetUWorld_InnerObject_Offset), 0, BGUGetUWorld_InnerObject_PropertyAddress.Address, InnerObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetUWorld_FunctionAddress, intPtr, BGUGetUWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, BGUGetUWorld_ReturnValue_Offset), 0, BGUGetUWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetSectionFromProceduralMesh")]
	public unsafe static void BGUGetSectionFromProceduralMesh(UProceduralMeshComponent InProcMesh, int SectionIndex, out List<FVector> Vertices, out List<int> Triangles, out List<FVector> Normals, out List<FVector2D> UVs, out List<FProcMeshTangent> Tangents)
	{
		if (!BGUGetSectionFromProceduralMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetSectionFromProceduralMesh");
			Vertices = null;
			Triangles = null;
			Normals = null;
			UVs = null;
			Tangents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetSectionFromProceduralMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetSectionFromProceduralMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UProceduralMeshComponent>.ToNative(IntPtr.Add(intPtr, BGUGetSectionFromProceduralMesh_InProcMesh_Offset), 0, BGUGetSectionFromProceduralMesh_InProcMesh_PropertyAddress.Address, InProcMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUGetSectionFromProceduralMesh_SectionIndex_Offset), 0, BGUGetSectionFromProceduralMesh_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetSectionFromProceduralMesh_FunctionAddress, intPtr, BGUGetSectionFromProceduralMesh_ParamsSize);
		Vertices = new TArrayCopyMarshaler<FVector>(1, BGUGetSectionFromProceduralMesh_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, BGUGetSectionFromProceduralMesh_Vertices_Offset));
		NativeReflection.DestroyValue_InContainer(BGUGetSectionFromProceduralMesh_Vertices_PropertyAddress.Address, intPtr);
		Triangles = new TArrayCopyMarshaler<int>(1, BGUGetSectionFromProceduralMesh_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, BGUGetSectionFromProceduralMesh_Triangles_Offset));
		NativeReflection.DestroyValue_InContainer(BGUGetSectionFromProceduralMesh_Triangles_PropertyAddress.Address, intPtr);
		Normals = new TArrayCopyMarshaler<FVector>(1, BGUGetSectionFromProceduralMesh_Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, BGUGetSectionFromProceduralMesh_Normals_Offset));
		NativeReflection.DestroyValue_InContainer(BGUGetSectionFromProceduralMesh_Normals_PropertyAddress.Address, intPtr);
		UVs = new TArrayCopyMarshaler<FVector2D>(1, BGUGetSectionFromProceduralMesh_UVs_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, BGUGetSectionFromProceduralMesh_UVs_Offset));
		NativeReflection.DestroyValue_InContainer(BGUGetSectionFromProceduralMesh_UVs_PropertyAddress.Address, intPtr);
		Tangents = new TArrayCopyMarshaler<FProcMeshTangent>(1, BGUGetSectionFromProceduralMesh_Tangents_PropertyAddress, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.FromNative, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.ToNative).FromNative(IntPtr.Add(intPtr, BGUGetSectionFromProceduralMesh_Tangents_Offset));
		NativeReflection.DestroyValue_InContainer(BGUGetSectionFromProceduralMesh_Tangents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetParticleSystemIsLooping")]
	public unsafe static bool BGUGetParticleSystemIsLooping(UParticleSystem ParticleForPlay)
	{
		if (!BGUGetParticleSystemIsLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetParticleSystemIsLooping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetParticleSystemIsLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetParticleSystemIsLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(intPtr, BGUGetParticleSystemIsLooping_ParticleForPlay_Offset), 0, BGUGetParticleSystemIsLooping_ParticleForPlay_PropertyAddress.Address, ParticleForPlay);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetParticleSystemIsLooping_FunctionAddress, intPtr, BGUGetParticleSystemIsLooping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetParticleSystemIsLooping_ReturnValue_Offset), 0, BGUGetParticleSystemIsLooping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetPARadiusByBoneName")]
	public unsafe static int BGUGetPARadiusByBoneName(UPhysicsAsset PA, FName BoneName, out float BodyRadius)
	{
		if (!BGUGetPARadiusByBoneName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetPARadiusByBoneName");
			BodyRadius = 0f;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetPARadiusByBoneName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetPARadiusByBoneName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, BGUGetPARadiusByBoneName_PA_Offset), 0, BGUGetPARadiusByBoneName_PA_PropertyAddress.Address, PA);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGetPARadiusByBoneName_BoneName_Offset), 0, BGUGetPARadiusByBoneName_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetPARadiusByBoneName_FunctionAddress, intPtr, BGUGetPARadiusByBoneName_ParamsSize);
		BodyRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetPARadiusByBoneName_BodyRadius_Offset), 0, BGUGetPARadiusByBoneName_BodyRadius_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetPARadiusByBoneName_ReturnValue_Offset), 0, BGUGetPARadiusByBoneName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetPaperSpriteSize")]
	public unsafe static FVector2D BGUGetPaperSpriteSize(UPaperSprite PaperSprite)
	{
		if (!BGUGetPaperSpriteSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetPaperSpriteSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetPaperSpriteSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetPaperSpriteSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPaperSprite>.ToNative(IntPtr.Add(intPtr, BGUGetPaperSpriteSize_PaperSprite_Offset), 0, BGUGetPaperSpriteSize_PaperSprite_PropertyAddress.Address, PaperSprite);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetPaperSpriteSize_FunctionAddress, intPtr, BGUGetPaperSpriteSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, BGUGetPaperSpriteSize_ReturnValue_Offset), 0, BGUGetPaperSpriteSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetMeshPredictedLODLevel")]
	public unsafe static int BGUGetMeshPredictedLODLevel(USkeletalMeshComponent MeshComp)
	{
		if (!BGUGetMeshPredictedLODLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetMeshPredictedLODLevel");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetMeshPredictedLODLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetMeshPredictedLODLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, BGUGetMeshPredictedLODLevel_MeshComp_Offset), 0, BGUGetMeshPredictedLODLevel_MeshComp_PropertyAddress.Address, MeshComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetMeshPredictedLODLevel_FunctionAddress, intPtr, BGUGetMeshPredictedLODLevel_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetMeshPredictedLODLevel_ReturnValue_Offset), 0, BGUGetMeshPredictedLODLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetLevelSequenceLength")]
	public unsafe static float BGUGetLevelSequenceLength(ULevelSequencePlayer LeveleSequencePlayer)
	{
		if (!BGUGetLevelSequenceLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetLevelSequenceLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetLevelSequenceLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetLevelSequenceLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, BGUGetLevelSequenceLength_LeveleSequencePlayer_Offset), 0, BGUGetLevelSequenceLength_LeveleSequencePlayer_PropertyAddress.Address, LeveleSequencePlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetLevelSequenceLength_FunctionAddress, intPtr, BGUGetLevelSequenceLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetLevelSequenceLength_ReturnValue_Offset), 0, BGUGetLevelSequenceLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetLevelSequenceCurTime")]
	public unsafe static float BGUGetLevelSequenceCurTime(ULevelSequencePlayer LeveleSequencePlayer)
	{
		if (!BGUGetLevelSequenceCurTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetLevelSequenceCurTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetLevelSequenceCurTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetLevelSequenceCurTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, BGUGetLevelSequenceCurTime_LeveleSequencePlayer_Offset), 0, BGUGetLevelSequenceCurTime_LeveleSequencePlayer_PropertyAddress.Address, LeveleSequencePlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetLevelSequenceCurTime_FunctionAddress, intPtr, BGUGetLevelSequenceCurTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetLevelSequenceCurTime_ReturnValue_Offset), 0, BGUGetLevelSequenceCurTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetLandscapeExtent")]
	public unsafe static void BGUGetLandscapeExtent(ALandscape Landscape, out int MinX, out int MinY, out int MaxX, out int MaxY)
	{
		if (!BGUGetLandscapeExtent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetLandscapeExtent");
			MinX = 0;
			MinY = 0;
			MaxX = 0;
			MaxY = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetLandscapeExtent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetLandscapeExtent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(intPtr, BGUGetLandscapeExtent_Landscape_Offset), 0, BGUGetLandscapeExtent_Landscape_PropertyAddress.Address, Landscape);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetLandscapeExtent_FunctionAddress, intPtr, BGUGetLandscapeExtent_ParamsSize);
		MinX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetLandscapeExtent_MinX_Offset), 0, BGUGetLandscapeExtent_MinX_PropertyAddress.Address);
		MinY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetLandscapeExtent_MinY_Offset), 0, BGUGetLandscapeExtent_MinY_PropertyAddress.Address);
		MaxX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetLandscapeExtent_MaxX_Offset), 0, BGUGetLandscapeExtent_MaxX_PropertyAddress.Address);
		MaxY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetLandscapeExtent_MaxY_Offset), 0, BGUGetLandscapeExtent_MaxY_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsRuntionShowCollision")]
	public unsafe static bool BGUGetIsRuntionShowCollision(UObject WorldContextObject)
	{
		if (!BGUGetIsRuntionShowCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsRuntionShowCollision");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetIsRuntionShowCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetIsRuntionShowCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUGetIsRuntionShowCollision_WorldContextObject_Offset), 0, BGUGetIsRuntionShowCollision_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetIsRuntionShowCollision_FunctionAddress, intPtr, BGUGetIsRuntionShowCollision_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetIsRuntionShowCollision_ReturnValue_Offset), 0, BGUGetIsRuntionShowCollision_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsInGameWorld")]
	public unsafe static bool BGUGetIsInGameWorld(UObject WorldContextObject)
	{
		if (!BGUGetIsInGameWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsInGameWorld");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetIsInGameWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetIsInGameWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUGetIsInGameWorld_WorldContextObject_Offset), 0, BGUGetIsInGameWorld_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetIsInGameWorld_FunctionAddress, intPtr, BGUGetIsInGameWorld_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetIsInGameWorld_ReturnValue_Offset), 0, BGUGetIsInGameWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsInEditorPreview")]
	public unsafe static bool BGUGetIsInEditorPreview(UObject WorldContextObject)
	{
		if (!BGUGetIsInEditorPreview_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsInEditorPreview");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetIsInEditorPreview_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetIsInEditorPreview_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUGetIsInEditorPreview_WorldContextObject_Offset), 0, BGUGetIsInEditorPreview_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetIsInEditorPreview_FunctionAddress, intPtr, BGUGetIsInEditorPreview_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetIsInEditorPreview_ReturnValue_Offset), 0, BGUGetIsInEditorPreview_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsEditor")]
	public unsafe static bool BGUGetIsEditor()
	{
		if (!BGUGetIsEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetIsEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetIsEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetIsEditor_FunctionAddress, intPtr, BGUGetIsEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetIsEditor_ReturnValue_Offset), 0, BGUGetIsEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsBuildShipping")]
	public unsafe static bool BGUGetIsBuildShipping()
	{
		if (!BGUGetIsBuildShipping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsBuildShipping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetIsBuildShipping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetIsBuildShipping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetIsBuildShipping_FunctionAddress, intPtr, BGUGetIsBuildShipping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetIsBuildShipping_ReturnValue_Offset), 0, BGUGetIsBuildShipping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetFloatValueTableRow")]
	public unsafe static bool BGUGetFloatValueTableRow(UDataTable DataTable, FName RowName, out FGSFloatValueTableRow Result, string ContextString, bool bWarnIfRowMissing = true)
	{
		if (!BGUGetFloatValueTableRow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetFloatValueTableRow");
			Result = default(FGSFloatValueTableRow);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetFloatValueTableRow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetFloatValueTableRow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, BGUGetFloatValueTableRow_DataTable_Offset), 0, BGUGetFloatValueTableRow_DataTable_PropertyAddress.Address, DataTable);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGetFloatValueTableRow_RowName_Offset), 0, BGUGetFloatValueTableRow_RowName_PropertyAddress.Address, RowName);
		NativeReflection.InitializeValue_InContainer(BGUGetFloatValueTableRow_Result_PropertyAddress.Address, intPtr);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGUGetFloatValueTableRow_ContextString_Offset), 0, BGUGetFloatValueTableRow_ContextString_PropertyAddress.Address, ContextString);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUGetFloatValueTableRow_bWarnIfRowMissing_Offset), 0, BGUGetFloatValueTableRow_bWarnIfRowMissing_PropertyAddress.Address, bWarnIfRowMissing);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetFloatValueTableRow_FunctionAddress, intPtr, BGUGetFloatValueTableRow_ParamsSize);
		Result = FGSFloatValueTableRow.FromNative(IntPtr.Add(intPtr, BGUGetFloatValueTableRow_Result_Offset), 0, BGUGetFloatValueTableRow_Result_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BGUGetFloatValueTableRow_Result_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BGUGetFloatValueTableRow_ContextString_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetFloatValueTableRow_ReturnValue_Offset), 0, BGUGetFloatValueTableRow_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetCurrentTime")]
	public unsafe static float BGUGetCurrentTime(UObject WorldContextObject, out bool IsValid)
	{
		if (!BGUGetCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetCurrentTime");
			IsValid = false;
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUGetCurrentTime_WorldContextObject_Offset), 0, BGUGetCurrentTime_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetCurrentTime_FunctionAddress, intPtr, BGUGetCurrentTime_ParamsSize);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetCurrentTime_IsValid_Offset), 0, BGUGetCurrentTime_IsValid_PropertyAddress.Address);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetCurrentTime_ReturnValue_Offset), 0, BGUGetCurrentTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetCurActiveMontageInstID")]
	public unsafe static int BGUGetCurActiveMontageInstID(UAnimInstance AnimInstance)
	{
		if (!BGUGetCurActiveMontageInstID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetCurActiveMontageInstID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetCurActiveMontageInstID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetCurActiveMontageInstID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, BGUGetCurActiveMontageInstID_AnimInstance_Offset), 0, BGUGetCurActiveMontageInstID_AnimInstance_PropertyAddress.Address, AnimInstance);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetCurActiveMontageInstID_FunctionAddress, intPtr, BGUGetCurActiveMontageInstID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetCurActiveMontageInstID_ReturnValue_Offset), 0, BGUGetCurActiveMontageInstID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetBounds")]
	public unsafe static void BGUGetBounds(UPrimitiveComponent PrimComp, out FVector Origin, out FVector BoxExtent)
	{
		if (!BGUGetBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetBounds");
			Origin = default(FVector);
			BoxExtent = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUGetBounds_PrimComp_Offset), 0, BGUGetBounds_PrimComp_PropertyAddress.Address, PrimComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetBounds_FunctionAddress, intPtr, BGUGetBounds_ParamsSize);
		Origin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUGetBounds_Origin_Offset), 0, BGUGetBounds_Origin_PropertyAddress.Address);
		BoxExtent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUGetBounds_BoxExtent_Offset), 0, BGUGetBounds_BoxExtent_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetBodyRadius")]
	public unsafe static float BGUGetBodyRadius(USkeletalMeshComponent SkMeshComp, FName BoneName, bool bGetWelded)
	{
		if (!BGUGetBodyRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetBodyRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetBodyRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetBodyRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, BGUGetBodyRadius_SkMeshComp_Offset), 0, BGUGetBodyRadius_SkMeshComp_PropertyAddress.Address, SkMeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGetBodyRadius_BoneName_Offset), 0, BGUGetBodyRadius_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUGetBodyRadius_bGetWelded_Offset), 0, BGUGetBodyRadius_bGetWelded_PropertyAddress.Address, bGetWelded);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetBodyRadius_FunctionAddress, intPtr, BGUGetBodyRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetBodyRadius_ReturnValue_Offset), 0, BGUGetBodyRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetAllActorsFromGroupActor")]
	public unsafe static List<AActor> BGUGetAllActorsFromGroupActor(AActor GroupActor, bool bRecurse = false)
	{
		if (!BGUGetAllActorsFromGroupActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetAllActorsFromGroupActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetAllActorsFromGroupActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetAllActorsFromGroupActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetAllActorsFromGroupActor_GroupActor_Offset), 0, BGUGetAllActorsFromGroupActor_GroupActor_PropertyAddress.Address, GroupActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUGetAllActorsFromGroupActor_bRecurse_Offset), 0, BGUGetAllActorsFromGroupActor_bRecurse_PropertyAddress.Address, bRecurse);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetAllActorsFromGroupActor_FunctionAddress, intPtr, BGUGetAllActorsFromGroupActor_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, BGUGetAllActorsFromGroupActor_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, BGUGetAllActorsFromGroupActor_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(BGUGetAllActorsFromGroupActor_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetAIStimulusWasSuccessfullySensed")]
	public unsafe static bool BGUGetAIStimulusWasSuccessfullySensed(FAIStimulus Stimulus)
	{
		if (!BGUGetAIStimulusWasSuccessfullySensed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetAIStimulusWasSuccessfullySensed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetAIStimulusWasSuccessfullySensed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetAIStimulusWasSuccessfullySensed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BGUGetAIStimulusWasSuccessfullySensed_Stimulus_PropertyAddress.Address, intPtr);
		FAIStimulus.ToNative(IntPtr.Add(intPtr, BGUGetAIStimulusWasSuccessfullySensed_Stimulus_Offset), 0, BGUGetAIStimulusWasSuccessfullySensed_Stimulus_PropertyAddress.Address, Stimulus);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress, intPtr, BGUGetAIStimulusWasSuccessfullySensed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetAIStimulusWasSuccessfullySensed_ReturnValue_Offset), 0, BGUGetAIStimulusWasSuccessfullySensed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUGetActorLevelName")]
	public unsafe static string BGUGetActorLevelName(AActor Unit)
	{
		if (!BGUGetActorLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUGetActorLevelName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetActorLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetActorLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetActorLevelName_Unit_Offset), 0, BGUGetActorLevelName_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetActorLevelName_FunctionAddress, intPtr, BGUGetActorLevelName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetActorLevelName_ReturnValue_Offset), 0, BGUGetActorLevelName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BGUGetActorLevelName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUExceutePyCode")]
	public unsafe static void BGUExceutePyCode(string PyPath)
	{
		if (!BGUExceutePyCode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUExceutePyCode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUExceutePyCode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUExceutePyCode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGUExceutePyCode_PyPath_Offset), 0, BGUExceutePyCode_PyPath_PropertyAddress.Address, PyPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUExceutePyCode_FunctionAddress, intPtr, BGUExceutePyCode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUExceutePyCode_PyPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUEnableActorTick")]
	public unsafe static void BGUEnableActorTick(AActor Actor, bool bEnable)
	{
		if (!BGUEnableActorTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUEnableActorTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUEnableActorTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUEnableActorTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUEnableActorTick_Actor_Offset), 0, BGUEnableActorTick_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUEnableActorTick_bEnable_Offset), 0, BGUEnableActorTick_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUEnableActorTick_FunctionAddress, intPtr, BGUEnableActorTick_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BguDrawSweepCheckShapeWithColor")]
	public unsafe static void BguDrawSweepCheckShapeWithColor(UWorld World, FVector CenterPos, FQuat Rot, FGSSweepCheckShapeInfo SweepCheckShapeInfo, FColor Color)
	{
		if (!BguDrawSweepCheckShapeWithColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BguDrawSweepCheckShapeWithColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BguDrawSweepCheckShapeWithColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BguDrawSweepCheckShapeWithColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BguDrawSweepCheckShapeWithColor_World_Offset), 0, BguDrawSweepCheckShapeWithColor_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BguDrawSweepCheckShapeWithColor_CenterPos_Offset), 0, BguDrawSweepCheckShapeWithColor_CenterPos_PropertyAddress.Address, CenterPos);
		NativeReflection.InitializeValue_InContainer(BguDrawSweepCheckShapeWithColor_Rot_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, BguDrawSweepCheckShapeWithColor_Rot_Offset), 0, BguDrawSweepCheckShapeWithColor_Rot_PropertyAddress.Address, Rot);
		NativeReflection.InitializeValue_InContainer(BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_PropertyAddress.Address, intPtr);
		FGSSweepCheckShapeInfo.ToNative(IntPtr.Add(intPtr, BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_Offset), 0, BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_PropertyAddress.Address, SweepCheckShapeInfo);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, BguDrawSweepCheckShapeWithColor_Color_Offset), 0, BguDrawSweepCheckShapeWithColor_Color_PropertyAddress.Address, Color);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BguDrawSweepCheckShapeWithColor_FunctionAddress, intPtr, BguDrawSweepCheckShapeWithColor_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawSweepCheckShape")]
	public unsafe static void BGUDrawSweepCheckShape(UWorld World, FVector CenterPos, FQuat Rot, FGSSweepCheckShapeInfo SweepCheckShapeInfo)
	{
		if (!BGUDrawSweepCheckShape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawSweepCheckShape");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawSweepCheckShape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawSweepCheckShape_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawSweepCheckShape_World_Offset), 0, BGUDrawSweepCheckShape_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawSweepCheckShape_CenterPos_Offset), 0, BGUDrawSweepCheckShape_CenterPos_PropertyAddress.Address, CenterPos);
		NativeReflection.InitializeValue_InContainer(BGUDrawSweepCheckShape_Rot_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, BGUDrawSweepCheckShape_Rot_Offset), 0, BGUDrawSweepCheckShape_Rot_PropertyAddress.Address, Rot);
		NativeReflection.InitializeValue_InContainer(BGUDrawSweepCheckShape_SweepCheckShapeInfo_PropertyAddress.Address, intPtr);
		FGSSweepCheckShapeInfo.ToNative(IntPtr.Add(intPtr, BGUDrawSweepCheckShape_SweepCheckShapeInfo_Offset), 0, BGUDrawSweepCheckShape_SweepCheckShapeInfo_PropertyAddress.Address, SweepCheckShapeInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawSweepCheckShape_FunctionAddress, intPtr, BGUDrawSweepCheckShape_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BguDrawSphereSweepWithColor")]
	public unsafe static void BguDrawSphereSweepWithColor(UWorld World, FTransform Start, FTransform End, float Radius, FColor Color)
	{
		if (!BguDrawSphereSweepWithColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BguDrawSphereSweepWithColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BguDrawSphereSweepWithColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BguDrawSphereSweepWithColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BguDrawSphereSweepWithColor_World_Offset), 0, BguDrawSphereSweepWithColor_World_PropertyAddress.Address, World);
		NativeReflection.InitializeValue_InContainer(BguDrawSphereSweepWithColor_Start_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BguDrawSphereSweepWithColor_Start_Offset), 0, BguDrawSphereSweepWithColor_Start_PropertyAddress.Address, Start);
		NativeReflection.InitializeValue_InContainer(BguDrawSphereSweepWithColor_End_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BguDrawSphereSweepWithColor_End_Offset), 0, BguDrawSphereSweepWithColor_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BguDrawSphereSweepWithColor_Radius_Offset), 0, BguDrawSphereSweepWithColor_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, BguDrawSphereSweepWithColor_Color_Offset), 0, BguDrawSphereSweepWithColor_Color_PropertyAddress.Address, Color);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BguDrawSphereSweepWithColor_FunctionAddress, intPtr, BguDrawSphereSweepWithColor_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawSphereSweep")]
	public unsafe static void BGUDrawSphereSweep(UWorld World, FTransform Start, FTransform End, float Radius)
	{
		if (!BGUDrawSphereSweep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawSphereSweep");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawSphereSweep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawSphereSweep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawSphereSweep_World_Offset), 0, BGUDrawSphereSweep_World_PropertyAddress.Address, World);
		NativeReflection.InitializeValue_InContainer(BGUDrawSphereSweep_Start_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BGUDrawSphereSweep_Start_Offset), 0, BGUDrawSphereSweep_Start_PropertyAddress.Address, Start);
		NativeReflection.InitializeValue_InContainer(BGUDrawSphereSweep_End_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BGUDrawSphereSweep_End_Offset), 0, BGUDrawSphereSweep_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawSphereSweep_Radius_Offset), 0, BGUDrawSphereSweep_Radius_PropertyAddress.Address, Radius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawSphereSweep_FunctionAddress, intPtr, BGUDrawSphereSweep_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawLineArrowEx")]
	public unsafe static void BGUDrawLineArrowEx(UWorld World, FVector LineStart, FVector LineEnd, float ArrowSize, FColor Color, bool IsPersistentLines, float LifeTime)
	{
		if (!BGUDrawLineArrowEx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawLineArrowEx");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawLineArrowEx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawLineArrowEx_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrowEx_World_Offset), 0, BGUDrawLineArrowEx_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrowEx_LineStart_Offset), 0, BGUDrawLineArrowEx_LineStart_PropertyAddress.Address, LineStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrowEx_LineEnd_Offset), 0, BGUDrawLineArrowEx_LineEnd_PropertyAddress.Address, LineEnd);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrowEx_ArrowSize_Offset), 0, BGUDrawLineArrowEx_ArrowSize_PropertyAddress.Address, ArrowSize);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrowEx_Color_Offset), 0, BGUDrawLineArrowEx_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrowEx_IsPersistentLines_Offset), 0, BGUDrawLineArrowEx_IsPersistentLines_PropertyAddress.Address, IsPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrowEx_LifeTime_Offset), 0, BGUDrawLineArrowEx_LifeTime_PropertyAddress.Address, LifeTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawLineArrowEx_FunctionAddress, intPtr, BGUDrawLineArrowEx_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawLineArrow")]
	public unsafe static void BGUDrawLineArrow(UWorld World, FVector LineStart, FVector LineEnd, float ArrowSize)
	{
		if (!BGUDrawLineArrow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawLineArrow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawLineArrow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawLineArrow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrow_World_Offset), 0, BGUDrawLineArrow_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrow_LineStart_Offset), 0, BGUDrawLineArrow_LineStart_PropertyAddress.Address, LineStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrow_LineEnd_Offset), 0, BGUDrawLineArrow_LineEnd_PropertyAddress.Address, LineEnd);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawLineArrow_ArrowSize_Offset), 0, BGUDrawLineArrow_ArrowSize_PropertyAddress.Address, ArrowSize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawLineArrow_FunctionAddress, intPtr, BGUDrawLineArrow_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugSphereEx")]
	public unsafe static void BGUDrawDebugSphereEx(UWorld World, FVector CenterPos, float Raidus, float KeepTime, FColor Color)
	{
		if (!BGUDrawDebugSphereEx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugSphereEx");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawDebugSphereEx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawDebugSphereEx_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugSphereEx_World_Offset), 0, BGUDrawDebugSphereEx_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugSphereEx_CenterPos_Offset), 0, BGUDrawDebugSphereEx_CenterPos_PropertyAddress.Address, CenterPos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugSphereEx_Raidus_Offset), 0, BGUDrawDebugSphereEx_Raidus_PropertyAddress.Address, Raidus);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugSphereEx_KeepTime_Offset), 0, BGUDrawDebugSphereEx_KeepTime_PropertyAddress.Address, KeepTime);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugSphereEx_Color_Offset), 0, BGUDrawDebugSphereEx_Color_PropertyAddress.Address, Color);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawDebugSphereEx_FunctionAddress, intPtr, BGUDrawDebugSphereEx_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugSphere")]
	public unsafe static void BGUDrawDebugSphere(UWorld World, FVector CenterPos, float Raidus)
	{
		if (!BGUDrawDebugSphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugSphere");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawDebugSphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawDebugSphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugSphere_World_Offset), 0, BGUDrawDebugSphere_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugSphere_CenterPos_Offset), 0, BGUDrawDebugSphere_CenterPos_PropertyAddress.Address, CenterPos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugSphere_Raidus_Offset), 0, BGUDrawDebugSphere_Raidus_PropertyAddress.Address, Raidus);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawDebugSphere_FunctionAddress, intPtr, BGUDrawDebugSphere_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugRect")]
	public unsafe static void BGUDrawDebugRect(UWorld World, FVector CenterPos, FVector Direction, float Width, float Length)
	{
		if (!BGUDrawDebugRect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugRect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawDebugRect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawDebugRect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugRect_World_Offset), 0, BGUDrawDebugRect_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugRect_CenterPos_Offset), 0, BGUDrawDebugRect_CenterPos_PropertyAddress.Address, CenterPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugRect_Direction_Offset), 0, BGUDrawDebugRect_Direction_PropertyAddress.Address, Direction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugRect_Width_Offset), 0, BGUDrawDebugRect_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugRect_Length_Offset), 0, BGUDrawDebugRect_Length_PropertyAddress.Address, Length);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawDebugRect_FunctionAddress, intPtr, BGUDrawDebugRect_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugCircleEx")]
	public unsafe static void BGUDrawDebugCircleEx(UWorld World, FVector CenterPos, float Raidus, float KeepTime, FColor Color)
	{
		if (!BGUDrawDebugCircleEx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugCircleEx");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawDebugCircleEx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawDebugCircleEx_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugCircleEx_World_Offset), 0, BGUDrawDebugCircleEx_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugCircleEx_CenterPos_Offset), 0, BGUDrawDebugCircleEx_CenterPos_PropertyAddress.Address, CenterPos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugCircleEx_Raidus_Offset), 0, BGUDrawDebugCircleEx_Raidus_PropertyAddress.Address, Raidus);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugCircleEx_KeepTime_Offset), 0, BGUDrawDebugCircleEx_KeepTime_PropertyAddress.Address, KeepTime);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugCircleEx_Color_Offset), 0, BGUDrawDebugCircleEx_Color_PropertyAddress.Address, Color);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawDebugCircleEx_FunctionAddress, intPtr, BGUDrawDebugCircleEx_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugCircle")]
	public unsafe static void BGUDrawDebugCircle(UWorld World, FVector CenterPos, float Raidus)
	{
		if (!BGUDrawDebugCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawDebugCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawDebugCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugCircle_World_Offset), 0, BGUDrawDebugCircle_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugCircle_CenterPos_Offset), 0, BGUDrawDebugCircle_CenterPos_PropertyAddress.Address, CenterPos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugCircle_Raidus_Offset), 0, BGUDrawDebugCircle_Raidus_PropertyAddress.Address, Raidus);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawDebugCircle_FunctionAddress, intPtr, BGUDrawDebugCircle_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugAnnularSector")]
	public unsafe static void BGUDrawDebugAnnularSector(UWorld World, FVector CenterPos, FVector Direction, float InnerRadius, float OuterRadius, float HalfAngle, FColor Color, float Duration, float Thickness, int Segments)
	{
		if (!BGUDrawDebugAnnularSector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugAnnularSector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUDrawDebugAnnularSector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUDrawDebugAnnularSector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_World_Offset), 0, BGUDrawDebugAnnularSector_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_CenterPos_Offset), 0, BGUDrawDebugAnnularSector_CenterPos_PropertyAddress.Address, CenterPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_Direction_Offset), 0, BGUDrawDebugAnnularSector_Direction_PropertyAddress.Address, Direction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_InnerRadius_Offset), 0, BGUDrawDebugAnnularSector_InnerRadius_PropertyAddress.Address, InnerRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_OuterRadius_Offset), 0, BGUDrawDebugAnnularSector_OuterRadius_PropertyAddress.Address, OuterRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_HalfAngle_Offset), 0, BGUDrawDebugAnnularSector_HalfAngle_PropertyAddress.Address, HalfAngle);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_Color_Offset), 0, BGUDrawDebugAnnularSector_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_Duration_Offset), 0, BGUDrawDebugAnnularSector_Duration_PropertyAddress.Address, Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_Thickness_Offset), 0, BGUDrawDebugAnnularSector_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUDrawDebugAnnularSector_Segments_Offset), 0, BGUDrawDebugAnnularSector_Segments_PropertyAddress.Address, Segments);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUDrawDebugAnnularSector_FunctionAddress, intPtr, BGUDrawDebugAnnularSector_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUCreateLandscapeHeightMap")]
	public unsafe static UTexture2D BGUCreateLandscapeHeightMap(ALandscape Landscape, string PackageName, string AssetName)
	{
		if (!BGUCreateLandscapeHeightMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUCreateLandscapeHeightMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUCreateLandscapeHeightMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUCreateLandscapeHeightMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(intPtr, BGUCreateLandscapeHeightMap_Landscape_Offset), 0, BGUCreateLandscapeHeightMap_Landscape_PropertyAddress.Address, Landscape);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGUCreateLandscapeHeightMap_PackageName_Offset), 0, BGUCreateLandscapeHeightMap_PackageName_PropertyAddress.Address, PackageName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGUCreateLandscapeHeightMap_AssetName_Offset), 0, BGUCreateLandscapeHeightMap_AssetName_PropertyAddress.Address, AssetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUCreateLandscapeHeightMap_FunctionAddress, intPtr, BGUCreateLandscapeHeightMap_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUCreateLandscapeHeightMap_PackageName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BGUCreateLandscapeHeightMap_AssetName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, BGUCreateLandscapeHeightMap_ReturnValue_Offset), 0, BGUCreateLandscapeHeightMap_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUComputeActorHitMovePenetration")]
	public unsafe static FVector BGUComputeActorHitMovePenetration(AActor SelfActor, List<UHitMoveOverlapOtherActorCollisionsInfo> OverlappedOtherActorInfos, float SelfWeight, FVector PlaneNormalVector, int MaxComputeRound, float Epsilon = 1f)
	{
		if (!BGUComputeActorHitMovePenetration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUComputeActorHitMovePenetration");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUComputeActorHitMovePenetration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUComputeActorHitMovePenetration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUComputeActorHitMovePenetration_SelfActor_Offset), 0, BGUComputeActorHitMovePenetration_SelfActor_PropertyAddress.Address, SelfActor);
		new TArrayCopyMarshaler<UHitMoveOverlapOtherActorCollisionsInfo>(1, BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_PropertyAddress, CachedMarshalingDelegates<UHitMoveOverlapOtherActorCollisionsInfo, UObjectMarshaler<UHitMoveOverlapOtherActorCollisionsInfo>>.FromNative, CachedMarshalingDelegates<UHitMoveOverlapOtherActorCollisionsInfo, UObjectMarshaler<UHitMoveOverlapOtherActorCollisionsInfo>>.ToNative).ToNative(IntPtr.Add(intPtr, BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_Offset), OverlappedOtherActorInfos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUComputeActorHitMovePenetration_SelfWeight_Offset), 0, BGUComputeActorHitMovePenetration_SelfWeight_PropertyAddress.Address, SelfWeight);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUComputeActorHitMovePenetration_PlaneNormalVector_Offset), 0, BGUComputeActorHitMovePenetration_PlaneNormalVector_PropertyAddress.Address, PlaneNormalVector);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUComputeActorHitMovePenetration_MaxComputeRound_Offset), 0, BGUComputeActorHitMovePenetration_MaxComputeRound_PropertyAddress.Address, MaxComputeRound);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUComputeActorHitMovePenetration_Epsilon_Offset), 0, BGUComputeActorHitMovePenetration_Epsilon_PropertyAddress.Address, Epsilon);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUComputeActorHitMovePenetration_FunctionAddress, intPtr, BGUComputeActorHitMovePenetration_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUComputeActorHitMovePenetration_ReturnValue_Offset), 0, BGUComputeActorHitMovePenetration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnSetLevelsStateFinished")]
	public unsafe static void BGUBindOnSetLevelsStateFinished(UObject Obj, FName FuncName)
	{
		if (!BGUBindOnSetLevelsStateFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnSetLevelsStateFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnSetLevelsStateFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnSetLevelsStateFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnSetLevelsStateFinished_Obj_Offset), 0, BGUBindOnSetLevelsStateFinished_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnSetLevelsStateFinished_FuncName_Offset), 0, BGUBindOnSetLevelsStateFinished_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnSetLevelsStateFinished_FunctionAddress, intPtr, BGUBindOnSetLevelsStateFinished_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnComponentHitEvent")]
	public unsafe static void BGUBindOnComponentHitEvent(UPrimitiveComponent Comp, UObject Obj, FName Func)
	{
		if (!BGUBindOnComponentHitEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnComponentHitEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnComponentHitEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnComponentHitEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUBindOnComponentHitEvent_Comp_Offset), 0, BGUBindOnComponentHitEvent_Comp_PropertyAddress.Address, Comp);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnComponentHitEvent_Obj_Offset), 0, BGUBindOnComponentHitEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnComponentHitEvent_Func_Offset), 0, BGUBindOnComponentHitEvent_Func_PropertyAddress.Address, Func);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnComponentHitEvent_FunctionAddress, intPtr, BGUBindOnComponentHitEvent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnComponentEndOverlapEvent")]
	public unsafe static void BGUBindOnComponentEndOverlapEvent(UPrimitiveComponent Comp, UObject Obj, FName FuncName)
	{
		if (!BGUBindOnComponentEndOverlapEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnComponentEndOverlapEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnComponentEndOverlapEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnComponentEndOverlapEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUBindOnComponentEndOverlapEvent_Comp_Offset), 0, BGUBindOnComponentEndOverlapEvent_Comp_PropertyAddress.Address, Comp);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnComponentEndOverlapEvent_Obj_Offset), 0, BGUBindOnComponentEndOverlapEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnComponentEndOverlapEvent_FuncName_Offset), 0, BGUBindOnComponentEndOverlapEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnComponentEndOverlapEvent_FunctionAddress, intPtr, BGUBindOnComponentEndOverlapEvent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnComponentBeginOverlapEvent")]
	public unsafe static void BGUBindOnComponentBeginOverlapEvent(UPrimitiveComponent Comp, UObject Obj, FName FuncName)
	{
		if (!BGUBindOnComponentBeginOverlapEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnComponentBeginOverlapEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnComponentBeginOverlapEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnComponentBeginOverlapEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUBindOnComponentBeginOverlapEvent_Comp_Offset), 0, BGUBindOnComponentBeginOverlapEvent_Comp_PropertyAddress.Address, Comp);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnComponentBeginOverlapEvent_Obj_Offset), 0, BGUBindOnComponentBeginOverlapEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnComponentBeginOverlapEvent_FuncName_Offset), 0, BGUBindOnComponentBeginOverlapEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnComponentBeginOverlapEvent_FunctionAddress, intPtr, BGUBindOnComponentBeginOverlapEvent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnAllSetLevelsStateFinished")]
	public unsafe static void BGUBindOnAllSetLevelsStateFinished(UObject Obj, FName FuncName)
	{
		if (!BGUBindOnAllSetLevelsStateFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnAllSetLevelsStateFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnAllSetLevelsStateFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnAllSetLevelsStateFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnAllSetLevelsStateFinished_Obj_Offset), 0, BGUBindOnAllSetLevelsStateFinished_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnAllSetLevelsStateFinished_FuncName_Offset), 0, BGUBindOnAllSetLevelsStateFinished_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnAllSetLevelsStateFinished_FunctionAddress, intPtr, BGUBindOnAllSetLevelsStateFinished_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnActorEndOverlapEvent")]
	public unsafe static void BGUBindOnActorEndOverlapEvent(AActor Actor, UObject Obj, FName FuncName)
	{
		if (!BGUBindOnActorEndOverlapEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnActorEndOverlapEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnActorEndOverlapEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnActorEndOverlapEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUBindOnActorEndOverlapEvent_Actor_Offset), 0, BGUBindOnActorEndOverlapEvent_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnActorEndOverlapEvent_Obj_Offset), 0, BGUBindOnActorEndOverlapEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnActorEndOverlapEvent_FuncName_Offset), 0, BGUBindOnActorEndOverlapEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnActorEndOverlapEvent_FunctionAddress, intPtr, BGUBindOnActorEndOverlapEvent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnActorBeginOverlapEvent")]
	public unsafe static void BGUBindOnActorBeginOverlapEvent(AActor Actor, UObject Obj, FName FuncName)
	{
		if (!BGUBindOnActorBeginOverlapEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnActorBeginOverlapEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnActorBeginOverlapEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnActorBeginOverlapEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUBindOnActorBeginOverlapEvent_Actor_Offset), 0, BGUBindOnActorBeginOverlapEvent_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnActorBeginOverlapEvent_Obj_Offset), 0, BGUBindOnActorBeginOverlapEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnActorBeginOverlapEvent_FuncName_Offset), 0, BGUBindOnActorBeginOverlapEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnActorBeginOverlapEvent_FunctionAddress, intPtr, BGUBindOnActorBeginOverlapEvent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibraryForCS:AddNotifyPreloadedAsset")]
	public unsafe static void AddNotifyPreloadedAsset(UObject Notify, UObject Asset)
	{
		if (!AddNotifyPreloadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibraryForCS:AddNotifyPreloadedAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNotifyPreloadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNotifyPreloadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddNotifyPreloadedAsset_Notify_Offset), 0, AddNotifyPreloadedAsset_Notify_PropertyAddress.Address, Notify);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddNotifyPreloadedAsset_Asset_Offset), 0, AddNotifyPreloadedAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddNotifyPreloadedAsset_FunctionAddress, intPtr, AddNotifyPreloadedAsset_ParamsSize);
	}

	static UBGUFunctionLibraryForCS()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFunctionLibraryForCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFunctionLibraryForCS));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFunctionLibraryForCS");
		ValidateMontagesForCrossSectionNS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ValidateMontagesForCrossSectionNS");
		ValidateMontagesForCrossSectionNS_ParamsSize = NativeReflection.GetFunctionParamsSize(ValidateMontagesForCrossSectionNS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ValidateMontagesForCrossSectionNS_ResourcePath_PropertyAddress, ValidateMontagesForCrossSectionNS_FunctionAddress, "ResourcePath");
		ValidateMontagesForCrossSectionNS_ResourcePath_Offset = NativeReflectionCached.GetPropertyOffset(ValidateMontagesForCrossSectionNS_FunctionAddress, "ResourcePath");
		ValidateMontagesForCrossSectionNS_ResourcePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidateMontagesForCrossSectionNS_FunctionAddress, "ResourcePath", Classes.FStrProperty);
		ValidateMontagesForCrossSectionNS_IsValid = ValidateMontagesForCrossSectionNS_FunctionAddress != IntPtr.Zero && ValidateMontagesForCrossSectionNS_ResourcePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:ValidateMontagesForCrossSectionNS", ValidateMontagesForCrossSectionNS_IsValid);
		RequestGameplayTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestGameplayTag");
		RequestGameplayTag_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestGameplayTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestGameplayTag_TagName_PropertyAddress, RequestGameplayTag_FunctionAddress, "TagName");
		RequestGameplayTag_TagName_Offset = NativeReflectionCached.GetPropertyOffset(RequestGameplayTag_FunctionAddress, "TagName");
		RequestGameplayTag_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestGameplayTag_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestGameplayTag_ErrorIfNotFound_PropertyAddress, RequestGameplayTag_FunctionAddress, "ErrorIfNotFound");
		RequestGameplayTag_ErrorIfNotFound_Offset = NativeReflectionCached.GetPropertyOffset(RequestGameplayTag_FunctionAddress, "ErrorIfNotFound");
		RequestGameplayTag_ErrorIfNotFound_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestGameplayTag_FunctionAddress, "ErrorIfNotFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestGameplayTag_ReturnValue_PropertyAddress, RequestGameplayTag_FunctionAddress, "ReturnValue");
		RequestGameplayTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RequestGameplayTag_FunctionAddress, "ReturnValue");
		RequestGameplayTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestGameplayTag_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		RequestGameplayTag_IsValid = RequestGameplayTag_FunctionAddress != IntPtr.Zero && RequestGameplayTag_TagName_IsValid && RequestGameplayTag_ErrorIfNotFound_IsValid && RequestGameplayTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:RequestGameplayTag", RequestGameplayTag_IsValid);
		RemoveAllQueriesByQuerier_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllQueriesByQuerier");
		RemoveAllQueriesByQuerier_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllQueriesByQuerier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllQueriesByQuerier_Querier_PropertyAddress, RemoveAllQueriesByQuerier_FunctionAddress, "Querier");
		RemoveAllQueriesByQuerier_Querier_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllQueriesByQuerier_FunctionAddress, "Querier");
		RemoveAllQueriesByQuerier_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllQueriesByQuerier_FunctionAddress, "Querier", Classes.FObjectProperty);
		RemoveAllQueriesByQuerier_IsValid = RemoveAllQueriesByQuerier_FunctionAddress != IntPtr.Zero && RemoveAllQueriesByQuerier_Querier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:RemoveAllQueriesByQuerier", RemoveAllQueriesByQuerier_IsValid);
		CopyProceduralMeshFromStaticMeshComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyProceduralMeshFromStaticMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_PropertyAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "StaticMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "StaticMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "StaticMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyProceduralMeshFromStaticMeshComponent_LODIndex_PropertyAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "LODIndex");
		CopyProceduralMeshFromStaticMeshComponent_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "LODIndex");
		CopyProceduralMeshFromStaticMeshComponent_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_PropertyAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "ProcMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "ProcMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "ProcMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_PropertyAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "bCreateCollision");
		CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_Offset = NativeReflectionCached.GetPropertyOffset(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "bCreateCollision");
		CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "bCreateCollision", Classes.FBoolProperty);
		CopyProceduralMeshFromStaticMeshComponent_IsValid = CopyProceduralMeshFromStaticMeshComponent_FunctionAddress != IntPtr.Zero && CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_IsValid && CopyProceduralMeshFromStaticMeshComponent_LODIndex_IsValid && CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_IsValid && CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:CopyProceduralMeshFromStaticMeshComponent", CopyProceduralMeshFromStaticMeshComponent_IsValid);
		ConvertTraceTypeToCollisionChannel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertTraceTypeToCollisionChannel");
		ConvertTraceTypeToCollisionChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertTraceTypeToCollisionChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertTraceTypeToCollisionChannel_TraceType_PropertyAddress, ConvertTraceTypeToCollisionChannel_FunctionAddress, "TraceType");
		ConvertTraceTypeToCollisionChannel_TraceType_Offset = NativeReflectionCached.GetPropertyOffset(ConvertTraceTypeToCollisionChannel_FunctionAddress, "TraceType");
		ConvertTraceTypeToCollisionChannel_TraceType_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertTraceTypeToCollisionChannel_FunctionAddress, "TraceType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertTraceTypeToCollisionChannel_ReturnValue_PropertyAddress, ConvertTraceTypeToCollisionChannel_FunctionAddress, "ReturnValue");
		ConvertTraceTypeToCollisionChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertTraceTypeToCollisionChannel_FunctionAddress, "ReturnValue");
		ConvertTraceTypeToCollisionChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertTraceTypeToCollisionChannel_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ConvertTraceTypeToCollisionChannel_IsValid = ConvertTraceTypeToCollisionChannel_FunctionAddress != IntPtr.Zero && ConvertTraceTypeToCollisionChannel_TraceType_IsValid && ConvertTraceTypeToCollisionChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:ConvertTraceTypeToCollisionChannel", ConvertTraceTypeToCollisionChannel_IsValid);
		ConvertToTraceType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToTraceType");
		ConvertToTraceType_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToTraceType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTraceType_CollisionChannel_PropertyAddress, ConvertToTraceType_FunctionAddress, "CollisionChannel");
		ConvertToTraceType_CollisionChannel_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTraceType_FunctionAddress, "CollisionChannel");
		ConvertToTraceType_CollisionChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTraceType_FunctionAddress, "CollisionChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTraceType_ReturnValue_PropertyAddress, ConvertToTraceType_FunctionAddress, "ReturnValue");
		ConvertToTraceType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTraceType_FunctionAddress, "ReturnValue");
		ConvertToTraceType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTraceType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ConvertToTraceType_IsValid = ConvertToTraceType_FunctionAddress != IntPtr.Zero && ConvertToTraceType_CollisionChannel_IsValid && ConvertToTraceType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:ConvertToTraceType", ConvertToTraceType_IsValid);
		ConvertToObjectType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToObjectType");
		ConvertToObjectType_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToObjectType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToObjectType_CollisionChannel_PropertyAddress, ConvertToObjectType_FunctionAddress, "CollisionChannel");
		ConvertToObjectType_CollisionChannel_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToObjectType_FunctionAddress, "CollisionChannel");
		ConvertToObjectType_CollisionChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToObjectType_FunctionAddress, "CollisionChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToObjectType_ReturnValue_PropertyAddress, ConvertToObjectType_FunctionAddress, "ReturnValue");
		ConvertToObjectType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToObjectType_FunctionAddress, "ReturnValue");
		ConvertToObjectType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToObjectType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ConvertToObjectType_IsValid = ConvertToObjectType_FunctionAddress != IntPtr.Zero && ConvertToObjectType_CollisionChannel_IsValid && ConvertToObjectType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:ConvertToObjectType", ConvertToObjectType_IsValid);
		ConvertObjectTypeToCollisionChannel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertObjectTypeToCollisionChannel");
		ConvertObjectTypeToCollisionChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertObjectTypeToCollisionChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertObjectTypeToCollisionChannel_ObjectType_PropertyAddress, ConvertObjectTypeToCollisionChannel_FunctionAddress, "ObjectType");
		ConvertObjectTypeToCollisionChannel_ObjectType_Offset = NativeReflectionCached.GetPropertyOffset(ConvertObjectTypeToCollisionChannel_FunctionAddress, "ObjectType");
		ConvertObjectTypeToCollisionChannel_ObjectType_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertObjectTypeToCollisionChannel_FunctionAddress, "ObjectType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertObjectTypeToCollisionChannel_ReturnValue_PropertyAddress, ConvertObjectTypeToCollisionChannel_FunctionAddress, "ReturnValue");
		ConvertObjectTypeToCollisionChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertObjectTypeToCollisionChannel_FunctionAddress, "ReturnValue");
		ConvertObjectTypeToCollisionChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertObjectTypeToCollisionChannel_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ConvertObjectTypeToCollisionChannel_IsValid = ConvertObjectTypeToCollisionChannel_FunctionAddress != IntPtr.Zero && ConvertObjectTypeToCollisionChannel_ObjectType_IsValid && ConvertObjectTypeToCollisionChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:ConvertObjectTypeToCollisionChannel", ConvertObjectTypeToCollisionChannel_IsValid);
		CompForceUpdateOverlaps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompForceUpdateOverlaps");
		CompForceUpdateOverlaps_ParamsSize = NativeReflection.GetFunctionParamsSize(CompForceUpdateOverlaps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompForceUpdateOverlaps_Comp_PropertyAddress, CompForceUpdateOverlaps_FunctionAddress, "Comp");
		CompForceUpdateOverlaps_Comp_Offset = NativeReflectionCached.GetPropertyOffset(CompForceUpdateOverlaps_FunctionAddress, "Comp");
		CompForceUpdateOverlaps_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(CompForceUpdateOverlaps_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CompForceUpdateOverlaps_bDoNotifies_PropertyAddress, CompForceUpdateOverlaps_FunctionAddress, "bDoNotifies");
		CompForceUpdateOverlaps_bDoNotifies_Offset = NativeReflectionCached.GetPropertyOffset(CompForceUpdateOverlaps_FunctionAddress, "bDoNotifies");
		CompForceUpdateOverlaps_bDoNotifies_IsValid = NativeReflectionCached.ValidatePropertyClass(CompForceUpdateOverlaps_FunctionAddress, "bDoNotifies", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CompForceUpdateOverlaps_ReturnValue_PropertyAddress, CompForceUpdateOverlaps_FunctionAddress, "ReturnValue");
		CompForceUpdateOverlaps_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CompForceUpdateOverlaps_FunctionAddress, "ReturnValue");
		CompForceUpdateOverlaps_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CompForceUpdateOverlaps_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CompForceUpdateOverlaps_IsValid = CompForceUpdateOverlaps_FunctionAddress != IntPtr.Zero && CompForceUpdateOverlaps_Comp_IsValid && CompForceUpdateOverlaps_bDoNotifies_IsValid && CompForceUpdateOverlaps_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:CompForceUpdateOverlaps", CompForceUpdateOverlaps_IsValid);
		CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CallSectionManuallyChangeOnCrossSectionNotifies");
		CallSectionManuallyChangeOnCrossSectionNotifies_ParamsSize = NativeReflection.GetFunctionParamsSize(CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CallSectionManuallyChangeOnCrossSectionNotifies_OwnerChar_PropertyAddress, CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress, "OwnerChar");
		CallSectionManuallyChangeOnCrossSectionNotifies_OwnerChar_Offset = NativeReflectionCached.GetPropertyOffset(CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress, "OwnerChar");
		CallSectionManuallyChangeOnCrossSectionNotifies_OwnerChar_IsValid = NativeReflectionCached.ValidatePropertyClass(CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress, "OwnerChar", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CallSectionManuallyChangeOnCrossSectionNotifies_NewSectionName_PropertyAddress, CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress, "NewSectionName");
		CallSectionManuallyChangeOnCrossSectionNotifies_NewSectionName_Offset = NativeReflectionCached.GetPropertyOffset(CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress, "NewSectionName");
		CallSectionManuallyChangeOnCrossSectionNotifies_NewSectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress, "NewSectionName", Classes.FNameProperty);
		CallSectionManuallyChangeOnCrossSectionNotifies_IsValid = CallSectionManuallyChangeOnCrossSectionNotifies_FunctionAddress != IntPtr.Zero && CallSectionManuallyChangeOnCrossSectionNotifies_OwnerChar_IsValid && CallSectionManuallyChangeOnCrossSectionNotifies_NewSectionName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:CallSectionManuallyChangeOnCrossSectionNotifies", CallSectionManuallyChangeOnCrossSectionNotifies_IsValid);
		BGUUnBindOnSetLevelsStateFinished_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUnBindOnSetLevelsStateFinished");
		BGUUnBindOnSetLevelsStateFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnBindOnSetLevelsStateFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnSetLevelsStateFinished_Obj_PropertyAddress, BGUUnBindOnSetLevelsStateFinished_FunctionAddress, "Obj");
		BGUUnBindOnSetLevelsStateFinished_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnSetLevelsStateFinished_FunctionAddress, "Obj");
		BGUUnBindOnSetLevelsStateFinished_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnSetLevelsStateFinished_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnSetLevelsStateFinished_FuncName_PropertyAddress, BGUUnBindOnSetLevelsStateFinished_FunctionAddress, "FuncName");
		BGUUnBindOnSetLevelsStateFinished_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnSetLevelsStateFinished_FunctionAddress, "FuncName");
		BGUUnBindOnSetLevelsStateFinished_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnSetLevelsStateFinished_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUUnBindOnSetLevelsStateFinished_IsValid = BGUUnBindOnSetLevelsStateFinished_FunctionAddress != IntPtr.Zero && BGUUnBindOnSetLevelsStateFinished_Obj_IsValid && BGUUnBindOnSetLevelsStateFinished_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnSetLevelsStateFinished", BGUUnBindOnSetLevelsStateFinished_IsValid);
		BGUUnBindOnComponentHitEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUnBindOnComponentHitEvent");
		BGUUnBindOnComponentHitEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnBindOnComponentHitEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnComponentHitEvent_Comp_PropertyAddress, BGUUnBindOnComponentHitEvent_FunctionAddress, "Comp");
		BGUUnBindOnComponentHitEvent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnComponentHitEvent_FunctionAddress, "Comp");
		BGUUnBindOnComponentHitEvent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnComponentHitEvent_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnComponentHitEvent_Obj_PropertyAddress, BGUUnBindOnComponentHitEvent_FunctionAddress, "Obj");
		BGUUnBindOnComponentHitEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnComponentHitEvent_FunctionAddress, "Obj");
		BGUUnBindOnComponentHitEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnComponentHitEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnComponentHitEvent_Func_PropertyAddress, BGUUnBindOnComponentHitEvent_FunctionAddress, "Func");
		BGUUnBindOnComponentHitEvent_Func_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnComponentHitEvent_FunctionAddress, "Func");
		BGUUnBindOnComponentHitEvent_Func_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnComponentHitEvent_FunctionAddress, "Func", Classes.FNameProperty);
		BGUUnBindOnComponentHitEvent_IsValid = BGUUnBindOnComponentHitEvent_FunctionAddress != IntPtr.Zero && BGUUnBindOnComponentHitEvent_Comp_IsValid && BGUUnBindOnComponentHitEvent_Obj_IsValid && BGUUnBindOnComponentHitEvent_Func_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnComponentHitEvent", BGUUnBindOnComponentHitEvent_IsValid);
		BGUUnBindOnComponentEndOverlapEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUnBindOnComponentEndOverlapEvent");
		BGUUnBindOnComponentEndOverlapEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnBindOnComponentEndOverlapEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnComponentEndOverlapEvent_Comp_PropertyAddress, BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, "Comp");
		BGUUnBindOnComponentEndOverlapEvent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, "Comp");
		BGUUnBindOnComponentEndOverlapEvent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnComponentEndOverlapEvent_Obj_PropertyAddress, BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, "Obj");
		BGUUnBindOnComponentEndOverlapEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, "Obj");
		BGUUnBindOnComponentEndOverlapEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnComponentEndOverlapEvent_FuncName_PropertyAddress, BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, "FuncName");
		BGUUnBindOnComponentEndOverlapEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, "FuncName");
		BGUUnBindOnComponentEndOverlapEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnComponentEndOverlapEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUUnBindOnComponentEndOverlapEvent_IsValid = BGUUnBindOnComponentEndOverlapEvent_FunctionAddress != IntPtr.Zero && BGUUnBindOnComponentEndOverlapEvent_Comp_IsValid && BGUUnBindOnComponentEndOverlapEvent_Obj_IsValid && BGUUnBindOnComponentEndOverlapEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnComponentEndOverlapEvent", BGUUnBindOnComponentEndOverlapEvent_IsValid);
		BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUnBindOnComponentBeginOverlapEvent");
		BGUUnBindOnComponentBeginOverlapEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnComponentBeginOverlapEvent_Comp_PropertyAddress, BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, "Comp");
		BGUUnBindOnComponentBeginOverlapEvent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, "Comp");
		BGUUnBindOnComponentBeginOverlapEvent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnComponentBeginOverlapEvent_Obj_PropertyAddress, BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, "Obj");
		BGUUnBindOnComponentBeginOverlapEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, "Obj");
		BGUUnBindOnComponentBeginOverlapEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnComponentBeginOverlapEvent_FuncName_PropertyAddress, BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, "FuncName");
		BGUUnBindOnComponentBeginOverlapEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, "FuncName");
		BGUUnBindOnComponentBeginOverlapEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUUnBindOnComponentBeginOverlapEvent_IsValid = BGUUnBindOnComponentBeginOverlapEvent_FunctionAddress != IntPtr.Zero && BGUUnBindOnComponentBeginOverlapEvent_Comp_IsValid && BGUUnBindOnComponentBeginOverlapEvent_Obj_IsValid && BGUUnBindOnComponentBeginOverlapEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnComponentBeginOverlapEvent", BGUUnBindOnComponentBeginOverlapEvent_IsValid);
		BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUnBindOnAllSetLevelsStateFinished");
		BGUUnBindOnAllSetLevelsStateFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnAllSetLevelsStateFinished_Obj_PropertyAddress, BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress, "Obj");
		BGUUnBindOnAllSetLevelsStateFinished_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress, "Obj");
		BGUUnBindOnAllSetLevelsStateFinished_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnAllSetLevelsStateFinished_FuncName_PropertyAddress, BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress, "FuncName");
		BGUUnBindOnAllSetLevelsStateFinished_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress, "FuncName");
		BGUUnBindOnAllSetLevelsStateFinished_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUUnBindOnAllSetLevelsStateFinished_IsValid = BGUUnBindOnAllSetLevelsStateFinished_FunctionAddress != IntPtr.Zero && BGUUnBindOnAllSetLevelsStateFinished_Obj_IsValid && BGUUnBindOnAllSetLevelsStateFinished_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUUnBindOnAllSetLevelsStateFinished", BGUUnBindOnAllSetLevelsStateFinished_IsValid);
		BGUTeleportTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUTeleportTo");
		BGUTeleportTo_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUTeleportTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUTeleportTo_Owner_PropertyAddress, BGUTeleportTo_FunctionAddress, "Owner");
		BGUTeleportTo_Owner_Offset = NativeReflectionCached.GetPropertyOffset(BGUTeleportTo_FunctionAddress, "Owner");
		BGUTeleportTo_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUTeleportTo_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUTeleportTo_DestLocation_PropertyAddress, BGUTeleportTo_FunctionAddress, "DestLocation");
		BGUTeleportTo_DestLocation_Offset = NativeReflectionCached.GetPropertyOffset(BGUTeleportTo_FunctionAddress, "DestLocation");
		BGUTeleportTo_DestLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUTeleportTo_FunctionAddress, "DestLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUTeleportTo_DestRotation_PropertyAddress, BGUTeleportTo_FunctionAddress, "DestRotation");
		BGUTeleportTo_DestRotation_Offset = NativeReflectionCached.GetPropertyOffset(BGUTeleportTo_FunctionAddress, "DestRotation");
		BGUTeleportTo_DestRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUTeleportTo_FunctionAddress, "DestRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUTeleportTo_bIsATest_PropertyAddress, BGUTeleportTo_FunctionAddress, "bIsATest");
		BGUTeleportTo_bIsATest_Offset = NativeReflectionCached.GetPropertyOffset(BGUTeleportTo_FunctionAddress, "bIsATest");
		BGUTeleportTo_bIsATest_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUTeleportTo_FunctionAddress, "bIsATest", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUTeleportTo_bNoCheck_PropertyAddress, BGUTeleportTo_FunctionAddress, "bNoCheck");
		BGUTeleportTo_bNoCheck_Offset = NativeReflectionCached.GetPropertyOffset(BGUTeleportTo_FunctionAddress, "bNoCheck");
		BGUTeleportTo_bNoCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUTeleportTo_FunctionAddress, "bNoCheck", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUTeleportTo_ReturnValue_PropertyAddress, BGUTeleportTo_FunctionAddress, "ReturnValue");
		BGUTeleportTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUTeleportTo_FunctionAddress, "ReturnValue");
		BGUTeleportTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUTeleportTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUTeleportTo_IsValid = BGUTeleportTo_FunctionAddress != IntPtr.Zero && BGUTeleportTo_Owner_IsValid && BGUTeleportTo_DestLocation_IsValid && BGUTeleportTo_DestRotation_IsValid && BGUTeleportTo_bIsATest_IsValid && BGUTeleportTo_bNoCheck_IsValid && BGUTeleportTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUTeleportTo", BGUTeleportTo_IsValid);
		BGUSpawnDecalAttached_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSpawnDecalAttached");
		BGUSpawnDecalAttached_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSpawnDecalAttached_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSpawnDecalAttached_DecalMaterial_PropertyAddress, BGUSpawnDecalAttached_FunctionAddress, "DecalMaterial");
		BGUSpawnDecalAttached_DecalMaterial_Offset = NativeReflectionCached.GetPropertyOffset(BGUSpawnDecalAttached_FunctionAddress, "DecalMaterial");
		BGUSpawnDecalAttached_DecalMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSpawnDecalAttached_FunctionAddress, "DecalMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSpawnDecalAttached_DecalSize_PropertyAddress, BGUSpawnDecalAttached_FunctionAddress, "DecalSize");
		BGUSpawnDecalAttached_DecalSize_Offset = NativeReflectionCached.GetPropertyOffset(BGUSpawnDecalAttached_FunctionAddress, "DecalSize");
		BGUSpawnDecalAttached_DecalSize_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSpawnDecalAttached_FunctionAddress, "DecalSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSpawnDecalAttached_AttachToComponent_PropertyAddress, BGUSpawnDecalAttached_FunctionAddress, "AttachToComponent");
		BGUSpawnDecalAttached_AttachToComponent_Offset = NativeReflectionCached.GetPropertyOffset(BGUSpawnDecalAttached_FunctionAddress, "AttachToComponent");
		BGUSpawnDecalAttached_AttachToComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSpawnDecalAttached_FunctionAddress, "AttachToComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSpawnDecalAttached_AttachPointName_PropertyAddress, BGUSpawnDecalAttached_FunctionAddress, "AttachPointName");
		BGUSpawnDecalAttached_AttachPointName_Offset = NativeReflectionCached.GetPropertyOffset(BGUSpawnDecalAttached_FunctionAddress, "AttachPointName");
		BGUSpawnDecalAttached_AttachPointName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSpawnDecalAttached_FunctionAddress, "AttachPointName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSpawnDecalAttached_Location_PropertyAddress, BGUSpawnDecalAttached_FunctionAddress, "Location");
		BGUSpawnDecalAttached_Location_Offset = NativeReflectionCached.GetPropertyOffset(BGUSpawnDecalAttached_FunctionAddress, "Location");
		BGUSpawnDecalAttached_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSpawnDecalAttached_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSpawnDecalAttached_Rotation_PropertyAddress, BGUSpawnDecalAttached_FunctionAddress, "Rotation");
		BGUSpawnDecalAttached_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(BGUSpawnDecalAttached_FunctionAddress, "Rotation");
		BGUSpawnDecalAttached_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSpawnDecalAttached_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSpawnDecalAttached_LocationType_PropertyAddress, BGUSpawnDecalAttached_FunctionAddress, "LocationType");
		BGUSpawnDecalAttached_LocationType_Offset = NativeReflectionCached.GetPropertyOffset(BGUSpawnDecalAttached_FunctionAddress, "LocationType");
		BGUSpawnDecalAttached_LocationType_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSpawnDecalAttached_FunctionAddress, "LocationType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSpawnDecalAttached_LifeSpan_PropertyAddress, BGUSpawnDecalAttached_FunctionAddress, "LifeSpan");
		BGUSpawnDecalAttached_LifeSpan_Offset = NativeReflectionCached.GetPropertyOffset(BGUSpawnDecalAttached_FunctionAddress, "LifeSpan");
		BGUSpawnDecalAttached_LifeSpan_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSpawnDecalAttached_FunctionAddress, "LifeSpan", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSpawnDecalAttached_ReturnValue_PropertyAddress, BGUSpawnDecalAttached_FunctionAddress, "ReturnValue");
		BGUSpawnDecalAttached_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUSpawnDecalAttached_FunctionAddress, "ReturnValue");
		BGUSpawnDecalAttached_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSpawnDecalAttached_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUSpawnDecalAttached_IsValid = BGUSpawnDecalAttached_FunctionAddress != IntPtr.Zero && BGUSpawnDecalAttached_DecalMaterial_IsValid && BGUSpawnDecalAttached_DecalSize_IsValid && BGUSpawnDecalAttached_AttachToComponent_IsValid && BGUSpawnDecalAttached_AttachPointName_IsValid && BGUSpawnDecalAttached_Location_IsValid && BGUSpawnDecalAttached_Rotation_IsValid && BGUSpawnDecalAttached_LocationType_IsValid && BGUSpawnDecalAttached_LifeSpan_IsValid && BGUSpawnDecalAttached_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUSpawnDecalAttached", BGUSpawnDecalAttached_IsValid);
		BGUSliceProceduralMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSliceProceduralMesh");
		BGUSliceProceduralMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSliceProceduralMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSliceProceduralMesh_InProcMesh_PropertyAddress, BGUSliceProceduralMesh_FunctionAddress, "InProcMesh");
		BGUSliceProceduralMesh_InProcMesh_Offset = NativeReflectionCached.GetPropertyOffset(BGUSliceProceduralMesh_FunctionAddress, "InProcMesh");
		BGUSliceProceduralMesh_InProcMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSliceProceduralMesh_FunctionAddress, "InProcMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSliceProceduralMesh_PlanePosition_PropertyAddress, BGUSliceProceduralMesh_FunctionAddress, "PlanePosition");
		BGUSliceProceduralMesh_PlanePosition_Offset = NativeReflectionCached.GetPropertyOffset(BGUSliceProceduralMesh_FunctionAddress, "PlanePosition");
		BGUSliceProceduralMesh_PlanePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSliceProceduralMesh_FunctionAddress, "PlanePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSliceProceduralMesh_PlaneNormal_PropertyAddress, BGUSliceProceduralMesh_FunctionAddress, "PlaneNormal");
		BGUSliceProceduralMesh_PlaneNormal_Offset = NativeReflectionCached.GetPropertyOffset(BGUSliceProceduralMesh_FunctionAddress, "PlaneNormal");
		BGUSliceProceduralMesh_PlaneNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSliceProceduralMesh_FunctionAddress, "PlaneNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSliceProceduralMesh_bCreateOtherHalf_PropertyAddress, BGUSliceProceduralMesh_FunctionAddress, "bCreateOtherHalf");
		BGUSliceProceduralMesh_bCreateOtherHalf_Offset = NativeReflectionCached.GetPropertyOffset(BGUSliceProceduralMesh_FunctionAddress, "bCreateOtherHalf");
		BGUSliceProceduralMesh_bCreateOtherHalf_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSliceProceduralMesh_FunctionAddress, "bCreateOtherHalf", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSliceProceduralMesh_OutOtherHalfProcMesh_PropertyAddress, BGUSliceProceduralMesh_FunctionAddress, "OutOtherHalfProcMesh");
		BGUSliceProceduralMesh_OutOtherHalfProcMesh_Offset = NativeReflectionCached.GetPropertyOffset(BGUSliceProceduralMesh_FunctionAddress, "OutOtherHalfProcMesh");
		BGUSliceProceduralMesh_OutOtherHalfProcMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSliceProceduralMesh_FunctionAddress, "OutOtherHalfProcMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSliceProceduralMesh_CapOption_PropertyAddress, BGUSliceProceduralMesh_FunctionAddress, "CapOption");
		BGUSliceProceduralMesh_CapOption_Offset = NativeReflectionCached.GetPropertyOffset(BGUSliceProceduralMesh_FunctionAddress, "CapOption");
		BGUSliceProceduralMesh_CapOption_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSliceProceduralMesh_FunctionAddress, "CapOption", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSliceProceduralMesh_CapMaterial_PropertyAddress, BGUSliceProceduralMesh_FunctionAddress, "CapMaterial");
		BGUSliceProceduralMesh_CapMaterial_Offset = NativeReflectionCached.GetPropertyOffset(BGUSliceProceduralMesh_FunctionAddress, "CapMaterial");
		BGUSliceProceduralMesh_CapMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSliceProceduralMesh_FunctionAddress, "CapMaterial", Classes.FObjectProperty);
		BGUSliceProceduralMesh_IsValid = BGUSliceProceduralMesh_FunctionAddress != IntPtr.Zero && BGUSliceProceduralMesh_InProcMesh_IsValid && BGUSliceProceduralMesh_PlanePosition_IsValid && BGUSliceProceduralMesh_PlaneNormal_IsValid && BGUSliceProceduralMesh_bCreateOtherHalf_IsValid && BGUSliceProceduralMesh_OutOtherHalfProcMesh_IsValid && BGUSliceProceduralMesh_CapOption_IsValid && BGUSliceProceduralMesh_CapMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUSliceProceduralMesh", BGUSliceProceduralMesh_IsValid);
		BGUSetParticleSysSortPriority_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetParticleSysSortPriority");
		BGUSetParticleSysSortPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetParticleSysSortPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetParticleSysSortPriority_ParticleSystemComp_PropertyAddress, BGUSetParticleSysSortPriority_FunctionAddress, "ParticleSystemComp");
		BGUSetParticleSysSortPriority_ParticleSystemComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetParticleSysSortPriority_FunctionAddress, "ParticleSystemComp");
		BGUSetParticleSysSortPriority_ParticleSystemComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetParticleSysSortPriority_FunctionAddress, "ParticleSystemComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetParticleSysSortPriority_SortPriority_PropertyAddress, BGUSetParticleSysSortPriority_FunctionAddress, "SortPriority");
		BGUSetParticleSysSortPriority_SortPriority_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetParticleSysSortPriority_FunctionAddress, "SortPriority");
		BGUSetParticleSysSortPriority_SortPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetParticleSysSortPriority_FunctionAddress, "SortPriority", Classes.FIntProperty);
		BGUSetParticleSysSortPriority_IsValid = BGUSetParticleSysSortPriority_FunctionAddress != IntPtr.Zero && BGUSetParticleSysSortPriority_ParticleSystemComp_IsValid && BGUSetParticleSysSortPriority_SortPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUSetParticleSysSortPriority", BGUSetParticleSysSortPriority_IsValid);
		BGUSetParticleSysCompPoolingMethod_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetParticleSysCompPoolingMethod");
		BGUSetParticleSysCompPoolingMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetParticleSysCompPoolingMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetParticleSysCompPoolingMethod_ParticleComp_PropertyAddress, BGUSetParticleSysCompPoolingMethod_FunctionAddress, "ParticleComp");
		BGUSetParticleSysCompPoolingMethod_ParticleComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetParticleSysCompPoolingMethod_FunctionAddress, "ParticleComp");
		BGUSetParticleSysCompPoolingMethod_ParticleComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetParticleSysCompPoolingMethod_FunctionAddress, "ParticleComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetParticleSysCompPoolingMethod_PoolMethod_PropertyAddress, BGUSetParticleSysCompPoolingMethod_FunctionAddress, "PoolMethod");
		BGUSetParticleSysCompPoolingMethod_PoolMethod_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetParticleSysCompPoolingMethod_FunctionAddress, "PoolMethod");
		BGUSetParticleSysCompPoolingMethod_PoolMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetParticleSysCompPoolingMethod_FunctionAddress, "PoolMethod", Classes.FEnumProperty);
		BGUSetParticleSysCompPoolingMethod_IsValid = BGUSetParticleSysCompPoolingMethod_FunctionAddress != IntPtr.Zero && BGUSetParticleSysCompPoolingMethod_ParticleComp_IsValid && BGUSetParticleSysCompPoolingMethod_PoolMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUSetParticleSysCompPoolingMethod", BGUSetParticleSysCompPoolingMethod_IsValid);
		BGUSetIKComponentValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetIKComponentValid");
		BGUSetIKComponentValid_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetIKComponentValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetIKComponentValid_Character_PropertyAddress, BGUSetIKComponentValid_FunctionAddress, "Character");
		BGUSetIKComponentValid_Character_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetIKComponentValid_FunctionAddress, "Character");
		BGUSetIKComponentValid_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetIKComponentValid_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetIKComponentValid_NewValid_PropertyAddress, BGUSetIKComponentValid_FunctionAddress, "NewValid");
		BGUSetIKComponentValid_NewValid_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetIKComponentValid_FunctionAddress, "NewValid");
		BGUSetIKComponentValid_NewValid_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetIKComponentValid_FunctionAddress, "NewValid", Classes.FBoolProperty);
		BGUSetIKComponentValid_IsValid = BGUSetIKComponentValid_FunctionAddress != IntPtr.Zero && BGUSetIKComponentValid_Character_IsValid && BGUSetIKComponentValid_NewValid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUSetIKComponentValid", BGUSetIKComponentValid_IsValid);
		BGUSetDecalSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetDecalSize");
		BGUSetDecalSize_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetDecalSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetDecalSize_DecalComp_PropertyAddress, BGUSetDecalSize_FunctionAddress, "DecalComp");
		BGUSetDecalSize_DecalComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetDecalSize_FunctionAddress, "DecalComp");
		BGUSetDecalSize_DecalComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetDecalSize_FunctionAddress, "DecalComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetDecalSize_Size_PropertyAddress, BGUSetDecalSize_FunctionAddress, "Size");
		BGUSetDecalSize_Size_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetDecalSize_FunctionAddress, "Size");
		BGUSetDecalSize_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetDecalSize_FunctionAddress, "Size", Classes.FStructProperty);
		BGUSetDecalSize_IsValid = BGUSetDecalSize_FunctionAddress != IntPtr.Zero && BGUSetDecalSize_DecalComp_IsValid && BGUSetDecalSize_Size_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUSetDecalSize", BGUSetDecalSize_IsValid);
		BGURestartBT_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGURestartBT");
		BGURestartBT_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURestartBT_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGURestartBT_AIController_PropertyAddress, BGURestartBT_FunctionAddress, "AIController");
		BGURestartBT_AIController_Offset = NativeReflectionCached.GetPropertyOffset(BGURestartBT_FunctionAddress, "AIController");
		BGURestartBT_AIController_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURestartBT_FunctionAddress, "AIController", Classes.FObjectProperty);
		BGURestartBT_IsValid = BGURestartBT_FunctionAddress != IntPtr.Zero && BGURestartBT_AIController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGURestartBT", BGURestartBT_IsValid);
		BGURegistComp_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGURegistComp");
		BGURegistComp_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURegistComp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGURegistComp_WorldContextObject_PropertyAddress, BGURegistComp_FunctionAddress, "WorldContextObject");
		BGURegistComp_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGURegistComp_FunctionAddress, "WorldContextObject");
		BGURegistComp_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURegistComp_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURegistComp_ActorComp_PropertyAddress, BGURegistComp_FunctionAddress, "ActorComp");
		BGURegistComp_ActorComp_Offset = NativeReflectionCached.GetPropertyOffset(BGURegistComp_FunctionAddress, "ActorComp");
		BGURegistComp_ActorComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURegistComp_FunctionAddress, "ActorComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURegistComp_ReturnValue_PropertyAddress, BGURegistComp_FunctionAddress, "ReturnValue");
		BGURegistComp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGURegistComp_FunctionAddress, "ReturnValue");
		BGURegistComp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURegistComp_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGURegistComp_IsValid = BGURegistComp_FunctionAddress != IntPtr.Zero && BGURegistComp_WorldContextObject_IsValid && BGURegistComp_ActorComp_IsValid && BGURegistComp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGURegistComp", BGURegistComp_IsValid);
		BGUMovementComponentSlideAlongSurface_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUMovementComponentSlideAlongSurface");
		BGUMovementComponentSlideAlongSurface_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMovementComponentSlideAlongSurface_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentSlideAlongSurface_MoveComp_PropertyAddress, BGUMovementComponentSlideAlongSurface_FunctionAddress, "MoveComp");
		BGUMovementComponentSlideAlongSurface_MoveComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentSlideAlongSurface_FunctionAddress, "MoveComp");
		BGUMovementComponentSlideAlongSurface_MoveComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentSlideAlongSurface_FunctionAddress, "MoveComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentSlideAlongSurface_Delta_PropertyAddress, BGUMovementComponentSlideAlongSurface_FunctionAddress, "Delta");
		BGUMovementComponentSlideAlongSurface_Delta_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentSlideAlongSurface_FunctionAddress, "Delta");
		BGUMovementComponentSlideAlongSurface_Delta_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentSlideAlongSurface_FunctionAddress, "Delta", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentSlideAlongSurface_Time_PropertyAddress, BGUMovementComponentSlideAlongSurface_FunctionAddress, "Time");
		BGUMovementComponentSlideAlongSurface_Time_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentSlideAlongSurface_FunctionAddress, "Time");
		BGUMovementComponentSlideAlongSurface_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentSlideAlongSurface_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentSlideAlongSurface_Normal_PropertyAddress, BGUMovementComponentSlideAlongSurface_FunctionAddress, "Normal");
		BGUMovementComponentSlideAlongSurface_Normal_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentSlideAlongSurface_FunctionAddress, "Normal");
		BGUMovementComponentSlideAlongSurface_Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentSlideAlongSurface_FunctionAddress, "Normal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentSlideAlongSurface_InHit_PropertyAddress, BGUMovementComponentSlideAlongSurface_FunctionAddress, "InHit");
		BGUMovementComponentSlideAlongSurface_InHit_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentSlideAlongSurface_FunctionAddress, "InHit");
		BGUMovementComponentSlideAlongSurface_InHit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentSlideAlongSurface_FunctionAddress, "InHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentSlideAlongSurface_bHandleImpact_PropertyAddress, BGUMovementComponentSlideAlongSurface_FunctionAddress, "bHandleImpact");
		BGUMovementComponentSlideAlongSurface_bHandleImpact_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentSlideAlongSurface_FunctionAddress, "bHandleImpact");
		BGUMovementComponentSlideAlongSurface_bHandleImpact_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentSlideAlongSurface_FunctionAddress, "bHandleImpact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentSlideAlongSurface_OutHit_PropertyAddress, BGUMovementComponentSlideAlongSurface_FunctionAddress, "OutHit");
		BGUMovementComponentSlideAlongSurface_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentSlideAlongSurface_FunctionAddress, "OutHit");
		BGUMovementComponentSlideAlongSurface_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentSlideAlongSurface_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentSlideAlongSurface_ReturnValue_PropertyAddress, BGUMovementComponentSlideAlongSurface_FunctionAddress, "ReturnValue");
		BGUMovementComponentSlideAlongSurface_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentSlideAlongSurface_FunctionAddress, "ReturnValue");
		BGUMovementComponentSlideAlongSurface_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentSlideAlongSurface_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUMovementComponentSlideAlongSurface_IsValid = BGUMovementComponentSlideAlongSurface_FunctionAddress != IntPtr.Zero && BGUMovementComponentSlideAlongSurface_MoveComp_IsValid && BGUMovementComponentSlideAlongSurface_Delta_IsValid && BGUMovementComponentSlideAlongSurface_Time_IsValid && BGUMovementComponentSlideAlongSurface_Normal_IsValid && BGUMovementComponentSlideAlongSurface_InHit_IsValid && BGUMovementComponentSlideAlongSurface_bHandleImpact_IsValid && BGUMovementComponentSlideAlongSurface_OutHit_IsValid && BGUMovementComponentSlideAlongSurface_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUMovementComponentSlideAlongSurface", BGUMovementComponentSlideAlongSurface_IsValid);
		BGUMovementComponentHandleImpact_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUMovementComponentHandleImpact");
		BGUMovementComponentHandleImpact_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMovementComponentHandleImpact_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentHandleImpact_MoveComp_PropertyAddress, BGUMovementComponentHandleImpact_FunctionAddress, "MoveComp");
		BGUMovementComponentHandleImpact_MoveComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentHandleImpact_FunctionAddress, "MoveComp");
		BGUMovementComponentHandleImpact_MoveComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentHandleImpact_FunctionAddress, "MoveComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentHandleImpact_Hit_PropertyAddress, BGUMovementComponentHandleImpact_FunctionAddress, "Hit");
		BGUMovementComponentHandleImpact_Hit_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentHandleImpact_FunctionAddress, "Hit");
		BGUMovementComponentHandleImpact_Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentHandleImpact_FunctionAddress, "Hit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentHandleImpact_TimeSlice_PropertyAddress, BGUMovementComponentHandleImpact_FunctionAddress, "TimeSlice");
		BGUMovementComponentHandleImpact_TimeSlice_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentHandleImpact_FunctionAddress, "TimeSlice");
		BGUMovementComponentHandleImpact_TimeSlice_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentHandleImpact_FunctionAddress, "TimeSlice", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementComponentHandleImpact_MoveDelta_PropertyAddress, BGUMovementComponentHandleImpact_FunctionAddress, "MoveDelta");
		BGUMovementComponentHandleImpact_MoveDelta_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementComponentHandleImpact_FunctionAddress, "MoveDelta");
		BGUMovementComponentHandleImpact_MoveDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementComponentHandleImpact_FunctionAddress, "MoveDelta", Classes.FStructProperty);
		BGUMovementComponentHandleImpact_IsValid = BGUMovementComponentHandleImpact_FunctionAddress != IntPtr.Zero && BGUMovementComponentHandleImpact_MoveComp_IsValid && BGUMovementComponentHandleImpact_Hit_IsValid && BGUMovementComponentHandleImpact_TimeSlice_IsValid && BGUMovementComponentHandleImpact_MoveDelta_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUMovementComponentHandleImpact", BGUMovementComponentHandleImpact_IsValid);
		BGUIsBlackBoardKeyTypeMatch_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUIsBlackBoardKeyTypeMatch");
		BGUIsBlackBoardKeyTypeMatch_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUIsBlackBoardKeyTypeMatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUIsBlackBoardKeyTypeMatch_BBKey_PropertyAddress, BGUIsBlackBoardKeyTypeMatch_FunctionAddress, "BBKey");
		BGUIsBlackBoardKeyTypeMatch_BBKey_Offset = NativeReflectionCached.GetPropertyOffset(BGUIsBlackBoardKeyTypeMatch_FunctionAddress, "BBKey");
		BGUIsBlackBoardKeyTypeMatch_BBKey_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUIsBlackBoardKeyTypeMatch_FunctionAddress, "BBKey", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUIsBlackBoardKeyTypeMatch_BBKeyType_PropertyAddress, BGUIsBlackBoardKeyTypeMatch_FunctionAddress, "BBKeyType");
		BGUIsBlackBoardKeyTypeMatch_BBKeyType_Offset = NativeReflectionCached.GetPropertyOffset(BGUIsBlackBoardKeyTypeMatch_FunctionAddress, "BBKeyType");
		BGUIsBlackBoardKeyTypeMatch_BBKeyType_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUIsBlackBoardKeyTypeMatch_FunctionAddress, "BBKeyType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUIsBlackBoardKeyTypeMatch_ReturnValue_PropertyAddress, BGUIsBlackBoardKeyTypeMatch_FunctionAddress, "ReturnValue");
		BGUIsBlackBoardKeyTypeMatch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUIsBlackBoardKeyTypeMatch_FunctionAddress, "ReturnValue");
		BGUIsBlackBoardKeyTypeMatch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUIsBlackBoardKeyTypeMatch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUIsBlackBoardKeyTypeMatch_IsValid = BGUIsBlackBoardKeyTypeMatch_FunctionAddress != IntPtr.Zero && BGUIsBlackBoardKeyTypeMatch_BBKey_IsValid && BGUIsBlackBoardKeyTypeMatch_BBKeyType_IsValid && BGUIsBlackBoardKeyTypeMatch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUIsBlackBoardKeyTypeMatch", BGUIsBlackBoardKeyTypeMatch_IsValid);
		BGUGetUWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetUWorld");
		BGUGetUWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetUWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetUWorld_InnerObject_PropertyAddress, BGUGetUWorld_FunctionAddress, "InnerObject");
		BGUGetUWorld_InnerObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetUWorld_FunctionAddress, "InnerObject");
		BGUGetUWorld_InnerObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetUWorld_FunctionAddress, "InnerObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetUWorld_ReturnValue_PropertyAddress, BGUGetUWorld_FunctionAddress, "ReturnValue");
		BGUGetUWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetUWorld_FunctionAddress, "ReturnValue");
		BGUGetUWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetUWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGetUWorld_IsValid = BGUGetUWorld_FunctionAddress != IntPtr.Zero && BGUGetUWorld_InnerObject_IsValid && BGUGetUWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetUWorld", BGUGetUWorld_IsValid);
		BGUGetSectionFromProceduralMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetSectionFromProceduralMesh");
		BGUGetSectionFromProceduralMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetSectionFromProceduralMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSectionFromProceduralMesh_InProcMesh_PropertyAddress, BGUGetSectionFromProceduralMesh_FunctionAddress, "InProcMesh");
		BGUGetSectionFromProceduralMesh_InProcMesh_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSectionFromProceduralMesh_FunctionAddress, "InProcMesh");
		BGUGetSectionFromProceduralMesh_InProcMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSectionFromProceduralMesh_FunctionAddress, "InProcMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSectionFromProceduralMesh_SectionIndex_PropertyAddress, BGUGetSectionFromProceduralMesh_FunctionAddress, "SectionIndex");
		BGUGetSectionFromProceduralMesh_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSectionFromProceduralMesh_FunctionAddress, "SectionIndex");
		BGUGetSectionFromProceduralMesh_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSectionFromProceduralMesh_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSectionFromProceduralMesh_Vertices_PropertyAddress, BGUGetSectionFromProceduralMesh_FunctionAddress, "Vertices");
		BGUGetSectionFromProceduralMesh_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSectionFromProceduralMesh_FunctionAddress, "Vertices");
		BGUGetSectionFromProceduralMesh_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSectionFromProceduralMesh_FunctionAddress, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSectionFromProceduralMesh_Triangles_PropertyAddress, BGUGetSectionFromProceduralMesh_FunctionAddress, "Triangles");
		BGUGetSectionFromProceduralMesh_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSectionFromProceduralMesh_FunctionAddress, "Triangles");
		BGUGetSectionFromProceduralMesh_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSectionFromProceduralMesh_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSectionFromProceduralMesh_Normals_PropertyAddress, BGUGetSectionFromProceduralMesh_FunctionAddress, "Normals");
		BGUGetSectionFromProceduralMesh_Normals_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSectionFromProceduralMesh_FunctionAddress, "Normals");
		BGUGetSectionFromProceduralMesh_Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSectionFromProceduralMesh_FunctionAddress, "Normals", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSectionFromProceduralMesh_UVs_PropertyAddress, BGUGetSectionFromProceduralMesh_FunctionAddress, "UVs");
		BGUGetSectionFromProceduralMesh_UVs_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSectionFromProceduralMesh_FunctionAddress, "UVs");
		BGUGetSectionFromProceduralMesh_UVs_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSectionFromProceduralMesh_FunctionAddress, "UVs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSectionFromProceduralMesh_Tangents_PropertyAddress, BGUGetSectionFromProceduralMesh_FunctionAddress, "Tangents");
		BGUGetSectionFromProceduralMesh_Tangents_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSectionFromProceduralMesh_FunctionAddress, "Tangents");
		BGUGetSectionFromProceduralMesh_Tangents_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSectionFromProceduralMesh_FunctionAddress, "Tangents", Classes.FArrayProperty);
		BGUGetSectionFromProceduralMesh_IsValid = BGUGetSectionFromProceduralMesh_FunctionAddress != IntPtr.Zero && BGUGetSectionFromProceduralMesh_InProcMesh_IsValid && BGUGetSectionFromProceduralMesh_SectionIndex_IsValid && BGUGetSectionFromProceduralMesh_Vertices_IsValid && BGUGetSectionFromProceduralMesh_Triangles_IsValid && BGUGetSectionFromProceduralMesh_Normals_IsValid && BGUGetSectionFromProceduralMesh_UVs_IsValid && BGUGetSectionFromProceduralMesh_Tangents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetSectionFromProceduralMesh", BGUGetSectionFromProceduralMesh_IsValid);
		BGUGetParticleSystemIsLooping_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetParticleSystemIsLooping");
		BGUGetParticleSystemIsLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetParticleSystemIsLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetParticleSystemIsLooping_ParticleForPlay_PropertyAddress, BGUGetParticleSystemIsLooping_FunctionAddress, "ParticleForPlay");
		BGUGetParticleSystemIsLooping_ParticleForPlay_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetParticleSystemIsLooping_FunctionAddress, "ParticleForPlay");
		BGUGetParticleSystemIsLooping_ParticleForPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetParticleSystemIsLooping_FunctionAddress, "ParticleForPlay", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetParticleSystemIsLooping_ReturnValue_PropertyAddress, BGUGetParticleSystemIsLooping_FunctionAddress, "ReturnValue");
		BGUGetParticleSystemIsLooping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetParticleSystemIsLooping_FunctionAddress, "ReturnValue");
		BGUGetParticleSystemIsLooping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetParticleSystemIsLooping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetParticleSystemIsLooping_IsValid = BGUGetParticleSystemIsLooping_FunctionAddress != IntPtr.Zero && BGUGetParticleSystemIsLooping_ParticleForPlay_IsValid && BGUGetParticleSystemIsLooping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetParticleSystemIsLooping", BGUGetParticleSystemIsLooping_IsValid);
		BGUGetPARadiusByBoneName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetPARadiusByBoneName");
		BGUGetPARadiusByBoneName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetPARadiusByBoneName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetPARadiusByBoneName_PA_PropertyAddress, BGUGetPARadiusByBoneName_FunctionAddress, "PA");
		BGUGetPARadiusByBoneName_PA_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetPARadiusByBoneName_FunctionAddress, "PA");
		BGUGetPARadiusByBoneName_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetPARadiusByBoneName_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetPARadiusByBoneName_BoneName_PropertyAddress, BGUGetPARadiusByBoneName_FunctionAddress, "BoneName");
		BGUGetPARadiusByBoneName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetPARadiusByBoneName_FunctionAddress, "BoneName");
		BGUGetPARadiusByBoneName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetPARadiusByBoneName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetPARadiusByBoneName_BodyRadius_PropertyAddress, BGUGetPARadiusByBoneName_FunctionAddress, "BodyRadius");
		BGUGetPARadiusByBoneName_BodyRadius_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetPARadiusByBoneName_FunctionAddress, "BodyRadius");
		BGUGetPARadiusByBoneName_BodyRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetPARadiusByBoneName_FunctionAddress, "BodyRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetPARadiusByBoneName_ReturnValue_PropertyAddress, BGUGetPARadiusByBoneName_FunctionAddress, "ReturnValue");
		BGUGetPARadiusByBoneName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetPARadiusByBoneName_FunctionAddress, "ReturnValue");
		BGUGetPARadiusByBoneName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetPARadiusByBoneName_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetPARadiusByBoneName_IsValid = BGUGetPARadiusByBoneName_FunctionAddress != IntPtr.Zero && BGUGetPARadiusByBoneName_PA_IsValid && BGUGetPARadiusByBoneName_BoneName_IsValid && BGUGetPARadiusByBoneName_BodyRadius_IsValid && BGUGetPARadiusByBoneName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetPARadiusByBoneName", BGUGetPARadiusByBoneName_IsValid);
		BGUGetPaperSpriteSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetPaperSpriteSize");
		BGUGetPaperSpriteSize_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetPaperSpriteSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetPaperSpriteSize_PaperSprite_PropertyAddress, BGUGetPaperSpriteSize_FunctionAddress, "PaperSprite");
		BGUGetPaperSpriteSize_PaperSprite_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetPaperSpriteSize_FunctionAddress, "PaperSprite");
		BGUGetPaperSpriteSize_PaperSprite_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetPaperSpriteSize_FunctionAddress, "PaperSprite", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetPaperSpriteSize_ReturnValue_PropertyAddress, BGUGetPaperSpriteSize_FunctionAddress, "ReturnValue");
		BGUGetPaperSpriteSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetPaperSpriteSize_FunctionAddress, "ReturnValue");
		BGUGetPaperSpriteSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetPaperSpriteSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BGUGetPaperSpriteSize_IsValid = BGUGetPaperSpriteSize_FunctionAddress != IntPtr.Zero && BGUGetPaperSpriteSize_PaperSprite_IsValid && BGUGetPaperSpriteSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetPaperSpriteSize", BGUGetPaperSpriteSize_IsValid);
		BGUGetMeshPredictedLODLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetMeshPredictedLODLevel");
		BGUGetMeshPredictedLODLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetMeshPredictedLODLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMeshPredictedLODLevel_MeshComp_PropertyAddress, BGUGetMeshPredictedLODLevel_FunctionAddress, "MeshComp");
		BGUGetMeshPredictedLODLevel_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMeshPredictedLODLevel_FunctionAddress, "MeshComp");
		BGUGetMeshPredictedLODLevel_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMeshPredictedLODLevel_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMeshPredictedLODLevel_ReturnValue_PropertyAddress, BGUGetMeshPredictedLODLevel_FunctionAddress, "ReturnValue");
		BGUGetMeshPredictedLODLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMeshPredictedLODLevel_FunctionAddress, "ReturnValue");
		BGUGetMeshPredictedLODLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMeshPredictedLODLevel_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetMeshPredictedLODLevel_IsValid = BGUGetMeshPredictedLODLevel_FunctionAddress != IntPtr.Zero && BGUGetMeshPredictedLODLevel_MeshComp_IsValid && BGUGetMeshPredictedLODLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetMeshPredictedLODLevel", BGUGetMeshPredictedLODLevel_IsValid);
		BGUGetLevelSequenceLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetLevelSequenceLength");
		BGUGetLevelSequenceLength_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetLevelSequenceLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetLevelSequenceLength_LeveleSequencePlayer_PropertyAddress, BGUGetLevelSequenceLength_FunctionAddress, "LeveleSequencePlayer");
		BGUGetLevelSequenceLength_LeveleSequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetLevelSequenceLength_FunctionAddress, "LeveleSequencePlayer");
		BGUGetLevelSequenceLength_LeveleSequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetLevelSequenceLength_FunctionAddress, "LeveleSequencePlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetLevelSequenceLength_ReturnValue_PropertyAddress, BGUGetLevelSequenceLength_FunctionAddress, "ReturnValue");
		BGUGetLevelSequenceLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetLevelSequenceLength_FunctionAddress, "ReturnValue");
		BGUGetLevelSequenceLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetLevelSequenceLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetLevelSequenceLength_IsValid = BGUGetLevelSequenceLength_FunctionAddress != IntPtr.Zero && BGUGetLevelSequenceLength_LeveleSequencePlayer_IsValid && BGUGetLevelSequenceLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetLevelSequenceLength", BGUGetLevelSequenceLength_IsValid);
		BGUGetLevelSequenceCurTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetLevelSequenceCurTime");
		BGUGetLevelSequenceCurTime_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetLevelSequenceCurTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetLevelSequenceCurTime_LeveleSequencePlayer_PropertyAddress, BGUGetLevelSequenceCurTime_FunctionAddress, "LeveleSequencePlayer");
		BGUGetLevelSequenceCurTime_LeveleSequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetLevelSequenceCurTime_FunctionAddress, "LeveleSequencePlayer");
		BGUGetLevelSequenceCurTime_LeveleSequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetLevelSequenceCurTime_FunctionAddress, "LeveleSequencePlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetLevelSequenceCurTime_ReturnValue_PropertyAddress, BGUGetLevelSequenceCurTime_FunctionAddress, "ReturnValue");
		BGUGetLevelSequenceCurTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetLevelSequenceCurTime_FunctionAddress, "ReturnValue");
		BGUGetLevelSequenceCurTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetLevelSequenceCurTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetLevelSequenceCurTime_IsValid = BGUGetLevelSequenceCurTime_FunctionAddress != IntPtr.Zero && BGUGetLevelSequenceCurTime_LeveleSequencePlayer_IsValid && BGUGetLevelSequenceCurTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetLevelSequenceCurTime", BGUGetLevelSequenceCurTime_IsValid);
		BGUGetLandscapeExtent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetLandscapeExtent");
		BGUGetLandscapeExtent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetLandscapeExtent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetLandscapeExtent_Landscape_PropertyAddress, BGUGetLandscapeExtent_FunctionAddress, "Landscape");
		BGUGetLandscapeExtent_Landscape_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetLandscapeExtent_FunctionAddress, "Landscape");
		BGUGetLandscapeExtent_Landscape_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetLandscapeExtent_FunctionAddress, "Landscape", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetLandscapeExtent_MinX_PropertyAddress, BGUGetLandscapeExtent_FunctionAddress, "MinX");
		BGUGetLandscapeExtent_MinX_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetLandscapeExtent_FunctionAddress, "MinX");
		BGUGetLandscapeExtent_MinX_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetLandscapeExtent_FunctionAddress, "MinX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetLandscapeExtent_MinY_PropertyAddress, BGUGetLandscapeExtent_FunctionAddress, "MinY");
		BGUGetLandscapeExtent_MinY_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetLandscapeExtent_FunctionAddress, "MinY");
		BGUGetLandscapeExtent_MinY_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetLandscapeExtent_FunctionAddress, "MinY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetLandscapeExtent_MaxX_PropertyAddress, BGUGetLandscapeExtent_FunctionAddress, "MaxX");
		BGUGetLandscapeExtent_MaxX_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetLandscapeExtent_FunctionAddress, "MaxX");
		BGUGetLandscapeExtent_MaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetLandscapeExtent_FunctionAddress, "MaxX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetLandscapeExtent_MaxY_PropertyAddress, BGUGetLandscapeExtent_FunctionAddress, "MaxY");
		BGUGetLandscapeExtent_MaxY_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetLandscapeExtent_FunctionAddress, "MaxY");
		BGUGetLandscapeExtent_MaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetLandscapeExtent_FunctionAddress, "MaxY", Classes.FIntProperty);
		BGUGetLandscapeExtent_IsValid = BGUGetLandscapeExtent_FunctionAddress != IntPtr.Zero && BGUGetLandscapeExtent_Landscape_IsValid && BGUGetLandscapeExtent_MinX_IsValid && BGUGetLandscapeExtent_MinY_IsValid && BGUGetLandscapeExtent_MaxX_IsValid && BGUGetLandscapeExtent_MaxY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetLandscapeExtent", BGUGetLandscapeExtent_IsValid);
		BGUGetIsRuntionShowCollision_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetIsRuntionShowCollision");
		BGUGetIsRuntionShowCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetIsRuntionShowCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetIsRuntionShowCollision_WorldContextObject_PropertyAddress, BGUGetIsRuntionShowCollision_FunctionAddress, "WorldContextObject");
		BGUGetIsRuntionShowCollision_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetIsRuntionShowCollision_FunctionAddress, "WorldContextObject");
		BGUGetIsRuntionShowCollision_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetIsRuntionShowCollision_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetIsRuntionShowCollision_ReturnValue_PropertyAddress, BGUGetIsRuntionShowCollision_FunctionAddress, "ReturnValue");
		BGUGetIsRuntionShowCollision_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetIsRuntionShowCollision_FunctionAddress, "ReturnValue");
		BGUGetIsRuntionShowCollision_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetIsRuntionShowCollision_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetIsRuntionShowCollision_IsValid = BGUGetIsRuntionShowCollision_FunctionAddress != IntPtr.Zero && BGUGetIsRuntionShowCollision_WorldContextObject_IsValid && BGUGetIsRuntionShowCollision_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsRuntionShowCollision", BGUGetIsRuntionShowCollision_IsValid);
		BGUGetIsInGameWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetIsInGameWorld");
		BGUGetIsInGameWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetIsInGameWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetIsInGameWorld_WorldContextObject_PropertyAddress, BGUGetIsInGameWorld_FunctionAddress, "WorldContextObject");
		BGUGetIsInGameWorld_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetIsInGameWorld_FunctionAddress, "WorldContextObject");
		BGUGetIsInGameWorld_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetIsInGameWorld_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetIsInGameWorld_ReturnValue_PropertyAddress, BGUGetIsInGameWorld_FunctionAddress, "ReturnValue");
		BGUGetIsInGameWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetIsInGameWorld_FunctionAddress, "ReturnValue");
		BGUGetIsInGameWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetIsInGameWorld_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetIsInGameWorld_IsValid = BGUGetIsInGameWorld_FunctionAddress != IntPtr.Zero && BGUGetIsInGameWorld_WorldContextObject_IsValid && BGUGetIsInGameWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsInGameWorld", BGUGetIsInGameWorld_IsValid);
		BGUGetIsInEditorPreview_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetIsInEditorPreview");
		BGUGetIsInEditorPreview_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetIsInEditorPreview_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetIsInEditorPreview_WorldContextObject_PropertyAddress, BGUGetIsInEditorPreview_FunctionAddress, "WorldContextObject");
		BGUGetIsInEditorPreview_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetIsInEditorPreview_FunctionAddress, "WorldContextObject");
		BGUGetIsInEditorPreview_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetIsInEditorPreview_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetIsInEditorPreview_ReturnValue_PropertyAddress, BGUGetIsInEditorPreview_FunctionAddress, "ReturnValue");
		BGUGetIsInEditorPreview_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetIsInEditorPreview_FunctionAddress, "ReturnValue");
		BGUGetIsInEditorPreview_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetIsInEditorPreview_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetIsInEditorPreview_IsValid = BGUGetIsInEditorPreview_FunctionAddress != IntPtr.Zero && BGUGetIsInEditorPreview_WorldContextObject_IsValid && BGUGetIsInEditorPreview_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsInEditorPreview", BGUGetIsInEditorPreview_IsValid);
		BGUGetIsEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetIsEditor");
		BGUGetIsEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetIsEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetIsEditor_ReturnValue_PropertyAddress, BGUGetIsEditor_FunctionAddress, "ReturnValue");
		BGUGetIsEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetIsEditor_FunctionAddress, "ReturnValue");
		BGUGetIsEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetIsEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetIsEditor_IsValid = BGUGetIsEditor_FunctionAddress != IntPtr.Zero && BGUGetIsEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsEditor", BGUGetIsEditor_IsValid);
		BGUGetIsBuildShipping_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetIsBuildShipping");
		BGUGetIsBuildShipping_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetIsBuildShipping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetIsBuildShipping_ReturnValue_PropertyAddress, BGUGetIsBuildShipping_FunctionAddress, "ReturnValue");
		BGUGetIsBuildShipping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetIsBuildShipping_FunctionAddress, "ReturnValue");
		BGUGetIsBuildShipping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetIsBuildShipping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetIsBuildShipping_IsValid = BGUGetIsBuildShipping_FunctionAddress != IntPtr.Zero && BGUGetIsBuildShipping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetIsBuildShipping", BGUGetIsBuildShipping_IsValid);
		BGUGetFloatValueTableRow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetFloatValueTableRow");
		BGUGetFloatValueTableRow_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetFloatValueTableRow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetFloatValueTableRow_DataTable_PropertyAddress, BGUGetFloatValueTableRow_FunctionAddress, "DataTable");
		BGUGetFloatValueTableRow_DataTable_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetFloatValueTableRow_FunctionAddress, "DataTable");
		BGUGetFloatValueTableRow_DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetFloatValueTableRow_FunctionAddress, "DataTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetFloatValueTableRow_RowName_PropertyAddress, BGUGetFloatValueTableRow_FunctionAddress, "RowName");
		BGUGetFloatValueTableRow_RowName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetFloatValueTableRow_FunctionAddress, "RowName");
		BGUGetFloatValueTableRow_RowName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetFloatValueTableRow_FunctionAddress, "RowName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetFloatValueTableRow_Result_PropertyAddress, BGUGetFloatValueTableRow_FunctionAddress, "Result");
		BGUGetFloatValueTableRow_Result_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetFloatValueTableRow_FunctionAddress, "Result");
		BGUGetFloatValueTableRow_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetFloatValueTableRow_FunctionAddress, "Result", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetFloatValueTableRow_ContextString_PropertyAddress, BGUGetFloatValueTableRow_FunctionAddress, "ContextString");
		BGUGetFloatValueTableRow_ContextString_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetFloatValueTableRow_FunctionAddress, "ContextString");
		BGUGetFloatValueTableRow_ContextString_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetFloatValueTableRow_FunctionAddress, "ContextString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetFloatValueTableRow_bWarnIfRowMissing_PropertyAddress, BGUGetFloatValueTableRow_FunctionAddress, "bWarnIfRowMissing");
		BGUGetFloatValueTableRow_bWarnIfRowMissing_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetFloatValueTableRow_FunctionAddress, "bWarnIfRowMissing");
		BGUGetFloatValueTableRow_bWarnIfRowMissing_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetFloatValueTableRow_FunctionAddress, "bWarnIfRowMissing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetFloatValueTableRow_ReturnValue_PropertyAddress, BGUGetFloatValueTableRow_FunctionAddress, "ReturnValue");
		BGUGetFloatValueTableRow_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetFloatValueTableRow_FunctionAddress, "ReturnValue");
		BGUGetFloatValueTableRow_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetFloatValueTableRow_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetFloatValueTableRow_IsValid = BGUGetFloatValueTableRow_FunctionAddress != IntPtr.Zero && BGUGetFloatValueTableRow_DataTable_IsValid && BGUGetFloatValueTableRow_RowName_IsValid && BGUGetFloatValueTableRow_Result_IsValid && BGUGetFloatValueTableRow_ContextString_IsValid && BGUGetFloatValueTableRow_bWarnIfRowMissing_IsValid && BGUGetFloatValueTableRow_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetFloatValueTableRow", BGUGetFloatValueTableRow_IsValid);
		BGUGetCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetCurrentTime");
		BGUGetCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetCurrentTime_WorldContextObject_PropertyAddress, BGUGetCurrentTime_FunctionAddress, "WorldContextObject");
		BGUGetCurrentTime_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetCurrentTime_FunctionAddress, "WorldContextObject");
		BGUGetCurrentTime_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetCurrentTime_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetCurrentTime_IsValid_PropertyAddress, BGUGetCurrentTime_FunctionAddress, "IsValid");
		BGUGetCurrentTime_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetCurrentTime_FunctionAddress, "IsValid");
		BGUGetCurrentTime_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetCurrentTime_FunctionAddress, "IsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetCurrentTime_ReturnValue_PropertyAddress, BGUGetCurrentTime_FunctionAddress, "ReturnValue");
		BGUGetCurrentTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetCurrentTime_FunctionAddress, "ReturnValue");
		BGUGetCurrentTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetCurrentTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetCurrentTime_IsValid = BGUGetCurrentTime_FunctionAddress != IntPtr.Zero && BGUGetCurrentTime_WorldContextObject_IsValid && BGUGetCurrentTime_IsValid_IsValid && BGUGetCurrentTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetCurrentTime", BGUGetCurrentTime_IsValid);
		BGUGetCurActiveMontageInstID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetCurActiveMontageInstID");
		BGUGetCurActiveMontageInstID_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetCurActiveMontageInstID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetCurActiveMontageInstID_AnimInstance_PropertyAddress, BGUGetCurActiveMontageInstID_FunctionAddress, "AnimInstance");
		BGUGetCurActiveMontageInstID_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetCurActiveMontageInstID_FunctionAddress, "AnimInstance");
		BGUGetCurActiveMontageInstID_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetCurActiveMontageInstID_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetCurActiveMontageInstID_ReturnValue_PropertyAddress, BGUGetCurActiveMontageInstID_FunctionAddress, "ReturnValue");
		BGUGetCurActiveMontageInstID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetCurActiveMontageInstID_FunctionAddress, "ReturnValue");
		BGUGetCurActiveMontageInstID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetCurActiveMontageInstID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetCurActiveMontageInstID_IsValid = BGUGetCurActiveMontageInstID_FunctionAddress != IntPtr.Zero && BGUGetCurActiveMontageInstID_AnimInstance_IsValid && BGUGetCurActiveMontageInstID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetCurActiveMontageInstID", BGUGetCurActiveMontageInstID_IsValid);
		BGUGetBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetBounds");
		BGUGetBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetBounds_PrimComp_PropertyAddress, BGUGetBounds_FunctionAddress, "PrimComp");
		BGUGetBounds_PrimComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetBounds_FunctionAddress, "PrimComp");
		BGUGetBounds_PrimComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetBounds_FunctionAddress, "PrimComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetBounds_Origin_PropertyAddress, BGUGetBounds_FunctionAddress, "Origin");
		BGUGetBounds_Origin_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetBounds_FunctionAddress, "Origin");
		BGUGetBounds_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetBounds_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetBounds_BoxExtent_PropertyAddress, BGUGetBounds_FunctionAddress, "BoxExtent");
		BGUGetBounds_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetBounds_FunctionAddress, "BoxExtent");
		BGUGetBounds_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetBounds_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		BGUGetBounds_IsValid = BGUGetBounds_FunctionAddress != IntPtr.Zero && BGUGetBounds_PrimComp_IsValid && BGUGetBounds_Origin_IsValid && BGUGetBounds_BoxExtent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetBounds", BGUGetBounds_IsValid);
		BGUGetBodyRadius_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetBodyRadius");
		BGUGetBodyRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetBodyRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetBodyRadius_SkMeshComp_PropertyAddress, BGUGetBodyRadius_FunctionAddress, "SkMeshComp");
		BGUGetBodyRadius_SkMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetBodyRadius_FunctionAddress, "SkMeshComp");
		BGUGetBodyRadius_SkMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetBodyRadius_FunctionAddress, "SkMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetBodyRadius_BoneName_PropertyAddress, BGUGetBodyRadius_FunctionAddress, "BoneName");
		BGUGetBodyRadius_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetBodyRadius_FunctionAddress, "BoneName");
		BGUGetBodyRadius_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetBodyRadius_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetBodyRadius_bGetWelded_PropertyAddress, BGUGetBodyRadius_FunctionAddress, "bGetWelded");
		BGUGetBodyRadius_bGetWelded_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetBodyRadius_FunctionAddress, "bGetWelded");
		BGUGetBodyRadius_bGetWelded_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetBodyRadius_FunctionAddress, "bGetWelded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetBodyRadius_ReturnValue_PropertyAddress, BGUGetBodyRadius_FunctionAddress, "ReturnValue");
		BGUGetBodyRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetBodyRadius_FunctionAddress, "ReturnValue");
		BGUGetBodyRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetBodyRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetBodyRadius_IsValid = BGUGetBodyRadius_FunctionAddress != IntPtr.Zero && BGUGetBodyRadius_SkMeshComp_IsValid && BGUGetBodyRadius_BoneName_IsValid && BGUGetBodyRadius_bGetWelded_IsValid && BGUGetBodyRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetBodyRadius", BGUGetBodyRadius_IsValid);
		BGUGetAllActorsFromGroupActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetAllActorsFromGroupActor");
		BGUGetAllActorsFromGroupActor_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetAllActorsFromGroupActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAllActorsFromGroupActor_GroupActor_PropertyAddress, BGUGetAllActorsFromGroupActor_FunctionAddress, "GroupActor");
		BGUGetAllActorsFromGroupActor_GroupActor_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAllActorsFromGroupActor_FunctionAddress, "GroupActor");
		BGUGetAllActorsFromGroupActor_GroupActor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAllActorsFromGroupActor_FunctionAddress, "GroupActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAllActorsFromGroupActor_bRecurse_PropertyAddress, BGUGetAllActorsFromGroupActor_FunctionAddress, "bRecurse");
		BGUGetAllActorsFromGroupActor_bRecurse_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAllActorsFromGroupActor_FunctionAddress, "bRecurse");
		BGUGetAllActorsFromGroupActor_bRecurse_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAllActorsFromGroupActor_FunctionAddress, "bRecurse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAllActorsFromGroupActor_ReturnValue_PropertyAddress, BGUGetAllActorsFromGroupActor_FunctionAddress, "ReturnValue");
		BGUGetAllActorsFromGroupActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAllActorsFromGroupActor_FunctionAddress, "ReturnValue");
		BGUGetAllActorsFromGroupActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAllActorsFromGroupActor_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		BGUGetAllActorsFromGroupActor_IsValid = BGUGetAllActorsFromGroupActor_FunctionAddress != IntPtr.Zero && BGUGetAllActorsFromGroupActor_GroupActor_IsValid && BGUGetAllActorsFromGroupActor_bRecurse_IsValid && BGUGetAllActorsFromGroupActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetAllActorsFromGroupActor", BGUGetAllActorsFromGroupActor_IsValid);
		BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetAIStimulusWasSuccessfullySensed");
		BGUGetAIStimulusWasSuccessfullySensed_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAIStimulusWasSuccessfullySensed_Stimulus_PropertyAddress, BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress, "Stimulus");
		BGUGetAIStimulusWasSuccessfullySensed_Stimulus_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress, "Stimulus");
		BGUGetAIStimulusWasSuccessfullySensed_Stimulus_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress, "Stimulus", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAIStimulusWasSuccessfullySensed_ReturnValue_PropertyAddress, BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress, "ReturnValue");
		BGUGetAIStimulusWasSuccessfullySensed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress, "ReturnValue");
		BGUGetAIStimulusWasSuccessfullySensed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetAIStimulusWasSuccessfullySensed_IsValid = BGUGetAIStimulusWasSuccessfullySensed_FunctionAddress != IntPtr.Zero && BGUGetAIStimulusWasSuccessfullySensed_Stimulus_IsValid && BGUGetAIStimulusWasSuccessfullySensed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetAIStimulusWasSuccessfullySensed", BGUGetAIStimulusWasSuccessfullySensed_IsValid);
		BGUGetActorLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetActorLevelName");
		BGUGetActorLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetActorLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetActorLevelName_Unit_PropertyAddress, BGUGetActorLevelName_FunctionAddress, "Unit");
		BGUGetActorLevelName_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetActorLevelName_FunctionAddress, "Unit");
		BGUGetActorLevelName_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetActorLevelName_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetActorLevelName_ReturnValue_PropertyAddress, BGUGetActorLevelName_FunctionAddress, "ReturnValue");
		BGUGetActorLevelName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetActorLevelName_FunctionAddress, "ReturnValue");
		BGUGetActorLevelName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetActorLevelName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BGUGetActorLevelName_IsValid = BGUGetActorLevelName_FunctionAddress != IntPtr.Zero && BGUGetActorLevelName_Unit_IsValid && BGUGetActorLevelName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUGetActorLevelName", BGUGetActorLevelName_IsValid);
		BGUExceutePyCode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUExceutePyCode");
		BGUExceutePyCode_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUExceutePyCode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUExceutePyCode_PyPath_PropertyAddress, BGUExceutePyCode_FunctionAddress, "PyPath");
		BGUExceutePyCode_PyPath_Offset = NativeReflectionCached.GetPropertyOffset(BGUExceutePyCode_FunctionAddress, "PyPath");
		BGUExceutePyCode_PyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUExceutePyCode_FunctionAddress, "PyPath", Classes.FStrProperty);
		BGUExceutePyCode_IsValid = BGUExceutePyCode_FunctionAddress != IntPtr.Zero && BGUExceutePyCode_PyPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUExceutePyCode", BGUExceutePyCode_IsValid);
		BGUEnableActorTick_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUEnableActorTick");
		BGUEnableActorTick_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUEnableActorTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUEnableActorTick_Actor_PropertyAddress, BGUEnableActorTick_FunctionAddress, "Actor");
		BGUEnableActorTick_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUEnableActorTick_FunctionAddress, "Actor");
		BGUEnableActorTick_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUEnableActorTick_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUEnableActorTick_bEnable_PropertyAddress, BGUEnableActorTick_FunctionAddress, "bEnable");
		BGUEnableActorTick_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(BGUEnableActorTick_FunctionAddress, "bEnable");
		BGUEnableActorTick_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUEnableActorTick_FunctionAddress, "bEnable", Classes.FBoolProperty);
		BGUEnableActorTick_IsValid = BGUEnableActorTick_FunctionAddress != IntPtr.Zero && BGUEnableActorTick_Actor_IsValid && BGUEnableActorTick_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUEnableActorTick", BGUEnableActorTick_IsValid);
		BguDrawSweepCheckShapeWithColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BguDrawSweepCheckShapeWithColor");
		BguDrawSweepCheckShapeWithColor_ParamsSize = NativeReflection.GetFunctionParamsSize(BguDrawSweepCheckShapeWithColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSweepCheckShapeWithColor_World_PropertyAddress, BguDrawSweepCheckShapeWithColor_FunctionAddress, "World");
		BguDrawSweepCheckShapeWithColor_World_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSweepCheckShapeWithColor_FunctionAddress, "World");
		BguDrawSweepCheckShapeWithColor_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSweepCheckShapeWithColor_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSweepCheckShapeWithColor_CenterPos_PropertyAddress, BguDrawSweepCheckShapeWithColor_FunctionAddress, "CenterPos");
		BguDrawSweepCheckShapeWithColor_CenterPos_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSweepCheckShapeWithColor_FunctionAddress, "CenterPos");
		BguDrawSweepCheckShapeWithColor_CenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSweepCheckShapeWithColor_FunctionAddress, "CenterPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSweepCheckShapeWithColor_Rot_PropertyAddress, BguDrawSweepCheckShapeWithColor_FunctionAddress, "Rot");
		BguDrawSweepCheckShapeWithColor_Rot_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSweepCheckShapeWithColor_FunctionAddress, "Rot");
		BguDrawSweepCheckShapeWithColor_Rot_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSweepCheckShapeWithColor_FunctionAddress, "Rot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_PropertyAddress, BguDrawSweepCheckShapeWithColor_FunctionAddress, "SweepCheckShapeInfo");
		BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSweepCheckShapeWithColor_FunctionAddress, "SweepCheckShapeInfo");
		BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSweepCheckShapeWithColor_FunctionAddress, "SweepCheckShapeInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSweepCheckShapeWithColor_Color_PropertyAddress, BguDrawSweepCheckShapeWithColor_FunctionAddress, "Color");
		BguDrawSweepCheckShapeWithColor_Color_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSweepCheckShapeWithColor_FunctionAddress, "Color");
		BguDrawSweepCheckShapeWithColor_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSweepCheckShapeWithColor_FunctionAddress, "Color", Classes.FStructProperty);
		BguDrawSweepCheckShapeWithColor_IsValid = BguDrawSweepCheckShapeWithColor_FunctionAddress != IntPtr.Zero && BguDrawSweepCheckShapeWithColor_World_IsValid && BguDrawSweepCheckShapeWithColor_CenterPos_IsValid && BguDrawSweepCheckShapeWithColor_Rot_IsValid && BguDrawSweepCheckShapeWithColor_SweepCheckShapeInfo_IsValid && BguDrawSweepCheckShapeWithColor_Color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BguDrawSweepCheckShapeWithColor", BguDrawSweepCheckShapeWithColor_IsValid);
		BGUDrawSweepCheckShape_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawSweepCheckShape");
		BGUDrawSweepCheckShape_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawSweepCheckShape_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawSweepCheckShape_World_PropertyAddress, BGUDrawSweepCheckShape_FunctionAddress, "World");
		BGUDrawSweepCheckShape_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawSweepCheckShape_FunctionAddress, "World");
		BGUDrawSweepCheckShape_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawSweepCheckShape_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawSweepCheckShape_CenterPos_PropertyAddress, BGUDrawSweepCheckShape_FunctionAddress, "CenterPos");
		BGUDrawSweepCheckShape_CenterPos_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawSweepCheckShape_FunctionAddress, "CenterPos");
		BGUDrawSweepCheckShape_CenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawSweepCheckShape_FunctionAddress, "CenterPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawSweepCheckShape_Rot_PropertyAddress, BGUDrawSweepCheckShape_FunctionAddress, "Rot");
		BGUDrawSweepCheckShape_Rot_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawSweepCheckShape_FunctionAddress, "Rot");
		BGUDrawSweepCheckShape_Rot_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawSweepCheckShape_FunctionAddress, "Rot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawSweepCheckShape_SweepCheckShapeInfo_PropertyAddress, BGUDrawSweepCheckShape_FunctionAddress, "SweepCheckShapeInfo");
		BGUDrawSweepCheckShape_SweepCheckShapeInfo_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawSweepCheckShape_FunctionAddress, "SweepCheckShapeInfo");
		BGUDrawSweepCheckShape_SweepCheckShapeInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawSweepCheckShape_FunctionAddress, "SweepCheckShapeInfo", Classes.FStructProperty);
		BGUDrawSweepCheckShape_IsValid = BGUDrawSweepCheckShape_FunctionAddress != IntPtr.Zero && BGUDrawSweepCheckShape_World_IsValid && BGUDrawSweepCheckShape_CenterPos_IsValid && BGUDrawSweepCheckShape_Rot_IsValid && BGUDrawSweepCheckShape_SweepCheckShapeInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawSweepCheckShape", BGUDrawSweepCheckShape_IsValid);
		BguDrawSphereSweepWithColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BguDrawSphereSweepWithColor");
		BguDrawSphereSweepWithColor_ParamsSize = NativeReflection.GetFunctionParamsSize(BguDrawSphereSweepWithColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSphereSweepWithColor_World_PropertyAddress, BguDrawSphereSweepWithColor_FunctionAddress, "World");
		BguDrawSphereSweepWithColor_World_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSphereSweepWithColor_FunctionAddress, "World");
		BguDrawSphereSweepWithColor_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSphereSweepWithColor_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSphereSweepWithColor_Start_PropertyAddress, BguDrawSphereSweepWithColor_FunctionAddress, "Start");
		BguDrawSphereSweepWithColor_Start_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSphereSweepWithColor_FunctionAddress, "Start");
		BguDrawSphereSweepWithColor_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSphereSweepWithColor_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSphereSweepWithColor_End_PropertyAddress, BguDrawSphereSweepWithColor_FunctionAddress, "End");
		BguDrawSphereSweepWithColor_End_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSphereSweepWithColor_FunctionAddress, "End");
		BguDrawSphereSweepWithColor_End_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSphereSweepWithColor_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSphereSweepWithColor_Radius_PropertyAddress, BguDrawSphereSweepWithColor_FunctionAddress, "Radius");
		BguDrawSphereSweepWithColor_Radius_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSphereSweepWithColor_FunctionAddress, "Radius");
		BguDrawSphereSweepWithColor_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSphereSweepWithColor_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BguDrawSphereSweepWithColor_Color_PropertyAddress, BguDrawSphereSweepWithColor_FunctionAddress, "Color");
		BguDrawSphereSweepWithColor_Color_Offset = NativeReflectionCached.GetPropertyOffset(BguDrawSphereSweepWithColor_FunctionAddress, "Color");
		BguDrawSphereSweepWithColor_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(BguDrawSphereSweepWithColor_FunctionAddress, "Color", Classes.FStructProperty);
		BguDrawSphereSweepWithColor_IsValid = BguDrawSphereSweepWithColor_FunctionAddress != IntPtr.Zero && BguDrawSphereSweepWithColor_World_IsValid && BguDrawSphereSweepWithColor_Start_IsValid && BguDrawSphereSweepWithColor_End_IsValid && BguDrawSphereSweepWithColor_Radius_IsValid && BguDrawSphereSweepWithColor_Color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BguDrawSphereSweepWithColor", BguDrawSphereSweepWithColor_IsValid);
		BGUDrawSphereSweep_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawSphereSweep");
		BGUDrawSphereSweep_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawSphereSweep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawSphereSweep_World_PropertyAddress, BGUDrawSphereSweep_FunctionAddress, "World");
		BGUDrawSphereSweep_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawSphereSweep_FunctionAddress, "World");
		BGUDrawSphereSweep_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawSphereSweep_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawSphereSweep_Start_PropertyAddress, BGUDrawSphereSweep_FunctionAddress, "Start");
		BGUDrawSphereSweep_Start_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawSphereSweep_FunctionAddress, "Start");
		BGUDrawSphereSweep_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawSphereSweep_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawSphereSweep_End_PropertyAddress, BGUDrawSphereSweep_FunctionAddress, "End");
		BGUDrawSphereSweep_End_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawSphereSweep_FunctionAddress, "End");
		BGUDrawSphereSweep_End_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawSphereSweep_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawSphereSweep_Radius_PropertyAddress, BGUDrawSphereSweep_FunctionAddress, "Radius");
		BGUDrawSphereSweep_Radius_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawSphereSweep_FunctionAddress, "Radius");
		BGUDrawSphereSweep_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawSphereSweep_FunctionAddress, "Radius", Classes.FFloatProperty);
		BGUDrawSphereSweep_IsValid = BGUDrawSphereSweep_FunctionAddress != IntPtr.Zero && BGUDrawSphereSweep_World_IsValid && BGUDrawSphereSweep_Start_IsValid && BGUDrawSphereSweep_End_IsValid && BGUDrawSphereSweep_Radius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawSphereSweep", BGUDrawSphereSweep_IsValid);
		BGUDrawLineArrowEx_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawLineArrowEx");
		BGUDrawLineArrowEx_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawLineArrowEx_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrowEx_World_PropertyAddress, BGUDrawLineArrowEx_FunctionAddress, "World");
		BGUDrawLineArrowEx_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrowEx_FunctionAddress, "World");
		BGUDrawLineArrowEx_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrowEx_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrowEx_LineStart_PropertyAddress, BGUDrawLineArrowEx_FunctionAddress, "LineStart");
		BGUDrawLineArrowEx_LineStart_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrowEx_FunctionAddress, "LineStart");
		BGUDrawLineArrowEx_LineStart_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrowEx_FunctionAddress, "LineStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrowEx_LineEnd_PropertyAddress, BGUDrawLineArrowEx_FunctionAddress, "LineEnd");
		BGUDrawLineArrowEx_LineEnd_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrowEx_FunctionAddress, "LineEnd");
		BGUDrawLineArrowEx_LineEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrowEx_FunctionAddress, "LineEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrowEx_ArrowSize_PropertyAddress, BGUDrawLineArrowEx_FunctionAddress, "ArrowSize");
		BGUDrawLineArrowEx_ArrowSize_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrowEx_FunctionAddress, "ArrowSize");
		BGUDrawLineArrowEx_ArrowSize_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrowEx_FunctionAddress, "ArrowSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrowEx_Color_PropertyAddress, BGUDrawLineArrowEx_FunctionAddress, "Color");
		BGUDrawLineArrowEx_Color_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrowEx_FunctionAddress, "Color");
		BGUDrawLineArrowEx_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrowEx_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrowEx_IsPersistentLines_PropertyAddress, BGUDrawLineArrowEx_FunctionAddress, "IsPersistentLines");
		BGUDrawLineArrowEx_IsPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrowEx_FunctionAddress, "IsPersistentLines");
		BGUDrawLineArrowEx_IsPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrowEx_FunctionAddress, "IsPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrowEx_LifeTime_PropertyAddress, BGUDrawLineArrowEx_FunctionAddress, "LifeTime");
		BGUDrawLineArrowEx_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrowEx_FunctionAddress, "LifeTime");
		BGUDrawLineArrowEx_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrowEx_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		BGUDrawLineArrowEx_IsValid = BGUDrawLineArrowEx_FunctionAddress != IntPtr.Zero && BGUDrawLineArrowEx_World_IsValid && BGUDrawLineArrowEx_LineStart_IsValid && BGUDrawLineArrowEx_LineEnd_IsValid && BGUDrawLineArrowEx_ArrowSize_IsValid && BGUDrawLineArrowEx_Color_IsValid && BGUDrawLineArrowEx_IsPersistentLines_IsValid && BGUDrawLineArrowEx_LifeTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawLineArrowEx", BGUDrawLineArrowEx_IsValid);
		BGUDrawLineArrow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawLineArrow");
		BGUDrawLineArrow_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawLineArrow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrow_World_PropertyAddress, BGUDrawLineArrow_FunctionAddress, "World");
		BGUDrawLineArrow_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrow_FunctionAddress, "World");
		BGUDrawLineArrow_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrow_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrow_LineStart_PropertyAddress, BGUDrawLineArrow_FunctionAddress, "LineStart");
		BGUDrawLineArrow_LineStart_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrow_FunctionAddress, "LineStart");
		BGUDrawLineArrow_LineStart_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrow_FunctionAddress, "LineStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrow_LineEnd_PropertyAddress, BGUDrawLineArrow_FunctionAddress, "LineEnd");
		BGUDrawLineArrow_LineEnd_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrow_FunctionAddress, "LineEnd");
		BGUDrawLineArrow_LineEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrow_FunctionAddress, "LineEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawLineArrow_ArrowSize_PropertyAddress, BGUDrawLineArrow_FunctionAddress, "ArrowSize");
		BGUDrawLineArrow_ArrowSize_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawLineArrow_FunctionAddress, "ArrowSize");
		BGUDrawLineArrow_ArrowSize_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawLineArrow_FunctionAddress, "ArrowSize", Classes.FFloatProperty);
		BGUDrawLineArrow_IsValid = BGUDrawLineArrow_FunctionAddress != IntPtr.Zero && BGUDrawLineArrow_World_IsValid && BGUDrawLineArrow_LineStart_IsValid && BGUDrawLineArrow_LineEnd_IsValid && BGUDrawLineArrow_ArrowSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawLineArrow", BGUDrawLineArrow_IsValid);
		BGUDrawDebugSphereEx_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawDebugSphereEx");
		BGUDrawDebugSphereEx_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawDebugSphereEx_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugSphereEx_World_PropertyAddress, BGUDrawDebugSphereEx_FunctionAddress, "World");
		BGUDrawDebugSphereEx_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugSphereEx_FunctionAddress, "World");
		BGUDrawDebugSphereEx_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugSphereEx_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugSphereEx_CenterPos_PropertyAddress, BGUDrawDebugSphereEx_FunctionAddress, "CenterPos");
		BGUDrawDebugSphereEx_CenterPos_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugSphereEx_FunctionAddress, "CenterPos");
		BGUDrawDebugSphereEx_CenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugSphereEx_FunctionAddress, "CenterPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugSphereEx_Raidus_PropertyAddress, BGUDrawDebugSphereEx_FunctionAddress, "Raidus");
		BGUDrawDebugSphereEx_Raidus_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugSphereEx_FunctionAddress, "Raidus");
		BGUDrawDebugSphereEx_Raidus_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugSphereEx_FunctionAddress, "Raidus", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugSphereEx_KeepTime_PropertyAddress, BGUDrawDebugSphereEx_FunctionAddress, "KeepTime");
		BGUDrawDebugSphereEx_KeepTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugSphereEx_FunctionAddress, "KeepTime");
		BGUDrawDebugSphereEx_KeepTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugSphereEx_FunctionAddress, "KeepTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugSphereEx_Color_PropertyAddress, BGUDrawDebugSphereEx_FunctionAddress, "Color");
		BGUDrawDebugSphereEx_Color_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugSphereEx_FunctionAddress, "Color");
		BGUDrawDebugSphereEx_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugSphereEx_FunctionAddress, "Color", Classes.FStructProperty);
		BGUDrawDebugSphereEx_IsValid = BGUDrawDebugSphereEx_FunctionAddress != IntPtr.Zero && BGUDrawDebugSphereEx_World_IsValid && BGUDrawDebugSphereEx_CenterPos_IsValid && BGUDrawDebugSphereEx_Raidus_IsValid && BGUDrawDebugSphereEx_KeepTime_IsValid && BGUDrawDebugSphereEx_Color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugSphereEx", BGUDrawDebugSphereEx_IsValid);
		BGUDrawDebugSphere_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawDebugSphere");
		BGUDrawDebugSphere_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawDebugSphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugSphere_World_PropertyAddress, BGUDrawDebugSphere_FunctionAddress, "World");
		BGUDrawDebugSphere_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugSphere_FunctionAddress, "World");
		BGUDrawDebugSphere_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugSphere_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugSphere_CenterPos_PropertyAddress, BGUDrawDebugSphere_FunctionAddress, "CenterPos");
		BGUDrawDebugSphere_CenterPos_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugSphere_FunctionAddress, "CenterPos");
		BGUDrawDebugSphere_CenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugSphere_FunctionAddress, "CenterPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugSphere_Raidus_PropertyAddress, BGUDrawDebugSphere_FunctionAddress, "Raidus");
		BGUDrawDebugSphere_Raidus_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugSphere_FunctionAddress, "Raidus");
		BGUDrawDebugSphere_Raidus_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugSphere_FunctionAddress, "Raidus", Classes.FFloatProperty);
		BGUDrawDebugSphere_IsValid = BGUDrawDebugSphere_FunctionAddress != IntPtr.Zero && BGUDrawDebugSphere_World_IsValid && BGUDrawDebugSphere_CenterPos_IsValid && BGUDrawDebugSphere_Raidus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugSphere", BGUDrawDebugSphere_IsValid);
		BGUDrawDebugRect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawDebugRect");
		BGUDrawDebugRect_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawDebugRect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugRect_World_PropertyAddress, BGUDrawDebugRect_FunctionAddress, "World");
		BGUDrawDebugRect_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugRect_FunctionAddress, "World");
		BGUDrawDebugRect_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugRect_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugRect_CenterPos_PropertyAddress, BGUDrawDebugRect_FunctionAddress, "CenterPos");
		BGUDrawDebugRect_CenterPos_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugRect_FunctionAddress, "CenterPos");
		BGUDrawDebugRect_CenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugRect_FunctionAddress, "CenterPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugRect_Direction_PropertyAddress, BGUDrawDebugRect_FunctionAddress, "Direction");
		BGUDrawDebugRect_Direction_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugRect_FunctionAddress, "Direction");
		BGUDrawDebugRect_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugRect_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugRect_Width_PropertyAddress, BGUDrawDebugRect_FunctionAddress, "Width");
		BGUDrawDebugRect_Width_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugRect_FunctionAddress, "Width");
		BGUDrawDebugRect_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugRect_FunctionAddress, "Width", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugRect_Length_PropertyAddress, BGUDrawDebugRect_FunctionAddress, "Length");
		BGUDrawDebugRect_Length_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugRect_FunctionAddress, "Length");
		BGUDrawDebugRect_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugRect_FunctionAddress, "Length", Classes.FFloatProperty);
		BGUDrawDebugRect_IsValid = BGUDrawDebugRect_FunctionAddress != IntPtr.Zero && BGUDrawDebugRect_World_IsValid && BGUDrawDebugRect_CenterPos_IsValid && BGUDrawDebugRect_Direction_IsValid && BGUDrawDebugRect_Width_IsValid && BGUDrawDebugRect_Length_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugRect", BGUDrawDebugRect_IsValid);
		BGUDrawDebugCircleEx_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawDebugCircleEx");
		BGUDrawDebugCircleEx_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawDebugCircleEx_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugCircleEx_World_PropertyAddress, BGUDrawDebugCircleEx_FunctionAddress, "World");
		BGUDrawDebugCircleEx_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugCircleEx_FunctionAddress, "World");
		BGUDrawDebugCircleEx_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugCircleEx_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugCircleEx_CenterPos_PropertyAddress, BGUDrawDebugCircleEx_FunctionAddress, "CenterPos");
		BGUDrawDebugCircleEx_CenterPos_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugCircleEx_FunctionAddress, "CenterPos");
		BGUDrawDebugCircleEx_CenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugCircleEx_FunctionAddress, "CenterPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugCircleEx_Raidus_PropertyAddress, BGUDrawDebugCircleEx_FunctionAddress, "Raidus");
		BGUDrawDebugCircleEx_Raidus_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugCircleEx_FunctionAddress, "Raidus");
		BGUDrawDebugCircleEx_Raidus_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugCircleEx_FunctionAddress, "Raidus", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugCircleEx_KeepTime_PropertyAddress, BGUDrawDebugCircleEx_FunctionAddress, "KeepTime");
		BGUDrawDebugCircleEx_KeepTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugCircleEx_FunctionAddress, "KeepTime");
		BGUDrawDebugCircleEx_KeepTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugCircleEx_FunctionAddress, "KeepTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugCircleEx_Color_PropertyAddress, BGUDrawDebugCircleEx_FunctionAddress, "Color");
		BGUDrawDebugCircleEx_Color_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugCircleEx_FunctionAddress, "Color");
		BGUDrawDebugCircleEx_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugCircleEx_FunctionAddress, "Color", Classes.FStructProperty);
		BGUDrawDebugCircleEx_IsValid = BGUDrawDebugCircleEx_FunctionAddress != IntPtr.Zero && BGUDrawDebugCircleEx_World_IsValid && BGUDrawDebugCircleEx_CenterPos_IsValid && BGUDrawDebugCircleEx_Raidus_IsValid && BGUDrawDebugCircleEx_KeepTime_IsValid && BGUDrawDebugCircleEx_Color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugCircleEx", BGUDrawDebugCircleEx_IsValid);
		BGUDrawDebugCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawDebugCircle");
		BGUDrawDebugCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawDebugCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugCircle_World_PropertyAddress, BGUDrawDebugCircle_FunctionAddress, "World");
		BGUDrawDebugCircle_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugCircle_FunctionAddress, "World");
		BGUDrawDebugCircle_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugCircle_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugCircle_CenterPos_PropertyAddress, BGUDrawDebugCircle_FunctionAddress, "CenterPos");
		BGUDrawDebugCircle_CenterPos_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugCircle_FunctionAddress, "CenterPos");
		BGUDrawDebugCircle_CenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugCircle_FunctionAddress, "CenterPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugCircle_Raidus_PropertyAddress, BGUDrawDebugCircle_FunctionAddress, "Raidus");
		BGUDrawDebugCircle_Raidus_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugCircle_FunctionAddress, "Raidus");
		BGUDrawDebugCircle_Raidus_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugCircle_FunctionAddress, "Raidus", Classes.FFloatProperty);
		BGUDrawDebugCircle_IsValid = BGUDrawDebugCircle_FunctionAddress != IntPtr.Zero && BGUDrawDebugCircle_World_IsValid && BGUDrawDebugCircle_CenterPos_IsValid && BGUDrawDebugCircle_Raidus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugCircle", BGUDrawDebugCircle_IsValid);
		BGUDrawDebugAnnularSector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUDrawDebugAnnularSector");
		BGUDrawDebugAnnularSector_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDrawDebugAnnularSector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_World_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "World");
		BGUDrawDebugAnnularSector_World_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "World");
		BGUDrawDebugAnnularSector_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_CenterPos_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "CenterPos");
		BGUDrawDebugAnnularSector_CenterPos_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "CenterPos");
		BGUDrawDebugAnnularSector_CenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "CenterPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_Direction_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "Direction");
		BGUDrawDebugAnnularSector_Direction_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "Direction");
		BGUDrawDebugAnnularSector_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_InnerRadius_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "InnerRadius");
		BGUDrawDebugAnnularSector_InnerRadius_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "InnerRadius");
		BGUDrawDebugAnnularSector_InnerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "InnerRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_OuterRadius_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "OuterRadius");
		BGUDrawDebugAnnularSector_OuterRadius_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "OuterRadius");
		BGUDrawDebugAnnularSector_OuterRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "OuterRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_HalfAngle_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "HalfAngle");
		BGUDrawDebugAnnularSector_HalfAngle_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "HalfAngle");
		BGUDrawDebugAnnularSector_HalfAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "HalfAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_Color_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "Color");
		BGUDrawDebugAnnularSector_Color_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "Color");
		BGUDrawDebugAnnularSector_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_Duration_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "Duration");
		BGUDrawDebugAnnularSector_Duration_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "Duration");
		BGUDrawDebugAnnularSector_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_Thickness_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "Thickness");
		BGUDrawDebugAnnularSector_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "Thickness");
		BGUDrawDebugAnnularSector_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUDrawDebugAnnularSector_Segments_PropertyAddress, BGUDrawDebugAnnularSector_FunctionAddress, "Segments");
		BGUDrawDebugAnnularSector_Segments_Offset = NativeReflectionCached.GetPropertyOffset(BGUDrawDebugAnnularSector_FunctionAddress, "Segments");
		BGUDrawDebugAnnularSector_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUDrawDebugAnnularSector_FunctionAddress, "Segments", Classes.FIntProperty);
		BGUDrawDebugAnnularSector_IsValid = BGUDrawDebugAnnularSector_FunctionAddress != IntPtr.Zero && BGUDrawDebugAnnularSector_World_IsValid && BGUDrawDebugAnnularSector_CenterPos_IsValid && BGUDrawDebugAnnularSector_Direction_IsValid && BGUDrawDebugAnnularSector_InnerRadius_IsValid && BGUDrawDebugAnnularSector_OuterRadius_IsValid && BGUDrawDebugAnnularSector_HalfAngle_IsValid && BGUDrawDebugAnnularSector_Color_IsValid && BGUDrawDebugAnnularSector_Duration_IsValid && BGUDrawDebugAnnularSector_Thickness_IsValid && BGUDrawDebugAnnularSector_Segments_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUDrawDebugAnnularSector", BGUDrawDebugAnnularSector_IsValid);
		BGUCreateLandscapeHeightMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUCreateLandscapeHeightMap");
		BGUCreateLandscapeHeightMap_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCreateLandscapeHeightMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUCreateLandscapeHeightMap_Landscape_PropertyAddress, BGUCreateLandscapeHeightMap_FunctionAddress, "Landscape");
		BGUCreateLandscapeHeightMap_Landscape_Offset = NativeReflectionCached.GetPropertyOffset(BGUCreateLandscapeHeightMap_FunctionAddress, "Landscape");
		BGUCreateLandscapeHeightMap_Landscape_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCreateLandscapeHeightMap_FunctionAddress, "Landscape", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCreateLandscapeHeightMap_PackageName_PropertyAddress, BGUCreateLandscapeHeightMap_FunctionAddress, "PackageName");
		BGUCreateLandscapeHeightMap_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(BGUCreateLandscapeHeightMap_FunctionAddress, "PackageName");
		BGUCreateLandscapeHeightMap_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCreateLandscapeHeightMap_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCreateLandscapeHeightMap_AssetName_PropertyAddress, BGUCreateLandscapeHeightMap_FunctionAddress, "AssetName");
		BGUCreateLandscapeHeightMap_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(BGUCreateLandscapeHeightMap_FunctionAddress, "AssetName");
		BGUCreateLandscapeHeightMap_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCreateLandscapeHeightMap_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCreateLandscapeHeightMap_ReturnValue_PropertyAddress, BGUCreateLandscapeHeightMap_FunctionAddress, "ReturnValue");
		BGUCreateLandscapeHeightMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUCreateLandscapeHeightMap_FunctionAddress, "ReturnValue");
		BGUCreateLandscapeHeightMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCreateLandscapeHeightMap_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUCreateLandscapeHeightMap_IsValid = BGUCreateLandscapeHeightMap_FunctionAddress != IntPtr.Zero && BGUCreateLandscapeHeightMap_Landscape_IsValid && BGUCreateLandscapeHeightMap_PackageName_IsValid && BGUCreateLandscapeHeightMap_AssetName_IsValid && BGUCreateLandscapeHeightMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUCreateLandscapeHeightMap", BGUCreateLandscapeHeightMap_IsValid);
		BGUComputeActorHitMovePenetration_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUComputeActorHitMovePenetration");
		BGUComputeActorHitMovePenetration_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUComputeActorHitMovePenetration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUComputeActorHitMovePenetration_SelfActor_PropertyAddress, BGUComputeActorHitMovePenetration_FunctionAddress, "SelfActor");
		BGUComputeActorHitMovePenetration_SelfActor_Offset = NativeReflectionCached.GetPropertyOffset(BGUComputeActorHitMovePenetration_FunctionAddress, "SelfActor");
		BGUComputeActorHitMovePenetration_SelfActor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUComputeActorHitMovePenetration_FunctionAddress, "SelfActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_PropertyAddress, BGUComputeActorHitMovePenetration_FunctionAddress, "OverlappedOtherActorInfos");
		BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_Offset = NativeReflectionCached.GetPropertyOffset(BGUComputeActorHitMovePenetration_FunctionAddress, "OverlappedOtherActorInfos");
		BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUComputeActorHitMovePenetration_FunctionAddress, "OverlappedOtherActorInfos", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUComputeActorHitMovePenetration_SelfWeight_PropertyAddress, BGUComputeActorHitMovePenetration_FunctionAddress, "SelfWeight");
		BGUComputeActorHitMovePenetration_SelfWeight_Offset = NativeReflectionCached.GetPropertyOffset(BGUComputeActorHitMovePenetration_FunctionAddress, "SelfWeight");
		BGUComputeActorHitMovePenetration_SelfWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUComputeActorHitMovePenetration_FunctionAddress, "SelfWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUComputeActorHitMovePenetration_PlaneNormalVector_PropertyAddress, BGUComputeActorHitMovePenetration_FunctionAddress, "PlaneNormalVector");
		BGUComputeActorHitMovePenetration_PlaneNormalVector_Offset = NativeReflectionCached.GetPropertyOffset(BGUComputeActorHitMovePenetration_FunctionAddress, "PlaneNormalVector");
		BGUComputeActorHitMovePenetration_PlaneNormalVector_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUComputeActorHitMovePenetration_FunctionAddress, "PlaneNormalVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUComputeActorHitMovePenetration_MaxComputeRound_PropertyAddress, BGUComputeActorHitMovePenetration_FunctionAddress, "MaxComputeRound");
		BGUComputeActorHitMovePenetration_MaxComputeRound_Offset = NativeReflectionCached.GetPropertyOffset(BGUComputeActorHitMovePenetration_FunctionAddress, "MaxComputeRound");
		BGUComputeActorHitMovePenetration_MaxComputeRound_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUComputeActorHitMovePenetration_FunctionAddress, "MaxComputeRound", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUComputeActorHitMovePenetration_Epsilon_PropertyAddress, BGUComputeActorHitMovePenetration_FunctionAddress, "Epsilon");
		BGUComputeActorHitMovePenetration_Epsilon_Offset = NativeReflectionCached.GetPropertyOffset(BGUComputeActorHitMovePenetration_FunctionAddress, "Epsilon");
		BGUComputeActorHitMovePenetration_Epsilon_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUComputeActorHitMovePenetration_FunctionAddress, "Epsilon", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUComputeActorHitMovePenetration_ReturnValue_PropertyAddress, BGUComputeActorHitMovePenetration_FunctionAddress, "ReturnValue");
		BGUComputeActorHitMovePenetration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUComputeActorHitMovePenetration_FunctionAddress, "ReturnValue");
		BGUComputeActorHitMovePenetration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUComputeActorHitMovePenetration_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BGUComputeActorHitMovePenetration_IsValid = BGUComputeActorHitMovePenetration_FunctionAddress != IntPtr.Zero && BGUComputeActorHitMovePenetration_SelfActor_IsValid && BGUComputeActorHitMovePenetration_OverlappedOtherActorInfos_IsValid && BGUComputeActorHitMovePenetration_SelfWeight_IsValid && BGUComputeActorHitMovePenetration_PlaneNormalVector_IsValid && BGUComputeActorHitMovePenetration_MaxComputeRound_IsValid && BGUComputeActorHitMovePenetration_Epsilon_IsValid && BGUComputeActorHitMovePenetration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUComputeActorHitMovePenetration", BGUComputeActorHitMovePenetration_IsValid);
		BGUBindOnSetLevelsStateFinished_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnSetLevelsStateFinished");
		BGUBindOnSetLevelsStateFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnSetLevelsStateFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnSetLevelsStateFinished_Obj_PropertyAddress, BGUBindOnSetLevelsStateFinished_FunctionAddress, "Obj");
		BGUBindOnSetLevelsStateFinished_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnSetLevelsStateFinished_FunctionAddress, "Obj");
		BGUBindOnSetLevelsStateFinished_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnSetLevelsStateFinished_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnSetLevelsStateFinished_FuncName_PropertyAddress, BGUBindOnSetLevelsStateFinished_FunctionAddress, "FuncName");
		BGUBindOnSetLevelsStateFinished_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnSetLevelsStateFinished_FunctionAddress, "FuncName");
		BGUBindOnSetLevelsStateFinished_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnSetLevelsStateFinished_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUBindOnSetLevelsStateFinished_IsValid = BGUBindOnSetLevelsStateFinished_FunctionAddress != IntPtr.Zero && BGUBindOnSetLevelsStateFinished_Obj_IsValid && BGUBindOnSetLevelsStateFinished_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnSetLevelsStateFinished", BGUBindOnSetLevelsStateFinished_IsValid);
		BGUBindOnComponentHitEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnComponentHitEvent");
		BGUBindOnComponentHitEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnComponentHitEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnComponentHitEvent_Comp_PropertyAddress, BGUBindOnComponentHitEvent_FunctionAddress, "Comp");
		BGUBindOnComponentHitEvent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnComponentHitEvent_FunctionAddress, "Comp");
		BGUBindOnComponentHitEvent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnComponentHitEvent_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnComponentHitEvent_Obj_PropertyAddress, BGUBindOnComponentHitEvent_FunctionAddress, "Obj");
		BGUBindOnComponentHitEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnComponentHitEvent_FunctionAddress, "Obj");
		BGUBindOnComponentHitEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnComponentHitEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnComponentHitEvent_Func_PropertyAddress, BGUBindOnComponentHitEvent_FunctionAddress, "Func");
		BGUBindOnComponentHitEvent_Func_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnComponentHitEvent_FunctionAddress, "Func");
		BGUBindOnComponentHitEvent_Func_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnComponentHitEvent_FunctionAddress, "Func", Classes.FNameProperty);
		BGUBindOnComponentHitEvent_IsValid = BGUBindOnComponentHitEvent_FunctionAddress != IntPtr.Zero && BGUBindOnComponentHitEvent_Comp_IsValid && BGUBindOnComponentHitEvent_Obj_IsValid && BGUBindOnComponentHitEvent_Func_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnComponentHitEvent", BGUBindOnComponentHitEvent_IsValid);
		BGUBindOnComponentEndOverlapEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnComponentEndOverlapEvent");
		BGUBindOnComponentEndOverlapEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnComponentEndOverlapEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnComponentEndOverlapEvent_Comp_PropertyAddress, BGUBindOnComponentEndOverlapEvent_FunctionAddress, "Comp");
		BGUBindOnComponentEndOverlapEvent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnComponentEndOverlapEvent_FunctionAddress, "Comp");
		BGUBindOnComponentEndOverlapEvent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnComponentEndOverlapEvent_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnComponentEndOverlapEvent_Obj_PropertyAddress, BGUBindOnComponentEndOverlapEvent_FunctionAddress, "Obj");
		BGUBindOnComponentEndOverlapEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnComponentEndOverlapEvent_FunctionAddress, "Obj");
		BGUBindOnComponentEndOverlapEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnComponentEndOverlapEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnComponentEndOverlapEvent_FuncName_PropertyAddress, BGUBindOnComponentEndOverlapEvent_FunctionAddress, "FuncName");
		BGUBindOnComponentEndOverlapEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnComponentEndOverlapEvent_FunctionAddress, "FuncName");
		BGUBindOnComponentEndOverlapEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnComponentEndOverlapEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUBindOnComponentEndOverlapEvent_IsValid = BGUBindOnComponentEndOverlapEvent_FunctionAddress != IntPtr.Zero && BGUBindOnComponentEndOverlapEvent_Comp_IsValid && BGUBindOnComponentEndOverlapEvent_Obj_IsValid && BGUBindOnComponentEndOverlapEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnComponentEndOverlapEvent", BGUBindOnComponentEndOverlapEvent_IsValid);
		BGUBindOnComponentBeginOverlapEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnComponentBeginOverlapEvent");
		BGUBindOnComponentBeginOverlapEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnComponentBeginOverlapEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnComponentBeginOverlapEvent_Comp_PropertyAddress, BGUBindOnComponentBeginOverlapEvent_FunctionAddress, "Comp");
		BGUBindOnComponentBeginOverlapEvent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnComponentBeginOverlapEvent_FunctionAddress, "Comp");
		BGUBindOnComponentBeginOverlapEvent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnComponentBeginOverlapEvent_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnComponentBeginOverlapEvent_Obj_PropertyAddress, BGUBindOnComponentBeginOverlapEvent_FunctionAddress, "Obj");
		BGUBindOnComponentBeginOverlapEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnComponentBeginOverlapEvent_FunctionAddress, "Obj");
		BGUBindOnComponentBeginOverlapEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnComponentBeginOverlapEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnComponentBeginOverlapEvent_FuncName_PropertyAddress, BGUBindOnComponentBeginOverlapEvent_FunctionAddress, "FuncName");
		BGUBindOnComponentBeginOverlapEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnComponentBeginOverlapEvent_FunctionAddress, "FuncName");
		BGUBindOnComponentBeginOverlapEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnComponentBeginOverlapEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUBindOnComponentBeginOverlapEvent_IsValid = BGUBindOnComponentBeginOverlapEvent_FunctionAddress != IntPtr.Zero && BGUBindOnComponentBeginOverlapEvent_Comp_IsValid && BGUBindOnComponentBeginOverlapEvent_Obj_IsValid && BGUBindOnComponentBeginOverlapEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnComponentBeginOverlapEvent", BGUBindOnComponentBeginOverlapEvent_IsValid);
		BGUBindOnAllSetLevelsStateFinished_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnAllSetLevelsStateFinished");
		BGUBindOnAllSetLevelsStateFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnAllSetLevelsStateFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnAllSetLevelsStateFinished_Obj_PropertyAddress, BGUBindOnAllSetLevelsStateFinished_FunctionAddress, "Obj");
		BGUBindOnAllSetLevelsStateFinished_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnAllSetLevelsStateFinished_FunctionAddress, "Obj");
		BGUBindOnAllSetLevelsStateFinished_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnAllSetLevelsStateFinished_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnAllSetLevelsStateFinished_FuncName_PropertyAddress, BGUBindOnAllSetLevelsStateFinished_FunctionAddress, "FuncName");
		BGUBindOnAllSetLevelsStateFinished_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnAllSetLevelsStateFinished_FunctionAddress, "FuncName");
		BGUBindOnAllSetLevelsStateFinished_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnAllSetLevelsStateFinished_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUBindOnAllSetLevelsStateFinished_IsValid = BGUBindOnAllSetLevelsStateFinished_FunctionAddress != IntPtr.Zero && BGUBindOnAllSetLevelsStateFinished_Obj_IsValid && BGUBindOnAllSetLevelsStateFinished_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnAllSetLevelsStateFinished", BGUBindOnAllSetLevelsStateFinished_IsValid);
		BGUBindOnActorEndOverlapEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnActorEndOverlapEvent");
		BGUBindOnActorEndOverlapEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnActorEndOverlapEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnActorEndOverlapEvent_Actor_PropertyAddress, BGUBindOnActorEndOverlapEvent_FunctionAddress, "Actor");
		BGUBindOnActorEndOverlapEvent_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnActorEndOverlapEvent_FunctionAddress, "Actor");
		BGUBindOnActorEndOverlapEvent_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnActorEndOverlapEvent_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnActorEndOverlapEvent_Obj_PropertyAddress, BGUBindOnActorEndOverlapEvent_FunctionAddress, "Obj");
		BGUBindOnActorEndOverlapEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnActorEndOverlapEvent_FunctionAddress, "Obj");
		BGUBindOnActorEndOverlapEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnActorEndOverlapEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnActorEndOverlapEvent_FuncName_PropertyAddress, BGUBindOnActorEndOverlapEvent_FunctionAddress, "FuncName");
		BGUBindOnActorEndOverlapEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnActorEndOverlapEvent_FunctionAddress, "FuncName");
		BGUBindOnActorEndOverlapEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnActorEndOverlapEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUBindOnActorEndOverlapEvent_IsValid = BGUBindOnActorEndOverlapEvent_FunctionAddress != IntPtr.Zero && BGUBindOnActorEndOverlapEvent_Actor_IsValid && BGUBindOnActorEndOverlapEvent_Obj_IsValid && BGUBindOnActorEndOverlapEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnActorEndOverlapEvent", BGUBindOnActorEndOverlapEvent_IsValid);
		BGUBindOnActorBeginOverlapEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnActorBeginOverlapEvent");
		BGUBindOnActorBeginOverlapEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnActorBeginOverlapEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnActorBeginOverlapEvent_Actor_PropertyAddress, BGUBindOnActorBeginOverlapEvent_FunctionAddress, "Actor");
		BGUBindOnActorBeginOverlapEvent_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnActorBeginOverlapEvent_FunctionAddress, "Actor");
		BGUBindOnActorBeginOverlapEvent_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnActorBeginOverlapEvent_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnActorBeginOverlapEvent_Obj_PropertyAddress, BGUBindOnActorBeginOverlapEvent_FunctionAddress, "Obj");
		BGUBindOnActorBeginOverlapEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnActorBeginOverlapEvent_FunctionAddress, "Obj");
		BGUBindOnActorBeginOverlapEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnActorBeginOverlapEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnActorBeginOverlapEvent_FuncName_PropertyAddress, BGUBindOnActorBeginOverlapEvent_FunctionAddress, "FuncName");
		BGUBindOnActorBeginOverlapEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnActorBeginOverlapEvent_FunctionAddress, "FuncName");
		BGUBindOnActorBeginOverlapEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnActorBeginOverlapEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUBindOnActorBeginOverlapEvent_IsValid = BGUBindOnActorBeginOverlapEvent_FunctionAddress != IntPtr.Zero && BGUBindOnActorBeginOverlapEvent_Actor_IsValid && BGUBindOnActorBeginOverlapEvent_Obj_IsValid && BGUBindOnActorBeginOverlapEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:BGUBindOnActorBeginOverlapEvent", BGUBindOnActorBeginOverlapEvent_IsValid);
		AddNotifyPreloadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddNotifyPreloadedAsset");
		AddNotifyPreloadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNotifyPreloadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNotifyPreloadedAsset_Notify_PropertyAddress, AddNotifyPreloadedAsset_FunctionAddress, "Notify");
		AddNotifyPreloadedAsset_Notify_Offset = NativeReflectionCached.GetPropertyOffset(AddNotifyPreloadedAsset_FunctionAddress, "Notify");
		AddNotifyPreloadedAsset_Notify_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNotifyPreloadedAsset_FunctionAddress, "Notify", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNotifyPreloadedAsset_Asset_PropertyAddress, AddNotifyPreloadedAsset_FunctionAddress, "Asset");
		AddNotifyPreloadedAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(AddNotifyPreloadedAsset_FunctionAddress, "Asset");
		AddNotifyPreloadedAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNotifyPreloadedAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		AddNotifyPreloadedAsset_IsValid = AddNotifyPreloadedAsset_FunctionAddress != IntPtr.Zero && AddNotifyPreloadedAsset_Notify_IsValid && AddNotifyPreloadedAsset_Asset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibraryForCS:AddNotifyPreloadedAsset", AddNotifyPreloadedAsset_IsValid);
	}
}
