using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshQueries_CsExtensions
{
	public static bool IsValidVertexID(this UDynamicMesh TargetMesh, int VertexID)
	{
		return UGeometryScript_MeshQueries.IsValidVertexID(TargetMesh, VertexID);
	}

	public static bool IsValidTriangleID(this UDynamicMesh TargetMesh, int TriangleID)
	{
		return UGeometryScript_MeshQueries.IsValidTriangleID(TargetMesh, TriangleID);
	}

	public static FVector GetVertexPosition(this UDynamicMesh TargetMesh, int VertexID, out bool bIsValidVertex)
	{
		return UGeometryScript_MeshQueries.GetVertexPosition(TargetMesh, VertexID, out bIsValidVertex);
	}

	public static int GetVertexCount(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetVertexCount(TargetMesh);
	}

	public static FBox2D GetUVSetBoundingBox(this UDynamicMesh TargetMesh, int UVSetIndex, out bool bIsValidUVSet, out bool bUVSetIsEmpty)
	{
		return UGeometryScript_MeshQueries.GetUVSetBoundingBox(TargetMesh, UVSetIndex, out bIsValidUVSet, out bUVSetIsEmpty);
	}

	public static void GetTriangleUVs(this UDynamicMesh TargetMesh, int UVSetIndex, int TriangleID, out FVector2D UV1, out FVector2D UV2, out FVector2D UV3, out bool bHaveValidUVs)
	{
		UGeometryScript_MeshQueries.GetTriangleUVs(TargetMesh, UVSetIndex, TriangleID, out UV1, out UV2, out UV3, out bHaveValidUVs);
	}

	public static void GetTrianglePositions(this UDynamicMesh TargetMesh, int TriangleID, out bool bIsValidTriangle, out FVector Vertex1, out FVector Vertex2, out FVector Vertex3)
	{
		UGeometryScript_MeshQueries.GetTrianglePositions(TargetMesh, TriangleID, out bIsValidTriangle, out Vertex1, out Vertex2, out Vertex3);
	}

	public static FIntVector GetTriangleIndices(this UDynamicMesh TargetMesh, int TriangleID, out bool bIsValidTriangle)
	{
		return UGeometryScript_MeshQueries.GetTriangleIndices(TargetMesh, TriangleID, out bIsValidTriangle);
	}

	public static FVector GetTriangleFaceNormal(this UDynamicMesh TargetMesh, int TriangleID, out bool bIsValidTriangle)
	{
		return UGeometryScript_MeshQueries.GetTriangleFaceNormal(TargetMesh, TriangleID, out bIsValidTriangle);
	}

	public static int GetNumVertexIDs(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetNumVertexIDs(TargetMesh);
	}

	public static int GetNumUVSets(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetNumUVSets(TargetMesh);
	}

	public static int GetNumTriangleIDs(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetNumTriangleIDs(TargetMesh);
	}

	public static int GetNumOpenBorderLoops(this UDynamicMesh TargetMesh, out bool bAmbiguousTopologyFound)
	{
		return UGeometryScript_MeshQueries.GetNumOpenBorderLoops(TargetMesh, out bAmbiguousTopologyFound);
	}

	public static int GetNumOpenBorderEdges(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetNumOpenBorderEdges(TargetMesh);
	}

	public static int GetNumExtendedPolygroupLayers(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetNumExtendedPolygroupLayers(TargetMesh);
	}

	public static int GetNumConnectedComponents(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetNumConnectedComponents(TargetMesh);
	}

	public static void GetMeshVolumeArea(this UDynamicMesh TargetMesh, out float SurfaceArea, out float Volume)
	{
		UGeometryScript_MeshQueries.GetMeshVolumeArea(TargetMesh, out SurfaceArea, out Volume);
	}

	public static bool GetMeshHasAttributeSet(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetMeshHasAttributeSet(TargetMesh);
	}

	public static FBox GetMeshBoundingBox(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetMeshBoundingBox(TargetMesh);
	}

	public static bool GetIsDenseMesh(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetIsDenseMesh(TargetMesh);
	}

	public static bool GetIsClosedMesh(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetIsClosedMesh(TargetMesh);
	}

	public static bool GetHasVertexIDGaps(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetHasVertexIDGaps(TargetMesh);
	}

	public static bool GetHasTriangleIDGaps(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetHasTriangleIDGaps(TargetMesh);
	}

	public static bool GetHasPolygroups(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetHasPolygroups(TargetMesh);
	}

	public static bool GetHasMaterialIDs(this UDynamicMesh TargetMesh)
	{
		return UGeometryScript_MeshQueries.GetHasMaterialIDs(TargetMesh);
	}

	public static UDynamicMesh GetAllVertexPositions(this UDynamicMesh TargetMesh, out FGeometryScriptVectorList PositionList, bool bSkipGaps, out bool bHasVertexIDGaps)
	{
		return UGeometryScript_MeshQueries.GetAllVertexPositions(TargetMesh, out PositionList, bSkipGaps, out bHasVertexIDGaps);
	}

	public static UDynamicMesh GetAllVertexIDs(this UDynamicMesh TargetMesh, out FGeometryScriptIndexList VertexIDList, out bool bHasVertexIDGaps)
	{
		return UGeometryScript_MeshQueries.GetAllVertexIDs(TargetMesh, out VertexIDList, out bHasVertexIDGaps);
	}

	public static UDynamicMesh GetAllTriangleIndices(this UDynamicMesh TargetMesh, out FGeometryScriptTriangleList TriangleList, bool bSkipGaps, out bool bHasTriangleIDGaps)
	{
		return UGeometryScript_MeshQueries.GetAllTriangleIndices(TargetMesh, out TriangleList, bSkipGaps, out bHasTriangleIDGaps);
	}

	public static UDynamicMesh GetAllTriangleIDs(this UDynamicMesh TargetMesh, out FGeometryScriptIndexList TriangleIDList, out bool bHasTriangleIDGaps)
	{
		return UGeometryScript_MeshQueries.GetAllTriangleIDs(TargetMesh, out TriangleIDList, out bHasTriangleIDGaps);
	}
}
