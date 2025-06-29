using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.EditorSubsystem;
using UnrealEngine.Engine;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.StaticMeshEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem", "StaticMeshEditor", UnrealModuleType.Engine)]
public class UStaticMeshEditorSubsystem : UEditorSubsystem
{
	private static bool SetNaniteSettings_IsValid;

	private static IntPtr SetNaniteSettings_FunctionAddress;

	private static int SetNaniteSettings_ParamsSize;

	private static bool SetNaniteSettings_StaticMesh_IsValid;

	private static FFieldAddress SetNaniteSettings_StaticMesh_PropertyAddress;

	private static int SetNaniteSettings_StaticMesh_Offset;

	private static bool SetNaniteSettings_NaniteSettings_IsValid;

	private static FFieldAddress SetNaniteSettings_NaniteSettings_PropertyAddress;

	private static int SetNaniteSettings_NaniteSettings_Offset;

	private static bool SetNaniteSettings_bApplyChanges_IsValid;

	private static FFieldAddress SetNaniteSettings_bApplyChanges_PropertyAddress;

	private static int SetNaniteSettings_bApplyChanges_Offset;

	private static bool SetLodsWithNotification_IsValid;

	private static IntPtr SetLodsWithNotification_FunctionAddress;

	private static int SetLodsWithNotification_ParamsSize;

	private static bool SetLodsWithNotification_StaticMesh_IsValid;

	private static FFieldAddress SetLodsWithNotification_StaticMesh_PropertyAddress;

	private static int SetLodsWithNotification_StaticMesh_Offset;

	private static bool SetLodsWithNotification_ReductionOptions_IsValid;

	private static FFieldAddress SetLodsWithNotification_ReductionOptions_PropertyAddress;

	private static int SetLodsWithNotification_ReductionOptions_Offset;

	private static bool SetLodsWithNotification_bApplyChanges_IsValid;

	private static FFieldAddress SetLodsWithNotification_bApplyChanges_PropertyAddress;

	private static int SetLodsWithNotification_bApplyChanges_Offset;

	private static bool SetLodsWithNotification_ReturnValue_IsValid;

	private static FFieldAddress SetLodsWithNotification_ReturnValue_PropertyAddress;

	private static int SetLodsWithNotification_ReturnValue_Offset;

	private static bool SetLods_IsValid;

	private static IntPtr SetLods_FunctionAddress;

	private static int SetLods_ParamsSize;

	private static bool SetLods_StaticMesh_IsValid;

	private static FFieldAddress SetLods_StaticMesh_PropertyAddress;

	private static int SetLods_StaticMesh_Offset;

	private static bool SetLods_ReductionOptions_IsValid;

	private static FFieldAddress SetLods_ReductionOptions_PropertyAddress;

	private static int SetLods_ReductionOptions_Offset;

	private static bool SetLods_ReturnValue_IsValid;

	private static FFieldAddress SetLods_ReturnValue_PropertyAddress;

	private static int SetLods_ReturnValue_Offset;

	private static bool SetLodReductionSettings_IsValid;

	private static IntPtr SetLodReductionSettings_FunctionAddress;

	private static int SetLodReductionSettings_ParamsSize;

	private static bool SetLodReductionSettings_StaticMesh_IsValid;

	private static FFieldAddress SetLodReductionSettings_StaticMesh_PropertyAddress;

	private static int SetLodReductionSettings_StaticMesh_Offset;

	private static bool SetLodReductionSettings_LodIndex_IsValid;

	private static FFieldAddress SetLodReductionSettings_LodIndex_PropertyAddress;

	private static int SetLodReductionSettings_LodIndex_Offset;

	private static bool SetLodReductionSettings_ReductionOptions_IsValid;

	private static FFieldAddress SetLodReductionSettings_ReductionOptions_PropertyAddress;

	private static int SetLodReductionSettings_ReductionOptions_Offset;

	private static bool SetLODMaterialSlot_IsValid;

	private static IntPtr SetLODMaterialSlot_FunctionAddress;

	private static int SetLODMaterialSlot_ParamsSize;

	private static bool SetLODMaterialSlot_StaticMesh_IsValid;

	private static FFieldAddress SetLODMaterialSlot_StaticMesh_PropertyAddress;

	private static int SetLODMaterialSlot_StaticMesh_Offset;

	private static bool SetLODMaterialSlot_MaterialSlotIndex_IsValid;

	private static FFieldAddress SetLODMaterialSlot_MaterialSlotIndex_PropertyAddress;

	private static int SetLODMaterialSlot_MaterialSlotIndex_Offset;

	private static bool SetLODMaterialSlot_LODIndex_IsValid;

	private static FFieldAddress SetLODMaterialSlot_LODIndex_PropertyAddress;

	private static int SetLODMaterialSlot_LODIndex_Offset;

	private static bool SetLODMaterialSlot_SectionIndex_IsValid;

	private static FFieldAddress SetLODMaterialSlot_SectionIndex_PropertyAddress;

	private static int SetLODMaterialSlot_SectionIndex_Offset;

	private static bool SetLODGroup_IsValid;

	private static IntPtr SetLODGroup_FunctionAddress;

	private static int SetLODGroup_ParamsSize;

	private static bool SetLODGroup_StaticMesh_IsValid;

	private static FFieldAddress SetLODGroup_StaticMesh_PropertyAddress;

	private static int SetLODGroup_StaticMesh_Offset;

	private static bool SetLODGroup_LODGroup_IsValid;

	private static FFieldAddress SetLODGroup_LODGroup_PropertyAddress;

	private static int SetLODGroup_LODGroup_Offset;

	private static bool SetLODGroup_bRebuildImmediately_IsValid;

	private static FFieldAddress SetLODGroup_bRebuildImmediately_PropertyAddress;

	private static int SetLODGroup_bRebuildImmediately_Offset;

	private static bool SetLODGroup_ReturnValue_IsValid;

	private static FFieldAddress SetLODGroup_ReturnValue_PropertyAddress;

	private static int SetLODGroup_ReturnValue_Offset;

	private static bool SetLodFromStaticMesh_IsValid;

	private static IntPtr SetLodFromStaticMesh_FunctionAddress;

	private static int SetLodFromStaticMesh_ParamsSize;

	private static bool SetLodFromStaticMesh_DestinationStaticMesh_IsValid;

	private static FFieldAddress SetLodFromStaticMesh_DestinationStaticMesh_PropertyAddress;

	private static int SetLodFromStaticMesh_DestinationStaticMesh_Offset;

	private static bool SetLodFromStaticMesh_DestinationLodIndex_IsValid;

	private static FFieldAddress SetLodFromStaticMesh_DestinationLodIndex_PropertyAddress;

	private static int SetLodFromStaticMesh_DestinationLodIndex_Offset;

	private static bool SetLodFromStaticMesh_SourceStaticMesh_IsValid;

	private static FFieldAddress SetLodFromStaticMesh_SourceStaticMesh_PropertyAddress;

	private static int SetLodFromStaticMesh_SourceStaticMesh_Offset;

	private static bool SetLodFromStaticMesh_SourceLodIndex_IsValid;

	private static FFieldAddress SetLodFromStaticMesh_SourceLodIndex_PropertyAddress;

	private static int SetLodFromStaticMesh_SourceLodIndex_Offset;

	private static bool SetLodFromStaticMesh_bReuseExistingMaterialSlots_IsValid;

	private static FFieldAddress SetLodFromStaticMesh_bReuseExistingMaterialSlots_PropertyAddress;

	private static int SetLodFromStaticMesh_bReuseExistingMaterialSlots_Offset;

	private static bool SetLodFromStaticMesh_ReturnValue_IsValid;

	private static FFieldAddress SetLodFromStaticMesh_ReturnValue_PropertyAddress;

	private static int SetLodFromStaticMesh_ReturnValue_Offset;

	private static bool SetLodBuildSettings_IsValid;

	private static IntPtr SetLodBuildSettings_FunctionAddress;

	private static int SetLodBuildSettings_ParamsSize;

	private static bool SetLodBuildSettings_StaticMesh_IsValid;

	private static FFieldAddress SetLodBuildSettings_StaticMesh_PropertyAddress;

	private static int SetLodBuildSettings_StaticMesh_Offset;

	private static bool SetLodBuildSettings_LodIndex_IsValid;

	private static FFieldAddress SetLodBuildSettings_LodIndex_PropertyAddress;

	private static int SetLodBuildSettings_LodIndex_Offset;

	private static bool SetLodBuildSettings_BuildOptions_IsValid;

	private static FFieldAddress SetLodBuildSettings_BuildOptions_PropertyAddress;

	private static int SetLodBuildSettings_BuildOptions_Offset;

	private static bool SetGenerateLightmapUv_IsValid;

	private static IntPtr SetGenerateLightmapUv_FunctionAddress;

	private static int SetGenerateLightmapUv_ParamsSize;

	private static bool SetGenerateLightmapUv_StaticMesh_IsValid;

	private static FFieldAddress SetGenerateLightmapUv_StaticMesh_PropertyAddress;

	private static int SetGenerateLightmapUv_StaticMesh_Offset;

	private static bool SetGenerateLightmapUv_bGenerateLightmapUVs_IsValid;

	private static FFieldAddress SetGenerateLightmapUv_bGenerateLightmapUVs_PropertyAddress;

	private static int SetGenerateLightmapUv_bGenerateLightmapUVs_Offset;

	private static bool SetGenerateLightmapUv_ReturnValue_IsValid;

	private static FFieldAddress SetGenerateLightmapUv_ReturnValue_PropertyAddress;

	private static int SetGenerateLightmapUv_ReturnValue_Offset;

	private static bool SetConvexDecompositionCollisionsWithNotification_IsValid;

	private static IntPtr SetConvexDecompositionCollisionsWithNotification_FunctionAddress;

	private static int SetConvexDecompositionCollisionsWithNotification_ParamsSize;

	private static bool SetConvexDecompositionCollisionsWithNotification_StaticMesh_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisionsWithNotification_StaticMesh_PropertyAddress;

	private static int SetConvexDecompositionCollisionsWithNotification_StaticMesh_Offset;

	private static bool SetConvexDecompositionCollisionsWithNotification_HullCount_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisionsWithNotification_HullCount_PropertyAddress;

	private static int SetConvexDecompositionCollisionsWithNotification_HullCount_Offset;

	private static bool SetConvexDecompositionCollisionsWithNotification_MaxHullVerts_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisionsWithNotification_MaxHullVerts_PropertyAddress;

	private static int SetConvexDecompositionCollisionsWithNotification_MaxHullVerts_Offset;

	private static bool SetConvexDecompositionCollisionsWithNotification_HullPrecision_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisionsWithNotification_HullPrecision_PropertyAddress;

	private static int SetConvexDecompositionCollisionsWithNotification_HullPrecision_Offset;

	private static bool SetConvexDecompositionCollisionsWithNotification_bApplyChanges_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisionsWithNotification_bApplyChanges_PropertyAddress;

	private static int SetConvexDecompositionCollisionsWithNotification_bApplyChanges_Offset;

	private static bool SetConvexDecompositionCollisionsWithNotification_ReturnValue_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisionsWithNotification_ReturnValue_PropertyAddress;

	private static int SetConvexDecompositionCollisionsWithNotification_ReturnValue_Offset;

	private static bool SetConvexDecompositionCollisions_IsValid;

	private static IntPtr SetConvexDecompositionCollisions_FunctionAddress;

	private static int SetConvexDecompositionCollisions_ParamsSize;

	private static bool SetConvexDecompositionCollisions_StaticMesh_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisions_StaticMesh_PropertyAddress;

	private static int SetConvexDecompositionCollisions_StaticMesh_Offset;

	private static bool SetConvexDecompositionCollisions_HullCount_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisions_HullCount_PropertyAddress;

	private static int SetConvexDecompositionCollisions_HullCount_Offset;

	private static bool SetConvexDecompositionCollisions_MaxHullVerts_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisions_MaxHullVerts_PropertyAddress;

	private static int SetConvexDecompositionCollisions_MaxHullVerts_Offset;

	private static bool SetConvexDecompositionCollisions_HullPrecision_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisions_HullPrecision_PropertyAddress;

	private static int SetConvexDecompositionCollisions_HullPrecision_Offset;

	private static bool SetConvexDecompositionCollisions_ReturnValue_IsValid;

	private static FFieldAddress SetConvexDecompositionCollisions_ReturnValue_PropertyAddress;

	private static int SetConvexDecompositionCollisions_ReturnValue_Offset;

	private static bool SetAllowCPUAccess_IsValid;

	private static IntPtr SetAllowCPUAccess_FunctionAddress;

	private static int SetAllowCPUAccess_ParamsSize;

	private static bool SetAllowCPUAccess_StaticMesh_IsValid;

	private static FFieldAddress SetAllowCPUAccess_StaticMesh_PropertyAddress;

	private static int SetAllowCPUAccess_StaticMesh_Offset;

	private static bool SetAllowCPUAccess_bAllowCPUAccess_IsValid;

	private static FFieldAddress SetAllowCPUAccess_bAllowCPUAccess_PropertyAddress;

	private static int SetAllowCPUAccess_bAllowCPUAccess_Offset;

	private static bool ReplaceMeshComponentsMeshesOnActors_IsValid;

	private static IntPtr ReplaceMeshComponentsMeshesOnActors_FunctionAddress;

	private static int ReplaceMeshComponentsMeshesOnActors_ParamsSize;

	private static bool ReplaceMeshComponentsMeshesOnActors_Actors_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMeshesOnActors_Actors_PropertyAddress;

	private static int ReplaceMeshComponentsMeshesOnActors_Actors_Offset;

	private static bool ReplaceMeshComponentsMeshesOnActors_MeshToBeReplaced_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMeshesOnActors_MeshToBeReplaced_PropertyAddress;

	private static int ReplaceMeshComponentsMeshesOnActors_MeshToBeReplaced_Offset;

	private static bool ReplaceMeshComponentsMeshesOnActors_NewMesh_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMeshesOnActors_NewMesh_PropertyAddress;

	private static int ReplaceMeshComponentsMeshesOnActors_NewMesh_Offset;

	private static bool ReplaceMeshComponentsMeshes_IsValid;

	private static IntPtr ReplaceMeshComponentsMeshes_FunctionAddress;

	private static int ReplaceMeshComponentsMeshes_ParamsSize;

	private static bool ReplaceMeshComponentsMeshes_MeshComponents_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMeshes_MeshComponents_PropertyAddress;

	private static int ReplaceMeshComponentsMeshes_MeshComponents_Offset;

	private static bool ReplaceMeshComponentsMeshes_MeshToBeReplaced_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMeshes_MeshToBeReplaced_PropertyAddress;

	private static int ReplaceMeshComponentsMeshes_MeshToBeReplaced_Offset;

	private static bool ReplaceMeshComponentsMeshes_NewMesh_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMeshes_NewMesh_PropertyAddress;

	private static int ReplaceMeshComponentsMeshes_NewMesh_Offset;

	private static bool ReplaceMeshComponentsMaterialsOnActors_IsValid;

	private static IntPtr ReplaceMeshComponentsMaterialsOnActors_FunctionAddress;

	private static int ReplaceMeshComponentsMaterialsOnActors_ParamsSize;

	private static bool ReplaceMeshComponentsMaterialsOnActors_Actors_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMaterialsOnActors_Actors_PropertyAddress;

	private static int ReplaceMeshComponentsMaterialsOnActors_Actors_Offset;

	private static bool ReplaceMeshComponentsMaterialsOnActors_MaterialToBeReplaced_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMaterialsOnActors_MaterialToBeReplaced_PropertyAddress;

	private static int ReplaceMeshComponentsMaterialsOnActors_MaterialToBeReplaced_Offset;

	private static bool ReplaceMeshComponentsMaterialsOnActors_NewMaterial_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMaterialsOnActors_NewMaterial_PropertyAddress;

	private static int ReplaceMeshComponentsMaterialsOnActors_NewMaterial_Offset;

	private static bool ReplaceMeshComponentsMaterials_IsValid;

	private static IntPtr ReplaceMeshComponentsMaterials_FunctionAddress;

	private static int ReplaceMeshComponentsMaterials_ParamsSize;

	private static bool ReplaceMeshComponentsMaterials_MeshComponents_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMaterials_MeshComponents_PropertyAddress;

	private static int ReplaceMeshComponentsMaterials_MeshComponents_Offset;

	private static bool ReplaceMeshComponentsMaterials_MaterialToBeReplaced_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMaterials_MaterialToBeReplaced_PropertyAddress;

	private static int ReplaceMeshComponentsMaterials_MaterialToBeReplaced_Offset;

	private static bool ReplaceMeshComponentsMaterials_NewMaterial_IsValid;

	private static FFieldAddress ReplaceMeshComponentsMaterials_NewMaterial_PropertyAddress;

	private static int ReplaceMeshComponentsMaterials_NewMaterial_Offset;

	private static bool RemoveUVChannel_IsValid;

	private static IntPtr RemoveUVChannel_FunctionAddress;

	private static int RemoveUVChannel_ParamsSize;

	private static bool RemoveUVChannel_StaticMesh_IsValid;

	private static FFieldAddress RemoveUVChannel_StaticMesh_PropertyAddress;

	private static int RemoveUVChannel_StaticMesh_Offset;

	private static bool RemoveUVChannel_LODIndex_IsValid;

	private static FFieldAddress RemoveUVChannel_LODIndex_PropertyAddress;

	private static int RemoveUVChannel_LODIndex_Offset;

	private static bool RemoveUVChannel_UVChannelIndex_IsValid;

	private static FFieldAddress RemoveUVChannel_UVChannelIndex_PropertyAddress;

	private static int RemoveUVChannel_UVChannelIndex_Offset;

	private static bool RemoveUVChannel_ReturnValue_IsValid;

	private static FFieldAddress RemoveUVChannel_ReturnValue_PropertyAddress;

	private static int RemoveUVChannel_ReturnValue_Offset;

	private static bool RemoveLods_IsValid;

	private static IntPtr RemoveLods_FunctionAddress;

	private static int RemoveLods_ParamsSize;

	private static bool RemoveLods_StaticMesh_IsValid;

	private static FFieldAddress RemoveLods_StaticMesh_PropertyAddress;

	private static int RemoveLods_StaticMesh_Offset;

	private static bool RemoveLods_ReturnValue_IsValid;

	private static FFieldAddress RemoveLods_ReturnValue_PropertyAddress;

	private static int RemoveLods_ReturnValue_Offset;

	private static bool RemoveCollisionsWithNotification_IsValid;

	private static IntPtr RemoveCollisionsWithNotification_FunctionAddress;

	private static int RemoveCollisionsWithNotification_ParamsSize;

	private static bool RemoveCollisionsWithNotification_StaticMesh_IsValid;

	private static FFieldAddress RemoveCollisionsWithNotification_StaticMesh_PropertyAddress;

	private static int RemoveCollisionsWithNotification_StaticMesh_Offset;

	private static bool RemoveCollisionsWithNotification_bApplyChanges_IsValid;

	private static FFieldAddress RemoveCollisionsWithNotification_bApplyChanges_PropertyAddress;

	private static int RemoveCollisionsWithNotification_bApplyChanges_Offset;

	private static bool RemoveCollisionsWithNotification_ReturnValue_IsValid;

	private static FFieldAddress RemoveCollisionsWithNotification_ReturnValue_PropertyAddress;

	private static int RemoveCollisionsWithNotification_ReturnValue_Offset;

	private static bool RemoveCollisions_IsValid;

	private static IntPtr RemoveCollisions_FunctionAddress;

	private static int RemoveCollisions_ParamsSize;

	private static bool RemoveCollisions_StaticMesh_IsValid;

	private static FFieldAddress RemoveCollisions_StaticMesh_PropertyAddress;

	private static int RemoveCollisions_StaticMesh_Offset;

	private static bool RemoveCollisions_ReturnValue_IsValid;

	private static FFieldAddress RemoveCollisions_ReturnValue_PropertyAddress;

	private static int RemoveCollisions_ReturnValue_Offset;

	private static bool ReimportAllCustomLODs_IsValid;

	private static IntPtr ReimportAllCustomLODs_FunctionAddress;

	private static int ReimportAllCustomLODs_ParamsSize;

	private static bool ReimportAllCustomLODs_StaticMesh_IsValid;

	private static FFieldAddress ReimportAllCustomLODs_StaticMesh_PropertyAddress;

	private static int ReimportAllCustomLODs_StaticMesh_Offset;

	private static bool ReimportAllCustomLODs_ReturnValue_IsValid;

	private static FFieldAddress ReimportAllCustomLODs_ReturnValue_PropertyAddress;

	private static int ReimportAllCustomLODs_ReturnValue_Offset;

	private static bool MergeStaticMeshActors_IsValid;

	private static IntPtr MergeStaticMeshActors_FunctionAddress;

	private static int MergeStaticMeshActors_ParamsSize;

	private static bool MergeStaticMeshActors_ActorsToMerge_IsValid;

	private static FFieldAddress MergeStaticMeshActors_ActorsToMerge_PropertyAddress;

	private static int MergeStaticMeshActors_ActorsToMerge_Offset;

	private static bool MergeStaticMeshActors_MergeOptions_IsValid;

	private static FFieldAddress MergeStaticMeshActors_MergeOptions_PropertyAddress;

	private static int MergeStaticMeshActors_MergeOptions_Offset;

	private static bool MergeStaticMeshActors_OutMergedActor_IsValid;

	private static FFieldAddress MergeStaticMeshActors_OutMergedActor_PropertyAddress;

	private static int MergeStaticMeshActors_OutMergedActor_Offset;

	private static bool MergeStaticMeshActors_ReturnValue_IsValid;

	private static FFieldAddress MergeStaticMeshActors_ReturnValue_PropertyAddress;

	private static int MergeStaticMeshActors_ReturnValue_Offset;

	private static bool JoinStaticMeshActors_IsValid;

	private static IntPtr JoinStaticMeshActors_FunctionAddress;

	private static int JoinStaticMeshActors_ParamsSize;

	private static bool JoinStaticMeshActors_ActorsToJoin_IsValid;

	private static FFieldAddress JoinStaticMeshActors_ActorsToJoin_PropertyAddress;

	private static int JoinStaticMeshActors_ActorsToJoin_Offset;

	private static bool JoinStaticMeshActors_JoinOptions_IsValid;

	private static FFieldAddress JoinStaticMeshActors_JoinOptions_PropertyAddress;

	private static int JoinStaticMeshActors_JoinOptions_Offset;

