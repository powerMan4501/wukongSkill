using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorSkeletalMeshLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ToggleMaterialCurve_IsValid;

	private static IntPtr ToggleMaterialCurve_FunctionAddress;

	private static int ToggleMaterialCurve_ParamsSize;

	private static bool ToggleMaterialCurve_inSkeleton_IsValid;

	private static FFieldAddress ToggleMaterialCurve_inSkeleton_PropertyAddress;

	private static int ToggleMaterialCurve_inSkeleton_Offset;

	private static bool ToggleMaterialCurve_CurveNames_IsValid;

	private static FFieldAddress ToggleMaterialCurve_CurveNames_PropertyAddress;

	private static int ToggleMaterialCurve_CurveNames_Offset;

	private static bool SetSkeletalMeshCPUAccess_IsValid;

	private static IntPtr SetSkeletalMeshCPUAccess_FunctionAddress;

	private static int SetSkeletalMeshCPUAccess_ParamsSize;

	private static bool SetSkeletalMeshCPUAccess_InSM_IsValid;

	private static FFieldAddress SetSkeletalMeshCPUAccess_InSM_PropertyAddress;

	private static int SetSkeletalMeshCPUAccess_InSM_Offset;

	private static bool SetSkeletalMeshCPUAccess_LodIndex_IsValid;

	private static FFieldAddress SetSkeletalMeshCPUAccess_LodIndex_PropertyAddress;

	private static int SetSkeletalMeshCPUAccess_LodIndex_Offset;

	private static bool SetSkeletalMeshCPUAccess_Access_IsValid;

	private static FFieldAddress SetSkeletalMeshCPUAccess_Access_PropertyAddress;

	private static int SetSkeletalMeshCPUAccess_Access_Offset;

	private static bool SetSkeletalMeshCPUAccess_ReturnValue_IsValid;

	private static FFieldAddress SetSkeletalMeshCPUAccess_ReturnValue_PropertyAddress;

	private static int SetSkeletalMeshCPUAccess_ReturnValue_Offset;

	private static bool SetRagdoll_IsValid;

	private static IntPtr SetRagdoll_FunctionAddress;

	private static int SetRagdoll_ParamsSize;

	private static bool SetRagdoll_PA_IsValid;

	private static FFieldAddress SetRagdoll_PA_PropertyAddress;

	private static int SetRagdoll_PA_Offset;

	private static bool SetRagdoll_bRecreateBodies_IsValid;

	private static FFieldAddress SetRagdoll_bRecreateBodies_PropertyAddress;

	private static int SetRagdoll_bRecreateBodies_Offset;

	private static bool SetRagdoll_bCheckRootBody_IsValid;

	private static FFieldAddress SetRagdoll_bCheckRootBody_PropertyAddress;

	private static int SetRagdoll_bCheckRootBody_Offset;

	private static bool SetRagdoll_bSetWeapon_IsValid;

	private static FFieldAddress SetRagdoll_bSetWeapon_PropertyAddress;

	private static int SetRagdoll_bSetWeapon_Offset;

	private static bool SetRagdoll_bSetSimBodies_IsValid;

	private static FFieldAddress SetRagdoll_bSetSimBodies_PropertyAddress;

	private static int SetRagdoll_bSetSimBodies_Offset;

	private static bool SetRagdoll_bSetDefaultLimit_IsValid;

	private static FFieldAddress SetRagdoll_bSetDefaultLimit_PropertyAddress;

	private static int SetRagdoll_bSetDefaultLimit_Offset;

	private static bool SetRagdoll_bResetConstraintsPosition_IsValid;

	private static FFieldAddress SetRagdoll_bResetConstraintsPosition_PropertyAddress;

	private static int SetRagdoll_bResetConstraintsPosition_Offset;

	private static bool SetRagdoll_bSetKineToSim_IsValid;

	private static FFieldAddress SetRagdoll_bSetKineToSim_PropertyAddress;

	private static int SetRagdoll_bSetKineToSim_Offset;

	private static bool SetRagdoll_bResetBodyCollision_IsValid;

	private static FFieldAddress SetRagdoll_bResetBodyCollision_PropertyAddress;

	private static int SetRagdoll_bResetBodyCollision_Offset;

	private static bool SetLODScreenSize_IsValid;

	private static IntPtr SetLODScreenSize_FunctionAddress;

	private static int SetLODScreenSize_ParamsSize;

	private static bool SetLODScreenSize_InSM_IsValid;

	private static FFieldAddress SetLODScreenSize_InSM_PropertyAddress;

	private static int SetLODScreenSize_InSM_Offset;

	private static bool SetLODScreenSize_LodIndex_IsValid;

	private static FFieldAddress SetLODScreenSize_LodIndex_PropertyAddress;

	private static int SetLODScreenSize_LodIndex_Offset;

	private static bool SetLODScreenSize_NewScreenSize_IsValid;

	private static FFieldAddress SetLODScreenSize_NewScreenSize_PropertyAddress;

	private static int SetLODScreenSize_NewScreenSize_Offset;

	private static bool SetLODScreenSize_ReturnValue_IsValid;

	private static FFieldAddress SetLODScreenSize_ReturnValue_PropertyAddress;

	private static int SetLODScreenSize_ReturnValue_Offset;

	private static bool SetInertialTensorScale_IsValid;

	private static IntPtr SetInertialTensorScale_FunctionAddress;

	private static int SetInertialTensorScale_ParamsSize;

	private static bool SetInertialTensorScale_PA_IsValid;

	private static FFieldAddress SetInertialTensorScale_PA_PropertyAddress;

	private static int SetInertialTensorScale_PA_Offset;

	private static bool SetInertialTensorScale_TensorScale_IsValid;

	private static FFieldAddress SetInertialTensorScale_TensorScale_PropertyAddress;

	private static int SetInertialTensorScale_TensorScale_Offset;

	private static bool SetInertialTensorScale_DampingScale_IsValid;

	private static FFieldAddress SetInertialTensorScale_DampingScale_PropertyAddress;

	private static int SetInertialTensorScale_DampingScale_Offset;

	private static bool SetBeAttackProfile_IsValid;

	private static IntPtr SetBeAttackProfile_FunctionAddress;

	private static int SetBeAttackProfile_ParamsSize;

	private static bool SetBeAttackProfile_PA_IsValid;

	private static FFieldAddress SetBeAttackProfile_PA_PropertyAddress;

	private static int SetBeAttackProfile_PA_Offset;

	private static bool SetBeAttackProfile_bCheckRootBody_IsValid;

	private static FFieldAddress SetBeAttackProfile_bCheckRootBody_PropertyAddress;

	private static int SetBeAttackProfile_bCheckRootBody_Offset;

	private static bool SetBeAttackProfile_bLockLimb_IsValid;

	private static FFieldAddress SetBeAttackProfile_bLockLimb_PropertyAddress;

	private static int SetBeAttackProfile_bLockLimb_Offset;

	private static bool SetBeAttackProfile_DefaultStiffness_IsValid;

	private static FFieldAddress SetBeAttackProfile_DefaultStiffness_PropertyAddress;

	private static int SetBeAttackProfile_DefaultStiffness_Offset;

	private static bool SetBeAttackProfile_DefaultDamping_IsValid;

	private static FFieldAddress SetBeAttackProfile_DefaultDamping_PropertyAddress;

	private static int SetBeAttackProfile_DefaultDamping_Offset;

	private static bool ResetBeAttackLockLimb_IsValid;

	private static IntPtr ResetBeAttackLockLimb_FunctionAddress;

	private static int ResetBeAttackLockLimb_ParamsSize;

	private static bool ResetBeAttackLockLimb_PA_IsValid;

	private static FFieldAddress ResetBeAttackLockLimb_PA_PropertyAddress;

	private static int ResetBeAttackLockLimb_PA_Offset;

	private static bool RemoveVirtualBone_IsValid;

	private static IntPtr RemoveVirtualBone_FunctionAddress;

	private static int RemoveVirtualBone_ParamsSize;

	private static bool RemoveVirtualBone_Skeleton_IsValid;

	private static FFieldAddress RemoveVirtualBone_Skeleton_PropertyAddress;

	private static int RemoveVirtualBone_Skeleton_Offset;

	private static bool RemoveVirtualBone_VirtualBoneName_IsValid;

	private static FFieldAddress RemoveVirtualBone_VirtualBoneName_PropertyAddress;

	private static int RemoveVirtualBone_VirtualBoneName_Offset;

	private static bool GetSkeletalMeshVertices_IsValid;

	private static IntPtr GetSkeletalMeshVertices_FunctionAddress;

	private static int GetSkeletalMeshVertices_ParamsSize;

	private static bool GetSkeletalMeshVertices_skeletalmesh_IsValid;

	private static FFieldAddress GetSkeletalMeshVertices_skeletalmesh_PropertyAddress;

	private static int GetSkeletalMeshVertices_skeletalmesh_Offset;

	private static bool GetSkeletalMeshVertices_LOD_IsValid;

	private static FFieldAddress GetSkeletalMeshVertices_LOD_PropertyAddress;

	private static int GetSkeletalMeshVertices_LOD_Offset;

	private static bool GetSkeletalMeshVertices_ReturnValue_IsValid;

	private static FFieldAddress GetSkeletalMeshVertices_ReturnValue_PropertyAddress;

	private static int GetSkeletalMeshVertices_ReturnValue_Offset;

	private static bool GetSkeletalMeshTriangles_IsValid;

	private static IntPtr GetSkeletalMeshTriangles_FunctionAddress;

	private static int GetSkeletalMeshTriangles_ParamsSize;

	private static bool GetSkeletalMeshTriangles_skeletalmesh_IsValid;

	private static FFieldAddress GetSkeletalMeshTriangles_skeletalmesh_PropertyAddress;

	private static int GetSkeletalMeshTriangles_skeletalmesh_Offset;

	private static bool GetSkeletalMeshTriangles_LOD_IsValid;

	private static FFieldAddress GetSkeletalMeshTriangles_LOD_PropertyAddress;

	private static int GetSkeletalMeshTriangles_LOD_Offset;

	private static bool GetSkeletalMeshTriangles_ReturnValue_IsValid;

	private static FFieldAddress GetSkeletalMeshTriangles_ReturnValue_PropertyAddress;

	private static int GetSkeletalMeshTriangles_ReturnValue_Offset;

	private static bool GetSkeletalMeshClothsTriangles_IsValid;

	private static IntPtr GetSkeletalMeshClothsTriangles_FunctionAddress;

	private static int GetSkeletalMeshClothsTriangles_ParamsSize;

	private static bool GetSkeletalMeshClothsTriangles_skeletalmesh_IsValid;

	private static FFieldAddress GetSkeletalMeshClothsTriangles_skeletalmesh_PropertyAddress;

	private static int GetSkeletalMeshClothsTriangles_skeletalmesh_Offset;

	private static bool GetSkeletalMeshClothsTriangles_ReturnValue_IsValid;

	private static FFieldAddress GetSkeletalMeshClothsTriangles_ReturnValue_PropertyAddress;

	private static int GetSkeletalMeshClothsTriangles_ReturnValue_Offset;

	private static bool GetSkeletalMeshClothsPhysicsAsset_IsValid;

	private static IntPtr GetSkeletalMeshClothsPhysicsAsset_FunctionAddress;

	private static int GetSkeletalMeshClothsPhysicsAsset_ParamsSize;

	private static bool GetSkeletalMeshClothsPhysicsAsset_skeletalmesh_IsValid;

	private static FFieldAddress GetSkeletalMeshClothsPhysicsAsset_skeletalmesh_PropertyAddress;

	private static int GetSkeletalMeshClothsPhysicsAsset_skeletalmesh_Offset;

	private static bool GetSkeletalMeshClothsPhysicsAsset_ReturnValue_IsValid;

	private static FFieldAddress GetSkeletalMeshClothsPhysicsAsset_ReturnValue_PropertyAddress;

	private static int GetSkeletalMeshClothsPhysicsAsset_ReturnValue_Offset;

	private static bool GetSkeletalMeshClothSectionIndex_IsValid;

	private static IntPtr GetSkeletalMeshClothSectionIndex_FunctionAddress;

	private static int GetSkeletalMeshClothSectionIndex_ParamsSize;

	private static bool GetSkeletalMeshClothSectionIndex_InSM_IsValid;

	private static FFieldAddress GetSkeletalMeshClothSectionIndex_InSM_PropertyAddress;

	private static int GetSkeletalMeshClothSectionIndex_InSM_Offset;

	private static bool GetSkeletalMeshClothSectionIndex_LODIndex_IsValid;

	private static FFieldAddress GetSkeletalMeshClothSectionIndex_LODIndex_PropertyAddress;

	private static int GetSkeletalMeshClothSectionIndex_LODIndex_Offset;

	private static bool GetSkeletalMeshClothSectionIndex_ReturnValue_IsValid;

	private static FFieldAddress GetSkeletalMeshClothSectionIndex_ReturnValue_PropertyAddress;

	private static int GetSkeletalMeshClothSectionIndex_ReturnValue_Offset;

	private static bool GetSkeletalMeshBoneTree_IsValid;

	private static IntPtr GetSkeletalMeshBoneTree_FunctionAddress;

	private static int GetSkeletalMeshBoneTree_ParamsSize;

	private static bool GetSkeletalMeshBoneTree_skeletalmesh_IsValid;

	private static FFieldAddress GetSkeletalMeshBoneTree_skeletalmesh_PropertyAddress;

	private static int GetSkeletalMeshBoneTree_skeletalmesh_Offset;

	private static bool GetSkeletalMeshBoneTree_ReturnValue_IsValid;

	private static FFieldAddress GetSkeletalMeshBoneTree_ReturnValue_PropertyAddress;

	private static int GetSkeletalMeshBoneTree_ReturnValue_Offset;

	private static bool GetSkeletalMeshBoneTransforms_IsValid;

	private static IntPtr GetSkeletalMeshBoneTransforms_FunctionAddress;

	private static int GetSkeletalMeshBoneTransforms_ParamsSize;

	private static bool GetSkeletalMeshBoneTransforms_skeletalmesh_IsValid;

	private static FFieldAddress GetSkeletalMeshBoneTransforms_skeletalmesh_PropertyAddress;

	private static int GetSkeletalMeshBoneTransforms_skeletalmesh_Offset;

	private static bool GetSkeletalMeshBoneTransforms_RootIndex_IsValid;

	private static FFieldAddress GetSkeletalMeshBoneTransforms_RootIndex_PropertyAddress;

	private static int GetSkeletalMeshBoneTransforms_RootIndex_Offset;

	private static bool GetSkeletalMeshBoneTransforms_WorldSpace_IsValid;

	private static FFieldAddress GetSkeletalMeshBoneTransforms_WorldSpace_PropertyAddress;

	private static int GetSkeletalMeshBoneTransforms_WorldSpace_Offset;

	private static bool GetSkeletalMeshBoneTransforms_ReturnValue_IsValid;

	private static FFieldAddress GetSkeletalMeshBoneTransforms_ReturnValue_PropertyAddress;

	private static int GetSkeletalMeshBoneTransforms_ReturnValue_Offset;

	private static bool GetSkeletalMeshBoneToVertexMap_IsValid;

	private static IntPtr GetSkeletalMeshBoneToVertexMap_FunctionAddress;

	private static int GetSkeletalMeshBoneToVertexMap_ParamsSize;

	private static bool GetSkeletalMeshBoneToVertexMap_InSM_IsValid;

	private static FFieldAddress GetSkeletalMeshBoneToVertexMap_InSM_PropertyAddress;

	private static int GetSkeletalMeshBoneToVertexMap_InSM_Offset;

	private static bool GetSkeletalMeshBoneToVertexMap_BoneIndex_IsValid;

	private static FFieldAddress GetSkeletalMeshBoneToVertexMap_BoneIndex_PropertyAddress;

	private static int GetSkeletalMeshBoneToVertexMap_BoneIndex_Offset;

	private static bool GetSkeletalMeshBoneToVertexMap_ReturnValue_IsValid;

	private static FFieldAddress GetSkeletalMeshBoneToVertexMap_ReturnValue_PropertyAddress;

	private static int GetSkeletalMeshBoneToVertexMap_ReturnValue_Offset;

	private static bool GetPhysicsAssetPrimitivesNum_IsValid;

	private static IntPtr GetPhysicsAssetPrimitivesNum_FunctionAddress;

	private static int GetPhysicsAssetPrimitivesNum_ParamsSize;

	private static bool GetPhysicsAssetPrimitivesNum_PA_IsValid;

	private static FFieldAddress GetPhysicsAssetPrimitivesNum_PA_PropertyAddress;

	private static int GetPhysicsAssetPrimitivesNum_PA_Offset;

	private static bool GetPhysicsAssetPrimitivesNum_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsAssetPrimitivesNum_ReturnValue_PropertyAddress;

	private static int GetPhysicsAssetPrimitivesNum_ReturnValue_Offset;

	private static bool GetPhysicsAssetBodySetups_IsValid;

	private static IntPtr GetPhysicsAssetBodySetups_FunctionAddress;

	private static int GetPhysicsAssetBodySetups_ParamsSize;

	private static bool GetPhysicsAssetBodySetups_PA_IsValid;

	private static FFieldAddress GetPhysicsAssetBodySetups_PA_PropertyAddress;

	private static int GetPhysicsAssetBodySetups_PA_Offset;

	private static bool GetPhysicsAssetBodySetups_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsAssetBodySetups_ReturnValue_PropertyAddress;

	private static int GetPhysicsAssetBodySetups_ReturnValue_Offset;

	private static bool GetPhysicsAsset_IsValid;

	private static IntPtr GetPhysicsAsset_FunctionAddress;

	private static int GetPhysicsAsset_ParamsSize;

	private static bool GetPhysicsAsset_Mesh_IsValid;

	private static FFieldAddress GetPhysicsAsset_Mesh_PropertyAddress;

	private static int GetPhysicsAsset_Mesh_Offset;

	private static bool GetPhysicsAsset_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsAsset_ReturnValue_PropertyAddress;

	private static int GetPhysicsAsset_ReturnValue_Offset;

	private static bool ExchangePAConstraintsChildParent_IsValid;

	private static IntPtr ExchangePAConstraintsChildParent_FunctionAddress;

	private static int ExchangePAConstraintsChildParent_ParamsSize;

	private static bool ExchangePAConstraintsChildParent_PA_IsValid;

	private static FFieldAddress ExchangePAConstraintsChildParent_PA_PropertyAddress;

	private static int ExchangePAConstraintsChildParent_PA_Offset;

	private static bool ExchangePAConstraintsChildParent_ReturnValue_IsValid;

	private static FFieldAddress ExchangePAConstraintsChildParent_ReturnValue_PropertyAddress;

	private static int ExchangePAConstraintsChildParent_ReturnValue_Offset;

	private static bool ConvertSkinnedMesheToStaticMesh_IsValid;

	private static IntPtr ConvertSkinnedMesheToStaticMesh_FunctionAddress;

	private static int ConvertSkinnedMesheToStaticMesh_ParamsSize;

	private static bool ConvertSkinnedMesheToStaticMesh_InMeshComponents_IsValid;

	private static FFieldAddress ConvertSkinnedMesheToStaticMesh_InMeshComponents_PropertyAddress;

	private static int ConvertSkinnedMesheToStaticMesh_InMeshComponents_Offset;

	private static bool ConvertSkinnedMesheToStaticMesh_InRootTransform_IsValid;

	private static FFieldAddress ConvertSkinnedMesheToStaticMesh_InRootTransform_PropertyAddress;

	private static int ConvertSkinnedMesheToStaticMesh_InRootTransform_Offset;

	private static bool ConvertSkinnedMesheToStaticMesh_InPackageName_IsValid;

	private static FFieldAddress ConvertSkinnedMesheToStaticMesh_InPackageName_PropertyAddress;

	private static int ConvertSkinnedMesheToStaticMesh_InPackageName_Offset;

	private static bool ConvertSkinnedMesheToStaticMesh_LODIndex_IsValid;

	private static FFieldAddress ConvertSkinnedMesheToStaticMesh_LODIndex_PropertyAddress;

	private static int ConvertSkinnedMesheToStaticMesh_LODIndex_Offset;

	private static bool ConvertSkinnedMesheToStaticMesh_SectionIndex_IsValid;

	private static FFieldAddress ConvertSkinnedMesheToStaticMesh_SectionIndex_PropertyAddress;

	private static int ConvertSkinnedMesheToStaticMesh_SectionIndex_Offset;

	private static bool ConvertMeshesToStaticMesh_IsValid;

	private static IntPtr ConvertMeshesToStaticMesh_FunctionAddress;

	private static int ConvertMeshesToStaticMesh_ParamsSize;

	private static bool ConvertMeshesToStaticMesh_InMeshComponents_IsValid;

	private static FFieldAddress ConvertMeshesToStaticMesh_InMeshComponents_PropertyAddress;

	private static int ConvertMeshesToStaticMesh_InMeshComponents_Offset;

	private static bool ConvertMeshesToStaticMesh_InRootTransform_IsValid;

	private static FFieldAddress ConvertMeshesToStaticMesh_InRootTransform_PropertyAddress;

	private static int ConvertMeshesToStaticMesh_InRootTransform_Offset;

	private static bool ConvertMeshesToStaticMesh_InPackageName_IsValid;

	private static FFieldAddress ConvertMeshesToStaticMesh_InPackageName_PropertyAddress;

	private static int ConvertMeshesToStaticMesh_InPackageName_Offset;

	private static bool CheckSkeletalMeshClothPAEqualDefaultPA_IsValid;

	private static IntPtr CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress;

	private static int CheckSkeletalMeshClothPAEqualDefaultPA_ParamsSize;

	private static bool CheckSkeletalMeshClothPAEqualDefaultPA_SKMesh_IsValid;

	private static FFieldAddress CheckSkeletalMeshClothPAEqualDefaultPA_SKMesh_PropertyAddress;

	private static int CheckSkeletalMeshClothPAEqualDefaultPA_SKMesh_Offset;

	private static bool CheckSkeletalMeshClothPAEqualDefaultPA_ReturnValue_IsValid;

	private static FFieldAddress CheckSkeletalMeshClothPAEqualDefaultPA_ReturnValue_PropertyAddress;

	private static int CheckSkeletalMeshClothPAEqualDefaultPA_ReturnValue_Offset;

	private static bool CheckPhysicsAssetSimWithPhysicsOnly_IsValid;

	private static IntPtr CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress;

	private static int CheckPhysicsAssetSimWithPhysicsOnly_ParamsSize;

	private static bool CheckPhysicsAssetSimWithPhysicsOnly_PA_IsValid;

	private static FFieldAddress CheckPhysicsAssetSimWithPhysicsOnly_PA_PropertyAddress;

	private static int CheckPhysicsAssetSimWithPhysicsOnly_PA_Offset;

	private static bool CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_IsValid;

	private static FFieldAddress CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_PropertyAddress;

	private static int CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_Offset;

	private static bool CheckPhysicsAssetBoneNameWithSpecialCollisionType_IsValid;

	private static IntPtr CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress;

	private static int CheckPhysicsAssetBoneNameWithSpecialCollisionType_ParamsSize;

	private static bool CheckPhysicsAssetBoneNameWithSpecialCollisionType_PA_IsValid;

	private static FFieldAddress CheckPhysicsAssetBoneNameWithSpecialCollisionType_PA_PropertyAddress;

	private static int CheckPhysicsAssetBoneNameWithSpecialCollisionType_PA_Offset;

	private static bool CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_IsValid;

	private static FFieldAddress CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_PropertyAddress;

	private static int CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_Offset;

	private static bool CheckPhysicsAssetBoneNameWithSpecialCollisionType_CollisionType_IsValid;

	private static FFieldAddress CheckPhysicsAssetBoneNameWithSpecialCollisionType_CollisionType_PropertyAddress;

	private static int CheckPhysicsAssetBoneNameWithSpecialCollisionType_CollisionType_Offset;

	private static bool CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_IsValid;

	private static FFieldAddress CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_PropertyAddress;

	private static int CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_Offset;

	private static bool CheckPAInterspersedWithCollisionDisableTable_IsValid;

	private static IntPtr CheckPAInterspersedWithCollisionDisableTable_FunctionAddress;

	private static int CheckPAInterspersedWithCollisionDisableTable_ParamsSize;

	private static bool CheckPAInterspersedWithCollisionDisableTable_PA_IsValid;

	private static FFieldAddress CheckPAInterspersedWithCollisionDisableTable_PA_PropertyAddress;

	private static int CheckPAInterspersedWithCollisionDisableTable_PA_Offset;

	private static bool CheckPAInterspersedWithCollisionDisableTable_ReturnValue_IsValid;

	private static FFieldAddress CheckPAInterspersedWithCollisionDisableTable_ReturnValue_PropertyAddress;

	private static int CheckPAInterspersedWithCollisionDisableTable_ReturnValue_Offset;

	private static bool CheckPAInterspersed_IsValid;

	private static IntPtr CheckPAInterspersed_FunctionAddress;

	private static int CheckPAInterspersed_ParamsSize;

	private static bool CheckPAInterspersed_PA_IsValid;

	private static FFieldAddress CheckPAInterspersed_PA_PropertyAddress;

	private static int CheckPAInterspersed_PA_Offset;

	private static bool CheckPAInterspersed_ReturnValue_IsValid;

	private static FFieldAddress CheckPAInterspersed_ReturnValue_PropertyAddress;

	private static int CheckPAInterspersed_ReturnValue_Offset;

	private static bool CheckPAConstraintsChildParentError_IsValid;

	private static IntPtr CheckPAConstraintsChildParentError_FunctionAddress;

	private static int CheckPAConstraintsChildParentError_ParamsSize;

	private static bool CheckPAConstraintsChildParentError_PA_IsValid;

	private static FFieldAddress CheckPAConstraintsChildParentError_PA_PropertyAddress;

	private static int CheckPAConstraintsChildParentError_PA_Offset;

	private static bool CheckPAConstraintsChildParentError_ReturnValue_IsValid;

	private static FFieldAddress CheckPAConstraintsChildParentError_ReturnValue_PropertyAddress;

	private static int CheckPAConstraintsChildParentError_ReturnValue_Offset;

	private static bool AddVirtualBone_IsValid;

	private static IntPtr AddVirtualBone_FunctionAddress;

	private static int AddVirtualBone_ParamsSize;

	private static bool AddVirtualBone_Skeleton_IsValid;

	private static FFieldAddress AddVirtualBone_Skeleton_PropertyAddress;

	private static int AddVirtualBone_Skeleton_Offset;

	private static bool AddVirtualBone_SourceBoneName_IsValid;

	private static FFieldAddress AddVirtualBone_SourceBoneName_PropertyAddress;

	private static int AddVirtualBone_SourceBoneName_Offset;

	private static bool AddVirtualBone_TargetBoneName_IsValid;

	private static FFieldAddress AddVirtualBone_TargetBoneName_PropertyAddress;

	private static int AddVirtualBone_TargetBoneName_Offset;

	private static bool AddVirtualBone_VirtualBoneName_IsValid;

	private static FFieldAddress AddVirtualBone_VirtualBoneName_PropertyAddress;

	private static int AddVirtualBone_VirtualBoneName_Offset;

	private static bool AddNewSocketWithMeshSpaceTransform_IsValid;

	private static IntPtr AddNewSocketWithMeshSpaceTransform_FunctionAddress;

	private static int AddNewSocketWithMeshSpaceTransform_ParamsSize;

	private static bool AddNewSocketWithMeshSpaceTransform_SKMesh_IsValid;

	private static FFieldAddress AddNewSocketWithMeshSpaceTransform_SKMesh_PropertyAddress;

	private static int AddNewSocketWithMeshSpaceTransform_SKMesh_Offset;

	private static bool AddNewSocketWithMeshSpaceTransform_SocketName_IsValid;

	private static FFieldAddress AddNewSocketWithMeshSpaceTransform_SocketName_PropertyAddress;

	private static int AddNewSocketWithMeshSpaceTransform_SocketName_Offset;

	private static bool AddNewSocketWithMeshSpaceTransform_BoneName_IsValid;

	private static FFieldAddress AddNewSocketWithMeshSpaceTransform_BoneName_PropertyAddress;

	private static int AddNewSocketWithMeshSpaceTransform_BoneName_Offset;

	private static bool AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_IsValid;

	private static FFieldAddress AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_PropertyAddress;

	private static int AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_Offset;

	private static bool AddNewSocketWithMeshSpaceTransform_ReturnValue_IsValid;

	private static FFieldAddress AddNewSocketWithMeshSpaceTransform_ReturnValue_PropertyAddress;

	private static int AddNewSocketWithMeshSpaceTransform_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ToggleMaterialCurve")]
	public unsafe static void ToggleMaterialCurve(UObject inSkeleton, List<FName> CurveNames)
	{
		if (!ToggleMaterialCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ToggleMaterialCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleMaterialCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleMaterialCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ToggleMaterialCurve_inSkeleton_Offset), 0, ToggleMaterialCurve_inSkeleton_PropertyAddress.Address, inSkeleton);
		new TArrayCopyMarshaler<FName>(1, ToggleMaterialCurve_CurveNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, ToggleMaterialCurve_CurveNames_Offset), CurveNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ToggleMaterialCurve_FunctionAddress, intPtr, ToggleMaterialCurve_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ToggleMaterialCurve_CurveNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetSkeletalMeshCPUAccess")]
	public unsafe static bool SetSkeletalMeshCPUAccess(USkeletalMesh InSM, int LodIndex, bool Access)
	{
		if (!SetSkeletalMeshCPUAccess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetSkeletalMeshCPUAccess");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkeletalMeshCPUAccess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkeletalMeshCPUAccess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetSkeletalMeshCPUAccess_InSM_Offset), 0, SetSkeletalMeshCPUAccess_InSM_PropertyAddress.Address, InSM);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSkeletalMeshCPUAccess_LodIndex_Offset), 0, SetSkeletalMeshCPUAccess_LodIndex_PropertyAddress.Address, LodIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSkeletalMeshCPUAccess_Access_Offset), 0, SetSkeletalMeshCPUAccess_Access_PropertyAddress.Address, Access);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSkeletalMeshCPUAccess_FunctionAddress, intPtr, SetSkeletalMeshCPUAccess_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSkeletalMeshCPUAccess_ReturnValue_Offset), 0, SetSkeletalMeshCPUAccess_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetRagdoll")]
	public unsafe static void SetRagdoll(UPhysicsAsset PA, bool bRecreateBodies, bool bCheckRootBody, bool bSetWeapon, bool bSetSimBodies, bool bSetDefaultLimit, bool bResetConstraintsPosition, bool bSetKineToSim, bool bResetBodyCollision)
	{
		if (!SetRagdoll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetRagdoll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRagdoll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRagdoll_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, SetRagdoll_PA_Offset), 0, SetRagdoll_PA_PropertyAddress.Address, PA);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRagdoll_bRecreateBodies_Offset), 0, SetRagdoll_bRecreateBodies_PropertyAddress.Address, bRecreateBodies);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRagdoll_bCheckRootBody_Offset), 0, SetRagdoll_bCheckRootBody_PropertyAddress.Address, bCheckRootBody);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRagdoll_bSetWeapon_Offset), 0, SetRagdoll_bSetWeapon_PropertyAddress.Address, bSetWeapon);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRagdoll_bSetSimBodies_Offset), 0, SetRagdoll_bSetSimBodies_PropertyAddress.Address, bSetSimBodies);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRagdoll_bSetDefaultLimit_Offset), 0, SetRagdoll_bSetDefaultLimit_PropertyAddress.Address, bSetDefaultLimit);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRagdoll_bResetConstraintsPosition_Offset), 0, SetRagdoll_bResetConstraintsPosition_PropertyAddress.Address, bResetConstraintsPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRagdoll_bSetKineToSim_Offset), 0, SetRagdoll_bSetKineToSim_PropertyAddress.Address, bSetKineToSim);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRagdoll_bResetBodyCollision_Offset), 0, SetRagdoll_bResetBodyCollision_PropertyAddress.Address, bResetBodyCollision);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRagdoll_FunctionAddress, intPtr, SetRagdoll_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetLODScreenSize")]
	public unsafe static bool SetLODScreenSize(USkeletalMesh InSM, int LodIndex, float NewScreenSize)
	{
		if (!SetLODScreenSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetLODScreenSize");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLODScreenSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLODScreenSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetLODScreenSize_InSM_Offset), 0, SetLODScreenSize_InSM_PropertyAddress.Address, InSM);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLODScreenSize_LodIndex_Offset), 0, SetLODScreenSize_LodIndex_PropertyAddress.Address, LodIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLODScreenSize_NewScreenSize_Offset), 0, SetLODScreenSize_NewScreenSize_PropertyAddress.Address, NewScreenSize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLODScreenSize_FunctionAddress, intPtr, SetLODScreenSize_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLODScreenSize_ReturnValue_Offset), 0, SetLODScreenSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetInertialTensorScale")]
	public unsafe static void SetInertialTensorScale(UPhysicsAsset PA, float TensorScale, float DampingScale)
	{
		if (!SetInertialTensorScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetInertialTensorScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInertialTensorScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInertialTensorScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, SetInertialTensorScale_PA_Offset), 0, SetInertialTensorScale_PA_PropertyAddress.Address, PA);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetInertialTensorScale_TensorScale_Offset), 0, SetInertialTensorScale_TensorScale_PropertyAddress.Address, TensorScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetInertialTensorScale_DampingScale_Offset), 0, SetInertialTensorScale_DampingScale_PropertyAddress.Address, DampingScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInertialTensorScale_FunctionAddress, intPtr, SetInertialTensorScale_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetBeAttackProfile")]
	public unsafe static void SetBeAttackProfile(UPhysicsAsset PA, bool bCheckRootBody, bool bLockLimb, float DefaultStiffness, float DefaultDamping)
	{
		if (!SetBeAttackProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetBeAttackProfile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBeAttackProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBeAttackProfile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, SetBeAttackProfile_PA_Offset), 0, SetBeAttackProfile_PA_PropertyAddress.Address, PA);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBeAttackProfile_bCheckRootBody_Offset), 0, SetBeAttackProfile_bCheckRootBody_PropertyAddress.Address, bCheckRootBody);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBeAttackProfile_bLockLimb_Offset), 0, SetBeAttackProfile_bLockLimb_PropertyAddress.Address, bLockLimb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBeAttackProfile_DefaultStiffness_Offset), 0, SetBeAttackProfile_DefaultStiffness_PropertyAddress.Address, DefaultStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBeAttackProfile_DefaultDamping_Offset), 0, SetBeAttackProfile_DefaultDamping_PropertyAddress.Address, DefaultDamping);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBeAttackProfile_FunctionAddress, intPtr, SetBeAttackProfile_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ResetBeAttackLockLimb")]
	public unsafe static void ResetBeAttackLockLimb(UPhysicsAsset PA)
	{
		if (!ResetBeAttackLockLimb_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ResetBeAttackLockLimb");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetBeAttackLockLimb_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetBeAttackLockLimb_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, ResetBeAttackLockLimb_PA_Offset), 0, ResetBeAttackLockLimb_PA_PropertyAddress.Address, PA);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetBeAttackLockLimb_FunctionAddress, intPtr, ResetBeAttackLockLimb_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:RemoveVirtualBone")]
	public unsafe static void RemoveVirtualBone(USkeleton Skeleton, FName VirtualBoneName)
	{
		if (!RemoveVirtualBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:RemoveVirtualBone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveVirtualBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveVirtualBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, RemoveVirtualBone_Skeleton_Offset), 0, RemoveVirtualBone_Skeleton_PropertyAddress.Address, Skeleton);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveVirtualBone_VirtualBoneName_Offset), 0, RemoveVirtualBone_VirtualBoneName_PropertyAddress.Address, VirtualBoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveVirtualBone_FunctionAddress, intPtr, RemoveVirtualBone_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshVertices")]
	public unsafe static int GetSkeletalMeshVertices(USkeletalMesh skeletalmesh, int LOD)
	{
		if (!GetSkeletalMeshVertices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshVertices");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletalMeshVertices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletalMeshVertices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshVertices_skeletalmesh_Offset), 0, GetSkeletalMeshVertices_skeletalmesh_PropertyAddress.Address, skeletalmesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshVertices_LOD_Offset), 0, GetSkeletalMeshVertices_LOD_PropertyAddress.Address, LOD);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeletalMeshVertices_FunctionAddress, intPtr, GetSkeletalMeshVertices_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSkeletalMeshVertices_ReturnValue_Offset), 0, GetSkeletalMeshVertices_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshTriangles")]
	public unsafe static int GetSkeletalMeshTriangles(USkeletalMesh skeletalmesh, int LOD)
	{
		if (!GetSkeletalMeshTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshTriangles");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletalMeshTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletalMeshTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshTriangles_skeletalmesh_Offset), 0, GetSkeletalMeshTriangles_skeletalmesh_PropertyAddress.Address, skeletalmesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshTriangles_LOD_Offset), 0, GetSkeletalMeshTriangles_LOD_PropertyAddress.Address, LOD);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeletalMeshTriangles_FunctionAddress, intPtr, GetSkeletalMeshTriangles_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSkeletalMeshTriangles_ReturnValue_Offset), 0, GetSkeletalMeshTriangles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshClothsTriangles")]
	public unsafe static List<int> GetSkeletalMeshClothsTriangles(USkeletalMesh skeletalmesh)
	{
		if (!GetSkeletalMeshClothsTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshClothsTriangles");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletalMeshClothsTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletalMeshClothsTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshClothsTriangles_skeletalmesh_Offset), 0, GetSkeletalMeshClothsTriangles_skeletalmesh_PropertyAddress.Address, skeletalmesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeletalMeshClothsTriangles_FunctionAddress, intPtr, GetSkeletalMeshClothsTriangles_ParamsSize);
		List<int> result = new TArrayCopyMarshaler<int>(1, GetSkeletalMeshClothsTriangles_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSkeletalMeshClothsTriangles_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSkeletalMeshClothsTriangles_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshClothsPhysicsAsset")]
	public unsafe static List<UPhysicsAsset> GetSkeletalMeshClothsPhysicsAsset(USkeletalMesh skeletalmesh)
	{
		if (!GetSkeletalMeshClothsPhysicsAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshClothsPhysicsAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletalMeshClothsPhysicsAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletalMeshClothsPhysicsAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshClothsPhysicsAsset_skeletalmesh_Offset), 0, GetSkeletalMeshClothsPhysicsAsset_skeletalmesh_PropertyAddress.Address, skeletalmesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeletalMeshClothsPhysicsAsset_FunctionAddress, intPtr, GetSkeletalMeshClothsPhysicsAsset_ParamsSize);
		List<UPhysicsAsset> result = new TArrayCopyMarshaler<UPhysicsAsset>(1, GetSkeletalMeshClothsPhysicsAsset_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UPhysicsAsset, UObjectMarshaler<UPhysicsAsset>>.FromNative, CachedMarshalingDelegates<UPhysicsAsset, UObjectMarshaler<UPhysicsAsset>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSkeletalMeshClothsPhysicsAsset_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSkeletalMeshClothsPhysicsAsset_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshClothSectionIndex")]
	public unsafe static List<int> GetSkeletalMeshClothSectionIndex(USkeletalMesh InSM, int LODIndex)
	{
		if (!GetSkeletalMeshClothSectionIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshClothSectionIndex");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletalMeshClothSectionIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletalMeshClothSectionIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshClothSectionIndex_InSM_Offset), 0, GetSkeletalMeshClothSectionIndex_InSM_PropertyAddress.Address, InSM);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshClothSectionIndex_LODIndex_Offset), 0, GetSkeletalMeshClothSectionIndex_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeletalMeshClothSectionIndex_FunctionAddress, intPtr, GetSkeletalMeshClothSectionIndex_ParamsSize);
		List<int> result = new TArrayCopyMarshaler<int>(1, GetSkeletalMeshClothSectionIndex_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSkeletalMeshClothSectionIndex_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSkeletalMeshClothSectionIndex_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshBoneTree")]
	public unsafe static Dictionary<string, string> GetSkeletalMeshBoneTree(USkeletalMesh skeletalmesh)
	{
		if (!GetSkeletalMeshBoneTree_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshBoneTree");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletalMeshBoneTree_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletalMeshBoneTree_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshBoneTree_skeletalmesh_Offset), 0, GetSkeletalMeshBoneTree_skeletalmesh_PropertyAddress.Address, skeletalmesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeletalMeshBoneTree_FunctionAddress, intPtr, GetSkeletalMeshBoneTree_ParamsSize);
		Dictionary<string, string> result = new TMapCopyMarshaler<string, string>(1, GetSkeletalMeshBoneTree_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetSkeletalMeshBoneTree_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSkeletalMeshBoneTree_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshBoneTransforms")]
	public unsafe static Dictionary<string, FTransform> GetSkeletalMeshBoneTransforms(USkeletalMesh skeletalmesh, int RootIndex = 0, bool WorldSpace = true)
	{
		if (!GetSkeletalMeshBoneTransforms_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshBoneTransforms");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletalMeshBoneTransforms_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletalMeshBoneTransforms_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshBoneTransforms_skeletalmesh_Offset), 0, GetSkeletalMeshBoneTransforms_skeletalmesh_PropertyAddress.Address, skeletalmesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshBoneTransforms_RootIndex_Offset), 0, GetSkeletalMeshBoneTransforms_RootIndex_PropertyAddress.Address, RootIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshBoneTransforms_WorldSpace_Offset), 0, GetSkeletalMeshBoneTransforms_WorldSpace_PropertyAddress.Address, WorldSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeletalMeshBoneTransforms_FunctionAddress, intPtr, GetSkeletalMeshBoneTransforms_ParamsSize);
		Dictionary<string, FTransform> result = new TMapCopyMarshaler<string, FTransform>(1, GetSkeletalMeshBoneTransforms_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSkeletalMeshBoneTransforms_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSkeletalMeshBoneTransforms_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshBoneToVertexMap")]
	public unsafe static List<int> GetSkeletalMeshBoneToVertexMap(USkeletalMesh InSM, int BoneIndex)
	{
		if (!GetSkeletalMeshBoneToVertexMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshBoneToVertexMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletalMeshBoneToVertexMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletalMeshBoneToVertexMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshBoneToVertexMap_InSM_Offset), 0, GetSkeletalMeshBoneToVertexMap_InSM_PropertyAddress.Address, InSM);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSkeletalMeshBoneToVertexMap_BoneIndex_Offset), 0, GetSkeletalMeshBoneToVertexMap_BoneIndex_PropertyAddress.Address, BoneIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeletalMeshBoneToVertexMap_FunctionAddress, intPtr, GetSkeletalMeshBoneToVertexMap_ParamsSize);
		List<int> result = new TArrayCopyMarshaler<int>(1, GetSkeletalMeshBoneToVertexMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSkeletalMeshBoneToVertexMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSkeletalMeshBoneToVertexMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetPhysicsAssetPrimitivesNum")]
	public unsafe static int GetPhysicsAssetPrimitivesNum(UPhysicsAsset PA)
	{
		if (!GetPhysicsAssetPrimitivesNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetPhysicsAssetPrimitivesNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsAssetPrimitivesNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsAssetPrimitivesNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, GetPhysicsAssetPrimitivesNum_PA_Offset), 0, GetPhysicsAssetPrimitivesNum_PA_PropertyAddress.Address, PA);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPhysicsAssetPrimitivesNum_FunctionAddress, intPtr, GetPhysicsAssetPrimitivesNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPhysicsAssetPrimitivesNum_ReturnValue_Offset), 0, GetPhysicsAssetPrimitivesNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetPhysicsAssetBodySetups")]
	public unsafe static List<UObject> GetPhysicsAssetBodySetups(UPhysicsAsset PA)
	{
		if (!GetPhysicsAssetBodySetups_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetPhysicsAssetBodySetups");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsAssetBodySetups_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsAssetBodySetups_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, GetPhysicsAssetBodySetups_PA_Offset), 0, GetPhysicsAssetBodySetups_PA_PropertyAddress.Address, PA);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPhysicsAssetBodySetups_FunctionAddress, intPtr, GetPhysicsAssetBodySetups_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetPhysicsAssetBodySetups_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPhysicsAssetBodySetups_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPhysicsAssetBodySetups_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetPhysicsAsset")]
	public unsafe static UPhysicsAsset GetPhysicsAsset(USkeletalMeshComponent Mesh)
	{
		if (!GetPhysicsAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetPhysicsAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GetPhysicsAsset_Mesh_Offset), 0, GetPhysicsAsset_Mesh_PropertyAddress.Address, Mesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPhysicsAsset_FunctionAddress, intPtr, GetPhysicsAsset_ParamsSize);
		return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(intPtr, GetPhysicsAsset_ReturnValue_Offset), 0, GetPhysicsAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ExchangePAConstraintsChildParent")]
	public unsafe static List<string> ExchangePAConstraintsChildParent(UPhysicsAsset PA)
	{
		if (!ExchangePAConstraintsChildParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ExchangePAConstraintsChildParent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExchangePAConstraintsChildParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExchangePAConstraintsChildParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, ExchangePAConstraintsChildParent_PA_Offset), 0, ExchangePAConstraintsChildParent_PA_PropertyAddress.Address, PA);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExchangePAConstraintsChildParent_FunctionAddress, intPtr, ExchangePAConstraintsChildParent_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, ExchangePAConstraintsChildParent_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, ExchangePAConstraintsChildParent_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ExchangePAConstraintsChildParent_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ConvertSkinnedMesheToStaticMesh")]
	public unsafe static void ConvertSkinnedMesheToStaticMesh(List<UMeshComponent> InMeshComponents, FTransform InRootTransform, string InPackageName, int LODIndex, int SectionIndex)
	{
		if (!ConvertSkinnedMesheToStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ConvertSkinnedMesheToStaticMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertSkinnedMesheToStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertSkinnedMesheToStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMeshComponent>(1, ConvertSkinnedMesheToStaticMesh_InMeshComponents_PropertyAddress, CachedMarshalingDelegates<UMeshComponent, UObjectMarshaler<UMeshComponent>>.FromNative, CachedMarshalingDelegates<UMeshComponent, UObjectMarshaler<UMeshComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertSkinnedMesheToStaticMesh_InMeshComponents_Offset), InMeshComponents);
		NativeReflection.InitializeValue_InContainer(ConvertSkinnedMesheToStaticMesh_InRootTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ConvertSkinnedMesheToStaticMesh_InRootTransform_Offset), 0, ConvertSkinnedMesheToStaticMesh_InRootTransform_PropertyAddress.Address, InRootTransform);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertSkinnedMesheToStaticMesh_InPackageName_Offset), 0, ConvertSkinnedMesheToStaticMesh_InPackageName_PropertyAddress.Address, InPackageName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertSkinnedMesheToStaticMesh_LODIndex_Offset), 0, ConvertSkinnedMesheToStaticMesh_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertSkinnedMesheToStaticMesh_SectionIndex_Offset), 0, ConvertSkinnedMesheToStaticMesh_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertSkinnedMesheToStaticMesh_FunctionAddress, intPtr, ConvertSkinnedMesheToStaticMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertSkinnedMesheToStaticMesh_InMeshComponents_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ConvertSkinnedMesheToStaticMesh_InPackageName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ConvertMeshesToStaticMesh")]
	public unsafe static void ConvertMeshesToStaticMesh(List<UMeshComponent> InMeshComponents, FTransform InRootTransform, string InPackageName)
	{
		if (!ConvertMeshesToStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ConvertMeshesToStaticMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertMeshesToStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertMeshesToStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMeshComponent>(1, ConvertMeshesToStaticMesh_InMeshComponents_PropertyAddress, CachedMarshalingDelegates<UMeshComponent, UObjectMarshaler<UMeshComponent>>.FromNative, CachedMarshalingDelegates<UMeshComponent, UObjectMarshaler<UMeshComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertMeshesToStaticMesh_InMeshComponents_Offset), InMeshComponents);
		NativeReflection.InitializeValue_InContainer(ConvertMeshesToStaticMesh_InRootTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ConvertMeshesToStaticMesh_InRootTransform_Offset), 0, ConvertMeshesToStaticMesh_InRootTransform_PropertyAddress.Address, InRootTransform);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertMeshesToStaticMesh_InPackageName_Offset), 0, ConvertMeshesToStaticMesh_InPackageName_PropertyAddress.Address, InPackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertMeshesToStaticMesh_FunctionAddress, intPtr, ConvertMeshesToStaticMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertMeshesToStaticMesh_InMeshComponents_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ConvertMeshesToStaticMesh_InPackageName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckSkeletalMeshClothPAEqualDefaultPA")]
	public unsafe static int CheckSkeletalMeshClothPAEqualDefaultPA(USkeletalMesh SKMesh)
	{
		if (!CheckSkeletalMeshClothPAEqualDefaultPA_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckSkeletalMeshClothPAEqualDefaultPA");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckSkeletalMeshClothPAEqualDefaultPA_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckSkeletalMeshClothPAEqualDefaultPA_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, CheckSkeletalMeshClothPAEqualDefaultPA_SKMesh_Offset), 0, CheckSkeletalMeshClothPAEqualDefaultPA_SKMesh_PropertyAddress.Address, SKMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress, intPtr, CheckSkeletalMeshClothPAEqualDefaultPA_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CheckSkeletalMeshClothPAEqualDefaultPA_ReturnValue_Offset), 0, CheckSkeletalMeshClothPAEqualDefaultPA_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPhysicsAssetSimWithPhysicsOnly")]
	public unsafe static List<string> CheckPhysicsAssetSimWithPhysicsOnly(UPhysicsAsset PA)
	{
		if (!CheckPhysicsAssetSimWithPhysicsOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPhysicsAssetSimWithPhysicsOnly");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckPhysicsAssetSimWithPhysicsOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckPhysicsAssetSimWithPhysicsOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, CheckPhysicsAssetSimWithPhysicsOnly_PA_Offset), 0, CheckPhysicsAssetSimWithPhysicsOnly_PA_PropertyAddress.Address, PA);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress, intPtr, CheckPhysicsAssetSimWithPhysicsOnly_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPhysicsAssetBoneNameWithSpecialCollisionType")]
	public unsafe static List<string> CheckPhysicsAssetBoneNameWithSpecialCollisionType(UPhysicsAsset PA, List<FName> BoneNames, ECollisionEnabled CollisionType)
	{
		if (!CheckPhysicsAssetBoneNameWithSpecialCollisionType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPhysicsAssetBoneNameWithSpecialCollisionType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckPhysicsAssetBoneNameWithSpecialCollisionType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckPhysicsAssetBoneNameWithSpecialCollisionType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, CheckPhysicsAssetBoneNameWithSpecialCollisionType_PA_Offset), 0, CheckPhysicsAssetBoneNameWithSpecialCollisionType_PA_PropertyAddress.Address, PA);
		new TArrayCopyMarshaler<FName>(1, CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_Offset), BoneNames);
		EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(intPtr, CheckPhysicsAssetBoneNameWithSpecialCollisionType_CollisionType_Offset), 0, CheckPhysicsAssetBoneNameWithSpecialCollisionType_CollisionType_PropertyAddress.Address, CollisionType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, intPtr, CheckPhysicsAssetBoneNameWithSpecialCollisionType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPAInterspersedWithCollisionDisableTable")]
	public unsafe static List<FErrorNamePair> CheckPAInterspersedWithCollisionDisableTable(UPhysicsAsset PA)
	{
		if (!CheckPAInterspersedWithCollisionDisableTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPAInterspersedWithCollisionDisableTable");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckPAInterspersedWithCollisionDisableTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckPAInterspersedWithCollisionDisableTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, CheckPAInterspersedWithCollisionDisableTable_PA_Offset), 0, CheckPAInterspersedWithCollisionDisableTable_PA_PropertyAddress.Address, PA);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckPAInterspersedWithCollisionDisableTable_FunctionAddress, intPtr, CheckPAInterspersedWithCollisionDisableTable_ParamsSize);
		List<FErrorNamePair> result = new TArrayCopyMarshaler<FErrorNamePair>(1, CheckPAInterspersedWithCollisionDisableTable_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FErrorNamePair, FErrorNamePair>.FromNative, CachedMarshalingDelegates<FErrorNamePair, FErrorNamePair>.ToNative).FromNative(IntPtr.Add(intPtr, CheckPAInterspersedWithCollisionDisableTable_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CheckPAInterspersedWithCollisionDisableTable_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPAInterspersed")]
	public unsafe static List<FErrorNamePair> CheckPAInterspersed(UPhysicsAsset PA)
	{
		if (!CheckPAInterspersed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPAInterspersed");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckPAInterspersed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckPAInterspersed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, CheckPAInterspersed_PA_Offset), 0, CheckPAInterspersed_PA_PropertyAddress.Address, PA);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckPAInterspersed_FunctionAddress, intPtr, CheckPAInterspersed_ParamsSize);
		List<FErrorNamePair> result = new TArrayCopyMarshaler<FErrorNamePair>(1, CheckPAInterspersed_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FErrorNamePair, FErrorNamePair>.FromNative, CachedMarshalingDelegates<FErrorNamePair, FErrorNamePair>.ToNative).FromNative(IntPtr.Add(intPtr, CheckPAInterspersed_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CheckPAInterspersed_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPAConstraintsChildParentError")]
	public unsafe static List<string> CheckPAConstraintsChildParentError(UPhysicsAsset PA)
	{
		if (!CheckPAConstraintsChildParentError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPAConstraintsChildParentError");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckPAConstraintsChildParentError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckPAConstraintsChildParentError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, CheckPAConstraintsChildParentError_PA_Offset), 0, CheckPAConstraintsChildParentError_PA_PropertyAddress.Address, PA);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckPAConstraintsChildParentError_FunctionAddress, intPtr, CheckPAConstraintsChildParentError_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, CheckPAConstraintsChildParentError_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, CheckPAConstraintsChildParentError_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CheckPAConstraintsChildParentError_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:AddVirtualBone")]
	public unsafe static void AddVirtualBone(USkeleton Skeleton, FName SourceBoneName, FName TargetBoneName, FName VirtualBoneName)
	{
		if (!AddVirtualBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:AddVirtualBone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVirtualBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVirtualBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, AddVirtualBone_Skeleton_Offset), 0, AddVirtualBone_Skeleton_PropertyAddress.Address, Skeleton);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVirtualBone_SourceBoneName_Offset), 0, AddVirtualBone_SourceBoneName_PropertyAddress.Address, SourceBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVirtualBone_TargetBoneName_Offset), 0, AddVirtualBone_TargetBoneName_PropertyAddress.Address, TargetBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVirtualBone_VirtualBoneName_Offset), 0, AddVirtualBone_VirtualBoneName_PropertyAddress.Address, VirtualBoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddVirtualBone_FunctionAddress, intPtr, AddVirtualBone_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:AddNewSocketWithMeshSpaceTransform")]
	public unsafe static int AddNewSocketWithMeshSpaceTransform(USkeletalMesh SKMesh, FName SocketName, FName BoneName, FTransform MeshSpaceTransform)
	{
		if (!AddNewSocketWithMeshSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:AddNewSocketWithMeshSpaceTransform");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNewSocketWithMeshSpaceTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNewSocketWithMeshSpaceTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, AddNewSocketWithMeshSpaceTransform_SKMesh_Offset), 0, AddNewSocketWithMeshSpaceTransform_SKMesh_PropertyAddress.Address, SKMesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddNewSocketWithMeshSpaceTransform_SocketName_Offset), 0, AddNewSocketWithMeshSpaceTransform_SocketName_PropertyAddress.Address, SocketName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddNewSocketWithMeshSpaceTransform_BoneName_Offset), 0, AddNewSocketWithMeshSpaceTransform_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InitializeValue_InContainer(AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_Offset), 0, AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_PropertyAddress.Address, MeshSpaceTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddNewSocketWithMeshSpaceTransform_FunctionAddress, intPtr, AddNewSocketWithMeshSpaceTransform_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddNewSocketWithMeshSpaceTransform_ReturnValue_Offset), 0, AddNewSocketWithMeshSpaceTransform_ReturnValue_PropertyAddress.Address);
	}

	static UGSEditorSkeletalMeshLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorSkeletalMeshLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorSkeletalMeshLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary");
		ToggleMaterialCurve_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToggleMaterialCurve");
		ToggleMaterialCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleMaterialCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToggleMaterialCurve_inSkeleton_PropertyAddress, ToggleMaterialCurve_FunctionAddress, "inSkeleton");
		ToggleMaterialCurve_inSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(ToggleMaterialCurve_FunctionAddress, "inSkeleton");
		ToggleMaterialCurve_inSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleMaterialCurve_FunctionAddress, "inSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ToggleMaterialCurve_CurveNames_PropertyAddress, ToggleMaterialCurve_FunctionAddress, "CurveNames");
		ToggleMaterialCurve_CurveNames_Offset = NativeReflectionCached.GetPropertyOffset(ToggleMaterialCurve_FunctionAddress, "CurveNames");
		ToggleMaterialCurve_CurveNames_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleMaterialCurve_FunctionAddress, "CurveNames", Classes.FArrayProperty);
		ToggleMaterialCurve_IsValid = ToggleMaterialCurve_FunctionAddress != IntPtr.Zero && ToggleMaterialCurve_inSkeleton_IsValid && ToggleMaterialCurve_CurveNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ToggleMaterialCurve", ToggleMaterialCurve_IsValid);
		SetSkeletalMeshCPUAccess_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSkeletalMeshCPUAccess");
		SetSkeletalMeshCPUAccess_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkeletalMeshCPUAccess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMeshCPUAccess_InSM_PropertyAddress, SetSkeletalMeshCPUAccess_FunctionAddress, "InSM");
		SetSkeletalMeshCPUAccess_InSM_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMeshCPUAccess_FunctionAddress, "InSM");
		SetSkeletalMeshCPUAccess_InSM_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMeshCPUAccess_FunctionAddress, "InSM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMeshCPUAccess_LodIndex_PropertyAddress, SetSkeletalMeshCPUAccess_FunctionAddress, "LodIndex");
		SetSkeletalMeshCPUAccess_LodIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMeshCPUAccess_FunctionAddress, "LodIndex");
		SetSkeletalMeshCPUAccess_LodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMeshCPUAccess_FunctionAddress, "LodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMeshCPUAccess_Access_PropertyAddress, SetSkeletalMeshCPUAccess_FunctionAddress, "Access");
		SetSkeletalMeshCPUAccess_Access_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMeshCPUAccess_FunctionAddress, "Access");
		SetSkeletalMeshCPUAccess_Access_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMeshCPUAccess_FunctionAddress, "Access", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMeshCPUAccess_ReturnValue_PropertyAddress, SetSkeletalMeshCPUAccess_FunctionAddress, "ReturnValue");
		SetSkeletalMeshCPUAccess_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMeshCPUAccess_FunctionAddress, "ReturnValue");
		SetSkeletalMeshCPUAccess_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMeshCPUAccess_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSkeletalMeshCPUAccess_IsValid = SetSkeletalMeshCPUAccess_FunctionAddress != IntPtr.Zero && SetSkeletalMeshCPUAccess_InSM_IsValid && SetSkeletalMeshCPUAccess_LodIndex_IsValid && SetSkeletalMeshCPUAccess_Access_IsValid && SetSkeletalMeshCPUAccess_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetSkeletalMeshCPUAccess", SetSkeletalMeshCPUAccess_IsValid);
		SetRagdoll_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRagdoll");
		SetRagdoll_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRagdoll_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRagdoll_PA_PropertyAddress, SetRagdoll_FunctionAddress, "PA");
		SetRagdoll_PA_Offset = NativeReflectionCached.GetPropertyOffset(SetRagdoll_FunctionAddress, "PA");
		SetRagdoll_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRagdoll_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRagdoll_bRecreateBodies_PropertyAddress, SetRagdoll_FunctionAddress, "bRecreateBodies");
		SetRagdoll_bRecreateBodies_Offset = NativeReflectionCached.GetPropertyOffset(SetRagdoll_FunctionAddress, "bRecreateBodies");
		SetRagdoll_bRecreateBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRagdoll_FunctionAddress, "bRecreateBodies", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRagdoll_bCheckRootBody_PropertyAddress, SetRagdoll_FunctionAddress, "bCheckRootBody");
		SetRagdoll_bCheckRootBody_Offset = NativeReflectionCached.GetPropertyOffset(SetRagdoll_FunctionAddress, "bCheckRootBody");
		SetRagdoll_bCheckRootBody_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRagdoll_FunctionAddress, "bCheckRootBody", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRagdoll_bSetWeapon_PropertyAddress, SetRagdoll_FunctionAddress, "bSetWeapon");
		SetRagdoll_bSetWeapon_Offset = NativeReflectionCached.GetPropertyOffset(SetRagdoll_FunctionAddress, "bSetWeapon");
		SetRagdoll_bSetWeapon_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRagdoll_FunctionAddress, "bSetWeapon", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRagdoll_bSetSimBodies_PropertyAddress, SetRagdoll_FunctionAddress, "bSetSimBodies");
		SetRagdoll_bSetSimBodies_Offset = NativeReflectionCached.GetPropertyOffset(SetRagdoll_FunctionAddress, "bSetSimBodies");
		SetRagdoll_bSetSimBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRagdoll_FunctionAddress, "bSetSimBodies", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRagdoll_bSetDefaultLimit_PropertyAddress, SetRagdoll_FunctionAddress, "bSetDefaultLimit");
		SetRagdoll_bSetDefaultLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetRagdoll_FunctionAddress, "bSetDefaultLimit");
		SetRagdoll_bSetDefaultLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRagdoll_FunctionAddress, "bSetDefaultLimit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRagdoll_bResetConstraintsPosition_PropertyAddress, SetRagdoll_FunctionAddress, "bResetConstraintsPosition");
		SetRagdoll_bResetConstraintsPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetRagdoll_FunctionAddress, "bResetConstraintsPosition");
		SetRagdoll_bResetConstraintsPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRagdoll_FunctionAddress, "bResetConstraintsPosition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRagdoll_bSetKineToSim_PropertyAddress, SetRagdoll_FunctionAddress, "bSetKineToSim");
		SetRagdoll_bSetKineToSim_Offset = NativeReflectionCached.GetPropertyOffset(SetRagdoll_FunctionAddress, "bSetKineToSim");
		SetRagdoll_bSetKineToSim_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRagdoll_FunctionAddress, "bSetKineToSim", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRagdoll_bResetBodyCollision_PropertyAddress, SetRagdoll_FunctionAddress, "bResetBodyCollision");
		SetRagdoll_bResetBodyCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetRagdoll_FunctionAddress, "bResetBodyCollision");
		SetRagdoll_bResetBodyCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRagdoll_FunctionAddress, "bResetBodyCollision", Classes.FBoolProperty);
		SetRagdoll_IsValid = SetRagdoll_FunctionAddress != IntPtr.Zero && SetRagdoll_PA_IsValid && SetRagdoll_bRecreateBodies_IsValid && SetRagdoll_bCheckRootBody_IsValid && SetRagdoll_bSetWeapon_IsValid && SetRagdoll_bSetSimBodies_IsValid && SetRagdoll_bSetDefaultLimit_IsValid && SetRagdoll_bResetConstraintsPosition_IsValid && SetRagdoll_bSetKineToSim_IsValid && SetRagdoll_bResetBodyCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetRagdoll", SetRagdoll_IsValid);
		SetLODScreenSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLODScreenSize");
		SetLODScreenSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLODScreenSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLODScreenSize_InSM_PropertyAddress, SetLODScreenSize_FunctionAddress, "InSM");
		SetLODScreenSize_InSM_Offset = NativeReflectionCached.GetPropertyOffset(SetLODScreenSize_FunctionAddress, "InSM");
		SetLODScreenSize_InSM_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODScreenSize_FunctionAddress, "InSM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODScreenSize_LodIndex_PropertyAddress, SetLODScreenSize_FunctionAddress, "LodIndex");
		SetLODScreenSize_LodIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLODScreenSize_FunctionAddress, "LodIndex");
		SetLODScreenSize_LodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODScreenSize_FunctionAddress, "LodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODScreenSize_NewScreenSize_PropertyAddress, SetLODScreenSize_FunctionAddress, "NewScreenSize");
		SetLODScreenSize_NewScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(SetLODScreenSize_FunctionAddress, "NewScreenSize");
		SetLODScreenSize_NewScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODScreenSize_FunctionAddress, "NewScreenSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODScreenSize_ReturnValue_PropertyAddress, SetLODScreenSize_FunctionAddress, "ReturnValue");
		SetLODScreenSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLODScreenSize_FunctionAddress, "ReturnValue");
		SetLODScreenSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODScreenSize_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLODScreenSize_IsValid = SetLODScreenSize_FunctionAddress != IntPtr.Zero && SetLODScreenSize_InSM_IsValid && SetLODScreenSize_LodIndex_IsValid && SetLODScreenSize_NewScreenSize_IsValid && SetLODScreenSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetLODScreenSize", SetLODScreenSize_IsValid);
		SetInertialTensorScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInertialTensorScale");
		SetInertialTensorScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInertialTensorScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInertialTensorScale_PA_PropertyAddress, SetInertialTensorScale_FunctionAddress, "PA");
		SetInertialTensorScale_PA_Offset = NativeReflectionCached.GetPropertyOffset(SetInertialTensorScale_FunctionAddress, "PA");
		SetInertialTensorScale_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInertialTensorScale_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInertialTensorScale_TensorScale_PropertyAddress, SetInertialTensorScale_FunctionAddress, "TensorScale");
		SetInertialTensorScale_TensorScale_Offset = NativeReflectionCached.GetPropertyOffset(SetInertialTensorScale_FunctionAddress, "TensorScale");
		SetInertialTensorScale_TensorScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInertialTensorScale_FunctionAddress, "TensorScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInertialTensorScale_DampingScale_PropertyAddress, SetInertialTensorScale_FunctionAddress, "DampingScale");
		SetInertialTensorScale_DampingScale_Offset = NativeReflectionCached.GetPropertyOffset(SetInertialTensorScale_FunctionAddress, "DampingScale");
		SetInertialTensorScale_DampingScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInertialTensorScale_FunctionAddress, "DampingScale", Classes.FFloatProperty);
		SetInertialTensorScale_IsValid = SetInertialTensorScale_FunctionAddress != IntPtr.Zero && SetInertialTensorScale_PA_IsValid && SetInertialTensorScale_TensorScale_IsValid && SetInertialTensorScale_DampingScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetInertialTensorScale", SetInertialTensorScale_IsValid);
		SetBeAttackProfile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBeAttackProfile");
		SetBeAttackProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBeAttackProfile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBeAttackProfile_PA_PropertyAddress, SetBeAttackProfile_FunctionAddress, "PA");
		SetBeAttackProfile_PA_Offset = NativeReflectionCached.GetPropertyOffset(SetBeAttackProfile_FunctionAddress, "PA");
		SetBeAttackProfile_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeAttackProfile_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeAttackProfile_bCheckRootBody_PropertyAddress, SetBeAttackProfile_FunctionAddress, "bCheckRootBody");
		SetBeAttackProfile_bCheckRootBody_Offset = NativeReflectionCached.GetPropertyOffset(SetBeAttackProfile_FunctionAddress, "bCheckRootBody");
		SetBeAttackProfile_bCheckRootBody_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeAttackProfile_FunctionAddress, "bCheckRootBody", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeAttackProfile_bLockLimb_PropertyAddress, SetBeAttackProfile_FunctionAddress, "bLockLimb");
		SetBeAttackProfile_bLockLimb_Offset = NativeReflectionCached.GetPropertyOffset(SetBeAttackProfile_FunctionAddress, "bLockLimb");
		SetBeAttackProfile_bLockLimb_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeAttackProfile_FunctionAddress, "bLockLimb", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeAttackProfile_DefaultStiffness_PropertyAddress, SetBeAttackProfile_FunctionAddress, "DefaultStiffness");
		SetBeAttackProfile_DefaultStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetBeAttackProfile_FunctionAddress, "DefaultStiffness");
		SetBeAttackProfile_DefaultStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeAttackProfile_FunctionAddress, "DefaultStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeAttackProfile_DefaultDamping_PropertyAddress, SetBeAttackProfile_FunctionAddress, "DefaultDamping");
		SetBeAttackProfile_DefaultDamping_Offset = NativeReflectionCached.GetPropertyOffset(SetBeAttackProfile_FunctionAddress, "DefaultDamping");
		SetBeAttackProfile_DefaultDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeAttackProfile_FunctionAddress, "DefaultDamping", Classes.FFloatProperty);
		SetBeAttackProfile_IsValid = SetBeAttackProfile_FunctionAddress != IntPtr.Zero && SetBeAttackProfile_PA_IsValid && SetBeAttackProfile_bCheckRootBody_IsValid && SetBeAttackProfile_bLockLimb_IsValid && SetBeAttackProfile_DefaultStiffness_IsValid && SetBeAttackProfile_DefaultDamping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:SetBeAttackProfile", SetBeAttackProfile_IsValid);
		ResetBeAttackLockLimb_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetBeAttackLockLimb");
		ResetBeAttackLockLimb_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetBeAttackLockLimb_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetBeAttackLockLimb_PA_PropertyAddress, ResetBeAttackLockLimb_FunctionAddress, "PA");
		ResetBeAttackLockLimb_PA_Offset = NativeReflectionCached.GetPropertyOffset(ResetBeAttackLockLimb_FunctionAddress, "PA");
		ResetBeAttackLockLimb_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetBeAttackLockLimb_FunctionAddress, "PA", Classes.FObjectProperty);
		ResetBeAttackLockLimb_IsValid = ResetBeAttackLockLimb_FunctionAddress != IntPtr.Zero && ResetBeAttackLockLimb_PA_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ResetBeAttackLockLimb", ResetBeAttackLockLimb_IsValid);
		RemoveVirtualBone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveVirtualBone");
		RemoveVirtualBone_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveVirtualBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveVirtualBone_Skeleton_PropertyAddress, RemoveVirtualBone_FunctionAddress, "Skeleton");
		RemoveVirtualBone_Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVirtualBone_FunctionAddress, "Skeleton");
		RemoveVirtualBone_Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVirtualBone_FunctionAddress, "Skeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveVirtualBone_VirtualBoneName_PropertyAddress, RemoveVirtualBone_FunctionAddress, "VirtualBoneName");
		RemoveVirtualBone_VirtualBoneName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVirtualBone_FunctionAddress, "VirtualBoneName");
		RemoveVirtualBone_VirtualBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVirtualBone_FunctionAddress, "VirtualBoneName", Classes.FNameProperty);
		RemoveVirtualBone_IsValid = RemoveVirtualBone_FunctionAddress != IntPtr.Zero && RemoveVirtualBone_Skeleton_IsValid && RemoveVirtualBone_VirtualBoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:RemoveVirtualBone", RemoveVirtualBone_IsValid);
		GetSkeletalMeshVertices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeletalMeshVertices");
		GetSkeletalMeshVertices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletalMeshVertices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshVertices_skeletalmesh_PropertyAddress, GetSkeletalMeshVertices_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshVertices_skeletalmesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshVertices_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshVertices_skeletalmesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshVertices_FunctionAddress, "skeletalmesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshVertices_LOD_PropertyAddress, GetSkeletalMeshVertices_FunctionAddress, "LOD");
		GetSkeletalMeshVertices_LOD_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshVertices_FunctionAddress, "LOD");
		GetSkeletalMeshVertices_LOD_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshVertices_FunctionAddress, "LOD", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshVertices_ReturnValue_PropertyAddress, GetSkeletalMeshVertices_FunctionAddress, "ReturnValue");
		GetSkeletalMeshVertices_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshVertices_FunctionAddress, "ReturnValue");
		GetSkeletalMeshVertices_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshVertices_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSkeletalMeshVertices_IsValid = GetSkeletalMeshVertices_FunctionAddress != IntPtr.Zero && GetSkeletalMeshVertices_skeletalmesh_IsValid && GetSkeletalMeshVertices_LOD_IsValid && GetSkeletalMeshVertices_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshVertices", GetSkeletalMeshVertices_IsValid);
		GetSkeletalMeshTriangles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeletalMeshTriangles");
		GetSkeletalMeshTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletalMeshTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshTriangles_skeletalmesh_PropertyAddress, GetSkeletalMeshTriangles_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshTriangles_skeletalmesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshTriangles_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshTriangles_skeletalmesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshTriangles_FunctionAddress, "skeletalmesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshTriangles_LOD_PropertyAddress, GetSkeletalMeshTriangles_FunctionAddress, "LOD");
		GetSkeletalMeshTriangles_LOD_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshTriangles_FunctionAddress, "LOD");
		GetSkeletalMeshTriangles_LOD_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshTriangles_FunctionAddress, "LOD", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshTriangles_ReturnValue_PropertyAddress, GetSkeletalMeshTriangles_FunctionAddress, "ReturnValue");
		GetSkeletalMeshTriangles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshTriangles_FunctionAddress, "ReturnValue");
		GetSkeletalMeshTriangles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshTriangles_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSkeletalMeshTriangles_IsValid = GetSkeletalMeshTriangles_FunctionAddress != IntPtr.Zero && GetSkeletalMeshTriangles_skeletalmesh_IsValid && GetSkeletalMeshTriangles_LOD_IsValid && GetSkeletalMeshTriangles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshTriangles", GetSkeletalMeshTriangles_IsValid);
		GetSkeletalMeshClothsTriangles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeletalMeshClothsTriangles");
		GetSkeletalMeshClothsTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletalMeshClothsTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshClothsTriangles_skeletalmesh_PropertyAddress, GetSkeletalMeshClothsTriangles_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshClothsTriangles_skeletalmesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshClothsTriangles_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshClothsTriangles_skeletalmesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshClothsTriangles_FunctionAddress, "skeletalmesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshClothsTriangles_ReturnValue_PropertyAddress, GetSkeletalMeshClothsTriangles_FunctionAddress, "ReturnValue");
		GetSkeletalMeshClothsTriangles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshClothsTriangles_FunctionAddress, "ReturnValue");
		GetSkeletalMeshClothsTriangles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshClothsTriangles_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSkeletalMeshClothsTriangles_IsValid = GetSkeletalMeshClothsTriangles_FunctionAddress != IntPtr.Zero && GetSkeletalMeshClothsTriangles_skeletalmesh_IsValid && GetSkeletalMeshClothsTriangles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshClothsTriangles", GetSkeletalMeshClothsTriangles_IsValid);
		GetSkeletalMeshClothsPhysicsAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeletalMeshClothsPhysicsAsset");
		GetSkeletalMeshClothsPhysicsAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletalMeshClothsPhysicsAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshClothsPhysicsAsset_skeletalmesh_PropertyAddress, GetSkeletalMeshClothsPhysicsAsset_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshClothsPhysicsAsset_skeletalmesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshClothsPhysicsAsset_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshClothsPhysicsAsset_skeletalmesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshClothsPhysicsAsset_FunctionAddress, "skeletalmesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshClothsPhysicsAsset_ReturnValue_PropertyAddress, GetSkeletalMeshClothsPhysicsAsset_FunctionAddress, "ReturnValue");
		GetSkeletalMeshClothsPhysicsAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshClothsPhysicsAsset_FunctionAddress, "ReturnValue");
		GetSkeletalMeshClothsPhysicsAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshClothsPhysicsAsset_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSkeletalMeshClothsPhysicsAsset_IsValid = GetSkeletalMeshClothsPhysicsAsset_FunctionAddress != IntPtr.Zero && GetSkeletalMeshClothsPhysicsAsset_skeletalmesh_IsValid && GetSkeletalMeshClothsPhysicsAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshClothsPhysicsAsset", GetSkeletalMeshClothsPhysicsAsset_IsValid);
		GetSkeletalMeshClothSectionIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeletalMeshClothSectionIndex");
		GetSkeletalMeshClothSectionIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletalMeshClothSectionIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshClothSectionIndex_InSM_PropertyAddress, GetSkeletalMeshClothSectionIndex_FunctionAddress, "InSM");
		GetSkeletalMeshClothSectionIndex_InSM_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshClothSectionIndex_FunctionAddress, "InSM");
		GetSkeletalMeshClothSectionIndex_InSM_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshClothSectionIndex_FunctionAddress, "InSM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshClothSectionIndex_LODIndex_PropertyAddress, GetSkeletalMeshClothSectionIndex_FunctionAddress, "LODIndex");
		GetSkeletalMeshClothSectionIndex_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshClothSectionIndex_FunctionAddress, "LODIndex");
		GetSkeletalMeshClothSectionIndex_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshClothSectionIndex_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshClothSectionIndex_ReturnValue_PropertyAddress, GetSkeletalMeshClothSectionIndex_FunctionAddress, "ReturnValue");
		GetSkeletalMeshClothSectionIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshClothSectionIndex_FunctionAddress, "ReturnValue");
		GetSkeletalMeshClothSectionIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshClothSectionIndex_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSkeletalMeshClothSectionIndex_IsValid = GetSkeletalMeshClothSectionIndex_FunctionAddress != IntPtr.Zero && GetSkeletalMeshClothSectionIndex_InSM_IsValid && GetSkeletalMeshClothSectionIndex_LODIndex_IsValid && GetSkeletalMeshClothSectionIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshClothSectionIndex", GetSkeletalMeshClothSectionIndex_IsValid);
		GetSkeletalMeshBoneTree_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeletalMeshBoneTree");
		GetSkeletalMeshBoneTree_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletalMeshBoneTree_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshBoneTree_skeletalmesh_PropertyAddress, GetSkeletalMeshBoneTree_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshBoneTree_skeletalmesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshBoneTree_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshBoneTree_skeletalmesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshBoneTree_FunctionAddress, "skeletalmesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshBoneTree_ReturnValue_PropertyAddress, GetSkeletalMeshBoneTree_FunctionAddress, "ReturnValue");
		GetSkeletalMeshBoneTree_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshBoneTree_FunctionAddress, "ReturnValue");
		GetSkeletalMeshBoneTree_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshBoneTree_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetSkeletalMeshBoneTree_IsValid = GetSkeletalMeshBoneTree_FunctionAddress != IntPtr.Zero && GetSkeletalMeshBoneTree_skeletalmesh_IsValid && GetSkeletalMeshBoneTree_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshBoneTree", GetSkeletalMeshBoneTree_IsValid);
		GetSkeletalMeshBoneTransforms_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeletalMeshBoneTransforms");
		GetSkeletalMeshBoneTransforms_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletalMeshBoneTransforms_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshBoneTransforms_skeletalmesh_PropertyAddress, GetSkeletalMeshBoneTransforms_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshBoneTransforms_skeletalmesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshBoneTransforms_FunctionAddress, "skeletalmesh");
		GetSkeletalMeshBoneTransforms_skeletalmesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshBoneTransforms_FunctionAddress, "skeletalmesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshBoneTransforms_RootIndex_PropertyAddress, GetSkeletalMeshBoneTransforms_FunctionAddress, "RootIndex");
		GetSkeletalMeshBoneTransforms_RootIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshBoneTransforms_FunctionAddress, "RootIndex");
		GetSkeletalMeshBoneTransforms_RootIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshBoneTransforms_FunctionAddress, "RootIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshBoneTransforms_WorldSpace_PropertyAddress, GetSkeletalMeshBoneTransforms_FunctionAddress, "WorldSpace");
		GetSkeletalMeshBoneTransforms_WorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshBoneTransforms_FunctionAddress, "WorldSpace");
		GetSkeletalMeshBoneTransforms_WorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshBoneTransforms_FunctionAddress, "WorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshBoneTransforms_ReturnValue_PropertyAddress, GetSkeletalMeshBoneTransforms_FunctionAddress, "ReturnValue");
		GetSkeletalMeshBoneTransforms_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshBoneTransforms_FunctionAddress, "ReturnValue");
		GetSkeletalMeshBoneTransforms_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshBoneTransforms_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetSkeletalMeshBoneTransforms_IsValid = GetSkeletalMeshBoneTransforms_FunctionAddress != IntPtr.Zero && GetSkeletalMeshBoneTransforms_skeletalmesh_IsValid && GetSkeletalMeshBoneTransforms_RootIndex_IsValid && GetSkeletalMeshBoneTransforms_WorldSpace_IsValid && GetSkeletalMeshBoneTransforms_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshBoneTransforms", GetSkeletalMeshBoneTransforms_IsValid);
		GetSkeletalMeshBoneToVertexMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeletalMeshBoneToVertexMap");
		GetSkeletalMeshBoneToVertexMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletalMeshBoneToVertexMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshBoneToVertexMap_InSM_PropertyAddress, GetSkeletalMeshBoneToVertexMap_FunctionAddress, "InSM");
		GetSkeletalMeshBoneToVertexMap_InSM_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshBoneToVertexMap_FunctionAddress, "InSM");
		GetSkeletalMeshBoneToVertexMap_InSM_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshBoneToVertexMap_FunctionAddress, "InSM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshBoneToVertexMap_BoneIndex_PropertyAddress, GetSkeletalMeshBoneToVertexMap_FunctionAddress, "BoneIndex");
		GetSkeletalMeshBoneToVertexMap_BoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshBoneToVertexMap_FunctionAddress, "BoneIndex");
		GetSkeletalMeshBoneToVertexMap_BoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshBoneToVertexMap_FunctionAddress, "BoneIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletalMeshBoneToVertexMap_ReturnValue_PropertyAddress, GetSkeletalMeshBoneToVertexMap_FunctionAddress, "ReturnValue");
		GetSkeletalMeshBoneToVertexMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletalMeshBoneToVertexMap_FunctionAddress, "ReturnValue");
		GetSkeletalMeshBoneToVertexMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletalMeshBoneToVertexMap_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSkeletalMeshBoneToVertexMap_IsValid = GetSkeletalMeshBoneToVertexMap_FunctionAddress != IntPtr.Zero && GetSkeletalMeshBoneToVertexMap_InSM_IsValid && GetSkeletalMeshBoneToVertexMap_BoneIndex_IsValid && GetSkeletalMeshBoneToVertexMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetSkeletalMeshBoneToVertexMap", GetSkeletalMeshBoneToVertexMap_IsValid);
		GetPhysicsAssetPrimitivesNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPhysicsAssetPrimitivesNum");
		GetPhysicsAssetPrimitivesNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsAssetPrimitivesNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAssetPrimitivesNum_PA_PropertyAddress, GetPhysicsAssetPrimitivesNum_FunctionAddress, "PA");
		GetPhysicsAssetPrimitivesNum_PA_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAssetPrimitivesNum_FunctionAddress, "PA");
		GetPhysicsAssetPrimitivesNum_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAssetPrimitivesNum_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAssetPrimitivesNum_ReturnValue_PropertyAddress, GetPhysicsAssetPrimitivesNum_FunctionAddress, "ReturnValue");
		GetPhysicsAssetPrimitivesNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAssetPrimitivesNum_FunctionAddress, "ReturnValue");
		GetPhysicsAssetPrimitivesNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAssetPrimitivesNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPhysicsAssetPrimitivesNum_IsValid = GetPhysicsAssetPrimitivesNum_FunctionAddress != IntPtr.Zero && GetPhysicsAssetPrimitivesNum_PA_IsValid && GetPhysicsAssetPrimitivesNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetPhysicsAssetPrimitivesNum", GetPhysicsAssetPrimitivesNum_IsValid);
		GetPhysicsAssetBodySetups_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPhysicsAssetBodySetups");
		GetPhysicsAssetBodySetups_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsAssetBodySetups_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAssetBodySetups_PA_PropertyAddress, GetPhysicsAssetBodySetups_FunctionAddress, "PA");
		GetPhysicsAssetBodySetups_PA_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAssetBodySetups_FunctionAddress, "PA");
		GetPhysicsAssetBodySetups_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAssetBodySetups_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAssetBodySetups_ReturnValue_PropertyAddress, GetPhysicsAssetBodySetups_FunctionAddress, "ReturnValue");
		GetPhysicsAssetBodySetups_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAssetBodySetups_FunctionAddress, "ReturnValue");
		GetPhysicsAssetBodySetups_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAssetBodySetups_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPhysicsAssetBodySetups_IsValid = GetPhysicsAssetBodySetups_FunctionAddress != IntPtr.Zero && GetPhysicsAssetBodySetups_PA_IsValid && GetPhysicsAssetBodySetups_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetPhysicsAssetBodySetups", GetPhysicsAssetBodySetups_IsValid);
		GetPhysicsAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPhysicsAsset");
		GetPhysicsAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAsset_Mesh_PropertyAddress, GetPhysicsAsset_FunctionAddress, "Mesh");
		GetPhysicsAsset_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAsset_FunctionAddress, "Mesh");
		GetPhysicsAsset_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAsset_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAsset_ReturnValue_PropertyAddress, GetPhysicsAsset_FunctionAddress, "ReturnValue");
		GetPhysicsAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAsset_FunctionAddress, "ReturnValue");
		GetPhysicsAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPhysicsAsset_IsValid = GetPhysicsAsset_FunctionAddress != IntPtr.Zero && GetPhysicsAsset_Mesh_IsValid && GetPhysicsAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:GetPhysicsAsset", GetPhysicsAsset_IsValid);
		ExchangePAConstraintsChildParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExchangePAConstraintsChildParent");
		ExchangePAConstraintsChildParent_ParamsSize = NativeReflection.GetFunctionParamsSize(ExchangePAConstraintsChildParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExchangePAConstraintsChildParent_PA_PropertyAddress, ExchangePAConstraintsChildParent_FunctionAddress, "PA");
		ExchangePAConstraintsChildParent_PA_Offset = NativeReflectionCached.GetPropertyOffset(ExchangePAConstraintsChildParent_FunctionAddress, "PA");
		ExchangePAConstraintsChildParent_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(ExchangePAConstraintsChildParent_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExchangePAConstraintsChildParent_ReturnValue_PropertyAddress, ExchangePAConstraintsChildParent_FunctionAddress, "ReturnValue");
		ExchangePAConstraintsChildParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExchangePAConstraintsChildParent_FunctionAddress, "ReturnValue");
		ExchangePAConstraintsChildParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExchangePAConstraintsChildParent_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ExchangePAConstraintsChildParent_IsValid = ExchangePAConstraintsChildParent_FunctionAddress != IntPtr.Zero && ExchangePAConstraintsChildParent_PA_IsValid && ExchangePAConstraintsChildParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ExchangePAConstraintsChildParent", ExchangePAConstraintsChildParent_IsValid);
		ConvertSkinnedMesheToStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertSkinnedMesheToStaticMesh");
		ConvertSkinnedMesheToStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertSkinnedMesheToStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertSkinnedMesheToStaticMesh_InMeshComponents_PropertyAddress, ConvertSkinnedMesheToStaticMesh_FunctionAddress, "InMeshComponents");
		ConvertSkinnedMesheToStaticMesh_InMeshComponents_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "InMeshComponents");
		ConvertSkinnedMesheToStaticMesh_InMeshComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "InMeshComponents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSkinnedMesheToStaticMesh_InRootTransform_PropertyAddress, ConvertSkinnedMesheToStaticMesh_FunctionAddress, "InRootTransform");
		ConvertSkinnedMesheToStaticMesh_InRootTransform_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "InRootTransform");
		ConvertSkinnedMesheToStaticMesh_InRootTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "InRootTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSkinnedMesheToStaticMesh_InPackageName_PropertyAddress, ConvertSkinnedMesheToStaticMesh_FunctionAddress, "InPackageName");
		ConvertSkinnedMesheToStaticMesh_InPackageName_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "InPackageName");
		ConvertSkinnedMesheToStaticMesh_InPackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "InPackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSkinnedMesheToStaticMesh_LODIndex_PropertyAddress, ConvertSkinnedMesheToStaticMesh_FunctionAddress, "LODIndex");
		ConvertSkinnedMesheToStaticMesh_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "LODIndex");
		ConvertSkinnedMesheToStaticMesh_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSkinnedMesheToStaticMesh_SectionIndex_PropertyAddress, ConvertSkinnedMesheToStaticMesh_FunctionAddress, "SectionIndex");
		ConvertSkinnedMesheToStaticMesh_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "SectionIndex");
		ConvertSkinnedMesheToStaticMesh_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSkinnedMesheToStaticMesh_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		ConvertSkinnedMesheToStaticMesh_IsValid = ConvertSkinnedMesheToStaticMesh_FunctionAddress != IntPtr.Zero && ConvertSkinnedMesheToStaticMesh_InMeshComponents_IsValid && ConvertSkinnedMesheToStaticMesh_InRootTransform_IsValid && ConvertSkinnedMesheToStaticMesh_InPackageName_IsValid && ConvertSkinnedMesheToStaticMesh_LODIndex_IsValid && ConvertSkinnedMesheToStaticMesh_SectionIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ConvertSkinnedMesheToStaticMesh", ConvertSkinnedMesheToStaticMesh_IsValid);
		ConvertMeshesToStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertMeshesToStaticMesh");
		ConvertMeshesToStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertMeshesToStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertMeshesToStaticMesh_InMeshComponents_PropertyAddress, ConvertMeshesToStaticMesh_FunctionAddress, "InMeshComponents");
		ConvertMeshesToStaticMesh_InMeshComponents_Offset = NativeReflectionCached.GetPropertyOffset(ConvertMeshesToStaticMesh_FunctionAddress, "InMeshComponents");
		ConvertMeshesToStaticMesh_InMeshComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertMeshesToStaticMesh_FunctionAddress, "InMeshComponents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertMeshesToStaticMesh_InRootTransform_PropertyAddress, ConvertMeshesToStaticMesh_FunctionAddress, "InRootTransform");
		ConvertMeshesToStaticMesh_InRootTransform_Offset = NativeReflectionCached.GetPropertyOffset(ConvertMeshesToStaticMesh_FunctionAddress, "InRootTransform");
		ConvertMeshesToStaticMesh_InRootTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertMeshesToStaticMesh_FunctionAddress, "InRootTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertMeshesToStaticMesh_InPackageName_PropertyAddress, ConvertMeshesToStaticMesh_FunctionAddress, "InPackageName");
		ConvertMeshesToStaticMesh_InPackageName_Offset = NativeReflectionCached.GetPropertyOffset(ConvertMeshesToStaticMesh_FunctionAddress, "InPackageName");
		ConvertMeshesToStaticMesh_InPackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertMeshesToStaticMesh_FunctionAddress, "InPackageName", Classes.FStrProperty);
		ConvertMeshesToStaticMesh_IsValid = ConvertMeshesToStaticMesh_FunctionAddress != IntPtr.Zero && ConvertMeshesToStaticMesh_InMeshComponents_IsValid && ConvertMeshesToStaticMesh_InRootTransform_IsValid && ConvertMeshesToStaticMesh_InPackageName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:ConvertMeshesToStaticMesh", ConvertMeshesToStaticMesh_IsValid);
		CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckSkeletalMeshClothPAEqualDefaultPA");
		CheckSkeletalMeshClothPAEqualDefaultPA_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckSkeletalMeshClothPAEqualDefaultPA_SKMesh_PropertyAddress, CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress, "SKMesh");
		CheckSkeletalMeshClothPAEqualDefaultPA_SKMesh_Offset = NativeReflectionCached.GetPropertyOffset(CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress, "SKMesh");
		CheckSkeletalMeshClothPAEqualDefaultPA_SKMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress, "SKMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckSkeletalMeshClothPAEqualDefaultPA_ReturnValue_PropertyAddress, CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress, "ReturnValue");
		CheckSkeletalMeshClothPAEqualDefaultPA_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress, "ReturnValue");
		CheckSkeletalMeshClothPAEqualDefaultPA_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CheckSkeletalMeshClothPAEqualDefaultPA_IsValid = CheckSkeletalMeshClothPAEqualDefaultPA_FunctionAddress != IntPtr.Zero && CheckSkeletalMeshClothPAEqualDefaultPA_SKMesh_IsValid && CheckSkeletalMeshClothPAEqualDefaultPA_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckSkeletalMeshClothPAEqualDefaultPA", CheckSkeletalMeshClothPAEqualDefaultPA_IsValid);
		CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckPhysicsAssetSimWithPhysicsOnly");
		CheckPhysicsAssetSimWithPhysicsOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckPhysicsAssetSimWithPhysicsOnly_PA_PropertyAddress, CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress, "PA");
		CheckPhysicsAssetSimWithPhysicsOnly_PA_Offset = NativeReflectionCached.GetPropertyOffset(CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress, "PA");
		CheckPhysicsAssetSimWithPhysicsOnly_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_PropertyAddress, CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress, "ReturnValue");
		CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress, "ReturnValue");
		CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CheckPhysicsAssetSimWithPhysicsOnly_IsValid = CheckPhysicsAssetSimWithPhysicsOnly_FunctionAddress != IntPtr.Zero && CheckPhysicsAssetSimWithPhysicsOnly_PA_IsValid && CheckPhysicsAssetSimWithPhysicsOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPhysicsAssetSimWithPhysicsOnly", CheckPhysicsAssetSimWithPhysicsOnly_IsValid);
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckPhysicsAssetBoneNameWithSpecialCollisionType");
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckPhysicsAssetBoneNameWithSpecialCollisionType_PA_PropertyAddress, CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "PA");
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_PA_Offset = NativeReflectionCached.GetPropertyOffset(CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "PA");
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_PropertyAddress, CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "BoneNames");
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_Offset = NativeReflectionCached.GetPropertyOffset(CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "BoneNames");
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "BoneNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckPhysicsAssetBoneNameWithSpecialCollisionType_CollisionType_PropertyAddress, CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "CollisionType");
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_CollisionType_Offset = NativeReflectionCached.GetPropertyOffset(CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "CollisionType");
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_CollisionType_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "CollisionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_PropertyAddress, CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "ReturnValue");
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "ReturnValue");
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CheckPhysicsAssetBoneNameWithSpecialCollisionType_IsValid = CheckPhysicsAssetBoneNameWithSpecialCollisionType_FunctionAddress != IntPtr.Zero && CheckPhysicsAssetBoneNameWithSpecialCollisionType_PA_IsValid && CheckPhysicsAssetBoneNameWithSpecialCollisionType_BoneNames_IsValid && CheckPhysicsAssetBoneNameWithSpecialCollisionType_CollisionType_IsValid && CheckPhysicsAssetBoneNameWithSpecialCollisionType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPhysicsAssetBoneNameWithSpecialCollisionType", CheckPhysicsAssetBoneNameWithSpecialCollisionType_IsValid);
		CheckPAInterspersedWithCollisionDisableTable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckPAInterspersedWithCollisionDisableTable");
		CheckPAInterspersedWithCollisionDisableTable_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckPAInterspersedWithCollisionDisableTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckPAInterspersedWithCollisionDisableTable_PA_PropertyAddress, CheckPAInterspersedWithCollisionDisableTable_FunctionAddress, "PA");
		CheckPAInterspersedWithCollisionDisableTable_PA_Offset = NativeReflectionCached.GetPropertyOffset(CheckPAInterspersedWithCollisionDisableTable_FunctionAddress, "PA");
		CheckPAInterspersedWithCollisionDisableTable_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPAInterspersedWithCollisionDisableTable_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckPAInterspersedWithCollisionDisableTable_ReturnValue_PropertyAddress, CheckPAInterspersedWithCollisionDisableTable_FunctionAddress, "ReturnValue");
		CheckPAInterspersedWithCollisionDisableTable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckPAInterspersedWithCollisionDisableTable_FunctionAddress, "ReturnValue");
		CheckPAInterspersedWithCollisionDisableTable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPAInterspersedWithCollisionDisableTable_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CheckPAInterspersedWithCollisionDisableTable_IsValid = CheckPAInterspersedWithCollisionDisableTable_FunctionAddress != IntPtr.Zero && CheckPAInterspersedWithCollisionDisableTable_PA_IsValid && CheckPAInterspersedWithCollisionDisableTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPAInterspersedWithCollisionDisableTable", CheckPAInterspersedWithCollisionDisableTable_IsValid);
		CheckPAInterspersed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckPAInterspersed");
		CheckPAInterspersed_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckPAInterspersed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckPAInterspersed_PA_PropertyAddress, CheckPAInterspersed_FunctionAddress, "PA");
		CheckPAInterspersed_PA_Offset = NativeReflectionCached.GetPropertyOffset(CheckPAInterspersed_FunctionAddress, "PA");
		CheckPAInterspersed_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPAInterspersed_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckPAInterspersed_ReturnValue_PropertyAddress, CheckPAInterspersed_FunctionAddress, "ReturnValue");
		CheckPAInterspersed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckPAInterspersed_FunctionAddress, "ReturnValue");
		CheckPAInterspersed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPAInterspersed_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CheckPAInterspersed_IsValid = CheckPAInterspersed_FunctionAddress != IntPtr.Zero && CheckPAInterspersed_PA_IsValid && CheckPAInterspersed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPAInterspersed", CheckPAInterspersed_IsValid);
		CheckPAConstraintsChildParentError_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckPAConstraintsChildParentError");
		CheckPAConstraintsChildParentError_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckPAConstraintsChildParentError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckPAConstraintsChildParentError_PA_PropertyAddress, CheckPAConstraintsChildParentError_FunctionAddress, "PA");
		CheckPAConstraintsChildParentError_PA_Offset = NativeReflectionCached.GetPropertyOffset(CheckPAConstraintsChildParentError_FunctionAddress, "PA");
		CheckPAConstraintsChildParentError_PA_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPAConstraintsChildParentError_FunctionAddress, "PA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckPAConstraintsChildParentError_ReturnValue_PropertyAddress, CheckPAConstraintsChildParentError_FunctionAddress, "ReturnValue");
		CheckPAConstraintsChildParentError_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckPAConstraintsChildParentError_FunctionAddress, "ReturnValue");
		CheckPAConstraintsChildParentError_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPAConstraintsChildParentError_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CheckPAConstraintsChildParentError_IsValid = CheckPAConstraintsChildParentError_FunctionAddress != IntPtr.Zero && CheckPAConstraintsChildParentError_PA_IsValid && CheckPAConstraintsChildParentError_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:CheckPAConstraintsChildParentError", CheckPAConstraintsChildParentError_IsValid);
		AddVirtualBone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddVirtualBone");
		AddVirtualBone_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVirtualBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVirtualBone_Skeleton_PropertyAddress, AddVirtualBone_FunctionAddress, "Skeleton");
		AddVirtualBone_Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(AddVirtualBone_FunctionAddress, "Skeleton");
		AddVirtualBone_Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVirtualBone_FunctionAddress, "Skeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVirtualBone_SourceBoneName_PropertyAddress, AddVirtualBone_FunctionAddress, "SourceBoneName");
		AddVirtualBone_SourceBoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddVirtualBone_FunctionAddress, "SourceBoneName");
		AddVirtualBone_SourceBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVirtualBone_FunctionAddress, "SourceBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVirtualBone_TargetBoneName_PropertyAddress, AddVirtualBone_FunctionAddress, "TargetBoneName");
		AddVirtualBone_TargetBoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddVirtualBone_FunctionAddress, "TargetBoneName");
		AddVirtualBone_TargetBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVirtualBone_FunctionAddress, "TargetBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVirtualBone_VirtualBoneName_PropertyAddress, AddVirtualBone_FunctionAddress, "VirtualBoneName");
		AddVirtualBone_VirtualBoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddVirtualBone_FunctionAddress, "VirtualBoneName");
		AddVirtualBone_VirtualBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVirtualBone_FunctionAddress, "VirtualBoneName", Classes.FNameProperty);
		AddVirtualBone_IsValid = AddVirtualBone_FunctionAddress != IntPtr.Zero && AddVirtualBone_Skeleton_IsValid && AddVirtualBone_SourceBoneName_IsValid && AddVirtualBone_TargetBoneName_IsValid && AddVirtualBone_VirtualBoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:AddVirtualBone", AddVirtualBone_IsValid);
		AddNewSocketWithMeshSpaceTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddNewSocketWithMeshSpaceTransform");
		AddNewSocketWithMeshSpaceTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNewSocketWithMeshSpaceTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNewSocketWithMeshSpaceTransform_SKMesh_PropertyAddress, AddNewSocketWithMeshSpaceTransform_FunctionAddress, "SKMesh");
		AddNewSocketWithMeshSpaceTransform_SKMesh_Offset = NativeReflectionCached.GetPropertyOffset(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "SKMesh");
		AddNewSocketWithMeshSpaceTransform_SKMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "SKMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewSocketWithMeshSpaceTransform_SocketName_PropertyAddress, AddNewSocketWithMeshSpaceTransform_FunctionAddress, "SocketName");
		AddNewSocketWithMeshSpaceTransform_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "SocketName");
		AddNewSocketWithMeshSpaceTransform_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewSocketWithMeshSpaceTransform_BoneName_PropertyAddress, AddNewSocketWithMeshSpaceTransform_FunctionAddress, "BoneName");
		AddNewSocketWithMeshSpaceTransform_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "BoneName");
		AddNewSocketWithMeshSpaceTransform_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_PropertyAddress, AddNewSocketWithMeshSpaceTransform_FunctionAddress, "MeshSpaceTransform");
		AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "MeshSpaceTransform");
		AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "MeshSpaceTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewSocketWithMeshSpaceTransform_ReturnValue_PropertyAddress, AddNewSocketWithMeshSpaceTransform_FunctionAddress, "ReturnValue");
		AddNewSocketWithMeshSpaceTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "ReturnValue");
		AddNewSocketWithMeshSpaceTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewSocketWithMeshSpaceTransform_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AddNewSocketWithMeshSpaceTransform_IsValid = AddNewSocketWithMeshSpaceTransform_FunctionAddress != IntPtr.Zero && AddNewSocketWithMeshSpaceTransform_SKMesh_IsValid && AddNewSocketWithMeshSpaceTransform_SocketName_IsValid && AddNewSocketWithMeshSpaceTransform_BoneName_IsValid && AddNewSocketWithMeshSpaceTransform_MeshSpaceTransform_IsValid && AddNewSocketWithMeshSpaceTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSkeletalMeshLibrary:AddNewSocketWithMeshSpaceTransform", AddNewSocketWithMeshSpaceTransform_IsValid);
	}
}
