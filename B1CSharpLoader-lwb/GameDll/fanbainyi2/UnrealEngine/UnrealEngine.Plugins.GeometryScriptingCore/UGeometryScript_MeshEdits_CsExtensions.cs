using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshEdits_CsExtensions
{
	public static UDynamicMesh SetVertexPosition(this UDynamicMesh TargetMesh, int VertexID, FVector NewPosition, out bool bIsValidVertex, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_MeshEdits.SetVertexPosition(TargetMesh, VertexID, NewPosition, out bIsValidVertex, bDeferChangeNotifications);
	}

	public static UDynamicMesh DiscardMeshAttributes(this UDynamicMesh TargetMesh, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_MeshEdits.DiscardMeshAttributes(TargetMesh, bDeferChangeNotifications);
	}

	public static UDynamicMesh DeleteVerticesFromMesh(this UDynamicMesh TargetMesh, FGeometryScriptIndexList VertexList, out int NumDeleted, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_MeshEdits.DeleteVerticesFromMesh(TargetMesh, VertexList, out NumDeleted, bDeferChangeNotifications);
	}

	public static UDynamicMesh DeleteVertexFromMesh(this UDynamicMesh TargetMesh, int VertexID, out bool bWasVertexDeleted, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_MeshEdits.DeleteVertexFromMesh(TargetMesh, VertexID, out bWasVertexDeleted, bDeferChangeNotifications);
	}

	public static UDynamicMesh DeleteTrianglesFromMesh(this UDynamicMesh TargetMesh, FGeometryScriptIndexList TriangleList, out int NumDeleted, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_MeshEdits.DeleteTrianglesFromMesh(TargetMesh, TriangleList, out NumDeleted, bDeferChangeNotifications);
	}

	public static UDynamicMesh DeleteTriangleFromMesh(this UDynamicMesh TargetMesh, int TriangleID, out bool bWasTriangleDeleted, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_MeshEdits.DeleteTriangleFromMesh(TargetMesh, TriangleID, out bWasTriangleDeleted, bDeferChangeNotifications);
	}

	public static UDynamicMesh AppendMeshRepeated(this UDynamicMesh TargetMesh, UDynamicMesh AppendMesh, FTransform AppendTransform, int RepeatCount, bool bApplyTransformToFirstInstance, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshEdits.AppendMeshRepeated(TargetMesh, AppendMesh, AppendTransform, RepeatCount, bApplyTransformToFirstInstance, bDeferChangeNotifications, Debug);
	}

	public static UDynamicMesh AppendMesh(this UDynamicMesh TargetMesh, UDynamicMesh AppendMesh, FTransform AppendTransform, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshEdits.AppendMesh(TargetMesh, AppendMesh, AppendTransform, bDeferChangeNotifications, Debug);
	}

	public static UDynamicMesh AppendBuffersToMesh(this UDynamicMesh TargetMesh, FGeometryScriptSimpleMeshBuffers Buffers, out FGeometryScriptIndexList NewTriangleIndicesList, int MaterialID, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshEdits.AppendBuffersToMesh(TargetMesh, Buffers, out NewTriangleIndicesList, MaterialID, bDeferChangeNotifications, Debug);
	}

	public static UDynamicMesh AddVerticesToMesh(this UDynamicMesh TargetMesh, FGeometryScriptVectorList NewPositionsList, out FGeometryScriptIndexList NewIndicesList, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_MeshEdits.AddVerticesToMesh(TargetMesh, NewPositionsList, out NewIndicesList, bDeferChangeNotifications);
	}

	public static UDynamicMesh AddVertexToMesh(this UDynamicMesh TargetMesh, FVector NewPosition, out int NewVertexIndex, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_MeshEdits.AddVertexToMesh(TargetMesh, NewPosition, out NewVertexIndex, bDeferChangeNotifications);
	}

	public static UDynamicMesh AddTriangleToMesh(this UDynamicMesh TargetMesh, FIntVector NewTriangle, out int NewTriangleIndex, int NewTriangleGroupID, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshEdits.AddTriangleToMesh(TargetMesh, NewTriangle, out NewTriangleIndex, NewTriangleGroupID, bDeferChangeNotifications, Debug);
	}

	public static UDynamicMesh AddTrianglesToMesh(this UDynamicMesh TargetMesh, FGeometryScriptTriangleList NewTrianglesList, out FGeometryScriptIndexList NewIndicesList, int NewTriangleGroupID, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshEdits.AddTrianglesToMesh(TargetMesh, NewTrianglesList, out NewIndicesList, NewTriangleGroupID, bDeferChangeNotifications, Debug);
	}
}