	private static bool JoinStaticMeshActors_ReturnValue_IsValid;

	private static FFieldAddress JoinStaticMeshActors_ReturnValue_PropertyAddress;

	private static int JoinStaticMeshActors_ReturnValue_Offset;

	private static bool IsSectionCollisionEnabled_IsValid;

	private static IntPtr IsSectionCollisionEnabled_FunctionAddress;

	private static int IsSectionCollisionEnabled_ParamsSize;

	private static bool IsSectionCollisionEnabled_StaticMesh_IsValid;

	private static FFieldAddress IsSectionCollisionEnabled_StaticMesh_PropertyAddress;

	private static int IsSectionCollisionEnabled_StaticMesh_Offset;

	private static bool IsSectionCollisionEnabled_LODIndex_IsValid;

	private static FFieldAddress IsSectionCollisionEnabled_LODIndex_PropertyAddress;

	private static int IsSectionCollisionEnabled_LODIndex_Offset;

	private static bool IsSectionCollisionEnabled_SectionIndex_IsValid;

	private static FFieldAddress IsSectionCollisionEnabled_SectionIndex_PropertyAddress;

	private static int IsSectionCollisionEnabled_SectionIndex_Offset;

	private static bool IsSectionCollisionEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsSectionCollisionEnabled_ReturnValue_PropertyAddress;

	private static int IsSectionCollisionEnabled_ReturnValue_Offset;

	private static bool InsertUVChannel_IsValid;

	private static IntPtr InsertUVChannel_FunctionAddress;

	private static int InsertUVChannel_ParamsSize;

	private static bool InsertUVChannel_StaticMesh_IsValid;

	private static FFieldAddress InsertUVChannel_StaticMesh_PropertyAddress;

	private static int InsertUVChannel_StaticMesh_Offset;

	private static bool InsertUVChannel_LODIndex_IsValid;

	private static FFieldAddress InsertUVChannel_LODIndex_PropertyAddress;

	private static int InsertUVChannel_LODIndex_Offset;

	private static bool InsertUVChannel_UVChannelIndex_IsValid;

	private static FFieldAddress InsertUVChannel_UVChannelIndex_PropertyAddress;

	private static int InsertUVChannel_UVChannelIndex_Offset;

	private static bool InsertUVChannel_ReturnValue_IsValid;

	private static FFieldAddress InsertUVChannel_ReturnValue_PropertyAddress;

	private static int InsertUVChannel_ReturnValue_Offset;

	private static bool ImportLOD_IsValid;

	private static IntPtr ImportLOD_FunctionAddress;

	private static int ImportLOD_ParamsSize;

	private static bool ImportLOD_BaseStaticMesh_IsValid;

	private static FFieldAddress ImportLOD_BaseStaticMesh_PropertyAddress;

	private static int ImportLOD_BaseStaticMesh_Offset;

	private static bool ImportLOD_LODIndex_IsValid;

	private static FFieldAddress ImportLOD_LODIndex_PropertyAddress;

	private static int ImportLOD_LODIndex_Offset;

	private static bool ImportLOD_SourceFilename_IsValid;

	private static FFieldAddress ImportLOD_SourceFilename_PropertyAddress;

	private static int ImportLOD_SourceFilename_Offset;

	private static bool ImportLOD_ReturnValue_IsValid;

	private static FFieldAddress ImportLOD_ReturnValue_PropertyAddress;

	private static int ImportLOD_ReturnValue_Offset;

	private static bool HasVertexColors_IsValid;

	private static IntPtr HasVertexColors_FunctionAddress;

	private static int HasVertexColors_ParamsSize;

	private static bool HasVertexColors_StaticMesh_IsValid;

	private static FFieldAddress HasVertexColors_StaticMesh_PropertyAddress;

	private static int HasVertexColors_StaticMesh_Offset;

	private static bool HasVertexColors_ReturnValue_IsValid;

	private static FFieldAddress HasVertexColors_ReturnValue_PropertyAddress;

	private static int HasVertexColors_ReturnValue_Offset;

	private static bool HasInstanceVertexColors_IsValid;

	private static IntPtr HasInstanceVertexColors_FunctionAddress;

	private static int HasInstanceVertexColors_ParamsSize;

	private static bool HasInstanceVertexColors_StaticMeshComponent_IsValid;

	private static FFieldAddress HasInstanceVertexColors_StaticMeshComponent_PropertyAddress;

	private static int HasInstanceVertexColors_StaticMeshComponent_Offset;

	private static bool HasInstanceVertexColors_ReturnValue_IsValid;

	private static FFieldAddress HasInstanceVertexColors_ReturnValue_PropertyAddress;

	private static int HasInstanceVertexColors_ReturnValue_Offset;

	private static bool GetSimpleCollisionCount_IsValid;

	private static IntPtr GetSimpleCollisionCount_FunctionAddress;

	private static int GetSimpleCollisionCount_ParamsSize;

	private static bool GetSimpleCollisionCount_StaticMesh_IsValid;

	private static FFieldAddress GetSimpleCollisionCount_StaticMesh_PropertyAddress;

	private static int GetSimpleCollisionCount_StaticMesh_Offset;

	private static bool GetSimpleCollisionCount_ReturnValue_IsValid;

	private static FFieldAddress GetSimpleCollisionCount_ReturnValue_PropertyAddress;

	private static int GetSimpleCollisionCount_ReturnValue_Offset;

	private static bool GetNumUVChannels_IsValid;

	private static IntPtr GetNumUVChannels_FunctionAddress;

	private static int GetNumUVChannels_ParamsSize;

	private static bool GetNumUVChannels_StaticMesh_IsValid;

	private static FFieldAddress GetNumUVChannels_StaticMesh_PropertyAddress;

	private static int GetNumUVChannels_StaticMesh_Offset;

	private static bool GetNumUVChannels_LODIndex_IsValid;

	private static FFieldAddress GetNumUVChannels_LODIndex_PropertyAddress;

	private static int GetNumUVChannels_LODIndex_Offset;

	private static bool GetNumUVChannels_ReturnValue_IsValid;

	private static FFieldAddress GetNumUVChannels_ReturnValue_PropertyAddress;

	private static int GetNumUVChannels_ReturnValue_Offset;

	private static bool GetNumberVerts_IsValid;

	private static IntPtr GetNumberVerts_FunctionAddress;

	private static int GetNumberVerts_ParamsSize;

	private static bool GetNumberVerts_StaticMesh_IsValid;

	private static FFieldAddress GetNumberVerts_StaticMesh_PropertyAddress;

	private static int GetNumberVerts_StaticMesh_Offset;

	private static bool GetNumberVerts_LODIndex_IsValid;

	private static FFieldAddress GetNumberVerts_LODIndex_PropertyAddress;

	private static int GetNumberVerts_LODIndex_Offset;

	private static bool GetNumberVerts_ReturnValue_IsValid;

	private static FFieldAddress GetNumberVerts_ReturnValue_PropertyAddress;

	private static int GetNumberVerts_ReturnValue_Offset;

	private static bool GetNumberMaterials_IsValid;

	private static IntPtr GetNumberMaterials_FunctionAddress;

	private static int GetNumberMaterials_ParamsSize;

	private static bool GetNumberMaterials_StaticMesh_IsValid;

	private static FFieldAddress GetNumberMaterials_StaticMesh_PropertyAddress;

	private static int GetNumberMaterials_StaticMesh_Offset;

	private static bool GetNumberMaterials_ReturnValue_IsValid;

	private static FFieldAddress GetNumberMaterials_ReturnValue_PropertyAddress;

	private static int GetNumberMaterials_ReturnValue_Offset;

	private static bool GetNaniteSettings_IsValid;

	private static IntPtr GetNaniteSettings_FunctionAddress;

	private static int GetNaniteSettings_ParamsSize;

	private static bool GetNaniteSettings_StaticMesh_IsValid;

	private static FFieldAddress GetNaniteSettings_StaticMesh_PropertyAddress;

	private static int GetNaniteSettings_StaticMesh_Offset;

	private static bool GetNaniteSettings_ReturnValue_IsValid;

	private static FFieldAddress GetNaniteSettings_ReturnValue_PropertyAddress;

	private static int GetNaniteSettings_ReturnValue_Offset;

	private static bool GetLodScreenSizes_IsValid;

	private static IntPtr GetLodScreenSizes_FunctionAddress;

	private static int GetLodScreenSizes_ParamsSize;

	private static bool GetLodScreenSizes_StaticMesh_IsValid;

	private static FFieldAddress GetLodScreenSizes_StaticMesh_PropertyAddress;

	private static int GetLodScreenSizes_StaticMesh_Offset;

	private static bool GetLodScreenSizes_ReturnValue_IsValid;

	private static FFieldAddress GetLodScreenSizes_ReturnValue_PropertyAddress;

	private static int GetLodScreenSizes_ReturnValue_Offset;

	private static bool GetLodReductionSettings_IsValid;

	private static IntPtr GetLodReductionSettings_FunctionAddress;

	private static int GetLodReductionSettings_ParamsSize;

	private static bool GetLodReductionSettings_StaticMesh_IsValid;

	private static FFieldAddress GetLodReductionSettings_StaticMesh_PropertyAddress;

	private static int GetLodReductionSettings_StaticMesh_Offset;

	private static bool GetLodReductionSettings_LodIndex_IsValid;

	private static FFieldAddress GetLodReductionSettings_LodIndex_PropertyAddress;

	private static int GetLodReductionSettings_LodIndex_Offset;

	private static bool GetLodReductionSettings_OutReductionOptions_IsValid;

	private static FFieldAddress GetLodReductionSettings_OutReductionOptions_PropertyAddress;

	private static int GetLodReductionSettings_OutReductionOptions_Offset;

	private static bool GetLODMaterialSlot_IsValid;

	private static IntPtr GetLODMaterialSlot_FunctionAddress;

	private static int GetLODMaterialSlot_ParamsSize;

	private static bool GetLODMaterialSlot_StaticMesh_IsValid;

	private static FFieldAddress GetLODMaterialSlot_StaticMesh_PropertyAddress;

	private static int GetLODMaterialSlot_StaticMesh_Offset;

	private static bool GetLODMaterialSlot_LODIndex_IsValid;

	private static FFieldAddress GetLODMaterialSlot_LODIndex_PropertyAddress;

	private static int GetLODMaterialSlot_LODIndex_Offset;

	private static bool GetLODMaterialSlot_SectionIndex_IsValid;

	private static FFieldAddress GetLODMaterialSlot_SectionIndex_PropertyAddress;

	private static int GetLODMaterialSlot_SectionIndex_Offset;

	private static bool GetLODMaterialSlot_ReturnValue_IsValid;

	private static FFieldAddress GetLODMaterialSlot_ReturnValue_PropertyAddress;

	private static int GetLODMaterialSlot_ReturnValue_Offset;

	private static bool GetLODGroup_IsValid;

	private static IntPtr GetLODGroup_FunctionAddress;

	private static int GetLODGroup_ParamsSize;

	private static bool GetLODGroup_StaticMesh_IsValid;

	private static FFieldAddress GetLODGroup_StaticMesh_PropertyAddress;

	private static int GetLODGroup_StaticMesh_Offset;

	private static bool GetLODGroup_ReturnValue_IsValid;

	private static FFieldAddress GetLODGroup_ReturnValue_PropertyAddress;

	private static int GetLODGroup_ReturnValue_Offset;

	private static bool GetLodCount_IsValid;

	private static IntPtr GetLodCount_FunctionAddress;

	private static int GetLodCount_ParamsSize;

	private static bool GetLodCount_StaticMesh_IsValid;

	private static FFieldAddress GetLodCount_StaticMesh_PropertyAddress;

	private static int GetLodCount_StaticMesh_Offset;

	private static bool GetLodCount_ReturnValue_IsValid;

	private static FFieldAddress GetLodCount_ReturnValue_PropertyAddress;

	private static int GetLodCount_ReturnValue_Offset;

	private static bool GetLodBuildSettings_IsValid;

	private static IntPtr GetLodBuildSettings_FunctionAddress;

	private static int GetLodBuildSettings_ParamsSize;

	private static bool GetLodBuildSettings_StaticMesh_IsValid;

	private static FFieldAddress GetLodBuildSettings_StaticMesh_PropertyAddress;

	private static int GetLodBuildSettings_StaticMesh_Offset;

	private static bool GetLodBuildSettings_LodIndex_IsValid;

	private static FFieldAddress GetLodBuildSettings_LodIndex_PropertyAddress;

	private static int GetLodBuildSettings_LodIndex_Offset;

	private static bool GetLodBuildSettings_OutBuildOptions_IsValid;

	private static FFieldAddress GetLodBuildSettings_OutBuildOptions_PropertyAddress;

	private static int GetLodBuildSettings_OutBuildOptions_Offset;

	private static bool GetConvexCollisionCount_IsValid;

	private static IntPtr GetConvexCollisionCount_FunctionAddress;

	private static int GetConvexCollisionCount_ParamsSize;

	private static bool GetConvexCollisionCount_StaticMesh_IsValid;

	private static FFieldAddress GetConvexCollisionCount_StaticMesh_PropertyAddress;

	private static int GetConvexCollisionCount_StaticMesh_Offset;

	private static bool GetConvexCollisionCount_ReturnValue_IsValid;

	private static FFieldAddress GetConvexCollisionCount_ReturnValue_PropertyAddress;

	private static int GetConvexCollisionCount_ReturnValue_Offset;

	private static bool GetCollisionComplexity_IsValid;

	private static IntPtr GetCollisionComplexity_FunctionAddress;

	private static int GetCollisionComplexity_ParamsSize;

	private static bool GetCollisionComplexity_StaticMesh_IsValid;

	private static FFieldAddress GetCollisionComplexity_StaticMesh_PropertyAddress;

	private static int GetCollisionComplexity_StaticMesh_Offset;

	private static bool GetCollisionComplexity_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionComplexity_ReturnValue_PropertyAddress;

	private static int GetCollisionComplexity_ReturnValue_Offset;

	private static bool GeneratePlanarUVChannel_IsValid;

	private static IntPtr GeneratePlanarUVChannel_FunctionAddress;

	private static int GeneratePlanarUVChannel_ParamsSize;

	private static bool GeneratePlanarUVChannel_StaticMesh_IsValid;

	private static FFieldAddress GeneratePlanarUVChannel_StaticMesh_PropertyAddress;

	private static int GeneratePlanarUVChannel_StaticMesh_Offset;

	private static bool GeneratePlanarUVChannel_LODIndex_IsValid;

	private static FFieldAddress GeneratePlanarUVChannel_LODIndex_PropertyAddress;

	private static int GeneratePlanarUVChannel_LODIndex_Offset;

	private static bool GeneratePlanarUVChannel_UVChannelIndex_IsValid;

	private static FFieldAddress GeneratePlanarUVChannel_UVChannelIndex_PropertyAddress;

	private static int GeneratePlanarUVChannel_UVChannelIndex_Offset;

	private static bool GeneratePlanarUVChannel_Position_IsValid;

	private static FFieldAddress GeneratePlanarUVChannel_Position_PropertyAddress;

	private static int GeneratePlanarUVChannel_Position_Offset;

	private static bool GeneratePlanarUVChannel_Orientation_IsValid;

	private static FFieldAddress GeneratePlanarUVChannel_Orientation_PropertyAddress;

	private static int GeneratePlanarUVChannel_Orientation_Offset;

	private static bool GeneratePlanarUVChannel_Tiling_IsValid;

	private static FFieldAddress GeneratePlanarUVChannel_Tiling_PropertyAddress;

	private static int GeneratePlanarUVChannel_Tiling_Offset;

	private static bool GeneratePlanarUVChannel_ReturnValue_IsValid;

	private static FFieldAddress GeneratePlanarUVChannel_ReturnValue_PropertyAddress;

	private static int GeneratePlanarUVChannel_ReturnValue_Offset;

	private static bool GenerateCylindricalUVChannel_IsValid;

	private static IntPtr GenerateCylindricalUVChannel_FunctionAddress;

	private static int GenerateCylindricalUVChannel_ParamsSize;

	private static bool GenerateCylindricalUVChannel_StaticMesh_IsValid;

	private static FFieldAddress GenerateCylindricalUVChannel_StaticMesh_PropertyAddress;

	private static int GenerateCylindricalUVChannel_StaticMesh_Offset;

	private static bool GenerateCylindricalUVChannel_LODIndex_IsValid;

	private static FFieldAddress GenerateCylindricalUVChannel_LODIndex_PropertyAddress;

	private static int GenerateCylindricalUVChannel_LODIndex_Offset;

	private static bool GenerateCylindricalUVChannel_UVChannelIndex_IsValid;

	private static FFieldAddress GenerateCylindricalUVChannel_UVChannelIndex_PropertyAddress;

	private static int GenerateCylindricalUVChannel_UVChannelIndex_Offset;

	private static bool GenerateCylindricalUVChannel_Position_IsValid;

	private static FFieldAddress GenerateCylindricalUVChannel_Position_PropertyAddress;

	private static int GenerateCylindricalUVChannel_Position_Offset;

	private static bool GenerateCylindricalUVChannel_Orientation_IsValid;

	private static FFieldAddress GenerateCylindricalUVChannel_Orientation_PropertyAddress;

	private static int GenerateCylindricalUVChannel_Orientation_Offset;

	private static bool GenerateCylindricalUVChannel_Tiling_IsValid;

	private static FFieldAddress GenerateCylindricalUVChannel_Tiling_PropertyAddress;

	private static int GenerateCylindricalUVChannel_Tiling_Offset;

	private static bool GenerateCylindricalUVChannel_ReturnValue_IsValid;

	private static FFieldAddress GenerateCylindricalUVChannel_ReturnValue_PropertyAddress;

	private static int GenerateCylindricalUVChannel_ReturnValue_Offset;

	private static bool GenerateBoxUVChannel_IsValid;

	private static IntPtr GenerateBoxUVChannel_FunctionAddress;

	private static int GenerateBoxUVChannel_ParamsSize;

	private static bool GenerateBoxUVChannel_StaticMesh_IsValid;

	private static FFieldAddress GenerateBoxUVChannel_StaticMesh_PropertyAddress;

	private static int GenerateBoxUVChannel_StaticMesh_Offset;

	private static bool GenerateBoxUVChannel_LODIndex_IsValid;

	private static FFieldAddress GenerateBoxUVChannel_LODIndex_PropertyAddress;

	private static int GenerateBoxUVChannel_LODIndex_Offset;

	private static bool GenerateBoxUVChannel_UVChannelIndex_IsValid;

	private static FFieldAddress GenerateBoxUVChannel_UVChannelIndex_PropertyAddress;

	private static int GenerateBoxUVChannel_UVChannelIndex_Offset;

	private static bool GenerateBoxUVChannel_Position_IsValid;

	private static FFieldAddress GenerateBoxUVChannel_Position_PropertyAddress;

	private static int GenerateBoxUVChannel_Position_Offset;

	private static bool GenerateBoxUVChannel_Orientation_IsValid;

	private static FFieldAddress GenerateBoxUVChannel_Orientation_PropertyAddress;

	private static int GenerateBoxUVChannel_Orientation_Offset;

	private static bool GenerateBoxUVChannel_Size_IsValid;

	private static FFieldAddress GenerateBoxUVChannel_Size_PropertyAddress;

	private static int GenerateBoxUVChannel_Size_Offset;

	private static bool GenerateBoxUVChannel_ReturnValue_IsValid;

	private static FFieldAddress GenerateBoxUVChannel_ReturnValue_PropertyAddress;

	private static int GenerateBoxUVChannel_ReturnValue_Offset;

	private static bool EnableSectionCollision_IsValid;

	private static IntPtr EnableSectionCollision_FunctionAddress;

	private static int EnableSectionCollision_ParamsSize;

	private static bool EnableSectionCollision_StaticMesh_IsValid;

	private static FFieldAddress EnableSectionCollision_StaticMesh_PropertyAddress;

	private static int EnableSectionCollision_StaticMesh_Offset;

	private static bool EnableSectionCollision_bCollisionEnabled_IsValid;

	private static FFieldAddress EnableSectionCollision_bCollisionEnabled_PropertyAddress;

	private static int EnableSectionCollision_bCollisionEnabled_Offset;

	private static bool EnableSectionCollision_LODIndex_IsValid;

	private static FFieldAddress EnableSectionCollision_LODIndex_PropertyAddress;

	private static int EnableSectionCollision_LODIndex_Offset;

	private static bool EnableSectionCollision_SectionIndex_IsValid;

	private static FFieldAddress EnableSectionCollision_SectionIndex_PropertyAddress;

	private static int EnableSectionCollision_SectionIndex_Offset;

	private static bool EnableSectionCastShadow_IsValid;

	private static IntPtr EnableSectionCastShadow_FunctionAddress;

	private static int EnableSectionCastShadow_ParamsSize;

	private static bool EnableSectionCastShadow_StaticMesh_IsValid;

	private static FFieldAddress EnableSectionCastShadow_StaticMesh_PropertyAddress;

	private static int EnableSectionCastShadow_StaticMesh_Offset;

	private static bool EnableSectionCastShadow_bCastShadow_IsValid;

	private static FFieldAddress EnableSectionCastShadow_bCastShadow_PropertyAddress;

	private static int EnableSectionCastShadow_bCastShadow_Offset;

	private static bool EnableSectionCastShadow_LODIndex_IsValid;

	private static FFieldAddress EnableSectionCastShadow_LODIndex_PropertyAddress;

	private static int EnableSectionCastShadow_LODIndex_Offset;

	private static bool EnableSectionCastShadow_SectionIndex_IsValid;

	private static FFieldAddress EnableSectionCastShadow_SectionIndex_PropertyAddress;

	private static int EnableSectionCastShadow_SectionIndex_Offset;

	private static bool CreateProxyMeshActor_IsValid;

	private static IntPtr CreateProxyMeshActor_FunctionAddress;

	private static int CreateProxyMeshActor_ParamsSize;

	private static bool CreateProxyMeshActor_ActorsToMerge_IsValid;

	private static FFieldAddress CreateProxyMeshActor_ActorsToMerge_PropertyAddress;

	private static int CreateProxyMeshActor_ActorsToMerge_Offset;

	private static bool CreateProxyMeshActor_MergeOptions_IsValid;

	private static FFieldAddress CreateProxyMeshActor_MergeOptions_PropertyAddress;

	private static int CreateProxyMeshActor_MergeOptions_Offset;

	private static bool CreateProxyMeshActor_OutMergedActor_IsValid;

