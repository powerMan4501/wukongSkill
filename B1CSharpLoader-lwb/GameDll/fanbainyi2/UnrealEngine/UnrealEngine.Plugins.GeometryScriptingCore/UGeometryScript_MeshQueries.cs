using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshQueries : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsValidVertexID_IsValid;

	private static IntPtr IsValidVertexID_FunctionAddress;

	private static int IsValidVertexID_ParamsSize;

	private static bool IsValidVertexID_TargetMesh_IsValid;

	private static FFieldAddress IsValidVertexID_TargetMesh_PropertyAddress;

	private static int IsValidVertexID_TargetMesh_Offset;

	private static bool IsValidVertexID_VertexID_IsValid;

	private static FFieldAddress IsValidVertexID_VertexID_PropertyAddress;

	private static int IsValidVertexID_VertexID_Offset;

	private static bool IsValidVertexID_ReturnValue_IsValid;

	private static FFieldAddress IsValidVertexID_ReturnValue_PropertyAddress;

	private static int IsValidVertexID_ReturnValue_Offset;

	private static bool IsValidTriangleID_IsValid;

	private static IntPtr IsValidTriangleID_FunctionAddress;

	private static int IsValidTriangleID_ParamsSize;

	private static bool IsValidTriangleID_TargetMesh_IsValid;

	private static FFieldAddress IsValidTriangleID_TargetMesh_PropertyAddress;

	private static int IsValidTriangleID_TargetMesh_Offset;

	private static bool IsValidTriangleID_TriangleID_IsValid;

	private static FFieldAddress IsValidTriangleID_TriangleID_PropertyAddress;

	private static int IsValidTriangleID_TriangleID_Offset;

	private static bool IsValidTriangleID_ReturnValue_IsValid;

	private static FFieldAddress IsValidTriangleID_ReturnValue_PropertyAddress;

	private static int IsValidTriangleID_ReturnValue_Offset;

	private static bool GetVertexPosition_IsValid;

	private static IntPtr GetVertexPosition_FunctionAddress;

	private static int GetVertexPosition_ParamsSize;

	private static bool GetVertexPosition_TargetMesh_IsValid;

	private static FFieldAddress GetVertexPosition_TargetMesh_PropertyAddress;

	private static int GetVertexPosition_TargetMesh_Offset;

	private static bool GetVertexPosition_VertexID_IsValid;

	private static FFieldAddress GetVertexPosition_VertexID_PropertyAddress;

	private static int GetVertexPosition_VertexID_Offset;

	private static bool GetVertexPosition_bIsValidVertex_IsValid;

	private static FFieldAddress GetVertexPosition_bIsValidVertex_PropertyAddress;

	private static int GetVertexPosition_bIsValidVertex_Offset;

	private static bool GetVertexPosition_ReturnValue_IsValid;

	private static FFieldAddress GetVertexPosition_ReturnValue_PropertyAddress;

	private static int GetVertexPosition_ReturnValue_Offset;

	private static bool GetVertexCount_IsValid;

	private static IntPtr GetVertexCount_FunctionAddress;

	private static int GetVertexCount_ParamsSize;

	private static bool GetVertexCount_TargetMesh_IsValid;

	private static FFieldAddress GetVertexCount_TargetMesh_PropertyAddress;

	private static int GetVertexCount_TargetMesh_Offset;

	private static bool GetVertexCount_ReturnValue_IsValid;

	private static FFieldAddress GetVertexCount_ReturnValue_PropertyAddress;

	private static int GetVertexCount_ReturnValue_Offset;

	private static bool GetUVSetBoundingBox_IsValid;

	private static IntPtr GetUVSetBoundingBox_FunctionAddress;

	private static int GetUVSetBoundingBox_ParamsSize;

	private static bool GetUVSetBoundingBox_TargetMesh_IsValid;

	private static FFieldAddress GetUVSetBoundingBox_TargetMesh_PropertyAddress;

	private static int GetUVSetBoundingBox_TargetMesh_Offset;

	private static bool GetUVSetBoundingBox_UVSetIndex_IsValid;

	private static FFieldAddress GetUVSetBoundingBox_UVSetIndex_PropertyAddress;

	private static int GetUVSetBoundingBox_UVSetIndex_Offset;

	private static bool GetUVSetBoundingBox_bIsValidUVSet_IsValid;

	private static FFieldAddress GetUVSetBoundingBox_bIsValidUVSet_PropertyAddress;

	private static int GetUVSetBoundingBox_bIsValidUVSet_Offset;

	private static bool GetUVSetBoundingBox_bUVSetIsEmpty_IsValid;

	private static FFieldAddress GetUVSetBoundingBox_bUVSetIsEmpty_PropertyAddress;

	private static int GetUVSetBoundingBox_bUVSetIsEmpty_Offset;

	private static bool GetUVSetBoundingBox_ReturnValue_IsValid;

	private static FFieldAddress GetUVSetBoundingBox_ReturnValue_PropertyAddress;

	private static int GetUVSetBoundingBox_ReturnValue_Offset;

	private static bool GetTriangleUVs_IsValid;

	private static IntPtr GetTriangleUVs_FunctionAddress;

	private static int GetTriangleUVs_ParamsSize;

	private static bool GetTriangleUVs_TargetMesh_IsValid;

	private static FFieldAddress GetTriangleUVs_TargetMesh_PropertyAddress;

	private static int GetTriangleUVs_TargetMesh_Offset;

	private static bool GetTriangleUVs_UVSetIndex_IsValid;

	private static FFieldAddress GetTriangleUVs_UVSetIndex_PropertyAddress;

	private static int GetTriangleUVs_UVSetIndex_Offset;

	private static bool GetTriangleUVs_TriangleID_IsValid;

	private static FFieldAddress GetTriangleUVs_TriangleID_PropertyAddress;

	private static int GetTriangleUVs_TriangleID_Offset;

	private static bool GetTriangleUVs_UV1_IsValid;

	private static FFieldAddress GetTriangleUVs_UV1_PropertyAddress;

	private static int GetTriangleUVs_UV1_Offset;

	private static bool GetTriangleUVs_UV2_IsValid;

	private static FFieldAddress GetTriangleUVs_UV2_PropertyAddress;

	private static int GetTriangleUVs_UV2_Offset;

	private static bool GetTriangleUVs_UV3_IsValid;

	private static FFieldAddress GetTriangleUVs_UV3_PropertyAddress;

	private static int GetTriangleUVs_UV3_Offset;

	private static bool GetTriangleUVs_bHaveValidUVs_IsValid;

	private static FFieldAddress GetTriangleUVs_bHaveValidUVs_PropertyAddress;

	private static int GetTriangleUVs_bHaveValidUVs_Offset;

	private static bool GetTrianglePositions_IsValid;

	private static IntPtr GetTrianglePositions_FunctionAddress;

	private static int GetTrianglePositions_ParamsSize;

	private static bool GetTrianglePositions_TargetMesh_IsValid;

	private static FFieldAddress GetTrianglePositions_TargetMesh_PropertyAddress;

	private static int GetTrianglePositions_TargetMesh_Offset;

	private static bool GetTrianglePositions_TriangleID_IsValid;

	private static FFieldAddress GetTrianglePositions_TriangleID_PropertyAddress;

	private static int GetTrianglePositions_TriangleID_Offset;

	private static bool GetTrianglePositions_bIsValidTriangle_IsValid;

	private static FFieldAddress GetTrianglePositions_bIsValidTriangle_PropertyAddress;

	private static int GetTrianglePositions_bIsValidTriangle_Offset;

	private static bool GetTrianglePositions_Vertex1_IsValid;

	private static FFieldAddress GetTrianglePositions_Vertex1_PropertyAddress;

	private static int GetTrianglePositions_Vertex1_Offset;

	private static bool GetTrianglePositions_Vertex2_IsValid;

	private static FFieldAddress GetTrianglePositions_Vertex2_PropertyAddress;

	private static int GetTrianglePositions_Vertex2_Offset;

	private static bool GetTrianglePositions_Vertex3_IsValid;

	private static FFieldAddress GetTrianglePositions_Vertex3_PropertyAddress;

	private static int GetTrianglePositions_Vertex3_Offset;

	private static bool GetTriangleIndices_IsValid;

	private static IntPtr GetTriangleIndices_FunctionAddress;

	private static int GetTriangleIndices_ParamsSize;

	private static bool GetTriangleIndices_TargetMesh_IsValid;

	private static FFieldAddress GetTriangleIndices_TargetMesh_PropertyAddress;

	private static int GetTriangleIndices_TargetMesh_Offset;

	private static bool GetTriangleIndices_TriangleID_IsValid;

	private static FFieldAddress GetTriangleIndices_TriangleID_PropertyAddress;

	private static int GetTriangleIndices_TriangleID_Offset;

	private static bool GetTriangleIndices_bIsValidTriangle_IsValid;

	private static FFieldAddress GetTriangleIndices_bIsValidTriangle_PropertyAddress;

	private static int GetTriangleIndices_bIsValidTriangle_Offset;

	private static bool GetTriangleIndices_ReturnValue_IsValid;

	private static FFieldAddress GetTriangleIndices_ReturnValue_PropertyAddress;

	private static int GetTriangleIndices_ReturnValue_Offset;

	private static bool GetTriangleFaceNormal_IsValid;

	private static IntPtr GetTriangleFaceNormal_FunctionAddress;

	private static int GetTriangleFaceNormal_ParamsSize;

	private static bool GetTriangleFaceNormal_TargetMesh_IsValid;

	private static FFieldAddress GetTriangleFaceNormal_TargetMesh_PropertyAddress;

	private static int GetTriangleFaceNormal_TargetMesh_Offset;

	private static bool GetTriangleFaceNormal_TriangleID_IsValid;

	private static FFieldAddress GetTriangleFaceNormal_TriangleID_PropertyAddress;

	private static int GetTriangleFaceNormal_TriangleID_Offset;

	private static bool GetTriangleFaceNormal_bIsValidTriangle_IsValid;

	private static FFieldAddress GetTriangleFaceNormal_bIsValidTriangle_PropertyAddress;

	private static int GetTriangleFaceNormal_bIsValidTriangle_Offset;

	private static bool GetTriangleFaceNormal_ReturnValue_IsValid;

	private static FFieldAddress GetTriangleFaceNormal_ReturnValue_PropertyAddress;

	private static int GetTriangleFaceNormal_ReturnValue_Offset;

	private static bool GetNumVertexIDs_IsValid;

	private static IntPtr GetNumVertexIDs_FunctionAddress;

	private static int GetNumVertexIDs_ParamsSize;

	private static bool GetNumVertexIDs_TargetMesh_IsValid;

	private static FFieldAddress GetNumVertexIDs_TargetMesh_PropertyAddress;

	private static int GetNumVertexIDs_TargetMesh_Offset;

	private static bool GetNumVertexIDs_ReturnValue_IsValid;

	private static FFieldAddress GetNumVertexIDs_ReturnValue_PropertyAddress;

	private static int GetNumVertexIDs_ReturnValue_Offset;

	private static bool GetNumUVSets_IsValid;

	private static IntPtr GetNumUVSets_FunctionAddress;

	private static int GetNumUVSets_ParamsSize;

	private static bool GetNumUVSets_TargetMesh_IsValid;

	private static FFieldAddress GetNumUVSets_TargetMesh_PropertyAddress;

	private static int GetNumUVSets_TargetMesh_Offset;

	private static bool GetNumUVSets_ReturnValue_IsValid;

	private static FFieldAddress GetNumUVSets_ReturnValue_PropertyAddress;

	private static int GetNumUVSets_ReturnValue_Offset;

	private static bool GetNumTriangleIDs_IsValid;

	private static IntPtr GetNumTriangleIDs_FunctionAddress;

	private static int GetNumTriangleIDs_ParamsSize;

	private static bool GetNumTriangleIDs_TargetMesh_IsValid;

	private static FFieldAddress GetNumTriangleIDs_TargetMesh_PropertyAddress;

	private static int GetNumTriangleIDs_TargetMesh_Offset;

	private static bool GetNumTriangleIDs_ReturnValue_IsValid;

	private static FFieldAddress GetNumTriangleIDs_ReturnValue_PropertyAddress;

	private static int GetNumTriangleIDs_ReturnValue_Offset;

	private static bool GetNumOpenBorderLoops_IsValid;

	private static IntPtr GetNumOpenBorderLoops_FunctionAddress;

	private static int GetNumOpenBorderLoops_ParamsSize;

	private static bool GetNumOpenBorderLoops_TargetMesh_IsValid;

	private static FFieldAddress GetNumOpenBorderLoops_TargetMesh_PropertyAddress;

	private static int GetNumOpenBorderLoops_TargetMesh_Offset;

	private static bool GetNumOpenBorderLoops_bAmbiguousTopologyFound_IsValid;

	private static FFieldAddress GetNumOpenBorderLoops_bAmbiguousTopologyFound_PropertyAddress;

	private static int GetNumOpenBorderLoops_bAmbiguousTopologyFound_Offset;

	private static bool GetNumOpenBorderLoops_ReturnValue_IsValid;

	private static FFieldAddress GetNumOpenBorderLoops_ReturnValue_PropertyAddress;

	private static int GetNumOpenBorderLoops_ReturnValue_Offset;

	private static bool GetNumOpenBorderEdges_IsValid;

	private static IntPtr GetNumOpenBorderEdges_FunctionAddress;

	private static int GetNumOpenBorderEdges_ParamsSize;

	private static bool GetNumOpenBorderEdges_TargetMesh_IsValid;

	private static FFieldAddress GetNumOpenBorderEdges_TargetMesh_PropertyAddress;

	private static int GetNumOpenBorderEdges_TargetMesh_Offset;

	private static bool GetNumOpenBorderEdges_ReturnValue_IsValid;

	private static FFieldAddress GetNumOpenBorderEdges_ReturnValue_PropertyAddress;

	private static int GetNumOpenBorderEdges_ReturnValue_Offset;

	private static bool GetNumExtendedPolygroupLayers_IsValid;

	private static IntPtr GetNumExtendedPolygroupLayers_FunctionAddress;

	private static int GetNumExtendedPolygroupLayers_ParamsSize;

	private static bool GetNumExtendedPolygroupLayers_TargetMesh_IsValid;

	private static FFieldAddress GetNumExtendedPolygroupLayers_TargetMesh_PropertyAddress;

	private static int GetNumExtendedPolygroupLayers_TargetMesh_Offset;

	private static bool GetNumExtendedPolygroupLayers_ReturnValue_IsValid;

	private static FFieldAddress GetNumExtendedPolygroupLayers_ReturnValue_PropertyAddress;

	private static int GetNumExtendedPolygroupLayers_ReturnValue_Offset;

	private static bool GetNumConnectedComponents_IsValid;

	private static IntPtr GetNumConnectedComponents_FunctionAddress;

	private static int GetNumConnectedComponents_ParamsSize;

	private static bool GetNumConnectedComponents_TargetMesh_IsValid;

	private static FFieldAddress GetNumConnectedComponents_TargetMesh_PropertyAddress;

	private static int GetNumConnectedComponents_TargetMesh_Offset;

	private static bool GetNumConnectedComponents_ReturnValue_IsValid;

	private static FFieldAddress GetNumConnectedComponents_ReturnValue_PropertyAddress;

	private static int GetNumConnectedComponents_ReturnValue_Offset;

	private static bool GetMeshVolumeArea_IsValid;

	private static IntPtr GetMeshVolumeArea_FunctionAddress;

	private static int GetMeshVolumeArea_ParamsSize;

	private static bool GetMeshVolumeArea_TargetMesh_IsValid;

	private static FFieldAddress GetMeshVolumeArea_TargetMesh_PropertyAddress;

	private static int GetMeshVolumeArea_TargetMesh_Offset;

	private static bool GetMeshVolumeArea_SurfaceArea_IsValid;

	private static FFieldAddress GetMeshVolumeArea_SurfaceArea_PropertyAddress;

	private static int GetMeshVolumeArea_SurfaceArea_Offset;

	private static bool GetMeshVolumeArea_Volume_IsValid;

	private static FFieldAddress GetMeshVolumeArea_Volume_PropertyAddress;

	private static int GetMeshVolumeArea_Volume_Offset;

	private static bool GetMeshHasAttributeSet_IsValid;

	private static IntPtr GetMeshHasAttributeSet_FunctionAddress;

	private static int GetMeshHasAttributeSet_ParamsSize;

	private static bool GetMeshHasAttributeSet_TargetMesh_IsValid;

	private static FFieldAddress GetMeshHasAttributeSet_TargetMesh_PropertyAddress;

	private static int GetMeshHasAttributeSet_TargetMesh_Offset;

	private static bool GetMeshHasAttributeSet_ReturnValue_IsValid;

	private static FFieldAddress GetMeshHasAttributeSet_ReturnValue_PropertyAddress;

	private static int GetMeshHasAttributeSet_ReturnValue_Offset;

	private static bool GetMeshBoundingBox_IsValid;

	private static IntPtr GetMeshBoundingBox_FunctionAddress;

	private static int GetMeshBoundingBox_ParamsSize;

	private static bool GetMeshBoundingBox_TargetMesh_IsValid;

	private static FFieldAddress GetMeshBoundingBox_TargetMesh_PropertyAddress;

	private static int GetMeshBoundingBox_TargetMesh_Offset;

	private static bool GetMeshBoundingBox_ReturnValue_IsValid;

	private static FFieldAddress GetMeshBoundingBox_ReturnValue_PropertyAddress;

	private static int GetMeshBoundingBox_ReturnValue_Offset;

	private static bool GetIsDenseMesh_IsValid;

	private static IntPtr GetIsDenseMesh_FunctionAddress;

	private static int GetIsDenseMesh_ParamsSize;

	private static bool GetIsDenseMesh_TargetMesh_IsValid;

	private static FFieldAddress GetIsDenseMesh_TargetMesh_PropertyAddress;

	private static int GetIsDenseMesh_TargetMesh_Offset;

	private static bool GetIsDenseMesh_ReturnValue_IsValid;

	private static FFieldAddress GetIsDenseMesh_ReturnValue_PropertyAddress;

	private static int GetIsDenseMesh_ReturnValue_Offset;

	private static bool GetIsClosedMesh_IsValid;

	private static IntPtr GetIsClosedMesh_FunctionAddress;

	private static int GetIsClosedMesh_ParamsSize;

	private static bool GetIsClosedMesh_TargetMesh_IsValid;

	private static FFieldAddress GetIsClosedMesh_TargetMesh_PropertyAddress;

	private static int GetIsClosedMesh_TargetMesh_Offset;

	private static bool GetIsClosedMesh_ReturnValue_IsValid;

	private static FFieldAddress GetIsClosedMesh_ReturnValue_PropertyAddress;

	private static int GetIsClosedMesh_ReturnValue_Offset;

	private static bool GetHasVertexIDGaps_IsValid;

	private static IntPtr GetHasVertexIDGaps_FunctionAddress;

	private static int GetHasVertexIDGaps_ParamsSize;

	private static bool GetHasVertexIDGaps_TargetMesh_IsValid;

	private static FFieldAddress GetHasVertexIDGaps_TargetMesh_PropertyAddress;

	private static int GetHasVertexIDGaps_TargetMesh_Offset;

	private static bool GetHasVertexIDGaps_ReturnValue_IsValid;

	private static FFieldAddress GetHasVertexIDGaps_ReturnValue_PropertyAddress;

	private static int GetHasVertexIDGaps_ReturnValue_Offset;

	private static bool GetHasTriangleIDGaps_IsValid;

	private static IntPtr GetHasTriangleIDGaps_FunctionAddress;

	private static int GetHasTriangleIDGaps_ParamsSize;

	private static bool GetHasTriangleIDGaps_TargetMesh_IsValid;

	private static FFieldAddress GetHasTriangleIDGaps_TargetMesh_PropertyAddress;

	private static int GetHasTriangleIDGaps_TargetMesh_Offset;

	private static bool GetHasTriangleIDGaps_ReturnValue_IsValid;

	private static FFieldAddress GetHasTriangleIDGaps_ReturnValue_PropertyAddress;

	private static int GetHasTriangleIDGaps_ReturnValue_Offset;

	private static bool GetHasPolygroups_IsValid;

	private static IntPtr GetHasPolygroups_FunctionAddress;

	private static int GetHasPolygroups_ParamsSize;

	private static bool GetHasPolygroups_TargetMesh_IsValid;

	private static FFieldAddress GetHasPolygroups_TargetMesh_PropertyAddress;

	private static int GetHasPolygroups_TargetMesh_Offset;

	private static bool GetHasPolygroups_ReturnValue_IsValid;

	private static FFieldAddress GetHasPolygroups_ReturnValue_PropertyAddress;

	private static int GetHasPolygroups_ReturnValue_Offset;

	private static bool GetHasMaterialIDs_IsValid;

	private static IntPtr GetHasMaterialIDs_FunctionAddress;

	private static int GetHasMaterialIDs_ParamsSize;

	private static bool GetHasMaterialIDs_TargetMesh_IsValid;

	private static FFieldAddress GetHasMaterialIDs_TargetMesh_PropertyAddress;

	private static int GetHasMaterialIDs_TargetMesh_Offset;

	private static bool GetHasMaterialIDs_ReturnValue_IsValid;

	private static FFieldAddress GetHasMaterialIDs_ReturnValue_PropertyAddress;

	private static int GetHasMaterialIDs_ReturnValue_Offset;

	private static bool GetAllVertexPositions_IsValid;

	private static IntPtr GetAllVertexPositions_FunctionAddress;

	private static int GetAllVertexPositions_ParamsSize;

	private static bool GetAllVertexPositions_TargetMesh_IsValid;

	private static FFieldAddress GetAllVertexPositions_TargetMesh_PropertyAddress;

	private static int GetAllVertexPositions_TargetMesh_Offset;

	private static bool GetAllVertexPositions_PositionList_IsValid;

	private static FFieldAddress GetAllVertexPositions_PositionList_PropertyAddress;

	private static int GetAllVertexPositions_PositionList_Offset;

	private static bool GetAllVertexPositions_bSkipGaps_IsValid;

	private static FFieldAddress GetAllVertexPositions_bSkipGaps_PropertyAddress;

	private static int GetAllVertexPositions_bSkipGaps_Offset;

	private static bool GetAllVertexPositions_bHasVertexIDGaps_IsValid;

	private static FFieldAddress GetAllVertexPositions_bHasVertexIDGaps_PropertyAddress;

	private static int GetAllVertexPositions_bHasVertexIDGaps_Offset;

	private static bool GetAllVertexPositions_ReturnValue_IsValid;

	private static FFieldAddress GetAllVertexPositions_ReturnValue_PropertyAddress;

	private static int GetAllVertexPositions_ReturnValue_Offset;

	private static bool GetAllVertexIDs_IsValid;

	private static IntPtr GetAllVertexIDs_FunctionAddress;

	private static int GetAllVertexIDs_ParamsSize;

	private static bool GetAllVertexIDs_TargetMesh_IsValid;

	private static FFieldAddress GetAllVertexIDs_TargetMesh_PropertyAddress;

	private static int GetAllVertexIDs_TargetMesh_Offset;

	private static bool GetAllVertexIDs_VertexIDList_IsValid;

	private static FFieldAddress GetAllVertexIDs_VertexIDList_PropertyAddress;

	private static int GetAllVertexIDs_VertexIDList_Offset;

	private static bool GetAllVertexIDs_bHasVertexIDGaps_IsValid;

	private static FFieldAddress GetAllVertexIDs_bHasVertexIDGaps_PropertyAddress;

	private static int GetAllVertexIDs_bHasVertexIDGaps_Offset;

	private static bool GetAllVertexIDs_ReturnValue_IsValid;

	private static FFieldAddress GetAllVertexIDs_ReturnValue_PropertyAddress;

	private static int GetAllVertexIDs_ReturnValue_Offset;

	private static bool GetAllTriangleIndices_IsValid;

	private static IntPtr GetAllTriangleIndices_FunctionAddress;

	private static int GetAllTriangleIndices_ParamsSize;

	private static bool GetAllTriangleIndices_TargetMesh_IsValid;

	private static FFieldAddress GetAllTriangleIndices_TargetMesh_PropertyAddress;

	private static int GetAllTriangleIndices_TargetMesh_Offset;

	private static bool GetAllTriangleIndices_TriangleList_IsValid;

	private static FFieldAddress GetAllTriangleIndices_TriangleList_PropertyAddress;

	private static int GetAllTriangleIndices_TriangleList_Offset;

	private static bool GetAllTriangleIndices_bSkipGaps_IsValid;

	private static FFieldAddress GetAllTriangleIndices_bSkipGaps_PropertyAddress;

	private static int GetAllTriangleIndices_bSkipGaps_Offset;

	private static bool GetAllTriangleIndices_bHasTriangleIDGaps_IsValid;

	private static FFieldAddress GetAllTriangleIndices_bHasTriangleIDGaps_PropertyAddress;

	private static int GetAllTriangleIndices_bHasTriangleIDGaps_Offset;

	private static bool GetAllTriangleIndices_ReturnValue_IsValid;

	private static FFieldAddress GetAllTriangleIndices_ReturnValue_PropertyAddress;

	private static int GetAllTriangleIndices_ReturnValue_Offset;

	private static bool GetAllTriangleIDs_IsValid;

	private static IntPtr GetAllTriangleIDs_FunctionAddress;

	private static int GetAllTriangleIDs_ParamsSize;

	private static bool GetAllTriangleIDs_TargetMesh_IsValid;

	private static FFieldAddress GetAllTriangleIDs_TargetMesh_PropertyAddress;

	private static int GetAllTriangleIDs_TargetMesh_Offset;

	private static bool GetAllTriangleIDs_TriangleIDList_IsValid;

	private static FFieldAddress GetAllTriangleIDs_TriangleIDList_PropertyAddress;

	private static int GetAllTriangleIDs_TriangleIDList_Offset;

	private static bool GetAllTriangleIDs_bHasTriangleIDGaps_IsValid;

	private static FFieldAddress GetAllTriangleIDs_bHasTriangleIDGaps_PropertyAddress;

	private static int GetAllTriangleIDs_bHasTriangleIDGaps_Offset;

	private static bool GetAllTriangleIDs_ReturnValue_IsValid;

	private static FFieldAddress GetAllTriangleIDs_ReturnValue_PropertyAddress;

	private static int GetAllTriangleIDs_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:IsValidVertexID")]
	public unsafe static bool IsValidVertexID(UDynamicMesh TargetMesh, int VertexID)
	{
		if (!IsValidVertexID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:IsValidVertexID");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidVertexID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidVertexID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, IsValidVertexID_TargetMesh_Offset), 0, IsValidVertexID_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsValidVertexID_VertexID_Offset), 0, IsValidVertexID_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidVertexID_FunctionAddress, intPtr, IsValidVertexID_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidVertexID_ReturnValue_Offset), 0, IsValidVertexID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:IsValidTriangleID")]
	public unsafe static bool IsValidTriangleID(UDynamicMesh TargetMesh, int TriangleID)
	{
		if (!IsValidTriangleID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:IsValidTriangleID");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidTriangleID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidTriangleID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, IsValidTriangleID_TargetMesh_Offset), 0, IsValidTriangleID_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsValidTriangleID_TriangleID_Offset), 0, IsValidTriangleID_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidTriangleID_FunctionAddress, intPtr, IsValidTriangleID_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidTriangleID_ReturnValue_Offset), 0, IsValidTriangleID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetVertexPosition")]
	public unsafe static FVector GetVertexPosition(UDynamicMesh TargetMesh, int VertexID, out bool bIsValidVertex)
	{
		if (!GetVertexPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetVertexPosition");
			bIsValidVertex = false;
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetVertexPosition_TargetMesh_Offset), 0, GetVertexPosition_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVertexPosition_VertexID_Offset), 0, GetVertexPosition_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVertexPosition_FunctionAddress, intPtr, GetVertexPosition_ParamsSize);
		bIsValidVertex = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetVertexPosition_bIsValidVertex_Offset), 0, GetVertexPosition_bIsValidVertex_PropertyAddress.Address);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVertexPosition_ReturnValue_Offset), 0, GetVertexPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetVertexCount")]
	public unsafe static int GetVertexCount(UDynamicMesh TargetMesh)
	{
		if (!GetVertexCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetVertexCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetVertexCount_TargetMesh_Offset), 0, GetVertexCount_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVertexCount_FunctionAddress, intPtr, GetVertexCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetVertexCount_ReturnValue_Offset), 0, GetVertexCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetUVSetBoundingBox")]
	public unsafe static FBox2D GetUVSetBoundingBox(UDynamicMesh TargetMesh, int UVSetIndex, out bool bIsValidUVSet, out bool bUVSetIsEmpty)
	{
		if (!GetUVSetBoundingBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetUVSetBoundingBox");
			bIsValidUVSet = false;
			bUVSetIsEmpty = false;
			return default(FBox2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUVSetBoundingBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUVSetBoundingBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetUVSetBoundingBox_TargetMesh_Offset), 0, GetUVSetBoundingBox_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetUVSetBoundingBox_UVSetIndex_Offset), 0, GetUVSetBoundingBox_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUVSetBoundingBox_FunctionAddress, intPtr, GetUVSetBoundingBox_ParamsSize);
		bIsValidUVSet = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetUVSetBoundingBox_bIsValidUVSet_Offset), 0, GetUVSetBoundingBox_bIsValidUVSet_PropertyAddress.Address);
		bUVSetIsEmpty = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetUVSetBoundingBox_bUVSetIsEmpty_Offset), 0, GetUVSetBoundingBox_bUVSetIsEmpty_PropertyAddress.Address);
		return BlittableTypeMarshaler<FBox2D>.FromNative(IntPtr.Add(intPtr, GetUVSetBoundingBox_ReturnValue_Offset), 0, GetUVSetBoundingBox_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTriangleUVs")]
	public unsafe static void GetTriangleUVs(UDynamicMesh TargetMesh, int UVSetIndex, int TriangleID, out FVector2D UV1, out FVector2D UV2, out FVector2D UV3, out bool bHaveValidUVs)
	{
		if (!GetTriangleUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTriangleUVs");
			UV1 = default(FVector2D);
			UV2 = default(FVector2D);
			UV3 = default(FVector2D);
			bHaveValidUVs = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetTriangleUVs_TargetMesh_Offset), 0, GetTriangleUVs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTriangleUVs_UVSetIndex_Offset), 0, GetTriangleUVs_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTriangleUVs_TriangleID_Offset), 0, GetTriangleUVs_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTriangleUVs_FunctionAddress, intPtr, GetTriangleUVs_ParamsSize);
		UV1 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetTriangleUVs_UV1_Offset), 0, GetTriangleUVs_UV1_PropertyAddress.Address);
		UV2 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetTriangleUVs_UV2_Offset), 0, GetTriangleUVs_UV2_PropertyAddress.Address);
		UV3 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetTriangleUVs_UV3_Offset), 0, GetTriangleUVs_UV3_PropertyAddress.Address);
		bHaveValidUVs = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTriangleUVs_bHaveValidUVs_Offset), 0, GetTriangleUVs_bHaveValidUVs_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTrianglePositions")]
	public unsafe static void GetTrianglePositions(UDynamicMesh TargetMesh, int TriangleID, out bool bIsValidTriangle, out FVector Vertex1, out FVector Vertex2, out FVector Vertex3)
	{
		if (!GetTrianglePositions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTrianglePositions");
			bIsValidTriangle = false;
			Vertex1 = default(FVector);
			Vertex2 = default(FVector);
			Vertex3 = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrianglePositions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrianglePositions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetTrianglePositions_TargetMesh_Offset), 0, GetTrianglePositions_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTrianglePositions_TriangleID_Offset), 0, GetTrianglePositions_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTrianglePositions_FunctionAddress, intPtr, GetTrianglePositions_ParamsSize);
		bIsValidTriangle = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTrianglePositions_bIsValidTriangle_Offset), 0, GetTrianglePositions_bIsValidTriangle_PropertyAddress.Address);
		Vertex1 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTrianglePositions_Vertex1_Offset), 0, GetTrianglePositions_Vertex1_PropertyAddress.Address);
		Vertex2 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTrianglePositions_Vertex2_Offset), 0, GetTrianglePositions_Vertex2_PropertyAddress.Address);
		Vertex3 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTrianglePositions_Vertex3_Offset), 0, GetTrianglePositions_Vertex3_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTriangleIndices")]
	public unsafe static FIntVector GetTriangleIndices(UDynamicMesh TargetMesh, int TriangleID, out bool bIsValidTriangle)
	{
		if (!GetTriangleIndices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTriangleIndices");
			bIsValidTriangle = false;
			return default(FIntVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleIndices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleIndices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetTriangleIndices_TargetMesh_Offset), 0, GetTriangleIndices_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTriangleIndices_TriangleID_Offset), 0, GetTriangleIndices_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTriangleIndices_FunctionAddress, intPtr, GetTriangleIndices_ParamsSize);
		bIsValidTriangle = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTriangleIndices_bIsValidTriangle_Offset), 0, GetTriangleIndices_bIsValidTriangle_PropertyAddress.Address);
		return BlittableTypeMarshaler<FIntVector>.FromNative(IntPtr.Add(intPtr, GetTriangleIndices_ReturnValue_Offset), 0, GetTriangleIndices_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTriangleFaceNormal")]
	public unsafe static FVector GetTriangleFaceNormal(UDynamicMesh TargetMesh, int TriangleID, out bool bIsValidTriangle)
	{
		if (!GetTriangleFaceNormal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTriangleFaceNormal");
			bIsValidTriangle = false;
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleFaceNormal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleFaceNormal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetTriangleFaceNormal_TargetMesh_Offset), 0, GetTriangleFaceNormal_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTriangleFaceNormal_TriangleID_Offset), 0, GetTriangleFaceNormal_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTriangleFaceNormal_FunctionAddress, intPtr, GetTriangleFaceNormal_ParamsSize);
		bIsValidTriangle = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTriangleFaceNormal_bIsValidTriangle_Offset), 0, GetTriangleFaceNormal_bIsValidTriangle_PropertyAddress.Address);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTriangleFaceNormal_ReturnValue_Offset), 0, GetTriangleFaceNormal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumVertexIDs")]
	public unsafe static int GetNumVertexIDs(UDynamicMesh TargetMesh)
	{
		if (!GetNumVertexIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumVertexIDs");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVertexIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVertexIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetNumVertexIDs_TargetMesh_Offset), 0, GetNumVertexIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumVertexIDs_FunctionAddress, intPtr, GetNumVertexIDs_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVertexIDs_ReturnValue_Offset), 0, GetNumVertexIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumUVSets")]
	public unsafe static int GetNumUVSets(UDynamicMesh TargetMesh)
	{
		if (!GetNumUVSets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumUVSets");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumUVSets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumUVSets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetNumUVSets_TargetMesh_Offset), 0, GetNumUVSets_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumUVSets_FunctionAddress, intPtr, GetNumUVSets_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumUVSets_ReturnValue_Offset), 0, GetNumUVSets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumTriangleIDs")]
	public unsafe static int GetNumTriangleIDs(UDynamicMesh TargetMesh)
	{
		if (!GetNumTriangleIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumTriangleIDs");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumTriangleIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumTriangleIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetNumTriangleIDs_TargetMesh_Offset), 0, GetNumTriangleIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumTriangleIDs_FunctionAddress, intPtr, GetNumTriangleIDs_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumTriangleIDs_ReturnValue_Offset), 0, GetNumTriangleIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumOpenBorderLoops")]
	public unsafe static int GetNumOpenBorderLoops(UDynamicMesh TargetMesh, out bool bAmbiguousTopologyFound)
	{
		if (!GetNumOpenBorderLoops_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumOpenBorderLoops");
			bAmbiguousTopologyFound = false;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumOpenBorderLoops_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumOpenBorderLoops_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetNumOpenBorderLoops_TargetMesh_Offset), 0, GetNumOpenBorderLoops_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumOpenBorderLoops_FunctionAddress, intPtr, GetNumOpenBorderLoops_ParamsSize);
		bAmbiguousTopologyFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetNumOpenBorderLoops_bAmbiguousTopologyFound_Offset), 0, GetNumOpenBorderLoops_bAmbiguousTopologyFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumOpenBorderLoops_ReturnValue_Offset), 0, GetNumOpenBorderLoops_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumOpenBorderEdges")]
	public unsafe static int GetNumOpenBorderEdges(UDynamicMesh TargetMesh)
	{
		if (!GetNumOpenBorderEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumOpenBorderEdges");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumOpenBorderEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumOpenBorderEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetNumOpenBorderEdges_TargetMesh_Offset), 0, GetNumOpenBorderEdges_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumOpenBorderEdges_FunctionAddress, intPtr, GetNumOpenBorderEdges_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumOpenBorderEdges_ReturnValue_Offset), 0, GetNumOpenBorderEdges_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumExtendedPolygroupLayers")]
	public unsafe static int GetNumExtendedPolygroupLayers(UDynamicMesh TargetMesh)
	{
		if (!GetNumExtendedPolygroupLayers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumExtendedPolygroupLayers");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumExtendedPolygroupLayers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumExtendedPolygroupLayers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetNumExtendedPolygroupLayers_TargetMesh_Offset), 0, GetNumExtendedPolygroupLayers_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumExtendedPolygroupLayers_FunctionAddress, intPtr, GetNumExtendedPolygroupLayers_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumExtendedPolygroupLayers_ReturnValue_Offset), 0, GetNumExtendedPolygroupLayers_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumConnectedComponents")]
	public unsafe static int GetNumConnectedComponents(UDynamicMesh TargetMesh)
	{
		if (!GetNumConnectedComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumConnectedComponents");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumConnectedComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumConnectedComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetNumConnectedComponents_TargetMesh_Offset), 0, GetNumConnectedComponents_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumConnectedComponents_FunctionAddress, intPtr, GetNumConnectedComponents_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumConnectedComponents_ReturnValue_Offset), 0, GetNumConnectedComponents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetMeshVolumeArea")]
	public unsafe static void GetMeshVolumeArea(UDynamicMesh TargetMesh, out float SurfaceArea, out float Volume)
	{
		if (!GetMeshVolumeArea_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetMeshVolumeArea");
			SurfaceArea = 0f;
			Volume = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshVolumeArea_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshVolumeArea_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetMeshVolumeArea_TargetMesh_Offset), 0, GetMeshVolumeArea_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMeshVolumeArea_FunctionAddress, intPtr, GetMeshVolumeArea_ParamsSize);
		SurfaceArea = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMeshVolumeArea_SurfaceArea_Offset), 0, GetMeshVolumeArea_SurfaceArea_PropertyAddress.Address);
		Volume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMeshVolumeArea_Volume_Offset), 0, GetMeshVolumeArea_Volume_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetMeshHasAttributeSet")]
	public unsafe static bool GetMeshHasAttributeSet(UDynamicMesh TargetMesh)
	{
		if (!GetMeshHasAttributeSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetMeshHasAttributeSet");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshHasAttributeSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshHasAttributeSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetMeshHasAttributeSet_TargetMesh_Offset), 0, GetMeshHasAttributeSet_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMeshHasAttributeSet_FunctionAddress, intPtr, GetMeshHasAttributeSet_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetMeshHasAttributeSet_ReturnValue_Offset), 0, GetMeshHasAttributeSet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetMeshBoundingBox")]
	public unsafe static FBox GetMeshBoundingBox(UDynamicMesh TargetMesh)
	{
		if (!GetMeshBoundingBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetMeshBoundingBox");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshBoundingBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshBoundingBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetMeshBoundingBox_TargetMesh_Offset), 0, GetMeshBoundingBox_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMeshBoundingBox_FunctionAddress, intPtr, GetMeshBoundingBox_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetMeshBoundingBox_ReturnValue_Offset), 0, GetMeshBoundingBox_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetIsDenseMesh")]
	public unsafe static bool GetIsDenseMesh(UDynamicMesh TargetMesh)
	{
		if (!GetIsDenseMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetIsDenseMesh");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsDenseMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsDenseMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetIsDenseMesh_TargetMesh_Offset), 0, GetIsDenseMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsDenseMesh_FunctionAddress, intPtr, GetIsDenseMesh_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsDenseMesh_ReturnValue_Offset), 0, GetIsDenseMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetIsClosedMesh")]
	public unsafe static bool GetIsClosedMesh(UDynamicMesh TargetMesh)
	{
		if (!GetIsClosedMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetIsClosedMesh");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsClosedMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsClosedMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetIsClosedMesh_TargetMesh_Offset), 0, GetIsClosedMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsClosedMesh_FunctionAddress, intPtr, GetIsClosedMesh_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsClosedMesh_ReturnValue_Offset), 0, GetIsClosedMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasVertexIDGaps")]
	public unsafe static bool GetHasVertexIDGaps(UDynamicMesh TargetMesh)
	{
		if (!GetHasVertexIDGaps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasVertexIDGaps");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHasVertexIDGaps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHasVertexIDGaps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetHasVertexIDGaps_TargetMesh_Offset), 0, GetHasVertexIDGaps_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHasVertexIDGaps_FunctionAddress, intPtr, GetHasVertexIDGaps_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHasVertexIDGaps_ReturnValue_Offset), 0, GetHasVertexIDGaps_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasTriangleIDGaps")]
	public unsafe static bool GetHasTriangleIDGaps(UDynamicMesh TargetMesh)
	{
		if (!GetHasTriangleIDGaps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasTriangleIDGaps");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHasTriangleIDGaps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHasTriangleIDGaps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetHasTriangleIDGaps_TargetMesh_Offset), 0, GetHasTriangleIDGaps_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHasTriangleIDGaps_FunctionAddress, intPtr, GetHasTriangleIDGaps_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHasTriangleIDGaps_ReturnValue_Offset), 0, GetHasTriangleIDGaps_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasPolygroups")]
	public unsafe static bool GetHasPolygroups(UDynamicMesh TargetMesh)
	{
		if (!GetHasPolygroups_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasPolygroups");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHasPolygroups_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHasPolygroups_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetHasPolygroups_TargetMesh_Offset), 0, GetHasPolygroups_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHasPolygroups_FunctionAddress, intPtr, GetHasPolygroups_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHasPolygroups_ReturnValue_Offset), 0, GetHasPolygroups_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasMaterialIDs")]
	public unsafe static bool GetHasMaterialIDs(UDynamicMesh TargetMesh)
	{
		if (!GetHasMaterialIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasMaterialIDs");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHasMaterialIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHasMaterialIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetHasMaterialIDs_TargetMesh_Offset), 0, GetHasMaterialIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHasMaterialIDs_FunctionAddress, intPtr, GetHasMaterialIDs_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHasMaterialIDs_ReturnValue_Offset), 0, GetHasMaterialIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllVertexPositions")]
	public unsafe static UDynamicMesh GetAllVertexPositions(UDynamicMesh TargetMesh, out FGeometryScriptVectorList PositionList, bool bSkipGaps, out bool bHasVertexIDGaps)
	{
		if (!GetAllVertexPositions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllVertexPositions");
			PositionList = default(FGeometryScriptVectorList);
			bHasVertexIDGaps = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllVertexPositions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllVertexPositions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetAllVertexPositions_TargetMesh_Offset), 0, GetAllVertexPositions_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(GetAllVertexPositions_PositionList_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllVertexPositions_bSkipGaps_Offset), 0, GetAllVertexPositions_bSkipGaps_PropertyAddress.Address, bSkipGaps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllVertexPositions_FunctionAddress, intPtr, GetAllVertexPositions_ParamsSize);
		PositionList = FGeometryScriptVectorList.FromNative(IntPtr.Add(intPtr, GetAllVertexPositions_PositionList_Offset), 0, GetAllVertexPositions_PositionList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAllVertexPositions_PositionList_PropertyAddress.Address, intPtr);
		bHasVertexIDGaps = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllVertexPositions_bHasVertexIDGaps_Offset), 0, GetAllVertexPositions_bHasVertexIDGaps_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetAllVertexPositions_ReturnValue_Offset), 0, GetAllVertexPositions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllVertexIDs")]
	public unsafe static UDynamicMesh GetAllVertexIDs(UDynamicMesh TargetMesh, out FGeometryScriptIndexList VertexIDList, out bool bHasVertexIDGaps)
	{
		if (!GetAllVertexIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllVertexIDs");
			VertexIDList = default(FGeometryScriptIndexList);
			bHasVertexIDGaps = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllVertexIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllVertexIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetAllVertexIDs_TargetMesh_Offset), 0, GetAllVertexIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(GetAllVertexIDs_VertexIDList_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllVertexIDs_FunctionAddress, intPtr, GetAllVertexIDs_ParamsSize);
		VertexIDList = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, GetAllVertexIDs_VertexIDList_Offset), 0, GetAllVertexIDs_VertexIDList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAllVertexIDs_VertexIDList_PropertyAddress.Address, intPtr);
		bHasVertexIDGaps = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllVertexIDs_bHasVertexIDGaps_Offset), 0, GetAllVertexIDs_bHasVertexIDGaps_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetAllVertexIDs_ReturnValue_Offset), 0, GetAllVertexIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllTriangleIndices")]
	public unsafe static UDynamicMesh GetAllTriangleIndices(UDynamicMesh TargetMesh, out FGeometryScriptTriangleList TriangleList, bool bSkipGaps, out bool bHasTriangleIDGaps)
	{
		if (!GetAllTriangleIndices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllTriangleIndices");
			TriangleList = default(FGeometryScriptTriangleList);
			bHasTriangleIDGaps = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllTriangleIndices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllTriangleIndices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetAllTriangleIndices_TargetMesh_Offset), 0, GetAllTriangleIndices_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(GetAllTriangleIndices_TriangleList_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllTriangleIndices_bSkipGaps_Offset), 0, GetAllTriangleIndices_bSkipGaps_PropertyAddress.Address, bSkipGaps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllTriangleIndices_FunctionAddress, intPtr, GetAllTriangleIndices_ParamsSize);
		TriangleList = FGeometryScriptTriangleList.FromNative(IntPtr.Add(intPtr, GetAllTriangleIndices_TriangleList_Offset), 0, GetAllTriangleIndices_TriangleList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAllTriangleIndices_TriangleList_PropertyAddress.Address, intPtr);
		bHasTriangleIDGaps = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllTriangleIndices_bHasTriangleIDGaps_Offset), 0, GetAllTriangleIndices_bHasTriangleIDGaps_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetAllTriangleIndices_ReturnValue_Offset), 0, GetAllTriangleIndices_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllTriangleIDs")]
	public unsafe static UDynamicMesh GetAllTriangleIDs(UDynamicMesh TargetMesh, out FGeometryScriptIndexList TriangleIDList, out bool bHasTriangleIDGaps)
	{
		if (!GetAllTriangleIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllTriangleIDs");
			TriangleIDList = default(FGeometryScriptIndexList);
			bHasTriangleIDGaps = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllTriangleIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllTriangleIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetAllTriangleIDs_TargetMesh_Offset), 0, GetAllTriangleIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(GetAllTriangleIDs_TriangleIDList_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllTriangleIDs_FunctionAddress, intPtr, GetAllTriangleIDs_ParamsSize);
		TriangleIDList = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, GetAllTriangleIDs_TriangleIDList_Offset), 0, GetAllTriangleIDs_TriangleIDList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAllTriangleIDs_TriangleIDList_PropertyAddress.Address, intPtr);
		bHasTriangleIDGaps = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllTriangleIDs_bHasTriangleIDGaps_Offset), 0, GetAllTriangleIDs_bHasTriangleIDGaps_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetAllTriangleIDs_ReturnValue_Offset), 0, GetAllTriangleIDs_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshQueries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshQueries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshQueries));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions");
		IsValidVertexID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidVertexID");
		IsValidVertexID_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidVertexID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidVertexID_TargetMesh_PropertyAddress, IsValidVertexID_FunctionAddress, "TargetMesh");
		IsValidVertexID_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsValidVertexID_FunctionAddress, "TargetMesh");
		IsValidVertexID_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidVertexID_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidVertexID_VertexID_PropertyAddress, IsValidVertexID_FunctionAddress, "VertexID");
		IsValidVertexID_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(IsValidVertexID_FunctionAddress, "VertexID");
		IsValidVertexID_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidVertexID_FunctionAddress, "VertexID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidVertexID_ReturnValue_PropertyAddress, IsValidVertexID_FunctionAddress, "ReturnValue");
		IsValidVertexID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidVertexID_FunctionAddress, "ReturnValue");
		IsValidVertexID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidVertexID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidVertexID_IsValid = IsValidVertexID_FunctionAddress != IntPtr.Zero && IsValidVertexID_TargetMesh_IsValid && IsValidVertexID_VertexID_IsValid && IsValidVertexID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:IsValidVertexID", IsValidVertexID_IsValid);
		IsValidTriangleID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidTriangleID");
		IsValidTriangleID_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidTriangleID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidTriangleID_TargetMesh_PropertyAddress, IsValidTriangleID_FunctionAddress, "TargetMesh");
		IsValidTriangleID_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsValidTriangleID_FunctionAddress, "TargetMesh");
		IsValidTriangleID_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidTriangleID_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidTriangleID_TriangleID_PropertyAddress, IsValidTriangleID_FunctionAddress, "TriangleID");
		IsValidTriangleID_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(IsValidTriangleID_FunctionAddress, "TriangleID");
		IsValidTriangleID_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidTriangleID_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidTriangleID_ReturnValue_PropertyAddress, IsValidTriangleID_FunctionAddress, "ReturnValue");
		IsValidTriangleID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidTriangleID_FunctionAddress, "ReturnValue");
		IsValidTriangleID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidTriangleID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidTriangleID_IsValid = IsValidTriangleID_FunctionAddress != IntPtr.Zero && IsValidTriangleID_TargetMesh_IsValid && IsValidTriangleID_TriangleID_IsValid && IsValidTriangleID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:IsValidTriangleID", IsValidTriangleID_IsValid);
		GetVertexPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVertexPosition");
		GetVertexPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexPosition_TargetMesh_PropertyAddress, GetVertexPosition_FunctionAddress, "TargetMesh");
		GetVertexPosition_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexPosition_FunctionAddress, "TargetMesh");
		GetVertexPosition_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexPosition_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexPosition_VertexID_PropertyAddress, GetVertexPosition_FunctionAddress, "VertexID");
		GetVertexPosition_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexPosition_FunctionAddress, "VertexID");
		GetVertexPosition_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexPosition_FunctionAddress, "VertexID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexPosition_bIsValidVertex_PropertyAddress, GetVertexPosition_FunctionAddress, "bIsValidVertex");
		GetVertexPosition_bIsValidVertex_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexPosition_FunctionAddress, "bIsValidVertex");
		GetVertexPosition_bIsValidVertex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexPosition_FunctionAddress, "bIsValidVertex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexPosition_ReturnValue_PropertyAddress, GetVertexPosition_FunctionAddress, "ReturnValue");
		GetVertexPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexPosition_FunctionAddress, "ReturnValue");
		GetVertexPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVertexPosition_IsValid = GetVertexPosition_FunctionAddress != IntPtr.Zero && GetVertexPosition_TargetMesh_IsValid && GetVertexPosition_VertexID_IsValid && GetVertexPosition_bIsValidVertex_IsValid && GetVertexPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetVertexPosition", GetVertexPosition_IsValid);
		GetVertexCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVertexCount");
		GetVertexCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexCount_TargetMesh_PropertyAddress, GetVertexCount_FunctionAddress, "TargetMesh");
		GetVertexCount_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexCount_FunctionAddress, "TargetMesh");
		GetVertexCount_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexCount_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexCount_ReturnValue_PropertyAddress, GetVertexCount_FunctionAddress, "ReturnValue");
		GetVertexCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexCount_FunctionAddress, "ReturnValue");
		GetVertexCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetVertexCount_IsValid = GetVertexCount_FunctionAddress != IntPtr.Zero && GetVertexCount_TargetMesh_IsValid && GetVertexCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetVertexCount", GetVertexCount_IsValid);
		GetUVSetBoundingBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUVSetBoundingBox");
		GetUVSetBoundingBox_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUVSetBoundingBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUVSetBoundingBox_TargetMesh_PropertyAddress, GetUVSetBoundingBox_FunctionAddress, "TargetMesh");
		GetUVSetBoundingBox_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetUVSetBoundingBox_FunctionAddress, "TargetMesh");
		GetUVSetBoundingBox_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVSetBoundingBox_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUVSetBoundingBox_UVSetIndex_PropertyAddress, GetUVSetBoundingBox_FunctionAddress, "UVSetIndex");
		GetUVSetBoundingBox_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetUVSetBoundingBox_FunctionAddress, "UVSetIndex");
		GetUVSetBoundingBox_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVSetBoundingBox_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUVSetBoundingBox_bIsValidUVSet_PropertyAddress, GetUVSetBoundingBox_FunctionAddress, "bIsValidUVSet");
		GetUVSetBoundingBox_bIsValidUVSet_Offset = NativeReflectionCached.GetPropertyOffset(GetUVSetBoundingBox_FunctionAddress, "bIsValidUVSet");
		GetUVSetBoundingBox_bIsValidUVSet_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVSetBoundingBox_FunctionAddress, "bIsValidUVSet", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUVSetBoundingBox_bUVSetIsEmpty_PropertyAddress, GetUVSetBoundingBox_FunctionAddress, "bUVSetIsEmpty");
		GetUVSetBoundingBox_bUVSetIsEmpty_Offset = NativeReflectionCached.GetPropertyOffset(GetUVSetBoundingBox_FunctionAddress, "bUVSetIsEmpty");
		GetUVSetBoundingBox_bUVSetIsEmpty_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVSetBoundingBox_FunctionAddress, "bUVSetIsEmpty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUVSetBoundingBox_ReturnValue_PropertyAddress, GetUVSetBoundingBox_FunctionAddress, "ReturnValue");
		GetUVSetBoundingBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUVSetBoundingBox_FunctionAddress, "ReturnValue");
		GetUVSetBoundingBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVSetBoundingBox_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUVSetBoundingBox_IsValid = GetUVSetBoundingBox_FunctionAddress != IntPtr.Zero && GetUVSetBoundingBox_TargetMesh_IsValid && GetUVSetBoundingBox_UVSetIndex_IsValid && GetUVSetBoundingBox_bIsValidUVSet_IsValid && GetUVSetBoundingBox_bUVSetIsEmpty_IsValid && GetUVSetBoundingBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetUVSetBoundingBox", GetUVSetBoundingBox_IsValid);
		GetTriangleUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTriangleUVs");
		GetTriangleUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleUVs_TargetMesh_PropertyAddress, GetTriangleUVs_FunctionAddress, "TargetMesh");
		GetTriangleUVs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleUVs_FunctionAddress, "TargetMesh");
		GetTriangleUVs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleUVs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleUVs_UVSetIndex_PropertyAddress, GetTriangleUVs_FunctionAddress, "UVSetIndex");
		GetTriangleUVs_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleUVs_FunctionAddress, "UVSetIndex");
		GetTriangleUVs_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleUVs_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleUVs_TriangleID_PropertyAddress, GetTriangleUVs_FunctionAddress, "TriangleID");
		GetTriangleUVs_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleUVs_FunctionAddress, "TriangleID");
		GetTriangleUVs_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleUVs_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleUVs_UV1_PropertyAddress, GetTriangleUVs_FunctionAddress, "UV1");
		GetTriangleUVs_UV1_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleUVs_FunctionAddress, "UV1");
		GetTriangleUVs_UV1_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleUVs_FunctionAddress, "UV1", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleUVs_UV2_PropertyAddress, GetTriangleUVs_FunctionAddress, "UV2");
		GetTriangleUVs_UV2_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleUVs_FunctionAddress, "UV2");
		GetTriangleUVs_UV2_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleUVs_FunctionAddress, "UV2", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleUVs_UV3_PropertyAddress, GetTriangleUVs_FunctionAddress, "UV3");
		GetTriangleUVs_UV3_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleUVs_FunctionAddress, "UV3");
		GetTriangleUVs_UV3_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleUVs_FunctionAddress, "UV3", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleUVs_bHaveValidUVs_PropertyAddress, GetTriangleUVs_FunctionAddress, "bHaveValidUVs");
		GetTriangleUVs_bHaveValidUVs_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleUVs_FunctionAddress, "bHaveValidUVs");
		GetTriangleUVs_bHaveValidUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleUVs_FunctionAddress, "bHaveValidUVs", Classes.FBoolProperty);
		GetTriangleUVs_IsValid = GetTriangleUVs_FunctionAddress != IntPtr.Zero && GetTriangleUVs_TargetMesh_IsValid && GetTriangleUVs_UVSetIndex_IsValid && GetTriangleUVs_TriangleID_IsValid && GetTriangleUVs_UV1_IsValid && GetTriangleUVs_UV2_IsValid && GetTriangleUVs_UV3_IsValid && GetTriangleUVs_bHaveValidUVs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTriangleUVs", GetTriangleUVs_IsValid);
		GetTrianglePositions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTrianglePositions");
		GetTrianglePositions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrianglePositions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePositions_TargetMesh_PropertyAddress, GetTrianglePositions_FunctionAddress, "TargetMesh");
		GetTrianglePositions_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePositions_FunctionAddress, "TargetMesh");
		GetTrianglePositions_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePositions_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePositions_TriangleID_PropertyAddress, GetTrianglePositions_FunctionAddress, "TriangleID");
		GetTrianglePositions_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePositions_FunctionAddress, "TriangleID");
		GetTrianglePositions_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePositions_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePositions_bIsValidTriangle_PropertyAddress, GetTrianglePositions_FunctionAddress, "bIsValidTriangle");
		GetTrianglePositions_bIsValidTriangle_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePositions_FunctionAddress, "bIsValidTriangle");
		GetTrianglePositions_bIsValidTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePositions_FunctionAddress, "bIsValidTriangle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePositions_Vertex1_PropertyAddress, GetTrianglePositions_FunctionAddress, "Vertex1");
		GetTrianglePositions_Vertex1_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePositions_FunctionAddress, "Vertex1");
		GetTrianglePositions_Vertex1_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePositions_FunctionAddress, "Vertex1", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePositions_Vertex2_PropertyAddress, GetTrianglePositions_FunctionAddress, "Vertex2");
		GetTrianglePositions_Vertex2_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePositions_FunctionAddress, "Vertex2");
		GetTrianglePositions_Vertex2_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePositions_FunctionAddress, "Vertex2", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePositions_Vertex3_PropertyAddress, GetTrianglePositions_FunctionAddress, "Vertex3");
		GetTrianglePositions_Vertex3_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePositions_FunctionAddress, "Vertex3");
		GetTrianglePositions_Vertex3_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePositions_FunctionAddress, "Vertex3", Classes.FStructProperty);
		GetTrianglePositions_IsValid = GetTrianglePositions_FunctionAddress != IntPtr.Zero && GetTrianglePositions_TargetMesh_IsValid && GetTrianglePositions_TriangleID_IsValid && GetTrianglePositions_bIsValidTriangle_IsValid && GetTrianglePositions_Vertex1_IsValid && GetTrianglePositions_Vertex2_IsValid && GetTrianglePositions_Vertex3_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTrianglePositions", GetTrianglePositions_IsValid);
		GetTriangleIndices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTriangleIndices");
		GetTriangleIndices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleIndices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleIndices_TargetMesh_PropertyAddress, GetTriangleIndices_FunctionAddress, "TargetMesh");
		GetTriangleIndices_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleIndices_FunctionAddress, "TargetMesh");
		GetTriangleIndices_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleIndices_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleIndices_TriangleID_PropertyAddress, GetTriangleIndices_FunctionAddress, "TriangleID");
		GetTriangleIndices_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleIndices_FunctionAddress, "TriangleID");
		GetTriangleIndices_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleIndices_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleIndices_bIsValidTriangle_PropertyAddress, GetTriangleIndices_FunctionAddress, "bIsValidTriangle");
		GetTriangleIndices_bIsValidTriangle_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleIndices_FunctionAddress, "bIsValidTriangle");
		GetTriangleIndices_bIsValidTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleIndices_FunctionAddress, "bIsValidTriangle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleIndices_ReturnValue_PropertyAddress, GetTriangleIndices_FunctionAddress, "ReturnValue");
		GetTriangleIndices_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleIndices_FunctionAddress, "ReturnValue");
		GetTriangleIndices_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleIndices_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTriangleIndices_IsValid = GetTriangleIndices_FunctionAddress != IntPtr.Zero && GetTriangleIndices_TargetMesh_IsValid && GetTriangleIndices_TriangleID_IsValid && GetTriangleIndices_bIsValidTriangle_IsValid && GetTriangleIndices_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTriangleIndices", GetTriangleIndices_IsValid);
		GetTriangleFaceNormal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTriangleFaceNormal");
		GetTriangleFaceNormal_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleFaceNormal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleFaceNormal_TargetMesh_PropertyAddress, GetTriangleFaceNormal_FunctionAddress, "TargetMesh");
		GetTriangleFaceNormal_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleFaceNormal_FunctionAddress, "TargetMesh");
		GetTriangleFaceNormal_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleFaceNormal_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleFaceNormal_TriangleID_PropertyAddress, GetTriangleFaceNormal_FunctionAddress, "TriangleID");
		GetTriangleFaceNormal_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleFaceNormal_FunctionAddress, "TriangleID");
		GetTriangleFaceNormal_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleFaceNormal_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleFaceNormal_bIsValidTriangle_PropertyAddress, GetTriangleFaceNormal_FunctionAddress, "bIsValidTriangle");
		GetTriangleFaceNormal_bIsValidTriangle_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleFaceNormal_FunctionAddress, "bIsValidTriangle");
		GetTriangleFaceNormal_bIsValidTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleFaceNormal_FunctionAddress, "bIsValidTriangle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleFaceNormal_ReturnValue_PropertyAddress, GetTriangleFaceNormal_FunctionAddress, "ReturnValue");
		GetTriangleFaceNormal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleFaceNormal_FunctionAddress, "ReturnValue");
		GetTriangleFaceNormal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleFaceNormal_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTriangleFaceNormal_IsValid = GetTriangleFaceNormal_FunctionAddress != IntPtr.Zero && GetTriangleFaceNormal_TargetMesh_IsValid && GetTriangleFaceNormal_TriangleID_IsValid && GetTriangleFaceNormal_bIsValidTriangle_IsValid && GetTriangleFaceNormal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetTriangleFaceNormal", GetTriangleFaceNormal_IsValid);
		GetNumVertexIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumVertexIDs");
		GetNumVertexIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVertexIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexIDs_TargetMesh_PropertyAddress, GetNumVertexIDs_FunctionAddress, "TargetMesh");
		GetNumVertexIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexIDs_FunctionAddress, "TargetMesh");
		GetNumVertexIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexIDs_ReturnValue_PropertyAddress, GetNumVertexIDs_FunctionAddress, "ReturnValue");
		GetNumVertexIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexIDs_FunctionAddress, "ReturnValue");
		GetNumVertexIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexIDs_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVertexIDs_IsValid = GetNumVertexIDs_FunctionAddress != IntPtr.Zero && GetNumVertexIDs_TargetMesh_IsValid && GetNumVertexIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumVertexIDs", GetNumVertexIDs_IsValid);
		GetNumUVSets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumUVSets");
		GetNumUVSets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumUVSets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumUVSets_TargetMesh_PropertyAddress, GetNumUVSets_FunctionAddress, "TargetMesh");
		GetNumUVSets_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumUVSets_FunctionAddress, "TargetMesh");
		GetNumUVSets_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumUVSets_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumUVSets_ReturnValue_PropertyAddress, GetNumUVSets_FunctionAddress, "ReturnValue");
		GetNumUVSets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumUVSets_FunctionAddress, "ReturnValue");
		GetNumUVSets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumUVSets_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumUVSets_IsValid = GetNumUVSets_FunctionAddress != IntPtr.Zero && GetNumUVSets_TargetMesh_IsValid && GetNumUVSets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumUVSets", GetNumUVSets_IsValid);
		GetNumTriangleIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumTriangleIDs");
		GetNumTriangleIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumTriangleIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumTriangleIDs_TargetMesh_PropertyAddress, GetNumTriangleIDs_FunctionAddress, "TargetMesh");
		GetNumTriangleIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTriangleIDs_FunctionAddress, "TargetMesh");
		GetNumTriangleIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTriangleIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumTriangleIDs_ReturnValue_PropertyAddress, GetNumTriangleIDs_FunctionAddress, "ReturnValue");
		GetNumTriangleIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTriangleIDs_FunctionAddress, "ReturnValue");
		GetNumTriangleIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTriangleIDs_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumTriangleIDs_IsValid = GetNumTriangleIDs_FunctionAddress != IntPtr.Zero && GetNumTriangleIDs_TargetMesh_IsValid && GetNumTriangleIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumTriangleIDs", GetNumTriangleIDs_IsValid);
		GetNumOpenBorderLoops_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumOpenBorderLoops");
		GetNumOpenBorderLoops_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumOpenBorderLoops_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumOpenBorderLoops_TargetMesh_PropertyAddress, GetNumOpenBorderLoops_FunctionAddress, "TargetMesh");
		GetNumOpenBorderLoops_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumOpenBorderLoops_FunctionAddress, "TargetMesh");
		GetNumOpenBorderLoops_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumOpenBorderLoops_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumOpenBorderLoops_bAmbiguousTopologyFound_PropertyAddress, GetNumOpenBorderLoops_FunctionAddress, "bAmbiguousTopologyFound");
		GetNumOpenBorderLoops_bAmbiguousTopologyFound_Offset = NativeReflectionCached.GetPropertyOffset(GetNumOpenBorderLoops_FunctionAddress, "bAmbiguousTopologyFound");
		GetNumOpenBorderLoops_bAmbiguousTopologyFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumOpenBorderLoops_FunctionAddress, "bAmbiguousTopologyFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumOpenBorderLoops_ReturnValue_PropertyAddress, GetNumOpenBorderLoops_FunctionAddress, "ReturnValue");
		GetNumOpenBorderLoops_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumOpenBorderLoops_FunctionAddress, "ReturnValue");
		GetNumOpenBorderLoops_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumOpenBorderLoops_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumOpenBorderLoops_IsValid = GetNumOpenBorderLoops_FunctionAddress != IntPtr.Zero && GetNumOpenBorderLoops_TargetMesh_IsValid && GetNumOpenBorderLoops_bAmbiguousTopologyFound_IsValid && GetNumOpenBorderLoops_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumOpenBorderLoops", GetNumOpenBorderLoops_IsValid);
		GetNumOpenBorderEdges_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumOpenBorderEdges");
		GetNumOpenBorderEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumOpenBorderEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumOpenBorderEdges_TargetMesh_PropertyAddress, GetNumOpenBorderEdges_FunctionAddress, "TargetMesh");
		GetNumOpenBorderEdges_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumOpenBorderEdges_FunctionAddress, "TargetMesh");
		GetNumOpenBorderEdges_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumOpenBorderEdges_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumOpenBorderEdges_ReturnValue_PropertyAddress, GetNumOpenBorderEdges_FunctionAddress, "ReturnValue");
		GetNumOpenBorderEdges_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumOpenBorderEdges_FunctionAddress, "ReturnValue");
		GetNumOpenBorderEdges_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumOpenBorderEdges_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumOpenBorderEdges_IsValid = GetNumOpenBorderEdges_FunctionAddress != IntPtr.Zero && GetNumOpenBorderEdges_TargetMesh_IsValid && GetNumOpenBorderEdges_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumOpenBorderEdges", GetNumOpenBorderEdges_IsValid);
		GetNumExtendedPolygroupLayers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumExtendedPolygroupLayers");
		GetNumExtendedPolygroupLayers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumExtendedPolygroupLayers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumExtendedPolygroupLayers_TargetMesh_PropertyAddress, GetNumExtendedPolygroupLayers_FunctionAddress, "TargetMesh");
		GetNumExtendedPolygroupLayers_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumExtendedPolygroupLayers_FunctionAddress, "TargetMesh");
		GetNumExtendedPolygroupLayers_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumExtendedPolygroupLayers_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumExtendedPolygroupLayers_ReturnValue_PropertyAddress, GetNumExtendedPolygroupLayers_FunctionAddress, "ReturnValue");
		GetNumExtendedPolygroupLayers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumExtendedPolygroupLayers_FunctionAddress, "ReturnValue");
		GetNumExtendedPolygroupLayers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumExtendedPolygroupLayers_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumExtendedPolygroupLayers_IsValid = GetNumExtendedPolygroupLayers_FunctionAddress != IntPtr.Zero && GetNumExtendedPolygroupLayers_TargetMesh_IsValid && GetNumExtendedPolygroupLayers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumExtendedPolygroupLayers", GetNumExtendedPolygroupLayers_IsValid);
		GetNumConnectedComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumConnectedComponents");
		GetNumConnectedComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumConnectedComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumConnectedComponents_TargetMesh_PropertyAddress, GetNumConnectedComponents_FunctionAddress, "TargetMesh");
		GetNumConnectedComponents_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumConnectedComponents_FunctionAddress, "TargetMesh");
		GetNumConnectedComponents_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumConnectedComponents_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumConnectedComponents_ReturnValue_PropertyAddress, GetNumConnectedComponents_FunctionAddress, "ReturnValue");
		GetNumConnectedComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumConnectedComponents_FunctionAddress, "ReturnValue");
		GetNumConnectedComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumConnectedComponents_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumConnectedComponents_IsValid = GetNumConnectedComponents_FunctionAddress != IntPtr.Zero && GetNumConnectedComponents_TargetMesh_IsValid && GetNumConnectedComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetNumConnectedComponents", GetNumConnectedComponents_IsValid);
		GetMeshVolumeArea_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMeshVolumeArea");
		GetMeshVolumeArea_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshVolumeArea_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshVolumeArea_TargetMesh_PropertyAddress, GetMeshVolumeArea_FunctionAddress, "TargetMesh");
		GetMeshVolumeArea_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshVolumeArea_FunctionAddress, "TargetMesh");
		GetMeshVolumeArea_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshVolumeArea_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshVolumeArea_SurfaceArea_PropertyAddress, GetMeshVolumeArea_FunctionAddress, "SurfaceArea");
		GetMeshVolumeArea_SurfaceArea_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshVolumeArea_FunctionAddress, "SurfaceArea");
		GetMeshVolumeArea_SurfaceArea_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshVolumeArea_FunctionAddress, "SurfaceArea", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshVolumeArea_Volume_PropertyAddress, GetMeshVolumeArea_FunctionAddress, "Volume");
		GetMeshVolumeArea_Volume_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshVolumeArea_FunctionAddress, "Volume");
		GetMeshVolumeArea_Volume_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshVolumeArea_FunctionAddress, "Volume", Classes.FFloatProperty);
		GetMeshVolumeArea_IsValid = GetMeshVolumeArea_FunctionAddress != IntPtr.Zero && GetMeshVolumeArea_TargetMesh_IsValid && GetMeshVolumeArea_SurfaceArea_IsValid && GetMeshVolumeArea_Volume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetMeshVolumeArea", GetMeshVolumeArea_IsValid);
		GetMeshHasAttributeSet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMeshHasAttributeSet");
		GetMeshHasAttributeSet_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshHasAttributeSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshHasAttributeSet_TargetMesh_PropertyAddress, GetMeshHasAttributeSet_FunctionAddress, "TargetMesh");
		GetMeshHasAttributeSet_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshHasAttributeSet_FunctionAddress, "TargetMesh");
		GetMeshHasAttributeSet_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshHasAttributeSet_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshHasAttributeSet_ReturnValue_PropertyAddress, GetMeshHasAttributeSet_FunctionAddress, "ReturnValue");
		GetMeshHasAttributeSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshHasAttributeSet_FunctionAddress, "ReturnValue");
		GetMeshHasAttributeSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshHasAttributeSet_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetMeshHasAttributeSet_IsValid = GetMeshHasAttributeSet_FunctionAddress != IntPtr.Zero && GetMeshHasAttributeSet_TargetMesh_IsValid && GetMeshHasAttributeSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetMeshHasAttributeSet", GetMeshHasAttributeSet_IsValid);
		GetMeshBoundingBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMeshBoundingBox");
		GetMeshBoundingBox_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshBoundingBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshBoundingBox_TargetMesh_PropertyAddress, GetMeshBoundingBox_FunctionAddress, "TargetMesh");
		GetMeshBoundingBox_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshBoundingBox_FunctionAddress, "TargetMesh");
		GetMeshBoundingBox_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshBoundingBox_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshBoundingBox_ReturnValue_PropertyAddress, GetMeshBoundingBox_FunctionAddress, "ReturnValue");
		GetMeshBoundingBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshBoundingBox_FunctionAddress, "ReturnValue");
		GetMeshBoundingBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshBoundingBox_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMeshBoundingBox_IsValid = GetMeshBoundingBox_FunctionAddress != IntPtr.Zero && GetMeshBoundingBox_TargetMesh_IsValid && GetMeshBoundingBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetMeshBoundingBox", GetMeshBoundingBox_IsValid);
		GetIsDenseMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsDenseMesh");
		GetIsDenseMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsDenseMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsDenseMesh_TargetMesh_PropertyAddress, GetIsDenseMesh_FunctionAddress, "TargetMesh");
		GetIsDenseMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetIsDenseMesh_FunctionAddress, "TargetMesh");
		GetIsDenseMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsDenseMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsDenseMesh_ReturnValue_PropertyAddress, GetIsDenseMesh_FunctionAddress, "ReturnValue");
		GetIsDenseMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsDenseMesh_FunctionAddress, "ReturnValue");
		GetIsDenseMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsDenseMesh_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsDenseMesh_IsValid = GetIsDenseMesh_FunctionAddress != IntPtr.Zero && GetIsDenseMesh_TargetMesh_IsValid && GetIsDenseMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetIsDenseMesh", GetIsDenseMesh_IsValid);
		GetIsClosedMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsClosedMesh");
		GetIsClosedMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsClosedMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsClosedMesh_TargetMesh_PropertyAddress, GetIsClosedMesh_FunctionAddress, "TargetMesh");
		GetIsClosedMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetIsClosedMesh_FunctionAddress, "TargetMesh");
		GetIsClosedMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsClosedMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsClosedMesh_ReturnValue_PropertyAddress, GetIsClosedMesh_FunctionAddress, "ReturnValue");
		GetIsClosedMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsClosedMesh_FunctionAddress, "ReturnValue");
		GetIsClosedMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsClosedMesh_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsClosedMesh_IsValid = GetIsClosedMesh_FunctionAddress != IntPtr.Zero && GetIsClosedMesh_TargetMesh_IsValid && GetIsClosedMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetIsClosedMesh", GetIsClosedMesh_IsValid);
		GetHasVertexIDGaps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHasVertexIDGaps");
		GetHasVertexIDGaps_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHasVertexIDGaps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHasVertexIDGaps_TargetMesh_PropertyAddress, GetHasVertexIDGaps_FunctionAddress, "TargetMesh");
		GetHasVertexIDGaps_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetHasVertexIDGaps_FunctionAddress, "TargetMesh");
		GetHasVertexIDGaps_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHasVertexIDGaps_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHasVertexIDGaps_ReturnValue_PropertyAddress, GetHasVertexIDGaps_FunctionAddress, "ReturnValue");
		GetHasVertexIDGaps_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHasVertexIDGaps_FunctionAddress, "ReturnValue");
		GetHasVertexIDGaps_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHasVertexIDGaps_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHasVertexIDGaps_IsValid = GetHasVertexIDGaps_FunctionAddress != IntPtr.Zero && GetHasVertexIDGaps_TargetMesh_IsValid && GetHasVertexIDGaps_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasVertexIDGaps", GetHasVertexIDGaps_IsValid);
		GetHasTriangleIDGaps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHasTriangleIDGaps");
		GetHasTriangleIDGaps_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHasTriangleIDGaps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHasTriangleIDGaps_TargetMesh_PropertyAddress, GetHasTriangleIDGaps_FunctionAddress, "TargetMesh");
		GetHasTriangleIDGaps_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetHasTriangleIDGaps_FunctionAddress, "TargetMesh");
		GetHasTriangleIDGaps_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHasTriangleIDGaps_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHasTriangleIDGaps_ReturnValue_PropertyAddress, GetHasTriangleIDGaps_FunctionAddress, "ReturnValue");
		GetHasTriangleIDGaps_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHasTriangleIDGaps_FunctionAddress, "ReturnValue");
		GetHasTriangleIDGaps_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHasTriangleIDGaps_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHasTriangleIDGaps_IsValid = GetHasTriangleIDGaps_FunctionAddress != IntPtr.Zero && GetHasTriangleIDGaps_TargetMesh_IsValid && GetHasTriangleIDGaps_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasTriangleIDGaps", GetHasTriangleIDGaps_IsValid);
		GetHasPolygroups_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHasPolygroups");
		GetHasPolygroups_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHasPolygroups_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHasPolygroups_TargetMesh_PropertyAddress, GetHasPolygroups_FunctionAddress, "TargetMesh");
		GetHasPolygroups_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetHasPolygroups_FunctionAddress, "TargetMesh");
		GetHasPolygroups_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHasPolygroups_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHasPolygroups_ReturnValue_PropertyAddress, GetHasPolygroups_FunctionAddress, "ReturnValue");
		GetHasPolygroups_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHasPolygroups_FunctionAddress, "ReturnValue");
		GetHasPolygroups_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHasPolygroups_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHasPolygroups_IsValid = GetHasPolygroups_FunctionAddress != IntPtr.Zero && GetHasPolygroups_TargetMesh_IsValid && GetHasPolygroups_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasPolygroups", GetHasPolygroups_IsValid);
		GetHasMaterialIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHasMaterialIDs");
		GetHasMaterialIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHasMaterialIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHasMaterialIDs_TargetMesh_PropertyAddress, GetHasMaterialIDs_FunctionAddress, "TargetMesh");
		GetHasMaterialIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetHasMaterialIDs_FunctionAddress, "TargetMesh");
		GetHasMaterialIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHasMaterialIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHasMaterialIDs_ReturnValue_PropertyAddress, GetHasMaterialIDs_FunctionAddress, "ReturnValue");
		GetHasMaterialIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHasMaterialIDs_FunctionAddress, "ReturnValue");
		GetHasMaterialIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHasMaterialIDs_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHasMaterialIDs_IsValid = GetHasMaterialIDs_FunctionAddress != IntPtr.Zero && GetHasMaterialIDs_TargetMesh_IsValid && GetHasMaterialIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetHasMaterialIDs", GetHasMaterialIDs_IsValid);
		GetAllVertexPositions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllVertexPositions");
		GetAllVertexPositions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllVertexPositions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllVertexPositions_TargetMesh_PropertyAddress, GetAllVertexPositions_FunctionAddress, "TargetMesh");
		GetAllVertexPositions_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetAllVertexPositions_FunctionAddress, "TargetMesh");
		GetAllVertexPositions_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllVertexPositions_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllVertexPositions_PositionList_PropertyAddress, GetAllVertexPositions_FunctionAddress, "PositionList");
		GetAllVertexPositions_PositionList_Offset = NativeReflectionCached.GetPropertyOffset(GetAllVertexPositions_FunctionAddress, "PositionList");
		GetAllVertexPositions_PositionList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllVertexPositions_FunctionAddress, "PositionList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllVertexPositions_bSkipGaps_PropertyAddress, GetAllVertexPositions_FunctionAddress, "bSkipGaps");
		GetAllVertexPositions_bSkipGaps_Offset = NativeReflectionCached.GetPropertyOffset(GetAllVertexPositions_FunctionAddress, "bSkipGaps");
		GetAllVertexPositions_bSkipGaps_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllVertexPositions_FunctionAddress, "bSkipGaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllVertexPositions_bHasVertexIDGaps_PropertyAddress, GetAllVertexPositions_FunctionAddress, "bHasVertexIDGaps");
		GetAllVertexPositions_bHasVertexIDGaps_Offset = NativeReflectionCached.GetPropertyOffset(GetAllVertexPositions_FunctionAddress, "bHasVertexIDGaps");
		GetAllVertexPositions_bHasVertexIDGaps_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllVertexPositions_FunctionAddress, "bHasVertexIDGaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllVertexPositions_ReturnValue_PropertyAddress, GetAllVertexPositions_FunctionAddress, "ReturnValue");
		GetAllVertexPositions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllVertexPositions_FunctionAddress, "ReturnValue");
		GetAllVertexPositions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllVertexPositions_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAllVertexPositions_IsValid = GetAllVertexPositions_FunctionAddress != IntPtr.Zero && GetAllVertexPositions_TargetMesh_IsValid && GetAllVertexPositions_PositionList_IsValid && GetAllVertexPositions_bSkipGaps_IsValid && GetAllVertexPositions_bHasVertexIDGaps_IsValid && GetAllVertexPositions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllVertexPositions", GetAllVertexPositions_IsValid);
		GetAllVertexIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllVertexIDs");
		GetAllVertexIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllVertexIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllVertexIDs_TargetMesh_PropertyAddress, GetAllVertexIDs_FunctionAddress, "TargetMesh");
		GetAllVertexIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetAllVertexIDs_FunctionAddress, "TargetMesh");
		GetAllVertexIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllVertexIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllVertexIDs_VertexIDList_PropertyAddress, GetAllVertexIDs_FunctionAddress, "VertexIDList");
		GetAllVertexIDs_VertexIDList_Offset = NativeReflectionCached.GetPropertyOffset(GetAllVertexIDs_FunctionAddress, "VertexIDList");
		GetAllVertexIDs_VertexIDList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllVertexIDs_FunctionAddress, "VertexIDList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllVertexIDs_bHasVertexIDGaps_PropertyAddress, GetAllVertexIDs_FunctionAddress, "bHasVertexIDGaps");
		GetAllVertexIDs_bHasVertexIDGaps_Offset = NativeReflectionCached.GetPropertyOffset(GetAllVertexIDs_FunctionAddress, "bHasVertexIDGaps");
		GetAllVertexIDs_bHasVertexIDGaps_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllVertexIDs_FunctionAddress, "bHasVertexIDGaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllVertexIDs_ReturnValue_PropertyAddress, GetAllVertexIDs_FunctionAddress, "ReturnValue");
		GetAllVertexIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllVertexIDs_FunctionAddress, "ReturnValue");
		GetAllVertexIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllVertexIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAllVertexIDs_IsValid = GetAllVertexIDs_FunctionAddress != IntPtr.Zero && GetAllVertexIDs_TargetMesh_IsValid && GetAllVertexIDs_VertexIDList_IsValid && GetAllVertexIDs_bHasVertexIDGaps_IsValid && GetAllVertexIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllVertexIDs", GetAllVertexIDs_IsValid);
		GetAllTriangleIndices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllTriangleIndices");
		GetAllTriangleIndices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllTriangleIndices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleIndices_TargetMesh_PropertyAddress, GetAllTriangleIndices_FunctionAddress, "TargetMesh");
		GetAllTriangleIndices_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleIndices_FunctionAddress, "TargetMesh");
		GetAllTriangleIndices_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleIndices_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleIndices_TriangleList_PropertyAddress, GetAllTriangleIndices_FunctionAddress, "TriangleList");
		GetAllTriangleIndices_TriangleList_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleIndices_FunctionAddress, "TriangleList");
		GetAllTriangleIndices_TriangleList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleIndices_FunctionAddress, "TriangleList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleIndices_bSkipGaps_PropertyAddress, GetAllTriangleIndices_FunctionAddress, "bSkipGaps");
		GetAllTriangleIndices_bSkipGaps_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleIndices_FunctionAddress, "bSkipGaps");
		GetAllTriangleIndices_bSkipGaps_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleIndices_FunctionAddress, "bSkipGaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleIndices_bHasTriangleIDGaps_PropertyAddress, GetAllTriangleIndices_FunctionAddress, "bHasTriangleIDGaps");
		GetAllTriangleIndices_bHasTriangleIDGaps_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleIndices_FunctionAddress, "bHasTriangleIDGaps");
		GetAllTriangleIndices_bHasTriangleIDGaps_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleIndices_FunctionAddress, "bHasTriangleIDGaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleIndices_ReturnValue_PropertyAddress, GetAllTriangleIndices_FunctionAddress, "ReturnValue");
		GetAllTriangleIndices_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleIndices_FunctionAddress, "ReturnValue");
		GetAllTriangleIndices_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleIndices_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAllTriangleIndices_IsValid = GetAllTriangleIndices_FunctionAddress != IntPtr.Zero && GetAllTriangleIndices_TargetMesh_IsValid && GetAllTriangleIndices_TriangleList_IsValid && GetAllTriangleIndices_bSkipGaps_IsValid && GetAllTriangleIndices_bHasTriangleIDGaps_IsValid && GetAllTriangleIndices_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllTriangleIndices", GetAllTriangleIndices_IsValid);
		GetAllTriangleIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllTriangleIDs");
		GetAllTriangleIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllTriangleIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleIDs_TargetMesh_PropertyAddress, GetAllTriangleIDs_FunctionAddress, "TargetMesh");
		GetAllTriangleIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleIDs_FunctionAddress, "TargetMesh");
		GetAllTriangleIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleIDs_TriangleIDList_PropertyAddress, GetAllTriangleIDs_FunctionAddress, "TriangleIDList");
		GetAllTriangleIDs_TriangleIDList_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleIDs_FunctionAddress, "TriangleIDList");
		GetAllTriangleIDs_TriangleIDList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleIDs_FunctionAddress, "TriangleIDList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleIDs_bHasTriangleIDGaps_PropertyAddress, GetAllTriangleIDs_FunctionAddress, "bHasTriangleIDGaps");
		GetAllTriangleIDs_bHasTriangleIDGaps_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleIDs_FunctionAddress, "bHasTriangleIDGaps");
		GetAllTriangleIDs_bHasTriangleIDGaps_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleIDs_FunctionAddress, "bHasTriangleIDGaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleIDs_ReturnValue_PropertyAddress, GetAllTriangleIDs_FunctionAddress, "ReturnValue");
		GetAllTriangleIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleIDs_FunctionAddress, "ReturnValue");
		GetAllTriangleIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAllTriangleIDs_IsValid = GetAllTriangleIDs_FunctionAddress != IntPtr.Zero && GetAllTriangleIDs_TargetMesh_IsValid && GetAllTriangleIDs_TriangleIDList_IsValid && GetAllTriangleIDs_bHasTriangleIDGaps_IsValid && GetAllTriangleIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshQueryFunctions:GetAllTriangleIDs", GetAllTriangleIDs_IsValid);
	}
}
