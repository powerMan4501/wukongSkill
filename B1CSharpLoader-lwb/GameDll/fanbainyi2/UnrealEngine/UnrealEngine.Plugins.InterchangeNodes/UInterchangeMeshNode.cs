using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeMeshNode : UInterchangeBaseNode
{
	private static bool SetSkinnedMesh_IsValid;

	private static IntPtr SetSkinnedMesh_FunctionAddress;

	private static int SetSkinnedMesh_ParamsSize;

	private static bool SetSkinnedMesh_bIsSkinnedMesh_IsValid;

	private static FFieldAddress SetSkinnedMesh_bIsSkinnedMesh_PropertyAddress;

	private static int SetSkinnedMesh_bIsSkinnedMesh_Offset;

	private static bool SetSkinnedMesh_ReturnValue_IsValid;

	private static FFieldAddress SetSkinnedMesh_ReturnValue_PropertyAddress;

	private static int SetSkinnedMesh_ReturnValue_Offset;

	private static bool SetSkeletonDependencyUid_IsValid;

	private static IntPtr SetSkeletonDependencyUid_FunctionAddress;

	private static int SetSkeletonDependencyUid_ParamsSize;

	private static bool SetSkeletonDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress SetSkeletonDependencyUid_DependencyUid_PropertyAddress;

	private static int SetSkeletonDependencyUid_DependencyUid_Offset;

	private static bool SetSkeletonDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress SetSkeletonDependencyUid_ReturnValue_PropertyAddress;

	private static int SetSkeletonDependencyUid_ReturnValue_Offset;

	private static bool SetShapeDependencyUid_IsValid;

	private static IntPtr SetShapeDependencyUid_FunctionAddress;

	private static int SetShapeDependencyUid_ParamsSize;

	private static bool SetShapeDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress SetShapeDependencyUid_DependencyUid_PropertyAddress;

	private static int SetShapeDependencyUid_DependencyUid_Offset;

	private static bool SetShapeDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress SetShapeDependencyUid_ReturnValue_PropertyAddress;

	private static int SetShapeDependencyUid_ReturnValue_Offset;

	private static bool SetSceneInstanceUid_IsValid;

	private static IntPtr SetSceneInstanceUid_FunctionAddress;

	private static int SetSceneInstanceUid_ParamsSize;

	private static bool SetSceneInstanceUid_DependencyUid_IsValid;

	private static FFieldAddress SetSceneInstanceUid_DependencyUid_PropertyAddress;

	private static int SetSceneInstanceUid_DependencyUid_Offset;

	private static bool SetSceneInstanceUid_ReturnValue_IsValid;

	private static FFieldAddress SetSceneInstanceUid_ReturnValue_PropertyAddress;

	private static int SetSceneInstanceUid_ReturnValue_Offset;

	private static bool SetPayLoadKey_IsValid;

	private static IntPtr SetPayLoadKey_FunctionAddress;

	private static int SetPayLoadKey_ParamsSize;

	private static bool SetPayLoadKey_PayloadKey_IsValid;

	private static FFieldAddress SetPayLoadKey_PayloadKey_PropertyAddress;

	private static int SetPayLoadKey_PayloadKey_Offset;

	private static bool SetMaterialDependencyUid_IsValid;

	private static IntPtr SetMaterialDependencyUid_FunctionAddress;

	private static int SetMaterialDependencyUid_ParamsSize;

	private static bool SetMaterialDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress SetMaterialDependencyUid_DependencyUid_PropertyAddress;

	private static int SetMaterialDependencyUid_DependencyUid_Offset;

	private static bool SetMaterialDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress SetMaterialDependencyUid_ReturnValue_PropertyAddress;

	private static int SetMaterialDependencyUid_ReturnValue_Offset;

	private static bool SetCustomVertexCount_IsValid;

	private static IntPtr SetCustomVertexCount_FunctionAddress;

	private static int SetCustomVertexCount_ParamsSize;

	private static bool SetCustomVertexCount_AttributeValue_IsValid;

	private static FFieldAddress SetCustomVertexCount_AttributeValue_PropertyAddress;

	private static int SetCustomVertexCount_AttributeValue_Offset;

	private static bool SetCustomVertexCount_ReturnValue_IsValid;

	private static FFieldAddress SetCustomVertexCount_ReturnValue_PropertyAddress;

	private static int SetCustomVertexCount_ReturnValue_Offset;

	private static bool SetCustomUVCount_IsValid;

	private static IntPtr SetCustomUVCount_FunctionAddress;

	private static int SetCustomUVCount_ParamsSize;

	private static bool SetCustomUVCount_AttributeValue_IsValid;

	private static FFieldAddress SetCustomUVCount_AttributeValue_PropertyAddress;

	private static int SetCustomUVCount_AttributeValue_Offset;

	private static bool SetCustomUVCount_ReturnValue_IsValid;

	private static FFieldAddress SetCustomUVCount_ReturnValue_PropertyAddress;

	private static int SetCustomUVCount_ReturnValue_Offset;

	private static bool SetCustomPolygonCount_IsValid;

	private static IntPtr SetCustomPolygonCount_FunctionAddress;

	private static int SetCustomPolygonCount_ParamsSize;

	private static bool SetCustomPolygonCount_AttributeValue_IsValid;

	private static FFieldAddress SetCustomPolygonCount_AttributeValue_PropertyAddress;

	private static int SetCustomPolygonCount_AttributeValue_Offset;

	private static bool SetCustomPolygonCount_ReturnValue_IsValid;

	private static FFieldAddress SetCustomPolygonCount_ReturnValue_PropertyAddress;

	private static int SetCustomPolygonCount_ReturnValue_Offset;

	private static bool SetCustomHasVertexTangent_IsValid;

	private static IntPtr SetCustomHasVertexTangent_FunctionAddress;

	private static int SetCustomHasVertexTangent_ParamsSize;

	private static bool SetCustomHasVertexTangent_AttributeValue_IsValid;

	private static FFieldAddress SetCustomHasVertexTangent_AttributeValue_PropertyAddress;

	private static int SetCustomHasVertexTangent_AttributeValue_Offset;

	private static bool SetCustomHasVertexTangent_ReturnValue_IsValid;

	private static FFieldAddress SetCustomHasVertexTangent_ReturnValue_PropertyAddress;

	private static int SetCustomHasVertexTangent_ReturnValue_Offset;

	private static bool SetCustomHasVertexNormal_IsValid;

	private static IntPtr SetCustomHasVertexNormal_FunctionAddress;

	private static int SetCustomHasVertexNormal_ParamsSize;

	private static bool SetCustomHasVertexNormal_AttributeValue_IsValid;

	private static FFieldAddress SetCustomHasVertexNormal_AttributeValue_PropertyAddress;

	private static int SetCustomHasVertexNormal_AttributeValue_Offset;

	private static bool SetCustomHasVertexNormal_ReturnValue_IsValid;

	private static FFieldAddress SetCustomHasVertexNormal_ReturnValue_PropertyAddress;

	private static int SetCustomHasVertexNormal_ReturnValue_Offset;

	private static bool SetCustomHasVertexColor_IsValid;

	private static IntPtr SetCustomHasVertexColor_FunctionAddress;

	private static int SetCustomHasVertexColor_ParamsSize;

	private static bool SetCustomHasVertexColor_AttributeValue_IsValid;

	private static FFieldAddress SetCustomHasVertexColor_AttributeValue_PropertyAddress;

	private static int SetCustomHasVertexColor_AttributeValue_Offset;

	private static bool SetCustomHasVertexColor_ReturnValue_IsValid;

	private static FFieldAddress SetCustomHasVertexColor_ReturnValue_PropertyAddress;

	private static int SetCustomHasVertexColor_ReturnValue_Offset;

	private static bool SetCustomHasVertexBinormal_IsValid;

	private static IntPtr SetCustomHasVertexBinormal_FunctionAddress;

	private static int SetCustomHasVertexBinormal_ParamsSize;

	private static bool SetCustomHasVertexBinormal_AttributeValue_IsValid;

	private static FFieldAddress SetCustomHasVertexBinormal_AttributeValue_PropertyAddress;

	private static int SetCustomHasVertexBinormal_AttributeValue_Offset;

	private static bool SetCustomHasVertexBinormal_ReturnValue_IsValid;

	private static FFieldAddress SetCustomHasVertexBinormal_ReturnValue_PropertyAddress;

	private static int SetCustomHasVertexBinormal_ReturnValue_Offset;

	private static bool SetCustomHasSmoothGroup_IsValid;

	private static IntPtr SetCustomHasSmoothGroup_FunctionAddress;

	private static int SetCustomHasSmoothGroup_ParamsSize;

	private static bool SetCustomHasSmoothGroup_AttributeValue_IsValid;

	private static FFieldAddress SetCustomHasSmoothGroup_AttributeValue_PropertyAddress;

	private static int SetCustomHasSmoothGroup_AttributeValue_Offset;

	private static bool SetCustomHasSmoothGroup_ReturnValue_IsValid;

	private static FFieldAddress SetCustomHasSmoothGroup_ReturnValue_PropertyAddress;

	private static int SetCustomHasSmoothGroup_ReturnValue_Offset;

	private static bool SetCustomBoundingBox_IsValid;

	private static IntPtr SetCustomBoundingBox_FunctionAddress;

	private static int SetCustomBoundingBox_ParamsSize;

	private static bool SetCustomBoundingBox_AttributeValue_IsValid;

	private static FFieldAddress SetCustomBoundingBox_AttributeValue_PropertyAddress;

	private static int SetCustomBoundingBox_AttributeValue_Offset;

	private static bool SetCustomBoundingBox_ReturnValue_IsValid;

	private static FFieldAddress SetCustomBoundingBox_ReturnValue_PropertyAddress;

	private static int SetCustomBoundingBox_ReturnValue_Offset;

	private static bool SetBlendShapeName_IsValid;

	private static IntPtr SetBlendShapeName_FunctionAddress;

	private static int SetBlendShapeName_ParamsSize;

	private static bool SetBlendShapeName_BlendShapeName_IsValid;

	private static FFieldAddress SetBlendShapeName_BlendShapeName_PropertyAddress;

	private static int SetBlendShapeName_BlendShapeName_Offset;

	private static bool SetBlendShapeName_ReturnValue_IsValid;

	private static FFieldAddress SetBlendShapeName_ReturnValue_PropertyAddress;

	private static int SetBlendShapeName_ReturnValue_Offset;

	private static bool SetBlendShape_IsValid;

	private static IntPtr SetBlendShape_FunctionAddress;

	private static int SetBlendShape_ParamsSize;

	private static bool SetBlendShape_bIsBlendShape_IsValid;

	private static FFieldAddress SetBlendShape_bIsBlendShape_PropertyAddress;

	private static int SetBlendShape_bIsBlendShape_Offset;

	private static bool SetBlendShape_ReturnValue_IsValid;

	private static FFieldAddress SetBlendShape_ReturnValue_PropertyAddress;

	private static int SetBlendShape_ReturnValue_Offset;

	private static bool RemoveSkeletonDependencyUid_IsValid;

	private static IntPtr RemoveSkeletonDependencyUid_FunctionAddress;

	private static int RemoveSkeletonDependencyUid_ParamsSize;

	private static bool RemoveSkeletonDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress RemoveSkeletonDependencyUid_DependencyUid_PropertyAddress;

	private static int RemoveSkeletonDependencyUid_DependencyUid_Offset;

	private static bool RemoveSkeletonDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveSkeletonDependencyUid_ReturnValue_PropertyAddress;

	private static int RemoveSkeletonDependencyUid_ReturnValue_Offset;

	private static bool RemoveShapeDependencyUid_IsValid;

	private static IntPtr RemoveShapeDependencyUid_FunctionAddress;

	private static int RemoveShapeDependencyUid_ParamsSize;

	private static bool RemoveShapeDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress RemoveShapeDependencyUid_DependencyUid_PropertyAddress;

	private static int RemoveShapeDependencyUid_DependencyUid_Offset;

	private static bool RemoveShapeDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveShapeDependencyUid_ReturnValue_PropertyAddress;

	private static int RemoveShapeDependencyUid_ReturnValue_Offset;

	private static bool RemoveSceneInstanceUid_IsValid;

	private static IntPtr RemoveSceneInstanceUid_FunctionAddress;

	private static int RemoveSceneInstanceUid_ParamsSize;

	private static bool RemoveSceneInstanceUid_DependencyUid_IsValid;

	private static FFieldAddress RemoveSceneInstanceUid_DependencyUid_PropertyAddress;

	private static int RemoveSceneInstanceUid_DependencyUid_Offset;

	private static bool RemoveSceneInstanceUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveSceneInstanceUid_ReturnValue_PropertyAddress;

	private static int RemoveSceneInstanceUid_ReturnValue_Offset;

	private static bool RemoveMaterialDependencyUid_IsValid;

	private static IntPtr RemoveMaterialDependencyUid_FunctionAddress;

	private static int RemoveMaterialDependencyUid_ParamsSize;

	private static bool RemoveMaterialDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress RemoveMaterialDependencyUid_DependencyUid_PropertyAddress;

	private static int RemoveMaterialDependencyUid_DependencyUid_Offset;

	private static bool RemoveMaterialDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveMaterialDependencyUid_ReturnValue_PropertyAddress;

	private static int RemoveMaterialDependencyUid_ReturnValue_Offset;

	private static bool IsSkinnedMesh_IsValid;

	private static IntPtr IsSkinnedMesh_FunctionAddress;

	private static int IsSkinnedMesh_ParamsSize;

	private static bool IsSkinnedMesh_ReturnValue_IsValid;

	private static FFieldAddress IsSkinnedMesh_ReturnValue_PropertyAddress;

	private static int IsSkinnedMesh_ReturnValue_Offset;

	private static bool IsBlendShape_IsValid;

	private static IntPtr IsBlendShape_FunctionAddress;

	private static int IsBlendShape_ParamsSize;

	private static bool IsBlendShape_ReturnValue_IsValid;

	private static FFieldAddress IsBlendShape_ReturnValue_PropertyAddress;

	private static int IsBlendShape_ReturnValue_Offset;

	private static bool GetSkeletonDependency_IsValid;

	private static IntPtr GetSkeletonDependency_FunctionAddress;

	private static int GetSkeletonDependency_ParamsSize;

	private static bool GetSkeletonDependency_Index_IsValid;

	private static FFieldAddress GetSkeletonDependency_Index_PropertyAddress;

	private static int GetSkeletonDependency_Index_Offset;

	private static bool GetSkeletonDependency_OutDependency_IsValid;

	private static FFieldAddress GetSkeletonDependency_OutDependency_PropertyAddress;

	private static int GetSkeletonDependency_OutDependency_Offset;

	private static bool GetSkeletonDependencies_IsValid;

	private static IntPtr GetSkeletonDependencies_FunctionAddress;

	private static int GetSkeletonDependencies_ParamsSize;

	private static bool GetSkeletonDependencies_OutDependencies_IsValid;

	private static FFieldAddress GetSkeletonDependencies_OutDependencies_PropertyAddress;

	private static int GetSkeletonDependencies_OutDependencies_Offset;

	private static bool GetSkeletonDependeciesCount_IsValid;

	private static IntPtr GetSkeletonDependeciesCount_FunctionAddress;

	private static int GetSkeletonDependeciesCount_ParamsSize;

	private static bool GetSkeletonDependeciesCount_ReturnValue_IsValid;

	private static FFieldAddress GetSkeletonDependeciesCount_ReturnValue_PropertyAddress;

	private static int GetSkeletonDependeciesCount_ReturnValue_Offset;

	private static bool GetShapeDependency_IsValid;

	private static IntPtr GetShapeDependency_FunctionAddress;

	private static int GetShapeDependency_ParamsSize;

	private static bool GetShapeDependency_Index_IsValid;

	private static FFieldAddress GetShapeDependency_Index_PropertyAddress;

	private static int GetShapeDependency_Index_Offset;

	private static bool GetShapeDependency_OutDependency_IsValid;

	private static FFieldAddress GetShapeDependency_OutDependency_PropertyAddress;

	private static int GetShapeDependency_OutDependency_Offset;

	private static bool GetShapeDependencies_IsValid;

	private static IntPtr GetShapeDependencies_FunctionAddress;

	private static int GetShapeDependencies_ParamsSize;

	private static bool GetShapeDependencies_OutDependencies_IsValid;

	private static FFieldAddress GetShapeDependencies_OutDependencies_PropertyAddress;

	private static int GetShapeDependencies_OutDependencies_Offset;

	private static bool GetShapeDependeciesCount_IsValid;

	private static IntPtr GetShapeDependeciesCount_FunctionAddress;

	private static int GetShapeDependeciesCount_ParamsSize;

	private static bool GetShapeDependeciesCount_ReturnValue_IsValid;

	private static FFieldAddress GetShapeDependeciesCount_ReturnValue_PropertyAddress;

	private static int GetShapeDependeciesCount_ReturnValue_Offset;

	private static bool GetSceneInstanceUidsCount_IsValid;

	private static IntPtr GetSceneInstanceUidsCount_FunctionAddress;

	private static int GetSceneInstanceUidsCount_ParamsSize;

	private static bool GetSceneInstanceUidsCount_ReturnValue_IsValid;

	private static FFieldAddress GetSceneInstanceUidsCount_ReturnValue_PropertyAddress;

	private static int GetSceneInstanceUidsCount_ReturnValue_Offset;

	private static bool GetSceneInstanceUids_IsValid;

	private static IntPtr GetSceneInstanceUids_FunctionAddress;

	private static int GetSceneInstanceUids_ParamsSize;

	private static bool GetSceneInstanceUids_OutDependencies_IsValid;

	private static FFieldAddress GetSceneInstanceUids_OutDependencies_PropertyAddress;

	private static int GetSceneInstanceUids_OutDependencies_Offset;

	private static bool GetSceneInstanceUid_IsValid;

	private static IntPtr GetSceneInstanceUid_FunctionAddress;

	private static int GetSceneInstanceUid_ParamsSize;

	private static bool GetSceneInstanceUid_Index_IsValid;

	private static FFieldAddress GetSceneInstanceUid_Index_PropertyAddress;

	private static int GetSceneInstanceUid_Index_Offset;

	private static bool GetSceneInstanceUid_OutDependency_IsValid;

	private static FFieldAddress GetSceneInstanceUid_OutDependency_PropertyAddress;

	private static int GetSceneInstanceUid_OutDependency_Offset;

	private static bool GetMaterialDependency_IsValid;

	private static IntPtr GetMaterialDependency_FunctionAddress;

	private static int GetMaterialDependency_ParamsSize;

	private static bool GetMaterialDependency_Index_IsValid;

	private static FFieldAddress GetMaterialDependency_Index_PropertyAddress;

	private static int GetMaterialDependency_Index_Offset;

	private static bool GetMaterialDependency_OutDependency_IsValid;

	private static FFieldAddress GetMaterialDependency_OutDependency_PropertyAddress;

	private static int GetMaterialDependency_OutDependency_Offset;

	private static bool GetMaterialDependencies_IsValid;

	private static IntPtr GetMaterialDependencies_FunctionAddress;

	private static int GetMaterialDependencies_ParamsSize;

	private static bool GetMaterialDependencies_OutDependencies_IsValid;

	private static FFieldAddress GetMaterialDependencies_OutDependencies_PropertyAddress;

	private static int GetMaterialDependencies_OutDependencies_Offset;

	private static bool GetMaterialDependeciesCount_IsValid;

	private static IntPtr GetMaterialDependeciesCount_FunctionAddress;

	private static int GetMaterialDependeciesCount_ParamsSize;

	private static bool GetMaterialDependeciesCount_ReturnValue_IsValid;

	private static FFieldAddress GetMaterialDependeciesCount_ReturnValue_PropertyAddress;

	private static int GetMaterialDependeciesCount_ReturnValue_Offset;

	private static bool GetCustomVertexCount_IsValid;

	private static IntPtr GetCustomVertexCount_FunctionAddress;

	private static int GetCustomVertexCount_ParamsSize;

	private static bool GetCustomVertexCount_AttributeValue_IsValid;

	private static FFieldAddress GetCustomVertexCount_AttributeValue_PropertyAddress;

	private static int GetCustomVertexCount_AttributeValue_Offset;

	private static bool GetCustomVertexCount_ReturnValue_IsValid;

	private static FFieldAddress GetCustomVertexCount_ReturnValue_PropertyAddress;

	private static int GetCustomVertexCount_ReturnValue_Offset;

	private static bool GetCustomUVCount_IsValid;

	private static IntPtr GetCustomUVCount_FunctionAddress;

	private static int GetCustomUVCount_ParamsSize;

	private static bool GetCustomUVCount_AttributeValue_IsValid;

	private static FFieldAddress GetCustomUVCount_AttributeValue_PropertyAddress;

	private static int GetCustomUVCount_AttributeValue_Offset;

	private static bool GetCustomUVCount_ReturnValue_IsValid;

	private static FFieldAddress GetCustomUVCount_ReturnValue_PropertyAddress;

	private static int GetCustomUVCount_ReturnValue_Offset;

	private static bool GetCustomPolygonCount_IsValid;

	private static IntPtr GetCustomPolygonCount_FunctionAddress;

	private static int GetCustomPolygonCount_ParamsSize;

	private static bool GetCustomPolygonCount_AttributeValue_IsValid;

	private static FFieldAddress GetCustomPolygonCount_AttributeValue_PropertyAddress;

	private static int GetCustomPolygonCount_AttributeValue_Offset;

	private static bool GetCustomPolygonCount_ReturnValue_IsValid;

	private static FFieldAddress GetCustomPolygonCount_ReturnValue_PropertyAddress;

	private static int GetCustomPolygonCount_ReturnValue_Offset;

	private static bool GetCustomHasVertexTangent_IsValid;

	private static IntPtr GetCustomHasVertexTangent_FunctionAddress;

	private static int GetCustomHasVertexTangent_ParamsSize;

	private static bool GetCustomHasVertexTangent_AttributeValue_IsValid;

	private static FFieldAddress GetCustomHasVertexTangent_AttributeValue_PropertyAddress;

	private static int GetCustomHasVertexTangent_AttributeValue_Offset;

	private static bool GetCustomHasVertexTangent_ReturnValue_IsValid;

	private static FFieldAddress GetCustomHasVertexTangent_ReturnValue_PropertyAddress;

	private static int GetCustomHasVertexTangent_ReturnValue_Offset;

	private static bool GetCustomHasVertexNormal_IsValid;

	private static IntPtr GetCustomHasVertexNormal_FunctionAddress;

	private static int GetCustomHasVertexNormal_ParamsSize;

	private static bool GetCustomHasVertexNormal_AttributeValue_IsValid;

	private static FFieldAddress GetCustomHasVertexNormal_AttributeValue_PropertyAddress;

	private static int GetCustomHasVertexNormal_AttributeValue_Offset;

	private static bool GetCustomHasVertexNormal_ReturnValue_IsValid;

	private static FFieldAddress GetCustomHasVertexNormal_ReturnValue_PropertyAddress;

	private static int GetCustomHasVertexNormal_ReturnValue_Offset;

	private static bool GetCustomHasVertexColor_IsValid;

	private static IntPtr GetCustomHasVertexColor_FunctionAddress;

	private static int GetCustomHasVertexColor_ParamsSize;

	private static bool GetCustomHasVertexColor_AttributeValue_IsValid;

	private static FFieldAddress GetCustomHasVertexColor_AttributeValue_PropertyAddress;

	private static int GetCustomHasVertexColor_AttributeValue_Offset;

	private static bool GetCustomHasVertexColor_ReturnValue_IsValid;

	private static FFieldAddress GetCustomHasVertexColor_ReturnValue_PropertyAddress;

	private static int GetCustomHasVertexColor_ReturnValue_Offset;

	private static bool GetCustomHasVertexBinormal_IsValid;

	private static IntPtr GetCustomHasVertexBinormal_FunctionAddress;

	private static int GetCustomHasVertexBinormal_ParamsSize;

	private static bool GetCustomHasVertexBinormal_AttributeValue_IsValid;

	private static FFieldAddress GetCustomHasVertexBinormal_AttributeValue_PropertyAddress;

	private static int GetCustomHasVertexBinormal_AttributeValue_Offset;

	private static bool GetCustomHasVertexBinormal_ReturnValue_IsValid;

	private static FFieldAddress GetCustomHasVertexBinormal_ReturnValue_PropertyAddress;

	private static int GetCustomHasVertexBinormal_ReturnValue_Offset;

	private static bool GetCustomHasSmoothGroup_IsValid;

	private static IntPtr GetCustomHasSmoothGroup_FunctionAddress;

	private static int GetCustomHasSmoothGroup_ParamsSize;

	private static bool GetCustomHasSmoothGroup_AttributeValue_IsValid;

	private static FFieldAddress GetCustomHasSmoothGroup_AttributeValue_PropertyAddress;

	private static int GetCustomHasSmoothGroup_AttributeValue_Offset;

	private static bool GetCustomHasSmoothGroup_ReturnValue_IsValid;

	private static FFieldAddress GetCustomHasSmoothGroup_ReturnValue_PropertyAddress;

	private static int GetCustomHasSmoothGroup_ReturnValue_Offset;

	private static bool GetCustomBoundingBox_IsValid;

	private static IntPtr GetCustomBoundingBox_FunctionAddress;

	private static int GetCustomBoundingBox_ParamsSize;

	private static bool GetCustomBoundingBox_AttributeValue_IsValid;

	private static FFieldAddress GetCustomBoundingBox_AttributeValue_PropertyAddress;

	private static int GetCustomBoundingBox_AttributeValue_Offset;

	private static bool GetCustomBoundingBox_ReturnValue_IsValid;

	private static FFieldAddress GetCustomBoundingBox_ReturnValue_PropertyAddress;

	private static int GetCustomBoundingBox_ReturnValue_Offset;

	private static bool GetBlendShapeName_IsValid;

	private static IntPtr GetBlendShapeName_FunctionAddress;

	private static int GetBlendShapeName_ParamsSize;

	private static bool GetBlendShapeName_OutBlendShapeName_IsValid;

	private static FFieldAddress GetBlendShapeName_OutBlendShapeName_PropertyAddress;

	private static int GetBlendShapeName_OutBlendShapeName_Offset;

	private static bool GetBlendShapeName_ReturnValue_IsValid;

	private static FFieldAddress GetBlendShapeName_ReturnValue_PropertyAddress;

	private static int GetBlendShapeName_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetSkinnedMesh")]
	public unsafe bool SetSkinnedMesh(bool bIsSkinnedMesh)
	{
		CheckDestroyed();
		if (!SetSkinnedMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetSkinnedMesh");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkinnedMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkinnedMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSkinnedMesh_bIsSkinnedMesh_Offset), 0, SetSkinnedMesh_bIsSkinnedMesh_PropertyAddress.Address, bIsSkinnedMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkinnedMesh_FunctionAddress, intPtr, SetSkinnedMesh_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSkinnedMesh_ReturnValue_Offset), 0, SetSkinnedMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetSkeletonDependencyUid")]
	public unsafe bool SetSkeletonDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!SetSkeletonDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetSkeletonDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkeletonDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkeletonDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSkeletonDependencyUid_DependencyUid_Offset), 0, SetSkeletonDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkeletonDependencyUid_FunctionAddress, intPtr, SetSkeletonDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSkeletonDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSkeletonDependencyUid_ReturnValue_Offset), 0, SetSkeletonDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetShapeDependencyUid")]
	public unsafe bool SetShapeDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!SetShapeDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetShapeDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShapeDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShapeDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetShapeDependencyUid_DependencyUid_Offset), 0, SetShapeDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShapeDependencyUid_FunctionAddress, intPtr, SetShapeDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetShapeDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetShapeDependencyUid_ReturnValue_Offset), 0, SetShapeDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetSceneInstanceUid")]
	public unsafe bool SetSceneInstanceUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!SetSceneInstanceUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetSceneInstanceUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSceneInstanceUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSceneInstanceUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSceneInstanceUid_DependencyUid_Offset), 0, SetSceneInstanceUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSceneInstanceUid_FunctionAddress, intPtr, SetSceneInstanceUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSceneInstanceUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSceneInstanceUid_ReturnValue_Offset), 0, SetSceneInstanceUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetPayLoadKey")]
	public unsafe void SetPayLoadKey(string PayloadKey)
	{
		CheckDestroyed();
		if (!SetPayLoadKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetPayLoadKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPayLoadKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPayLoadKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPayLoadKey_PayloadKey_Offset), 0, SetPayLoadKey_PayloadKey_PropertyAddress.Address, PayloadKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPayLoadKey_FunctionAddress, intPtr, SetPayLoadKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPayLoadKey_PayloadKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetMaterialDependencyUid")]
	public unsafe bool SetMaterialDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!SetMaterialDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetMaterialDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterialDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterialDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMaterialDependencyUid_DependencyUid_Offset), 0, SetMaterialDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterialDependencyUid_FunctionAddress, intPtr, SetMaterialDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMaterialDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMaterialDependencyUid_ReturnValue_Offset), 0, SetMaterialDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomVertexCount")]
	public unsafe bool SetCustomVertexCount(int AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomVertexCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomVertexCount");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomVertexCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomVertexCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomVertexCount_AttributeValue_Offset), 0, SetCustomVertexCount_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomVertexCount_FunctionAddress, intPtr, SetCustomVertexCount_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomVertexCount_ReturnValue_Offset), 0, SetCustomVertexCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomUVCount")]
	public unsafe bool SetCustomUVCount(int AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomUVCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomUVCount");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomUVCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomUVCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomUVCount_AttributeValue_Offset), 0, SetCustomUVCount_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomUVCount_FunctionAddress, intPtr, SetCustomUVCount_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomUVCount_ReturnValue_Offset), 0, SetCustomUVCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomPolygonCount")]
	public unsafe bool SetCustomPolygonCount(int AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomPolygonCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomPolygonCount");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomPolygonCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomPolygonCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomPolygonCount_AttributeValue_Offset), 0, SetCustomPolygonCount_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomPolygonCount_FunctionAddress, intPtr, SetCustomPolygonCount_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomPolygonCount_ReturnValue_Offset), 0, SetCustomPolygonCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexTangent")]
	public unsafe bool SetCustomHasVertexTangent(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomHasVertexTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexTangent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomHasVertexTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomHasVertexTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomHasVertexTangent_AttributeValue_Offset), 0, SetCustomHasVertexTangent_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomHasVertexTangent_FunctionAddress, intPtr, SetCustomHasVertexTangent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomHasVertexTangent_ReturnValue_Offset), 0, SetCustomHasVertexTangent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexNormal")]
	public unsafe bool SetCustomHasVertexNormal(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomHasVertexNormal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexNormal");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomHasVertexNormal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomHasVertexNormal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomHasVertexNormal_AttributeValue_Offset), 0, SetCustomHasVertexNormal_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomHasVertexNormal_FunctionAddress, intPtr, SetCustomHasVertexNormal_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomHasVertexNormal_ReturnValue_Offset), 0, SetCustomHasVertexNormal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexColor")]
	public unsafe bool SetCustomHasVertexColor(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomHasVertexColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexColor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomHasVertexColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomHasVertexColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomHasVertexColor_AttributeValue_Offset), 0, SetCustomHasVertexColor_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomHasVertexColor_FunctionAddress, intPtr, SetCustomHasVertexColor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomHasVertexColor_ReturnValue_Offset), 0, SetCustomHasVertexColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexBinormal")]
	public unsafe bool SetCustomHasVertexBinormal(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomHasVertexBinormal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexBinormal");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomHasVertexBinormal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomHasVertexBinormal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomHasVertexBinormal_AttributeValue_Offset), 0, SetCustomHasVertexBinormal_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomHasVertexBinormal_FunctionAddress, intPtr, SetCustomHasVertexBinormal_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomHasVertexBinormal_ReturnValue_Offset), 0, SetCustomHasVertexBinormal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasSmoothGroup")]
	public unsafe bool SetCustomHasSmoothGroup(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomHasSmoothGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasSmoothGroup");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomHasSmoothGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomHasSmoothGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomHasSmoothGroup_AttributeValue_Offset), 0, SetCustomHasSmoothGroup_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomHasSmoothGroup_FunctionAddress, intPtr, SetCustomHasSmoothGroup_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomHasSmoothGroup_ReturnValue_Offset), 0, SetCustomHasSmoothGroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomBoundingBox")]
	public unsafe bool SetCustomBoundingBox(FBox AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomBoundingBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomBoundingBox");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomBoundingBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomBoundingBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, SetCustomBoundingBox_AttributeValue_Offset), 0, SetCustomBoundingBox_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomBoundingBox_FunctionAddress, intPtr, SetCustomBoundingBox_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomBoundingBox_ReturnValue_Offset), 0, SetCustomBoundingBox_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetBlendShapeName")]
	public unsafe bool SetBlendShapeName(string BlendShapeName)
	{
		CheckDestroyed();
		if (!SetBlendShapeName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetBlendShapeName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlendShapeName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlendShapeName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBlendShapeName_BlendShapeName_Offset), 0, SetBlendShapeName_BlendShapeName_PropertyAddress.Address, BlendShapeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBlendShapeName_FunctionAddress, intPtr, SetBlendShapeName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlendShapeName_BlendShapeName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetBlendShapeName_ReturnValue_Offset), 0, SetBlendShapeName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:SetBlendShape")]
	public unsafe bool SetBlendShape(bool bIsBlendShape)
	{
		CheckDestroyed();
		if (!SetBlendShape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:SetBlendShape");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlendShape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlendShape_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBlendShape_bIsBlendShape_Offset), 0, SetBlendShape_bIsBlendShape_PropertyAddress.Address, bIsBlendShape);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBlendShape_FunctionAddress, intPtr, SetBlendShape_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetBlendShape_ReturnValue_Offset), 0, SetBlendShape_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:RemoveSkeletonDependencyUid")]
	public unsafe bool RemoveSkeletonDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!RemoveSkeletonDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:RemoveSkeletonDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSkeletonDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSkeletonDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveSkeletonDependencyUid_DependencyUid_Offset), 0, RemoveSkeletonDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveSkeletonDependencyUid_FunctionAddress, intPtr, RemoveSkeletonDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveSkeletonDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveSkeletonDependencyUid_ReturnValue_Offset), 0, RemoveSkeletonDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:RemoveShapeDependencyUid")]
	public unsafe bool RemoveShapeDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!RemoveShapeDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:RemoveShapeDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveShapeDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveShapeDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveShapeDependencyUid_DependencyUid_Offset), 0, RemoveShapeDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveShapeDependencyUid_FunctionAddress, intPtr, RemoveShapeDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveShapeDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveShapeDependencyUid_ReturnValue_Offset), 0, RemoveShapeDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:RemoveSceneInstanceUid")]
	public unsafe bool RemoveSceneInstanceUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!RemoveSceneInstanceUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:RemoveSceneInstanceUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSceneInstanceUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSceneInstanceUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveSceneInstanceUid_DependencyUid_Offset), 0, RemoveSceneInstanceUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveSceneInstanceUid_FunctionAddress, intPtr, RemoveSceneInstanceUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveSceneInstanceUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveSceneInstanceUid_ReturnValue_Offset), 0, RemoveSceneInstanceUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:RemoveMaterialDependencyUid")]
	public unsafe bool RemoveMaterialDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!RemoveMaterialDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:RemoveMaterialDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMaterialDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMaterialDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveMaterialDependencyUid_DependencyUid_Offset), 0, RemoveMaterialDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveMaterialDependencyUid_FunctionAddress, intPtr, RemoveMaterialDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveMaterialDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveMaterialDependencyUid_ReturnValue_Offset), 0, RemoveMaterialDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:IsSkinnedMesh")]
	public unsafe bool IsSkinnedMesh()
	{
		CheckDestroyed();
		if (!IsSkinnedMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:IsSkinnedMesh");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSkinnedMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSkinnedMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSkinnedMesh_FunctionAddress, intPtr, IsSkinnedMesh_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSkinnedMesh_ReturnValue_Offset), 0, IsSkinnedMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:IsBlendShape")]
	public unsafe bool IsBlendShape()
	{
		CheckDestroyed();
		if (!IsBlendShape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:IsBlendShape");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBlendShape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBlendShape_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBlendShape_FunctionAddress, intPtr, IsBlendShape_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBlendShape_ReturnValue_Offset), 0, IsBlendShape_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetSkeletonDependency")]
	public unsafe void GetSkeletonDependency(int Index, out string OutDependency)
	{
		CheckDestroyed();
		if (!GetSkeletonDependency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetSkeletonDependency");
			OutDependency = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletonDependency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletonDependency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSkeletonDependency_Index_Offset), 0, GetSkeletonDependency_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSkeletonDependency_FunctionAddress, intPtr, GetSkeletonDependency_ParamsSize);
		OutDependency = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSkeletonDependency_OutDependency_Offset), 0, GetSkeletonDependency_OutDependency_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSkeletonDependency_OutDependency_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetSkeletonDependencies")]
	public unsafe void GetSkeletonDependencies(out List<string> OutDependencies)
	{
		CheckDestroyed();
		if (!GetSkeletonDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetSkeletonDependencies");
			OutDependencies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletonDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletonDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSkeletonDependencies_FunctionAddress, intPtr, GetSkeletonDependencies_ParamsSize);
		OutDependencies = new TArrayCopyMarshaler<string>(1, GetSkeletonDependencies_OutDependencies_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetSkeletonDependencies_OutDependencies_Offset));
		NativeReflection.DestroyValue_InContainer(GetSkeletonDependencies_OutDependencies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetSkeletonDependeciesCount")]
	public unsafe int GetSkeletonDependeciesCount()
	{
		CheckDestroyed();
		if (!GetSkeletonDependeciesCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetSkeletonDependeciesCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeletonDependeciesCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeletonDependeciesCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSkeletonDependeciesCount_FunctionAddress, intPtr, GetSkeletonDependeciesCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSkeletonDependeciesCount_ReturnValue_Offset), 0, GetSkeletonDependeciesCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetShapeDependency")]
	public unsafe void GetShapeDependency(int Index, out string OutDependency)
	{
		CheckDestroyed();
		if (!GetShapeDependency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetShapeDependency");
			OutDependency = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShapeDependency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShapeDependency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetShapeDependency_Index_Offset), 0, GetShapeDependency_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShapeDependency_FunctionAddress, intPtr, GetShapeDependency_ParamsSize);
		OutDependency = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetShapeDependency_OutDependency_Offset), 0, GetShapeDependency_OutDependency_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetShapeDependency_OutDependency_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetShapeDependencies")]
	public unsafe void GetShapeDependencies(out List<string> OutDependencies)
	{
		CheckDestroyed();
		if (!GetShapeDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetShapeDependencies");
			OutDependencies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShapeDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShapeDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShapeDependencies_FunctionAddress, intPtr, GetShapeDependencies_ParamsSize);
		OutDependencies = new TArrayCopyMarshaler<string>(1, GetShapeDependencies_OutDependencies_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetShapeDependencies_OutDependencies_Offset));
		NativeReflection.DestroyValue_InContainer(GetShapeDependencies_OutDependencies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetShapeDependeciesCount")]
	public unsafe int GetShapeDependeciesCount()
	{
		CheckDestroyed();
		if (!GetShapeDependeciesCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetShapeDependeciesCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShapeDependeciesCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShapeDependeciesCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShapeDependeciesCount_FunctionAddress, intPtr, GetShapeDependeciesCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetShapeDependeciesCount_ReturnValue_Offset), 0, GetShapeDependeciesCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetSceneInstanceUidsCount")]
	public unsafe int GetSceneInstanceUidsCount()
	{
		CheckDestroyed();
		if (!GetSceneInstanceUidsCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetSceneInstanceUidsCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSceneInstanceUidsCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSceneInstanceUidsCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSceneInstanceUidsCount_FunctionAddress, intPtr, GetSceneInstanceUidsCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSceneInstanceUidsCount_ReturnValue_Offset), 0, GetSceneInstanceUidsCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetSceneInstanceUids")]
	public unsafe void GetSceneInstanceUids(out List<string> OutDependencies)
	{
		CheckDestroyed();
		if (!GetSceneInstanceUids_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetSceneInstanceUids");
			OutDependencies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSceneInstanceUids_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSceneInstanceUids_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSceneInstanceUids_FunctionAddress, intPtr, GetSceneInstanceUids_ParamsSize);
		OutDependencies = new TArrayCopyMarshaler<string>(1, GetSceneInstanceUids_OutDependencies_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetSceneInstanceUids_OutDependencies_Offset));
		NativeReflection.DestroyValue_InContainer(GetSceneInstanceUids_OutDependencies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetSceneInstanceUid")]
	public unsafe void GetSceneInstanceUid(int Index, out string OutDependency)
	{
		CheckDestroyed();
		if (!GetSceneInstanceUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetSceneInstanceUid");
			OutDependency = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSceneInstanceUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSceneInstanceUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSceneInstanceUid_Index_Offset), 0, GetSceneInstanceUid_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSceneInstanceUid_FunctionAddress, intPtr, GetSceneInstanceUid_ParamsSize);
		OutDependency = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSceneInstanceUid_OutDependency_Offset), 0, GetSceneInstanceUid_OutDependency_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSceneInstanceUid_OutDependency_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetMaterialDependency")]
	public unsafe void GetMaterialDependency(int Index, out string OutDependency)
	{
		CheckDestroyed();
		if (!GetMaterialDependency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetMaterialDependency");
			OutDependency = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialDependency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialDependency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMaterialDependency_Index_Offset), 0, GetMaterialDependency_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialDependency_FunctionAddress, intPtr, GetMaterialDependency_ParamsSize);
		OutDependency = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMaterialDependency_OutDependency_Offset), 0, GetMaterialDependency_OutDependency_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMaterialDependency_OutDependency_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetMaterialDependencies")]
	public unsafe void GetMaterialDependencies(out List<string> OutDependencies)
	{
		CheckDestroyed();
		if (!GetMaterialDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetMaterialDependencies");
			OutDependencies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialDependencies_FunctionAddress, intPtr, GetMaterialDependencies_ParamsSize);
		OutDependencies = new TArrayCopyMarshaler<string>(1, GetMaterialDependencies_OutDependencies_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetMaterialDependencies_OutDependencies_Offset));
		NativeReflection.DestroyValue_InContainer(GetMaterialDependencies_OutDependencies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetMaterialDependeciesCount")]
	public unsafe int GetMaterialDependeciesCount()
	{
		CheckDestroyed();
		if (!GetMaterialDependeciesCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetMaterialDependeciesCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialDependeciesCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialDependeciesCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialDependeciesCount_FunctionAddress, intPtr, GetMaterialDependeciesCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaterialDependeciesCount_ReturnValue_Offset), 0, GetMaterialDependeciesCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomVertexCount")]
	public unsafe bool GetCustomVertexCount(out int AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomVertexCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomVertexCount");
			AttributeValue = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomVertexCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomVertexCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomVertexCount_FunctionAddress, intPtr, GetCustomVertexCount_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCustomVertexCount_AttributeValue_Offset), 0, GetCustomVertexCount_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomVertexCount_ReturnValue_Offset), 0, GetCustomVertexCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomUVCount")]
	public unsafe bool GetCustomUVCount(out int AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomUVCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomUVCount");
			AttributeValue = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomUVCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomUVCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomUVCount_FunctionAddress, intPtr, GetCustomUVCount_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCustomUVCount_AttributeValue_Offset), 0, GetCustomUVCount_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomUVCount_ReturnValue_Offset), 0, GetCustomUVCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomPolygonCount")]
	public unsafe bool GetCustomPolygonCount(out int AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomPolygonCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomPolygonCount");
			AttributeValue = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomPolygonCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomPolygonCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomPolygonCount_FunctionAddress, intPtr, GetCustomPolygonCount_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCustomPolygonCount_AttributeValue_Offset), 0, GetCustomPolygonCount_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomPolygonCount_ReturnValue_Offset), 0, GetCustomPolygonCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexTangent")]
	public unsafe bool GetCustomHasVertexTangent(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomHasVertexTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexTangent");
			AttributeValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomHasVertexTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomHasVertexTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomHasVertexTangent_FunctionAddress, intPtr, GetCustomHasVertexTangent_ParamsSize);
		AttributeValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasVertexTangent_AttributeValue_Offset), 0, GetCustomHasVertexTangent_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasVertexTangent_ReturnValue_Offset), 0, GetCustomHasVertexTangent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexNormal")]
	public unsafe bool GetCustomHasVertexNormal(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomHasVertexNormal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexNormal");
			AttributeValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomHasVertexNormal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomHasVertexNormal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomHasVertexNormal_FunctionAddress, intPtr, GetCustomHasVertexNormal_ParamsSize);
		AttributeValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasVertexNormal_AttributeValue_Offset), 0, GetCustomHasVertexNormal_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasVertexNormal_ReturnValue_Offset), 0, GetCustomHasVertexNormal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexColor")]
	public unsafe bool GetCustomHasVertexColor(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomHasVertexColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexColor");
			AttributeValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomHasVertexColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomHasVertexColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomHasVertexColor_FunctionAddress, intPtr, GetCustomHasVertexColor_ParamsSize);
		AttributeValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasVertexColor_AttributeValue_Offset), 0, GetCustomHasVertexColor_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasVertexColor_ReturnValue_Offset), 0, GetCustomHasVertexColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexBinormal")]
	public unsafe bool GetCustomHasVertexBinormal(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomHasVertexBinormal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexBinormal");
			AttributeValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomHasVertexBinormal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomHasVertexBinormal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomHasVertexBinormal_FunctionAddress, intPtr, GetCustomHasVertexBinormal_ParamsSize);
		AttributeValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasVertexBinormal_AttributeValue_Offset), 0, GetCustomHasVertexBinormal_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasVertexBinormal_ReturnValue_Offset), 0, GetCustomHasVertexBinormal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasSmoothGroup")]
	public unsafe bool GetCustomHasSmoothGroup(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomHasSmoothGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasSmoothGroup");
			AttributeValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomHasSmoothGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomHasSmoothGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomHasSmoothGroup_FunctionAddress, intPtr, GetCustomHasSmoothGroup_ParamsSize);
		AttributeValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasSmoothGroup_AttributeValue_Offset), 0, GetCustomHasSmoothGroup_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomHasSmoothGroup_ReturnValue_Offset), 0, GetCustomHasSmoothGroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomBoundingBox")]
	public unsafe bool GetCustomBoundingBox(out FBox AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomBoundingBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomBoundingBox");
			AttributeValue = default(FBox);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomBoundingBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomBoundingBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomBoundingBox_FunctionAddress, intPtr, GetCustomBoundingBox_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetCustomBoundingBox_AttributeValue_Offset), 0, GetCustomBoundingBox_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomBoundingBox_ReturnValue_Offset), 0, GetCustomBoundingBox_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMeshNode:GetBlendShapeName")]
	public unsafe bool GetBlendShapeName(out string OutBlendShapeName)
	{
		CheckDestroyed();
		if (!GetBlendShapeName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMeshNode:GetBlendShapeName");
			OutBlendShapeName = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlendShapeName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlendShapeName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBlendShapeName_FunctionAddress, intPtr, GetBlendShapeName_ParamsSize);
		OutBlendShapeName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetBlendShapeName_OutBlendShapeName_Offset), 0, GetBlendShapeName_OutBlendShapeName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetBlendShapeName_OutBlendShapeName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBlendShapeName_ReturnValue_Offset), 0, GetBlendShapeName_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeMeshNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeMeshNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeMeshNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeMeshNode");
		SetSkinnedMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSkinnedMesh");
		SetSkinnedMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkinnedMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkinnedMesh_bIsSkinnedMesh_PropertyAddress, SetSkinnedMesh_FunctionAddress, "bIsSkinnedMesh");
		SetSkinnedMesh_bIsSkinnedMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetSkinnedMesh_FunctionAddress, "bIsSkinnedMesh");
		SetSkinnedMesh_bIsSkinnedMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkinnedMesh_FunctionAddress, "bIsSkinnedMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkinnedMesh_ReturnValue_PropertyAddress, SetSkinnedMesh_FunctionAddress, "ReturnValue");
		SetSkinnedMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSkinnedMesh_FunctionAddress, "ReturnValue");
		SetSkinnedMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkinnedMesh_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSkinnedMesh_IsValid = SetSkinnedMesh_FunctionAddress != IntPtr.Zero && SetSkinnedMesh_bIsSkinnedMesh_IsValid && SetSkinnedMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetSkinnedMesh", SetSkinnedMesh_IsValid);
		SetSkeletonDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSkeletonDependencyUid");
		SetSkeletonDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkeletonDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletonDependencyUid_DependencyUid_PropertyAddress, SetSkeletonDependencyUid_FunctionAddress, "DependencyUid");
		SetSkeletonDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletonDependencyUid_FunctionAddress, "DependencyUid");
		SetSkeletonDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletonDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletonDependencyUid_ReturnValue_PropertyAddress, SetSkeletonDependencyUid_FunctionAddress, "ReturnValue");
		SetSkeletonDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletonDependencyUid_FunctionAddress, "ReturnValue");
		SetSkeletonDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletonDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSkeletonDependencyUid_IsValid = SetSkeletonDependencyUid_FunctionAddress != IntPtr.Zero && SetSkeletonDependencyUid_DependencyUid_IsValid && SetSkeletonDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetSkeletonDependencyUid", SetSkeletonDependencyUid_IsValid);
		SetShapeDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetShapeDependencyUid");
		SetShapeDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShapeDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShapeDependencyUid_DependencyUid_PropertyAddress, SetShapeDependencyUid_FunctionAddress, "DependencyUid");
		SetShapeDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(SetShapeDependencyUid_FunctionAddress, "DependencyUid");
		SetShapeDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShapeDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetShapeDependencyUid_ReturnValue_PropertyAddress, SetShapeDependencyUid_FunctionAddress, "ReturnValue");
		SetShapeDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShapeDependencyUid_FunctionAddress, "ReturnValue");
		SetShapeDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShapeDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetShapeDependencyUid_IsValid = SetShapeDependencyUid_FunctionAddress != IntPtr.Zero && SetShapeDependencyUid_DependencyUid_IsValid && SetShapeDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetShapeDependencyUid", SetShapeDependencyUid_IsValid);
		SetSceneInstanceUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSceneInstanceUid");
		SetSceneInstanceUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSceneInstanceUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSceneInstanceUid_DependencyUid_PropertyAddress, SetSceneInstanceUid_FunctionAddress, "DependencyUid");
		SetSceneInstanceUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneInstanceUid_FunctionAddress, "DependencyUid");
		SetSceneInstanceUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneInstanceUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSceneInstanceUid_ReturnValue_PropertyAddress, SetSceneInstanceUid_FunctionAddress, "ReturnValue");
		SetSceneInstanceUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneInstanceUid_FunctionAddress, "ReturnValue");
		SetSceneInstanceUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneInstanceUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSceneInstanceUid_IsValid = SetSceneInstanceUid_FunctionAddress != IntPtr.Zero && SetSceneInstanceUid_DependencyUid_IsValid && SetSceneInstanceUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetSceneInstanceUid", SetSceneInstanceUid_IsValid);
		SetPayLoadKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPayLoadKey");
		SetPayLoadKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPayLoadKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPayLoadKey_PayloadKey_PropertyAddress, SetPayLoadKey_FunctionAddress, "PayloadKey");
		SetPayLoadKey_PayloadKey_Offset = NativeReflectionCached.GetPropertyOffset(SetPayLoadKey_FunctionAddress, "PayloadKey");
		SetPayLoadKey_PayloadKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPayLoadKey_FunctionAddress, "PayloadKey", Classes.FStrProperty);
		SetPayLoadKey_IsValid = SetPayLoadKey_FunctionAddress != IntPtr.Zero && SetPayLoadKey_PayloadKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetPayLoadKey", SetPayLoadKey_IsValid);
		SetMaterialDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMaterialDependencyUid");
		SetMaterialDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterialDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialDependencyUid_DependencyUid_PropertyAddress, SetMaterialDependencyUid_FunctionAddress, "DependencyUid");
		SetMaterialDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialDependencyUid_FunctionAddress, "DependencyUid");
		SetMaterialDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialDependencyUid_ReturnValue_PropertyAddress, SetMaterialDependencyUid_FunctionAddress, "ReturnValue");
		SetMaterialDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialDependencyUid_FunctionAddress, "ReturnValue");
		SetMaterialDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetMaterialDependencyUid_IsValid = SetMaterialDependencyUid_FunctionAddress != IntPtr.Zero && SetMaterialDependencyUid_DependencyUid_IsValid && SetMaterialDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetMaterialDependencyUid", SetMaterialDependencyUid_IsValid);
		SetCustomVertexCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomVertexCount");
		SetCustomVertexCount_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomVertexCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexCount_AttributeValue_PropertyAddress, SetCustomVertexCount_FunctionAddress, "AttributeValue");
		SetCustomVertexCount_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexCount_FunctionAddress, "AttributeValue");
		SetCustomVertexCount_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexCount_FunctionAddress, "AttributeValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexCount_ReturnValue_PropertyAddress, SetCustomVertexCount_FunctionAddress, "ReturnValue");
		SetCustomVertexCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexCount_FunctionAddress, "ReturnValue");
		SetCustomVertexCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexCount_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomVertexCount_IsValid = SetCustomVertexCount_FunctionAddress != IntPtr.Zero && SetCustomVertexCount_AttributeValue_IsValid && SetCustomVertexCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomVertexCount", SetCustomVertexCount_IsValid);
		SetCustomUVCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomUVCount");
		SetCustomUVCount_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomUVCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomUVCount_AttributeValue_PropertyAddress, SetCustomUVCount_FunctionAddress, "AttributeValue");
		SetCustomUVCount_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomUVCount_FunctionAddress, "AttributeValue");
		SetCustomUVCount_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomUVCount_FunctionAddress, "AttributeValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomUVCount_ReturnValue_PropertyAddress, SetCustomUVCount_FunctionAddress, "ReturnValue");
		SetCustomUVCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomUVCount_FunctionAddress, "ReturnValue");
		SetCustomUVCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomUVCount_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomUVCount_IsValid = SetCustomUVCount_FunctionAddress != IntPtr.Zero && SetCustomUVCount_AttributeValue_IsValid && SetCustomUVCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomUVCount", SetCustomUVCount_IsValid);
		SetCustomPolygonCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomPolygonCount");
		SetCustomPolygonCount_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomPolygonCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPolygonCount_AttributeValue_PropertyAddress, SetCustomPolygonCount_FunctionAddress, "AttributeValue");
		SetCustomPolygonCount_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPolygonCount_FunctionAddress, "AttributeValue");
		SetCustomPolygonCount_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPolygonCount_FunctionAddress, "AttributeValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPolygonCount_ReturnValue_PropertyAddress, SetCustomPolygonCount_FunctionAddress, "ReturnValue");
		SetCustomPolygonCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPolygonCount_FunctionAddress, "ReturnValue");
		SetCustomPolygonCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPolygonCount_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomPolygonCount_IsValid = SetCustomPolygonCount_FunctionAddress != IntPtr.Zero && SetCustomPolygonCount_AttributeValue_IsValid && SetCustomPolygonCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomPolygonCount", SetCustomPolygonCount_IsValid);
		SetCustomHasVertexTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomHasVertexTangent");
		SetCustomHasVertexTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomHasVertexTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasVertexTangent_AttributeValue_PropertyAddress, SetCustomHasVertexTangent_FunctionAddress, "AttributeValue");
		SetCustomHasVertexTangent_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasVertexTangent_FunctionAddress, "AttributeValue");
		SetCustomHasVertexTangent_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasVertexTangent_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasVertexTangent_ReturnValue_PropertyAddress, SetCustomHasVertexTangent_FunctionAddress, "ReturnValue");
		SetCustomHasVertexTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasVertexTangent_FunctionAddress, "ReturnValue");
		SetCustomHasVertexTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasVertexTangent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomHasVertexTangent_IsValid = SetCustomHasVertexTangent_FunctionAddress != IntPtr.Zero && SetCustomHasVertexTangent_AttributeValue_IsValid && SetCustomHasVertexTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexTangent", SetCustomHasVertexTangent_IsValid);
		SetCustomHasVertexNormal_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomHasVertexNormal");
		SetCustomHasVertexNormal_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomHasVertexNormal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasVertexNormal_AttributeValue_PropertyAddress, SetCustomHasVertexNormal_FunctionAddress, "AttributeValue");
		SetCustomHasVertexNormal_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasVertexNormal_FunctionAddress, "AttributeValue");
		SetCustomHasVertexNormal_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasVertexNormal_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasVertexNormal_ReturnValue_PropertyAddress, SetCustomHasVertexNormal_FunctionAddress, "ReturnValue");
		SetCustomHasVertexNormal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasVertexNormal_FunctionAddress, "ReturnValue");
		SetCustomHasVertexNormal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasVertexNormal_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomHasVertexNormal_IsValid = SetCustomHasVertexNormal_FunctionAddress != IntPtr.Zero && SetCustomHasVertexNormal_AttributeValue_IsValid && SetCustomHasVertexNormal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexNormal", SetCustomHasVertexNormal_IsValid);
		SetCustomHasVertexColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomHasVertexColor");
		SetCustomHasVertexColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomHasVertexColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasVertexColor_AttributeValue_PropertyAddress, SetCustomHasVertexColor_FunctionAddress, "AttributeValue");
		SetCustomHasVertexColor_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasVertexColor_FunctionAddress, "AttributeValue");
		SetCustomHasVertexColor_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasVertexColor_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasVertexColor_ReturnValue_PropertyAddress, SetCustomHasVertexColor_FunctionAddress, "ReturnValue");
		SetCustomHasVertexColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasVertexColor_FunctionAddress, "ReturnValue");
		SetCustomHasVertexColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasVertexColor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomHasVertexColor_IsValid = SetCustomHasVertexColor_FunctionAddress != IntPtr.Zero && SetCustomHasVertexColor_AttributeValue_IsValid && SetCustomHasVertexColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexColor", SetCustomHasVertexColor_IsValid);
		SetCustomHasVertexBinormal_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomHasVertexBinormal");
		SetCustomHasVertexBinormal_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomHasVertexBinormal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasVertexBinormal_AttributeValue_PropertyAddress, SetCustomHasVertexBinormal_FunctionAddress, "AttributeValue");
		SetCustomHasVertexBinormal_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasVertexBinormal_FunctionAddress, "AttributeValue");
		SetCustomHasVertexBinormal_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasVertexBinormal_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasVertexBinormal_ReturnValue_PropertyAddress, SetCustomHasVertexBinormal_FunctionAddress, "ReturnValue");
		SetCustomHasVertexBinormal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasVertexBinormal_FunctionAddress, "ReturnValue");
		SetCustomHasVertexBinormal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasVertexBinormal_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomHasVertexBinormal_IsValid = SetCustomHasVertexBinormal_FunctionAddress != IntPtr.Zero && SetCustomHasVertexBinormal_AttributeValue_IsValid && SetCustomHasVertexBinormal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasVertexBinormal", SetCustomHasVertexBinormal_IsValid);
		SetCustomHasSmoothGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomHasSmoothGroup");
		SetCustomHasSmoothGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomHasSmoothGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasSmoothGroup_AttributeValue_PropertyAddress, SetCustomHasSmoothGroup_FunctionAddress, "AttributeValue");
		SetCustomHasSmoothGroup_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasSmoothGroup_FunctionAddress, "AttributeValue");
		SetCustomHasSmoothGroup_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasSmoothGroup_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHasSmoothGroup_ReturnValue_PropertyAddress, SetCustomHasSmoothGroup_FunctionAddress, "ReturnValue");
		SetCustomHasSmoothGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHasSmoothGroup_FunctionAddress, "ReturnValue");
		SetCustomHasSmoothGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHasSmoothGroup_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomHasSmoothGroup_IsValid = SetCustomHasSmoothGroup_FunctionAddress != IntPtr.Zero && SetCustomHasSmoothGroup_AttributeValue_IsValid && SetCustomHasSmoothGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomHasSmoothGroup", SetCustomHasSmoothGroup_IsValid);
		SetCustomBoundingBox_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomBoundingBox");
		SetCustomBoundingBox_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomBoundingBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomBoundingBox_AttributeValue_PropertyAddress, SetCustomBoundingBox_FunctionAddress, "AttributeValue");
		SetCustomBoundingBox_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomBoundingBox_FunctionAddress, "AttributeValue");
		SetCustomBoundingBox_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomBoundingBox_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomBoundingBox_ReturnValue_PropertyAddress, SetCustomBoundingBox_FunctionAddress, "ReturnValue");
		SetCustomBoundingBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomBoundingBox_FunctionAddress, "ReturnValue");
		SetCustomBoundingBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomBoundingBox_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomBoundingBox_IsValid = SetCustomBoundingBox_FunctionAddress != IntPtr.Zero && SetCustomBoundingBox_AttributeValue_IsValid && SetCustomBoundingBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetCustomBoundingBox", SetCustomBoundingBox_IsValid);
		SetBlendShapeName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBlendShapeName");
		SetBlendShapeName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlendShapeName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlendShapeName_BlendShapeName_PropertyAddress, SetBlendShapeName_FunctionAddress, "BlendShapeName");
		SetBlendShapeName_BlendShapeName_Offset = NativeReflectionCached.GetPropertyOffset(SetBlendShapeName_FunctionAddress, "BlendShapeName");
		SetBlendShapeName_BlendShapeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlendShapeName_FunctionAddress, "BlendShapeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlendShapeName_ReturnValue_PropertyAddress, SetBlendShapeName_FunctionAddress, "ReturnValue");
		SetBlendShapeName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBlendShapeName_FunctionAddress, "ReturnValue");
		SetBlendShapeName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlendShapeName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetBlendShapeName_IsValid = SetBlendShapeName_FunctionAddress != IntPtr.Zero && SetBlendShapeName_BlendShapeName_IsValid && SetBlendShapeName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetBlendShapeName", SetBlendShapeName_IsValid);
		SetBlendShape_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBlendShape");
		SetBlendShape_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlendShape_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlendShape_bIsBlendShape_PropertyAddress, SetBlendShape_FunctionAddress, "bIsBlendShape");
		SetBlendShape_bIsBlendShape_Offset = NativeReflectionCached.GetPropertyOffset(SetBlendShape_FunctionAddress, "bIsBlendShape");
		SetBlendShape_bIsBlendShape_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlendShape_FunctionAddress, "bIsBlendShape", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlendShape_ReturnValue_PropertyAddress, SetBlendShape_FunctionAddress, "ReturnValue");
		SetBlendShape_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBlendShape_FunctionAddress, "ReturnValue");
		SetBlendShape_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlendShape_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetBlendShape_IsValid = SetBlendShape_FunctionAddress != IntPtr.Zero && SetBlendShape_bIsBlendShape_IsValid && SetBlendShape_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:SetBlendShape", SetBlendShape_IsValid);
		RemoveSkeletonDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveSkeletonDependencyUid");
		RemoveSkeletonDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSkeletonDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSkeletonDependencyUid_DependencyUid_PropertyAddress, RemoveSkeletonDependencyUid_FunctionAddress, "DependencyUid");
		RemoveSkeletonDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSkeletonDependencyUid_FunctionAddress, "DependencyUid");
		RemoveSkeletonDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSkeletonDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSkeletonDependencyUid_ReturnValue_PropertyAddress, RemoveSkeletonDependencyUid_FunctionAddress, "ReturnValue");
		RemoveSkeletonDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSkeletonDependencyUid_FunctionAddress, "ReturnValue");
		RemoveSkeletonDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSkeletonDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveSkeletonDependencyUid_IsValid = RemoveSkeletonDependencyUid_FunctionAddress != IntPtr.Zero && RemoveSkeletonDependencyUid_DependencyUid_IsValid && RemoveSkeletonDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:RemoveSkeletonDependencyUid", RemoveSkeletonDependencyUid_IsValid);
		RemoveShapeDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveShapeDependencyUid");
		RemoveShapeDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveShapeDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveShapeDependencyUid_DependencyUid_PropertyAddress, RemoveShapeDependencyUid_FunctionAddress, "DependencyUid");
		RemoveShapeDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(RemoveShapeDependencyUid_FunctionAddress, "DependencyUid");
		RemoveShapeDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveShapeDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveShapeDependencyUid_ReturnValue_PropertyAddress, RemoveShapeDependencyUid_FunctionAddress, "ReturnValue");
		RemoveShapeDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveShapeDependencyUid_FunctionAddress, "ReturnValue");
		RemoveShapeDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveShapeDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveShapeDependencyUid_IsValid = RemoveShapeDependencyUid_FunctionAddress != IntPtr.Zero && RemoveShapeDependencyUid_DependencyUid_IsValid && RemoveShapeDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:RemoveShapeDependencyUid", RemoveShapeDependencyUid_IsValid);
		RemoveSceneInstanceUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveSceneInstanceUid");
		RemoveSceneInstanceUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSceneInstanceUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSceneInstanceUid_DependencyUid_PropertyAddress, RemoveSceneInstanceUid_FunctionAddress, "DependencyUid");
		RemoveSceneInstanceUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSceneInstanceUid_FunctionAddress, "DependencyUid");
		RemoveSceneInstanceUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSceneInstanceUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSceneInstanceUid_ReturnValue_PropertyAddress, RemoveSceneInstanceUid_FunctionAddress, "ReturnValue");
		RemoveSceneInstanceUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSceneInstanceUid_FunctionAddress, "ReturnValue");
		RemoveSceneInstanceUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSceneInstanceUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveSceneInstanceUid_IsValid = RemoveSceneInstanceUid_FunctionAddress != IntPtr.Zero && RemoveSceneInstanceUid_DependencyUid_IsValid && RemoveSceneInstanceUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:RemoveSceneInstanceUid", RemoveSceneInstanceUid_IsValid);
		RemoveMaterialDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveMaterialDependencyUid");
		RemoveMaterialDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMaterialDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMaterialDependencyUid_DependencyUid_PropertyAddress, RemoveMaterialDependencyUid_FunctionAddress, "DependencyUid");
		RemoveMaterialDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMaterialDependencyUid_FunctionAddress, "DependencyUid");
		RemoveMaterialDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMaterialDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMaterialDependencyUid_ReturnValue_PropertyAddress, RemoveMaterialDependencyUid_FunctionAddress, "ReturnValue");
		RemoveMaterialDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMaterialDependencyUid_FunctionAddress, "ReturnValue");
		RemoveMaterialDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMaterialDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveMaterialDependencyUid_IsValid = RemoveMaterialDependencyUid_FunctionAddress != IntPtr.Zero && RemoveMaterialDependencyUid_DependencyUid_IsValid && RemoveMaterialDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:RemoveMaterialDependencyUid", RemoveMaterialDependencyUid_IsValid);
		IsSkinnedMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSkinnedMesh");
		IsSkinnedMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSkinnedMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSkinnedMesh_ReturnValue_PropertyAddress, IsSkinnedMesh_FunctionAddress, "ReturnValue");
		IsSkinnedMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSkinnedMesh_FunctionAddress, "ReturnValue");
		IsSkinnedMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSkinnedMesh_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSkinnedMesh_IsValid = IsSkinnedMesh_FunctionAddress != IntPtr.Zero && IsSkinnedMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:IsSkinnedMesh", IsSkinnedMesh_IsValid);
		IsBlendShape_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsBlendShape");
		IsBlendShape_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBlendShape_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBlendShape_ReturnValue_PropertyAddress, IsBlendShape_FunctionAddress, "ReturnValue");
		IsBlendShape_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBlendShape_FunctionAddress, "ReturnValue");
		IsBlendShape_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBlendShape_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBlendShape_IsValid = IsBlendShape_FunctionAddress != IntPtr.Zero && IsBlendShape_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:IsBlendShape", IsBlendShape_IsValid);
		GetSkeletonDependency_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSkeletonDependency");
		GetSkeletonDependency_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletonDependency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletonDependency_Index_PropertyAddress, GetSkeletonDependency_FunctionAddress, "Index");
		GetSkeletonDependency_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletonDependency_FunctionAddress, "Index");
		GetSkeletonDependency_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletonDependency_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletonDependency_OutDependency_PropertyAddress, GetSkeletonDependency_FunctionAddress, "OutDependency");
		GetSkeletonDependency_OutDependency_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletonDependency_FunctionAddress, "OutDependency");
		GetSkeletonDependency_OutDependency_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletonDependency_FunctionAddress, "OutDependency", Classes.FStrProperty);
		GetSkeletonDependency_IsValid = GetSkeletonDependency_FunctionAddress != IntPtr.Zero && GetSkeletonDependency_Index_IsValid && GetSkeletonDependency_OutDependency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetSkeletonDependency", GetSkeletonDependency_IsValid);
		GetSkeletonDependencies_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSkeletonDependencies");
		GetSkeletonDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletonDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletonDependencies_OutDependencies_PropertyAddress, GetSkeletonDependencies_FunctionAddress, "OutDependencies");
		GetSkeletonDependencies_OutDependencies_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletonDependencies_FunctionAddress, "OutDependencies");
		GetSkeletonDependencies_OutDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletonDependencies_FunctionAddress, "OutDependencies", Classes.FArrayProperty);
		GetSkeletonDependencies_IsValid = GetSkeletonDependencies_FunctionAddress != IntPtr.Zero && GetSkeletonDependencies_OutDependencies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetSkeletonDependencies", GetSkeletonDependencies_IsValid);
		GetSkeletonDependeciesCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSkeletonDependeciesCount");
		GetSkeletonDependeciesCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeletonDependeciesCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeletonDependeciesCount_ReturnValue_PropertyAddress, GetSkeletonDependeciesCount_FunctionAddress, "ReturnValue");
		GetSkeletonDependeciesCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeletonDependeciesCount_FunctionAddress, "ReturnValue");
		GetSkeletonDependeciesCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeletonDependeciesCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSkeletonDependeciesCount_IsValid = GetSkeletonDependeciesCount_FunctionAddress != IntPtr.Zero && GetSkeletonDependeciesCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetSkeletonDependeciesCount", GetSkeletonDependeciesCount_IsValid);
		GetShapeDependency_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetShapeDependency");
		GetShapeDependency_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShapeDependency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShapeDependency_Index_PropertyAddress, GetShapeDependency_FunctionAddress, "Index");
		GetShapeDependency_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetShapeDependency_FunctionAddress, "Index");
		GetShapeDependency_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShapeDependency_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetShapeDependency_OutDependency_PropertyAddress, GetShapeDependency_FunctionAddress, "OutDependency");
		GetShapeDependency_OutDependency_Offset = NativeReflectionCached.GetPropertyOffset(GetShapeDependency_FunctionAddress, "OutDependency");
		GetShapeDependency_OutDependency_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShapeDependency_FunctionAddress, "OutDependency", Classes.FStrProperty);
		GetShapeDependency_IsValid = GetShapeDependency_FunctionAddress != IntPtr.Zero && GetShapeDependency_Index_IsValid && GetShapeDependency_OutDependency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetShapeDependency", GetShapeDependency_IsValid);
		GetShapeDependencies_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetShapeDependencies");
		GetShapeDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShapeDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShapeDependencies_OutDependencies_PropertyAddress, GetShapeDependencies_FunctionAddress, "OutDependencies");
		GetShapeDependencies_OutDependencies_Offset = NativeReflectionCached.GetPropertyOffset(GetShapeDependencies_FunctionAddress, "OutDependencies");
		GetShapeDependencies_OutDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShapeDependencies_FunctionAddress, "OutDependencies", Classes.FArrayProperty);
		GetShapeDependencies_IsValid = GetShapeDependencies_FunctionAddress != IntPtr.Zero && GetShapeDependencies_OutDependencies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetShapeDependencies", GetShapeDependencies_IsValid);
		GetShapeDependeciesCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetShapeDependeciesCount");
		GetShapeDependeciesCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShapeDependeciesCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShapeDependeciesCount_ReturnValue_PropertyAddress, GetShapeDependeciesCount_FunctionAddress, "ReturnValue");
		GetShapeDependeciesCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShapeDependeciesCount_FunctionAddress, "ReturnValue");
		GetShapeDependeciesCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShapeDependeciesCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetShapeDependeciesCount_IsValid = GetShapeDependeciesCount_FunctionAddress != IntPtr.Zero && GetShapeDependeciesCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetShapeDependeciesCount", GetShapeDependeciesCount_IsValid);
		GetSceneInstanceUidsCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSceneInstanceUidsCount");
		GetSceneInstanceUidsCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSceneInstanceUidsCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSceneInstanceUidsCount_ReturnValue_PropertyAddress, GetSceneInstanceUidsCount_FunctionAddress, "ReturnValue");
		GetSceneInstanceUidsCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneInstanceUidsCount_FunctionAddress, "ReturnValue");
		GetSceneInstanceUidsCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneInstanceUidsCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSceneInstanceUidsCount_IsValid = GetSceneInstanceUidsCount_FunctionAddress != IntPtr.Zero && GetSceneInstanceUidsCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetSceneInstanceUidsCount", GetSceneInstanceUidsCount_IsValid);
		GetSceneInstanceUids_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSceneInstanceUids");
		GetSceneInstanceUids_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSceneInstanceUids_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSceneInstanceUids_OutDependencies_PropertyAddress, GetSceneInstanceUids_FunctionAddress, "OutDependencies");
		GetSceneInstanceUids_OutDependencies_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneInstanceUids_FunctionAddress, "OutDependencies");
		GetSceneInstanceUids_OutDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneInstanceUids_FunctionAddress, "OutDependencies", Classes.FArrayProperty);
		GetSceneInstanceUids_IsValid = GetSceneInstanceUids_FunctionAddress != IntPtr.Zero && GetSceneInstanceUids_OutDependencies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetSceneInstanceUids", GetSceneInstanceUids_IsValid);
		GetSceneInstanceUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSceneInstanceUid");
		GetSceneInstanceUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSceneInstanceUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSceneInstanceUid_Index_PropertyAddress, GetSceneInstanceUid_FunctionAddress, "Index");
		GetSceneInstanceUid_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneInstanceUid_FunctionAddress, "Index");
		GetSceneInstanceUid_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneInstanceUid_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSceneInstanceUid_OutDependency_PropertyAddress, GetSceneInstanceUid_FunctionAddress, "OutDependency");
		GetSceneInstanceUid_OutDependency_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneInstanceUid_FunctionAddress, "OutDependency");
		GetSceneInstanceUid_OutDependency_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneInstanceUid_FunctionAddress, "OutDependency", Classes.FStrProperty);
		GetSceneInstanceUid_IsValid = GetSceneInstanceUid_FunctionAddress != IntPtr.Zero && GetSceneInstanceUid_Index_IsValid && GetSceneInstanceUid_OutDependency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetSceneInstanceUid", GetSceneInstanceUid_IsValid);
		GetMaterialDependency_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMaterialDependency");
		GetMaterialDependency_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialDependency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialDependency_Index_PropertyAddress, GetMaterialDependency_FunctionAddress, "Index");
		GetMaterialDependency_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialDependency_FunctionAddress, "Index");
		GetMaterialDependency_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialDependency_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialDependency_OutDependency_PropertyAddress, GetMaterialDependency_FunctionAddress, "OutDependency");
		GetMaterialDependency_OutDependency_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialDependency_FunctionAddress, "OutDependency");
		GetMaterialDependency_OutDependency_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialDependency_FunctionAddress, "OutDependency", Classes.FStrProperty);
		GetMaterialDependency_IsValid = GetMaterialDependency_FunctionAddress != IntPtr.Zero && GetMaterialDependency_Index_IsValid && GetMaterialDependency_OutDependency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetMaterialDependency", GetMaterialDependency_IsValid);
		GetMaterialDependencies_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMaterialDependencies");
		GetMaterialDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialDependencies_OutDependencies_PropertyAddress, GetMaterialDependencies_FunctionAddress, "OutDependencies");
		GetMaterialDependencies_OutDependencies_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialDependencies_FunctionAddress, "OutDependencies");
		GetMaterialDependencies_OutDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialDependencies_FunctionAddress, "OutDependencies", Classes.FArrayProperty);
		GetMaterialDependencies_IsValid = GetMaterialDependencies_FunctionAddress != IntPtr.Zero && GetMaterialDependencies_OutDependencies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetMaterialDependencies", GetMaterialDependencies_IsValid);
		GetMaterialDependeciesCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMaterialDependeciesCount");
		GetMaterialDependeciesCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialDependeciesCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialDependeciesCount_ReturnValue_PropertyAddress, GetMaterialDependeciesCount_FunctionAddress, "ReturnValue");
		GetMaterialDependeciesCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialDependeciesCount_FunctionAddress, "ReturnValue");
		GetMaterialDependeciesCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialDependeciesCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMaterialDependeciesCount_IsValid = GetMaterialDependeciesCount_FunctionAddress != IntPtr.Zero && GetMaterialDependeciesCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetMaterialDependeciesCount", GetMaterialDependeciesCount_IsValid);
		GetCustomVertexCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomVertexCount");
		GetCustomVertexCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomVertexCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexCount_AttributeValue_PropertyAddress, GetCustomVertexCount_FunctionAddress, "AttributeValue");
		GetCustomVertexCount_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexCount_FunctionAddress, "AttributeValue");
		GetCustomVertexCount_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexCount_FunctionAddress, "AttributeValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexCount_ReturnValue_PropertyAddress, GetCustomVertexCount_FunctionAddress, "ReturnValue");
		GetCustomVertexCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexCount_FunctionAddress, "ReturnValue");
		GetCustomVertexCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexCount_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomVertexCount_IsValid = GetCustomVertexCount_FunctionAddress != IntPtr.Zero && GetCustomVertexCount_AttributeValue_IsValid && GetCustomVertexCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomVertexCount", GetCustomVertexCount_IsValid);
		GetCustomUVCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomUVCount");
		GetCustomUVCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomUVCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomUVCount_AttributeValue_PropertyAddress, GetCustomUVCount_FunctionAddress, "AttributeValue");
		GetCustomUVCount_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomUVCount_FunctionAddress, "AttributeValue");
		GetCustomUVCount_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomUVCount_FunctionAddress, "AttributeValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomUVCount_ReturnValue_PropertyAddress, GetCustomUVCount_FunctionAddress, "ReturnValue");
		GetCustomUVCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomUVCount_FunctionAddress, "ReturnValue");
		GetCustomUVCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomUVCount_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomUVCount_IsValid = GetCustomUVCount_FunctionAddress != IntPtr.Zero && GetCustomUVCount_AttributeValue_IsValid && GetCustomUVCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomUVCount", GetCustomUVCount_IsValid);
		GetCustomPolygonCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomPolygonCount");
		GetCustomPolygonCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomPolygonCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPolygonCount_AttributeValue_PropertyAddress, GetCustomPolygonCount_FunctionAddress, "AttributeValue");
		GetCustomPolygonCount_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPolygonCount_FunctionAddress, "AttributeValue");
		GetCustomPolygonCount_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPolygonCount_FunctionAddress, "AttributeValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPolygonCount_ReturnValue_PropertyAddress, GetCustomPolygonCount_FunctionAddress, "ReturnValue");
		GetCustomPolygonCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPolygonCount_FunctionAddress, "ReturnValue");
		GetCustomPolygonCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPolygonCount_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomPolygonCount_IsValid = GetCustomPolygonCount_FunctionAddress != IntPtr.Zero && GetCustomPolygonCount_AttributeValue_IsValid && GetCustomPolygonCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomPolygonCount", GetCustomPolygonCount_IsValid);
		GetCustomHasVertexTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomHasVertexTangent");
		GetCustomHasVertexTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomHasVertexTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasVertexTangent_AttributeValue_PropertyAddress, GetCustomHasVertexTangent_FunctionAddress, "AttributeValue");
		GetCustomHasVertexTangent_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasVertexTangent_FunctionAddress, "AttributeValue");
		GetCustomHasVertexTangent_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasVertexTangent_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasVertexTangent_ReturnValue_PropertyAddress, GetCustomHasVertexTangent_FunctionAddress, "ReturnValue");
		GetCustomHasVertexTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasVertexTangent_FunctionAddress, "ReturnValue");
		GetCustomHasVertexTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasVertexTangent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomHasVertexTangent_IsValid = GetCustomHasVertexTangent_FunctionAddress != IntPtr.Zero && GetCustomHasVertexTangent_AttributeValue_IsValid && GetCustomHasVertexTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexTangent", GetCustomHasVertexTangent_IsValid);
		GetCustomHasVertexNormal_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomHasVertexNormal");
		GetCustomHasVertexNormal_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomHasVertexNormal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasVertexNormal_AttributeValue_PropertyAddress, GetCustomHasVertexNormal_FunctionAddress, "AttributeValue");
		GetCustomHasVertexNormal_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasVertexNormal_FunctionAddress, "AttributeValue");
		GetCustomHasVertexNormal_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasVertexNormal_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasVertexNormal_ReturnValue_PropertyAddress, GetCustomHasVertexNormal_FunctionAddress, "ReturnValue");
		GetCustomHasVertexNormal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasVertexNormal_FunctionAddress, "ReturnValue");
		GetCustomHasVertexNormal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasVertexNormal_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomHasVertexNormal_IsValid = GetCustomHasVertexNormal_FunctionAddress != IntPtr.Zero && GetCustomHasVertexNormal_AttributeValue_IsValid && GetCustomHasVertexNormal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexNormal", GetCustomHasVertexNormal_IsValid);
		GetCustomHasVertexColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomHasVertexColor");
		GetCustomHasVertexColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomHasVertexColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasVertexColor_AttributeValue_PropertyAddress, GetCustomHasVertexColor_FunctionAddress, "AttributeValue");
		GetCustomHasVertexColor_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasVertexColor_FunctionAddress, "AttributeValue");
		GetCustomHasVertexColor_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasVertexColor_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasVertexColor_ReturnValue_PropertyAddress, GetCustomHasVertexColor_FunctionAddress, "ReturnValue");
		GetCustomHasVertexColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasVertexColor_FunctionAddress, "ReturnValue");
		GetCustomHasVertexColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasVertexColor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomHasVertexColor_IsValid = GetCustomHasVertexColor_FunctionAddress != IntPtr.Zero && GetCustomHasVertexColor_AttributeValue_IsValid && GetCustomHasVertexColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexColor", GetCustomHasVertexColor_IsValid);
		GetCustomHasVertexBinormal_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomHasVertexBinormal");
		GetCustomHasVertexBinormal_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomHasVertexBinormal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasVertexBinormal_AttributeValue_PropertyAddress, GetCustomHasVertexBinormal_FunctionAddress, "AttributeValue");
		GetCustomHasVertexBinormal_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasVertexBinormal_FunctionAddress, "AttributeValue");
		GetCustomHasVertexBinormal_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasVertexBinormal_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasVertexBinormal_ReturnValue_PropertyAddress, GetCustomHasVertexBinormal_FunctionAddress, "ReturnValue");
		GetCustomHasVertexBinormal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasVertexBinormal_FunctionAddress, "ReturnValue");
		GetCustomHasVertexBinormal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasVertexBinormal_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomHasVertexBinormal_IsValid = GetCustomHasVertexBinormal_FunctionAddress != IntPtr.Zero && GetCustomHasVertexBinormal_AttributeValue_IsValid && GetCustomHasVertexBinormal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasVertexBinormal", GetCustomHasVertexBinormal_IsValid);
		GetCustomHasSmoothGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomHasSmoothGroup");
		GetCustomHasSmoothGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomHasSmoothGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasSmoothGroup_AttributeValue_PropertyAddress, GetCustomHasSmoothGroup_FunctionAddress, "AttributeValue");
		GetCustomHasSmoothGroup_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasSmoothGroup_FunctionAddress, "AttributeValue");
		GetCustomHasSmoothGroup_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasSmoothGroup_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomHasSmoothGroup_ReturnValue_PropertyAddress, GetCustomHasSmoothGroup_FunctionAddress, "ReturnValue");
		GetCustomHasSmoothGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomHasSmoothGroup_FunctionAddress, "ReturnValue");
		GetCustomHasSmoothGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomHasSmoothGroup_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomHasSmoothGroup_IsValid = GetCustomHasSmoothGroup_FunctionAddress != IntPtr.Zero && GetCustomHasSmoothGroup_AttributeValue_IsValid && GetCustomHasSmoothGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomHasSmoothGroup", GetCustomHasSmoothGroup_IsValid);
		GetCustomBoundingBox_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomBoundingBox");
		GetCustomBoundingBox_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomBoundingBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomBoundingBox_AttributeValue_PropertyAddress, GetCustomBoundingBox_FunctionAddress, "AttributeValue");
		GetCustomBoundingBox_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomBoundingBox_FunctionAddress, "AttributeValue");
		GetCustomBoundingBox_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomBoundingBox_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomBoundingBox_ReturnValue_PropertyAddress, GetCustomBoundingBox_FunctionAddress, "ReturnValue");
		GetCustomBoundingBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomBoundingBox_FunctionAddress, "ReturnValue");
		GetCustomBoundingBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomBoundingBox_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomBoundingBox_IsValid = GetCustomBoundingBox_FunctionAddress != IntPtr.Zero && GetCustomBoundingBox_AttributeValue_IsValid && GetCustomBoundingBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetCustomBoundingBox", GetCustomBoundingBox_IsValid);
		GetBlendShapeName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBlendShapeName");
		GetBlendShapeName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlendShapeName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlendShapeName_OutBlendShapeName_PropertyAddress, GetBlendShapeName_FunctionAddress, "OutBlendShapeName");
		GetBlendShapeName_OutBlendShapeName_Offset = NativeReflectionCached.GetPropertyOffset(GetBlendShapeName_FunctionAddress, "OutBlendShapeName");
		GetBlendShapeName_OutBlendShapeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlendShapeName_FunctionAddress, "OutBlendShapeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlendShapeName_ReturnValue_PropertyAddress, GetBlendShapeName_FunctionAddress, "ReturnValue");
		GetBlendShapeName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlendShapeName_FunctionAddress, "ReturnValue");
		GetBlendShapeName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlendShapeName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBlendShapeName_IsValid = GetBlendShapeName_FunctionAddress != IntPtr.Zero && GetBlendShapeName_OutBlendShapeName_IsValid && GetBlendShapeName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMeshNode:GetBlendShapeName", GetBlendShapeName_IsValid);
	}
}