	private static FFieldAddress CreateProxyMeshActor_OutMergedActor_PropertyAddress;

	private static int CreateProxyMeshActor_OutMergedActor_Offset;

	private static bool CreateProxyMeshActor_ReturnValue_IsValid;

	private static FFieldAddress CreateProxyMeshActor_ReturnValue_PropertyAddress;

	private static int CreateProxyMeshActor_ReturnValue_Offset;

	private static bool BulkSetConvexDecompositionCollisionsWithNotification_IsValid;

	private static IntPtr BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress;

	private static int BulkSetConvexDecompositionCollisionsWithNotification_ParamsSize;

	private static bool BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_Offset;

	private static bool BulkSetConvexDecompositionCollisionsWithNotification_HullCount_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisionsWithNotification_HullCount_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisionsWithNotification_HullCount_Offset;

	private static bool BulkSetConvexDecompositionCollisionsWithNotification_MaxHullVerts_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisionsWithNotification_MaxHullVerts_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisionsWithNotification_MaxHullVerts_Offset;

	private static bool BulkSetConvexDecompositionCollisionsWithNotification_HullPrecision_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisionsWithNotification_HullPrecision_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisionsWithNotification_HullPrecision_Offset;

	private static bool BulkSetConvexDecompositionCollisionsWithNotification_bApplyChanges_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisionsWithNotification_bApplyChanges_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisionsWithNotification_bApplyChanges_Offset;

	private static bool BulkSetConvexDecompositionCollisionsWithNotification_ReturnValue_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisionsWithNotification_ReturnValue_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisionsWithNotification_ReturnValue_Offset;

	private static bool BulkSetConvexDecompositionCollisions_IsValid;

	private static IntPtr BulkSetConvexDecompositionCollisions_FunctionAddress;

	private static int BulkSetConvexDecompositionCollisions_ParamsSize;

	private static bool BulkSetConvexDecompositionCollisions_StaticMeshes_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisions_StaticMeshes_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisions_StaticMeshes_Offset;

	private static bool BulkSetConvexDecompositionCollisions_HullCount_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisions_HullCount_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisions_HullCount_Offset;

	private static bool BulkSetConvexDecompositionCollisions_MaxHullVerts_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisions_MaxHullVerts_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisions_MaxHullVerts_Offset;

	private static bool BulkSetConvexDecompositionCollisions_HullPrecision_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisions_HullPrecision_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisions_HullPrecision_Offset;

	private static bool BulkSetConvexDecompositionCollisions_ReturnValue_IsValid;

	private static FFieldAddress BulkSetConvexDecompositionCollisions_ReturnValue_PropertyAddress;

	private static int BulkSetConvexDecompositionCollisions_ReturnValue_Offset;

	private static bool AddUVChannel_IsValid;

	private static IntPtr AddUVChannel_FunctionAddress;

	private static int AddUVChannel_ParamsSize;

	private static bool AddUVChannel_StaticMesh_IsValid;

	private static FFieldAddress AddUVChannel_StaticMesh_PropertyAddress;

	private static int AddUVChannel_StaticMesh_Offset;

	private static bool AddUVChannel_LODIndex_IsValid;

	private static FFieldAddress AddUVChannel_LODIndex_PropertyAddress;

	private static int AddUVChannel_LODIndex_Offset;

	private static bool AddUVChannel_ReturnValue_IsValid;

	private static FFieldAddress AddUVChannel_ReturnValue_PropertyAddress;

	private static int AddUVChannel_ReturnValue_Offset;

	private static bool AddSimpleCollisionsWithNotification_IsValid;

	private static IntPtr AddSimpleCollisionsWithNotification_FunctionAddress;

	private static int AddSimpleCollisionsWithNotification_ParamsSize;

	private static bool AddSimpleCollisionsWithNotification_StaticMesh_IsValid;

	private static FFieldAddress AddSimpleCollisionsWithNotification_StaticMesh_PropertyAddress;

	private static int AddSimpleCollisionsWithNotification_StaticMesh_Offset;

	private static bool AddSimpleCollisionsWithNotification_ShapeType_IsValid;

	private static FFieldAddress AddSimpleCollisionsWithNotification_ShapeType_PropertyAddress;

	private static int AddSimpleCollisionsWithNotification_ShapeType_Offset;

	private static bool AddSimpleCollisionsWithNotification_bApplyChanges_IsValid;

	private static FFieldAddress AddSimpleCollisionsWithNotification_bApplyChanges_PropertyAddress;

	private static int AddSimpleCollisionsWithNotification_bApplyChanges_Offset;

	private static bool AddSimpleCollisionsWithNotification_ReturnValue_IsValid;

	private static FFieldAddress AddSimpleCollisionsWithNotification_ReturnValue_PropertyAddress;

	private static int AddSimpleCollisionsWithNotification_ReturnValue_Offset;

	private static bool AddSimpleCollisions_IsValid;

	private static IntPtr AddSimpleCollisions_FunctionAddress;

	private static int AddSimpleCollisions_ParamsSize;

	private static bool AddSimpleCollisions_StaticMesh_IsValid;

	private static FFieldAddress AddSimpleCollisions_StaticMesh_PropertyAddress;

	private static int AddSimpleCollisions_StaticMesh_Offset;

	private static bool AddSimpleCollisions_ShapeType_IsValid;

	private static FFieldAddress AddSimpleCollisions_ShapeType_PropertyAddress;

	private static int AddSimpleCollisions_ShapeType_Offset;

	private static bool AddSimpleCollisions_ReturnValue_IsValid;

	private static FFieldAddress AddSimpleCollisions_ReturnValue_PropertyAddress;

	private static int AddSimpleCollisions_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetNaniteSettings")]
	public unsafe void SetNaniteSettings(UStaticMesh StaticMesh, FMeshNaniteSettings NaniteSettings, bool bApplyChanges = true)
	{
		CheckDestroyed();
		if (!SetNaniteSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetNaniteSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNaniteSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNaniteSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetNaniteSettings_StaticMesh_Offset), 0, SetNaniteSettings_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InitializeValue_InContainer(SetNaniteSettings_NaniteSettings_PropertyAddress.Address, intPtr);
		FMeshNaniteSettings.ToNative(IntPtr.Add(intPtr, SetNaniteSettings_NaniteSettings_Offset), 0, SetNaniteSettings_NaniteSettings_PropertyAddress.Address, NaniteSettings);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNaniteSettings_bApplyChanges_Offset), 0, SetNaniteSettings_bApplyChanges_PropertyAddress.Address, bApplyChanges);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNaniteSettings_FunctionAddress, intPtr, SetNaniteSettings_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodsWithNotification")]
	public unsafe int SetLodsWithNotification(UStaticMesh StaticMesh, FStaticMeshReductionOptions ReductionOptions, bool bApplyChanges)
	{
		CheckDestroyed();
		if (!SetLodsWithNotification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodsWithNotification");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLodsWithNotification_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLodsWithNotification_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetLodsWithNotification_StaticMesh_Offset), 0, SetLodsWithNotification_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InitializeValue_InContainer(SetLodsWithNotification_ReductionOptions_PropertyAddress.Address, intPtr);
		FStaticMeshReductionOptions.ToNative(IntPtr.Add(intPtr, SetLodsWithNotification_ReductionOptions_Offset), 0, SetLodsWithNotification_ReductionOptions_PropertyAddress.Address, ReductionOptions);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLodsWithNotification_bApplyChanges_Offset), 0, SetLodsWithNotification_bApplyChanges_PropertyAddress.Address, bApplyChanges);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLodsWithNotification_FunctionAddress, intPtr, SetLodsWithNotification_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLodsWithNotification_ReductionOptions_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SetLodsWithNotification_ReturnValue_Offset), 0, SetLodsWithNotification_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLods")]
	public unsafe int SetLods(UStaticMesh StaticMesh, FStaticMeshReductionOptions ReductionOptions)
	{
		CheckDestroyed();
		if (!SetLods_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLods");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLods_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLods_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetLods_StaticMesh_Offset), 0, SetLods_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InitializeValue_InContainer(SetLods_ReductionOptions_PropertyAddress.Address, intPtr);
		FStaticMeshReductionOptions.ToNative(IntPtr.Add(intPtr, SetLods_ReductionOptions_Offset), 0, SetLods_ReductionOptions_PropertyAddress.Address, ReductionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLods_FunctionAddress, intPtr, SetLods_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLods_ReductionOptions_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SetLods_ReturnValue_Offset), 0, SetLods_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodReductionSettings")]
	public unsafe void SetLodReductionSettings(UStaticMesh StaticMesh, int LodIndex, FMeshReductionSettings ReductionOptions)
	{
		CheckDestroyed();
		if (!SetLodReductionSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodReductionSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLodReductionSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLodReductionSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetLodReductionSettings_StaticMesh_Offset), 0, SetLodReductionSettings_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLodReductionSettings_LodIndex_Offset), 0, SetLodReductionSettings_LodIndex_PropertyAddress.Address, LodIndex);
		NativeReflection.InitializeValue_InContainer(SetLodReductionSettings_ReductionOptions_PropertyAddress.Address, intPtr);
		FMeshReductionSettings.ToNative(IntPtr.Add(intPtr, SetLodReductionSettings_ReductionOptions_Offset), 0, SetLodReductionSettings_ReductionOptions_PropertyAddress.Address, ReductionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLodReductionSettings_FunctionAddress, intPtr, SetLodReductionSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLODMaterialSlot")]
	public unsafe void SetLODMaterialSlot(UStaticMesh StaticMesh, int MaterialSlotIndex, int LODIndex, int SectionIndex)
	{
		CheckDestroyed();
		if (!SetLODMaterialSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLODMaterialSlot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLODMaterialSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLODMaterialSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetLODMaterialSlot_StaticMesh_Offset), 0, SetLODMaterialSlot_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLODMaterialSlot_MaterialSlotIndex_Offset), 0, SetLODMaterialSlot_MaterialSlotIndex_PropertyAddress.Address, MaterialSlotIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLODMaterialSlot_LODIndex_Offset), 0, SetLODMaterialSlot_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLODMaterialSlot_SectionIndex_Offset), 0, SetLODMaterialSlot_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLODMaterialSlot_FunctionAddress, intPtr, SetLODMaterialSlot_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLODGroup")]
	public unsafe bool SetLODGroup(UStaticMesh StaticMesh, FName LODGroup, bool bRebuildImmediately = true)
	{
		CheckDestroyed();
		if (!SetLODGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLODGroup");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLODGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLODGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetLODGroup_StaticMesh_Offset), 0, SetLODGroup_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLODGroup_LODGroup_Offset), 0, SetLODGroup_LODGroup_PropertyAddress.Address, LODGroup);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLODGroup_bRebuildImmediately_Offset), 0, SetLODGroup_bRebuildImmediately_PropertyAddress.Address, bRebuildImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLODGroup_FunctionAddress, intPtr, SetLODGroup_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLODGroup_ReturnValue_Offset), 0, SetLODGroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodFromStaticMesh")]
	public unsafe int SetLodFromStaticMesh(UStaticMesh DestinationStaticMesh, int DestinationLodIndex, UStaticMesh SourceStaticMesh, int SourceLodIndex, bool bReuseExistingMaterialSlots)
	{
		CheckDestroyed();
		if (!SetLodFromStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodFromStaticMesh");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLodFromStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLodFromStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetLodFromStaticMesh_DestinationStaticMesh_Offset), 0, SetLodFromStaticMesh_DestinationStaticMesh_PropertyAddress.Address, DestinationStaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLodFromStaticMesh_DestinationLodIndex_Offset), 0, SetLodFromStaticMesh_DestinationLodIndex_PropertyAddress.Address, DestinationLodIndex);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetLodFromStaticMesh_SourceStaticMesh_Offset), 0, SetLodFromStaticMesh_SourceStaticMesh_PropertyAddress.Address, SourceStaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLodFromStaticMesh_SourceLodIndex_Offset), 0, SetLodFromStaticMesh_SourceLodIndex_PropertyAddress.Address, SourceLodIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLodFromStaticMesh_bReuseExistingMaterialSlots_Offset), 0, SetLodFromStaticMesh_bReuseExistingMaterialSlots_PropertyAddress.Address, bReuseExistingMaterialSlots);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLodFromStaticMesh_FunctionAddress, intPtr, SetLodFromStaticMesh_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SetLodFromStaticMesh_ReturnValue_Offset), 0, SetLodFromStaticMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodBuildSettings")]
	public unsafe void SetLodBuildSettings(UStaticMesh StaticMesh, int LodIndex, FMeshBuildSettings BuildOptions)
	{
		CheckDestroyed();
		if (!SetLodBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodBuildSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLodBuildSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLodBuildSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetLodBuildSettings_StaticMesh_Offset), 0, SetLodBuildSettings_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLodBuildSettings_LodIndex_Offset), 0, SetLodBuildSettings_LodIndex_PropertyAddress.Address, LodIndex);
		NativeReflection.InitializeValue_InContainer(SetLodBuildSettings_BuildOptions_PropertyAddress.Address, intPtr);
		FMeshBuildSettings.ToNative(IntPtr.Add(intPtr, SetLodBuildSettings_BuildOptions_Offset), 0, SetLodBuildSettings_BuildOptions_PropertyAddress.Address, BuildOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLodBuildSettings_FunctionAddress, intPtr, SetLodBuildSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "SetGenerateLightmapUVs")]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetGenerateLightmapUVs")]
	public unsafe bool SetGenerateLightmapUv(UStaticMesh StaticMesh, bool bGenerateLightmapUVs)
	{
		CheckDestroyed();
		if (!SetGenerateLightmapUv_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetGenerateLightmapUVs");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGenerateLightmapUv_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGenerateLightmapUv_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetGenerateLightmapUv_StaticMesh_Offset), 0, SetGenerateLightmapUv_StaticMesh_PropertyAddress.Address, StaticMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGenerateLightmapUv_bGenerateLightmapUVs_Offset), 0, SetGenerateLightmapUv_bGenerateLightmapUVs_PropertyAddress.Address, bGenerateLightmapUVs);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGenerateLightmapUv_FunctionAddress, intPtr, SetGenerateLightmapUv_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetGenerateLightmapUv_ReturnValue_Offset), 0, SetGenerateLightmapUv_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetConvexDecompositionCollisionsWithNotification")]
	public unsafe bool SetConvexDecompositionCollisionsWithNotification(UStaticMesh StaticMesh, int HullCount, int MaxHullVerts, int HullPrecision, bool bApplyChanges)
	{
		CheckDestroyed();
		if (!SetConvexDecompositionCollisionsWithNotification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetConvexDecompositionCollisionsWithNotification");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConvexDecompositionCollisionsWithNotification_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConvexDecompositionCollisionsWithNotification_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisionsWithNotification_StaticMesh_Offset), 0, SetConvexDecompositionCollisionsWithNotification_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisionsWithNotification_HullCount_Offset), 0, SetConvexDecompositionCollisionsWithNotification_HullCount_PropertyAddress.Address, HullCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisionsWithNotification_MaxHullVerts_Offset), 0, SetConvexDecompositionCollisionsWithNotification_MaxHullVerts_PropertyAddress.Address, MaxHullVerts);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisionsWithNotification_HullPrecision_Offset), 0, SetConvexDecompositionCollisionsWithNotification_HullPrecision_PropertyAddress.Address, HullPrecision);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisionsWithNotification_bApplyChanges_Offset), 0, SetConvexDecompositionCollisionsWithNotification_bApplyChanges_PropertyAddress.Address, bApplyChanges);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConvexDecompositionCollisionsWithNotification_FunctionAddress, intPtr, SetConvexDecompositionCollisionsWithNotification_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisionsWithNotification_ReturnValue_Offset), 0, SetConvexDecompositionCollisionsWithNotification_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetConvexDecompositionCollisions")]
	public unsafe bool SetConvexDecompositionCollisions(UStaticMesh StaticMesh, int HullCount, int MaxHullVerts, int HullPrecision)
	{
		CheckDestroyed();
		if (!SetConvexDecompositionCollisions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetConvexDecompositionCollisions");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConvexDecompositionCollisions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConvexDecompositionCollisions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisions_StaticMesh_Offset), 0, SetConvexDecompositionCollisions_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisions_HullCount_Offset), 0, SetConvexDecompositionCollisions_HullCount_PropertyAddress.Address, HullCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisions_MaxHullVerts_Offset), 0, SetConvexDecompositionCollisions_MaxHullVerts_PropertyAddress.Address, MaxHullVerts);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisions_HullPrecision_Offset), 0, SetConvexDecompositionCollisions_HullPrecision_PropertyAddress.Address, HullPrecision);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConvexDecompositionCollisions_FunctionAddress, intPtr, SetConvexDecompositionCollisions_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetConvexDecompositionCollisions_ReturnValue_Offset), 0, SetConvexDecompositionCollisions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetAllowCPUAccess")]
	public unsafe void SetAllowCPUAccess(UStaticMesh StaticMesh, bool bAllowCPUAccess)
	{
		CheckDestroyed();
		if (!SetAllowCPUAccess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetAllowCPUAccess");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllowCPUAccess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllowCPUAccess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetAllowCPUAccess_StaticMesh_Offset), 0, SetAllowCPUAccess_StaticMesh_PropertyAddress.Address, StaticMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllowCPUAccess_bAllowCPUAccess_Offset), 0, SetAllowCPUAccess_bAllowCPUAccess_PropertyAddress.Address, bAllowCPUAccess);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllowCPUAccess_FunctionAddress, intPtr, SetAllowCPUAccess_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMeshesOnActors")]
	public unsafe void ReplaceMeshComponentsMeshesOnActors(List<AActor> Actors, UStaticMesh MeshToBeReplaced, UStaticMesh NewMesh)
	{
		CheckDestroyed();
		if (!ReplaceMeshComponentsMeshesOnActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMeshesOnActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceMeshComponentsMeshesOnActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceMeshComponentsMeshesOnActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ReplaceMeshComponentsMeshesOnActors_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMeshesOnActors_Actors_Offset), Actors);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMeshesOnActors_MeshToBeReplaced_Offset), 0, ReplaceMeshComponentsMeshesOnActors_MeshToBeReplaced_PropertyAddress.Address, MeshToBeReplaced);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMeshesOnActors_NewMesh_Offset), 0, ReplaceMeshComponentsMeshesOnActors_NewMesh_PropertyAddress.Address, NewMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReplaceMeshComponentsMeshesOnActors_FunctionAddress, intPtr, ReplaceMeshComponentsMeshesOnActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceMeshComponentsMeshesOnActors_Actors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMeshes")]
	public unsafe void ReplaceMeshComponentsMeshes(List<UStaticMeshComponent> MeshComponents, UStaticMesh MeshToBeReplaced, UStaticMesh NewMesh)
	{
		CheckDestroyed();
		if (!ReplaceMeshComponentsMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMeshes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceMeshComponentsMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceMeshComponentsMeshes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UStaticMeshComponent>(1, ReplaceMeshComponentsMeshes_MeshComponents_PropertyAddress, CachedMarshalingDelegates<UStaticMeshComponent, UObjectMarshaler<UStaticMeshComponent>>.FromNative, CachedMarshalingDelegates<UStaticMeshComponent, UObjectMarshaler<UStaticMeshComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMeshes_MeshComponents_Offset), MeshComponents);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMeshes_MeshToBeReplaced_Offset), 0, ReplaceMeshComponentsMeshes_MeshToBeReplaced_PropertyAddress.Address, MeshToBeReplaced);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMeshes_NewMesh_Offset), 0, ReplaceMeshComponentsMeshes_NewMesh_PropertyAddress.Address, NewMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReplaceMeshComponentsMeshes_FunctionAddress, intPtr, ReplaceMeshComponentsMeshes_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceMeshComponentsMeshes_MeshComponents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMaterialsOnActors")]
	public unsafe void ReplaceMeshComponentsMaterialsOnActors(List<AActor> Actors, UMaterialInterface MaterialToBeReplaced, UMaterialInterface NewMaterial)
	{
		CheckDestroyed();
		if (!ReplaceMeshComponentsMaterialsOnActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMaterialsOnActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceMeshComponentsMaterialsOnActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceMeshComponentsMaterialsOnActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ReplaceMeshComponentsMaterialsOnActors_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMaterialsOnActors_Actors_Offset), Actors);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMaterialsOnActors_MaterialToBeReplaced_Offset), 0, ReplaceMeshComponentsMaterialsOnActors_MaterialToBeReplaced_PropertyAddress.Address, MaterialToBeReplaced);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMaterialsOnActors_NewMaterial_Offset), 0, ReplaceMeshComponentsMaterialsOnActors_NewMaterial_PropertyAddress.Address, NewMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, intPtr, ReplaceMeshComponentsMaterialsOnActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceMeshComponentsMaterialsOnActors_Actors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMaterials")]
	public unsafe void ReplaceMeshComponentsMaterials(List<UMeshComponent> MeshComponents, UMaterialInterface MaterialToBeReplaced, UMaterialInterface NewMaterial)
	{
		CheckDestroyed();
		if (!ReplaceMeshComponentsMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceMeshComponentsMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceMeshComponentsMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMeshComponent>(1, ReplaceMeshComponentsMaterials_MeshComponents_PropertyAddress, CachedMarshalingDelegates<UMeshComponent, UObjectMarshaler<UMeshComponent>>.FromNative, CachedMarshalingDelegates<UMeshComponent, UObjectMarshaler<UMeshComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMaterials_MeshComponents_Offset), MeshComponents);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMaterials_MaterialToBeReplaced_Offset), 0, ReplaceMeshComponentsMaterials_MaterialToBeReplaced_PropertyAddress.Address, MaterialToBeReplaced);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, ReplaceMeshComponentsMaterials_NewMaterial_Offset), 0, ReplaceMeshComponentsMaterials_NewMaterial_PropertyAddress.Address, NewMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReplaceMeshComponentsMaterials_FunctionAddress, intPtr, ReplaceMeshComponentsMaterials_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceMeshComponentsMaterials_MeshComponents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveUVChannel")]
	public unsafe bool RemoveUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex)
	{
		CheckDestroyed();
		if (!RemoveUVChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveUVChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveUVChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveUVChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, RemoveUVChannel_StaticMesh_Offset), 0, RemoveUVChannel_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveUVChannel_LODIndex_Offset), 0, RemoveUVChannel_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveUVChannel_UVChannelIndex_Offset), 0, RemoveUVChannel_UVChannelIndex_PropertyAddress.Address, UVChannelIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveUVChannel_FunctionAddress, intPtr, RemoveUVChannel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveUVChannel_ReturnValue_Offset), 0, RemoveUVChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveLods")]
	public unsafe bool RemoveLods(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!RemoveLods_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveLods");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveLods_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveLods_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, RemoveLods_StaticMesh_Offset), 0, RemoveLods_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveLods_FunctionAddress, intPtr, RemoveLods_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveLods_ReturnValue_Offset), 0, RemoveLods_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveCollisionsWithNotification")]
	public unsafe bool RemoveCollisionsWithNotification(UStaticMesh StaticMesh, bool bApplyChanges)
	{
		CheckDestroyed();
		if (!RemoveCollisionsWithNotification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveCollisionsWithNotification");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveCollisionsWithNotification_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveCollisionsWithNotification_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, RemoveCollisionsWithNotification_StaticMesh_Offset), 0, RemoveCollisionsWithNotification_StaticMesh_PropertyAddress.Address, StaticMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveCollisionsWithNotification_bApplyChanges_Offset), 0, RemoveCollisionsWithNotification_bApplyChanges_PropertyAddress.Address, bApplyChanges);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveCollisionsWithNotification_FunctionAddress, intPtr, RemoveCollisionsWithNotification_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveCollisionsWithNotification_ReturnValue_Offset), 0, RemoveCollisionsWithNotification_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveCollisions")]
	public unsafe bool RemoveCollisions(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!RemoveCollisions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveCollisions");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveCollisions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveCollisions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, RemoveCollisions_StaticMesh_Offset), 0, RemoveCollisions_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveCollisions_FunctionAddress, intPtr, RemoveCollisions_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveCollisions_ReturnValue_Offset), 0, RemoveCollisions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReimportAllCustomLODs")]
	public unsafe bool ReimportAllCustomLODs(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!ReimportAllCustomLODs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReimportAllCustomLODs");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReimportAllCustomLODs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReimportAllCustomLODs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, ReimportAllCustomLODs_StaticMesh_Offset), 0, ReimportAllCustomLODs_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReimportAllCustomLODs_FunctionAddress, intPtr, ReimportAllCustomLODs_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReimportAllCustomLODs_ReturnValue_Offset), 0, ReimportAllCustomLODs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:MergeStaticMeshActors")]
	public unsafe bool MergeStaticMeshActors(List<AStaticMeshActor> ActorsToMerge, FMergeStaticMeshActorsOptions MergeOptions, out AStaticMeshActor OutMergedActor)
	{
		CheckDestroyed();
		if (!MergeStaticMeshActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:MergeStaticMeshActors");
			OutMergedActor = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergeStaticMeshActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergeStaticMeshActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AStaticMeshActor>(1, MergeStaticMeshActors_ActorsToMerge_PropertyAddress, CachedMarshalingDelegates<AStaticMeshActor, UObjectMarshaler<AStaticMeshActor>>.FromNative, CachedMarshalingDelegates<AStaticMeshActor, UObjectMarshaler<AStaticMeshActor>>.ToNative).ToNative(IntPtr.Add(intPtr, MergeStaticMeshActors_ActorsToMerge_Offset), ActorsToMerge);
		NativeReflection.InitializeValue_InContainer(MergeStaticMeshActors_MergeOptions_PropertyAddress.Address, intPtr);
		FMergeStaticMeshActorsOptions.ToNative(IntPtr.Add(intPtr, MergeStaticMeshActors_MergeOptions_Offset), 0, MergeStaticMeshActors_MergeOptions_PropertyAddress.Address, MergeOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, MergeStaticMeshActors_FunctionAddress, intPtr, MergeStaticMeshActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MergeStaticMeshActors_ActorsToMerge_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MergeStaticMeshActors_MergeOptions_PropertyAddress.Address, intPtr);
		OutMergedActor = UObjectMarshaler<AStaticMeshActor>.FromNative(IntPtr.Add(intPtr, MergeStaticMeshActors_OutMergedActor_Offset), 0, MergeStaticMeshActors_OutMergedActor_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MergeStaticMeshActors_ReturnValue_Offset), 0, MergeStaticMeshActors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:JoinStaticMeshActors")]
	public unsafe AActor JoinStaticMeshActors(List<AStaticMeshActor> ActorsToJoin, FJoinStaticMeshActorsOptions JoinOptions)
	{
		CheckDestroyed();
		if (!JoinStaticMeshActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:JoinStaticMeshActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(JoinStaticMeshActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JoinStaticMeshActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AStaticMeshActor>(1, JoinStaticMeshActors_ActorsToJoin_PropertyAddress, CachedMarshalingDelegates<AStaticMeshActor, UObjectMarshaler<AStaticMeshActor>>.FromNative, CachedMarshalingDelegates<AStaticMeshActor, UObjectMarshaler<AStaticMeshActor>>.ToNative).ToNative(IntPtr.Add(intPtr, JoinStaticMeshActors_ActorsToJoin_Offset), ActorsToJoin);
		NativeReflection.InitializeValue_InContainer(JoinStaticMeshActors_JoinOptions_PropertyAddress.Address, intPtr);
		FJoinStaticMeshActorsOptions.ToNative(IntPtr.Add(intPtr, JoinStaticMeshActors_JoinOptions_Offset), 0, JoinStaticMeshActors_JoinOptions_PropertyAddress.Address, JoinOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, JoinStaticMeshActors_FunctionAddress, intPtr, JoinStaticMeshActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(JoinStaticMeshActors_ActorsToJoin_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(JoinStaticMeshActors_JoinOptions_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, JoinStaticMeshActors_ReturnValue_Offset), 0, JoinStaticMeshActors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:IsSectionCollisionEnabled")]
	public unsafe bool IsSectionCollisionEnabled(UStaticMesh StaticMesh, int LODIndex, int SectionIndex)
	{
		CheckDestroyed();
		if (!IsSectionCollisionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:IsSectionCollisionEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSectionCollisionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSectionCollisionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, IsSectionCollisionEnabled_StaticMesh_Offset), 0, IsSectionCollisionEnabled_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsSectionCollisionEnabled_LODIndex_Offset), 0, IsSectionCollisionEnabled_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsSectionCollisionEnabled_SectionIndex_Offset), 0, IsSectionCollisionEnabled_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSectionCollisionEnabled_FunctionAddress, intPtr, IsSectionCollisionEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSectionCollisionEnabled_ReturnValue_Offset), 0, IsSectionCollisionEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:InsertUVChannel")]
	public unsafe bool InsertUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex)
	{
		CheckDestroyed();
		if (!InsertUVChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:InsertUVChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InsertUVChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InsertUVChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, InsertUVChannel_StaticMesh_Offset), 0, InsertUVChannel_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InsertUVChannel_LODIndex_Offset), 0, InsertUVChannel_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InsertUVChannel_UVChannelIndex_Offset), 0, InsertUVChannel_UVChannelIndex_PropertyAddress.Address, UVChannelIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, InsertUVChannel_FunctionAddress, intPtr, InsertUVChannel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InsertUVChannel_ReturnValue_Offset), 0, InsertUVChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ImportLOD")]
	public unsafe int ImportLOD(UStaticMesh BaseStaticMesh, int LODIndex, string SourceFilename)
	{
		CheckDestroyed();
		if (!ImportLOD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ImportLOD");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportLOD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportLOD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, ImportLOD_BaseStaticMesh_Offset), 0, ImportLOD_BaseStaticMesh_PropertyAddress.Address, BaseStaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ImportLOD_LODIndex_Offset), 0, ImportLOD_LODIndex_PropertyAddress.Address, LODIndex);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportLOD_SourceFilename_Offset), 0, ImportLOD_SourceFilename_PropertyAddress.Address, SourceFilename);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportLOD_FunctionAddress, intPtr, ImportLOD_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportLOD_SourceFilename_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ImportLOD_ReturnValue_Offset), 0, ImportLOD_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:HasVertexColors")]
	public unsafe bool HasVertexColors(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!HasVertexColors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:HasVertexColors");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasVertexColors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasVertexColors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, HasVertexColors_StaticMesh_Offset), 0, HasVertexColors_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasVertexColors_FunctionAddress, intPtr, HasVertexColors_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasVertexColors_ReturnValue_Offset), 0, HasVertexColors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:HasInstanceVertexColors")]
	public unsafe bool HasInstanceVertexColors(UStaticMeshComponent StaticMeshComponent)
	{
		CheckDestroyed();
		if (!HasInstanceVertexColors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:HasInstanceVertexColors");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasInstanceVertexColors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasInstanceVertexColors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, HasInstanceVertexColors_StaticMeshComponent_Offset), 0, HasInstanceVertexColors_StaticMeshComponent_PropertyAddress.Address, StaticMeshComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasInstanceVertexColors_FunctionAddress, intPtr, HasInstanceVertexColors_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasInstanceVertexColors_ReturnValue_Offset), 0, HasInstanceVertexColors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetSimpleCollisionCount")]
	public unsafe int GetSimpleCollisionCount(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!GetSimpleCollisionCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetSimpleCollisionCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSimpleCollisionCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSimpleCollisionCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetSimpleCollisionCount_StaticMesh_Offset), 0, GetSimpleCollisionCount_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSimpleCollisionCount_FunctionAddress, intPtr, GetSimpleCollisionCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSimpleCollisionCount_ReturnValue_Offset), 0, GetSimpleCollisionCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNumUVChannels")]
	public unsafe int GetNumUVChannels(UStaticMesh StaticMesh, int LODIndex)
	{
		CheckDestroyed();
		if (!GetNumUVChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNumUVChannels");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumUVChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumUVChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetNumUVChannels_StaticMesh_Offset), 0, GetNumUVChannels_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNumUVChannels_LODIndex_Offset), 0, GetNumUVChannels_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumUVChannels_FunctionAddress, intPtr, GetNumUVChannels_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumUVChannels_ReturnValue_Offset), 0, GetNumUVChannels_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNumberVerts")]
	public unsafe int GetNumberVerts(UStaticMesh StaticMesh, int LODIndex)
	{
		CheckDestroyed();
		if (!GetNumberVerts_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNumberVerts");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberVerts_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberVerts_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetNumberVerts_StaticMesh_Offset), 0, GetNumberVerts_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNumberVerts_LODIndex_Offset), 0, GetNumberVerts_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberVerts_FunctionAddress, intPtr, GetNumberVerts_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberVerts_ReturnValue_Offset), 0, GetNumberVerts_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNumberMaterials")]
	public unsafe int GetNumberMaterials(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!GetNumberMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNumberMaterials");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetNumberMaterials_StaticMesh_Offset), 0, GetNumberMaterials_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberMaterials_FunctionAddress, intPtr, GetNumberMaterials_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberMaterials_ReturnValue_Offset), 0, GetNumberMaterials_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNaniteSettings")]
	public unsafe FMeshNaniteSettings GetNaniteSettings(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!GetNaniteSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNaniteSettings");
			return default(FMeshNaniteSettings);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNaniteSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNaniteSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetNaniteSettings_StaticMesh_Offset), 0, GetNaniteSettings_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNaniteSettings_FunctionAddress, intPtr, GetNaniteSettings_ParamsSize);
		return FMeshNaniteSettings.FromNative(IntPtr.Add(intPtr, GetNaniteSettings_ReturnValue_Offset), 0, GetNaniteSettings_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodScreenSizes")]
	public unsafe List<float> GetLodScreenSizes(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!GetLodScreenSizes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodScreenSizes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLodScreenSizes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLodScreenSizes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetLodScreenSizes_StaticMesh_Offset), 0, GetLodScreenSizes_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLodScreenSizes_FunctionAddress, intPtr, GetLodScreenSizes_ParamsSize);
		List<float> result = new TArrayCopyMarshaler<float>(1, GetLodScreenSizes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLodScreenSizes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLodScreenSizes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodReductionSettings")]
	public unsafe void GetLodReductionSettings(UStaticMesh StaticMesh, int LodIndex, out FMeshReductionSettings OutReductionOptions)
	{
		CheckDestroyed();
		if (!GetLodReductionSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodReductionSettings");
			OutReductionOptions = default(FMeshReductionSettings);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLodReductionSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLodReductionSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetLodReductionSettings_StaticMesh_Offset), 0, GetLodReductionSettings_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLodReductionSettings_LodIndex_Offset), 0, GetLodReductionSettings_LodIndex_PropertyAddress.Address, LodIndex);
		NativeReflection.InitializeValue_InContainer(GetLodReductionSettings_OutReductionOptions_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLodReductionSettings_FunctionAddress, intPtr, GetLodReductionSettings_ParamsSize);
		OutReductionOptions = FMeshReductionSettings.FromNative(IntPtr.Add(intPtr, GetLodReductionSettings_OutReductionOptions_Offset), 0, GetLodReductionSettings_OutReductionOptions_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLODMaterialSlot")]
	public unsafe int GetLODMaterialSlot(UStaticMesh StaticMesh, int LODIndex, int SectionIndex)
	{
		CheckDestroyed();
		if (!GetLODMaterialSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLODMaterialSlot");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLODMaterialSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLODMaterialSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetLODMaterialSlot_StaticMesh_Offset), 0, GetLODMaterialSlot_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLODMaterialSlot_LODIndex_Offset), 0, GetLODMaterialSlot_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLODMaterialSlot_SectionIndex_Offset), 0, GetLODMaterialSlot_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLODMaterialSlot_FunctionAddress, intPtr, GetLODMaterialSlot_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLODMaterialSlot_ReturnValue_Offset), 0, GetLODMaterialSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLODGroup")]
	public unsafe FName GetLODGroup(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!GetLODGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLODGroup");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLODGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLODGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetLODGroup_StaticMesh_Offset), 0, GetLODGroup_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLODGroup_FunctionAddress, intPtr, GetLODGroup_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetLODGroup_ReturnValue_Offset), 0, GetLODGroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodCount")]
	public unsafe int GetLodCount(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!GetLodCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLodCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLodCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetLodCount_StaticMesh_Offset), 0, GetLodCount_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLodCount_FunctionAddress, intPtr, GetLodCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLodCount_ReturnValue_Offset), 0, GetLodCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodBuildSettings")]
	public unsafe void GetLodBuildSettings(UStaticMesh StaticMesh, int LodIndex, out FMeshBuildSettings OutBuildOptions)
	{
		CheckDestroyed();
		if (!GetLodBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodBuildSettings");
			OutBuildOptions = default(FMeshBuildSettings);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLodBuildSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLodBuildSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetLodBuildSettings_StaticMesh_Offset), 0, GetLodBuildSettings_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLodBuildSettings_LodIndex_Offset), 0, GetLodBuildSettings_LodIndex_PropertyAddress.Address, LodIndex);
		NativeReflection.InitializeValue_InContainer(GetLodBuildSettings_OutBuildOptions_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLodBuildSettings_FunctionAddress, intPtr, GetLodBuildSettings_ParamsSize);
		OutBuildOptions = FMeshBuildSettings.FromNative(IntPtr.Add(intPtr, GetLodBuildSettings_OutBuildOptions_Offset), 0, GetLodBuildSettings_OutBuildOptions_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetConvexCollisionCount")]
	public unsafe int GetConvexCollisionCount(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!GetConvexCollisionCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetConvexCollisionCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConvexCollisionCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConvexCollisionCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetConvexCollisionCount_StaticMesh_Offset), 0, GetConvexCollisionCount_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConvexCollisionCount_FunctionAddress, intPtr, GetConvexCollisionCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetConvexCollisionCount_ReturnValue_Offset), 0, GetConvexCollisionCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetCollisionComplexity")]
	public unsafe ECollisionTraceFlag GetCollisionComplexity(UStaticMesh StaticMesh)
	{
		CheckDestroyed();
		if (!GetCollisionComplexity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetCollisionComplexity");
			return ECollisionTraceFlag.CTF_UseDefault;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionComplexity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionComplexity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetCollisionComplexity_StaticMesh_Offset), 0, GetCollisionComplexity_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCollisionComplexity_FunctionAddress, intPtr, GetCollisionComplexity_ParamsSize);
		return EnumMarshaler<ECollisionTraceFlag>.FromNative(IntPtr.Add(intPtr, GetCollisionComplexity_ReturnValue_Offset), 0, GetCollisionComplexity_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GeneratePlanarUVChannel")]
	public unsafe bool GeneratePlanarUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, FVector Position, FRotator Orientation, FVector2D Tiling)
	{
		CheckDestroyed();
		if (!GeneratePlanarUVChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GeneratePlanarUVChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GeneratePlanarUVChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GeneratePlanarUVChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GeneratePlanarUVChannel_StaticMesh_Offset), 0, GeneratePlanarUVChannel_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GeneratePlanarUVChannel_LODIndex_Offset), 0, GeneratePlanarUVChannel_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GeneratePlanarUVChannel_UVChannelIndex_Offset), 0, GeneratePlanarUVChannel_UVChannelIndex_PropertyAddress.Address, UVChannelIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GeneratePlanarUVChannel_Position_Offset), 0, GeneratePlanarUVChannel_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, GeneratePlanarUVChannel_Orientation_Offset), 0, GeneratePlanarUVChannel_Orientation_PropertyAddress.Address, Orientation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GeneratePlanarUVChannel_Tiling_Offset), 0, GeneratePlanarUVChannel_Tiling_PropertyAddress.Address, Tiling);
		NativeReflection.InvokeFunctionOptimized(base.Address, GeneratePlanarUVChannel_FunctionAddress, intPtr, GeneratePlanarUVChannel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GeneratePlanarUVChannel_ReturnValue_Offset), 0, GeneratePlanarUVChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GenerateCylindricalUVChannel")]
	public unsafe bool GenerateCylindricalUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, FVector Position, FRotator Orientation, FVector2D Tiling)
	{
		CheckDestroyed();
		if (!GenerateCylindricalUVChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GenerateCylindricalUVChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateCylindricalUVChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateCylindricalUVChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GenerateCylindricalUVChannel_StaticMesh_Offset), 0, GenerateCylindricalUVChannel_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GenerateCylindricalUVChannel_LODIndex_Offset), 0, GenerateCylindricalUVChannel_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GenerateCylindricalUVChannel_UVChannelIndex_Offset), 0, GenerateCylindricalUVChannel_UVChannelIndex_PropertyAddress.Address, UVChannelIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GenerateCylindricalUVChannel_Position_Offset), 0, GenerateCylindricalUVChannel_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, GenerateCylindricalUVChannel_Orientation_Offset), 0, GenerateCylindricalUVChannel_Orientation_PropertyAddress.Address, Orientation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GenerateCylindricalUVChannel_Tiling_Offset), 0, GenerateCylindricalUVChannel_Tiling_PropertyAddress.Address, Tiling);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateCylindricalUVChannel_FunctionAddress, intPtr, GenerateCylindricalUVChannel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GenerateCylindricalUVChannel_ReturnValue_Offset), 0, GenerateCylindricalUVChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GenerateBoxUVChannel")]
	public unsafe bool GenerateBoxUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, FVector Position, FRotator Orientation, FVector Size)
	{
		CheckDestroyed();
		if (!GenerateBoxUVChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GenerateBoxUVChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateBoxUVChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateBoxUVChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GenerateBoxUVChannel_StaticMesh_Offset), 0, GenerateBoxUVChannel_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GenerateBoxUVChannel_LODIndex_Offset), 0, GenerateBoxUVChannel_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GenerateBoxUVChannel_UVChannelIndex_Offset), 0, GenerateBoxUVChannel_UVChannelIndex_PropertyAddress.Address, UVChannelIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GenerateBoxUVChannel_Position_Offset), 0, GenerateBoxUVChannel_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, GenerateBoxUVChannel_Orientation_Offset), 0, GenerateBoxUVChannel_Orientation_PropertyAddress.Address, Orientation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GenerateBoxUVChannel_Size_Offset), 0, GenerateBoxUVChannel_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateBoxUVChannel_FunctionAddress, intPtr, GenerateBoxUVChannel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GenerateBoxUVChannel_ReturnValue_Offset), 0, GenerateBoxUVChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:EnableSectionCollision")]
	public unsafe void EnableSectionCollision(UStaticMesh StaticMesh, bool bCollisionEnabled, int LODIndex, int SectionIndex)
	{
		CheckDestroyed();
		if (!EnableSectionCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:EnableSectionCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableSectionCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableSectionCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, EnableSectionCollision_StaticMesh_Offset), 0, EnableSectionCollision_StaticMesh_PropertyAddress.Address, StaticMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableSectionCollision_bCollisionEnabled_Offset), 0, EnableSectionCollision_bCollisionEnabled_PropertyAddress.Address, bCollisionEnabled);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EnableSectionCollision_LODIndex_Offset), 0, EnableSectionCollision_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EnableSectionCollision_SectionIndex_Offset), 0, EnableSectionCollision_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableSectionCollision_FunctionAddress, intPtr, EnableSectionCollision_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:EnableSectionCastShadow")]
	public unsafe void EnableSectionCastShadow(UStaticMesh StaticMesh, bool bCastShadow, int LODIndex, int SectionIndex)
	{
		CheckDestroyed();
		if (!EnableSectionCastShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:EnableSectionCastShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableSectionCastShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableSectionCastShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, EnableSectionCastShadow_StaticMesh_Offset), 0, EnableSectionCastShadow_StaticMesh_PropertyAddress.Address, StaticMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableSectionCastShadow_bCastShadow_Offset), 0, EnableSectionCastShadow_bCastShadow_PropertyAddress.Address, bCastShadow);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EnableSectionCastShadow_LODIndex_Offset), 0, EnableSectionCastShadow_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EnableSectionCastShadow_SectionIndex_Offset), 0, EnableSectionCastShadow_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableSectionCastShadow_FunctionAddress, intPtr, EnableSectionCastShadow_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:CreateProxyMeshActor")]
	public unsafe bool CreateProxyMeshActor(List<AStaticMeshActor> ActorsToMerge, FCreateProxyMeshActorOptions MergeOptions, out AStaticMeshActor OutMergedActor)
	{
		CheckDestroyed();
		if (!CreateProxyMeshActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:CreateProxyMeshActor");
			OutMergedActor = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateProxyMeshActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateProxyMeshActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AStaticMeshActor>(1, CreateProxyMeshActor_ActorsToMerge_PropertyAddress, CachedMarshalingDelegates<AStaticMeshActor, UObjectMarshaler<AStaticMeshActor>>.FromNative, CachedMarshalingDelegates<AStaticMeshActor, UObjectMarshaler<AStaticMeshActor>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateProxyMeshActor_ActorsToMerge_Offset), ActorsToMerge);
		NativeReflection.InitializeValue_InContainer(CreateProxyMeshActor_MergeOptions_PropertyAddress.Address, intPtr);
		FCreateProxyMeshActorOptions.ToNative(IntPtr.Add(intPtr, CreateProxyMeshActor_MergeOptions_Offset), 0, CreateProxyMeshActor_MergeOptions_PropertyAddress.Address, MergeOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateProxyMeshActor_FunctionAddress, intPtr, CreateProxyMeshActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateProxyMeshActor_ActorsToMerge_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateProxyMeshActor_MergeOptions_PropertyAddress.Address, intPtr);
		OutMergedActor = UObjectMarshaler<AStaticMeshActor>.FromNative(IntPtr.Add(intPtr, CreateProxyMeshActor_OutMergedActor_Offset), 0, CreateProxyMeshActor_OutMergedActor_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CreateProxyMeshActor_ReturnValue_Offset), 0, CreateProxyMeshActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:BulkSetConvexDecompositionCollisionsWithNotification")]
	public unsafe bool BulkSetConvexDecompositionCollisionsWithNotification(List<UStaticMesh> StaticMeshes, int HullCount, int MaxHullVerts, int HullPrecision, bool bApplyChanges)
	{
		CheckDestroyed();
		if (!BulkSetConvexDecompositionCollisionsWithNotification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:BulkSetConvexDecompositionCollisionsWithNotification");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BulkSetConvexDecompositionCollisionsWithNotification_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BulkSetConvexDecompositionCollisionsWithNotification_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UStaticMesh>(1, BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_PropertyAddress, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.FromNative, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.ToNative).ToNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_Offset), StaticMeshes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisionsWithNotification_HullCount_Offset), 0, BulkSetConvexDecompositionCollisionsWithNotification_HullCount_PropertyAddress.Address, HullCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisionsWithNotification_MaxHullVerts_Offset), 0, BulkSetConvexDecompositionCollisionsWithNotification_MaxHullVerts_PropertyAddress.Address, MaxHullVerts);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisionsWithNotification_HullPrecision_Offset), 0, BulkSetConvexDecompositionCollisionsWithNotification_HullPrecision_PropertyAddress.Address, HullPrecision);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisionsWithNotification_bApplyChanges_Offset), 0, BulkSetConvexDecompositionCollisionsWithNotification_bApplyChanges_PropertyAddress.Address, bApplyChanges);
		NativeReflection.InvokeFunctionOptimized(base.Address, BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, intPtr, BulkSetConvexDecompositionCollisionsWithNotification_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisionsWithNotification_ReturnValue_Offset), 0, BulkSetConvexDecompositionCollisionsWithNotification_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:BulkSetConvexDecompositionCollisions")]
	public unsafe bool BulkSetConvexDecompositionCollisions(List<UStaticMesh> StaticMeshes, int HullCount, int MaxHullVerts, int HullPrecision)
	{
		CheckDestroyed();
		if (!BulkSetConvexDecompositionCollisions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:BulkSetConvexDecompositionCollisions");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BulkSetConvexDecompositionCollisions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BulkSetConvexDecompositionCollisions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UStaticMesh>(1, BulkSetConvexDecompositionCollisions_StaticMeshes_PropertyAddress, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.FromNative, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.ToNative).ToNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisions_StaticMeshes_Offset), StaticMeshes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisions_HullCount_Offset), 0, BulkSetConvexDecompositionCollisions_HullCount_PropertyAddress.Address, HullCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisions_MaxHullVerts_Offset), 0, BulkSetConvexDecompositionCollisions_MaxHullVerts_PropertyAddress.Address, MaxHullVerts);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisions_HullPrecision_Offset), 0, BulkSetConvexDecompositionCollisions_HullPrecision_PropertyAddress.Address, HullPrecision);
		NativeReflection.InvokeFunctionOptimized(base.Address, BulkSetConvexDecompositionCollisions_FunctionAddress, intPtr, BulkSetConvexDecompositionCollisions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BulkSetConvexDecompositionCollisions_StaticMeshes_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BulkSetConvexDecompositionCollisions_ReturnValue_Offset), 0, BulkSetConvexDecompositionCollisions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:AddUVChannel")]
	public unsafe bool AddUVChannel(UStaticMesh StaticMesh, int LODIndex)
	{
		CheckDestroyed();
		if (!AddUVChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:AddUVChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddUVChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddUVChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, AddUVChannel_StaticMesh_Offset), 0, AddUVChannel_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddUVChannel_LODIndex_Offset), 0, AddUVChannel_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddUVChannel_FunctionAddress, intPtr, AddUVChannel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddUVChannel_ReturnValue_Offset), 0, AddUVChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:AddSimpleCollisionsWithNotification")]
	public unsafe int AddSimpleCollisionsWithNotification(UStaticMesh StaticMesh, EScriptCollisionShapeType ShapeType, bool bApplyChanges)
	{
		CheckDestroyed();
		if (!AddSimpleCollisionsWithNotification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:AddSimpleCollisionsWithNotification");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSimpleCollisionsWithNotification_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSimpleCollisionsWithNotification_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, AddSimpleCollisionsWithNotification_StaticMesh_Offset), 0, AddSimpleCollisionsWithNotification_StaticMesh_PropertyAddress.Address, StaticMesh);
		EnumMarshaler<EScriptCollisionShapeType>.ToNative(IntPtr.Add(intPtr, AddSimpleCollisionsWithNotification_ShapeType_Offset), 0, AddSimpleCollisionsWithNotification_ShapeType_PropertyAddress.Address, ShapeType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSimpleCollisionsWithNotification_bApplyChanges_Offset), 0, AddSimpleCollisionsWithNotification_bApplyChanges_PropertyAddress.Address, bApplyChanges);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSimpleCollisionsWithNotification_FunctionAddress, intPtr, AddSimpleCollisionsWithNotification_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddSimpleCollisionsWithNotification_ReturnValue_Offset), 0, AddSimpleCollisionsWithNotification_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:AddSimpleCollisions")]
	public unsafe int AddSimpleCollisions(UStaticMesh StaticMesh, EScriptCollisionShapeType ShapeType)
	{
		CheckDestroyed();
		if (!AddSimpleCollisions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:AddSimpleCollisions");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSimpleCollisions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSimpleCollisions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, AddSimpleCollisions_StaticMesh_Offset), 0, AddSimpleCollisions_StaticMesh_PropertyAddress.Address, StaticMesh);
		EnumMarshaler<EScriptCollisionShapeType>.ToNative(IntPtr.Add(intPtr, AddSimpleCollisions_ShapeType_Offset), 0, AddSimpleCollisions_ShapeType_PropertyAddress.Address, ShapeType);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSimpleCollisions_FunctionAddress, intPtr, AddSimpleCollisions_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddSimpleCollisions_ReturnValue_Offset), 0, AddSimpleCollisions_ReturnValue_PropertyAddress.Address);
	}

	static UStaticMeshEditorSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStaticMeshEditorSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStaticMeshEditorSubsystem));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/StaticMeshEditor.StaticMeshEditorSubsystem");
		SetNaniteSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNaniteSettings");
		SetNaniteSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNaniteSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteSettings_StaticMesh_PropertyAddress, SetNaniteSettings_FunctionAddress, "StaticMesh");
		SetNaniteSettings_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteSettings_FunctionAddress, "StaticMesh");
		SetNaniteSettings_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteSettings_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteSettings_NaniteSettings_PropertyAddress, SetNaniteSettings_FunctionAddress, "NaniteSettings");
		SetNaniteSettings_NaniteSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteSettings_FunctionAddress, "NaniteSettings");
		SetNaniteSettings_NaniteSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteSettings_FunctionAddress, "NaniteSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteSettings_bApplyChanges_PropertyAddress, SetNaniteSettings_FunctionAddress, "bApplyChanges");
		SetNaniteSettings_bApplyChanges_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteSettings_FunctionAddress, "bApplyChanges");
		SetNaniteSettings_bApplyChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteSettings_FunctionAddress, "bApplyChanges", Classes.FBoolProperty);
		SetNaniteSettings_IsValid = SetNaniteSettings_FunctionAddress != IntPtr.Zero && SetNaniteSettings_StaticMesh_IsValid && SetNaniteSettings_NaniteSettings_IsValid && SetNaniteSettings_bApplyChanges_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetNaniteSettings", SetNaniteSettings_IsValid);
		SetLodsWithNotification_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLodsWithNotification");
		SetLodsWithNotification_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLodsWithNotification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLodsWithNotification_StaticMesh_PropertyAddress, SetLodsWithNotification_FunctionAddress, "StaticMesh");
		SetLodsWithNotification_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLodsWithNotification_FunctionAddress, "StaticMesh");
		SetLodsWithNotification_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodsWithNotification_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodsWithNotification_ReductionOptions_PropertyAddress, SetLodsWithNotification_FunctionAddress, "ReductionOptions");
		SetLodsWithNotification_ReductionOptions_Offset = NativeReflectionCached.GetPropertyOffset(SetLodsWithNotification_FunctionAddress, "ReductionOptions");
		SetLodsWithNotification_ReductionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodsWithNotification_FunctionAddress, "ReductionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodsWithNotification_bApplyChanges_PropertyAddress, SetLodsWithNotification_FunctionAddress, "bApplyChanges");
		SetLodsWithNotification_bApplyChanges_Offset = NativeReflectionCached.GetPropertyOffset(SetLodsWithNotification_FunctionAddress, "bApplyChanges");
		SetLodsWithNotification_bApplyChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodsWithNotification_FunctionAddress, "bApplyChanges", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodsWithNotification_ReturnValue_PropertyAddress, SetLodsWithNotification_FunctionAddress, "ReturnValue");
		SetLodsWithNotification_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLodsWithNotification_FunctionAddress, "ReturnValue");
		SetLodsWithNotification_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodsWithNotification_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SetLodsWithNotification_IsValid = SetLodsWithNotification_FunctionAddress != IntPtr.Zero && SetLodsWithNotification_StaticMesh_IsValid && SetLodsWithNotification_ReductionOptions_IsValid && SetLodsWithNotification_bApplyChanges_IsValid && SetLodsWithNotification_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodsWithNotification", SetLodsWithNotification_IsValid);
		SetLods_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLods");
		SetLods_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLods_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLods_StaticMesh_PropertyAddress, SetLods_FunctionAddress, "StaticMesh");
		SetLods_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLods_FunctionAddress, "StaticMesh");
		SetLods_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLods_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLods_ReductionOptions_PropertyAddress, SetLods_FunctionAddress, "ReductionOptions");
		SetLods_ReductionOptions_Offset = NativeReflectionCached.GetPropertyOffset(SetLods_FunctionAddress, "ReductionOptions");
		SetLods_ReductionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLods_FunctionAddress, "ReductionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLods_ReturnValue_PropertyAddress, SetLods_FunctionAddress, "ReturnValue");
		SetLods_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLods_FunctionAddress, "ReturnValue");
		SetLods_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLods_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SetLods_IsValid = SetLods_FunctionAddress != IntPtr.Zero && SetLods_StaticMesh_IsValid && SetLods_ReductionOptions_IsValid && SetLods_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLods", SetLods_IsValid);
		SetLodReductionSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLodReductionSettings");
		SetLodReductionSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLodReductionSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLodReductionSettings_StaticMesh_PropertyAddress, SetLodReductionSettings_FunctionAddress, "StaticMesh");
		SetLodReductionSettings_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLodReductionSettings_FunctionAddress, "StaticMesh");
		SetLodReductionSettings_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodReductionSettings_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodReductionSettings_LodIndex_PropertyAddress, SetLodReductionSettings_FunctionAddress, "LodIndex");
		SetLodReductionSettings_LodIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLodReductionSettings_FunctionAddress, "LodIndex");
		SetLodReductionSettings_LodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodReductionSettings_FunctionAddress, "LodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodReductionSettings_ReductionOptions_PropertyAddress, SetLodReductionSettings_FunctionAddress, "ReductionOptions");
		SetLodReductionSettings_ReductionOptions_Offset = NativeReflectionCached.GetPropertyOffset(SetLodReductionSettings_FunctionAddress, "ReductionOptions");
		SetLodReductionSettings_ReductionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodReductionSettings_FunctionAddress, "ReductionOptions", Classes.FStructProperty);
		SetLodReductionSettings_IsValid = SetLodReductionSettings_FunctionAddress != IntPtr.Zero && SetLodReductionSettings_StaticMesh_IsValid && SetLodReductionSettings_LodIndex_IsValid && SetLodReductionSettings_ReductionOptions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodReductionSettings", SetLodReductionSettings_IsValid);
		SetLODMaterialSlot_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLODMaterialSlot");
		SetLODMaterialSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLODMaterialSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLODMaterialSlot_StaticMesh_PropertyAddress, SetLODMaterialSlot_FunctionAddress, "StaticMesh");
		SetLODMaterialSlot_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLODMaterialSlot_FunctionAddress, "StaticMesh");
		SetLODMaterialSlot_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODMaterialSlot_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODMaterialSlot_MaterialSlotIndex_PropertyAddress, SetLODMaterialSlot_FunctionAddress, "MaterialSlotIndex");
		SetLODMaterialSlot_MaterialSlotIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLODMaterialSlot_FunctionAddress, "MaterialSlotIndex");
		SetLODMaterialSlot_MaterialSlotIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODMaterialSlot_FunctionAddress, "MaterialSlotIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODMaterialSlot_LODIndex_PropertyAddress, SetLODMaterialSlot_FunctionAddress, "LODIndex");
		SetLODMaterialSlot_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLODMaterialSlot_FunctionAddress, "LODIndex");
		SetLODMaterialSlot_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODMaterialSlot_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODMaterialSlot_SectionIndex_PropertyAddress, SetLODMaterialSlot_FunctionAddress, "SectionIndex");
		SetLODMaterialSlot_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLODMaterialSlot_FunctionAddress, "SectionIndex");
		SetLODMaterialSlot_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODMaterialSlot_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		SetLODMaterialSlot_IsValid = SetLODMaterialSlot_FunctionAddress != IntPtr.Zero && SetLODMaterialSlot_StaticMesh_IsValid && SetLODMaterialSlot_MaterialSlotIndex_IsValid && SetLODMaterialSlot_LODIndex_IsValid && SetLODMaterialSlot_SectionIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLODMaterialSlot", SetLODMaterialSlot_IsValid);
		SetLODGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLODGroup");
		SetLODGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLODGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLODGroup_StaticMesh_PropertyAddress, SetLODGroup_FunctionAddress, "StaticMesh");
		SetLODGroup_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLODGroup_FunctionAddress, "StaticMesh");
		SetLODGroup_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODGroup_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODGroup_LODGroup_PropertyAddress, SetLODGroup_FunctionAddress, "LODGroup");
		SetLODGroup_LODGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetLODGroup_FunctionAddress, "LODGroup");
		SetLODGroup_LODGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODGroup_FunctionAddress, "LODGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODGroup_bRebuildImmediately_PropertyAddress, SetLODGroup_FunctionAddress, "bRebuildImmediately");
		SetLODGroup_bRebuildImmediately_Offset = NativeReflectionCached.GetPropertyOffset(SetLODGroup_FunctionAddress, "bRebuildImmediately");
		SetLODGroup_bRebuildImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODGroup_FunctionAddress, "bRebuildImmediately", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODGroup_ReturnValue_PropertyAddress, SetLODGroup_FunctionAddress, "ReturnValue");
		SetLODGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLODGroup_FunctionAddress, "ReturnValue");
		SetLODGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODGroup_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLODGroup_IsValid = SetLODGroup_FunctionAddress != IntPtr.Zero && SetLODGroup_StaticMesh_IsValid && SetLODGroup_LODGroup_IsValid && SetLODGroup_bRebuildImmediately_IsValid && SetLODGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLODGroup", SetLODGroup_IsValid);
		SetLodFromStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLodFromStaticMesh");
		SetLodFromStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLodFromStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLodFromStaticMesh_DestinationStaticMesh_PropertyAddress, SetLodFromStaticMesh_FunctionAddress, "DestinationStaticMesh");
		SetLodFromStaticMesh_DestinationStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLodFromStaticMesh_FunctionAddress, "DestinationStaticMesh");
		SetLodFromStaticMesh_DestinationStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodFromStaticMesh_FunctionAddress, "DestinationStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodFromStaticMesh_DestinationLodIndex_PropertyAddress, SetLodFromStaticMesh_FunctionAddress, "DestinationLodIndex");
		SetLodFromStaticMesh_DestinationLodIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLodFromStaticMesh_FunctionAddress, "DestinationLodIndex");
		SetLodFromStaticMesh_DestinationLodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodFromStaticMesh_FunctionAddress, "DestinationLodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodFromStaticMesh_SourceStaticMesh_PropertyAddress, SetLodFromStaticMesh_FunctionAddress, "SourceStaticMesh");
		SetLodFromStaticMesh_SourceStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLodFromStaticMesh_FunctionAddress, "SourceStaticMesh");
		SetLodFromStaticMesh_SourceStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodFromStaticMesh_FunctionAddress, "SourceStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodFromStaticMesh_SourceLodIndex_PropertyAddress, SetLodFromStaticMesh_FunctionAddress, "SourceLodIndex");
		SetLodFromStaticMesh_SourceLodIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLodFromStaticMesh_FunctionAddress, "SourceLodIndex");
		SetLodFromStaticMesh_SourceLodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodFromStaticMesh_FunctionAddress, "SourceLodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodFromStaticMesh_bReuseExistingMaterialSlots_PropertyAddress, SetLodFromStaticMesh_FunctionAddress, "bReuseExistingMaterialSlots");
		SetLodFromStaticMesh_bReuseExistingMaterialSlots_Offset = NativeReflectionCached.GetPropertyOffset(SetLodFromStaticMesh_FunctionAddress, "bReuseExistingMaterialSlots");
		SetLodFromStaticMesh_bReuseExistingMaterialSlots_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodFromStaticMesh_FunctionAddress, "bReuseExistingMaterialSlots", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodFromStaticMesh_ReturnValue_PropertyAddress, SetLodFromStaticMesh_FunctionAddress, "ReturnValue");
		SetLodFromStaticMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLodFromStaticMesh_FunctionAddress, "ReturnValue");
		SetLodFromStaticMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodFromStaticMesh_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SetLodFromStaticMesh_IsValid = SetLodFromStaticMesh_FunctionAddress != IntPtr.Zero && SetLodFromStaticMesh_DestinationStaticMesh_IsValid && SetLodFromStaticMesh_DestinationLodIndex_IsValid && SetLodFromStaticMesh_SourceStaticMesh_IsValid && SetLodFromStaticMesh_SourceLodIndex_IsValid && SetLodFromStaticMesh_bReuseExistingMaterialSlots_IsValid && SetLodFromStaticMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodFromStaticMesh", SetLodFromStaticMesh_IsValid);
		SetLodBuildSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLodBuildSettings");
		SetLodBuildSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLodBuildSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLodBuildSettings_StaticMesh_PropertyAddress, SetLodBuildSettings_FunctionAddress, "StaticMesh");
		SetLodBuildSettings_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLodBuildSettings_FunctionAddress, "StaticMesh");
		SetLodBuildSettings_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodBuildSettings_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodBuildSettings_LodIndex_PropertyAddress, SetLodBuildSettings_FunctionAddress, "LodIndex");
		SetLodBuildSettings_LodIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLodBuildSettings_FunctionAddress, "LodIndex");
		SetLodBuildSettings_LodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodBuildSettings_FunctionAddress, "LodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodBuildSettings_BuildOptions_PropertyAddress, SetLodBuildSettings_FunctionAddress, "BuildOptions");
		SetLodBuildSettings_BuildOptions_Offset = NativeReflectionCached.GetPropertyOffset(SetLodBuildSettings_FunctionAddress, "BuildOptions");
		SetLodBuildSettings_BuildOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodBuildSettings_FunctionAddress, "BuildOptions", Classes.FStructProperty);
		SetLodBuildSettings_IsValid = SetLodBuildSettings_FunctionAddress != IntPtr.Zero && SetLodBuildSettings_StaticMesh_IsValid && SetLodBuildSettings_LodIndex_IsValid && SetLodBuildSettings_BuildOptions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetLodBuildSettings", SetLodBuildSettings_IsValid);
		SetGenerateLightmapUv_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGenerateLightmapUVs");
		SetGenerateLightmapUv_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGenerateLightmapUv_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGenerateLightmapUv_StaticMesh_PropertyAddress, SetGenerateLightmapUv_FunctionAddress, "StaticMesh");
		SetGenerateLightmapUv_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetGenerateLightmapUv_FunctionAddress, "StaticMesh");
		SetGenerateLightmapUv_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGenerateLightmapUv_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGenerateLightmapUv_bGenerateLightmapUVs_PropertyAddress, SetGenerateLightmapUv_FunctionAddress, "bGenerateLightmapUVs");
		SetGenerateLightmapUv_bGenerateLightmapUVs_Offset = NativeReflectionCached.GetPropertyOffset(SetGenerateLightmapUv_FunctionAddress, "bGenerateLightmapUVs");
		SetGenerateLightmapUv_bGenerateLightmapUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGenerateLightmapUv_FunctionAddress, "bGenerateLightmapUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGenerateLightmapUv_ReturnValue_PropertyAddress, SetGenerateLightmapUv_FunctionAddress, "ReturnValue");
		SetGenerateLightmapUv_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetGenerateLightmapUv_FunctionAddress, "ReturnValue");
		SetGenerateLightmapUv_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGenerateLightmapUv_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetGenerateLightmapUv_IsValid = SetGenerateLightmapUv_FunctionAddress != IntPtr.Zero && SetGenerateLightmapUv_StaticMesh_IsValid && SetGenerateLightmapUv_bGenerateLightmapUVs_IsValid && SetGenerateLightmapUv_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetGenerateLightmapUVs", SetGenerateLightmapUv_IsValid);
		SetConvexDecompositionCollisionsWithNotification_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetConvexDecompositionCollisionsWithNotification");
		SetConvexDecompositionCollisionsWithNotification_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConvexDecompositionCollisionsWithNotification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisionsWithNotification_StaticMesh_PropertyAddress, SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "StaticMesh");
		SetConvexDecompositionCollisionsWithNotification_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "StaticMesh");
		SetConvexDecompositionCollisionsWithNotification_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisionsWithNotification_HullCount_PropertyAddress, SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullCount");
		SetConvexDecompositionCollisionsWithNotification_HullCount_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullCount");
		SetConvexDecompositionCollisionsWithNotification_HullCount_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisionsWithNotification_MaxHullVerts_PropertyAddress, SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "MaxHullVerts");
		SetConvexDecompositionCollisionsWithNotification_MaxHullVerts_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "MaxHullVerts");
		SetConvexDecompositionCollisionsWithNotification_MaxHullVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "MaxHullVerts", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisionsWithNotification_HullPrecision_PropertyAddress, SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullPrecision");
		SetConvexDecompositionCollisionsWithNotification_HullPrecision_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullPrecision");
		SetConvexDecompositionCollisionsWithNotification_HullPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullPrecision", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisionsWithNotification_bApplyChanges_PropertyAddress, SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "bApplyChanges");
		SetConvexDecompositionCollisionsWithNotification_bApplyChanges_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "bApplyChanges");
		SetConvexDecompositionCollisionsWithNotification_bApplyChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "bApplyChanges", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisionsWithNotification_ReturnValue_PropertyAddress, SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "ReturnValue");
		SetConvexDecompositionCollisionsWithNotification_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "ReturnValue");
		SetConvexDecompositionCollisionsWithNotification_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisionsWithNotification_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetConvexDecompositionCollisionsWithNotification_IsValid = SetConvexDecompositionCollisionsWithNotification_FunctionAddress != IntPtr.Zero && SetConvexDecompositionCollisionsWithNotification_StaticMesh_IsValid && SetConvexDecompositionCollisionsWithNotification_HullCount_IsValid && SetConvexDecompositionCollisionsWithNotification_MaxHullVerts_IsValid && SetConvexDecompositionCollisionsWithNotification_HullPrecision_IsValid && SetConvexDecompositionCollisionsWithNotification_bApplyChanges_IsValid && SetConvexDecompositionCollisionsWithNotification_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetConvexDecompositionCollisionsWithNotification", SetConvexDecompositionCollisionsWithNotification_IsValid);
		SetConvexDecompositionCollisions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetConvexDecompositionCollisions");
		SetConvexDecompositionCollisions_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConvexDecompositionCollisions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisions_StaticMesh_PropertyAddress, SetConvexDecompositionCollisions_FunctionAddress, "StaticMesh");
		SetConvexDecompositionCollisions_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisions_FunctionAddress, "StaticMesh");
		SetConvexDecompositionCollisions_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisions_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisions_HullCount_PropertyAddress, SetConvexDecompositionCollisions_FunctionAddress, "HullCount");
		SetConvexDecompositionCollisions_HullCount_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisions_FunctionAddress, "HullCount");
		SetConvexDecompositionCollisions_HullCount_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisions_FunctionAddress, "HullCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisions_MaxHullVerts_PropertyAddress, SetConvexDecompositionCollisions_FunctionAddress, "MaxHullVerts");
		SetConvexDecompositionCollisions_MaxHullVerts_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisions_FunctionAddress, "MaxHullVerts");
		SetConvexDecompositionCollisions_MaxHullVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisions_FunctionAddress, "MaxHullVerts", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisions_HullPrecision_PropertyAddress, SetConvexDecompositionCollisions_FunctionAddress, "HullPrecision");
		SetConvexDecompositionCollisions_HullPrecision_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisions_FunctionAddress, "HullPrecision");
		SetConvexDecompositionCollisions_HullPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisions_FunctionAddress, "HullPrecision", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollisions_ReturnValue_PropertyAddress, SetConvexDecompositionCollisions_FunctionAddress, "ReturnValue");
		SetConvexDecompositionCollisions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollisions_FunctionAddress, "ReturnValue");
		SetConvexDecompositionCollisions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollisions_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetConvexDecompositionCollisions_IsValid = SetConvexDecompositionCollisions_FunctionAddress != IntPtr.Zero && SetConvexDecompositionCollisions_StaticMesh_IsValid && SetConvexDecompositionCollisions_HullCount_IsValid && SetConvexDecompositionCollisions_MaxHullVerts_IsValid && SetConvexDecompositionCollisions_HullPrecision_IsValid && SetConvexDecompositionCollisions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetConvexDecompositionCollisions", SetConvexDecompositionCollisions_IsValid);
		SetAllowCPUAccess_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAllowCPUAccess");
		SetAllowCPUAccess_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllowCPUAccess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllowCPUAccess_StaticMesh_PropertyAddress, SetAllowCPUAccess_FunctionAddress, "StaticMesh");
		SetAllowCPUAccess_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowCPUAccess_FunctionAddress, "StaticMesh");
		SetAllowCPUAccess_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowCPUAccess_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllowCPUAccess_bAllowCPUAccess_PropertyAddress, SetAllowCPUAccess_FunctionAddress, "bAllowCPUAccess");
		SetAllowCPUAccess_bAllowCPUAccess_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowCPUAccess_FunctionAddress, "bAllowCPUAccess");
		SetAllowCPUAccess_bAllowCPUAccess_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowCPUAccess_FunctionAddress, "bAllowCPUAccess", Classes.FBoolProperty);
		SetAllowCPUAccess_IsValid = SetAllowCPUAccess_FunctionAddress != IntPtr.Zero && SetAllowCPUAccess_StaticMesh_IsValid && SetAllowCPUAccess_bAllowCPUAccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:SetAllowCPUAccess", SetAllowCPUAccess_IsValid);
		ReplaceMeshComponentsMeshesOnActors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReplaceMeshComponentsMeshesOnActors");
		ReplaceMeshComponentsMeshesOnActors_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceMeshComponentsMeshesOnActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMeshesOnActors_Actors_PropertyAddress, ReplaceMeshComponentsMeshesOnActors_FunctionAddress, "Actors");
		ReplaceMeshComponentsMeshesOnActors_Actors_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMeshesOnActors_FunctionAddress, "Actors");
		ReplaceMeshComponentsMeshesOnActors_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMeshesOnActors_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMeshesOnActors_MeshToBeReplaced_PropertyAddress, ReplaceMeshComponentsMeshesOnActors_FunctionAddress, "MeshToBeReplaced");
		ReplaceMeshComponentsMeshesOnActors_MeshToBeReplaced_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMeshesOnActors_FunctionAddress, "MeshToBeReplaced");
		ReplaceMeshComponentsMeshesOnActors_MeshToBeReplaced_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMeshesOnActors_FunctionAddress, "MeshToBeReplaced", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMeshesOnActors_NewMesh_PropertyAddress, ReplaceMeshComponentsMeshesOnActors_FunctionAddress, "NewMesh");
		ReplaceMeshComponentsMeshesOnActors_NewMesh_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMeshesOnActors_FunctionAddress, "NewMesh");
		ReplaceMeshComponentsMeshesOnActors_NewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMeshesOnActors_FunctionAddress, "NewMesh", Classes.FObjectProperty);
		ReplaceMeshComponentsMeshesOnActors_IsValid = ReplaceMeshComponentsMeshesOnActors_FunctionAddress != IntPtr.Zero && ReplaceMeshComponentsMeshesOnActors_Actors_IsValid && ReplaceMeshComponentsMeshesOnActors_MeshToBeReplaced_IsValid && ReplaceMeshComponentsMeshesOnActors_NewMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMeshesOnActors", ReplaceMeshComponentsMeshesOnActors_IsValid);
		ReplaceMeshComponentsMeshes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReplaceMeshComponentsMeshes");
		ReplaceMeshComponentsMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceMeshComponentsMeshes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMeshes_MeshComponents_PropertyAddress, ReplaceMeshComponentsMeshes_FunctionAddress, "MeshComponents");
		ReplaceMeshComponentsMeshes_MeshComponents_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMeshes_FunctionAddress, "MeshComponents");
		ReplaceMeshComponentsMeshes_MeshComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMeshes_FunctionAddress, "MeshComponents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMeshes_MeshToBeReplaced_PropertyAddress, ReplaceMeshComponentsMeshes_FunctionAddress, "MeshToBeReplaced");
		ReplaceMeshComponentsMeshes_MeshToBeReplaced_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMeshes_FunctionAddress, "MeshToBeReplaced");
		ReplaceMeshComponentsMeshes_MeshToBeReplaced_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMeshes_FunctionAddress, "MeshToBeReplaced", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMeshes_NewMesh_PropertyAddress, ReplaceMeshComponentsMeshes_FunctionAddress, "NewMesh");
		ReplaceMeshComponentsMeshes_NewMesh_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMeshes_FunctionAddress, "NewMesh");
		ReplaceMeshComponentsMeshes_NewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMeshes_FunctionAddress, "NewMesh", Classes.FObjectProperty);
		ReplaceMeshComponentsMeshes_IsValid = ReplaceMeshComponentsMeshes_FunctionAddress != IntPtr.Zero && ReplaceMeshComponentsMeshes_MeshComponents_IsValid && ReplaceMeshComponentsMeshes_MeshToBeReplaced_IsValid && ReplaceMeshComponentsMeshes_NewMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMeshes", ReplaceMeshComponentsMeshes_IsValid);
		ReplaceMeshComponentsMaterialsOnActors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReplaceMeshComponentsMaterialsOnActors");
		ReplaceMeshComponentsMaterialsOnActors_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceMeshComponentsMaterialsOnActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMaterialsOnActors_Actors_PropertyAddress, ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, "Actors");
		ReplaceMeshComponentsMaterialsOnActors_Actors_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, "Actors");
		ReplaceMeshComponentsMaterialsOnActors_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMaterialsOnActors_MaterialToBeReplaced_PropertyAddress, ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, "MaterialToBeReplaced");
		ReplaceMeshComponentsMaterialsOnActors_MaterialToBeReplaced_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, "MaterialToBeReplaced");
		ReplaceMeshComponentsMaterialsOnActors_MaterialToBeReplaced_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, "MaterialToBeReplaced", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMaterialsOnActors_NewMaterial_PropertyAddress, ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, "NewMaterial");
		ReplaceMeshComponentsMaterialsOnActors_NewMaterial_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, "NewMaterial");
		ReplaceMeshComponentsMaterialsOnActors_NewMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMaterialsOnActors_FunctionAddress, "NewMaterial", Classes.FObjectProperty);
		ReplaceMeshComponentsMaterialsOnActors_IsValid = ReplaceMeshComponentsMaterialsOnActors_FunctionAddress != IntPtr.Zero && ReplaceMeshComponentsMaterialsOnActors_Actors_IsValid && ReplaceMeshComponentsMaterialsOnActors_MaterialToBeReplaced_IsValid && ReplaceMeshComponentsMaterialsOnActors_NewMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMaterialsOnActors", ReplaceMeshComponentsMaterialsOnActors_IsValid);
		ReplaceMeshComponentsMaterials_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReplaceMeshComponentsMaterials");
		ReplaceMeshComponentsMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceMeshComponentsMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMaterials_MeshComponents_PropertyAddress, ReplaceMeshComponentsMaterials_FunctionAddress, "MeshComponents");
		ReplaceMeshComponentsMaterials_MeshComponents_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMaterials_FunctionAddress, "MeshComponents");
		ReplaceMeshComponentsMaterials_MeshComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMaterials_FunctionAddress, "MeshComponents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMaterials_MaterialToBeReplaced_PropertyAddress, ReplaceMeshComponentsMaterials_FunctionAddress, "MaterialToBeReplaced");
		ReplaceMeshComponentsMaterials_MaterialToBeReplaced_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMaterials_FunctionAddress, "MaterialToBeReplaced");
		ReplaceMeshComponentsMaterials_MaterialToBeReplaced_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMaterials_FunctionAddress, "MaterialToBeReplaced", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMeshComponentsMaterials_NewMaterial_PropertyAddress, ReplaceMeshComponentsMaterials_FunctionAddress, "NewMaterial");
		ReplaceMeshComponentsMaterials_NewMaterial_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMeshComponentsMaterials_FunctionAddress, "NewMaterial");
		ReplaceMeshComponentsMaterials_NewMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMeshComponentsMaterials_FunctionAddress, "NewMaterial", Classes.FObjectProperty);
		ReplaceMeshComponentsMaterials_IsValid = ReplaceMeshComponentsMaterials_FunctionAddress != IntPtr.Zero && ReplaceMeshComponentsMaterials_MeshComponents_IsValid && ReplaceMeshComponentsMaterials_MaterialToBeReplaced_IsValid && ReplaceMeshComponentsMaterials_NewMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReplaceMeshComponentsMaterials", ReplaceMeshComponentsMaterials_IsValid);
		RemoveUVChannel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveUVChannel");
		RemoveUVChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveUVChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveUVChannel_StaticMesh_PropertyAddress, RemoveUVChannel_FunctionAddress, "StaticMesh");
		RemoveUVChannel_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(RemoveUVChannel_FunctionAddress, "StaticMesh");
		RemoveUVChannel_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveUVChannel_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveUVChannel_LODIndex_PropertyAddress, RemoveUVChannel_FunctionAddress, "LODIndex");
		RemoveUVChannel_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(RemoveUVChannel_FunctionAddress, "LODIndex");
		RemoveUVChannel_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveUVChannel_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveUVChannel_UVChannelIndex_PropertyAddress, RemoveUVChannel_FunctionAddress, "UVChannelIndex");
		RemoveUVChannel_UVChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(RemoveUVChannel_FunctionAddress, "UVChannelIndex");
		RemoveUVChannel_UVChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveUVChannel_FunctionAddress, "UVChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveUVChannel_ReturnValue_PropertyAddress, RemoveUVChannel_FunctionAddress, "ReturnValue");
		RemoveUVChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveUVChannel_FunctionAddress, "ReturnValue");
		RemoveUVChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveUVChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveUVChannel_IsValid = RemoveUVChannel_FunctionAddress != IntPtr.Zero && RemoveUVChannel_StaticMesh_IsValid && RemoveUVChannel_LODIndex_IsValid && RemoveUVChannel_UVChannelIndex_IsValid && RemoveUVChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveUVChannel", RemoveUVChannel_IsValid);
		RemoveLods_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveLods");
		RemoveLods_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveLods_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveLods_StaticMesh_PropertyAddress, RemoveLods_FunctionAddress, "StaticMesh");
		RemoveLods_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLods_FunctionAddress, "StaticMesh");
		RemoveLods_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLods_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveLods_ReturnValue_PropertyAddress, RemoveLods_FunctionAddress, "ReturnValue");
		RemoveLods_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLods_FunctionAddress, "ReturnValue");
		RemoveLods_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLods_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveLods_IsValid = RemoveLods_FunctionAddress != IntPtr.Zero && RemoveLods_StaticMesh_IsValid && RemoveLods_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveLods", RemoveLods_IsValid);
		RemoveCollisionsWithNotification_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveCollisionsWithNotification");
		RemoveCollisionsWithNotification_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveCollisionsWithNotification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveCollisionsWithNotification_StaticMesh_PropertyAddress, RemoveCollisionsWithNotification_FunctionAddress, "StaticMesh");
		RemoveCollisionsWithNotification_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCollisionsWithNotification_FunctionAddress, "StaticMesh");
		RemoveCollisionsWithNotification_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCollisionsWithNotification_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCollisionsWithNotification_bApplyChanges_PropertyAddress, RemoveCollisionsWithNotification_FunctionAddress, "bApplyChanges");
		RemoveCollisionsWithNotification_bApplyChanges_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCollisionsWithNotification_FunctionAddress, "bApplyChanges");
		RemoveCollisionsWithNotification_bApplyChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCollisionsWithNotification_FunctionAddress, "bApplyChanges", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCollisionsWithNotification_ReturnValue_PropertyAddress, RemoveCollisionsWithNotification_FunctionAddress, "ReturnValue");
		RemoveCollisionsWithNotification_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCollisionsWithNotification_FunctionAddress, "ReturnValue");
		RemoveCollisionsWithNotification_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCollisionsWithNotification_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveCollisionsWithNotification_IsValid = RemoveCollisionsWithNotification_FunctionAddress != IntPtr.Zero && RemoveCollisionsWithNotification_StaticMesh_IsValid && RemoveCollisionsWithNotification_bApplyChanges_IsValid && RemoveCollisionsWithNotification_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveCollisionsWithNotification", RemoveCollisionsWithNotification_IsValid);
		RemoveCollisions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveCollisions");
		RemoveCollisions_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveCollisions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveCollisions_StaticMesh_PropertyAddress, RemoveCollisions_FunctionAddress, "StaticMesh");
		RemoveCollisions_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCollisions_FunctionAddress, "StaticMesh");
		RemoveCollisions_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCollisions_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCollisions_ReturnValue_PropertyAddress, RemoveCollisions_FunctionAddress, "ReturnValue");
		RemoveCollisions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCollisions_FunctionAddress, "ReturnValue");
		RemoveCollisions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCollisions_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveCollisions_IsValid = RemoveCollisions_FunctionAddress != IntPtr.Zero && RemoveCollisions_StaticMesh_IsValid && RemoveCollisions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:RemoveCollisions", RemoveCollisions_IsValid);
		ReimportAllCustomLODs_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReimportAllCustomLODs");
		ReimportAllCustomLODs_ParamsSize = NativeReflection.GetFunctionParamsSize(ReimportAllCustomLODs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReimportAllCustomLODs_StaticMesh_PropertyAddress, ReimportAllCustomLODs_FunctionAddress, "StaticMesh");
		ReimportAllCustomLODs_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(ReimportAllCustomLODs_FunctionAddress, "StaticMesh");
		ReimportAllCustomLODs_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ReimportAllCustomLODs_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReimportAllCustomLODs_ReturnValue_PropertyAddress, ReimportAllCustomLODs_FunctionAddress, "ReturnValue");
		ReimportAllCustomLODs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReimportAllCustomLODs_FunctionAddress, "ReturnValue");
		ReimportAllCustomLODs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReimportAllCustomLODs_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReimportAllCustomLODs_IsValid = ReimportAllCustomLODs_FunctionAddress != IntPtr.Zero && ReimportAllCustomLODs_StaticMesh_IsValid && ReimportAllCustomLODs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ReimportAllCustomLODs", ReimportAllCustomLODs_IsValid);
		MergeStaticMeshActors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MergeStaticMeshActors");
		MergeStaticMeshActors_ParamsSize = NativeReflection.GetFunctionParamsSize(MergeStaticMeshActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergeStaticMeshActors_ActorsToMerge_PropertyAddress, MergeStaticMeshActors_FunctionAddress, "ActorsToMerge");
		MergeStaticMeshActors_ActorsToMerge_Offset = NativeReflectionCached.GetPropertyOffset(MergeStaticMeshActors_FunctionAddress, "ActorsToMerge");
		MergeStaticMeshActors_ActorsToMerge_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeStaticMeshActors_FunctionAddress, "ActorsToMerge", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeStaticMeshActors_MergeOptions_PropertyAddress, MergeStaticMeshActors_FunctionAddress, "MergeOptions");
		MergeStaticMeshActors_MergeOptions_Offset = NativeReflectionCached.GetPropertyOffset(MergeStaticMeshActors_FunctionAddress, "MergeOptions");
		MergeStaticMeshActors_MergeOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeStaticMeshActors_FunctionAddress, "MergeOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeStaticMeshActors_OutMergedActor_PropertyAddress, MergeStaticMeshActors_FunctionAddress, "OutMergedActor");
		MergeStaticMeshActors_OutMergedActor_Offset = NativeReflectionCached.GetPropertyOffset(MergeStaticMeshActors_FunctionAddress, "OutMergedActor");
		MergeStaticMeshActors_OutMergedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeStaticMeshActors_FunctionAddress, "OutMergedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeStaticMeshActors_ReturnValue_PropertyAddress, MergeStaticMeshActors_FunctionAddress, "ReturnValue");
		MergeStaticMeshActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MergeStaticMeshActors_FunctionAddress, "ReturnValue");
		MergeStaticMeshActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeStaticMeshActors_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MergeStaticMeshActors_IsValid = MergeStaticMeshActors_FunctionAddress != IntPtr.Zero && MergeStaticMeshActors_ActorsToMerge_IsValid && MergeStaticMeshActors_MergeOptions_IsValid && MergeStaticMeshActors_OutMergedActor_IsValid && MergeStaticMeshActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:MergeStaticMeshActors", MergeStaticMeshActors_IsValid);
		JoinStaticMeshActors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "JoinStaticMeshActors");
		JoinStaticMeshActors_ParamsSize = NativeReflection.GetFunctionParamsSize(JoinStaticMeshActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref JoinStaticMeshActors_ActorsToJoin_PropertyAddress, JoinStaticMeshActors_FunctionAddress, "ActorsToJoin");
		JoinStaticMeshActors_ActorsToJoin_Offset = NativeReflectionCached.GetPropertyOffset(JoinStaticMeshActors_FunctionAddress, "ActorsToJoin");
		JoinStaticMeshActors_ActorsToJoin_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinStaticMeshActors_FunctionAddress, "ActorsToJoin", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref JoinStaticMeshActors_JoinOptions_PropertyAddress, JoinStaticMeshActors_FunctionAddress, "JoinOptions");
		JoinStaticMeshActors_JoinOptions_Offset = NativeReflectionCached.GetPropertyOffset(JoinStaticMeshActors_FunctionAddress, "JoinOptions");
		JoinStaticMeshActors_JoinOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinStaticMeshActors_FunctionAddress, "JoinOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref JoinStaticMeshActors_ReturnValue_PropertyAddress, JoinStaticMeshActors_FunctionAddress, "ReturnValue");
		JoinStaticMeshActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(JoinStaticMeshActors_FunctionAddress, "ReturnValue");
		JoinStaticMeshActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinStaticMeshActors_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		JoinStaticMeshActors_IsValid = JoinStaticMeshActors_FunctionAddress != IntPtr.Zero && JoinStaticMeshActors_ActorsToJoin_IsValid && JoinStaticMeshActors_JoinOptions_IsValid && JoinStaticMeshActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:JoinStaticMeshActors", JoinStaticMeshActors_IsValid);
		IsSectionCollisionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSectionCollisionEnabled");
		IsSectionCollisionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSectionCollisionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSectionCollisionEnabled_StaticMesh_PropertyAddress, IsSectionCollisionEnabled_FunctionAddress, "StaticMesh");
		IsSectionCollisionEnabled_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsSectionCollisionEnabled_FunctionAddress, "StaticMesh");
		IsSectionCollisionEnabled_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSectionCollisionEnabled_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSectionCollisionEnabled_LODIndex_PropertyAddress, IsSectionCollisionEnabled_FunctionAddress, "LODIndex");
		IsSectionCollisionEnabled_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(IsSectionCollisionEnabled_FunctionAddress, "LODIndex");
		IsSectionCollisionEnabled_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSectionCollisionEnabled_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSectionCollisionEnabled_SectionIndex_PropertyAddress, IsSectionCollisionEnabled_FunctionAddress, "SectionIndex");
		IsSectionCollisionEnabled_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(IsSectionCollisionEnabled_FunctionAddress, "SectionIndex");
		IsSectionCollisionEnabled_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSectionCollisionEnabled_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSectionCollisionEnabled_ReturnValue_PropertyAddress, IsSectionCollisionEnabled_FunctionAddress, "ReturnValue");
		IsSectionCollisionEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSectionCollisionEnabled_FunctionAddress, "ReturnValue");
		IsSectionCollisionEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSectionCollisionEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSectionCollisionEnabled_IsValid = IsSectionCollisionEnabled_FunctionAddress != IntPtr.Zero && IsSectionCollisionEnabled_StaticMesh_IsValid && IsSectionCollisionEnabled_LODIndex_IsValid && IsSectionCollisionEnabled_SectionIndex_IsValid && IsSectionCollisionEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:IsSectionCollisionEnabled", IsSectionCollisionEnabled_IsValid);
		InsertUVChannel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InsertUVChannel");
		InsertUVChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(InsertUVChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InsertUVChannel_StaticMesh_PropertyAddress, InsertUVChannel_FunctionAddress, "StaticMesh");
		InsertUVChannel_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(InsertUVChannel_FunctionAddress, "StaticMesh");
		InsertUVChannel_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertUVChannel_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertUVChannel_LODIndex_PropertyAddress, InsertUVChannel_FunctionAddress, "LODIndex");
		InsertUVChannel_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(InsertUVChannel_FunctionAddress, "LODIndex");
		InsertUVChannel_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertUVChannel_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertUVChannel_UVChannelIndex_PropertyAddress, InsertUVChannel_FunctionAddress, "UVChannelIndex");
		InsertUVChannel_UVChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(InsertUVChannel_FunctionAddress, "UVChannelIndex");
		InsertUVChannel_UVChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertUVChannel_FunctionAddress, "UVChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertUVChannel_ReturnValue_PropertyAddress, InsertUVChannel_FunctionAddress, "ReturnValue");
		InsertUVChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InsertUVChannel_FunctionAddress, "ReturnValue");
		InsertUVChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertUVChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InsertUVChannel_IsValid = InsertUVChannel_FunctionAddress != IntPtr.Zero && InsertUVChannel_StaticMesh_IsValid && InsertUVChannel_LODIndex_IsValid && InsertUVChannel_UVChannelIndex_IsValid && InsertUVChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:InsertUVChannel", InsertUVChannel_IsValid);
		ImportLOD_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImportLOD");
		ImportLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportLOD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportLOD_BaseStaticMesh_PropertyAddress, ImportLOD_FunctionAddress, "BaseStaticMesh");
		ImportLOD_BaseStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(ImportLOD_FunctionAddress, "BaseStaticMesh");
		ImportLOD_BaseStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLOD_FunctionAddress, "BaseStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLOD_LODIndex_PropertyAddress, ImportLOD_FunctionAddress, "LODIndex");
		ImportLOD_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(ImportLOD_FunctionAddress, "LODIndex");
		ImportLOD_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLOD_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLOD_SourceFilename_PropertyAddress, ImportLOD_FunctionAddress, "SourceFilename");
		ImportLOD_SourceFilename_Offset = NativeReflectionCached.GetPropertyOffset(ImportLOD_FunctionAddress, "SourceFilename");
		ImportLOD_SourceFilename_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLOD_FunctionAddress, "SourceFilename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLOD_ReturnValue_PropertyAddress, ImportLOD_FunctionAddress, "ReturnValue");
		ImportLOD_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportLOD_FunctionAddress, "ReturnValue");
		ImportLOD_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLOD_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ImportLOD_IsValid = ImportLOD_FunctionAddress != IntPtr.Zero && ImportLOD_BaseStaticMesh_IsValid && ImportLOD_LODIndex_IsValid && ImportLOD_SourceFilename_IsValid && ImportLOD_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:ImportLOD", ImportLOD_IsValid);
		HasVertexColors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasVertexColors");
		HasVertexColors_ParamsSize = NativeReflection.GetFunctionParamsSize(HasVertexColors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasVertexColors_StaticMesh_PropertyAddress, HasVertexColors_FunctionAddress, "StaticMesh");
		HasVertexColors_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(HasVertexColors_FunctionAddress, "StaticMesh");
		HasVertexColors_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(HasVertexColors_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasVertexColors_ReturnValue_PropertyAddress, HasVertexColors_FunctionAddress, "ReturnValue");
		HasVertexColors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasVertexColors_FunctionAddress, "ReturnValue");
		HasVertexColors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasVertexColors_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasVertexColors_IsValid = HasVertexColors_FunctionAddress != IntPtr.Zero && HasVertexColors_StaticMesh_IsValid && HasVertexColors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:HasVertexColors", HasVertexColors_IsValid);
		HasInstanceVertexColors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasInstanceVertexColors");
		HasInstanceVertexColors_ParamsSize = NativeReflection.GetFunctionParamsSize(HasInstanceVertexColors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasInstanceVertexColors_StaticMeshComponent_PropertyAddress, HasInstanceVertexColors_FunctionAddress, "StaticMeshComponent");
		HasInstanceVertexColors_StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(HasInstanceVertexColors_FunctionAddress, "StaticMeshComponent");
		HasInstanceVertexColors_StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(HasInstanceVertexColors_FunctionAddress, "StaticMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasInstanceVertexColors_ReturnValue_PropertyAddress, HasInstanceVertexColors_FunctionAddress, "ReturnValue");
		HasInstanceVertexColors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasInstanceVertexColors_FunctionAddress, "ReturnValue");
		HasInstanceVertexColors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasInstanceVertexColors_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasInstanceVertexColors_IsValid = HasInstanceVertexColors_FunctionAddress != IntPtr.Zero && HasInstanceVertexColors_StaticMeshComponent_IsValid && HasInstanceVertexColors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:HasInstanceVertexColors", HasInstanceVertexColors_IsValid);
		GetSimpleCollisionCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSimpleCollisionCount");
		GetSimpleCollisionCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSimpleCollisionCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSimpleCollisionCount_StaticMesh_PropertyAddress, GetSimpleCollisionCount_FunctionAddress, "StaticMesh");
		GetSimpleCollisionCount_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSimpleCollisionCount_FunctionAddress, "StaticMesh");
		GetSimpleCollisionCount_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSimpleCollisionCount_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSimpleCollisionCount_ReturnValue_PropertyAddress, GetSimpleCollisionCount_FunctionAddress, "ReturnValue");
		GetSimpleCollisionCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSimpleCollisionCount_FunctionAddress, "ReturnValue");
		GetSimpleCollisionCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSimpleCollisionCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSimpleCollisionCount_IsValid = GetSimpleCollisionCount_FunctionAddress != IntPtr.Zero && GetSimpleCollisionCount_StaticMesh_IsValid && GetSimpleCollisionCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetSimpleCollisionCount", GetSimpleCollisionCount_IsValid);
		GetNumUVChannels_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumUVChannels");
		GetNumUVChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumUVChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumUVChannels_StaticMesh_PropertyAddress, GetNumUVChannels_FunctionAddress, "StaticMesh");
		GetNumUVChannels_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumUVChannels_FunctionAddress, "StaticMesh");
		GetNumUVChannels_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumUVChannels_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumUVChannels_LODIndex_PropertyAddress, GetNumUVChannels_FunctionAddress, "LODIndex");
		GetNumUVChannels_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetNumUVChannels_FunctionAddress, "LODIndex");
		GetNumUVChannels_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumUVChannels_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumUVChannels_ReturnValue_PropertyAddress, GetNumUVChannels_FunctionAddress, "ReturnValue");
		GetNumUVChannels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumUVChannels_FunctionAddress, "ReturnValue");
		GetNumUVChannels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumUVChannels_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumUVChannels_IsValid = GetNumUVChannels_FunctionAddress != IntPtr.Zero && GetNumUVChannels_StaticMesh_IsValid && GetNumUVChannels_LODIndex_IsValid && GetNumUVChannels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNumUVChannels", GetNumUVChannels_IsValid);
		GetNumberVerts_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumberVerts");
		GetNumberVerts_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberVerts_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberVerts_StaticMesh_PropertyAddress, GetNumberVerts_FunctionAddress, "StaticMesh");
		GetNumberVerts_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberVerts_FunctionAddress, "StaticMesh");
		GetNumberVerts_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberVerts_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumberVerts_LODIndex_PropertyAddress, GetNumberVerts_FunctionAddress, "LODIndex");
		GetNumberVerts_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberVerts_FunctionAddress, "LODIndex");
		GetNumberVerts_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberVerts_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumberVerts_ReturnValue_PropertyAddress, GetNumberVerts_FunctionAddress, "ReturnValue");
		GetNumberVerts_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberVerts_FunctionAddress, "ReturnValue");
		GetNumberVerts_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberVerts_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberVerts_IsValid = GetNumberVerts_FunctionAddress != IntPtr.Zero && GetNumberVerts_StaticMesh_IsValid && GetNumberVerts_LODIndex_IsValid && GetNumberVerts_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNumberVerts", GetNumberVerts_IsValid);
		GetNumberMaterials_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumberMaterials");
		GetNumberMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberMaterials_StaticMesh_PropertyAddress, GetNumberMaterials_FunctionAddress, "StaticMesh");
		GetNumberMaterials_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberMaterials_FunctionAddress, "StaticMesh");
		GetNumberMaterials_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberMaterials_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumberMaterials_ReturnValue_PropertyAddress, GetNumberMaterials_FunctionAddress, "ReturnValue");
		GetNumberMaterials_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberMaterials_FunctionAddress, "ReturnValue");
		GetNumberMaterials_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberMaterials_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberMaterials_IsValid = GetNumberMaterials_FunctionAddress != IntPtr.Zero && GetNumberMaterials_StaticMesh_IsValid && GetNumberMaterials_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNumberMaterials", GetNumberMaterials_IsValid);
		GetNaniteSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNaniteSettings");
		GetNaniteSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNaniteSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNaniteSettings_StaticMesh_PropertyAddress, GetNaniteSettings_FunctionAddress, "StaticMesh");
		GetNaniteSettings_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNaniteSettings_FunctionAddress, "StaticMesh");
		GetNaniteSettings_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNaniteSettings_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNaniteSettings_ReturnValue_PropertyAddress, GetNaniteSettings_FunctionAddress, "ReturnValue");
		GetNaniteSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNaniteSettings_FunctionAddress, "ReturnValue");
		GetNaniteSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNaniteSettings_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNaniteSettings_IsValid = GetNaniteSettings_FunctionAddress != IntPtr.Zero && GetNaniteSettings_StaticMesh_IsValid && GetNaniteSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetNaniteSettings", GetNaniteSettings_IsValid);
		GetLodScreenSizes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLodScreenSizes");
		GetLodScreenSizes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLodScreenSizes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLodScreenSizes_StaticMesh_PropertyAddress, GetLodScreenSizes_FunctionAddress, "StaticMesh");
		GetLodScreenSizes_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetLodScreenSizes_FunctionAddress, "StaticMesh");
		GetLodScreenSizes_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodScreenSizes_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLodScreenSizes_ReturnValue_PropertyAddress, GetLodScreenSizes_FunctionAddress, "ReturnValue");
		GetLodScreenSizes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLodScreenSizes_FunctionAddress, "ReturnValue");
		GetLodScreenSizes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodScreenSizes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLodScreenSizes_IsValid = GetLodScreenSizes_FunctionAddress != IntPtr.Zero && GetLodScreenSizes_StaticMesh_IsValid && GetLodScreenSizes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodScreenSizes", GetLodScreenSizes_IsValid);
		GetLodReductionSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLodReductionSettings");
		GetLodReductionSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLodReductionSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLodReductionSettings_StaticMesh_PropertyAddress, GetLodReductionSettings_FunctionAddress, "StaticMesh");
		GetLodReductionSettings_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetLodReductionSettings_FunctionAddress, "StaticMesh");
		GetLodReductionSettings_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodReductionSettings_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLodReductionSettings_LodIndex_PropertyAddress, GetLodReductionSettings_FunctionAddress, "LodIndex");
		GetLodReductionSettings_LodIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLodReductionSettings_FunctionAddress, "LodIndex");
		GetLodReductionSettings_LodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodReductionSettings_FunctionAddress, "LodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLodReductionSettings_OutReductionOptions_PropertyAddress, GetLodReductionSettings_FunctionAddress, "OutReductionOptions");
		GetLodReductionSettings_OutReductionOptions_Offset = NativeReflectionCached.GetPropertyOffset(GetLodReductionSettings_FunctionAddress, "OutReductionOptions");
		GetLodReductionSettings_OutReductionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodReductionSettings_FunctionAddress, "OutReductionOptions", Classes.FStructProperty);
		GetLodReductionSettings_IsValid = GetLodReductionSettings_FunctionAddress != IntPtr.Zero && GetLodReductionSettings_StaticMesh_IsValid && GetLodReductionSettings_LodIndex_IsValid && GetLodReductionSettings_OutReductionOptions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodReductionSettings", GetLodReductionSettings_IsValid);
		GetLODMaterialSlot_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLODMaterialSlot");
		GetLODMaterialSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLODMaterialSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLODMaterialSlot_StaticMesh_PropertyAddress, GetLODMaterialSlot_FunctionAddress, "StaticMesh");
		GetLODMaterialSlot_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetLODMaterialSlot_FunctionAddress, "StaticMesh");
		GetLODMaterialSlot_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODMaterialSlot_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLODMaterialSlot_LODIndex_PropertyAddress, GetLODMaterialSlot_FunctionAddress, "LODIndex");
		GetLODMaterialSlot_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLODMaterialSlot_FunctionAddress, "LODIndex");
		GetLODMaterialSlot_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODMaterialSlot_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLODMaterialSlot_SectionIndex_PropertyAddress, GetLODMaterialSlot_FunctionAddress, "SectionIndex");
		GetLODMaterialSlot_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLODMaterialSlot_FunctionAddress, "SectionIndex");
		GetLODMaterialSlot_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODMaterialSlot_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLODMaterialSlot_ReturnValue_PropertyAddress, GetLODMaterialSlot_FunctionAddress, "ReturnValue");
		GetLODMaterialSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLODMaterialSlot_FunctionAddress, "ReturnValue");
		GetLODMaterialSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODMaterialSlot_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLODMaterialSlot_IsValid = GetLODMaterialSlot_FunctionAddress != IntPtr.Zero && GetLODMaterialSlot_StaticMesh_IsValid && GetLODMaterialSlot_LODIndex_IsValid && GetLODMaterialSlot_SectionIndex_IsValid && GetLODMaterialSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLODMaterialSlot", GetLODMaterialSlot_IsValid);
		GetLODGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLODGroup");
		GetLODGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLODGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLODGroup_StaticMesh_PropertyAddress, GetLODGroup_FunctionAddress, "StaticMesh");
		GetLODGroup_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetLODGroup_FunctionAddress, "StaticMesh");
		GetLODGroup_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODGroup_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLODGroup_ReturnValue_PropertyAddress, GetLODGroup_FunctionAddress, "ReturnValue");
		GetLODGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLODGroup_FunctionAddress, "ReturnValue");
		GetLODGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODGroup_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetLODGroup_IsValid = GetLODGroup_FunctionAddress != IntPtr.Zero && GetLODGroup_StaticMesh_IsValid && GetLODGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLODGroup", GetLODGroup_IsValid);
		GetLodCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLodCount");
		GetLodCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLodCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLodCount_StaticMesh_PropertyAddress, GetLodCount_FunctionAddress, "StaticMesh");
		GetLodCount_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetLodCount_FunctionAddress, "StaticMesh");
		GetLodCount_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodCount_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLodCount_ReturnValue_PropertyAddress, GetLodCount_FunctionAddress, "ReturnValue");
		GetLodCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLodCount_FunctionAddress, "ReturnValue");
		GetLodCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLodCount_IsValid = GetLodCount_FunctionAddress != IntPtr.Zero && GetLodCount_StaticMesh_IsValid && GetLodCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodCount", GetLodCount_IsValid);
		GetLodBuildSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLodBuildSettings");
		GetLodBuildSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLodBuildSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLodBuildSettings_StaticMesh_PropertyAddress, GetLodBuildSettings_FunctionAddress, "StaticMesh");
		GetLodBuildSettings_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetLodBuildSettings_FunctionAddress, "StaticMesh");
		GetLodBuildSettings_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodBuildSettings_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLodBuildSettings_LodIndex_PropertyAddress, GetLodBuildSettings_FunctionAddress, "LodIndex");
		GetLodBuildSettings_LodIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLodBuildSettings_FunctionAddress, "LodIndex");
		GetLodBuildSettings_LodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodBuildSettings_FunctionAddress, "LodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLodBuildSettings_OutBuildOptions_PropertyAddress, GetLodBuildSettings_FunctionAddress, "OutBuildOptions");
		GetLodBuildSettings_OutBuildOptions_Offset = NativeReflectionCached.GetPropertyOffset(GetLodBuildSettings_FunctionAddress, "OutBuildOptions");
		GetLodBuildSettings_OutBuildOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodBuildSettings_FunctionAddress, "OutBuildOptions", Classes.FStructProperty);
		GetLodBuildSettings_IsValid = GetLodBuildSettings_FunctionAddress != IntPtr.Zero && GetLodBuildSettings_StaticMesh_IsValid && GetLodBuildSettings_LodIndex_IsValid && GetLodBuildSettings_OutBuildOptions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetLodBuildSettings", GetLodBuildSettings_IsValid);
		GetConvexCollisionCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetConvexCollisionCount");
		GetConvexCollisionCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConvexCollisionCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConvexCollisionCount_StaticMesh_PropertyAddress, GetConvexCollisionCount_FunctionAddress, "StaticMesh");
		GetConvexCollisionCount_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetConvexCollisionCount_FunctionAddress, "StaticMesh");
		GetConvexCollisionCount_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConvexCollisionCount_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConvexCollisionCount_ReturnValue_PropertyAddress, GetConvexCollisionCount_FunctionAddress, "ReturnValue");
		GetConvexCollisionCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConvexCollisionCount_FunctionAddress, "ReturnValue");
		GetConvexCollisionCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConvexCollisionCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetConvexCollisionCount_IsValid = GetConvexCollisionCount_FunctionAddress != IntPtr.Zero && GetConvexCollisionCount_StaticMesh_IsValid && GetConvexCollisionCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetConvexCollisionCount", GetConvexCollisionCount_IsValid);
		GetCollisionComplexity_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCollisionComplexity");
		GetCollisionComplexity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionComplexity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionComplexity_StaticMesh_PropertyAddress, GetCollisionComplexity_FunctionAddress, "StaticMesh");
		GetCollisionComplexity_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionComplexity_FunctionAddress, "StaticMesh");
		GetCollisionComplexity_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionComplexity_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionComplexity_ReturnValue_PropertyAddress, GetCollisionComplexity_FunctionAddress, "ReturnValue");
		GetCollisionComplexity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionComplexity_FunctionAddress, "ReturnValue");
		GetCollisionComplexity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionComplexity_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetCollisionComplexity_IsValid = GetCollisionComplexity_FunctionAddress != IntPtr.Zero && GetCollisionComplexity_StaticMesh_IsValid && GetCollisionComplexity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GetCollisionComplexity", GetCollisionComplexity_IsValid);
		GeneratePlanarUVChannel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GeneratePlanarUVChannel");
		GeneratePlanarUVChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GeneratePlanarUVChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GeneratePlanarUVChannel_StaticMesh_PropertyAddress, GeneratePlanarUVChannel_FunctionAddress, "StaticMesh");
		GeneratePlanarUVChannel_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePlanarUVChannel_FunctionAddress, "StaticMesh");
		GeneratePlanarUVChannel_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePlanarUVChannel_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GeneratePlanarUVChannel_LODIndex_PropertyAddress, GeneratePlanarUVChannel_FunctionAddress, "LODIndex");
		GeneratePlanarUVChannel_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePlanarUVChannel_FunctionAddress, "LODIndex");
		GeneratePlanarUVChannel_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePlanarUVChannel_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GeneratePlanarUVChannel_UVChannelIndex_PropertyAddress, GeneratePlanarUVChannel_FunctionAddress, "UVChannelIndex");
		GeneratePlanarUVChannel_UVChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePlanarUVChannel_FunctionAddress, "UVChannelIndex");
		GeneratePlanarUVChannel_UVChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePlanarUVChannel_FunctionAddress, "UVChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GeneratePlanarUVChannel_Position_PropertyAddress, GeneratePlanarUVChannel_FunctionAddress, "Position");
		GeneratePlanarUVChannel_Position_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePlanarUVChannel_FunctionAddress, "Position");
		GeneratePlanarUVChannel_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePlanarUVChannel_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GeneratePlanarUVChannel_Orientation_PropertyAddress, GeneratePlanarUVChannel_FunctionAddress, "Orientation");
		GeneratePlanarUVChannel_Orientation_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePlanarUVChannel_FunctionAddress, "Orientation");
		GeneratePlanarUVChannel_Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePlanarUVChannel_FunctionAddress, "Orientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GeneratePlanarUVChannel_Tiling_PropertyAddress, GeneratePlanarUVChannel_FunctionAddress, "Tiling");
		GeneratePlanarUVChannel_Tiling_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePlanarUVChannel_FunctionAddress, "Tiling");
		GeneratePlanarUVChannel_Tiling_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePlanarUVChannel_FunctionAddress, "Tiling", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GeneratePlanarUVChannel_ReturnValue_PropertyAddress, GeneratePlanarUVChannel_FunctionAddress, "ReturnValue");
		GeneratePlanarUVChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePlanarUVChannel_FunctionAddress, "ReturnValue");
		GeneratePlanarUVChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePlanarUVChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GeneratePlanarUVChannel_IsValid = GeneratePlanarUVChannel_FunctionAddress != IntPtr.Zero && GeneratePlanarUVChannel_StaticMesh_IsValid && GeneratePlanarUVChannel_LODIndex_IsValid && GeneratePlanarUVChannel_UVChannelIndex_IsValid && GeneratePlanarUVChannel_Position_IsValid && GeneratePlanarUVChannel_Orientation_IsValid && GeneratePlanarUVChannel_Tiling_IsValid && GeneratePlanarUVChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GeneratePlanarUVChannel", GeneratePlanarUVChannel_IsValid);
		GenerateCylindricalUVChannel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateCylindricalUVChannel");
		GenerateCylindricalUVChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateCylindricalUVChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateCylindricalUVChannel_StaticMesh_PropertyAddress, GenerateCylindricalUVChannel_FunctionAddress, "StaticMesh");
		GenerateCylindricalUVChannel_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GenerateCylindricalUVChannel_FunctionAddress, "StaticMesh");
		GenerateCylindricalUVChannel_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateCylindricalUVChannel_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateCylindricalUVChannel_LODIndex_PropertyAddress, GenerateCylindricalUVChannel_FunctionAddress, "LODIndex");
		GenerateCylindricalUVChannel_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GenerateCylindricalUVChannel_FunctionAddress, "LODIndex");
		GenerateCylindricalUVChannel_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateCylindricalUVChannel_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateCylindricalUVChannel_UVChannelIndex_PropertyAddress, GenerateCylindricalUVChannel_FunctionAddress, "UVChannelIndex");
		GenerateCylindricalUVChannel_UVChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(GenerateCylindricalUVChannel_FunctionAddress, "UVChannelIndex");
		GenerateCylindricalUVChannel_UVChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateCylindricalUVChannel_FunctionAddress, "UVChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateCylindricalUVChannel_Position_PropertyAddress, GenerateCylindricalUVChannel_FunctionAddress, "Position");
		GenerateCylindricalUVChannel_Position_Offset = NativeReflectionCached.GetPropertyOffset(GenerateCylindricalUVChannel_FunctionAddress, "Position");
		GenerateCylindricalUVChannel_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateCylindricalUVChannel_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateCylindricalUVChannel_Orientation_PropertyAddress, GenerateCylindricalUVChannel_FunctionAddress, "Orientation");
		GenerateCylindricalUVChannel_Orientation_Offset = NativeReflectionCached.GetPropertyOffset(GenerateCylindricalUVChannel_FunctionAddress, "Orientation");
		GenerateCylindricalUVChannel_Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateCylindricalUVChannel_FunctionAddress, "Orientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateCylindricalUVChannel_Tiling_PropertyAddress, GenerateCylindricalUVChannel_FunctionAddress, "Tiling");
		GenerateCylindricalUVChannel_Tiling_Offset = NativeReflectionCached.GetPropertyOffset(GenerateCylindricalUVChannel_FunctionAddress, "Tiling");
		GenerateCylindricalUVChannel_Tiling_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateCylindricalUVChannel_FunctionAddress, "Tiling", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateCylindricalUVChannel_ReturnValue_PropertyAddress, GenerateCylindricalUVChannel_FunctionAddress, "ReturnValue");
		GenerateCylindricalUVChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateCylindricalUVChannel_FunctionAddress, "ReturnValue");
		GenerateCylindricalUVChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateCylindricalUVChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateCylindricalUVChannel_IsValid = GenerateCylindricalUVChannel_FunctionAddress != IntPtr.Zero && GenerateCylindricalUVChannel_StaticMesh_IsValid && GenerateCylindricalUVChannel_LODIndex_IsValid && GenerateCylindricalUVChannel_UVChannelIndex_IsValid && GenerateCylindricalUVChannel_Position_IsValid && GenerateCylindricalUVChannel_Orientation_IsValid && GenerateCylindricalUVChannel_Tiling_IsValid && GenerateCylindricalUVChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GenerateCylindricalUVChannel", GenerateCylindricalUVChannel_IsValid);
		GenerateBoxUVChannel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateBoxUVChannel");
		GenerateBoxUVChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateBoxUVChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxUVChannel_StaticMesh_PropertyAddress, GenerateBoxUVChannel_FunctionAddress, "StaticMesh");
		GenerateBoxUVChannel_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxUVChannel_FunctionAddress, "StaticMesh");
		GenerateBoxUVChannel_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxUVChannel_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxUVChannel_LODIndex_PropertyAddress, GenerateBoxUVChannel_FunctionAddress, "LODIndex");
		GenerateBoxUVChannel_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxUVChannel_FunctionAddress, "LODIndex");
		GenerateBoxUVChannel_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxUVChannel_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxUVChannel_UVChannelIndex_PropertyAddress, GenerateBoxUVChannel_FunctionAddress, "UVChannelIndex");
		GenerateBoxUVChannel_UVChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxUVChannel_FunctionAddress, "UVChannelIndex");
		GenerateBoxUVChannel_UVChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxUVChannel_FunctionAddress, "UVChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxUVChannel_Position_PropertyAddress, GenerateBoxUVChannel_FunctionAddress, "Position");
		GenerateBoxUVChannel_Position_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxUVChannel_FunctionAddress, "Position");
		GenerateBoxUVChannel_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxUVChannel_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxUVChannel_Orientation_PropertyAddress, GenerateBoxUVChannel_FunctionAddress, "Orientation");
		GenerateBoxUVChannel_Orientation_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxUVChannel_FunctionAddress, "Orientation");
		GenerateBoxUVChannel_Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxUVChannel_FunctionAddress, "Orientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxUVChannel_Size_PropertyAddress, GenerateBoxUVChannel_FunctionAddress, "Size");
		GenerateBoxUVChannel_Size_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxUVChannel_FunctionAddress, "Size");
		GenerateBoxUVChannel_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxUVChannel_FunctionAddress, "Size", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxUVChannel_ReturnValue_PropertyAddress, GenerateBoxUVChannel_FunctionAddress, "ReturnValue");
		GenerateBoxUVChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxUVChannel_FunctionAddress, "ReturnValue");
		GenerateBoxUVChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxUVChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateBoxUVChannel_IsValid = GenerateBoxUVChannel_FunctionAddress != IntPtr.Zero && GenerateBoxUVChannel_StaticMesh_IsValid && GenerateBoxUVChannel_LODIndex_IsValid && GenerateBoxUVChannel_UVChannelIndex_IsValid && GenerateBoxUVChannel_Position_IsValid && GenerateBoxUVChannel_Orientation_IsValid && GenerateBoxUVChannel_Size_IsValid && GenerateBoxUVChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:GenerateBoxUVChannel", GenerateBoxUVChannel_IsValid);
		EnableSectionCollision_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnableSectionCollision");
		EnableSectionCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableSectionCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableSectionCollision_StaticMesh_PropertyAddress, EnableSectionCollision_FunctionAddress, "StaticMesh");
		EnableSectionCollision_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(EnableSectionCollision_FunctionAddress, "StaticMesh");
		EnableSectionCollision_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableSectionCollision_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSectionCollision_bCollisionEnabled_PropertyAddress, EnableSectionCollision_FunctionAddress, "bCollisionEnabled");
		EnableSectionCollision_bCollisionEnabled_Offset = NativeReflectionCached.GetPropertyOffset(EnableSectionCollision_FunctionAddress, "bCollisionEnabled");
		EnableSectionCollision_bCollisionEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableSectionCollision_FunctionAddress, "bCollisionEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSectionCollision_LODIndex_PropertyAddress, EnableSectionCollision_FunctionAddress, "LODIndex");
		EnableSectionCollision_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(EnableSectionCollision_FunctionAddress, "LODIndex");
		EnableSectionCollision_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableSectionCollision_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSectionCollision_SectionIndex_PropertyAddress, EnableSectionCollision_FunctionAddress, "SectionIndex");
		EnableSectionCollision_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(EnableSectionCollision_FunctionAddress, "SectionIndex");
		EnableSectionCollision_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableSectionCollision_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		EnableSectionCollision_IsValid = EnableSectionCollision_FunctionAddress != IntPtr.Zero && EnableSectionCollision_StaticMesh_IsValid && EnableSectionCollision_bCollisionEnabled_IsValid && EnableSectionCollision_LODIndex_IsValid && EnableSectionCollision_SectionIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:EnableSectionCollision", EnableSectionCollision_IsValid);
		EnableSectionCastShadow_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnableSectionCastShadow");
		EnableSectionCastShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableSectionCastShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableSectionCastShadow_StaticMesh_PropertyAddress, EnableSectionCastShadow_FunctionAddress, "StaticMesh");
		EnableSectionCastShadow_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(EnableSectionCastShadow_FunctionAddress, "StaticMesh");
		EnableSectionCastShadow_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableSectionCastShadow_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSectionCastShadow_bCastShadow_PropertyAddress, EnableSectionCastShadow_FunctionAddress, "bCastShadow");
		EnableSectionCastShadow_bCastShadow_Offset = NativeReflectionCached.GetPropertyOffset(EnableSectionCastShadow_FunctionAddress, "bCastShadow");
		EnableSectionCastShadow_bCastShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableSectionCastShadow_FunctionAddress, "bCastShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSectionCastShadow_LODIndex_PropertyAddress, EnableSectionCastShadow_FunctionAddress, "LODIndex");
		EnableSectionCastShadow_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(EnableSectionCastShadow_FunctionAddress, "LODIndex");
		EnableSectionCastShadow_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableSectionCastShadow_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSectionCastShadow_SectionIndex_PropertyAddress, EnableSectionCastShadow_FunctionAddress, "SectionIndex");
		EnableSectionCastShadow_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(EnableSectionCastShadow_FunctionAddress, "SectionIndex");
		EnableSectionCastShadow_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableSectionCastShadow_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		EnableSectionCastShadow_IsValid = EnableSectionCastShadow_FunctionAddress != IntPtr.Zero && EnableSectionCastShadow_StaticMesh_IsValid && EnableSectionCastShadow_bCastShadow_IsValid && EnableSectionCastShadow_LODIndex_IsValid && EnableSectionCastShadow_SectionIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:EnableSectionCastShadow", EnableSectionCastShadow_IsValid);
		CreateProxyMeshActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateProxyMeshActor");
		CreateProxyMeshActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateProxyMeshActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateProxyMeshActor_ActorsToMerge_PropertyAddress, CreateProxyMeshActor_FunctionAddress, "ActorsToMerge");
		CreateProxyMeshActor_ActorsToMerge_Offset = NativeReflectionCached.GetPropertyOffset(CreateProxyMeshActor_FunctionAddress, "ActorsToMerge");
		CreateProxyMeshActor_ActorsToMerge_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateProxyMeshActor_FunctionAddress, "ActorsToMerge", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateProxyMeshActor_MergeOptions_PropertyAddress, CreateProxyMeshActor_FunctionAddress, "MergeOptions");
		CreateProxyMeshActor_MergeOptions_Offset = NativeReflectionCached.GetPropertyOffset(CreateProxyMeshActor_FunctionAddress, "MergeOptions");
		CreateProxyMeshActor_MergeOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateProxyMeshActor_FunctionAddress, "MergeOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateProxyMeshActor_OutMergedActor_PropertyAddress, CreateProxyMeshActor_FunctionAddress, "OutMergedActor");
		CreateProxyMeshActor_OutMergedActor_Offset = NativeReflectionCached.GetPropertyOffset(CreateProxyMeshActor_FunctionAddress, "OutMergedActor");
		CreateProxyMeshActor_OutMergedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateProxyMeshActor_FunctionAddress, "OutMergedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateProxyMeshActor_ReturnValue_PropertyAddress, CreateProxyMeshActor_FunctionAddress, "ReturnValue");
		CreateProxyMeshActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateProxyMeshActor_FunctionAddress, "ReturnValue");
		CreateProxyMeshActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateProxyMeshActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CreateProxyMeshActor_IsValid = CreateProxyMeshActor_FunctionAddress != IntPtr.Zero && CreateProxyMeshActor_ActorsToMerge_IsValid && CreateProxyMeshActor_MergeOptions_IsValid && CreateProxyMeshActor_OutMergedActor_IsValid && CreateProxyMeshActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:CreateProxyMeshActor", CreateProxyMeshActor_IsValid);
		BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BulkSetConvexDecompositionCollisionsWithNotification");
		BulkSetConvexDecompositionCollisionsWithNotification_ParamsSize = NativeReflection.GetFunctionParamsSize(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_PropertyAddress, BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "StaticMeshes");
		BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "StaticMeshes");
		BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "StaticMeshes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisionsWithNotification_HullCount_PropertyAddress, BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullCount");
		BulkSetConvexDecompositionCollisionsWithNotification_HullCount_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullCount");
		BulkSetConvexDecompositionCollisionsWithNotification_HullCount_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisionsWithNotification_MaxHullVerts_PropertyAddress, BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "MaxHullVerts");
		BulkSetConvexDecompositionCollisionsWithNotification_MaxHullVerts_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "MaxHullVerts");
		BulkSetConvexDecompositionCollisionsWithNotification_MaxHullVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "MaxHullVerts", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisionsWithNotification_HullPrecision_PropertyAddress, BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullPrecision");
		BulkSetConvexDecompositionCollisionsWithNotification_HullPrecision_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullPrecision");
		BulkSetConvexDecompositionCollisionsWithNotification_HullPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "HullPrecision", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisionsWithNotification_bApplyChanges_PropertyAddress, BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "bApplyChanges");
		BulkSetConvexDecompositionCollisionsWithNotification_bApplyChanges_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "bApplyChanges");
		BulkSetConvexDecompositionCollisionsWithNotification_bApplyChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "bApplyChanges", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisionsWithNotification_ReturnValue_PropertyAddress, BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "ReturnValue");
		BulkSetConvexDecompositionCollisionsWithNotification_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "ReturnValue");
		BulkSetConvexDecompositionCollisionsWithNotification_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BulkSetConvexDecompositionCollisionsWithNotification_IsValid = BulkSetConvexDecompositionCollisionsWithNotification_FunctionAddress != IntPtr.Zero && BulkSetConvexDecompositionCollisionsWithNotification_StaticMeshes_IsValid && BulkSetConvexDecompositionCollisionsWithNotification_HullCount_IsValid && BulkSetConvexDecompositionCollisionsWithNotification_MaxHullVerts_IsValid && BulkSetConvexDecompositionCollisionsWithNotification_HullPrecision_IsValid && BulkSetConvexDecompositionCollisionsWithNotification_bApplyChanges_IsValid && BulkSetConvexDecompositionCollisionsWithNotification_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:BulkSetConvexDecompositionCollisionsWithNotification", BulkSetConvexDecompositionCollisionsWithNotification_IsValid);
		BulkSetConvexDecompositionCollisions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BulkSetConvexDecompositionCollisions");
		BulkSetConvexDecompositionCollisions_ParamsSize = NativeReflection.GetFunctionParamsSize(BulkSetConvexDecompositionCollisions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisions_StaticMeshes_PropertyAddress, BulkSetConvexDecompositionCollisions_FunctionAddress, "StaticMeshes");
		BulkSetConvexDecompositionCollisions_StaticMeshes_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisions_FunctionAddress, "StaticMeshes");
		BulkSetConvexDecompositionCollisions_StaticMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisions_FunctionAddress, "StaticMeshes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisions_HullCount_PropertyAddress, BulkSetConvexDecompositionCollisions_FunctionAddress, "HullCount");
		BulkSetConvexDecompositionCollisions_HullCount_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisions_FunctionAddress, "HullCount");
		BulkSetConvexDecompositionCollisions_HullCount_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisions_FunctionAddress, "HullCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisions_MaxHullVerts_PropertyAddress, BulkSetConvexDecompositionCollisions_FunctionAddress, "MaxHullVerts");
		BulkSetConvexDecompositionCollisions_MaxHullVerts_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisions_FunctionAddress, "MaxHullVerts");
		BulkSetConvexDecompositionCollisions_MaxHullVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisions_FunctionAddress, "MaxHullVerts", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisions_HullPrecision_PropertyAddress, BulkSetConvexDecompositionCollisions_FunctionAddress, "HullPrecision");
		BulkSetConvexDecompositionCollisions_HullPrecision_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisions_FunctionAddress, "HullPrecision");
		BulkSetConvexDecompositionCollisions_HullPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisions_FunctionAddress, "HullPrecision", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BulkSetConvexDecompositionCollisions_ReturnValue_PropertyAddress, BulkSetConvexDecompositionCollisions_FunctionAddress, "ReturnValue");
		BulkSetConvexDecompositionCollisions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BulkSetConvexDecompositionCollisions_FunctionAddress, "ReturnValue");
		BulkSetConvexDecompositionCollisions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BulkSetConvexDecompositionCollisions_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BulkSetConvexDecompositionCollisions_IsValid = BulkSetConvexDecompositionCollisions_FunctionAddress != IntPtr.Zero && BulkSetConvexDecompositionCollisions_StaticMeshes_IsValid && BulkSetConvexDecompositionCollisions_HullCount_IsValid && BulkSetConvexDecompositionCollisions_MaxHullVerts_IsValid && BulkSetConvexDecompositionCollisions_HullPrecision_IsValid && BulkSetConvexDecompositionCollisions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:BulkSetConvexDecompositionCollisions", BulkSetConvexDecompositionCollisions_IsValid);
		AddUVChannel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddUVChannel");
		AddUVChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(AddUVChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddUVChannel_StaticMesh_PropertyAddress, AddUVChannel_FunctionAddress, "StaticMesh");
		AddUVChannel_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(AddUVChannel_FunctionAddress, "StaticMesh");
		AddUVChannel_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUVChannel_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUVChannel_LODIndex_PropertyAddress, AddUVChannel_FunctionAddress, "LODIndex");
		AddUVChannel_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(AddUVChannel_FunctionAddress, "LODIndex");
		AddUVChannel_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUVChannel_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUVChannel_ReturnValue_PropertyAddress, AddUVChannel_FunctionAddress, "ReturnValue");
		AddUVChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddUVChannel_FunctionAddress, "ReturnValue");
		AddUVChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUVChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddUVChannel_IsValid = AddUVChannel_FunctionAddress != IntPtr.Zero && AddUVChannel_StaticMesh_IsValid && AddUVChannel_LODIndex_IsValid && AddUVChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:AddUVChannel", AddUVChannel_IsValid);
		AddSimpleCollisionsWithNotification_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddSimpleCollisionsWithNotification");
		AddSimpleCollisionsWithNotification_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSimpleCollisionsWithNotification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSimpleCollisionsWithNotification_StaticMesh_PropertyAddress, AddSimpleCollisionsWithNotification_FunctionAddress, "StaticMesh");
		AddSimpleCollisionsWithNotification_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(AddSimpleCollisionsWithNotification_FunctionAddress, "StaticMesh");
		AddSimpleCollisionsWithNotification_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSimpleCollisionsWithNotification_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSimpleCollisionsWithNotification_ShapeType_PropertyAddress, AddSimpleCollisionsWithNotification_FunctionAddress, "ShapeType");
		AddSimpleCollisionsWithNotification_ShapeType_Offset = NativeReflectionCached.GetPropertyOffset(AddSimpleCollisionsWithNotification_FunctionAddress, "ShapeType");
		AddSimpleCollisionsWithNotification_ShapeType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSimpleCollisionsWithNotification_FunctionAddress, "ShapeType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSimpleCollisionsWithNotification_bApplyChanges_PropertyAddress, AddSimpleCollisionsWithNotification_FunctionAddress, "bApplyChanges");
		AddSimpleCollisionsWithNotification_bApplyChanges_Offset = NativeReflectionCached.GetPropertyOffset(AddSimpleCollisionsWithNotification_FunctionAddress, "bApplyChanges");
		AddSimpleCollisionsWithNotification_bApplyChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSimpleCollisionsWithNotification_FunctionAddress, "bApplyChanges", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSimpleCollisionsWithNotification_ReturnValue_PropertyAddress, AddSimpleCollisionsWithNotification_FunctionAddress, "ReturnValue");
		AddSimpleCollisionsWithNotification_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSimpleCollisionsWithNotification_FunctionAddress, "ReturnValue");
		AddSimpleCollisionsWithNotification_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSimpleCollisionsWithNotification_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AddSimpleCollisionsWithNotification_IsValid = AddSimpleCollisionsWithNotification_FunctionAddress != IntPtr.Zero && AddSimpleCollisionsWithNotification_StaticMesh_IsValid && AddSimpleCollisionsWithNotification_ShapeType_IsValid && AddSimpleCollisionsWithNotification_bApplyChanges_IsValid && AddSimpleCollisionsWithNotification_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:AddSimpleCollisionsWithNotification", AddSimpleCollisionsWithNotification_IsValid);
		AddSimpleCollisions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddSimpleCollisions");
		AddSimpleCollisions_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSimpleCollisions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSimpleCollisions_StaticMesh_PropertyAddress, AddSimpleCollisions_FunctionAddress, "StaticMesh");
		AddSimpleCollisions_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(AddSimpleCollisions_FunctionAddress, "StaticMesh");
		AddSimpleCollisions_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSimpleCollisions_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSimpleCollisions_ShapeType_PropertyAddress, AddSimpleCollisions_FunctionAddress, "ShapeType");
		AddSimpleCollisions_ShapeType_Offset = NativeReflectionCached.GetPropertyOffset(AddSimpleCollisions_FunctionAddress, "ShapeType");
		AddSimpleCollisions_ShapeType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSimpleCollisions_FunctionAddress, "ShapeType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSimpleCollisions_ReturnValue_PropertyAddress, AddSimpleCollisions_FunctionAddress, "ReturnValue");
		AddSimpleCollisions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSimpleCollisions_FunctionAddress, "ReturnValue");
		AddSimpleCollisions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSimpleCollisions_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AddSimpleCollisions_IsValid = AddSimpleCollisions_FunctionAddress != IntPtr.Zero && AddSimpleCollisions_StaticMesh_IsValid && AddSimpleCollisions_ShapeType_IsValid && AddSimpleCollisions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshEditor.StaticMeshEditorSubsystem:AddSimpleCollisions", AddSimpleCollisions_IsValid);
	}
}
